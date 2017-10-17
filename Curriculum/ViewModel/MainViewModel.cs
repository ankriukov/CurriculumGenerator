using Curriculum.DBresourse;
using Curriculum.Infrastructure;
using Curriculum.Model;
using Curriculum.Model.Flyout;
using Curriculum.Model.Panels;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Curriculum.ViewModel
{

    public class MainViewModel
    {
        public ProxyData SimpleData { get; set; }
        public Commands Cmd { get; set; }
        public FlyoutData FlyoutInfo { get; set; }
        public TabsData TB { get; set; }

        public MainViewModel()
        {
            Cmd = new Commands();
            SimpleData = new ProxyData();
            FlyoutInfo = new FlyoutData();
            TB = new TabsData();
           // SimpleData.WorkDays.Date
        }

    }
}
