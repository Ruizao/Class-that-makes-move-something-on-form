using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecto_stor_3
{
    class Class1
    {
        public void Move(object sender)
        {
            Random r = new Random();
            int _x = (int.Parse(r.Next(500).ToString()));
            int _y = (int.Parse(r.Next(250).ToString()) + 100);
            Point pt = new Point(_x,_y);
            Button b = (Button)sender;
            b.Location = pt;

        }
    }
}
