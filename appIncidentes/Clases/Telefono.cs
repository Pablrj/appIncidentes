using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appIncidentes.Clases
{
    class Telefono : Incidentes
    {
        public override string Nombre
        {
            get
            {
                return "Telefono";
            }
        }

        public override double costo()
        {
            double baseIn = 0;
            double total = 0;
            if (base.Prioridad == 1 || base.Prioridad == 2)
            {
                total += 90;
            }
            else
            {
                total += 80;
            }

            if (base.Duracion >= 1 && base.Duracion <= 12)
            {
                total += 100;
            }
            else
            {
                if (base.Duracion >= 13 && base.Duracion <= 24)
                {
                    total += 110;
                }
                else
                {
                    total += 125;
                }
            }

            if (base.Gravedad == Gravedad.Alta)
            {
                baseIn = (total + 750) + ((total + 750) * 3.5);
            }
            else
            {
                if (base.Gravedad == Gravedad.Baja)
                {
                    baseIn = (total + 750) + ((total + 750) * 5.5);
                }
                else
                {
                    baseIn = (total + 750) + ((total + 750) * 4.5);
                }
            }
            return baseIn;
        }
    }
}
