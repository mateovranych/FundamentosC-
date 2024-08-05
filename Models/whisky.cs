using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosC_.Models
{
	class whisky
	{

		public string name { get; set; }
		public int ms { get; set; }

        public whisky(string name, int ms)
        {
            this.name = name;
            this.ms = ms;
        }

        public void beber(int cantidadBebidaDeWhisky)
        {
            this.ms -= cantidadBebidaDeWhisky;
        }
    }
}
