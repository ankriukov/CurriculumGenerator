using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDll
{
    public class DB_Data
    {
        public void Subject(string str)
        {

        }
    }
    public class Group
    {
        public string NumberGroup { get; set; }
        public string SpecialtyGroup { get; set; }
    }
    public class Lesson
    {
        public string NameLesson { get; set;}
    }

    public class LessonTypeLesson
    {
        public int HoursLessonTypeLesson { get; set; }
    }

    public class Room
    {
        public List<string> TypeRoom { get; set; }
        public string NumberRoom { get; set; } 
    }
    public class Teacher
    {
        public string NameTeacher { get; set; }
        public string PtronomicTeacher { get; set; }
        public string SurnameTeacher { get; set; }
        public int AgeTeacher { get; set; }
    }
    public class TypeLesson
    {
        public string NameTypeLesson { get; set; }
    }
    //public class TypeRoom
    //{
    //    public string NameTypeRoom { get; set; }
    //}

}
