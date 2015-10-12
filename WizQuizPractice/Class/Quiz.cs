using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WizQuizPractice.Class
{
	public class Quiz
	{
		// 問題のID(URLから取得)
		[XmlElement("ID")]
		public int QuizID;
		// 問題文
		[XmlElement("Qst")]
		public string Question;
		// 選択肢1～4
		[XmlElement("Sel1")]
		public string Selection1;
		[XmlElement("Sel2")]
		public string Selection2;
		[XmlElement("Sel3")]
		public string Selection3;
		[XmlElement("Sel4")]
		public string Selection4;
		// 解答(現状Sel1に正解が入っているようなのでSel1を返却するように変更)
		[XmlIgnore]
		public string Answer
		{
			get
			{
				return Selection1;
			}
		}
		// ジャンル
		public string Genre;
		// 難易度(1-3)
		public int Diff;
		// 4種類すべての選択肢が用意されてるかどうか
		[XmlElement("IsEnb")]
		public bool IsEnabledSelections;
		// 使用予定なし
		[XmlIgnore]
		public int AnswerRate = -1;
		// 問題のレート(詳細はAnswerDataを確認)
		[XmlIgnore]
		public AnswerData AData;

		// 問題文、選択肢に指定された文字列が含まれているかを返す
		public bool IsExist(string Search)
		{
			bool Rst = false;
			Rst = Rst || Question.IndexOf(Search) >= 0;
			Rst = Rst || Selection1.IndexOf(Search) >= 0;
			Rst = Rst || Selection2.IndexOf(Search) >= 0;
			Rst = Rst || Selection3.IndexOf(Search) >= 0;
			Rst = Rst || Selection4.IndexOf(Search) >= 0;
			return Rst;
		}
		// 選択肢4つをランダムにして返す
		public string[] GetChoicesStringsRandom()
		{
			string[] Sels = { Selection1, Selection2, Selection3, Selection4};
			return Sels.OrderBy(i => Guid.NewGuid()).ToArray();
		}
	}
}
