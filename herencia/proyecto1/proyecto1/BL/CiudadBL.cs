using proyecto1.Modelos;
using System.Collections.Generic;

namespace proyecto1.BL
{
     public class CiudadBL
    {
        public List<Ciudad> ListadeCiudad { get; set; }
        public object ListadeClientes { get; private set; }

        public CiudadBL()
        {
            ListadeCiudad = new List<Ciudad>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "progreso");
            var ciudad2 = new Ciudad(2, "SPS");

            var cliente1 = new Clientes(1, "Angela", 96623524, "1 Calle", ciudad1);
            var cliente2 = new Clientes(2, "Yumari", 31711556, "1 Calle", ciudad2);
            var cliente3 = new Clientes(1, "Jose", 87674567, "1 Calle", ciudad2);

            ListadeCiudad.Add(ciudad1);
            ListadeCiudad.Add(ciudad2);
            
        }
    }
}
