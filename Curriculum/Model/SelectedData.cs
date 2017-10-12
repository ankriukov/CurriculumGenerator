using Curriculum.DBresourse;
using System;
using System.Collections.Generic;
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
        

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
