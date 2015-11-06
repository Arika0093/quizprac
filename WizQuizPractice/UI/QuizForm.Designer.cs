namespace WizQuizPractice
{
	partial class Main
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.問題の取得更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.問題の読み込みOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.検索SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.練習モードを開始SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.過去の出題問題から練習RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.問題帳から練習を開始BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.表示問題の条件を指定して開始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.練習モードを終了EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.問題を自動的に問題帳へ保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.このアプリについてAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.Status_LoadQst = new System.Windows.Forms.ToolStripStatusLabel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.Question = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.selfDrawProgressBar1 = new WizQuizPractice.UI.SelfDrawProgressBar();
			this.ツールTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ダメージ計算機ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.問題検索ダイアログを開くDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.検索SToolStripMenuItem,
            this.ツールTToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(388, 26);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ファイルFToolStripMenuItem
			// 
			this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.問題の取得更新ToolStripMenuItem,
            this.問題の読み込みOToolStripMenuItem,
            this.toolStripSeparator1,
            this.終了XToolStripMenuItem});
			this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
			this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
			this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
			// 
			// 問題の取得更新ToolStripMenuItem
			// 
			this.問題の取得更新ToolStripMenuItem.Name = "問題の取得更新ToolStripMenuItem";
			this.問題の取得更新ToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
			this.問題の取得更新ToolStripMenuItem.Text = "問題の更新(&R)...";
			this.問題の取得更新ToolStripMenuItem.Click += new System.EventHandler(this.問題の取得更新ToolStripMenuItem_Click);
			// 
			// 問題の読み込みOToolStripMenuItem
			// 
			this.問題の読み込みOToolStripMenuItem.Name = "問題の読み込みOToolStripMenuItem";
			this.問題の読み込みOToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
			this.問題の読み込みOToolStripMenuItem.Text = "問題ファイルの読み込み(&O)...";
			this.問題の読み込みOToolStripMenuItem.Click += new System.EventHandler(this.問題の読み込みOToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(236, 6);
			// 
			// 終了XToolStripMenuItem
			// 
			this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
			this.終了XToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.終了XToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
			this.終了XToolStripMenuItem.Text = "終了(&X)";
			this.終了XToolStripMenuItem.Click += new System.EventHandler(this.終了XToolStripMenuItem_Click);
			// 
			// 検索SToolStripMenuItem
			// 
			this.検索SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.練習モードを開始SToolStripMenuItem,
            this.過去の出題問題から練習RToolStripMenuItem,
            this.問題帳から練習を開始BToolStripMenuItem,
            this.表示問題の条件を指定して開始ToolStripMenuItem,
            this.toolStripSeparator4,
            this.練習モードを終了EToolStripMenuItem});
			this.検索SToolStripMenuItem.Name = "検索SToolStripMenuItem";
			this.検索SToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
			this.検索SToolStripMenuItem.Text = "クイズ(&Q)";
			// 
			// 練習モードを開始SToolStripMenuItem
			// 
			this.練習モードを開始SToolStripMenuItem.Name = "練習モードを開始SToolStripMenuItem";
			this.練習モードを開始SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.練習モードを開始SToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
			this.練習モードを開始SToolStripMenuItem.Text = "練習モードを開始(&S)";
			this.練習モードを開始SToolStripMenuItem.Click += new System.EventHandler(this.練習モードを開始SToolStripMenuItem_Click);
			// 
			// 過去の出題問題から練習RToolStripMenuItem
			// 
			this.過去の出題問題から練習RToolStripMenuItem.Name = "過去の出題問題から練習RToolStripMenuItem";
			this.過去の出題問題から練習RToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
			this.過去の出題問題から練習RToolStripMenuItem.Text = "過去の出題問題から練習(&R)";
			this.過去の出題問題から練習RToolStripMenuItem.Click += new System.EventHandler(this.過去の出題問題から練習RToolStripMenuItem_Click);
			// 
			// 問題帳から練習を開始BToolStripMenuItem
			// 
			this.問題帳から練習を開始BToolStripMenuItem.Name = "問題帳から練習を開始BToolStripMenuItem";
			this.問題帳から練習を開始BToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
			this.問題帳から練習を開始BToolStripMenuItem.Text = "問題帳から練習を開始(&B)...";
			this.問題帳から練習を開始BToolStripMenuItem.Click += new System.EventHandler(this.問題帳から練習を開始BToolStripMenuItem_Click);
			// 
			// 表示問題の条件を指定して開始ToolStripMenuItem
			// 
			this.表示問題の条件を指定して開始ToolStripMenuItem.Name = "表示問題の条件を指定して開始ToolStripMenuItem";
			this.表示問題の条件を指定して開始ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.表示問題の条件を指定して開始ToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
			this.表示問題の条件を指定して開始ToolStripMenuItem.Text = "条件を指定して練習開始(&C)...";
			this.表示問題の条件を指定して開始ToolStripMenuItem.Click += new System.EventHandler(this.表示問題の条件を指定して開始ToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(282, 6);
			// 
			// 練習モードを終了EToolStripMenuItem
			// 
			this.練習モードを終了EToolStripMenuItem.Enabled = false;
			this.練習モードを終了EToolStripMenuItem.Name = "練習モードを終了EToolStripMenuItem";
			this.練習モードを終了EToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.練習モードを終了EToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
			this.練習モードを終了EToolStripMenuItem.Text = "練習モードを終了(&E)";
			this.練習モードを終了EToolStripMenuItem.Click += new System.EventHandler(this.練習モードを終了EToolStripMenuItem_Click);
			// 
			// ヘルプHToolStripMenuItem
			// 
			this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.問題を自動的に問題帳へ保存SToolStripMenuItem,
            this.toolStripSeparator2,
            this.このアプリについてAToolStripMenuItem});
			this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
			this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
			this.ヘルプHToolStripMenuItem.Text = "設定(&S)";
			// 
			// 問題を自動的に問題帳へ保存SToolStripMenuItem
			// 
			this.問題を自動的に問題帳へ保存SToolStripMenuItem.Name = "問題を自動的に問題帳へ保存SToolStripMenuItem";
			this.問題を自動的に問題帳へ保存SToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
			this.問題を自動的に問題帳へ保存SToolStripMenuItem.Text = "誤答問題を自動保存(&S)";
			this.問題を自動的に問題帳へ保存SToolStripMenuItem.Click += new System.EventHandler(this.問題を自動的に問題帳へ保存SToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(211, 6);
			// 
			// このアプリについてAToolStripMenuItem
			// 
			this.このアプリについてAToolStripMenuItem.Name = "このアプリについてAToolStripMenuItem";
			this.このアプリについてAToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
			this.このアプリについてAToolStripMenuItem.Text = "このアプリについて(&A)...";
			this.このアプリについてAToolStripMenuItem.Click += new System.EventHandler(this.このアプリについてAToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status_LoadQst});
			this.statusStrip1.Location = new System.Drawing.Point(0, 328);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(388, 23);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// Status_LoadQst
			// 
			this.Status_LoadQst.Name = "Status_LoadQst";
			this.Status_LoadQst.Size = new System.Drawing.Size(373, 18);
			this.Status_LoadQst.Spring = true;
			this.Status_LoadQst.Text = "読み込んだ問題数: xxxxx";
			this.Status_LoadQst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.button4, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.button3, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.button2, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.Question, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.button1, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.selfDrawProgressBar1, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 26);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 302);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// button4
			// 
			this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button4.Location = new System.Drawing.Point(197, 245);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(188, 54);
			this.button4.TabIndex = 8;
			this.button4.Text = "選択肢4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button3.Location = new System.Drawing.Point(3, 245);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(188, 54);
			this.button3.TabIndex = 7;
			this.button3.Text = "選択肢3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button2.Location = new System.Drawing.Point(197, 185);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(188, 54);
			this.button2.TabIndex = 6;
			this.button2.Text = "選択肢2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Question
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.Question, 2);
			this.Question.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Question.Location = new System.Drawing.Point(3, 27);
			this.Question.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
			this.Question.Multiline = true;
			this.Question.Name = "Question";
			this.Question.ReadOnly = true;
			this.Question.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.Question.Size = new System.Drawing.Size(382, 135);
			this.Question.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(382, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "第 1 問";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button1.Location = new System.Drawing.Point(3, 185);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(188, 54);
			this.button1.TabIndex = 5;
			this.button1.Text = "選択肢1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// selfDrawProgressBar1
			// 
			this.selfDrawProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tableLayoutPanel1.SetColumnSpan(this.selfDrawProgressBar1, 2);
			this.selfDrawProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.selfDrawProgressBar1.Location = new System.Drawing.Point(3, 163);
			this.selfDrawProgressBar1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.selfDrawProgressBar1.Maximum = 2000;
			this.selfDrawProgressBar1.Name = "selfDrawProgressBar1";
			this.selfDrawProgressBar1.Size = new System.Drawing.Size(382, 16);
			this.selfDrawProgressBar1.TabIndex = 9;
			this.selfDrawProgressBar1.Value = 2000;
			// 
			// ツールTToolStripMenuItem
			// 
			this.ツールTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ダメージ計算機ToolStripMenuItem,
            this.問題検索ダイアログを開くDToolStripMenuItem});
			this.ツールTToolStripMenuItem.Name = "ツールTToolStripMenuItem";
			this.ツールTToolStripMenuItem.Size = new System.Drawing.Size(74, 22);
			this.ツールTToolStripMenuItem.Text = "ツール(&T)";
			// 
			// ダメージ計算機ToolStripMenuItem
			// 
			this.ダメージ計算機ToolStripMenuItem.Name = "ダメージ計算機ToolStripMenuItem";
			this.ダメージ計算機ToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
			this.ダメージ計算機ToolStripMenuItem.Text = "簡易ダメージ計算機(&C)...";
			this.ダメージ計算機ToolStripMenuItem.Click += new System.EventHandler(this.ダメージ計算機ToolStripMenuItem_Click);
			// 
			// 問題検索ダイアログを開くDToolStripMenuItem
			// 
			this.問題検索ダイアログを開くDToolStripMenuItem.Name = "問題検索ダイアログを開くDToolStripMenuItem";
			this.問題検索ダイアログを開くDToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
			this.問題検索ダイアログを開くDToolStripMenuItem.Text = "問題検索ダイアログ(&D)...";
			this.問題検索ダイアログを開くDToolStripMenuItem.Click += new System.EventHandler(this.問題検索ダイアログを開くDToolStripMenuItem_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(388, 351);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "クイズ練習用ソフト";
			this.Load += new System.EventHandler(this.Main_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 問題の取得更新ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 問題の読み込みOToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 検索SToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem このアプリについてAToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel Status_LoadQst;
		private System.Windows.Forms.ToolStripMenuItem 練習モードを開始SToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 練習モードを終了EToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox Question;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private UI.SelfDrawProgressBar selfDrawProgressBar1;
		private System.Windows.Forms.ToolStripMenuItem 問題帳から練習を開始BToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 表示問題の条件を指定して開始ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 過去の出題問題から練習RToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 問題を自動的に問題帳へ保存SToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem ツールTToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ダメージ計算機ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 問題検索ダイアログを開くDToolStripMenuItem;
	}
}

