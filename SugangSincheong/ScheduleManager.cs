using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugangSincheong
{
    public class ClassTime
    {
        public char day { get; private set; }
        public List<int> time = new List<int>();

        public ClassTime(string s)
        {
            string[] splited = s.Split(' ');
            day = splited[0][0];
            foreach(string strs in splited[1].Split(','))
            {
                int b = (strs[strs.Length - 1] == 'B') ? 1 : 0;
                b += Int32.Parse(strs.Substring(0, strs.Length - 1))*2;
                time.Add(b);
            }
        }

        public override string ToString()
        {
            string result = ""+day+" ";
            foreach(int t in time)
            {
                result += (t/2).ToString();
                result += (t % 2 == 0) ? "A " : "B ";
            }
            return result;
        }
    }
    internal class Schedule
    {
        Dictionary<char, bool[]> schedule;

        public void addToSchedule(ClassTime time)
        {
            foreach(int t in time.time)
            {
                schedule[time.day][t] = true;
            }
        }

        public bool checkOverlap(ClassTime time)
        {
            for(int i = 1; i < time.time.Count-1; i++)
            {
                if (schedule[time.day][time.time[i]] == true)
                    return true;
            }
            return false;
        }


        public Schedule()
        {
            schedule['월'] = new bool[28];
            schedule['화'] = new bool[28];
            schedule['수'] = new bool[28];
            schedule['목'] = new bool[28];
            schedule['금'] = new bool[28];
            schedule['토'] = new bool[28];
        }
    }
}
