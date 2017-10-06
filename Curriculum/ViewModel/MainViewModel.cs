using DataDll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum.ViewModel
{
    public class MainViewModel 
    {
        DBContext db = new DBContext();

        public MainViewModel()
        {
            var a = db.Groups;
        }
    }
}
