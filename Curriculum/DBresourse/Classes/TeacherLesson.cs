using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum.DBresourse.Classes
{
    public class TeacherLesson : INotifyPropertyChanged
    {
        private int id_teacher;
        public int Id_Teacher
        {
            get { return id_teacher; }
            set
            {
                id_teacher = value;
                OnPropertyChanged();
            }
        }

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

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
