﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using WizQuizPractice.Class;

namespace WizQuizPractice.UI
{
	public partial class QuizSearch : Form
	{
		public QuizSearch()
		{
			InitializeComponent();
			GenreCombo.SelectedIndex = 0;
			DiffCombo.SelectedIndex = 0;
		}

		// Search Quiz
		private void SearchBtn_Click(object sender, EventArgs e)
		{
			// Search
			var Spls = SearchBox.Text.Split(new char[] { ' ', }, StringSplitOptions.RemoveEmptyEntries);
			var Srcs = from q in QuizManage.Quizs
					   where SearchCheck(q, Spls,
							 (GenreCombo.SelectedIndex > 0 ? GenreCombo.Text : ""),
							 DiffCombo.SelectedIndex)
					   orderby q.Diff descending, q.Genre descending
					   select q;
			// Add listbox
			listView1.Items.Clear();
			foreach(var Src in Srcs) {
				var lststrs = new string[] {
					Src.Question,
					Src.Answer,
					Src.Genre,
					Src.Diff.ToString() + "色",
				};
				var lstItem = new ListViewItem(lststrs);
				listView1.Items.Add(lstItem);
			}
		}

		// Press Enter
		private void SearchBox_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter) {
				SearchBtn_Click(null, null);
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
		}

		// QuizSearch Function
		private bool SearchCheck(Quiz q, string[] srcs, string gen, int diff)
		{
			bool isExist = true;
			foreach(var src in srcs) {
				isExist = isExist && q.IsExist(src);
			}
			return isExist
				&& (diff != 0 ? diff == q.Diff : true)
				&& (gen == "" || q.Genre.IndexOf(gen) >= 0);
		}
	}
}
