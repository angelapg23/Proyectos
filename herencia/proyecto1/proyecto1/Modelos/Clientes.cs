namespace proyecto1.Modelos
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public int CiudadId { get; set; }
        public Ciudad Ciudad { get; set; }
       
      

        public Clientes(int id, string nombre, int telefono,string direccion, Ciudad ciudad)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
            Ciudad  = ciudad;
            CiudadId = ciudad.Id;

            
        }
    }
}
