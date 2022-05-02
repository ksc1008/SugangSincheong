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
    public partial class form : UserControl
    {
        int[,] colors = new int[6,28];
        int[] sbjNum = new int[28];

        public void SetColor(int i, int j, int val)
        {
            if (val == -1)
            {
                sbjNum[j]--;
            }
            else if(colors[i,j]==-1)
            {
                sbjNum[j]++;
            }
            colors[i, j] = val;

            if (val != -1 && j > latestSubj)
                latestSubj = j;
            else if(val==-1 && j <= latestSubj)
            {
                bool check = false;
                for (int t = j; t <= latestSubj; t++)
                {
                    if (sbjNum[t] > 0)
                        break;
                    if (t == latestSubj)
                        check = true;

                }
                if (check)
                {
                    int t;
                    for(t = j; t >= 0; t--)
                    {
                        if(sbjNum[t] > 0) break;
                    }
                    latestSubj = t;
                }
            }
            this.Invalidate();
        }
        int _latestSubj
        {
            get;
            set;
        }

        public int latestSubj
        {
            get { return _latestSubj; }
            private set { _latestSubj = Math.Max(value,12); }
        }

        List<Panel> panels = new List<Panel>();
        public form()
        {
            latestSubj = 12;
            InitializeComponent();
            for(int i = 0;i<colors.Length;i++)
            {
                colors[i/28,i%28] = -1;
            }
        }


        private void UserControl1_Resize(object sender, EventArgs e)
        {
            for(int i = 0;i< panels.Count; i++)
            {
                panels[i].Size = new Size(((Control)sender).Size.Width / 6, ((Control)sender).Size.Height);
                panels[i].Location = new Point(((Control)sender).Size.Width / 6 * i, 0);
                foreach(Label l in panels[i].Controls)
                {
                    l.Size = new Size(((Control)sender).Size.Width / 6, ((Control)sender).Size.Height/26);
                }
            }
        }
        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            Color[] MonoColors = { Color.FromArgb(200, 200, 200), Color.FromArgb(175, 175, 175)};
            Color[] Colors = { Color.FromArgb(255, 154, 162), Color.FromArgb(255, 183, 178), Color.FromArgb(255, 218, 193), Color.FromArgb(226, 240, 203), Color.FromArgb(181, 234, 215), Color.FromArgb(199, 206, 234) };
            SolidBrush br;
            for (int i = 0; i < 6; i++)
            {
                for(int j = 0; j < latestSubj+1; j++)
                {
                    Rectangle rectangle = new System.Drawing.Rectangle(Width / 6 * i, Height/ (latestSubj+1) * j, Width / 6, Height/ (latestSubj+1));
                    if (colors[i, j] == -1)
                    {
                        br = new SolidBrush(MonoColors[i % 2]);
                    }
                    else
                    {
                        br = new SolidBrush(Colors[colors[i, j]]);
                    }
                    e.Graphics.FillRectangle(br, rectangle);
                }

            }

        }
    }
}
