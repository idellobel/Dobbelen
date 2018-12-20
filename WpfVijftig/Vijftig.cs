using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfVijftig
{
    partial class Vijftig
    {
        public Dobbelsteen x = new Dobbelsteen();
        public Dobbelsteen y = new Dobbelsteen();

        public int score = 0;

        public int worp;

        public int GooiWorp(Dobbelsteen x, Dobbelsteen y)
        {
            score = x.worp + y.worp;

            if (x.worp == 6 && y.worp == 6)
                score += 25;

            if (x.worp == y.worp && x.worp != 6 && y.worp != 6)
                score += 5;

            if (x.worp == 3 && y.worp == 3)
                score *= 0;

            return score;
        }

        public int Gooiworp()
        {
            score = worp * 2;

            if (worp == 6)
                score += 25;

            if (worp != 6)
                score += 5;

            if (worp == 3)
                score *= 0;


            return score;

        }

        public Vijftig()
        {
            GooiWorp(x, y);
        }

        public Vijftig(int worp)
        {
            this.worp = worp;
            Gooiworp();

        }
    }
}