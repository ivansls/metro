using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace metro
{
    internal class logicd
    {
        public void l(mounth m, int day)
        {
            
            for (int i = 1; i < day + 1; i++)
            {
                days_block f = new days_block();

                f.Days.Text = i.ToString();
                m.grid.Children.Add(f);

            }
        }


        
    }
}
