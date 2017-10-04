using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDll
{
    public class Lesson
    {
        public string Name { get; set; }
        public Dictionary<string,int> HoursPerTypeLesson { get; set; }
    }
}
