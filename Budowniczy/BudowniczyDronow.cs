using System;
using System.Collections.Generic;
using System.Text;

namespace Dron
{
    abstract class BudowniczyDronow
    {
        public Pilot pilot { get; private set; } //pierwszy produkt
        public Dron dron { get; private set; } //drugi produkt

        public BudowniczyDronow (IDron dron)
        {
            this.dron = (Dron)dron;
            pilot = new Pilot();
        }

        public abstract void ZamontujPrzyciski();
        public abstract void SkonfigurujPilot();
        public abstract Pilot DajGotowyPilot();
    }
}
