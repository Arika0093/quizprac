using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WizQuizPractice.UI
{
	public class SelfDrawProgressBar : ProgressBar
	{
		public string MaxTime = "20.00";

		public SelfDrawProgressBar()
        {
            //Paintイベントが発生するようにする
            //ダブルバッファリングを有効にする
            base.SetStyle(ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Brush backBrush = new SolidBrush(this.BackColor);
            Brush foreBrush = new SolidBrush(this.ForeColor);

            // 背景を描画する
            e.Graphics.FillRectangle(backBrush, this.ClientRectangle);

            // バーの幅を計算する
            int chunksWidth = (int)(
                (double)this.ClientSize.Width *
                (double)(this.Value - this.Minimum) /
                (double)(this.Maximum - this.Minimum));
            Rectangle chunksRect = new Rectangle(0, 0,
                chunksWidth, this.ClientSize.Height);
            // バーを描画する
            e.Graphics.FillRectangle(foreBrush, chunksRect);

			// 残り時間を描画する
			var f = new Font("メイリオ", 8);
			e.Graphics.DrawString(String.Format("{0} / {1}", ((double)Value/100).ToString("#0.00"), MaxTime),
				f, Brushes.White, new Point(ClientSize.Width - 80, 4));

            backBrush.Dispose();
            foreBrush.Dispose();
        }
	}
}
