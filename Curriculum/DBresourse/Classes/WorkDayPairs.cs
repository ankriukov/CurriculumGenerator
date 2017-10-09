using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDll
{
    public class WorkDayPairs : INotifyPropertyChanged
    {
        private int id_WorkDay { get; set; }
        public int Id_WorkDay
        {
            get { return id_WorkDay; }
            set
            {
                id_WorkDay = value;
                OnPropertyChanged();
            }
        }

        private int id_Pair { get; set; }
        public int Id_Pair
        {
            get { return id_Pair; }
            set
            {
                id_Pair = value;
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
