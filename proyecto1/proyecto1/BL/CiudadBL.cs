using proyecto1.Modelos;
using System.Collections.Generic;

namespace proyecto1.BL
{
     public class CiudadBL
    {
        public List<Ciudad> ListadeCiudad { get; set; }
        public CiudadBL()
        {
            ListadeCiudad = new List<Ciudad>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "progreso");
            var ciudad2 = new Ciudad(2, "SPS");

            ListadeCiudad.Add(ciudad1);
            ListadeCiudad.Add(ciudad2);

        }
    }
}
