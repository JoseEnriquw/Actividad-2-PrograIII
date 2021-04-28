using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Bussines;
using Dominio;


namespace Presentacion
{


    /// Pestañas:
    /// 1-Pestaña principal de interfaz; nombre("tabpageMenu") 
    /// 2-Pestaña de Listar; nombre("tabpageListar")
    /// 3-Pestaña de Modificar y Eliminar("tabpageME")
    /// 4-Pestaña de Agregar; nombre("tabpageAgregar")
    
    public partial class Window : Form
    {

        ArticulosBussines negocio=new ArticulosBussines();
        public Window()
        {
            InitializeComponent();
        }



        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            dataGridViewListar.DataSource=negocio.listar("");
        }

        private void codigoDeArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
            labelListar.Text = codigoToolStripMenuItem.Text;
        }

        private void todoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }
    }
}
