using System.Collections.Generic;

namespace Dron
{
    //Wzorzec fabryki prostej do tworzenia dronów
    class FabrykaDronow
    {
        List<IDron> drony = new List<IDron>();
        public FabrykaDronow()
        {
            drony.Add(new Mavic3CinePremium());
            drony.Add(new MavicMini2());
            drony.Add(new UgoZephir30());
        }
        public IDron StworzDrona(string nazwa)
        {
            char[] charsToTrim = { ' ', ',', '.' };
            IDron dron = null;
            string n = nazwa.Trim(charsToTrim).ToLower().Replace(" ", "");
            foreach (IDron d in drony)
            {
                if (n.Equals(d.nazwa.Trim(charsToTrim).ToLower().Replace(" ", "")))
                    dron = d;
            }
            return dron;
        }
    }
}
