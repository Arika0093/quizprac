using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizQuizPractice.Class
{
	public class Quiz
	{
		// 問題文
		public string Question;
		// 選択肢1～4
		public string Selection1;
		public string Selection2;
		public string Selection3;
		public string Selection4;
		// 解答
		public string Answer;
		// ジャンル
		public string Genre;
		// 難易度(1-3)
		public int Diff;
		// 使用予定なし
		public int AnswerRate = -1;
		// 4種類すべての選択肢が用意されてるかどうか
		public bool IsEnableSelections;
		// 選択肢4つをランダムにして返す
		public string[] GetChoicesStringsRandom()
		{
			string[] Sels = { Selection1, Selection2, Selection3, Selection4};
			return Sels.OrderBy(i => Guid.NewGuid()).ToArray();
		}
	}
}
