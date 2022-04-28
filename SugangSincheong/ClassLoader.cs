using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SugangSincheong
{
    public class Subject
    {
        public string name
        {
            get;
            private set;
        }
        private List<string> professors = new List<string>();
        private List<string> times = new List<string>();

    }

    class SubjectData
    {
        [JsonInclude]
        public List<sbj> data;
        public class sbj
        {
            [JsonInclude]
            public string? lssnsTimeInfo; 
            [JsonInclude]
            public string? sbjetNm;
            [JsonInclude]
            public string? totalPrfssNm;
        }

        public string print()
        {
            string s = "";
            foreach(var sbj in data)
            {
                s += sbj.sbjetNm;
                s += '\n';
            }
            return s;
        }

        public List<Subject> toSubjects()
        {

        }
    }
    internal class ClassLoader
    {
        private List<Subject> subjects;
        public void LoadFromJson(string filePath)
        {
            string jsonStr = File.ReadAllText(filePath);
            SubjectData? subjectdatas = JsonSerializer.Deserialize<SubjectData>(jsonStr);
            string ss = "";
            if(subjectdatas == null)
            {
                MessageBox.Show("No Data");
                return;
            }
            MessageBox.Show(subjectdatas.print());
        }
    }
}
