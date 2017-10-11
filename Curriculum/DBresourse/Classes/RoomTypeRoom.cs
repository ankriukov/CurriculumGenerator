using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum.DBresourse.Classes
{
    public class RoomTypeRoom : INotifyPropertyChanged
    {
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

        private int id_typeRoom;
        public int Id_TypeRoom
        {
            get { return id_typeRoom; }
            set
            {
                id_typeRoom = value;
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
