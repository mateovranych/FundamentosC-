using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosC_.Models
{
	internal class bebidas
	{
        public string nombre { get; set; }  
        public int cantidad { get; set; }
        public bebidas(string nombre, int cantidad)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
        }
        public void beber(int cantidadBebida)
        {
            this.cantidad -= cantidadBebida;
        }

    }
}
