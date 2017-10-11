using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum.DBresourse.Classes
{
    public class LessonTypeLessonTypeRoom : INotifyPropertyChanged
    {
        private int id_lessonTypeLesson;
        public int Id_LessonTypeLesson
        {
            get { return id_lessonTypeLesson; }
            set
            {
                id_lessonTypeLesson = value;
                OnPropertyChanged();
            }
        }

        private int id_typeRoom;
        public int Id_TypeRoom
        {
            get { return id_typeRoom; }
            set
            {
                id_typeRoom = value;
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
