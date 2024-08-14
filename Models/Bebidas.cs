using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosC_.Models
{
	public class Bebidas
	{
		public string Nombre { get; set; }
		public float Cantidad { get; set; }

        public Bebidas(string Nombre, float Cantidad)
        {
            this.Nombre = Nombre;  
            this.Cantidad = Cantidad;
        }
    }
}
