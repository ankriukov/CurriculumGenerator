using Curriculum.DBresourse;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum.Model
{
    public static class CommonSelectedData
    {
        public static Teacher Sel_Teacher { get; set; }
        public static Group_ Sel_Group { get; set; }
        public static Lesson Sel_Lesson { get; set; }

        public static ObservableCollection<Teacher> Sel_Teachers { get; set; }
        public static ObservableCollection<Lesson> Sel_Lessons { get; set; }
    }
}
