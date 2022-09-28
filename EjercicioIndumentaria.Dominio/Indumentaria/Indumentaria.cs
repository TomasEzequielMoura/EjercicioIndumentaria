using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIndumentaria.Dominio.Indumentaria
{
    public abstract class Indumentaria
    {
        public Indumentaria(TipoIndumentaria tipo, int codigo, int stock, string talle, double precio)
        {
            Tipo = tipo;
            Codigo = codigo;
            Stock = stock;
            Talle = talle;
            Precio = precio;
        }

        public TipoIndumentaria Tipo;
        public int Codigo;
        public int Stock;
        public string Talle;
        public double Precio;

        public string ToString()
        {
            return "";
        }

        public bool Equals()
        {
            return false;
        }

        public string GetDetalle()
        {
            return "";
        }

    }
}
