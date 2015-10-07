using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WizQuizPractice.UI;
using WizQuizPractice.Class;

namespace WizQuizPractice
{
	public partial class Main : Form
	{
		private List<Quiz> ShowQuizs;
		private int Qcount = 0;
		private MyQAList Mqa;
		private string QuizAnswer;
		private System.Threading.Timer QuizTimer;
		private const int TimerInterval = 6;

		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			Status_LoadQst.Text = "読み込んだ問題数: " + QuizManage.Quizs.Count.ToString();
			tableLayoutPanel1.Enabled = false;
		}

		private void 問題の取得更新ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var DlForm = new QuizDownload();
			DlForm.ShowDialog();
			// Reload
			Main_Load(null, null);
		}

		private void 問題の読み込みOToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "quizfile(*.xml)|*.xml|all files(*.*)|*.*";
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
			// Menu/Item Enable Change
			問題の取得更新ToolStripMenuItem.Enabled = false;
			問題の読み込みOToolStripMenuItem.Enabled = false;
			練習モードを開始SToolStripMenuItem.Enabled = false;
			練習モードを終了EToolStripMenuItem.Enabled = true;
			tableLayoutPanel1.Enabled = true;

			// Get Quizs at random
			ShowQuizs = (from q in QuizManage.Quizs
						 where q.IsEnabledSelections == true
						 orderby Guid.NewGuid()
						 select q).ToList();
			// and etc
			Mqa = new MyQAList();
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
			練習モードを終了EToolStripMenuItem.Enabled = false;
			tableLayoutPanel1.Enabled = false;

			// Timer Dispose
			if(QuizTimer != null) {
				QuizTimer.Dispose();
			}
			selfDrawProgressBar1.ForeColor = Color.DodgerBlue;
			selfDrawProgressBar1.Value = 2000;
			// count reset
			Qcount = 0;
			// Show Result
			new QuizResult(Mqa).ShowDialog();
		}

		// Quiz Show
		private void QuizShow()
		{
			// count add
			Qcount += 1;
			// time reset
			selfDrawProgressBar1.Value = 2000;
			// enable reset
			button1.Enabled =
			button2.Enabled =
			button3.Enabled =
			button4.Enabled = true;
			// new quiz
			Quiz q = ShowQuizs[Qcount];
			// Info Bar
			label2.Text = String.Format("第 {0} 問 (現在の正答率: {1}% / Excellent: {2}問)",
				Qcount, Mqa.GetMyAnsRate(), Mqa.GetMyExcellentNum().ToString());
			// Question
			Question.Text
				= String.Format("[{0} / {1}色問題]\r\n{2}", q.Genre, q.Diff, q.Question);
			// Selections
			var Sels = q.GetChoicesStringsRandom();
			button1.Text = Sels[0];
			button2.Text = Sels[1];
			button3.Text = Sels[2];
			button4.Text = Sels[3];
			// Answer
			QuizAnswer = q.Answer;
			// Timer Create
			QuizTimer = new System.Threading.Timer(Timer_Tick, null, 0, TimerInterval * 10);
		}

		private void QuizAnswerClick(string SelAnswer)
		{
			if(QuizTimer != null) {
				QuizTimer.Dispose();
				// answer data
				MyQstAns mq = new MyQstAns();
				mq.q = ShowQuizs[Qcount];
				mq.SelAns = SelAnswer;
				mq.IsCorrect = (SelAnswer == QuizAnswer);
				mq.LimitTime = (double)selfDrawProgressBar1.Value / 100;
				// add
				Mqa.DataAdd(mq);
				// if miss quiz
				if(!mq.IsCorrect) {
					// quizmiss show
					QuizMiss();
					return;
				}
			}
			// new quiz
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
			int val = Math.Max(selfDrawProgressBar1.Value - TimerInterval, 0);
			selfDrawProgressBar1.Value = val;
			// Color Change
			if(val >= 1500) {
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
			new About().ShowDialog();
		}

		private void 問題検索ダイアログを開くDToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new QuizSearch().Show();
		}
	}
}
