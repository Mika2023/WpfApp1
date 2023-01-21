using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Pattern;
using WpfApp1.model;
using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore;

namespace WpfApp1.viewmodel
{
    //public class BehaviorUser
    //{
    //    //RelayCommand? addCommand;
    //    public static User userl { get; set; }
    //    ////public ObservableCollection<User> Users { get; set; }
    //    ////public BehaviorUser()
    //    ////{
    //    ////    SingleTon.DB.Users.Load();
    //    ////    Users = SingleTon.DB.Users.Local.ToObservableCollection();
    //    ////}
    //    //public RelayCommand AddCommand
    //    //{
    //    //    get
    //    //    {
    //    //        return addCommand ??
    //    //            (addCommand = new RelayCommand((o) =>
    //    //            {
    //    //                reg register = new reg();
    //    //                if (register.ShowDialog() == true)
    //    //                {
    //    //                    userl = register.allBinding.user;
    //    //                    SingleTon.DB.Users.Add(userl);
    //    //                    SingleTon.DB.SaveChanges();
    //    //                }
    //    //            }));
    //    //    }
    //    //}
    //    ////public RelayCommand GetCommand
    //    ////{
    //    ////    get
    //    ////    {
    //    ////        return getCommand ??
    //    ////        (getCommand = new RelayCommand((selectedItem) =>
    //    ////        {
    //    ////            User? user = selectedItem as User;
    //    ////            if (user == null) return;

    //    ////        }));
    //    ////        Main main = new Main();
    //    ////        main.Show();
    //    ////    }
    //    ////}
    //    public void LogIn()
    //    {
    //        var user = SingleTon.DB.Users.Where(u => u.Login == userl.Login && u.Password == userl.Password).FirstOrDefault();
    //        if (user != null)
    //        {
    //            Main main = new Main();
    //            main.ShowDialog();
    //        }
    //    }
        
    //}
}
