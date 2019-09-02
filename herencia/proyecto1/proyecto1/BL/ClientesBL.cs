using proyecto1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1.BL
{
    public class ClientesBL
    {
        public List<Clientes> ListadeClientes { get; set; }

          
        public ClientesBL()
        {
            ListadeClientes = new List<Clientes>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "progreso");
            var ciudad2 = new Ciudad(2, "SPS");

            var cliente1 = new Clientes(1, "Angela", 96623524,"1 Calle",ciudad1);
            var cliente2 = new Clientes(2, "Yumari", 31711556, "1 Calle",ciudad2);
            var cliente3 = new Clientes(1, "Jose", 87674567, "1 Calle",ciudad2 );

            ListadeClientes.Add(cliente1);
            ListadeClientes.Add(cliente2);
            ListadeClientes.Add(cliente3);


        }

    }
}
