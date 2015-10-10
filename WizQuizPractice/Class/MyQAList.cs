using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace WizQuizPractice.Class
{
	public class MyQAList
	{
		public List<MyQstAns> mqa = new List<MyQstAns>();
		public string GetMyAnsRate()
		{
			if(mqa.Count <= 0) {
				return "--";
			}
			var Qcor = from q in mqa
					   where q.IsCorrect == true
					   select q;
			int AnsRate = (int)((double)Qcor.Count() * 100 / mqa.Count);
			return AnsRate.ToString();
		}
		public int GetMyExcellentNum()
		{
			if(mqa.Count <= 0) {
				return 0;
			}
			var Qexc = from q in mqa
					   where q.LimitTime >= WQPSetting.ExcellentTime && q.IsCorrect
					   select q;
			return Qexc.Count();
		}
		public string DataAdd(MyQstAns mq)
		{
			mqa.Add(mq);
			return "";
		}
		public void XmlLoad(string xmlpath)
		{
			XmlSerializer Xs = new XmlSerializer(typeof(List<MyQstAns>));
			StreamReader Sr = new StreamReader(xmlpath);
			mqa = (List<MyQstAns>)Xs.Deserialize(Sr);
			Sr.Close();
		}
	}

	public class MyQstAns
	{
		public Quiz q;
		public string SelAns;
		public double LimitTime;
		public bool IsCorrect;
	}
}
