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
    public class ProxyData : INotifyPropertyChanged
    {
        private DBStorage context;

        #region Observable objects
        public ObservableCollection<Teacher> Teachers { get; set; }
        public ObservableCollection<Group_> Groups { get; set; }
        public ObservableCollection<Lesson> Lessons { get; set; }
        public ObservableCollection<WorkDay> WorkDays { get; set; }
        public ObservableCollection<Room> Rooms { get; set; }
        #endregion Observable objects

        public ProxyData()
        {
            context = new DBStorage();
            Teachers = new ObservableCollection<Teacher>(context.Teacher.AsEnumerable());
            Groups = new ObservableCollection<Group_>(context.Group_.AsEnumerable());
            Lessons = new ObservableCollection<Lesson>(context.Lesson.AsEnumerable());
            WorkDays = new ObservableCollection<WorkDay>(context.WorkDay.AsEnumerable());
            Rooms = new ObservableCollection<Room>(context.Room.AsEnumerable());
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
