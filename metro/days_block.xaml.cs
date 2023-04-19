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
        public static Uri pic1 = new Uri("C:\\С\\metro\\picture\\tohca.png", UriKind.Relative);
        int count = 0;
        public days_block()
        {
            InitializeComponent();
            Picture.ImageSource = new BitmapImage(pic1);
            
        }

        private void But_Click(object sender, RoutedEventArgs e)
        {
            
                //MainWindow main = new MainWindow();
            (Application.Current.MainWindow as MainWindow).frame.Content = new day(Days.Text);
            
            
            
            
        }
    }
}
