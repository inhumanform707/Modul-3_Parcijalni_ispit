using Ispit.Proizvodi.Klase;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Proizvodi.Ekstenzije
{
    public static class ShuffleListEkstenzija
    {
        public static Random Rand { get; set; } = new Random();

        public static List<Polaznik> Shuffle(this List<Polaznik> listaPolaznika)
        {
            for (int i = 0; i < listaPolaznika.Count; i++)
            {
                int j = Rand.Next(listaPolaznika.Count);

                Polaznik privremeni = listaPolaznika[i];
                listaPolaznika[i] = listaPolaznika[j];
                listaPolaznika[j] = privremeni;
            }

            return listaPolaznika;
        }

    }
}
