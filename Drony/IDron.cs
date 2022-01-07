using System;
using System.Collections.Generic;
using System.Text;

namespace Dron
{
    interface IDron
    {
        string nazwa { get; set; }
        string typ { get; set; }
        double[] pozycja { get; set; }
        Kamera kamera { get; set; }
        double zasieg { get; set; }
        bool czyKamera { get; set; }
        bool czyUszkodzony { get; set; }
        double predkosc { get; set; }
        double bateria { get; set; }
        public double odleglosc { get; set; }
        double[] DajPozycje();
        void Ruch(char key);
        void Uderzenie();
        void PokazInformacje();
        void PokazStatystyki();
}
}
