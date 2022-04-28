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
            subjectList.Items.Add("Hello");
            subjectList.Items.Add("They");
            subjectList.Items.Add("Are");
            subjectList.Items.Add("New");
            subjectList.Items.Add("Elements");
            cl.LoadFromJson(@"C:\Users\ksc10\source\repos\SugangSincheong\SugangSincheong\jsons\gg.json");

        }
    }
}