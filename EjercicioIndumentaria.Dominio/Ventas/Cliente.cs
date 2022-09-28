using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIndumentaria.Dominio.Ventas
{
    public class Cliente
    {
        public Cliente(string apellido, string nombre, int estado, int codigo)
        {
            Codigo = codigo;
            Apellido = apellido;
            Nombre = nombre;
        }

        public int Codigo;
        public string Apellido;
        public string Nombre;
    }
}
