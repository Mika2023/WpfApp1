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
    /// Логика взаимодействия для AddCard.xaml
    /// </summary>
    public partial class AddCard : Window
    {
        public AllBinding binding { get; set; }
        public AddCard(AllBinding allBinding)
        {
            InitializeComponent();
            binding = allBinding;
            //binding.addCard = this;
            //binding.Datacontextforc(binding.user.Card);
        }

        private void go(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
