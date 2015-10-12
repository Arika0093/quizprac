using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace WizQuizPractice.Class
{
	// コンパイル時設定(そのうち保存できるようにするかも)
	static class WQPSetting
	{
		// ダウンロード機能の表示
		public static bool QuizDownloadShow = true;

		// 誤答問題の自動保存を有効にするかどうか
		public static bool IsAutoSaveMissQuiz = false;

		// 残り時間の指定(標準で20秒)
		public static double LimitTime = 20;

		// Excellent判定する残り時間の指定(標準で15秒)
		public static double ExcellentTime = 15;

		// タイマーの更新時間(大きくしすぎるとカクつきます)(10の倍数を推奨)
		public static int TimerRefresh = 30;
	}
}
