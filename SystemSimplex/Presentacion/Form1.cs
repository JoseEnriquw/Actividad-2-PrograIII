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
        string where = " ";
        public Window()
        {
            InitializeComponent();
        }


        private void Visibilidad(short aux) {

            switch (aux){
                case 1:
                    textBoxPrecioMAX.Visible = textBoxPrecioMIN.Visible = comboBoxCate_Marca.Visible = labelRangoPreciolistar.Visible = labelCategorias_o_Marcas.Visible = false;
                    textBoxListar.Visible = labelListar.Visible = true;
                break;

                case 2:

                   textBoxListar.Visible = labelListar.Visible = comboBoxCate_Marca.Visible  = labelCategorias_o_Marcas.Visible = false;
                    textBoxPrecioMAX.Visible = textBoxPrecioMIN.Visible = labelRangoPreciolistar.Visible = true;
                    break;

                case 3:
                    textBoxPrecioMAX.Visible = textBoxPrecioMIN.Visible = textBoxListar.Visible = labelListar.Visible  = labelRangoPreciolistar.Visible = false;
                    comboBoxCate_Marca.Visible =labelCategorias_o_Marcas.Visible = true;
                    break;
                
                default:
                    textBoxPrecioMAX.Visible = textBoxPrecioMIN.Visible = textBoxListar.Visible = labelListar.Visible = labelRangoPreciolistar.Visible = comboBoxCate_Marca.Visible = labelCategorias_o_Marcas.Visible = false;
                    
                    break;
            }


        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            dataGridViewListar.DataSource=negocio.listar("");
        }

        

        //Opción de barra de menu Listar Todo
        private void todoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visibilidad(0);
            tabControl.SelectedIndex = 1;
           
        }

        //Opción de barra de menu Listar por ID
        private void iDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visibilidad(1);
            tabControl.SelectedIndex = 1;
            labelListar.Text = IDToolStripMenuItem.Text;
            where = "where A.Id= '" + textBoxListar.Text + "'";
        }

        //Opción de barra de menu Listar por Codigo de Articulo
        private void codigoDeArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visibilidad(1);
            tabControl.SelectedIndex = 1;
            where = "where A.Codigo= '" + textBoxListar.Text + "'";
            labelListar.Text = codigoToolStripMenuItem.Text;
        }

        //Opción de barra de menu Listar por Nombre
        private void nombreDeArticulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visibilidad(1);
            tabControl.SelectedIndex = 1;
            where = "where A.Nombre= '" + textBoxListar.Text + "'";
            labelListar.Text = nombreDeArticulToolStripMenuItem.Text;
        }

        
    }
}
