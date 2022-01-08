using System;

namespace Dron
{
    class Status : IStatus
    { 
        //Ta klasa jest używna gdy dron jest sprawny
        //Gdy dron sie uszkodzi ta klasa jest przysłonięta przez Adapter.
        IDron dron;
        public Status(IDron dron)
        {
            this.dron = dron;

        }
        public virtual void PokazStatystyki()
        {
            Console.WriteLine($"Stan baterii: {dron.bateria}");
            Console.WriteLine($"Odległość od operatora: {dron.odleglosc} metrów");
            Console.WriteLine($"Pozycja drona: {dron.DajPozycje()[0]}, {dron.DajPozycje()[1]}");
        }
    }
}
