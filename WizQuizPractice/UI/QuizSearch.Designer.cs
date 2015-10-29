namespace WizQuizPractice.UI
{
	partial class QuizSearch
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
			this.DiffCombo = new System.Windows.Forms.ComboBox();
			this.SearchBox = new System.Windows.Forms.TextBox();
			this.SearchBtn = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.GenreCombo = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
			this.tableLayoutPanel1.Controls.Add(this.DiffCombo, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.SearchBox, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.SearchBtn, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.GenreCombo, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(503, 320);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// DiffCombo
			// 
			this.DiffCombo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DiffCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DiffCombo.FormattingEnabled = true;
			this.DiffCombo.Items.AddRange(new object[] {
            "(全色)",
            "1色",
            "2色",
            "3色"});
			this.DiffCombo.Location = new System.Drawing.Point(225, 3);
			this.DiffCombo.Name = "DiffCombo";
			this.DiffCombo.Size = new System.Drawing.Size(216, 26);
			this.DiffCombo.TabIndex = 4;
			// 
			// SearchBox
			// 
			this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.SetColumnSpan(this.SearchBox, 2);
			this.SearchBox.ImeMode = System.Windows.Forms.ImeMode.On;
			this.SearchBox.Location = new System.Drawing.Point(3, 34);
			this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SearchBox.Name = "SearchBox";
			this.SearchBox.Size = new System.Drawing.Size(438, 25);
			this.SearchBox.TabIndex = 0;
			this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
			// 
			// SearchBtn
			// 
			this.SearchBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SearchBtn.Location = new System.Drawing.Point(447, 3);
			this.SearchBtn.Name = "SearchBtn";
			this.tableLayoutPanel1.SetRowSpan(this.SearchBtn, 2);
			this.SearchBtn.Size = new System.Drawing.Size(53, 56);
			this.SearchBtn.TabIndex = 1;
			this.SearchBtn.Text = "検索";
			this.SearchBtn.UseVisualStyleBackColor = true;
			this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3});
			this.tableLayoutPanel1.SetColumnSpan(this.listView1, 3);
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(3, 65);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(497, 252);
			this.listView1.TabIndex = 2;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Question";
			this.columnHeader1.Width = 295;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Answer";
			this.columnHeader4.Width = 83;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Genre";
			this.columnHeader2.Width = 48;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Diff";
			this.columnHeader3.Width = 37;
			// 
			// GenreCombo
			// 
			this.GenreCombo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GenreCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.GenreCombo.FormattingEnabled = true;
			this.GenreCombo.Items.AddRange(new object[] {
            "(全ジャンル)",
            "文系",
            "理系",
            "雑学",
            "芸能",
            "スポーツ",
            "アニメ ゲーム"});
			this.GenreCombo.Location = new System.Drawing.Point(3, 3);
			this.GenreCombo.Name = "GenreCombo";
			this.GenreCombo.Size = new System.Drawing.Size(216, 26);
			this.GenreCombo.TabIndex = 3;
			// 
			// QuizSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(503, 320);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "QuizSearch";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "問題検索";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox SearchBox;
		private System.Windows.Forms.Button SearchBtn;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ComboBox DiffCombo;
		private System.Windows.Forms.ComboBox GenreCombo;
	}
}