using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.model;
using WpfApp1.Pattern;
using Microsoft.EntityFrameworkCore;

namespace WpfApp1.viewmodel
{
    public class AllBinding
    {
        public User user { get; set; } = null!;
        public authorise Authorise { get; set; }
        public reg Reg { get; set; }
        public string cardnum { get;set;}
        public string Pincode { get; set; }

        RelayCommand _addCard;

        RelayCommand AddCard
        {
            get
            {
                return _addCard ??( _addCard = new RelayCommand((o) =>
                {
                    SingleTon.DB.Add(new card() { Cardnum = int.Parse(cardnum), Pincode = int.Parse(Pincode) });
                    SingleTon.DB.SaveChanges();
                }));
            }
        }


        //public AddCard addCard { get; set; }
        public void Datacontextforr(User User)
        {
            //user = new User();
            Reg.DataContext = User;
        }
        public void Datacontextfora()
        {
            user = new User();
            Authorise.DataContext = user;
        }
        //public void Datacontextforc(card Card)
        //{
        //    addCard.DataContext = Card;
        //}
        public void register()
        {
            reg Reg = new reg(this);
            if (Reg.ShowDialog() == true)
            {
                User u = Reg.allBinding.user;
                SingleTon.DB.Users.Add(u);
                SingleTon.DB.SaveChanges();
            }
        }
        public void logIn()
        {
            SingleTon.DB.Users.Load();
            var User = SingleTon.DB.Users.Where(u => u.Login == user.Login && u.Password == user.Password).FirstOrDefault();
            if (User == null)
            {
                return;
            }
            else
            SingleTon.user = User;
        }
        public void addcard()
        {
            AddCard add = new AddCard(this);
            if(add.ShowDialog() == true)
            {
                card c = add.binding.user.Card;
                SingleTon.DB.cards.Add(c);
                SingleTon.DB.SaveChanges(true);
            }
            //SingleTon.DB.Users.Load();
            //SingleTon.DB.cards.Load();
            //var card = SingleTon.DB.cards.Where(c => c.cardnum == this.Card.cardnum && c.Pincode == this.Card.Pincode).FirstOrDefault();
            //if (card == null)
            //{
            //    SingleTon.DB.cards.Add(this.Card);
            //    SingleTon.DB.SaveChanges();
            //    SingleTon.Card = this.Card;
            //    SingleTon.user.CardId = SingleTon.Card.ID;
            //}
            //else if (card.ID == this.user.CardId) SingleTon.Card = card;
            //else return;
        }
    }
}
