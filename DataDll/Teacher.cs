using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDll
{
    public class Teacher
    {
        public string Name { get; set; }
        public string Patronomic { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public List<Lesson> Lessons { get; set; }
    }
}
