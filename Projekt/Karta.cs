using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_2_Typy_referencyjne
{ 
    class Karta
    {
        public Karta()
        {
            oceny = new List<float>();
            licznik++;
        }
        // Stan (zmienne - pola)
        private List<float> oceny = new List<float>();
        public static float MinOcena = 0;
        public static float MaxOcena = 10;
        public static long licznik = 0;
        public string Nazwa;

        //Zachowania (metody)
        public kartaStatystyki ObliczStatystyki()
        {
            kartaStatystyki stat = new kartaStatystyki();

            float suma = 0;
            foreach (var ocena in oceny)
            {
                suma += ocena;
            }
            stat.SredniaOcena = suma / oceny.Count();
            stat.NajnizszaOcena = oceny.Min();
            stat.NajwyzszaOcena = oceny.Max();


            return stat;
        }
        /// <summary>
        /// Doddaje nową ocenę do listy ocen
        /// </summary>
        /// <param name="ocena">nowa ocena</param>
        public void DodajOcene(float ocena)
        {
            if (ocena >= 0 && ocena <= 10)
            {
                oceny.Add(ocena);
            }

        }

        

        /// <summary>
        /// obliczania średniejz listy ocen
        /// </summary>
        /// <returns>srednia ocena</returns>
        public float ObliczSrednia()
        {
            float suma = 0;
            float srednia = 0;
            foreach (var ocena in oceny)
            {
                suma += ocena;
            }
            srednia = suma / oceny.Count();
            return srednia;
            //return oceny.Average();
        }
        /// <summary>
        /// Dostajemy najmniejsza ocene
        /// </summary>
        /// <returns>Najmniejsza Ocena</returns>
        public float NajnizszaOcena()
        {
            
            return oceny.Min();
        }
        /// <summary>
        /// Dostajemy największą ocenę
        /// </summary>
        /// <returns>największa ocena</returns>
        public float NajwyzszaOcena()
        {
            return oceny.Max();
        }
    }
}
