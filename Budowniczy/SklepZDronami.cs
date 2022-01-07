using System;
using System.Collections.Generic;
using System.Text;

namespace Dron
{
    class SklepZDronami
    {
        BudowniczyDronow budowniczyPilotow;

        public void Konstruuj(BudowniczyDronow budowniczyPilotow)
        {
            this.budowniczyPilotow = budowniczyPilotow;

            this.budowniczyPilotow.ZamontujPrzyciski();
            this.budowniczyPilotow.SkonfigurujPilot();
        }
    }
}
