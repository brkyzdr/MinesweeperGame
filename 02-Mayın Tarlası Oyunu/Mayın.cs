using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _02_Mayın_Tarlası_Oyunu
{
    public class Mayın
    {
        Point loc;
        bool dolu;
        bool bakildi;

        public Mayın(Point loca)
        {
            dolu = false;
            loc = loca;
        }

        public Point konumAl
        {
            get { return loc; }
        }

        public bool mayinVarMi
        {
            get { return dolu; }
            set { dolu = value; }
        }

        public bool bakildi_
        {
            get { return bakildi; }
            set { bakildi = value; }
        }
    }
}
