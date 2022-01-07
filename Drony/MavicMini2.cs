using System;

namespace Dron
{
    class MavicMini2 : Dron, IDron
    {
        public MavicMini2()
        {
            nazwa = "Mavic Mini 2";
            typ = "Rekreacyjny";
            zasieg = 6000; // metrów
            czyKamera = true;
            czyUszkodzony = false;
            predkosc = 16; // m/s
            bateria = 2250; // mAh
            pozycja = new double[2];
            pozycja[0] = 0;
            pozycja[1] = 0;
            if (czyKamera) kamera = new Kamera("4K (3840 x 2160)");
        }
    }
}
