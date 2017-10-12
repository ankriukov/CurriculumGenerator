using Curriculum.DBresourse;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum.Model
{
    public class SelectedData : INotifyPropertyChanged
    {
        public Teacher Sel_Teacher
        {
            get { return CommonSelectedData.Sel_Teacher; }
            set
            {
                CommonSelectedData.Sel_Teacher = value;
                OnPropertyChanged();
            }
        }
        public Group_ Sel_Group
        {
            get { return CommonSelectedData.Sel_Group; }
            set
            {
                CommonSelectedData.Sel_Group = value;
                OnPropertyChanged();
            }
        }
        public Lesson Sel_Lesson
        {
            get { return CommonSelectedData.Sel_Lesson; }
            set
            {
                CommonSelectedData.Sel_Lesson = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Teacher> Sel_Teachers
        {
            get { return CommonSelectedData.Sel_Teachers; }
            set
            {
                CommonSelectedData.Sel_Teachers = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Lesson> Sel_Lessons
        {
            get { return CommonSelectedData.Sel_Lessons; }
            set
            {
                CommonSelectedData.Sel_Lessons = value;
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
