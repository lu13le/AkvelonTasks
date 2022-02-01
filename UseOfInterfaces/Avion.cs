using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfInterfaces
{
    class Avion:Vozilo
    {
        private int rasponKrila;

        public Avion(int rasponKrila, int trenutnaBrzina, int maxBrzina, bool motorStartovan) : base(trenutnaBrzina, maxBrzina, motorStartovan)
        {
            this.rasponKrila = rasponKrila;
        }

        public override void ubrzaj()
        {
            if (rasponKrila > 50)
            {
                if (trenutnaBrzina + 20 <= maxBrzina)
                    trenutnaBrzina += 20;
                else
                    trenutnaBrzina = maxBrzina;
            }
            else
            {
                if (trenutnaBrzina + 40 <= maxBrzina)
                    trenutnaBrzina += 40;
                else
                    trenutnaBrzina = maxBrzina;
            }
        }

        public override string ToString()
        {
            return $"Avion\nRaspon krila: {rasponKrila}\n{base.ToString()}";
        }
    }
}
