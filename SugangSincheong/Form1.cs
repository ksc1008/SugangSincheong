namespace SugangSincheong
{
    public partial class Form1 : Form
    {
        ClassLoader cl = new ClassLoader();
        public Form1()
        {
            InitializeComponent();
            string s = "테스트용";
        }

        private void testText_Click(object sender, EventArgs e)
        {
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            cl.LoadFromJson(@"C:\Users\ksc10\source\repos\SugangSincheong\SugangSincheong\jsons\gg.json");
            foreach(var s in cl.subjects)
            {
                subjectList.Items.Add(s.name);
            }
        }

        private void subjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var current = cl.subjects[subjectList.SelectedIndex];
            selectedSubject.Items.Clear();
            selectedSubject.Items.Add("과목명\t"+current.name);
            selectedSubject.Items.Add("교수\t"+ current.professors[0]);
            for(int i = 1;i< current.professors.Count;i++)
                selectedSubject.Items.Add("\t" + current.professors[i]);
            selectedSubject.Items.Add("시간표\t" + current.times[0].ToString());
            for (int i = 1; i < current.times.Count; i++)
                selectedSubject.Items.Add("\t" + current.times[i].ToString());
            selectedSubject.Items.Add("수업방식\t" + (current.isUntact ? "비대면" : "대면"));
        }
    }
}