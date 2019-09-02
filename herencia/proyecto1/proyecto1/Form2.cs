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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            var productosBL = new ProductoBL();
            listadeProductosBindingSource.DataSource = productosBL.ListadeProductos;

            var categoriasBL = new CategoriaBL();
            listadeCategoriasBindingSource.DataSource = categoriasBL.ListadeCategorias;




        }

        private void listadeProductosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
