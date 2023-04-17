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
    /// Логика взаимодействия для days_block.xaml
    /// </summary>
    public partial class days_block : UserControl
    {
        public static Uri pic1 = new Uri("C:\\Users\\ivan\\Desktop\\шарага\\C#\\metro\\metro\\picture\\tohca.png", UriKind.Relative);
        public days_block()
        {
            InitializeComponent();
            Picture.ImageSource = new BitmapImage(pic1);
        }

        private void But_Click(object sender, RoutedEventArgs e)
        {
            if (Days.Text == "1")
            {
                MainWindow main = new MainWindow();
                main.frame.Content = new day();
            }
            else if (Days.Text == "2")
            {
                MessageBox.Show("2");
            }
            else if (Days.Text == "3")
            {
                MessageBox.Show("3");
            }
            
        }
    }
}
