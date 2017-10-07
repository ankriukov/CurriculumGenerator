using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataDll
{
    public class WorkDay : INotifyPropertyChanged
    {
        public int Id { get; set; }

        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set
            {
                date = value;
                OnPropertyChanged();
            }
        }


        public ObservableCollection<Pair> Pairs { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
