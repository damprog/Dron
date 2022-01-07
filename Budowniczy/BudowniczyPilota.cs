using System;
using System.Collections.Generic;
using System.Text;

namespace Dron.Budowniczy
{
    class BudowniczyPilota : BudowniczyDronow
    {
        public BudowniczyPilota(IDron dron) : base(dron) { }
        public override void SkonfigurujPilot()
        {
            this.pilot.Dron = this.dron;
        }

        public override void ZamontujPrzyciski()
        {
            pilot[Przycisk.W] = 'w';
            pilot[Przycisk.S] = 's';
            pilot[Przycisk.A] = 'a';
            pilot[Przycisk.D] = 'd';
            pilot[Przycisk.P] = 'p';
        }

        public override Pilot DajGotowyPilot()
        {
            return pilot;
        }
    }
}
