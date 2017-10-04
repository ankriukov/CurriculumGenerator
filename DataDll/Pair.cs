using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDll
{
    public class Pair
    {
        public Teacher Teacher_ { get; set; }
        public Lesson Lesson_ { get; set; }
        public Room Room_ { get; set; }
        public List<Group> Groups { get; set; }
        private int number;
        public Pair(int n)
        {
            number = n;
        }
    }
}
