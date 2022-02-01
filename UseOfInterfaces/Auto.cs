using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfInterfaces
{
    class Auto:Vozilo
    {
        private string brojSasije;

        public Auto(string brojSasije, int trenutnaBrzina, int maxBrzina, bool motorStartovan) : base(trenutnaBrzina, maxBrzina, motorStartovan)
        {
            this.brojSasije = brojSasije;
        }

        public override void ubrzaj()
        {
            if (trenutnaBrzina + 5 <= maxBrzina)
                trenutnaBrzina += 30;
            else
                trenutnaBrzina = maxBrzina;
        }
        public override string ToString()
        {
            return $"AUTO\nBroj sasije: {brojSasije}\n{base.ToString()}";
        }
    }
}
