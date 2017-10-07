using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataDll
{
    public class Pair : INotifyPropertyChanged
    {
        public int Id { get; set; }

        private int number;
        public int Number
        {
            get { return number; }
            set
            {
                number = value;
                OnPropertyChanged();
            }
        }

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

        private int id_room;
        public int Id_Room
        {
            get { return id_room; }
            set
            {
                id_room = value;
                OnPropertyChanged();
            }
        }

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

        private int id_group;
        public int Id_Group
        {
            get { return id_group; }
            set
            {
                id_group = value;
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
