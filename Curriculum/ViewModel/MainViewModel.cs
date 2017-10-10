using Curriculum.Model;
using DataDll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum.ViewModel
{
    //public class Para
    //{
    //    public string nameTeacher { get; set; }
    //    public string namePara { get; set; }
    //    public string nameAuditory { get; set; }

    //    public override string ToString()
    //    {
    //        return namePara;
    //    }
    //}

    //public class Daa
    //{
    //    public string groupa { get; set; }
    //    public Dictionary<int, Para> pp { get; set; } = new Dictionary<int, Para>();

    //    public override string ToString()
    //    {
    //        return groupa;
    //    }
    //}
   

    public class MainViewModel 
    {
        public Dictionary<TypeLesson, int> ss { get; set; }
        //public List<Daa> gr { get; set; } = new List<Daa>();
        //public Daa qq { get; set; }

        public MainViewModel()
        {
            ss = StorageData.GetTypesByLesson(new Lesson { Id = 1, Name = "WCF"});
            
            //for (int i = 0; i < 5; i++)
            //{
            //    Daa tmp = new Daa();
            //    tmp.groupa = "Group Name";
            //    for (int k = 0; k < 3; k++)
            //    {
            //        tmp.pp.Add(k, new Para
            //        {
            //            nameAuditory = "101",
            //            namePara = "English",
            //            nameTeacher = "Zhutska"
            //        });
            //    }
            //    gr.Add(tmp);
            //    qq = tmp;

                
            //}
            //gr[0].pp[1].nameAuditory;
        }
    }
}
