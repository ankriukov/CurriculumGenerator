using Curriculum.DBresourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum.Model
{
    public static class CommonSelectedData
    {
        public static Teacher Sel_Teacher { get; set; }
            

        static CommonSelectedData()
        {
            Sel_Teacher = new Teacher();
        }

    }
}
