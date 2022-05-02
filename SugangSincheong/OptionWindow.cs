using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SugangSincheong
{
    public partial class OptionWindow : Form
    {
        public OptionWindow()
        {
            MaximizeBox = false;
            this.ControlBox = false;
            InitializeComponent();
            Combo1.SelectedIndex = 0;
            Combo1.Update();        
        }

        void InitializeItems(string path, ComboBox combo, bool isDirectory)
        {
            combo.Items.Clear();
            combo.Items.Add("전체");
            var dirs = (isDirectory)? Directory.GetDirectories(path) : Directory.GetFiles(path); 
            foreach(var dir in dirs)
            {
                combo.Items.Add(dir.Split('\\').Last().Split('.').First());
            }
            combo.SelectedIndex = 0;
            combo.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Combo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Combo1.SelectedIndex == 0)
            {
                Combo2.Visible = false;
                Combo2.SelectedIndex = 0;
            }
            else if(Combo1.SelectedIndex == 2)
            {
                InitializeItems(@"jsons\Classes\major", Combo2, true);
            }
            else if(Combo1.SelectedIndex == 1)
            {
                InitializeItems(@"jsons\Classes\general", Combo2, true);
            }
            UpdateOptionPath();
        }

        private void Combo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combo2.SelectedIndex == 0)
            {
                Combo3.Visible = false;
                Combo3.SelectedIndex = 0;
            }
            else
            {
                if(Combo1.SelectedIndex == 2)
                {
                    InitializeItems(@"jsons\Classes\major\" + Combo2.Items[Combo2.SelectedIndex], Combo3, false);
                }
            }
            UpdateOptionPath();
        }

        private void Combo3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateOptionPath();
        }

        private void UpdateOptionPath()
        {
            SearchOption.searchPath = @"jsons\Classes";
            switch (Combo1.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    SearchOption.searchPath += @"\general\";
                    break;
                case 2:
                    SearchOption.searchPath += @"\major\";
                    if (Combo2.SelectedIndex != 0)
                    {
                        SearchOption.searchPath += Combo2.Items[Combo2.SelectedIndex] + @"\";
                    }
                    if (Combo3.SelectedIndex != 0)
                    {
                        SearchOption.searchPath += Combo3.Items[Combo3.SelectedIndex] + ".json";
                    }
                    break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SearchOption.Initialize();
            Combo1.SelectedIndex = 0;
            Combo1.Update();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (professorNameCheckbox.Checked)
            {
                professorNameTextbox.Enabled = true;
            }
            else
            {
                professorNameTextbox.Enabled = false;
                professorNameTextbox.Text = "";
                SearchOption.professor = "";
            }
        }

        private void classIDCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (classIDCheckbox.Checked)
            {
                classIDTextbox.Enabled = true;
            }
            else
            {
                classIDTextbox.Enabled = false;
                classIDTextbox.Text = "";
                SearchOption.classID = "";
            }
        }

        private void untactCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (untactCheckbox.Checked)
            {
                onlyNoUntact.Enabled = true;
                onlyUntact.Enabled = true;
                onlyNoUntact.Checked = true;
                onlyUntact.Checked = false;
            }
            else
            {
                onlyNoUntact.Checked = false;
                onlyUntact.Checked = false;
                onlyNoUntact.Enabled = false;
                onlyUntact.Enabled = false;
                SearchOption.isOnlyUntact = 0;
            }
        }

        private void professorNameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!professorNameCheckbox.Checked)
                return;
            SearchOption.professor = professorNameTextbox.Text;
        }

        private void classIDTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!classIDCheckbox.Checked)
                return;
            SearchOption.classID = classIDTextbox.Text;
        }

        private void onlyNoUntact_CheckedChanged(object sender, EventArgs e)
        {
            if (!untactCheckbox.Checked)
                return;
            SearchOption.isOnlyUntact = onlyNoUntact.Checked ? -1 : 1;
        }

        private void noOverloadCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SearchOption.noOverload = noOverloadCheckbox.Checked;
        }
    }
}
