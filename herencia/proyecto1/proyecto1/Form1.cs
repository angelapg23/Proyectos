using proyecto1.BL;
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

            var clientesBL = new ClientesBL();
            listadeClientesBindingSource.DataSource = clientesBL.ListadeClientes;

            var ciudadBL = new CiudadBL();
            listadeCiudadBindingSource.DataSource = ciudadBL.ListadeCiudad;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void descripcionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idLabel1_Click(object sender, EventArgs e)
        {

        }

        private void idTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ciudadIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void ciudadIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descripcionLabel_Click(object sender, EventArgs e)
        {

        }
    }
    }

    

    

    

