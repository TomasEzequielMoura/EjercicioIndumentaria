using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EjercicioIndumentaria.Dominio.Indumentaria;

namespace EjercicioIndumentaria.Dominio.Ventas
{
    public class VentaItem
    {
        public VentaItem(Indumentaria.Indumentaria prenda, int cantidad)
        {
            Prenda = prenda;
            Cantidad = cantidad;
        }

        public Indumentaria.Indumentaria Prenda;
        public int Cantidad;

        public double GetTotal()
        {
            return 1;
        }
    }
}
