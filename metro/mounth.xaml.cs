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
        logicd lo = new logicd();
        public mounth()
        {
            InitializeComponent();
            lo.l(this , MainWindow.a);

        }

        /*public void t()
        {
            logicd.l(this);
        }*/

        private void grid_LostTouchCapture(object sender, TouchEventArgs e)
        {
            MessageBox.Show("123");
        }
    }
}
