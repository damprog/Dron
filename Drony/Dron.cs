using System;
using System.Collections.Generic;
using System.Text;

namespace Dron
{
    abstract class Dron : IDron
    {
        public string nazwa { get; set; }
        public string typ { get; set; }
        public double zasieg { get; set; }
        public bool czyKamera { get; set; }
        public bool czyUszkodzony { get; set; }
        public double predkosc { get; set; }
        public double bateria { get; set; }
        public double[] pozycja { get; set; }
        public Kamera kamera { get; set; }
        public double odleglosc { get; set; }


        public double[] DajPozycje()
        {
            return pozycja;
        }

        public void Ruch(char key)
        {
            if (key == 'w') pozycja[0] += predkosc;
            else if (key == 's') pozycja[0] -= predkosc;
            else if (key == 'a') pozycja[1] -= predkosc;
            else if (key == 'd') pozycja[1] += predkosc;
            else if (key == 'p') Operator.AutoPowrotDrona(); //odwołuje się do statycznej klasy
            Console.WriteLine("\n\nDron porusza się");
            bateria -= 1;
            odleglosc = Math.Sqrt(Math.Pow(pozycja[0], 2) + Math.Pow(pozycja[1], 2));
        }
        public void PokazStatystyki()
        {
            if (!czyUszkodzony)
            {
                Console.WriteLine($"Stan baterii: {bateria}");
                Console.WriteLine($"Odległość od operatora: {odleglosc} metrów");
                Console.WriteLine($"Pozycja drona: {DajPozycje()[0]}, {DajPozycje()[1]}");
            }
            else
            {
                Console.WriteLine("Stan: Uszkodzony");
            }
        }
        public void Uderzenie()
        {
            czyUszkodzony = true;
            Console.WriteLine("Dron uderzył w przeszkodę");
            Console.WriteLine("Dron został unieruchomiony");
        }
        public void PokazInformacje()
        {
            Console.WriteLine($"Nazwa: {nazwa}" +
                $"\nTyp: {typ}" +
                $"\nZasięg: {zasieg} metrów" +
                $"\nPrędkość: {predkosc} m/s" +
                $"\nBateria: {bateria} mAh");
            if (czyKamera) { Console.WriteLine($"Kamera - rozdzielczość {kamera.DajRozdzielczosc()}"); }
            else { Console.WriteLine("Nie posiada kamery"); }
            Console.WriteLine("\n------------------------------------------\n");
        }
    }
}
