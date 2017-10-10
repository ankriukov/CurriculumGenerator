using DataDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum.Model
{
    public static class StorageData
    {
        #region Lists of objects
        public static List<Group> Groups { get; set; }
        public static List<GroupLessonTypeLesson> GroupLessonTypeLessons { get; set; }
        public static List<Lesson> Lessons { get; set; }
        public static List<LessonTypeLesson> LessonTypeL { get; set; }
        public static List<LessonTypeLessonTypeRoom> LessonTypeLessonTypeRooms { get; set; }
        public static List<Pair> Pairs { get; set; }
        public static List<Teacher> Teachers { get; set; }
        public static List<Room> Rooms { get; set; }
        public static List<RoomTypeRoom> RoomTypeRooms { get;set;}
        public static List<TeacherLesson> TeacherLesson { get; set; }
        public static List<TypeLesson> TypeLessons { get; set; }
        public static List<WorkDay> WorkDays { get; set; }
        public static List<WorkDayPairs> WorkDayPairses { get; set; }
        #endregion

        static StorageData()
        {
            Groups = DBMethods.getGroups();
            GroupLessonTypeLessons = DBMethods.getGroupLTypeL();
            Lessons = DBMethods.getLesson();
            LessonTypeL = DBMethods.getLesTypeLes();
            LessonTypeLessonTypeRooms = DBMethods.getLTypeLTypeRoom();
            Pairs = DBMethods.getPair();
            Rooms = DBMethods.getRoom();
            RoomTypeRooms = DBMethods.getRoomTypeRoom();
            Teachers = DBMethods.getTeacher();
            TeacherLesson = DBMethods.getTeacherLesson();
            TypeLessons = DBMethods.getTypeLesson();
            WorkDays = DBMethods.getWorkDay();
            WorkDayPairses = DBMethods.getWorkDayPairs();
        }

        public static List<dynamic> GetTypesByLesson(string lesson)
        {
            var id_name = Lessons.Where(x => x.Name == lesson).Select(x => x.Id).FirstOrDefault();
            var ltl = (from lesTypeles in LessonTypeL
                      where lesTypeles.Id_Lesson == id_name 

            //var tr = from it in ltl
            //         join tpLess in TypeLessons
            //         on it.Id_TypeLesson equals tpLess.Id
            //         select new
            //         {
            //             NameLesson = lesson,
                         
            //         }


            return null;
        }

    }
}
