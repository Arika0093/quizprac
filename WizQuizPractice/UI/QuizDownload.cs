using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WizQuizPractice.Class;

namespace WizQuizPractice.UI
{
	public partial class QuizDownload : Form
	{
		public QuizDownload()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			progressBar1.Style = ProgressBarStyle.Marquee;
			backgroundWorker1.RunWorkerAsync();
			tableLayoutPanel1.Enabled = false;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		// Background do
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			// download and save
			QuizManage.GetFromDb((int)numericUpDown1.Value,
				(checkBox1.Checked ? (int)numericUpDown2.Value : -1));
			QuizManage.Save();
		}

		// finish
		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			// End
			MessageBox.Show("ダウンロードが完了しました。");
			DialogResult = DialogResult.OK;
			Close();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			numericUpDown2.Enabled = checkBox1.Checked;
		}
	}
}
