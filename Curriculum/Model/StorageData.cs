using DataDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum.Model
{
    public static class StorageData
    {
        #region Lists of objects
        public static List<WorkDay> WorkDays { get; set; }
        public static List<Room> Rooms { get; set; }
        public static List<Group> Groups { get; set; }
        public static List<Lesson> Lessons { get; set; }
        public static List<Pair> Pairs { get; set; }
        public static List<Teacher> Teachers { get; set; }
        #endregion

        static StorageData()
        {
            WorkDays = new List<WorkDay>();
            Rooms = new List<Room>();
            Teachers = new List<Teacher>();
            Pairs = new List<Pair>();

        }

    }
}
