using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataDll
{
    public class LessonTypeLesson : INotifyPropertyChanged
    {
        public int Id { get; set; }

        private int id_lesson;
        public int Id_Lesson
        {
            get { return id_lesson; }
            set
            {
                id_lesson = value;
                OnPropertyChanged();
            }
        }

        private int id_typeLesson;
        public int Id_TypeLesson
        {
            get { return id_typeLesson; }
            set
            {
                id_typeLesson = value;
                OnPropertyChanged();
            }
        }

        private int hours;
        public int Hours
        {
            get { return hours; }
            set
            {
                hours = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
