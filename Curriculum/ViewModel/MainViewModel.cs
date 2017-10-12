using Curriculum.Model;
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
        public ProxyData SimpleData { get; set; }
        public SelectedData Selected { get; set; }
        
        

        public MainViewModel()
        {
            SimpleData = new ProxyData();
            Selected = new SelectedData();
        }
    }
}
