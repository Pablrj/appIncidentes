using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appIncidentes.Clases
{
    class Television : Incidentes
    {
        public override string Nombre
        {
            get
            {
                return "Television";
            }
        }


        public override double costo()
        {
            double baseIn = 0;
            double total = 0;
            if (base.Prioridad == 1 || base.Prioridad == 2)
            {
                total += 150;
            }
            else
            {
                total += 100;
            }

            if (base.Duracion >= 1 && base.Duracion <= 12)
            {
                total += 120;
            }
            else
            {
                if (base.Duracion >= 13 && base.Duracion <= 24)
                {
                    total += 140;
                }
                else
                {
                    total += 160;
                }
            }

            if (base.Gravedad == Gravedad.Alta)
            {
                baseIn = (total + 100) + ((total + 100) * 0.8);
            }
            else
            {
                if (base.Gravedad == Gravedad.Baja)
                {
                    baseIn = (total + 1000) + ((total + 1000) * 0.4);
                }
                else
                {
                    baseIn = (total + 1000) + ((total + 1000) * 0.6);
                }
            }
            return baseIn;
        }
    }
}
