using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace metro
{
    internal class logicd
    {
        DateTime d = mounth.now;
        public static List<my_type> list = new List<my_type>();
        string data;
        List<my_type2> type = desir.MyDesirialize<List<my_type2>>();
        public void l(mounth m, int day)
        {
            type = desir.MyDesirialize<List<my_type2>>();
            for (int i = 0; i < day; i++)
            {
                days_block f = new days_block();
                
               
                f.Days.Text = i.ToString();
                m.grid.Children.Add(f);
                try
                {
                    foreach (my_type2 type2 in type)
                    {
                        if (type2.datet.Day.ToString() == f.Days.Text)
                        {
                            if (type2.my_Types[0].isCheck == true)
                            {
                                f.Picture.ImageSource = new BitmapImage(new Uri(type2.my_Types[0].put.ToString()));
                            }
                            else if (type2.my_Types[1].isCheck == true)
                            {
                                f.Picture.ImageSource = new BitmapImage(new Uri(type2.my_Types[1].put.ToString()));
                            }
                            else if (type2.my_Types[2].isCheck == true)
                            {
                                f.Picture.ImageSource = new BitmapImage(new Uri(type2.my_Types[2].put.ToString()));
                            }
                        }
                        else
                        {
                            f.Picture.ImageSource = new BitmapImage(new Uri("pack://application:,,,/picture/tohca.png"));
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(1); }


            }

            
            
        }

        public void add_to_json(string dat)
        {
           
            MessageBox.Show(d.ToString());
            my_type2 my_Type = new my_type2();
            my_Type.datet = d;
            my_Type.my_Types = list;
            type.Add(my_Type);
            desir.MySerialeze(type);
        }


        
    }
}
