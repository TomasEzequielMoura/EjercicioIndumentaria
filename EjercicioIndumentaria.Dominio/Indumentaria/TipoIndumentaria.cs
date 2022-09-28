using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIndumentaria.Dominio.Indumentaria
{
    public abstract class TipoIndumentaria
    {
        public TipoIndumentaria(string origen, double porcentajeAlgodon)
        {
            Origen = origen;
            PorcentajeAlgodon = porcentajeAlgodon;
        }

        public string Origen;
        public double PorcentajeAlgodon;
    }
}
