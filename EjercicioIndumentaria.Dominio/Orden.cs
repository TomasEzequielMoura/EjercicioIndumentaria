using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIndumentaria.Dominio
{
    public class Orden
    {
        public Orden(int codigo, string nombreCliente, string apellidoCliente, int cantidadPrendas, double totalPedido)
        {
            _codigo = codigo;
            _nombreCliente = nombreCliente;
            _apellidoCliente = apellidoCliente;
            _cantidadPrendas = cantidadPrendas;
            _totalPedido = totalPedido;
        }

        private int _codigo;
        private string _nombreCliente;
        private string _apellidoCliente;
        private int _cantidadPrendas;
        private double _totalPedido;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string NombreCliente { get => _nombreCliente; set => _nombreCliente = value; }
        public string ApellidoCliente { get => _apellidoCliente; set => _apellidoCliente = value; }
        public int CantidadPrendas { get => _cantidadPrendas; set => _cantidadPrendas = value; }
        public double TotalPedido { get => _totalPedido; set => _totalPedido = value; }
    }
}
