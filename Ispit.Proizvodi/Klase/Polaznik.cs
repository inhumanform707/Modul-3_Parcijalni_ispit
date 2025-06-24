using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Proizvodi.Klase
{
    public class Polaznik
    {
        public delegate void PredajIspit(Polaznik polaznik);
        public event EventHandler<Polaznik>? IspitZavrsen;
        
        public string? ImePrezime { get; set; }

        public Polaznik(string imePrezime)
        {
            ImePrezime = imePrezime;
        }

        public void OdgovoriNaPitanja(DateTime vrijemePocetka)
        {
            Console.WriteLine($"Ime i prezime polaznika: {ImePrezime}, Datum i vrijeme pristupanja ispitu: {vrijemePocetka}");
        }

        public void PredajOdgovorenaPitanja()
        {
            Console.WriteLine($"\nPolaznik: {ImePrezime} je predao odgovore\n");

            IspitZavrsen?.Invoke(this, this);
        }
    }
}
