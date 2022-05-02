namespace SugangSincheong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LeftsidePanel = new System.Windows.Forms.Panel();
            this.SearchOption = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchContentPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.subjectList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectedSubject = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scheduleShow = new SugangSincheong.form();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.LeftsidePanel.SuspendLayout();
            this.SearchContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1383, 828);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LeftsidePanel);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.scheduleShow);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1375, 800);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LeftsidePanel
            // 
            this.LeftsidePanel.Controls.Add(this.SearchOption);
            this.LeftsidePanel.Controls.Add(this.SearchBox);
            this.LeftsidePanel.Controls.Add(this.SearchContentPanel);
            this.LeftsidePanel.Controls.Add(this.searchButton);
            this.LeftsidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftsidePanel.Location = new System.Drawing.Point(3, 2);
            this.LeftsidePanel.Name = "LeftsidePanel";
            this.LeftsidePanel.Size = new System.Drawing.Size(691, 796);
            this.LeftsidePanel.TabIndex = 13;
            // 
            // SearchOption
            // 
            this.SearchOption.Location = new System.Drawing.Point(608, 8);
            this.SearchOption.Name = "SearchOption";
            this.SearchOption.Size = new System.Drawing.Size(80, 30);
            this.SearchOption.TabIndex = 14;
            this.SearchOption.Text = "검색 옵션";
            this.SearchOption.UseVisualStyleBackColor = true;
            this.SearchOption.Click += new System.EventHandler(this.SearchOption_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchBox.Location = new System.Drawing.Point(5, 10);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(491, 27);
            this.SearchBox.TabIndex = 13;
            // 
            // SearchContentPanel
            // 
            this.SearchContentPanel.Controls.Add(this.splitContainer1);
            this.SearchContentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SearchContentPanel.Location = new System.Drawing.Point(0, 43);
            this.SearchContentPanel.Name = "SearchContentPanel";
            this.SearchContentPanel.Size = new System.Drawing.Size(691, 753);
            this.SearchContentPanel.TabIndex = 12;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.subjectList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(691, 753);
            this.splitContainer1.SplitterDistance = 277;
            this.splitContainer1.TabIndex = 5;
            // 
            // subjectList
            // 
            this.subjectList.Cursor = System.Windows.Forms.Cursors.Default;
            this.subjectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subjectList.FormattingEnabled = true;
            this.subjectList.ItemHeight = 15;
            this.subjectList.Location = new System.Drawing.Point(0, 0);
            this.subjectList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectList.Name = "subjectList";
            this.subjectList.Size = new System.Drawing.Size(277, 753);
            this.subjectList.TabIndex = 0;
            this.subjectList.SelectedIndexChanged += new System.EventHandler(this.subjectList_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectedSubject);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 753);
            this.panel1.TabIndex = 3;
            // 
            // selectedSubject
            // 
            this.selectedSubject.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.selectedSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedSubject.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectedSubject.FormattingEnabled = true;
            this.selectedSubject.HorizontalScrollbar = true;
            this.selectedSubject.ItemHeight = 19;
            this.selectedSubject.Location = new System.Drawing.Point(0, 0);
            this.selectedSubject.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.selectedSubject.Name = "selectedSubject";
            this.selectedSubject.Size = new System.Drawing.Size(410, 753);
            this.selectedSubject.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Location = new System.Drawing.Point(502, 8);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.MaximumSize = new System.Drawing.Size(100, 30);
            this.searchButton.MinimumSize = new System.Drawing.Size(100, 30);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 30);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "검색";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1325, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "토";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1255, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "금";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1185, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "목";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1115, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "수";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1045, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "화";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(975, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "월";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scheduleShow
            // 
            this.scheduleShow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scheduleShow.Location = new System.Drawing.Point(950, 32);
            this.scheduleShow.Name = "scheduleShow";
            this.scheduleShow.Size = new System.Drawing.Size(420, 760);
            this.scheduleShow.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1375, 800);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 828);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.LeftsidePanel.ResumeLayout(false);
            this.LeftsidePanel.PerformLayout();
            this.SearchContentPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button searchButton;
        private ListBox subjectList;
        private ListBox selectedSubject;
        private Panel panel1;
        private SugangSincheong.form scheduleShow;
        private SplitContainer splitContainer1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel LeftsidePanel;
        private Panel SearchContentPanel;
        private TextBox SearchBox;
        private Button SearchOption;
    }
}