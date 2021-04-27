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


namespace Presentacion
{


    /// Pestañas:
    /// 1-Pestaña principal de interfaz; nombre("tabpageMenu") 
    /// 2-Pestaña de Listar; nombre("tabpageListar")
    /// 3-Pestaña de Modificar y Eliminar("tabpageME")
    /// 4-Pestaña de Agregar; nombre("tabpageAgregar")
    public partial class Window : Form
    {
        const string server = "DESKTOP-Q2KI0EM\\SQLEXPRESS";
        const string database = "CATALOGO_DB";
        SqlConnection conexion = new SqlConnection("data source=" + server + ";initial catalog=" + database + ";integrated security=true;");
        public Window()
        {
            InitializeComponent();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Comandos para combobox's
            if (tabControl.SelectedIndex == 4) //ADD PAGE
            {
                //Eliminar componentes de los comboboxs
                comboBoxMarcaAdd.Items.Clear();
                comboBoxCategoriasAdd.Items.Clear();

                //Combobox Marca
                conexion.Open();
                SqlCommand comandoMarcas = new SqlCommand("select * from marcas", conexion);
                SqlDataReader lectorMarcas = comandoMarcas.ExecuteReader();
                while (lectorMarcas.Read())
                {
                    comboBoxMarcaAdd.Items.Add((string)lectorMarcas["descripcion"]);
                }
                conexion.Close();

                //Combobox Categoria
                conexion.Open();
                SqlCommand comandoCateg = new SqlCommand("select * from categorias", conexion);
                SqlDataReader lectorCateg = comandoCateg.ExecuteReader();
                while (lectorCateg.Read())
                {
                    comboBoxCategoriasAdd.Items.Add((string)lectorCateg["descripcion"]);
                }
                conexion.Close();

                //Inabilitar boton agregar
                buttonAdd.Enabled = false;
            }
            else if (tabControl.SelectedIndex == 1)
            {
                MessageBox.Show("pagina 2 Aun en prueba");
            }
            else
            {
                MessageBox.Show("pagina 3 Aun en prueba");
            }
        }
    }
}
