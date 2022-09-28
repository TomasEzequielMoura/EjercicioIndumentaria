using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIndumentaria.Dominio.Indumentaria
{
    public class Camisa : Indumentaria
    {

        public Camisa(TipoIndumentaria tipo, int codigo, int stock, string talle, double precio, string tipoManga, bool tieneEstampado) : base(tipo, codigo, stock, talle, precio)
        {
            TipoManga = tipoManga;
            TieneEstampado = tieneEstampado;
        }

        public bool TieneEstampado;
        public string TipoManga;

        public string GetDetalle()
        {
            return "";
        }
    }
}
