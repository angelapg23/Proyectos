using proyecto1.BL;
using proyecto1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1.BL
{
    public class CategoriaBL
    {
        public List<Categoria> ListadeCategorias { get; set; }

        public CategoriaBL()
        {
            ListadeCategorias = new List<Categoria>();
            DatosdePrueba();

        }


        private void DatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Laptop");
            var categoria2 = new Categoria(2, "Accesorios");

            ListadeCategorias.Add(categoria1);
            ListadeCategorias.Add(categoria2);
        }

    }
}
