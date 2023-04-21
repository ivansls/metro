using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
                f.Picture.ImageSource = new BitmapImage(new Uri("pack://application:,,,/picture/tohca.png"));
                main(f);
                


            }

            
            
        }

        public void add_to_json(string dat)
        {

            /*if (type == )
            {
                type = new List<my_type2> { };
                MessageBox.Show(d.ToString());
                my_type2 my_Type = new my_type2();
                my_Type.datet = new DateTime(d.Year, d.Month, Convert.ToInt32(dat));
                my_Type.my_Types = list;
                type.Add(my_Type);
                desir.MySerialeze(type);
            }
            else
            {*/

            /*if (type.Contains())*/


            /*if (type.Contains(my_Type))
            {
                MessageBox.Show(type.IndexOf(my_Type).ToString());
                type.RemoveAt(type.IndexOf(my_Type));
                type.Add(my_Type);
            }
            else
            {
                type.Add(my_Type);
            }
            desir.MySerialeze(type);*/
            if (type.Count == 0)
            {
                my_type2 my_Type = new my_type2();
                my_Type.datet = new DateTime(d.Year, d.Month, Convert.ToInt32(dat));
                my_Type.my_Types = list;
                type.Add(my_Type);
                desir.MySerialeze(type);
            }
            else
            {
                try
                {
                    foreach (my_type2 t in type)
                    {
                        if (t.datet.Day.ToString() == dat)
                        {
                            type.RemoveAt(type.IndexOf(t));
                            my_type2 my_Type = new my_type2();
                            my_Type.datet = new DateTime(t.datet.Year, t.datet.Month, Convert.ToInt32(dat));
                            my_Type.my_Types = list;
                            type.Add(my_Type);
                            desir.MySerialeze(type);
                        }
                        else
                        {
                            my_type2 my_Type = new my_type2();
                            my_Type.datet = new DateTime(d.Year, d.Month, Convert.ToInt32(dat));
                            my_Type.my_Types = list;
                            type.Add(my_Type);
                            desir.MySerialeze(type);
                        }
                    }
                }
                catch { MessageBox.Show("DONE"); }
            }
        }

        public void main(days_block f)
        {

            foreach (my_type2 t in type)
            {
                if (t.datet.Month.ToString() == mounth.now.Month.ToString())
                {
                    MessageBox.Show("12");
                    if (t.datet.Day.ToString() == f.Days.Text)
                    {
                        if (t.my_Types[0].isCheck == true)
                        {
                            f.Picture.ImageSource = new BitmapImage(new Uri(t.my_Types[0].put.ToString()));
                            break;
                        }
                        else if (t.my_Types[1].isCheck == true)
                        {
                            f.Picture.ImageSource = new BitmapImage(new Uri(t.my_Types[1].put.ToString()));
                            break;
                        }
                        else if (t.my_Types[2].isCheck == true)
                        {
                            f.Picture.ImageSource = new BitmapImage(new Uri(t.my_Types[2].put.ToString()));
                            break;
                        }
                        /*MessageBox.Show(t.datet.Day.ToString() + " " + f.Days.Text);*/
                    }
                }

                else
                {
                    break;
                }

            }
        }


        
    }
}
