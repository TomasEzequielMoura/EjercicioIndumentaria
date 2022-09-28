using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIndumentaria.Dominio.Ventas
{
    public class Venta
    {
        public Venta(List<VentaItem> items, Cliente cliente, int estado, int codigo)
        {
            Items = items;
            Cliente = cliente;
            Estado = estado;
            Codigo = codigo;
        }

        public List<VentaItem> Items;
        public Cliente Cliente;
        public int Estado;
        public int Codigo;

        public double GetTotalPedido()
        {
            return 1;
        }
    }
}
