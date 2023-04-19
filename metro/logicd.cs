using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace metro
{
    internal class logicd
    {
        DateTime d = mounth.now;
        public static List<my_type> list = new List<my_type>();
        string data;
        public void l(mounth m, int day)
        {

            for (int i = 1; i < day + 1; i++)
            {
                days_block f = new days_block();
                try {
                    
                        if (list[0].opis == "bus")
                        {
                            if ((i + 1).ToString() == data)
                            {
                                f.Picture.ImageSource = new BitmapImage(new Uri("pack://application:,,,/picture/bus.png"));
                            }   
                        }
                        else if (list[0].opis == "electric")
                        {
                            if ((i + 1).ToString() == data)
                            {
                                f.Picture.ImageSource = new BitmapImage(new Uri("pack://application:,,,/picture/electric.png"));
                            }
                        }
                        else if (list[0].opis == "metro")
                        {
                            if ((i + 1).ToString() == data)
                            {
                                f.Picture.ImageSource = new BitmapImage(new Uri("pack://application:,,,/picture/metro.png"));
                            }
                        }
                    

                    
                }
                catch (Exception e)
                {
                    f.Picture.ImageSource = new BitmapImage(new Uri("pack://application:,,,/picture/tohca.png"));
                }
               
                f.Days.Text = i.ToString();
                m.grid.Children.Add(f);

            }
        }

        public void add_to_json(string dat)
        {
            mounth mounth = new mounth();
            data = dat;
            days_block days = new days_block();
            check_metro check_Metro = new check_metro();
            d = new DateTime(Convert.ToInt32(mounth.now.Year), Convert.ToInt32(mounth.now.Month), Convert.ToInt32(dat));
            MessageBox.Show(d.ToString());
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    MessageBox.Show(list[i].isCheck.ToString() + " " + list[i].put.ToString() + " " + list[i].opis.ToString());
                }
                catch 
                {
                    continue;
                }
            }
        }


        
    }
}
