using System;
using System.Collections.Generic;
using System.Text;

namespace Dron
{
    class StatusProxy : IStatus
    {
        IDron dron;
        Status status;
        Adapter adapter;

        public StatusProxy(IDron dron)
        {
            this.dron = dron;
            status = new Status(this.dron);
            adapter = new Adapter(this.dron);
        }

        public void PokazStatystyki()
        {
            //Sprawdzić czy dron uszkodzony czy nie i wykonać odpowiednie zadanie
            if (!dron.czyUszkodzony)
            {
                status.PokazStatystyki();
            }
            else
            {
                adapter.PokazStatystyki();
            }
        }
    }
}
