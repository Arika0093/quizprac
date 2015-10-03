using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WizQuizPractice.Class;
using WizQuizPractice.UI;

namespace WizQuizPractice
{
	static class Program
	{
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			// quizs.xmlの存在を確認し、ないならダウンロードフォームを立ち上げる
			if(QuizManage.IsExistQuizFile() == false) {
				var DlForm = new QuizDownload();
				DlForm.ShowDialog();
				if(DlForm.DialogResult == DialogResult.Cancel) {
					return;
				}
			}
			else {
				QuizManage.Load();
			}
			Application.Run(new Main());
		}
	}
}
