using System;
using System.Collections.Generic;
using System.Text;

namespace Dron
{
    class Pilot
    {
        IDron dron { get; set; }
        public IDron Dron { get { return dron; } set { dron = value; } }

        double[] pozycja = new double[2];
        public double[] Pozycja { get { return pozycja; } }

        public Dictionary<Przycisk, char> przyciski = new Dictionary<Przycisk, char>();
        public char this[Przycisk key]
        {
            get { return przyciski[key]; }
            set { przyciski[key] = value; }
        }
        public Pilot()
        {
            pozycja[0] = 0; // x
            pozycja[0] = 0; // y
        }

        public void Ruch(char key)
        {
            char[] k = key.ToString().ToLower().ToCharArray();
            if (przyciski.ContainsValue(k[0]))
            {
                dron.Ruch(key);
                dron.PokazStatystyki();
                SprawdzZasieg();
            }
            else
            {
                Console.WriteLine("Dron nie wie co zrobić");
            }
        }
        public void SprawdzZasieg()
        {
            if(dron.odleglosc > dron.zasieg)
            {
                Console.WriteLine("\n\n@#@#@#@#@#@#@#@#@#@#@");
                Console.WriteLine("Mayday mayday!");
                Console.WriteLine("Jestem poza zasięgiem");
                Console.WriteLine("...");
                dron.Uderzenie();
                dron.PokazStatystyki();
                Operator.KoniecLotu();
            }
        }
        public void AutoPowrotDrona()
        {
            dron.bateria -= dron.odleglosc/dron.predkosc;
            if (dron.bateria <= 0)
            {
                Console.WriteLine("Wykorzystano wszystkie zasoby baterii.");
                Operator.KoniecLotu();
            }
            else
            {
                Console.WriteLine("Dron powrócił do operatora");
                dron.DajPozycje()[0] = 0;
                dron.DajPozycje()[1] = 0;
                dron.PokazStatystyki();
            }
        }
        public void PokazStatystykiDrona()
        {
            dron.PokazStatystyki();
        }
    }
    public enum Przycisk
    {
        W,
        S,
        A,
        D,
        P
    }
}
