using Curriculum.DBresourse;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum.Model
{
    public static class StaticProxy
    {
        public static DBStorage Context { get; set; } 
        
        #region Observable objects
        public static ObservableCollection<Teacher> Teachers { get; set; }
        public static ObservableCollection<Group_> Groups { get; set; }
        public static ObservableCollection<Lesson> Lessons { get; set; }
        public static ObservableCollection<WorkDay> WorkDays { get; set; }
        public static ObservableCollection<Room> Rooms { get; set; }
        public static ObservableCollection<TypeLesson> TypesLesson { get; set; }
        public static ObservableCollection<TypeRoom> TypesRoom { get; set; }
        public static ObservableCollection<Pair> Pairs { get; set; }
        public static ObservableCollection<LessonTypeLesson> LessonTypesLesson { get; set; }
        #endregion Observable objects

        static StaticProxy()
        {
            Context = new DBStorage();

            Rooms = new ObservableCollection<Room>(Context.Room.AsEnumerable());
            Teachers = new ObservableCollection<Teacher>(Context.Teacher.AsEnumerable());
            Lessons = new ObservableCollection<Lesson>(Context.Lesson.AsEnumerable());
            TypesLesson = new ObservableCollection<TypeLesson>(Context.TypeLesson.AsEnumerable());
            Groups = new ObservableCollection<Group_>(Context.Group_.AsEnumerable());
        }
    }
}
