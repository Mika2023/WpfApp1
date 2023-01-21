using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WpfApp1.model
{
    public class card
    {
        public int ID { get; set; }
        public User user { get; set; } = null!;
        public int Balance { get; set; }
        public int cardnum { get; set; }
        public int Pincode { get; set; }
        public int Cardnum
        {
            get { return cardnum; }
            set
            {
                cardnum = value;
               // OnPropertyChanged("Name");
            }
        }
    }
}
