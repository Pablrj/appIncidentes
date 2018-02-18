using appIncidentes.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appIncidentes.Interfaz
{
    interface IObservador
    {
        void Actualizar(Incidentes incidentes);        
    }
}
