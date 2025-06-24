using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ispit.Proizvodi.Program;

namespace Ispit.Proizvodi.Klase
{
    public class Predavac
    {
        public event PocniPisatiIspit? Ispit;

        public void ZvoniZvono()
        {
            Console.WriteLine("Zazvonilo je zvono, ispit pocinje!\n");

            Ispit?.Invoke(DateTime.Now);
        }

        public void IspitZaprimljen(Polaznik polaznik)
        {
            Console.WriteLine($"Predavac je zaprimio odgovore od polaznika: {polaznik.ImePrezime}\n");
        }
    }
}
