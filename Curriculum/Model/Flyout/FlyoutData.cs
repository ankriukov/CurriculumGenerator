using Curriculum.Model.Flyout.ProxyData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum.Model.Flyout
{
    public class FlyoutData
    {
        public ProxyTabNewLesson NewLesson { get; set; } = new ProxyTabNewLesson();

        public ProxyTabNewTeacher NewTeacher { get; set; } = new ProxyTabNewTeacher();

    }
}
