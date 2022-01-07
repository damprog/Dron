using Dron.Budowniczy;
using System;
using System.Collections.Generic;

namespace Dron
{
    static class Operator
    {
        static Pilot pilot;
        static FabrykaDronow dronFactory = new FabrykaDronow();
        static List<IDron> drony = new List<IDron>();
        static IDron dron;
        static bool dronWLocie = true;
        public static void uruchom()
        {
            drony.Add(new Mavic3CinePremium());
            drony.Add(new MavicMini2());
            drony.Add(new UgoZephir30());
            WybierzDrona();
            Console.Clear();
            Console.WriteLine("Wybrany dron: ");
            dron.PokazInformacje();

            SklepZDronami szd = new SklepZDronami();
            BudowniczyPilota bp = new BudowniczyPilota(dron);
            szd.Konstruuj(bp);
            pilot = bp.DajGotowyPilot(); // Utworzenie pilota za pomoca wzorca kreacyjnego "budowniczy"

            Console.WriteLine($"\nStatystyki drona: "); 
            pilot.PokazStatystykiDrona();
            Console.WriteLine("\nTeraz możesz poruszać dronem");
            Console.WriteLine("w - do przodu");
            Console.WriteLine("s - do tyłu");
            Console.WriteLine("a - w lewo");
            Console.WriteLine("d - w prawo");
            Console.WriteLine("Automatyczny powrót drona: p");
            Console.WriteLine("Zakończenie lotu: z");
            Console.WriteLine("\nUważaj żeby nie wylecieć poza zasięg!");
            Console.WriteLine("Powodzenia!");
            while (dronWLocie)
            {
                char key = Console.ReadKey().KeyChar;
                Console.WriteLine();
                pilot.Ruch(key);
                //TODO sprawdzenie czy nie wyledział poza zasięg
            }
        }

        public static void AutoPowrotDrona()
        {
            pilot.AutoPowrotDrona();
        }

        public static void KoniecLotu()
        {
            dronWLocie = false;
            Console.WriteLine("Koniec lotu");
            Console.ReadLine();
        }

        static void WybierzDrona()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Lista dronów: ");
                foreach (IDron d in drony) d.PokazInformacje();
                Console.WriteLine("Wybierz drona wpisując jego nazwę");
                dron = dronFactory.StworzDrona(Console.ReadLine()); // Stworzenie drona za pomocą 
                                                                    //wzorca kreacyjnego "fabryka prosta"
                if (dron == null) throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Podano niepoprawną nazwę drona!");
                Console.ReadLine();
                WybierzDrona();
            }
        }
    }
}
