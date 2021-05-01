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
        AccessData data=new AccessData("DESKTOP-Q2KI0EM\\SQLEXPRESS", "CATALOGO_DB");

        public systemSimplex()
        {
            InitializeComponent();
        }

        //Funcion para hacer visibles solos los items que se usan en el momentos
        private void Visibilidad(short aux) {
            dataGridViewListar.DataSource = null;
            where = " ";
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
                    comboBoxCate_Marca.Items.Clear();
                    comboBoxCate_Marca.Text = " ";
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
            crear_where();
            dataGridViewListar.DataSource=negocio.listar(where);
            dataGridViewListar.Columns[6].Visible = false;
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
           
        }

        //Opción de barra de menu Listar por Codigo de Articulo
        private void codigoDeArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            tabControl.SelectedIndex = 1;
            Visibilidad(1);
            labelListar.Text = codigoToolStripMenuItem.Text;
        }

        //Opción de barra de menu Listar por Nombre
        private void nombreDeArticulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            tabControl.SelectedIndex = 1;
            Visibilidad(1);           
            labelListar.Text = nombreDeArticulToolStripMenuItem.Text;
        }

        //Opción de barra de menu Listar por Descripcion

        private void descripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            tabControl.SelectedIndex = 1;
            Visibilidad(1);
            labelListar.Text = descripcionToolStripMenuItem.Text;

        }


        //Opción de barra de menu Listar por Marca
        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visibilidad(3);
            tabControl.SelectedIndex = 1;
           
            labelCategorias_o_Marcas.Text = marcaToolStripMenuItem.Text;
            Listarcombobox(ref comboBoxCate_Marca, "select * from marcas");
        }

        //Opción de barra de menu Listar por Categoria
        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visibilidad(3);
            labelCategorias_o_Marcas.Text = categoriaToolStripMenuItem.Text;
            Listarcombobox(ref comboBoxCate_Marca, "select * from categorias"); 

        }

        //Opcion de barra de menu Listar por Rango de precio
        private void rangoDePrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            tabControl.SelectedIndex = 1;
            Visibilidad(2);
            textBoxPrecioMAX.Text = textBoxPrecioMIN.Text=" ";

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
                Listarcombobox(ref comboBoxMarcaAdd,"select * from marcas");



                //Combobox Categoria
                Listarcombobox(ref comboBoxCategoriaAdd, "select * from categorias");
         

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

        //Cargar el Login
        private void Window_Load(object sender, EventArgs e)
        {
           // login.ShowDialog();
            //if (login.close) { this.Close(); }
          
        }
        
        //Se usa para agregar los items al combox en tiempo real
        private void Listarcombobox(ref ComboBox aux,string consulta)
        {
            
            try
            {
                data.setearConsulta(consulta);
                data.ejecutarLectura();

                while (data.Lector.Read())
                {
                    aux.Items.Add((string)data.Lector["descripcion"]);
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                data.cerrarConexion();
            }
        }

        private void crear_where()
        {
          if(labelListar.Visible && labelListar.Text=="ID" && textBoxListar.TextLength > 0)
            {
                where = "where A.Id= '" + textBoxListar.Text + "'";
            }

            if (labelListar.Visible && labelListar.Text == "Codigo" && textBoxListar.TextLength > 0)
            {
                where = "where A.Codigo like  '%" + textBoxListar.Text + "%'";
            }

            if (labelListar.Visible && labelListar.Text == "Nombre" && textBoxListar.TextLength > 0)
            {
                where = "where A.Nombre like '%" + textBoxListar.Text + "%'";
            }

            if (labelListar.Visible && labelListar.Text == "Descripcion" && textBoxListar.TextLength > 0)
            {
                where = "where A.Descripcion like '%" + textBoxListar.Text + "%'";
            }

            if (labelCategorias_o_Marcas.Visible && labelCategorias_o_Marcas.Text=="Marca" && comboBoxCate_Marca.SelectedIndex>=0)
            {
                where = "where M.Descripcion = '" + comboBoxCate_Marca.SelectedItem + "'";
            }

            if (labelCategorias_o_Marcas.Visible && labelCategorias_o_Marcas.Text == "Categoria" && comboBoxCate_Marca.SelectedIndex >= 0)
            {
                where = "where C.Descripcion = '" + comboBoxCate_Marca.SelectedItem + "'";
            }

            if (labelRangoPreciolistar.Visible && textBoxPrecioMAX.TextLength>0 && textBoxPrecioMIN.TextLength > 0)
            {
                where = "where A.Precio between " + textBoxPrecioMIN.Text + " and "+ textBoxPrecioMAX.Text;
            }
        }

        
    }
}
