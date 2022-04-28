namespace SugangSincheong
{
    public partial class Form1 : Form
    {
        ClassLoader cl = new ClassLoader();
        public Form1()
        {
            InitializeComponent();
            string s = "�׽�Ʈ��";
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
            selectedSubject.Items.Add("�����\t"+current.name);
            selectedSubject.Items.Add("����\t"+ current.professors[0]);
            for(int i = 1;i< current.professors.Count;i++)
                selectedSubject.Items.Add("\t" + current.professors[i]);
            selectedSubject.Items.Add("�ð�ǥ\t" + current.times[0].ToString());
            for (int i = 1; i < current.times.Count; i++)
                selectedSubject.Items.Add("\t" + current.times[i].ToString());
            selectedSubject.Items.Add("�������\t" + (current.isUntact ? "����" : "���"));
        }
    }
}