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
        public int ApplicationCount;
        public int ApplicationMax;
        public string? SubjectId;
        public List<string> EstablishedDepartments = new List<string>();
        public List<string> EstablishedUniversities = new List<string>();
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
            public string? crseNo;              // 과목 코드
            [JsonInclude]
            public string? lssnsTimeInfo; 
            [JsonInclude]
            public string? sbjetNm;
            [JsonInclude]
            public string? lctreMthodNm;
            [JsonInclude]
            public string? estblDprtnNm;        // 개설 학과
            [JsonInclude]
            public string? estblUnivNm;         // 개설 대학
            [JsonInclude]
            public string? appcrCnt;               // 수강 신청 인원
            [JsonInclude]
            public string? attlcPrscpCnt;          // 수강 정원
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
                if (!Int32.TryParse(sbj.appcrCnt,out subject.ApplicationCount)|| !Int32.TryParse(sbj.attlcPrscpCnt, out subject.ApplicationMax))
                {
                    subject.ApplicationCount = -1;
                    subject.ApplicationMax = -2;
                }
                subject.SubjectId = sbj.crseNo;
                subject.EstablishedDepartments.Add((sbj.estblUnivNm ?? "") + ' ' + (sbj.estblDprtnNm ?? ""));
                subject.EstablishedUniversities.Add(sbj.estblUnivNm??"");
                subject.name = sbj.sbjetNm;
                subject.isUntact = sbj.lctreMthodNm != "대면";
                string[] ss = sbj.totalPrfssNm.Split("<br/>");
                subject.professors.AddRange(ss);
                List<ClassTime> ct = new List<ClassTime>();
                foreach(var s in sbj.lssnsTimeInfo?.Split("<br/>") ?? new string[0])
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
        Dictionary<string, int> IDtoClass = new();
        public List<Subject> subjects= new();
        void LoadFromJson(string filePath)
        {
            string jsonStr = File.ReadAllText(filePath);
            SubjectData? subjectdatas = JsonSerializer.Deserialize<SubjectData>(jsonStr);
            string ss = "";
            if(subjectdatas == null)
            {
                MessageBox.Show("No Data");
                return;
            }
            foreach(Subject subject in subjectdatas.toSubjects())
            {
                if (IDtoClass.ContainsKey(subject.SubjectId))
                {
                    var thatSubject = subjects[IDtoClass[subject.SubjectId]];
                    if (!thatSubject.EstablishedUniversities.Contains(subject.EstablishedUniversities[0]))
                        thatSubject.EstablishedUniversities.Add(subject.EstablishedUniversities[0]);
                    if (!thatSubject.EstablishedDepartments.Contains(subject.EstablishedDepartments[0]))
                        thatSubject.EstablishedDepartments.Add(subject.EstablishedDepartments[0]);                    
                }
                else
                {
                    IDtoClass[subject.SubjectId] = subjects.Count;
                    subjects.Add(subject);
                }
            }
        }

        public void LoadAllInPath(string path, bool clearList= true)
        {
            //MessageBox.Show(path);
            if (clearList)
            {
                subjects.Clear();
                IDtoClass = new();
            }
            if (path.EndsWith("json"))
            {
                LoadFromJson(path);
            }
            else
            {
                var dirs = Directory.GetDirectories(path).ToList();
                dirs.AddRange(Directory.GetFiles(path));
                foreach (string dir in dirs)
                {
                    //MessageBox.Show(dir);
                    LoadAllInPath(dir,false);
                }
            }
        }

    }
}
