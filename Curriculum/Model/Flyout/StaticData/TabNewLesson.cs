using Curriculum.DBresourse;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum.Model.Flyout
{
    public static class TabNewLesson
    {
        public static Lesson NewLesson { get; set; } = new Lesson();

        public static ObservableCollection<TypeLesson> CheckedTypesLesson { get; set; } = new ObservableCollection<TypeLesson>();

        public static Teacher Sel_Teacher { get; set; } = new Teacher();

        public static int Hours { get; set; }

        public static TypeLesson Sel_TypeLesson { get; set; } = new TypeLesson();

        public static void Reset()
        {
            NewLesson = null;
            CheckedTypesLesson = null;
            Sel_Teacher = null;
        }

        public static Lesson GetCurrentLesson()
        {
            if (NewLesson == null)
                return null;

            foreach (var item in CheckedTypesLesson)
            {
                var lsl = new LessonTypeLesson()
                {
                    Lesson = NewLesson,
                    TypeLesson = item
                };
                NewLesson.LessonTypeLesson.Add(lsl);
            }
            

            return NewLesson;
        }

        static TabNewLesson()
        {
            NewLesson.Teacher.Add(new Teacher() { Name = "name", Surname = "ds", Patronomic = "", Age = 20 });
        }
    }
}
