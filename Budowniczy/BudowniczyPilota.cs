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
            this.pilot.Status = new StatusProxy(this.pilot.Dron);
        }

        public override void ZamontujPrzyciski()
        {
            pilot[Przycisk.W] = 'w';
            pilot[Przycisk.S] = 's';
            pilot[Przycisk.A] = 'a';
            pilot[Przycisk.D] = 'd';
            pilot[Przycisk.P] = 'p';
            pilot[Przycisk.Z] = 'z';
        }

        public override Pilot DajGotowyPilot()
        {
            return pilot;
        }
    }
}
