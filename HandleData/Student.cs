using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Net.Http;
using System.Net.Http.Headers;

namespace HandleData
{
    class Student
    {
        public String name { get; set; }
        public String mssv { get; set; }
        public String password { get; set; }
        public String faculty_short { get; set; }
        public String program_short { get; set; }
        public int year { get; set; }

        public Student ()
            {
                name = "";
                mssv = "";
                password = "";
                faculty_short = "";
                program_short = "";
                year = 1;
            }
        public Student(String ten, String mssv, String matkhau, String khoa, String chuongtrinh, int namhoc)
        {
            this.name = ten;
            this.mssv = mssv;
            this.password = matkhau;
            this.faculty_short = khoa;
            this.program_short = chuongtrinh;
            this.year = namhoc;
        }
        public static Student getStudentFromString(String infoStudent)
        {
            Student s = new Student();
            String pattern = ";";
            String[] elements = System.Text.RegularExpressions.Regex.Split(infoStudent, pattern);
            if(elements != null && elements.Length == 6)
            {
                s.name = elements[0].ToLower();
                s.mssv = elements[1].ToLower();
                s.password = elements[2].ToLower();
                s.faculty_short = elements[3].ToLower();
                s.program_short = elements[4].ToLower();
                s.year = int.Parse(elements[5]);
                return s;
            }
            return null;
        }
        public static String getStringFromStudent(Student student)
        {
            if(student != null)
            {
                return student.name + student.mssv + student.password + student.faculty_short
                    + student.program_short + student.year.ToString();
            }
            else
            {
                return null;
            }
        }
        public static List<Student> GetStudentsFromListString(List<String> infoStudents)
        {
            List<Student> students = new List<Student>();
            if (infoStudents != null)
            {
                foreach (String s in infoStudents)
                {
                    Student st = Student.getStudentFromString(s);
                    if(st != null)
                    {
                        students.Add(st);
                    }
                }
                return students;
            }
            return null;
        }
        public static List<Student> getStudentsFromFile(String url)
        {
            List<String> studentsStringInfo = ReadFile.readDataFromFile(url);
            if (studentsStringInfo != null)
            {
                List<Student> students = Student.GetStudentsFromListString(studentsStringInfo);
                if (students != null)
                    return students;
            }
            return null;
        }
    }
}
