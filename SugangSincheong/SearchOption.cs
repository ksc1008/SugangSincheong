using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugangSincheong
{
    public static class SearchOption
    {
        static public void Initialize()
        {        
            searchPath = @"jsons\Classes\";
            professor = "";
            classID = "";
            level = 0;
            isOnlyUntact = 0;
            onlyFavorite = false;
            disallowConflict = false;
            noOverload = false;
        }

        public static string searchPath = @"jsons\Classes\";
        public static string professor = "";
        public static string classID = "";
        public static int level=0;
        public static int isOnlyUntact = 0;       //-1: 비대면, 0: 둘 다, 1: 대면
        public static bool onlyFavorite = false;
        public static bool disallowConflict = false;
        public static bool noOverload = false;

        public static bool SearchFilter(Subject subject)
        {
            if (!subject.SubjectId.Contains(classID.Trim()))
                return false;
            if (noOverload && (subject.ApplicationMax <= subject.ApplicationCount))
                return false;
            bool cont = false;
            foreach(var f in subject.professors)
            {
                if (f.Contains(professor.Trim()))
                {
                    cont = true;
                    break;
                }
            }
            if (!cont)
                return false;

            if(isOnlyUntact!=0 && subject.isUntact!=(isOnlyUntact==1))
                return false;

            return true;
        }
    }
}
