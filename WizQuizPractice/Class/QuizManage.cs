using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WizQuizPractice.Class
{
	static class QuizManage
	{
		// Quizfile path(constant)
		public static string Quizfilepath = "Data/Quizzes.xml";
		// QuizAnswerdata filepath(constant)
		public static string QuizAnsDataPath = "Data/MyAnswer.xml";

		// Quizlist
		public static List<Quiz> Quizs;

		// QuizFile Check
		public static bool IsExistQuizFile()
		{
			return File.Exists(Quizfilepath);
		}

		// Get Quizs from Database Site
		public static bool GetFromDb(int GetCount = -1, int SeparateDl = -1)
		{
			QuizGetFromDb Qgfd = new QuizGetFromDb();
			if(GetCount > 1) {
				Qgfd.GetCount = GetCount;
			}
			if(SeparateDl > 1) {
				Qgfd.SeparateDl = SeparateDl;
			}
			Qgfd.GetDatabase();
			Quizs = Qgfd.Quizs;
			return true;
		}

		// QuizFile Save
		public static void Save()
		{
			// Quizdata -----------
			XmlSerializer Xs = new XmlSerializer(typeof(List<Quiz>));
			StreamWriter Sw = new StreamWriter(Quizfilepath);
			Xs.Serialize(Sw, Quizs);
			Sw.Close();
		}

		// AnswerData Save
		public static void SaveAnswerData()
		{
			// Answerdata ---------
			var adwi = from q in Quizs
					   where q.AData != null && q.AData.QstNumber > 0
					   select new AnswerDataWithID {
						   Ad = q.AData,
						   ID = q.QuizID
					   };
			var adwl = adwi.ToList();
			XmlSerializer Xsa = new XmlSerializer(typeof(List<AnswerDataWithID>));
			StreamWriter Swa = new StreamWriter(QuizAnsDataPath);
			Xsa.Serialize(Swa, adwl);
			Swa.Close();
		}

		// Quizfile Load
		public static void Load()
		{
			// Quizdata -----------
			XmlSerializer Xs = new XmlSerializer(typeof(List<Quiz>));
			StreamReader Sr = new StreamReader(Quizfilepath);
			Quizs = (List<Quiz>)Xs.Deserialize(Sr);
			Sr.Close();
			LoadAnswerData();
		}

		// Answerdata load
		public static void LoadAnswerData()
		{
			if(File.Exists(QuizAnsDataPath)) {
				// Answerdata -----
				XmlSerializer Xsa = new XmlSerializer(typeof(List<AnswerDataWithID>));
				StreamReader Sra = new StreamReader(QuizAnsDataPath);
				var ad = (List<AnswerDataWithID>)Xsa.Deserialize(Sra);
				// Marge ----------
				foreach(var q in Quizs) {
					var qwi = ad.FirstOrDefault(a => a.ID == q.QuizID);
					q.AData = qwi != null ? qwi.Ad : new AnswerData();
				}
				Sra.Close();
			}
		}
	}
}
