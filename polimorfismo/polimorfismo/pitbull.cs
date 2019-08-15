using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    public class pitbull : Perro
    {


        public override void Ladrar()
        {
            VecesLadra = 2;
            EstaCorriendo = false;
        }

            public void Pelear() { }
           
        }
    }

