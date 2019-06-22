using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class ClassDaneOsobowe
    {
      
        List<string> imiona_i_Nazwiska = new List<string>();

        public void DodajImie_i_Nazwisko(string imie_i_Nazwisko)
        {
            imiona_i_Nazwiska.Add(imie_i_Nazwisko);
        }

        public string Wyswietl_Imie_i_Nazwisko(int index)
        {
            return imiona_i_Nazwiska[index];
            
        }
        public void UsunImie_i_Nazwisko(int imie_i_Nazwisko)
        {
            imiona_i_Nazwiska.RemoveAt(imie_i_Nazwisko);
        }

    }
}
