namespace WizQuizPractice.UI
{
	partial class QuizDownload
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.tableLayoutPanel1.Controls.Add(this.numericUpDown2, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.button2, 2, 5);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.progressBar1, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.button1, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.checkBox1, 1, 3);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(399, 202);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numericUpDown2.Location = new System.Drawing.Point(282, 99);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(114, 25);
			this.numericUpDown2.TabIndex = 7;
			this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown2.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			// 
			// button2
			// 
			this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button2.Location = new System.Drawing.Point(282, 165);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(114, 34);
			this.button2.TabIndex = 3;
			this.button2.Text = "終了";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 6);
			this.label1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(393, 55);
			this.label1.TabIndex = 0;
			this.label1.Text = "quiz-wiz.com/database/から問題をダウンロードします。\r\n負荷がかかると思われますので、自己責任で行ってください。\r\n[開始]をクリックしてダ" +
    "ウンロードを開始します。";
			// 
			// progressBar1
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.progressBar1, 3);
			this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.progressBar1.Location = new System.Drawing.Point(3, 131);
			this.progressBar1.MarqueeAnimationSpeed = 40;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(393, 28);
			this.progressBar1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button1.Location = new System.Drawing.Point(149, 165);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(127, 34);
			this.button1.TabIndex = 2;
			this.button1.Text = "開始";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(273, 32);
			this.label2.TabIndex = 4;
			this.label2.Text = "ダウンロードする問題数: ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numericUpDown1.Location = new System.Drawing.Point(282, 67);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(114, 25);
			this.numericUpDown1.TabIndex = 5;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown1.Value = new decimal(new int[] {
            60000,
            0,
            0,
            0});
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBox1.Location = new System.Drawing.Point(149, 99);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(127, 26);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.Text = "分割ダウンロード";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// QuizDownload
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(399, 202);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "QuizDownload";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "問題のダウンロード";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}