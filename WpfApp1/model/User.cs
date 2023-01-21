using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfApp1.Pattern;

namespace WpfApp1.model
{
    public class User: INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Age { get; set; }
        public card Card { get; set; }
        public int CardId { get; set; }
        public string? name
        {
            get { return Name; }
            set
            {
                Name = value;
                OnPropertyChanged("Name");
            }
        }
        public int age
        {
            get { return Age; }
            set
            {
                Age = value;
                OnPropertyChanged("Age");
            }
        }
        public string login
        {
            get { return Login; }
            set
            {
                Login = value;
                OnPropertyChanged("Login");
            }
        }
        public string password
        {
            get { return Password; }
            set
            {
                Password = value;
                OnPropertyChanged("Password");
            }
        }
        public card card
        {
            get { return SingleTon.DB.cards.Where(C => CardId == C.ID).FirstOrDefault(); }
            set
            {
                Card = value;
                OnPropertyChanged("Card");
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
