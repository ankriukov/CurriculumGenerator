using Curriculum.DBresourse;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum.Model.Flyout.ProxyData
{
    public class ProxyTabNewLesson : INotifyPropertyChanged
    {
        public Lesson NewLesson
        {
            get { return TabNewLesson.NewLesson; }
            set
            {
                TabNewLesson.NewLesson = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<TypeLesson> CheckedTypesLesson
        {
            get { return TabNewLesson.CheckedTypesLesson; }
            set
            {
                TabNewLesson.CheckedTypesLesson = value;
                OnPropertyChanged();
            }
        }

        public Teacher Sel_Teacher
        {
            get { return TabNewLesson.Sel_Teacher; }
            set
            {
                TabNewLesson.Sel_Teacher = value;
                OnPropertyChanged();
            }
        }

        public int Hours
        {
            get { return TabNewLesson.Hours; }
            set
            {
                TabNewLesson.Hours = value;
                OnPropertyChanged();
            }
        }

        public TypeLesson Sel_TypeLesson
        {
            get { return TabNewLesson.Sel_TypeLesson; }
            set
            {
                TabNewLesson.Sel_TypeLesson = value;
                OnPropertyChanged();
            }
        }

        public static void Reset()
        {
            TabNewLesson.Reset();
        }

        public static Lesson GetCurrentLesson()
        {
            return TabNewLesson.GetCurrentLesson();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
