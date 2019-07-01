using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HandleData
{
    class Subject
    {
        public String name { get; set; }
        public int value { get; set; }
        public int max_student { get; set; }
        public int year { get; set; }
        public int semester { get; set; }
        public String faculty_short { get; set; }
        [JsonProperty(PropertyName = "class")]
        public String _class { get; set; }
        public String type_sub_short { get; set; }
        public String mhp { get; set; }
        public Boolean status { get; set;}
        public int weekday { get; set; }
        public int from_period { get; set; }
        public int to_period { get; set; }
        public String program_short { get; set; }
        public int can_enroll { get; set; }
        public Subject()
        {
            name = "";
            value = 0;
            max_student = 0;
            year = 0;
            semester = 0;
            faculty_short = "";
            _class = "";
            type_sub_short = "";
            mhp = "";
            status = true;
            weekday = 0;
            from_period = 0;
            to_period = 0;
            program_short = "";
            can_enroll = 0;
    }
        public static Subject getSubjectFromString(String infoSubject)
        {
            String pattern = @";|&";
            String[] elements = System.Text.RegularExpressions.Regex.Split(infoSubject, pattern);
            int lengthElement = elements.Length;
            if (elements != null && elements.Length >=6)
            {
                Subject subject = new Subject();
                subject.name = elements[0].ToLower();
                subject.value = Int32.Parse(elements[1]);
                subject.max_student = Int32.Parse(elements[2]);
                subject.year = Int32.Parse(elements[3]);
                subject.semester = Int32.Parse(elements[4]);
                subject.faculty_short = elements[5].ToLower();
                subject._class = elements[6].ToLower();
                subject.type_sub_short = elements[7].ToLower();
                subject.mhp = elements[8].ToLower();
                subject.status = Convert.ToBoolean(elements[9].ToLower());
                subject.weekday = Int32.Parse(elements[10]);
                subject.from_period = Int32.Parse(elements[11]);
                subject.to_period = Int32.Parse(elements[12]);
                subject.program_short = elements[13].ToLower();
                subject.can_enroll = Int32.Parse(elements[14]);
                return subject;
            }
            return null;
        }

        public static List<Subject> GetSubjectsFromListString( List<String> infoSubjects)
        {
            List<Subject> subjects = new List<Subject>();
            if (infoSubjects != null)
            {
                foreach (String s in infoSubjects)
                {
                    Subject st = Subject.getSubjectFromString(s);
                    if (st != null)
                    {
                        subjects.Add(st);
                    }
                }
                return subjects;
            }
            return null;
        }
        public static List<Subject> GetSubjectsFromFile(String url)
        {
            if(url != null)
            {
                List<String> infoSubject = ReadFile.readDataFromFile(url);
                if(infoSubject != null)
                {
                    List<Subject> subjects = GetSubjectsFromListString(infoSubject);
                    return subjects;
                }
            }
            return null;
        }
    }
}
