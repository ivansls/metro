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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace metro
{
    /// <summary>
    /// Логика взаимодействия для day.xaml
    /// </summary>
    public partial class day : Page
    {
        check_metro first = new check_metro();
        string dat;
        public List<check_metro> check_Metros = new List<check_metro>();
        List<my_type2> type = desir.MyDesirialize<List<my_type2>>();
        public day(string d)
        {
            InitializeComponent();
            dat = d;
            text_block.Text = d + "-" + mounth.now.ToString("MMMMMMMMMM-yyyy");
            first.txt.Text = "bus";
            first.img.Source = new BitmapImage(new Uri("pack://application:,,,/picture/bus.png"));

            check_metro s = new check_metro();
            s.txt.Text = "electric";
            s.img.Source = new BitmapImage(new Uri("pack://application:,,,/picture/electric.png"));

            check_metro t = new check_metro();
            t.txt.Text = "metro";
            t.img.Source = new BitmapImage(new Uri("pack://application:,,,/picture/metro.png"));


            foreach (my_type2 q  in type)
            {
                foreach (my_type m in q.my_Types)
                {
                    if (q.datet.Day.ToString() == d)
                    {


                        if (m.opis == "bus" && m.isCheck == true)
                        {
                            first.check.IsChecked = true;

                        }
                        else if (m.opis == "electric" && m.isCheck == true)
                        {
                            s.check.IsChecked = true;

                        }
                        else if (m.opis == "metro" && m.isCheck == true)
                        {
                            t.check.IsChecked = true;

                        }
                    }
                    
                }
            }

            List<check_metro> check_Metros = new List<check_metro>() {first, s, t };
            list.ItemsSource = check_Metros;
            
            
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            (System.Windows.Application.Current.MainWindow as MainWindow).frame.Content = new mounth();
        }
    

        private void back_save_Click(object sender, RoutedEventArgs e)
        {
            logicd logicd = new logicd();
            List<my_type> list1 = new List<my_type>();
            foreach (check_metro my1 in list.Items)
            {

                my_type my = new my_type();
                my.isCheck = my1.check.IsChecked;
                my.put = my1.img.Source.ToString();
                my.opis = my1.txt.Text.ToString();
                list1.Add(my);
            }
            logicd.list = list1;
            logicd.add_to_json(dat);
            (System.Windows.Application.Current.MainWindow as MainWindow).frame.Content = new mounth();
        }
    }
}
