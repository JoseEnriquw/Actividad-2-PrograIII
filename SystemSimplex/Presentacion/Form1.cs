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
    
    public partial class systemSimplex : Form
    {
        Login login = new Login();
        ArticulosBussines negocio=new ArticulosBussines();
        string where = " ";


        public systemSimplex()
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









        //Cambios agregados x adriel:

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e) //Agregar a 
        {
            tabControl.SelectedIndex = 3;
            comboboxsAdd();
            //Reiniciar campos
            textBoxCodAdd.Text = "";
            textBoxDescripAdd.Text = "";
            textBoxIdAdd.Text = "";
            textBoxNombreAdd.Text = "";
            textBoxPrecioAdd.Text = "";
            textBoxUrlAdd.Text = "";
            buttonAdd.Enabled = false;
            pictureBoxAdd.Load("https://png.pngtree.com/png-vector/20190927/ourlarge/pngtree-red-cross-with-the-outline-coming-out-png-image_1761934.jpg");
        }

        //Agrega los elementos al combobox marca y descripcion de Add
        private void comboboxsAdd()
        {
            if (tabControl.SelectedIndex == 3)
            {
                //Eliminar componentes de los comboboxs
                comboBoxMarcaAdd.Items.Clear();
                comboBoxCategoriaAdd.Items.Clear();

                //Combobox Marca
                /*
                conexion.Open();
                SqlCommand comandoMarcas = new SqlCommand("select * from marcas", conexion);
                SqlDataReader lectorMarcas = comandoMarcas.ExecuteReader();
                while (lectorMarcas.Read())
                {
                    comboBoxMarcaAdd.Items.Add((string)lectorMarcas["descripcion"]);
                }
                conexion.Close();*/

                //Combobox Categoria
                /*
                conexion.Open();
                SqlCommand comandoCateg = new SqlCommand("select * from categorias", conexion);
                SqlDataReader lectorCateg = comandoCateg.ExecuteReader();
                while (lectorCateg.Read())
                {
                    comboBoxCategoriasAdd.Items.Add((string)lectorCateg["descripcion"]);
                }
                conexion.Close();*/

                //Inabilitar boton agregar
                buttonAdd.Enabled = false;
            }
        }

        //Verifica si estan completo todos los datos
        private void changedAddVerific(object sender, EventArgs e)
        {
            int cont = 0;
            if (textBoxCodAdd.Text != "") { cont++; }
            if (textBoxNombreAdd.Text != "") { cont++; }
            if (textBoxPrecioAdd.Text != "") { cont++; }
            if (textBoxDescripAdd.Text != "") { cont++; }
            else
            {
                try
                {
                    labelUrlAdd.ForeColor = Color.Black;
                    pictureBoxAdd.Load(textBoxUrlAdd.Text);
                }
                catch (Exception ex)
                {
                    labelUrlAdd.ForeColor = Color.Red;
                    pictureBoxAdd.Load("https://png.pngtree.com/png-vector/20190927/ourlarge/pngtree-red-cross-with-the-outline-coming-out-png-image_1761934.jpg");
                }
            }
            if (textBoxUrlAdd.Text != "") { cont++; }
            if (comboBoxMarcaAdd.Text != "") { cont++; }
            if (comboBoxCategoriaAdd.Text != "") { cont++; }

            MessageBox.Show("CONTADOR: " + cont);
            if (cont == 7)
            {
                buttonAdd.Enabled = true;
                /*
                conexion.Open();
                SqlCommand comandoId = new SqlCommand("select * from articulos", conexion);
                SqlDataReader lectorId = comandoId.ExecuteReader();
                int UltimaId = 1;
                while (lectorId.Read())
                {
                    UltimaId++;
                }
                textBoxIdAdd.Text = UltimaId.ToString();
                conexion.Close();
                */
            }
            else { buttonAdd.Enabled = false; }
        }
        
        //Al precinar Agregar:
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show
                ("DESEAS AGREGAR ESTE NUEVO PRODUCTO?", "ADVERTENCIA",MessageBoxButtons.YesNoCancel);
            switch (resultado.ToString())
            {
                case "Yes":
                    //Realizar consulta insert
                    string queryAdd = "insert into articulos values ('";
                    queryAdd += textBoxCodAdd.Text + "','";
                    queryAdd += textBoxNombreAdd.Text + "','";
                    queryAdd += textBoxDescripAdd.Text + "',";
                    queryAdd += comboBoxMarcaAdd.SelectedIndex + ",";
                    queryAdd += comboBoxCategoriaAdd.SelectedIndex + ",'";
                    queryAdd += textBoxUrlAdd.Text + "',";
                    queryAdd += textBoxPrecioAdd.Text + ")";
                    /*
                    conexion.Open();
                    SqlCommand comandoAdd = new SqlCommand(queryAdd, conexion);
                    SqlDataAdapter data = new SqlDataAdapter(comandoAdd);
                    conexion.Close();
                    */
                    break;
                case "Cancel":
                    //Reiniciar campos
                    textBoxCodAdd.Text = "";
                    textBoxDescripAdd.Text = "";
                    textBoxIdAdd.Text = "";
                    textBoxNombreAdd.Text = "";
                    textBoxPrecioAdd.Text = "";
                    textBoxUrlAdd.Text = "";
                    buttonAdd.Enabled = false;
                    pictureBoxAdd.Load("");
                    break;
            }
        }

        private void Window_Load(object sender, EventArgs e)
        {
            login.ShowDialog();
            if (login.close == true) { this.Close(); }
        }
    }
}
