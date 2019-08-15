using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyecto1.Modelos;

namespace proyecto1.BL
{
    public class ProductoBL
    {
        public List<Producto> ListadeProductos { get; set; }

        public ProductoBL()
        {
            ListadeProductos = new List<Producto>();
            CrearDatosdePrueba();


        }
        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Laptop");
            var categoria2 = new Categoria(2, "Accesorios");

            var producto1 = new Producto(1, "Laptop DELL", 15000, categoria1);
            var producto2 = new Producto(2, "Laptop Axus", 20000, categoria1);
            var producto3 = new Producto(3, "Mouse Logitech", 150, categoria2);


            ListadeProductos.Add(producto1);
            ListadeProductos.Add(producto2);
            ListadeProductos.Add(producto3);

        }
    }
}