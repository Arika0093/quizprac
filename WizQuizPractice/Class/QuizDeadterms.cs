using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WizQuizPractice.Class
{
	using Fc = Func<MyQAList, bool>;

	public static class QuizDeadterms
	{
		public static List<QuizDeadterm> Lqdt = new List<QuizDeadterm>(
			new QuizDeadterm[]{
				// 通常(死亡条件無し)
				new QuizDeadterm("(指定しない)", mqa => true),
				// 誤答したら終了
				new QuizDeadterm("全問正解", mqa => (mqa.GetMyAnsRate() ?? 100) == 100),
				// EXCを外したら終了
				new QuizDeadterm("全問EXCELLENT正解", mqa => mqa.mqa.Count == mqa.GetMyExcellentNum()),
				// 5回誤答したら終了
				new QuizDeadterm("5回誤答したら終了", mqa => mqa.mqa.Count(p => !p.IsCorrect) < 5),
			}
		);



	}

	public class QuizDeadterm
	{
		public QuizDeadterm()
		{
		}
		public QuizDeadterm(string info, Fc func)
		{
			Info = info;
			Check = func;
		}
		public string Info;
		public Fc Check;
	}
}
