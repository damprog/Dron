using System;
using System.Collections.Generic;
using System.Text;

namespace Dron
{
    class Kamera
    {
        bool czyNagrywa;
        string rozdzielczoscFilmow;
        public Kamera(string rozdzielczoscFilmow)
        {
            czyNagrywa = false;
            this.rozdzielczoscFilmow = rozdzielczoscFilmow;
        }

        public void WlaczNagrywanie() 
        {
            if (!czyNagrywa)
            {
                Console.WriteLine("Nagrywanie zostało włączone");
                czyNagrywa = true;
            }
            else
            {
                Console.WriteLine("Nagrywanie jest już włączone");
            }
        }
        public void WylaczNagrywanie() 
        {
            if (czyNagrywa)
            {
                ZakonczNagrywanie();
            }
            else
            {
                Console.WriteLine("Nagrywanie jest już wyłączone");
            }
        }

        public void ZakonczNagrywanie()
        {
            Console.WriteLine("Zakończono nagrywanie.");
            czyNagrywa = false;
        }

        public string DajRozdzielczosc()
        {
            return rozdzielczoscFilmow;
        }
    }
}
