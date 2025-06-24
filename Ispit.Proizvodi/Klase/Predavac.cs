using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Proizvodi.Klase
{
    public class Predavac
    {
        public event EventHandler<DateTime>? Ispit;

        public void ZvoniZvono()
        {
            Console.WriteLine("Zazvonilo je zvono, ispit pocinje!");

            Ispit?.Invoke(this, DateTime.Now);
        }

        public void IspitZaprimljen(Polaznik polaznik)
        {
            Console.WriteLine($"Predavac je zaprimio odgovore od polaznika: {polaznik.ImePrezime}\n");
        }
    }
}
