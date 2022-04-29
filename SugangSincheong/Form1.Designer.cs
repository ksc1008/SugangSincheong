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
            this.scheduleShow = new SugangSincheong.UserControl1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectedSubject = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.subjectList = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(908, 768);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.scheduleShow);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.subjectList);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(900, 740);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // scheduleShow
            // 
            this.scheduleShow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scheduleShow.Location = new System.Drawing.Point(484, 98);
            this.scheduleShow.Name = "scheduleShow";
            this.scheduleShow.Size = new System.Drawing.Size(378, 579);
            this.scheduleShow.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectedSubject);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(221, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 736);
            this.panel1.TabIndex = 3;
            // 
            // selectedSubject
            // 
            this.selectedSubject.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.selectedSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedSubject.FormattingEnabled = true;
            this.selectedSubject.ItemHeight = 15;
            this.selectedSubject.Location = new System.Drawing.Point(0, 30);
            this.selectedSubject.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.selectedSubject.Name = "selectedSubject";
            this.selectedSubject.Size = new System.Drawing.Size(215, 706);
            this.selectedSubject.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchButton.Location = new System.Drawing.Point(0, 0);
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
            // subjectList
            // 
            this.subjectList.Dock = System.Windows.Forms.DockStyle.Left;
            this.subjectList.FormattingEnabled = true;
            this.subjectList.ItemHeight = 15;
            this.subjectList.Location = new System.Drawing.Point(3, 2);
            this.subjectList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectList.Name = "subjectList";
            this.subjectList.Size = new System.Drawing.Size(218, 736);
            this.subjectList.TabIndex = 0;
            this.subjectList.SelectedIndexChanged += new System.EventHandler(this.subjectList_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(900, 740);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 768);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
        private UserControl1 scheduleShow;
    }
}