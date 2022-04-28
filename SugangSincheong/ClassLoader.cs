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
        public bool isUntact;
        public string name;
        public List<string> professors = new List<string>();
        public List<ClassTime> times = new List<ClassTime>();

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
            public string? lctreMthodNm;
            [JsonInclude]
            public string? totalPrfssNm;
        }

        public string print()
        {
            string s = "";
            if(data == null)
            {
                return "ND";
            }
            foreach(var sbj in data)
            {
                s += sbj.sbjetNm;
                s += '\n';
            }
            return s;
        }

        public List<Subject> toSubjects()
        {
            if (data == null)
                return null;
            List<Subject> subjects = new List<Subject>();
            foreach(var sbj in data)
            {
                Subject subject = new Subject();
                subject.name = sbj.sbjetNm;
                subject.isUntact = sbj.lctreMthodNm != "대면";
                string[] ss = sbj.totalPrfssNm.Split("<br/>");
                subject.professors.AddRange(ss);
                List<ClassTime> ct = new List<ClassTime>();
                foreach(string s in sbj.lssnsTimeInfo.Split("<br/>"))
                    ct.Add(new ClassTime(s));
                foreach(var t in ct)
                {
                    subject.times.Add(t);
                }
                subjects.Add(subject);
            }
            return subjects;
        }
    }
    internal class ClassLoader
    {
        public List<Subject> subjects;
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
            subjects = subjectdatas.toSubjects();
        }
    }
}
