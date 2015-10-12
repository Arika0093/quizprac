using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace WizQuizPractice.Class
{
	/// <summary>
	/// 問題の正解情報を保持するクラスです。
	/// </summary>
	public class AnswerData
	{
		// 正解時のレート上昇値
		public const int AddRate = 1;
		// 不正解時のレート減少値
		public const int MinusRate = 2;

		// 問題のレート(0スタート、正解すると+AddRate、誤答すると-MinusRate)
		public int Rate = 0;

		// 問題の出題回数
		[XmlElement("Qst")]
		public uint QstNumber = 0;

		// 問題の正解回数
		[XmlElement("Ans")]
		public uint AnsNumber = 0;

		// レート操作関数
		public void RateChange(bool isCorrect)
		{
			Rate += isCorrect ? AddRate : -MinusRate;
		}

	}

	/// <summary>
	/// 問題の正解情報とその問題のIDを保持するクラスです。
	/// このクラスをXMLとして書き出します。
	/// </summary>
	[XmlType(TypeName = "Ads")]
	public class AnswerDataWithID
	{
		// 問題のID
		public int ID;
		// 問題の正解情報
		public AnswerData Ad;
	}
}
