using System;
using System.Collections.Generic;
using System.Text;

namespace Dron
{
    class UgoZephir30 : Dron, IDron
    {
        public UgoZephir30()
        {
            nazwa = "UGO Zephir 3.0";
            typ = "Rekreacyjny";
            zasieg = 50; // metrów
            czyKamera = false;
            czyUszkodzony = false;
            predkosc = 3; // m/s
            bateria = 380; // mAh
            pozycja = new double[2];
            pozycja[0] = 0;
            pozycja[1] = 0;
            if (czyKamera) kamera = new Kamera("");
        }
    }
}
