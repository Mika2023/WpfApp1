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
using WpfApp1.Pattern;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для reg.xaml
    /// </summary>
    public partial class reg : Window
    {
        public AllBinding allBinding { get; set; }
        public reg(AllBinding binding)
        {
            InitializeComponent();
            allBinding = binding;
            allBinding.Reg = this;
            allBinding.Datacontextforr(allBinding.user);
        }

        private void regist(object sender, RoutedEventArgs e)
        {

            DialogResult = true;
        }
    }
}
