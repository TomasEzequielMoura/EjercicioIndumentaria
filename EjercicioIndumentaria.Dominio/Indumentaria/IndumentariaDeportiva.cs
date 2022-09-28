using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIndumentaria.Dominio.Indumentaria
{
    public class IndumentariaDeportiva : TipoIndumentaria
    {
        public IndumentariaDeportiva(string origen, double porcentajeAlgodon) : base(origen, porcentajeAlgodon)
        {
        }
    }
}
