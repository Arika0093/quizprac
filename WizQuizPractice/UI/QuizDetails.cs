using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

using WizQuizPractice.Class;

namespace WizQuizPractice.UI
{
	public partial class QuizDetails : Form
	{
		MyQAList Mqa;
		List<MyQstAns> SortQa;

		public QuizDetails(MyQAList mqa)
		{
			InitializeComponent();
			Mqa = mqa;
		}

		private void QuizDetails_Load(object sender, EventArgs e)
		{
			SortQa = (from qa in Mqa.mqa
					 orderby qa.IsCorrect, qa.q.Diff descending
					 select qa).ToList();
			foreach(var qa in SortQa) {
				var Params = new string[]{
					qa.q.Question,
					qa.q.Genre,
					qa.q.Diff + "色",
					qa.q.Answer,
					qa.SelAns
				};
				var LstItem = new ListViewItem(Params);
				if(!qa.IsCorrect) {
					LstItem.ForeColor = Color.OrangeRed;
					LstItem.Checked = true;
				}
				listView1.Items.Add(LstItem);
			}
		}

		// Save
		private void button1_Click(object sender, EventArgs e)
		{
			// Get selected indexes
			var CheckedQaList = new List<MyQstAns>();
			var Indexes = (from s in listView1.Items.Cast<ListViewItem>()
						  where s.Checked
						  select s.Index).ToArray();
			if(Indexes.Count() <= 0) {
				// ERROR
				MessageBox.Show("チェックが付けられた項目が存在しません。");
				return;
			}
			for(int i = 0; i < SortQa.Count; i++) {
				if(Array.IndexOf(Indexes, i) >= 0) {
					CheckedQaList.Add(SortQa[i]);
				}
			}
			QuizSaveToBook(CheckedQaList);
		}

		public static void QuizSaveToBook(List<MyQstAns> qs)
		{
			if(qs.Count <= 0) {
				return;
			}
			// filename
			var n = DateTime.Now;
			var f = String.Format("{0}{1:D2}{2:D2}_{3:D2}{4:D2}.xml",
						n.Year, n.Month, n.Day, n.Hour, n.Minute);
			// Save
			XmlSerializer Xs = new XmlSerializer(typeof(List<MyQstAns>));
			StreamWriter Sw = new StreamWriter("Books/" + f);
			Xs.Serialize(Sw, qs);
			Sw.Close();
			// Success
			MessageBox.Show("問題帳を作成しました。\r\nファイル名: " + f + "\r\n問題数: " + qs.Count().ToString());
		}
	}
}
