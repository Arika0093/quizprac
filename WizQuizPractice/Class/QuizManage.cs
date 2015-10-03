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
		public static string Quizfilepath = "Quizzes.xml";

		// Quizlist
		[XmlArrayItem(typeof(Quiz))]
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
			XmlSerializer Xs = new XmlSerializer(typeof(List<Quiz>));
			StreamWriter Sw = new StreamWriter(Quizfilepath);
			Xs.Serialize(Sw, Quizs);
		}

		// Quizfile Load
		public static void Load()
		{
			XmlSerializer Xs = new XmlSerializer(typeof(List<Quiz>));
			StreamReader Sr = new StreamReader(Quizfilepath);
			Quizs = (List<Quiz>)Xs.Deserialize(Sr);
		}
	}
}
