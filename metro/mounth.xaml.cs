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
    /// Логика взаимодействия для mounth.xaml
    /// </summary>
    public partial class mounth : Page
    {
        
        public static DateTime now = DateTime.Now;
        int plusDay = 0;
        public static int a = DateTime.DaysInMonth(now.Year, now.Month);
        logicd lo = new logicd();
        public mounth()
        {
            InitializeComponent();
            lo.l(this , a);
            date.Text = now.ToString();
            txt.Text = now.ToString("yyyy-MMMMMMMMMM");
            back.Content = "-";

        }

       

        
        private void back_Click(object sender, RoutedEventArgs e)
        {

            now = now.AddMonths(-1);
            a = DateTime.DaysInMonth(now.Year, now.Month);
            txt.Text = now.ToString("yyyy-MMMMMMMMMM");
            date.Text = now.ToString();
            lo.l(this, a);
            (Application.Current.MainWindow as MainWindow).frame.Content = new mounth();
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            now = now.AddMonths(1);
            a = DateTime.DaysInMonth(now.Year, now.Month);
            txt.Text = now.ToString("yyyy-MMMMMMMMMM");
            date.Text = now.ToString();
            lo.l(this, a);
            (Application.Current.MainWindow as MainWindow).frame.Content = new mounth();
        }

        private void date_CalendarClosed(object sender, RoutedEventArgs e)
        {
            now = Convert.ToDateTime(date.Text);
            a = DateTime.DaysInMonth(now.Year, now.Month);
            txt.Text = now.ToString("yyyy-MMMMMMMMMM");
            date.Text = now.ToString();
            lo.l(this, a);
            (Application.Current.MainWindow as MainWindow).frame.Content = new mounth();
        }
    }
}
