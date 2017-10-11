using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum.DBresourse.Classes
{
    public class GroupLessonTypeLesson : INotifyPropertyChanged
    {
        private int id_group { get; set; }
        public int Id_Group
        {
            get { return id_group; }
            set
            {
                id_group = value;
                OnPropertyChanged();
            }
        }
        
        private int id_lessonTypeLesson { get; set; }
        public int Id_LessonTypeLesson
        {
            get { return id_lessonTypeLesson; }
            set
            {
                id_lessonTypeLesson = value;
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
