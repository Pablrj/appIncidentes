using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appIncidentes.Interfaz
{
    interface ISujeto
    {

        void Registrar(IObservador ob);

        void Notificar();
    }
}
