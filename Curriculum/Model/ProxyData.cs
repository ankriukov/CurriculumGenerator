using DataDll;
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
        public ObservableCollection<Teacher> Teachers
        {
            get { return StorageData.Teachers; }
            set { StorageData.Teachers = value; }
        }

        public ObservableCollection<Lesson> Lessons
        {
            get { return StorageData.Lessons; }
            set { StorageData.Lessons = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
