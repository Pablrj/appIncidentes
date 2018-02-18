using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appIncidentes.Clases
{
    class Internet : Incidentes
    {
        public override string Nombre
        {
            get
            {
                return "Internet";
            }
        }

        


        public override double costo()
        {
            double baseIn = 0;
            double total = 0;
            if (base.Prioridad == 1 || base.Prioridad == 2)
            {
                total += 200;
            }
            else
            {
                total += 150;
            }

            if (base.Duracion >= 1 && base.Duracion <= 12)
            {
                total += 130;
            }
            else
            {
                if (base.Duracion >= 13 && base.Duracion <= 24)
                {
                    total += 135;
                }
                else
                {
                    total += 140;
                }
            }

            if (base.Gravedad == Gravedad.Alta)
            {
                baseIn = (total + 1500) + ((total + 1500) * 8.5);
            }
            else
            {
                if (base.Gravedad == Gravedad.Baja)
                {
                    baseIn = (total + 1500) + ((total + 1500) * 9.5);
                }
                else
                {
                    baseIn = (total + 1500) + ((total + 1500) * 0.9);
                }
            }
            return baseIn;
        }

        
    }
}
