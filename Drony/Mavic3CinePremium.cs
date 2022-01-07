namespace Dron
{
    class Mavic3CinePremium : Dron, IDron
    {
        public Mavic3CinePremium()
        {
            nazwa = "Mavic 3 Cine Premium";
            typ = "Profesjonalny";
            zasieg = 30000; // metrów
            czyKamera = true;
            czyUszkodzony = false;
            predkosc = 21; // m/s
            bateria = 5000; // mAh
            pozycja = new double[2];
            pozycja[0] = 0;
            pozycja[1] = 0;
            if (czyKamera) kamera = new Kamera("5K (5120 x 2700)");
        }
    }
}
