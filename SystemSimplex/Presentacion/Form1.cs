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

using System.IO;


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
        AccessData data=new AccessData("DESKTOP-C14H989\\SQLEXPRESS", "CATALOGO_DB");
        //DESKTOP-Q2KI0EM\\SQLEXPRESS (Enrique)
        //DESKTOP-C14H989\\SQLEXPRESS (Adriel)
        

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
                case 4:
                    textBoxCodAdd.Text = "";textBoxDescripAdd.Text = "";textBoxIdAdd.Text = "";textBoxNombreAdd.Text = "";textBoxPrecioAdd.Text = "";textBoxUrlAdd.Text = "";buttonAdd.Enabled = false;
                    pictureBoxAdd.Load("https://png.pngtree.com/png-vector/20190927/ourlarge/pngtree-red-cross-with-the-outline-coming-out-png-image_1761934.jpg");
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
            tabControl.SelectedIndex = 1; Visibilidad(1);
            labelListar.Text = codigoToolStripMenuItem.Text;
        }

        //Opción de barra de menu Listar por Nombre
        private void nombreDeArticulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1; Visibilidad(1);           
            labelListar.Text = nombreDeArticulToolStripMenuItem.Text;
        }

        //Opción de barra de menu Listar por Descripcion

        private void descripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1; Visibilidad(1);
            labelListar.Text = descripcionToolStripMenuItem.Text;
        }


        //Opción de barra de menu Listar por Marca
        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visibilidad(3); tabControl.SelectedIndex = 1;
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
            tabControl.SelectedIndex = 1; Visibilidad(2);
            textBoxPrecioMAX.Text = textBoxPrecioMIN.Text=" ";
        }

        //Cambios agregados x adriel:

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e) //Agregar a 
        {
            tabControl.SelectedIndex = 3;
            Visibilidad(4);
            comboboxsAdd();
            try{
                data.setearConsulta("select * from articulos");
                int UltimaId = 1;
                data.ejecutarLectura();
                while (data.Lector.Read()) { UltimaId++; }
                textBoxIdAdd.Text = UltimaId.ToString();
            }
            catch (Exception ex) { throw ex; }
            finally { data.cerrarConexion(); }
        }
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
            comboBoxMarcaMod.Items.Clear();
            comboBoxCategMod.Items.Clear();
            Listarcombobox(ref comboBoxMarcaMod, "select * from marcas");
            Listarcombobox(ref comboBoxCategMod, "select * from categorias");
        }


        //Agrega los elementos al combobox marca y descripcion de Add
        private void comboboxsAdd()
        {
            if (tabControl.SelectedIndex == 3)
            {
                //Eliminar componentes de los comboboxs
                comboBoxMarcaAdd.Items.Clear();
                comboBoxCategAdd.Items.Clear();
                Listarcombobox(ref comboBoxMarcaAdd,"select * from marcas");
                Listarcombobox(ref comboBoxCategAdd, "select * from categorias");
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
                    labelUrlAdd.BackColor = Color.Black;
                    pictureBoxAdd.Load(textBoxUrlAdd.Text);
                }
                catch (Exception ex)
                {
                    labelUrlAdd.BackColor = Color.Red;
                    pictureBoxAdd.Load("https://png.pngtree.com/png-vector/20190927/ourlarge/pngtree-red-cross-with-the-outline-coming-out-png-image_1761934.jpg");
                }
            }
            if (textBoxUrlAdd.Text != "") { cont++; }
            if (comboBoxMarcaAdd.Text != "") { cont++; }
            if (comboBoxCategAdd.Text != "") { cont++; }
            if (cont == 7){ buttonAdd.Enabled = true;}
            else { buttonAdd.Enabled = false; }
        }
        
        //Al precionar Agregar:
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show
            ("DESEAS AGREGAR ESTE NUEVO PRODUCTO?", "ADVERTENCIA",MessageBoxButtons.YesNoCancel);
            switch (resultado.ToString())
            {
                case "Yes":
                    //Realizar consulta insert
                    string queryAdd = "insert into articulos values ('";
                    queryAdd += textBoxCodAdd.Text + "','"; queryAdd += textBoxNombreAdd.Text + "','"; queryAdd += textBoxDescripAdd.Text + "',";
                    int cbmarca = comboBoxMarcaAdd.SelectedIndex + 1; queryAdd += cbmarca + ",";
                    int cbcateg = comboBoxCategAdd.SelectedIndex + 1; queryAdd += cbcateg + ",'";
                    queryAdd += textBoxUrlAdd.Text + "',"; queryAdd += textBoxPrecioAdd.Text + ")";
                    data.setearConsulta(queryAdd);
                    data.ejectutarAccion(); data.cerrarConexion();
                    MessageBox.Show("Articulo agregado con exito!");
                break;
                case "Cancel":
                    //Reiniciar campos
                    Visibilidad(4);
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
        private void Listarcombobox(ref ComboBox aux,string consulta){
            try{
                data.setearConsulta(consulta); data.ejecutarLectura();
                while (data.Lector.Read()){ aux.Items.Add((string)data.Lector["descripcion"]);}
            }catch (Exception ex){ throw ex; } finally{ data.cerrarConexion();}
        }

        private void cambioMod(object sender,EventArgs e)
        {
            dataGridMod.DataSource = negocio.listar(condicionMod());
        }

        private string condicionMod()
        {
            //Crea la condicion
            bool andc = false; int cont = 0; string queryCondicion = " where ";
            if (textBoxIdMod.Text != "") { queryCondicion += "id = " + textBoxIdMod.Text; andc = true; cont++; }

            if (andc == true && textBoxCodMod.Text != "") {             queryCondicion += " and "; andc = false; }
            if (textBoxCodMod.Text != "") { queryCondicion += "codigo LIKE '%" + textBoxCodMod.Text + "%'"; andc = true; cont++; }

            if (andc == true && textBoxNombreMod.Text != "") {          queryCondicion += " and "; andc = false; }
            if (textBoxNombreMod.Text != "") { queryCondicion += "nombre LIKE '%" + textBoxNombreMod.Text + "%'"; andc = true; cont++; }

            if (andc == true && textBoxDescripMod.Text != "") {         queryCondicion += " and "; andc = false; }
            if (textBoxDescripMod.Text != "") { queryCondicion += "descripcion LIKE '%" + textBoxDescripMod.Text + "%'"; andc = true; cont++; }

            if (andc == true && textBoxPrecioMod.Text != "" || textBoxPrecioMinMod.Text != "" || textBoxPrecioMaxMod.Text != "")
            { queryCondicion += " and "; andc = false; cont++; }
            if (textBoxPrecioMod.Text != "") { queryCondicion += "precio = " + double.Parse(textBoxPrecioMod.Text); ; andc = true; }
            else if (textBoxPrecioMinMod.Text != "" && textBoxPrecioMaxMod.Text != "")
            { queryCondicion += "between " + textBoxPrecioMinMod.Text + " and " + textBoxPrecioMaxMod.Text;}
            else if (textBoxPrecioMinMod.Text != "") { queryCondicion += "precio <= " + textBoxPrecioMinMod.Text; }
            else if (textBoxPrecioMaxMod.Text != "") { queryCondicion += "precio >= " + textBoxPrecioMaxMod.Text; }

            if (andc == true && comboBoxMarcaMod.SelectedIndex >= 0) {  queryCondicion += " and "; andc = false; }
            if (comboBoxMarcaMod.SelectedIndex >= 0)
            {
                int cb = comboBoxMarcaMod.SelectedIndex + 1;
                queryCondicion += "idMarca = " + cb.ToString();
                andc = true; cont++;
            }

            if (andc == true && comboBoxCategMod.SelectedIndex >= 0) { queryCondicion += " and ";}
            if (comboBoxCategMod.SelectedIndex >= 0)
            {
                int cb = comboBoxCategMod.SelectedIndex + 1;
                queryCondicion += "idCategoria = " + cb.ToString();
                cont++;
            }
            if (cont == 0) { queryCondicion = ""; }
            return queryCondicion;
        }

        private void crear_where()
        {
          if(labelListar.Visible && labelListar.Text=="ID" && textBoxListar.TextLength > 0)
            { where = "where A.Id= '" + textBoxListar.Text + "'";}

            if (labelListar.Visible && labelListar.Text == "Codigo" && textBoxListar.TextLength > 0)
            { where = "where A.Codigo like  '%" + textBoxListar.Text + "%'";}

            if (labelListar.Visible && labelListar.Text == "Nombre" && textBoxListar.TextLength > 0)
            { where = "where A.Nombre like '%" + textBoxListar.Text + "%'";}

            if (labelListar.Visible && labelListar.Text == "Descripcion" && textBoxListar.TextLength > 0)
            { where = "where A.Descripcion like '%" + textBoxListar.Text + "%'";}

            if (labelCategorias_o_Marcas.Visible && labelCategorias_o_Marcas.Text=="Marca" && comboBoxCate_Marca.SelectedIndex>=0)
            { where = "where M.Descripcion = '" + comboBoxCate_Marca.SelectedItem + "'";}

            if (labelCategorias_o_Marcas.Visible && labelCategorias_o_Marcas.Text == "Categoria" && comboBoxCate_Marca.SelectedIndex >= 0)
            { where = "where C.Descripcion = '" + comboBoxCate_Marca.SelectedItem + "'";}

            if (labelRangoPreciolistar.Visible && textBoxPrecioMAX.TextLength>0 && textBoxPrecioMIN.TextLength > 0)
            { where = "where A.Precio between " + textBoxPrecioMIN.Text + " and "+ textBoxPrecioMAX.Text;}
        }

        public bool cantidadModificar(int cant)
        {
            bool opc = false;
            DialogResult result = MessageBox.Show("DESEAS MODIFICAR " + cant + " ARTICULOS?", "ADVERTENCIA", MessageBoxButtons.YesNo);
            if (result.ToString() == "Yes") { opc = true; }
            return opc;
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            if (buttonMod.Text == "MODIFICAR")
            {
                data.setearConsulta("select * from articulos " + condicionMod());
                data.ejecutarLectura(); int cant = 0;
                while (data.Lector.Read()){ cant++;} data.cerrarConexion();
             
                if (cantidadModificar(cant) == true)
                {
                    textBoxIdMod.Text = "";         textBoxPrecioMinMod.Text = "";
                    textBoxPrecioMinMod.Text = "";  textBoxPrecioMaxMod.Text = "";
                    textBoxPrecioMaxMod.Text = "";  buttonMod.Text = "APLICAR";
                    textBoxIdMod.Enabled = true;        textBoxUrlMod.Visible = true;
                    textBoxPrecioMinMod.Enabled = true; textBoxPrecioMinMod.Visible = false;
                    textBoxPrecioMaxMod.Enabled = true; textBoxPrecioMaxMod.Visible = false;
                    textBoxUrlMod.Enabled = false; 
                }
            }
            else
            {
                data.setearConsulta("select * from articulos " + condicionMod());
                data.ejecutarLectura(); int cant = 0;
                while (data.Lector.Read()) { cant++; } data.cerrarConexion();

                if (cantidadModificar(cant) == true)
                {
                    bool and = false;
                    string update = "update articulos set ";
                    if (textBoxIdMod.Text != "") { update += "id = " + textBoxIdMod.Text; and = true; }

                    if (and == true && textBoxCodMod.Text != "") {              update += ", "; and = false; }
                    if (textBoxCodMod.Text != "") { update += "codigo = '" + textBoxCodMod.Text + "'"; and = true; }

                    if (and == true && textBoxNombreMod.Text != "") {           update += ", "; and = false; }
                    if (textBoxNombreMod.Text != "") { update += "nombre = '" + textBoxNombreMod.Text + "'"; and = true; }

                    if (and == true && textBoxDescripMod.Text != "") {          update += ", "; and = false; }
                    if (textBoxDescripMod.Text != "") { update += "descripcion ='" + textBoxDescripMod.Text + "'"; and = true; }

                    if (and == true && textBoxPrecioMod.Text != "") {           update += ", "; and = false; }
                    if (textBoxPrecioMod.Text != "") { update += "precio =" + textBoxPrecioMod.Text; and = true; }

                    if (and == true && comboBoxMarcaMod.SelectedIndex >= 0) {   update += ", "; and = false; }
                    if (comboBoxMarcaMod.SelectedIndex >= 0)
                    {
                        int cb = comboBoxMarcaMod.SelectedIndex + 1;
                        update += "idMarca = " + cb.ToString(); and = true;
                    }
                    if (and == true && comboBoxCategMod.SelectedIndex >= 0) {   update += ", ";}
                    if (comboBoxCategMod.SelectedIndex > 0)
                    {
                        int cb = comboBoxCategMod.SelectedIndex + 1;
                        update += "idCategoria = " + cb.ToString();
                    }
                    data.setearConsulta(update + condicionMod());
                    data.ejectutarAccion(); data.cerrarConexion();
                    MessageBox.Show("Los cambios fueron cambiados exitosamente");
                    dataGridMod.DataSource = negocio.listar(condicionMod());

                    buttonMod.Text = "MODIFICAR";        textBoxUrlMod.Text = "";
                    textBoxPrecioMinMod.Enabled = false; textBoxUrlMod.Visible = false;
                    textBoxPrecioMaxMod.Enabled = false; textBoxIdMod.Enabled = false;
                    textBoxPrecioMinMod.Visible = true;  textBoxPrecioMaxMod.Visible = true; 
                    textBoxUrlMod.Enabled = true;       
                }
                else
                {
                    buttonMod.Text = "MODIFICAR";        textBoxUrlMod.Text = ""; 
                    textBoxPrecioMinMod.Enabled = false; textBoxIdMod.Enabled = false;
                    textBoxPrecioMaxMod.Enabled = false; textBoxUrlMod.Visible = false;
                    textBoxPrecioMinMod.Visible = true;  textBoxUrlMod.Enabled = true;
                    textBoxPrecioMaxMod.Visible = true; 
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            int cant = 0;
            data.setearConsulta("select * from articulos " + condicionMod());
            data.ejecutarLectura();
            while (data.Lector.Read()) { cant++; } data.cerrarConexion();

            if (cantidadModificar(cant) == true)
            {
                data.setearConsulta("delete * from articulos" + condicionMod());
                data.ejectutarAccion(); data.cerrarConexion();
                MessageBox.Show("Los cambios fueron cambiados exitosamente");
                dataGridMod.DataSource = negocio.listar(condicionMod());
            }
        }

        private void buttonBuscar_MouseHover(object sender, EventArgs e){   buttonBuscar.BackColor = Color.Black;}
        private void buttonBuscar_MouseLeave(object sender, EventArgs e){   buttonBuscar.BackColor = Color.DimGray;}
        private void buttonMod_MouseHover(object sender, EventArgs e){      buttonMod.BackColor = Color.Black;}
        private void buttonMod_MouseLeave(object sender, EventArgs e){      buttonMod.BackColor = Color.DimGray;}
        private void buttonDel_MouseHover(object sender, EventArgs e){      buttonDel.BackColor = Color.Black;}
        private void buttonDel_MouseLeave(object sender, EventArgs e){      buttonDel.BackColor = Color.DimGray;}
        private void buttonAdd_MouseHover(object sender, EventArgs e){      buttonAdd.BackColor = Color.Black;}
        private void buttonAdd_MouseLeave(object sender, EventArgs e){      buttonAdd.BackColor = Color.DimGray; }
    }
}
