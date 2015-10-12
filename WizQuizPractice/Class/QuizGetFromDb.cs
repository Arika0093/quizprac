using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using HtmlAgilityPack;

namespace WizQuizPractice.Class
{
	class QuizGetFromDb
	{
		public const string AccessURL = "http://quiz-wiz.com/database/quiz4/?disp={0}&page_no={1}";
		public int GetCount = 100000;
		public int SeparateDl = 10000;
		public List<Quiz> Quizs;

		// Get Quizs from Database
		public bool GetDatabase()
		{
			// Reset
			Quizs = new List<Quiz>();
			bool Result = true;
			for(int i = 1; Result && i<=(GetCount/SeparateDl); i++) {
				string Html = HtmlGet(i);
				Result = AnalyseAndCreateQuizs(Html);
			}
			return Result;
		}

		// HtmlText get
		private string HtmlGet(int Page)
		{
			var Web = new WebClient();
			var Url = String.Format(AccessURL, SeparateDl.ToString(), Page);
			Web.Encoding = Encoding.UTF8;
			var Stm = Web.DownloadString(Url);
			return Stm;
		}

		// Analyse Html Text
		private bool AnalyseAndCreateQuizs(string html)
		{
			// Create
			var HtmlDoc = new HtmlAgilityPack.HtmlDocument();
			HtmlDoc.LoadHtml(html);
			// Analyse
			var xpath = @"//table[@id=""output_list_box""]/tr[@id]";
			var Articles = HtmlDoc.DocumentNode.SelectNodes(xpath);
			if(Articles == null) {
				// Error
				return false;
			}
			foreach(var Artc in Articles) {
				// Generate Quiz
				Quiz q = new Quiz();
				// QuizID
				q.QuizID = Convert.ToInt32(
					Artc.SelectSingleNode("descendant::td[3]/p/a").Attributes["href"].Value
						.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries).Last()
				);
				// Genre
				q.Genre = Artc.SelectSingleNode("descendant::td[1]/p").InnerText.Replace(" ","");
				// Diff
				q.Diff = DiffStringToInt(Artc.SelectSingleNode("descendant::td[2]/p").InnerText);
				// Question
				q.Question = Artc.SelectSingleNode("descendant::td[3]/p/a").InnerText.Trim();
				// selections
				var Selections
					= (from s in Artc.SelectSingleNode("descendant::td[3]/p/a").Attributes["title"].Value
					  .Substring(4).Split(new char[] { '【', '】'}, StringSplitOptions.RemoveEmptyEntries)
					  where s.Replace(" ", "").Length > 0
					  select s).ToArray();
				q.Selection1 = Selections[0];
				q.Selection2 = Selections[1];
				q.Selection3 = Selections[2];
				q.Selection4 = Selections[3];
				// IsEnableSelections
				q.IsEnabledSelections = Selections[3].IndexOf("不明") <= -1;
				// Insert
				Quizs.Add(q);
			}

			return true;
		}

		private int DiffStringToInt(string diff)
		{
			int d;
			int.TryParse(diff.Substring(0, 1), out d);
			return d;
		}

	}
}
