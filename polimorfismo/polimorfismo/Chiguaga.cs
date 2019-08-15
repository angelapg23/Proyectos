using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    public class Chiguaga: Perro
    {
        public override void Ladrar()
        {
            EstaCorriendo = true;
        }

        public void Pelear()
        { }
    }
}
