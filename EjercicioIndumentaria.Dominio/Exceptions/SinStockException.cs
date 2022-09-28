using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIndumentaria.Dominio.Exceptions
{
    public class SinStockException : Exception
    {
        public SinStockException() : base("NO hay mas stock") { }
        public SinStockException(string msg) : base(msg) { }
    }
}
