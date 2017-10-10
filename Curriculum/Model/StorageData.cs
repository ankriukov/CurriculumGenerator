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

        public static Dictionary<TypeLesson, int> GetTypesByLesson(Lesson lesson)
        {
            Dictionary<TypeLesson, int> ForReturn = new Dictionary<TypeLesson, int>();

            var id_types = (from it in LessonTypeL
                       where lesson.Id == it.Id_Lesson
                       select new
                       {
                           id_type = it.Id_TypeLesson, hours = it.Hours
                       }).ToList();

            foreach (var item in TypeLessons)
            {
                var searchField = id_types.Find(x => x.id_type == item.Id);
                if (searchField != null)
                    ForReturn.Add(item, searchField.hours);   
            }
            return ForReturn;
        }

    }
}
