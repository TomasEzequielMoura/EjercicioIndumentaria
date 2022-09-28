using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioIndumentaria.Dominio.Ventas;
using EjercicioIndumentaria.Dominio.Indumentaria;

namespace EjercicioIndumentaria.Dominio
{
    public class TiendaRopa
    {
        public TiendaRopa(List<Indumentaria.Indumentaria> inventario, List<Venta> ventas, int ultimoCodigo)
        {
            _Inventario = inventario;
            _Ventas = ventas;
            _ultimoCodigo = ultimoCodigo;
        }

        private List<Indumentaria.Indumentaria> _Inventario;
        private List<Venta> _Ventas;
        private int _ultimoCodigo;

        public int UltimoCodigo { get => _ultimoCodigo; set => _ultimoCodigo = value; }

        public int GetProximoCodigo()
        {
            return 1;
        }

        public void Agregar(Indumentaria.Indumentaria indumentaria)
        {

        }

        public void Modificar(Indumentaria.Indumentaria indumentaria)
        {

        }

        public void Quitar(Indumentaria.Indumentaria indumentaria)
        {

        }

        public void IngresarOrden(Venta venta)
        {

        }

        public List<Indumentaria.Indumentaria> Listar(int value)
        {
            List<Indumentaria.Indumentaria> listIndumentaria = new List<Indumentaria.Indumentaria>();
            return listIndumentaria;
        }

        public List<Orden> ListarOrden(int value)
        {
            List<Orden> listOrden = new List<Orden>();
            return listOrden;
        }

        public void DevolverOrden(Orden orden)
        {

        }
    }
}
