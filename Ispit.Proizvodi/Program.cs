using Ispit.Proizvodi.Ekstenzije;
using Ispit.Proizvodi.Klase;

namespace Ispit.Proizvodi;

public class Program
{
    public delegate void PocniPisatiIspit(DateTime datumVrijeme);

    static void Main(string[] args)
    {
        Predavac predavac = new Predavac();

        var listaPolaznika = new List<Polaznik>                                    // instanciranje 8 polaznika putem liste polaznika
        {
            new Polaznik("Tereza Kesovija"),
            new Polaznik("Johnny Stulic"),
            new Polaznik("Darko Rundek"),
            new Polaznik("Dino Dvornik"),
            new Polaznik("Goran Bare"),
            new Polaznik("Zorica Kondza"),
            new Polaznik("Matija Dedic"),
            new Polaznik("Dino Jelusic")
        };

        ShuffleListEkstenzija.Shuffle(listaPolaznika);                            // mijesanje clanova liste polaznika

        List<Polaznik> listaNasumicnihPolaznika = new List<Polaznik>()            // kreiranje nasumicne liste i ubacivanje 4 clana
        {
            listaPolaznika[0],
            listaPolaznika[1],
            listaPolaznika[2],
            listaPolaznika[3]
        };

        predavac.Ispit += Predavac_Ispit;                                         // pretplata na event handler predavaca
        predavac.ZvoniZvono();

        listaNasumicnihPolaznika.ForEach(x => x.OdgovoriNaPitanja(DateTime.Now)); // lambda izraz , iteracija kroz polaznike i ispis vremena pocetka za svakoga

        var odabraniPolaznik = listaNasumicnihPolaznika[0];

        odabraniPolaznik.IspitZavrsen += OdabraniPolaznik_IspitZavrsen;           // pretplata na event handler polaznika
        odabraniPolaznik.PredajOdgovorenaPitanja();

        predavac.IspitZaprimljen(odabraniPolaznik);                               // potvrda predavaca da je ispit zaprimljen

        predavac.Ispit -= Predavac_Ispit;                                         // odplata
        odabraniPolaznik.IspitZavrsen -= OdabraniPolaznik_IspitZavrsen;           // odplata

    }

    private static void Predavac_Ispit(DateTime vrijeme)
    {
        Console.WriteLine($"Vrijeme početka ispita: {vrijeme}\n");
    }

    private static void OdabraniPolaznik_IspitZavrsen(Polaznik polaznik)
    {
        Console.WriteLine($"Ispit zaprimljen od polaznika: {polaznik.ImePrezime}\n");
    }

}