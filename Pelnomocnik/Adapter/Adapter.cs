using System;
using System.Collections.Generic;
using System.Text;

namespace Dron
{
    class Adapter : Status
    {
        //Przysłania klasę status gdy dron sie uszkodzi
        //Za pośrednictwem klasy StatusAdaptee wyświetla aktualny status drona.
        private StatusAdaptee statusAdaptee = new StatusAdaptee();
        public Adapter(IDron dron) : base(dron)
        {
        }
        public override void PokazStatystyki()
        {
            statusAdaptee.PokazStatystykiGdyUszkodzony();
        }
    }
}
