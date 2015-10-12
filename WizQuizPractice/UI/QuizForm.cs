using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

using WizQuizPractice.UI;
using WizQuizPractice.Class;

namespace WizQuizPractice
{
	public partial class Main : Form
	{
		// 表示するクイズを取得してここに入れる
		private List<Quiz> ShowQuizs;
		// 現在の出題問題数
		private int Qcount;
		// 回答結果をこの中に入れる
		private MyQAList Mqa;
		// 回答を一時的にこの変数に保持する
		private string QuizAnswer;
		// クイズの残り時間を管理
		private System.Threading.Timer QuizTimer;
		// 練習モード続行条件
		private Func<MyQAList, bool> Dt = p => true;
		// -------------------------------

		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			// Error Ignore
			SelfDrawProgressBar.CheckForIllegalCrossThreadCalls = false;
			// Menu
			問題の取得更新ToolStripMenuItem.Visible = WQPSetting.QuizDownloadShow;
			// Statusbar
			Status_LoadQst.Text = "読み込んだ問題数: " + QuizManage.Quizs.Count.ToString();
			// Mainpanel
			tableLayoutPanel1.Enabled = false;
		}

		private void 問題の取得更新ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var DlForm = new QuizDownload();
			DlForm.ShowDialog(this);
			// Reload
			Main_Load(null, null);
		}

		private void 問題の読み込みOToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.FileName = Path.GetFileName(QuizManage.Quizfilepath);
			ofd.InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			ofd.Filter = "Quizfile|Quizzes.xml|all files(*.*)|*.*";
			if(ofd.ShowDialog() == DialogResult.OK) {
				QuizManage.Quizfilepath = ofd.FileName;
				QuizManage.Load();
				// Reload
				Main_Load(null, null);
			}
		}

		// Start
		private void 練習モードを開始SToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Get Quizs at random
			ShowQuizs = (from q in QuizManage.Quizs
						 where q.IsEnabledSelections && q.Genre.IndexOf("イベント")<=-1
						 orderby Guid.NewGuid()
						 select q).ToList();
			// Init
			StartTraningMode();
		}

		private void 過去の出題問題から練習RToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Load
			QuizManage.LoadAnswerData();
			ShowQuizs = (from q in QuizManage.Quizs
						 where q.AData != null && q.AData.QstNumber > 0
						 orderby Guid.NewGuid()
						 select q).ToList();
			StartTraningMode();
		}

		private void 問題帳から練習を開始BToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Open QuizFile
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Books\\";
			ofd.Filter = "quizfile(*.xml)|*.xml|all files(*.*)|*.*";
			if(ofd.ShowDialog() == DialogResult.OK) {
				// Load
				var mql = new MyQAList();
				mql.XmlLoad(ofd.FileName);
				ShowQuizs = (from qa in QuizManage.Quizs
							 where mql.mqa.Exists(p => p.q.QuizID == qa.QuizID)
							 select qa).ToList();
				QuizManage.LoadAnswerData();
				StartTraningMode();
			}
		}

		private void 表示問題の条件を指定して開始ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Get
			var qt = new QuizTerm();
			ShowQuizs = qt.QuizExtractWithTerm(this);
			if(ShowQuizs != null) {
				Dt = qt.Deadterm;
				StartTraningMode();
			}
		}

		private void StartTraningMode()
		{
			// Menu/Item Enable Change
			問題の取得更新ToolStripMenuItem.Enabled = false;
			問題の読み込みOToolStripMenuItem.Enabled = false;
			練習モードを開始SToolStripMenuItem.Enabled = false;
			過去の出題問題から練習RToolStripMenuItem.Enabled = false;
			表示問題の条件を指定して開始ToolStripMenuItem.Enabled = false;
			問題帳から練習を開始BToolStripMenuItem.Enabled = false;
			練習モードを終了EToolStripMenuItem.Enabled = true;
			tableLayoutPanel1.Enabled = true;
			// and etc
			Status_LoadQst.Text = "読み込んだ問題数: " + ShowQuizs.Count;
			selfDrawProgressBar1.Maximum = (int)Math.Max(WQPSetting.LimitTime * 100, 2000);
			Mqa = new MyQAList();
			Qcount = -1;
			// Show
			QuizShow();
		}

		// Finish
		private void 練習モードを終了EToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Menu/Item Enable Change
			問題の取得更新ToolStripMenuItem.Enabled = true;
			問題の読み込みOToolStripMenuItem.Enabled = true;
			練習モードを開始SToolStripMenuItem.Enabled = true;
			過去の出題問題から練習RToolStripMenuItem.Enabled = true;
			表示問題の条件を指定して開始ToolStripMenuItem.Enabled = true;
			問題帳から練習を開始BToolStripMenuItem.Enabled = true;
			練習モードを終了EToolStripMenuItem.Enabled = false;
			tableLayoutPanel1.Enabled = false;

			// Timer Dispose
			if(QuizTimer != null) {
				QuizTimer.Dispose();
			}
			selfDrawProgressBar1.ForeColor = Color.DodgerBlue;
			selfDrawProgressBar1.Value = (int)(WQPSetting.LimitTime * 100);
			// count reset
			Qcount = 0;
			// Show Result
			new QuizResult(Mqa).ShowDialog(this);
			// Save
			QuizManage.SaveAnswerData();
		}

		// Quiz Show
		private void QuizShow()
		{
			// count add
			Qcount += 1;
			// If Over Limit
			if(Qcount >= ShowQuizs.Count) {
				// Quiz End
				練習モードを終了EToolStripMenuItem_Click(null, null);
				return;
			}
			// time reset
			selfDrawProgressBar1.Value = (int)(WQPSetting.LimitTime * 100);
			// enable reset
			button1.Enabled =
			button2.Enabled =
			button3.Enabled =
			button4.Enabled = true;
			// new quiz
			Quiz q = ShowQuizs[Qcount];
			// Info Bar
			label2.Text = String.Format("第 {0} 問 (現在の正答率: {1}% / Excellent: {2}問)",
				Qcount + 1, (Mqa.GetMyAnsRate() ?? 0).ToString("##0.0"), Mqa.GetMyExcellentNum().ToString());
			// Question
			if(q.AData != null && q.AData.QstNumber > 0) {
				Question.Text
					= String.Format("[{0} / {1}色問題] [正解回数: {3}/{4}回]\r\n{2}",
						q.Genre, q.Diff, q.Question, q.AData.AnsNumber, q.AData.QstNumber);
			}
			else {
				Question.Text
					= String.Format("[{0} / {1}色問題]\r\n{2}", q.Genre, q.Diff, q.Question);
			}

			// Selections
			var Sels = q.GetChoicesStringsRandom();
			button1.Text = Sels[0];
			button2.Text = Sels[1];
			button3.Text = Sels[2];
			button4.Text = Sels[3];
			// Answer
			QuizAnswer = q.Answer;
			// Timer Create
			QuizTimer = new System.Threading.Timer(Timer_Tick, null, 0, WQPSetting.TimerRefresh);
		}

		private void QuizAnswerClick(string SelAnswer)
		{
			if(QuizTimer != null) {
				QuizTimer.Dispose();
				// myQA
				MyQstAns mq = new MyQstAns();
				Quiz q = ShowQuizs[Qcount];
				mq.q = q;
				mq.SelAns = SelAnswer;
				mq.IsCorrect = (SelAnswer == QuizAnswer);
				mq.LimitTime = (double)selfDrawProgressBar1.Value / 100;
				// answer data
				if(q.AData == null) {
					q.AData = new AnswerData();
				}
				q.AData.QstNumber += 1;
				q.AData.AnsNumber += (uint)(mq.IsCorrect ? 1 : 0);
				q.AData.RateChange(mq.IsCorrect);
				// add
				Mqa.DataAdd(mq);
				// if miss quiz
				if(!mq.IsCorrect) {
					// quizmiss show
					QuizMiss();
					return;
				}
			}
			// Deadterm check
			if(!Dt(Mqa)) {
				// end
				練習モードを終了EToolStripMenuItem_Click(null, null);
				return;
			}
			QuizShow();
		}

		private void QuizMiss()
		{
			// add answer
			Question.Text += "\r\n\r\n正解: " + QuizAnswer;
			Question.Select(0, 0);
			// enable change
			button1.Enabled = button1.Text == QuizAnswer;
			button2.Enabled = button2.Text == QuizAnswer;
			button3.Enabled = button3.Text == QuizAnswer;
			button4.Enabled = button4.Text == QuizAnswer;
			// Timer Delete
			QuizTimer = null;
		}

		private void Timer_Tick(object o)
		{
			// Time minus
			int val = Math.Max(selfDrawProgressBar1.Value - WQPSetting.TimerRefresh/10, 0);
			selfDrawProgressBar1.Value = val;
			// Color Change
			if(val >= WQPSetting.ExcellentTime*100) {
				selfDrawProgressBar1.ForeColor = Color.DodgerBlue;
			}
			else if(val >= 1000) {
				selfDrawProgressBar1.ForeColor = Color.LimeGreen;
			}
			else if(val >= 500) {
				selfDrawProgressBar1.ForeColor = Color.Gold;
			}
			else {
				selfDrawProgressBar1.ForeColor = Color.Crimson;
			}
			// if timeover
			if(val <= 0) {
				QuizAnswerClick("");
			}
			// ReDraw
			selfDrawProgressBar1.Refresh();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			QuizAnswerClick(button1.Text);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			QuizAnswerClick(button2.Text);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			QuizAnswerClick(button3.Text);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			QuizAnswerClick(button4.Text);
		}

		private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void このアプリについてAToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new About().ShowDialog(this);
		}

		private void 問題検索ダイアログを開くDToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new QuizSearch().Show(this);
		}

		private void 問題を自動的に問題帳へ保存SToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var chkd = !問題を自動的に問題帳へ保存SToolStripMenuItem.Checked;
			問題を自動的に問題帳へ保存SToolStripMenuItem.Checked = chkd;
			WQPSetting.IsAutoSaveMissQuiz = chkd;
		}
	}
}
