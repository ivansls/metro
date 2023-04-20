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
using System.Windows.Markup;
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
        int count = 0;
        public days_block()
        {
            InitializeComponent();
            /*try
            {

                if (logicd.list[0].opis == "bus")
                {
                    if ((i + 1).ToString() == data)
                    {
                        Picture.ImageSource = new BitmapImage(new Uri("pack://application:,,,/picture/bus.png"));
                    }
                }
                else if (logicd.list[0].opis == "electric")
                {
                    if ((i + 1).ToString() == data)
                    {
                        Picture.ImageSource = new BitmapImage(new Uri("pack://application:,,,/picture/electric.png"));
                    }
                }
                else if (logicd.list[0].opis == "metro")
                {
                    if ((i + 1).ToString() == data)
                    {
                        Picture.ImageSource = new BitmapImage(new Uri("pack://application:,,,/picture/metro.png"));
                    }
                }



            }
            catch (Exception e)
            {
                f.Picture.ImageSource = new BitmapImage(new Uri("pack://application:,,,/picture/tohca.png"));
            }*/

            

        }

        private void But_Click(object sender, RoutedEventArgs e)
        {
            
                //MainWindow main = new MainWindow();
            (Application.Current.MainWindow as MainWindow).frame.Content = new day(Days.Text);
            
            
            
            
        }
    }
}
