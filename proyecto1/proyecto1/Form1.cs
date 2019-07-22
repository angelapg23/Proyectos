using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var clientes1 = new Cliente();
            clientes1.Id = 1;
            clientes1.Nombre = "Angela";
            clientes1.Ciudad = "El progreso";

            Cliente clientes2 = new Cliente();
            clientes2.Id = 2;
            clientes2.Nombre = "Jose";
            clientes2.Ciudad = "San pedro sula";

            
            var listadeclientes = new List<Cliente>();
            listadeclientes.Add(clientes1);
            listadeclientes.Add(clientes2);

            foreach (var c in listadeclientes)
            {
                MessageBox.Show(c.Nombre);
                MessageBox.Show(c.Ciudad);




            }

        }
    }

    public class Cliente
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
    }
}
    

    

