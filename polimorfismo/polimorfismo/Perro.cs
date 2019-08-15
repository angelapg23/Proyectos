using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    public abstract class Perro: Mamifero
    {

        public bool EstaCorriendo { get; set; }
        public int VecesLadra { get; set; }
        public int LibrasComidas { get; set; }

      public Perro()
        {
            Patas = 4;
        }

        public string Raza { get; set; }


        public abstract void Ladrar();
{}
        

        
    }
}
