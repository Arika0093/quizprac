using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WizQuizPractice.Class;

namespace WizQuizPractice.UI
{
	public partial class QuizResult : Form
	{
		// const str
		private const string DoublePerFormat = "##0.0";

		// const color
		private Color Over90Per = Color.DodgerBlue;
		private Color Under50Per = Color.Orange;
		private Color Under30Per = Color.Red;

		// Quizs
		private MyQAList Mqa;

		public QuizResult(MyQAList mqa)
		{
			InitializeComponent();
			Mqa = mqa;
		}

		// @load
		private void QuizResult_Load(object sender, EventArgs e)
		{
			var Curs = from qa in Mqa.mqa
					   where qa.IsCorrect
					   select qa.LimitTime;
			// Basic
			TraningRst.Text = "今回の練習結果 (練習問題数: " + Mqa.mqa.Count + "問)";
			AnsRate.Text = Mqa.GetMyAnsRate() + "%";
			toolTip1.SetToolTip(AnsRate, String.Format("{1}/{0}問正解", Mqa.mqa.Count, Curs.Count()));
			if(Curs.Count() > 0) {
				AnsTime.Text = (WQPSetting.LimitTime - Curs.Average()).ToString("#0.00") + "s";
			}
			ExcNum.Text = Mqa.GetMyExcellentNum() + "問";
			toolTip1.SetToolTip(ExcNum, String.Format("{1}/{0}問", Mqa.GetMyExcellentNum(), Curs.Count()));
			// Genre,Diff
			GenreDiffCorrRateShow(ref B1, "文系", 1);
			GenreDiffCorrRateShow(ref B2, "文系", 2);
			GenreDiffCorrRateShow(ref B3, "文系", 3);
			GenreDiffCorrRateShow(ref R1, "理系", 1);
			GenreDiffCorrRateShow(ref R2, "理系", 2);
			GenreDiffCorrRateShow(ref R3, "理系", 3);
			GenreDiffCorrRateShow(ref Z1, "雑学", 1);
			GenreDiffCorrRateShow(ref Z2, "雑学", 2);
			GenreDiffCorrRateShow(ref Z3, "雑学", 3);
			GenreDiffCorrRateShow(ref G1, "芸能", 1);
			GenreDiffCorrRateShow(ref G2, "芸能", 2);
			GenreDiffCorrRateShow(ref G3, "芸能", 3);
			GenreDiffCorrRateShow(ref S1, "スポーツ", 1);
			GenreDiffCorrRateShow(ref S2, "スポーツ", 2);
			GenreDiffCorrRateShow(ref S3, "スポーツ", 3);
			GenreDiffCorrRateShow(ref A1, "アニメゲーム", 1);
			GenreDiffCorrRateShow(ref A2, "アニメゲーム", 2);
			GenreDiffCorrRateShow(ref A3, "アニメゲーム", 3);
		}

		// close
		private void OK_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void GenreDiffCorrRateShow(ref Label l, string gen, int diff)
		{
			// get count
			var Base = from qa in Mqa.mqa
					   where qa.q.Genre.IndexOf(gen) >= 0 && qa.q.Diff == diff
					   select Mqa;
			var Anss = from qa in Mqa.mqa
					   where qa.q.Genre.IndexOf(gen)>=0 && qa.q.Diff == diff && qa.IsCorrect
					   select Mqa;
			// calc rate
			if(Base.Count() != 0) {
				double Rate = (double)Anss.Count() * 100 / Base.Count();
				// accept
				l.Text = Rate.ToString(DoublePerFormat) + "%";
				toolTip1.SetToolTip(l, String.Format("{1}/{0}問正解", Base.Count(), Anss.Count()));
				RateColorChange(ref l, Rate);
			}
			else {
				l.Text = "---.-%";
			}
		}

		private void RateColorChange(ref Label l, double Rate)
		{
			if(Rate >= 90) {
				l.ForeColor = Over90Per;
			}
			else if(Rate <= 30) {
				l.ForeColor = Under30Per;
			}
			else if(Rate <= 50) {
				l.ForeColor = Under50Per;
			}
		}

		private void QuizDetailsCheck_Click(object sender, EventArgs e)
		{
			new QuizDetails(Mqa).ShowDialog();
		}
	}
}
