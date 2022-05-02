namespace SugangSincheong
{
    partial class OptionWindow
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
            if (disposing && (components != null))
            {
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
            this.ApplyButton = new System.Windows.Forms.Button();
            this.InitButton = new System.Windows.Forms.Button();
            this.Combo1 = new System.Windows.Forms.ComboBox();
            this.Combo2 = new System.Windows.Forms.ComboBox();
            this.Combo3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.professorNameCheckbox = new System.Windows.Forms.CheckBox();
            this.professorNameTextbox = new System.Windows.Forms.TextBox();
            this.classIDTextbox = new System.Windows.Forms.TextBox();
            this.classIDCheckbox = new System.Windows.Forms.CheckBox();
            this.untactCheckbox = new System.Windows.Forms.CheckBox();
            this.onlyNoUntact = new System.Windows.Forms.RadioButton();
            this.onlyUntact = new System.Windows.Forms.RadioButton();
            this.forDebug = new System.Windows.Forms.Label();
            this.noOverloadCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(694, 453);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(136, 73);
            this.ApplyButton.TabIndex = 0;
            this.ApplyButton.Text = "적용";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // InitButton
            // 
            this.InitButton.Location = new System.Drawing.Point(540, 453);
            this.InitButton.Name = "InitButton";
            this.InitButton.Size = new System.Drawing.Size(136, 73);
            this.InitButton.TabIndex = 1;
            this.InitButton.Text = "초기화";
            this.InitButton.UseVisualStyleBackColor = true;
            this.InitButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Combo1
            // 
            this.Combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Combo1.FormattingEnabled = true;
            this.Combo1.Items.AddRange(new object[] {
            "전체",
            "교양",
            "전공"});
            this.Combo1.Location = new System.Drawing.Point(12, 47);
            this.Combo1.Name = "Combo1";
            this.Combo1.Size = new System.Drawing.Size(199, 28);
            this.Combo1.TabIndex = 2;
            this.Combo1.SelectedIndexChanged += new System.EventHandler(this.Combo1_SelectedIndexChanged);
            // 
            // Combo2
            // 
            this.Combo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Combo2.FormattingEnabled = true;
            this.Combo2.Items.AddRange(new object[] {
            "전체"});
            this.Combo2.Location = new System.Drawing.Point(217, 47);
            this.Combo2.Name = "Combo2";
            this.Combo2.Size = new System.Drawing.Size(191, 28);
            this.Combo2.TabIndex = 3;
            this.Combo2.SelectedIndexChanged += new System.EventHandler(this.Combo2_SelectedIndexChanged);
            // 
            // Combo3
            // 
            this.Combo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Combo3.FormattingEnabled = true;
            this.Combo3.Items.AddRange(new object[] {
            "전체"});
            this.Combo3.Location = new System.Drawing.Point(414, 47);
            this.Combo3.Name = "Combo3";
            this.Combo3.Size = new System.Drawing.Size(316, 28);
            this.Combo3.TabIndex = 4;
            this.Combo3.SelectedIndexChanged += new System.EventHandler(this.Combo3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("함초롬돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "구분";
            // 
            // professorNameCheckbox
            // 
            this.professorNameCheckbox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.professorNameCheckbox.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.professorNameCheckbox.Location = new System.Drawing.Point(17, 107);
            this.professorNameCheckbox.Name = "professorNameCheckbox";
            this.professorNameCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.professorNameCheckbox.Size = new System.Drawing.Size(74, 29);
            this.professorNameCheckbox.TabIndex = 6;
            this.professorNameCheckbox.Text = "교수명";
            this.professorNameCheckbox.UseVisualStyleBackColor = true;
            this.professorNameCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // professorNameTextbox
            // 
            this.professorNameTextbox.Enabled = false;
            this.professorNameTextbox.Location = new System.Drawing.Point(97, 112);
            this.professorNameTextbox.MaxLength = 50;
            this.professorNameTextbox.Name = "professorNameTextbox";
            this.professorNameTextbox.Size = new System.Drawing.Size(614, 23);
            this.professorNameTextbox.TabIndex = 7;
            this.professorNameTextbox.TextChanged += new System.EventHandler(this.professorNameTextbox_TextChanged);
            // 
            // classIDTextbox
            // 
            this.classIDTextbox.Enabled = false;
            this.classIDTextbox.Location = new System.Drawing.Point(97, 156);
            this.classIDTextbox.MaxLength = 50;
            this.classIDTextbox.Name = "classIDTextbox";
            this.classIDTextbox.Size = new System.Drawing.Size(614, 23);
            this.classIDTextbox.TabIndex = 9;
            this.classIDTextbox.TextChanged += new System.EventHandler(this.classIDTextbox_TextChanged);
            // 
            // classIDCheckbox
            // 
            this.classIDCheckbox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.classIDCheckbox.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.classIDCheckbox.Location = new System.Drawing.Point(-3, 151);
            this.classIDCheckbox.Name = "classIDCheckbox";
            this.classIDCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.classIDCheckbox.Size = new System.Drawing.Size(94, 29);
            this.classIDCheckbox.TabIndex = 8;
            this.classIDCheckbox.Text = "과목코드";
            this.classIDCheckbox.UseVisualStyleBackColor = true;
            this.classIDCheckbox.CheckedChanged += new System.EventHandler(this.classIDCheckbox_CheckedChanged);
            // 
            // untactCheckbox
            // 
            this.untactCheckbox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.untactCheckbox.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.untactCheckbox.Location = new System.Drawing.Point(-3, 195);
            this.untactCheckbox.Name = "untactCheckbox";
            this.untactCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.untactCheckbox.Size = new System.Drawing.Size(94, 29);
            this.untactCheckbox.TabIndex = 10;
            this.untactCheckbox.Text = "강의방식";
            this.untactCheckbox.UseVisualStyleBackColor = true;
            this.untactCheckbox.CheckedChanged += new System.EventHandler(this.untactCheckbox_CheckedChanged);
            // 
            // onlyNoUntact
            // 
            this.onlyNoUntact.AutoSize = true;
            this.onlyNoUntact.Enabled = false;
            this.onlyNoUntact.Location = new System.Drawing.Point(115, 201);
            this.onlyNoUntact.Name = "onlyNoUntact";
            this.onlyNoUntact.Size = new System.Drawing.Size(49, 19);
            this.onlyNoUntact.TabIndex = 11;
            this.onlyNoUntact.Text = "대면";
            this.onlyNoUntact.UseVisualStyleBackColor = true;
            this.onlyNoUntact.CheckedChanged += new System.EventHandler(this.onlyNoUntact_CheckedChanged);
            // 
            // onlyUntact
            // 
            this.onlyUntact.AutoSize = true;
            this.onlyUntact.Enabled = false;
            this.onlyUntact.Location = new System.Drawing.Point(170, 201);
            this.onlyUntact.Name = "onlyUntact";
            this.onlyUntact.Size = new System.Drawing.Size(61, 19);
            this.onlyUntact.TabIndex = 12;
            this.onlyUntact.Text = "비대면";
            this.onlyUntact.UseVisualStyleBackColor = true;
            // 
            // forDebug
            // 
            this.forDebug.AutoSize = true;
            this.forDebug.Location = new System.Drawing.Point(19, 496);
            this.forDebug.Name = "forDebug";
            this.forDebug.Size = new System.Drawing.Size(39, 15);
            this.forDebug.TabIndex = 13;
            this.forDebug.Text = "label2";
            // 
            // noOverloadCheckbox
            // 
            this.noOverloadCheckbox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.noOverloadCheckbox.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noOverloadCheckbox.Location = new System.Drawing.Point(-10, 234);
            this.noOverloadCheckbox.Name = "noOverloadCheckbox";
            this.noOverloadCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.noOverloadCheckbox.Size = new System.Drawing.Size(190, 29);
            this.noOverloadCheckbox.TabIndex = 14;
            this.noOverloadCheckbox.Text = "정원 초과된 과목 제외";
            this.noOverloadCheckbox.UseVisualStyleBackColor = true;
            this.noOverloadCheckbox.CheckedChanged += new System.EventHandler(this.noOverloadCheckbox_CheckedChanged);
            // 
            // OptionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 538);
            this.Controls.Add(this.noOverloadCheckbox);
            this.Controls.Add(this.forDebug);
            this.Controls.Add(this.onlyUntact);
            this.Controls.Add(this.onlyNoUntact);
            this.Controls.Add(this.untactCheckbox);
            this.Controls.Add(this.classIDTextbox);
            this.Controls.Add(this.classIDCheckbox);
            this.Controls.Add(this.professorNameTextbox);
            this.Controls.Add(this.professorNameCheckbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Combo3);
            this.Controls.Add(this.Combo2);
            this.Controls.Add(this.Combo1);
            this.Controls.Add(this.InitButton);
            this.Controls.Add(this.ApplyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OptionWindow";
            this.Text = "검색 옵션";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ApplyButton;
        private Button InitButton;
        private ComboBox Combo1;
        private ComboBox Combo2;
        private ComboBox Combo3;
        private Label label1;
        private CheckBox professorNameCheckbox;
        private TextBox professorNameTextbox;
        private TextBox classIDTextbox;
        private CheckBox classIDCheckbox;
        private CheckBox untactCheckbox;
        private RadioButton onlyNoUntact;
        private RadioButton onlyUntact;
        private Label forDebug;
        private CheckBox noOverloadCheckbox;
    }
}