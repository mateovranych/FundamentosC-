using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosC_.Models
{
	class vodkas : bebidas , IbebidaAlcoholica
	{
        
        public vodkas(int Cantidad,string Nombre="Vodka") : base(Nombre, Cantidad)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
        }

		public int Alcohol { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}   
}
