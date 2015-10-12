using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using WizQuizPractice.Class;

namespace WizQuizPractice.UI
{
	public partial class QuizTerm : Form
	{
		// 出題する問題の出典(nullで全問題から出題)
		public string QuizBook = null;
		// 出題する問題のレートの最大値(nullで指定しない)
		public int? ShowRate = 0;
		// 出題する問題の正解率の最大値(nullで指定しない)
		public uint? AnsRate = 100;
		// 出題する問題の出題回数の最大値/最小値(nullで指定しない)
		public uint? MaxShow = null;
		public uint? MinShow = null;
		// 出題する問題数(nullで指定しない)
		public int? ShowCount = null;
		// 出題する問題の難易度
		public bool Diff1 = true;	// 単色
		public bool Diff2 = true;	// 二色
		public bool Diff3 = true;	// 三色
		// 出題する問題のジャンル
		public bool GenreB = true;	// 文系
		public bool GenreR = true;	// 理系
		public bool GenreG = true;	// 芸能
		public bool GenreZ = true;	// 雑学
		public bool GenreS = true;	// スポーツ
		public bool GenreA = true;	// アニメゲーム
		// 死亡条件
		public Func<MyQAList, bool> Deadterm = p => true;

		public QuizTerm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// ダイアログで指定された条件に一致する問題を抽出し返却します。
		/// </summary>
		/// <returns>抽出された問題の一覧 / 選択されなかった場合null</returns>
		public List<Quiz> QuizExtractWithTerm(IWin32Window f)
		{
			List<Quiz> lq;
			// Show Dialog
			if(ShowDialog(f) != DialogResult.OK) {
				return null;
			}
			// Load
			if(QuizBook != null) {
				// Open
				var mql = new MyQAList();
				mql.XmlLoad("Books/" + QuizBook);
				lq = (from qa in QuizManage.Quizs
					  where mql.mqa.Exists(p => p.q.QuizID == qa.QuizID)
					  select qa).ToList();
			}
			else {
				lq = QuizManage.Quizs;
			}
			QuizManage.LoadAnswerData();

			// Extract
			var ls = from q in lq
					 where _IsMatchQuiz(q) && q.IsEnabledSelections
					 orderby Guid.NewGuid()
					 select q;
			if(ShowCount != null) {
				ls = ls.Take(ShowCount.Value).OrderBy(a => true);
			}
			return ls.ToList();
		}

		// 条件に一致するかどうかを返却
		private bool _IsMatchQuiz(Quiz q)
		{
			var Ad = q.AData;
			return (ShowRate == null || Ad.Rate <= ShowRate.Value)
				&& (MaxShow == null || Ad.QstNumber <= MaxShow)
				&& (MinShow == null || Ad.QstNumber >= MinShow)
				&& (AnsRate == null || (Ad.QstNumber > 0 && (double)Ad.AnsNumber/Ad.QstNumber*100 <= AnsRate.Value))
				&& ((q.Diff == 1 && Diff1) || (q.Diff == 2 && Diff2) || (q.Diff == 3 && Diff3))
				&& (
					(GenreB && q.Genre.IndexOf("文系") >= 0) ||
					(GenreR && q.Genre.IndexOf("理系") >= 0) ||
					(GenreG && q.Genre.IndexOf("芸能") >= 0) ||
					(GenreZ && q.Genre.IndexOf("雑学") >= 0) ||
					(GenreS && q.Genre.IndexOf("スポーツ") >= 0) ||
					(GenreA && q.Genre.IndexOf("アニメゲーム") >= 0)
				);
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			numericUpDown1.Enabled = !checkBox1.Checked;
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			numericUpDown2.Enabled = !checkBox2.Checked;
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			numericUpDown3.Enabled = !checkBox3.Checked;
		}

		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			numericUpDown4.Enabled = !checkBox4.Checked;
		}

		private void checkBox14_CheckedChanged(object sender, EventArgs e)
		{
			numericUpDown5.Enabled = !checkBox14.Checked;
		}

		private void numericUpDown2_ValueChanged(object sender, EventArgs e)
		{
			// 最小値 > 最大値となった場合に最大値のほうを合わせる
			if(numericUpDown2.Value > numericUpDown3.Value) {
				numericUpDown3.Value = numericUpDown2.Value;
			}
		}

		private void numericUpDown3_ValueChanged(object sender, EventArgs e)
		{
			// 最小値 > 最大値となった場合に最小値のほうを合わせる
			if(numericUpDown2.Value > numericUpDown3.Value) {
				numericUpDown2.Value = numericUpDown3.Value;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// State get
			QuizBook = comboBox1.SelectedIndex == 0 ? null : (string)comboBox1.Items[comboBox1.SelectedIndex];
			ShowRate = (checkBox1.Checked ? null : (int?)numericUpDown1.Value);
			MinShow = (checkBox2.Checked ? null : (uint?)numericUpDown2.Value);
			MaxShow = (checkBox3.Checked ? null : (uint?)numericUpDown3.Value);
			AnsRate = (checkBox4.Checked ? null : (uint?)numericUpDown4.Value);
			ShowCount = (checkBox14.Checked ? null : (int?)numericUpDown5.Value);
			Diff1 = checkBox5.Checked;
			Diff2 = checkBox6.Checked;
			Diff3 = checkBox7.Checked;
			GenreB = checkBox8.Checked;
			GenreR = checkBox9.Checked;
			GenreG = checkBox10.Checked;
			GenreZ = checkBox11.Checked;
			GenreS = checkBox12.Checked;
			GenreA = checkBox13.Checked;
			Deadterm = QuizDeadterms.Lqdt[comboBox2.SelectedIndex].Check;
			// Close
			DialogResult = DialogResult.OK;
			Close();
		}

		private void QuizTerm_Load(object sender, EventArgs e)
		{
			// quizbook
			var qbs = Directory.GetFiles("Books/", "*.xml", SearchOption.TopDirectoryOnly);
			foreach(var qb in qbs) {
				comboBox1.Items.Add(Path.GetFileName(qb));
			}
			comboBox1.SelectedIndex = 0;
			// deadterm
			foreach(var dt in QuizDeadterms.Lqdt) {
				comboBox2.Items.Add(dt.Info);
			}
			comboBox2.SelectedIndex = 0;
		}
	}
}
