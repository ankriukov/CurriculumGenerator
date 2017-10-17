using Curriculum.DBresourse;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum.Model
{
    public class ProxyData : INotifyPropertyChanged
    {
        #region Observable objects
        public ObservableCollection<Teacher> Teachers
        {
            get { return StaticProxy.Teachers; }
            set
            {
                StaticProxy.Teachers = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Group_> Groups
        {
            get { return StaticProxy.Groups; }
            set
            {
                StaticProxy.Groups = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Lesson> Lessons
        {
            get { return StaticProxy.Lessons; }
            set
            {
                StaticProxy.Lessons = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<WorkDay> WorkDays
        {
            get { return StaticProxy.WorkDays; }
            set
            {
                StaticProxy.WorkDays = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Room> Rooms
        {
            get { return StaticProxy.Rooms; }
            set
            {
                StaticProxy.Rooms = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<TypeLesson> TypesLesson
        {
            get { return StaticProxy.TypesLesson; }
            set
            {
                StaticProxy.TypesLesson = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<TypeRoom> TypesRoom
        {
            get { return StaticProxy.TypesRoom; }
            set
            {
                StaticProxy.TypesRoom = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Pair> Pairs
        {
            get { return StaticProxy.Pairs; }
            set
            {
                StaticProxy.Pairs = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<LessonTypeLesson> LessonTypesLesson
        {
            get { return StaticProxy.LessonTypesLesson; }
            set
            {
                StaticProxy.LessonTypesLesson = value;
                OnPropertyChanged();
            }
        }
        #endregion Observable objects

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
