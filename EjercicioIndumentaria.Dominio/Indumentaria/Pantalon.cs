using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIndumentaria.Dominio.Indumentaria
{
    public class Pantalon : Indumentaria
    {
        public Pantalon(TipoIndumentaria tipo, int codigo, int stock, string talle, double precio, string material, bool tieneBolsillos) : base(tipo, codigo, stock, talle, precio)
        {
            Material = material;
            TieneBolsillos = tieneBolsillos;
        }

        public string Material;
        public bool TieneBolsillos;

        public string GetDetalle()
        {
            return "";
        }
    }
}
