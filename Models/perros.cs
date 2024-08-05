using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosC_.Models
{
    class perros
    {
        public string name { get; set; }
        public int weight { get; set; }


        public perros(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public void Lipo(int lossWeight)
        {
            this.weight -= lossWeight;
        }
    }
}
