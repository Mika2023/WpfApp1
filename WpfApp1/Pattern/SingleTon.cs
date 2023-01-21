using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.DataBase;
using WpfApp1.model;

namespace WpfApp1.Pattern
{
    public static class SingleTon
    {
        public static User user { get; set; }
        public static card Card { get; set; }
        public static AppContextDb DB { get; set; }
        static SingleTon()
        {
            DB = new AppContextDb();
        }

    }
}
