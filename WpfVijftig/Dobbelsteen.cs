using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfVijftig
{
    partial class Dobbelsteen
    {
        public static Random waarde = new Random();
        public int minimum = 1;
        public int maximum = 7;

        public int worp;

        public Dobbelsteen()
        {
            worp = minimum;
            MethodeDobbel();
        }

        public Dobbelsteen(int Worp)
        {
            this.worp = Worp;
        }

        public int MethodeDobbel()
        {
            worp = waarde.Next(minimum, maximum);
            return worp;
        }

    }
}