using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleData
{
    class Subject
    {
        public String tenMonHoc { get; set; }
        public int soTinChi { get; set; }
        public int soSinhVien { get; set; }
        public int namHoc { get; set; }
        public int hocKi { get; set; }
        public String khoa { get; set; }
        public String loaiHocPhan { get; set; }
        public List<String> dsMonHocTienQuyet { get; set; }

        public Subject()
        {
            tenMonHoc = "";
            soTinChi = 0;
            soSinhVien = 0;
            namHoc = 0;
            hocKi = 0;
            khoa = "";
            loaiHocPhan = "";
            dsMonHocTienQuyet = null;
        }
        public static Subject getSubjectFromString(String infoSubject)
        {
            String pattern = @";|&";
            String[] elements = System.Text.RegularExpressions.Regex.Split(infoSubject, pattern);
            int lengthElement = elements.Length;
            if (elements != null && elements.Length >=6)
            {
                Subject subject = new Subject();
                subject.tenMonHoc = elements[0];
                subject.soTinChi = Int32.Parse(elements[1]);
                subject.soSinhVien = Int32.Parse(elements[2]);
                subject.namHoc = Int32.Parse(elements[3]);
                subject.hocKi = Int32.Parse(elements[4]);
                subject.khoa = elements[5];
                subject.loaiHocPhan = elements[6];
                subject.dsMonHocTienQuyet = new List<String>();
                int index = 7;
                if(index < lengthElement)
                {
                    while (index < lengthElement)
                    {
                        subject.dsMonHocTienQuyet.Add(elements[index]);
                        index++;
                    }
                }
                return subject;
            }
            return null;
        }

        public static String getStringFromSubject(Subject subject)
        {
            return subject.tenMonHoc + subject.soTinChi.ToString()
                + subject.soSinhVien.ToString() + subject.khoa.ToString()
                + subject.dsMonHocTienQuyet[0] + subject.dsMonHocTienQuyet[1];
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
