using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa_herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var superman = new Heroe();
            superman.Id = 01;
            superman.Nombre = "clark";
            superman.Poder = "Volar";

            var capitanAmerica = new Heroe();
            capitanAmerica.Id = 02;
            capitanAmerica.Nombre = "stevenrogers";
            capitanAmerica.Poder = "Fuerza";

            var hulk = new Heroe();
            hulk.Id = 03;
            hulk.Nombre = "BruceBaner";
            hulk.Poder = "Fuerza";

            var doctdum = new Villano();
            doctdum.Id = 01;
            doctdum.Nombre = "VictorDum";

            var thanos = new Villano();
            thanos.Id = 02;
            thanos.Nombre = "ElThanos";

            var loki = new Villano();
            loki.Id = 03;
            loki.Nombre = "ElDiosdelaMentira";
        }
    }
}
