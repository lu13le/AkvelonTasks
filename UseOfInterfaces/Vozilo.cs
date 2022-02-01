using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfInterfaces
{
    abstract class Vozilo:IVoznja
    {
        protected int trenutnaBrzina;
        protected int maxBrzina;
        protected bool motorStartovan;

        public Vozilo(int trenutnaBrzina, int maxBrzina, bool motorStartovan)
        {
            if (motorStartovan == true)
            {
                this.trenutnaBrzina = trenutnaBrzina;
            }
            else
                this.trenutnaBrzina = 0;
            this.maxBrzina = maxBrzina;
            this.motorStartovan = motorStartovan;
        }

        public abstract void ubrzaj();

        public void start()
        {
            trenutnaBrzina = 0;
            motorStartovan = true;
        }
        public void zaustavi()
        {
            trenutnaBrzina = 0;

        }
        public void parkiraj()
        {
            trenutnaBrzina = 0;
            motorStartovan = false;
        }

        public override string ToString()
        {
            return $"Podaci o vozilu:\nTr. brzina:{trenutnaBrzina}\nMax. brzina: {maxBrzina}\nMotor startovan: {motorStartovan}";
        }
    }
}
