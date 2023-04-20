﻿using System;
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


            List<check_metro> check_Metros = new List<check_metro>() {first, s, t };
            list.ItemsSource = check_Metros;
            
            
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            logicd logicd = new logicd();
            foreach (check_metro my1 in list.Items)
            {
                my_type my = new my_type();
                my.isCheck = my1.check.IsChecked;
                my.put = my1.img.Source.ToString();
                my.opis = my1.txt.Text.ToString();
                logicd.list.Add(my);
            }
            logicd.add_to_json(dat);
            (System.Windows.Application.Current.MainWindow as MainWindow).frame.Content = new mounth(); ;
        }
    }
}
