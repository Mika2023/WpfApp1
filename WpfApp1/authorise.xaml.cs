using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.viewmodel;
namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для authorise.xaml
    /// </summary>
    public partial class authorise : Window
    {
        public AllBinding binding = new AllBinding();
        public authorise()
        {
            InitializeComponent();
            binding.Authorise = this;
            binding.Datacontextfora();
        }

        private void log(object sender, RoutedEventArgs e)
        {
            binding.logIn();
            AddCard addCard = new AddCard(binding);
            addCard.Show();
            Close();
        }

        private void register(object sender, RoutedEventArgs e)
        {
            binding.register();
        }

        private void add(object sender, RoutedEventArgs e)
        {
            binding.addcard();
        }
    }
}
