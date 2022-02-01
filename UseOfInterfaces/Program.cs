using System;

namespace UseOfInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto("12345", 45, 145, false);
            Console.WriteLine(a1);

            a1.start();
            Console.WriteLine("\nAuto posle startovanja\n" + a1);

            a1.ubrzaj();
            Console.WriteLine("\nAuto posle ubrzavanja\n" + a1);

            a1.zaustavi();
            Console.WriteLine("\nAuto posle zaustavljanja\n" + a1);

            a1.parkiraj();
            Console.WriteLine("\nAuto posle parkiranja\n" + a1);


            Avion a2 = new Avion(55, 0, 999, false);
            Console.WriteLine(a2);

            a2.start();
            Console.WriteLine("\nAvion posle startovanja\n" + a2);

            a2.ubrzaj();
            Console.WriteLine("\nAvion posle ubrzavanja\n" + a2);

            a2.zaustavi();
            Console.WriteLine("\nAvion posle zaustavljanja\n" + a2);

            a2.parkiraj();
            Console.WriteLine("\nAvion posle parkiranja\n" + a2);
        }
    }
}
