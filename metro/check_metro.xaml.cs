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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace metro
{
    /// <summary>
    /// Логика взаимодействия для check_metro.xaml
    /// </summary>
    public partial class check_metro : UserControl
    {
        public static int c;
        public List<check_metro> check_Metros = new List<check_metro>();
        public check_metro()
        {
            
            InitializeComponent();
        }

        private void check_Checked(object sender, RoutedEventArgs e)
        {

            
            

        }
    }
}
