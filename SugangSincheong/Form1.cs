namespace SugangSincheong
{
    public partial class Form1 : Form
    {
        OptionWindow optionWindow = new OptionWindow();
        int previousSelect = -1;
        ClassLoader cl = new ClassLoader();
        List<Subject> searchedList = new List<Subject>();
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            cl.LoadAllInPath(Application.StartupPath + SugangSincheong.SearchOption.searchPath);
            var search = from subject in cl.subjects
                         where SugangSincheong.SearchOption.SearchFilter(subject) && subject.name.Contains(SearchBox.Text)
                         select subject;
            selectedSubject.Items.Clear();
            previousSelect = -1;
            subjectList.SelectedIndex = -1;
            subjectList.Items.Clear();
            searchedList.Clear();
            foreach (var s in search)
            {
                searchedList.Add(s);
                subjectList.Items.Add(s.name);
            }

        }
        private void FormatSubjectList(string text, string? data)
        {
            selectedSubject.Items.Add(text + "\t : " + data);
        }

        private void FormatSubjectList(string text, List<string> data)
        {
            selectedSubject.Items.Add(text + "\t : " + data[0]);
            for (int i = 1; i < data.Count; i++)
            {
                selectedSubject.Items.Add("\t : " + data[i]);
            }
        }

        private void subjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subjectList.SelectedIndex >= subjectList.Items.Count || subjectList.SelectedIndex < 0 || subjectList.Items.Count == 0)
                return;
            if (subjectList.SelectedIndex == previousSelect)
                return;

            previousSelect = subjectList.SelectedIndex;
            var current = searchedList[subjectList.SelectedIndex];

            selectedSubject.Items.Clear();
            FormatSubjectList("�����ڵ�", current.SubjectId);

            selectedSubject.Items.Add("");
            FormatSubjectList("��������", current.EstablishedUniversities);
            FormatSubjectList("�����а�", current.EstablishedDepartments);
            selectedSubject.Items.Add("");
            FormatSubjectList("�����", current.name);
            FormatSubjectList("����", current.professors);
            FormatSubjectList("�������", (current.isUntact ? "����" : "���"));


            selectedSubject.Items.Add("");
            if (current.times.Count > 0)
            {
                selectedSubject.Items.Add("�ð�ǥ\t : " + current.times[0].ToString());
                int color = new Random().Next(6);
                foreach (var i in current.times[0].time)
                    scheduleShow.SetColor(current.times[0].dayInt(), i, color);
                for (int i = 1; i < current.times.Count; i++)
                {
                    selectedSubject.Items.Add("\t : " + current.times[i].ToString());
                    foreach (var k in current.times[i].time)
                        scheduleShow.SetColor(current.times[i].dayInt(), k, color);
                }
                selectedSubject.Items.Add("");
            }

            selectedSubject.Items.Add("���� �ο� / ���� ����");
            if (current.ApplicationCount == -1)
            {
                selectedSubject.Items.Add("- / -");
            }
            else
            {
                selectedSubject.Items.Add(string.Format("{0} / {1}", current.ApplicationCount, current.ApplicationMax));
            }
        }

        private void SearchOption_Click(object sender, EventArgs e)
        {
            optionWindow.Show();
        }
    }
}