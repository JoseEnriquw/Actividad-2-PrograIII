
namespace Presentacion
{
    partial class Window
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabpageMenu = new System.Windows.Forms.TabPage();
            this.tabpageListar = new System.Windows.Forms.TabPage();
            this.comboBoxCate_Marca = new System.Windows.Forms.ComboBox();
            this.labelCategorias_o_Marcas = new System.Windows.Forms.Label();
            this.labelRangoPreciolistar = new System.Windows.Forms.Label();
            this.textBoxPrecioMAX = new System.Windows.Forms.TextBox();
            this.textBoxPrecioMIN = new System.Windows.Forms.TextBox();
            this.textBoxListar = new System.Windows.Forms.TextBox();
            this.labelListar = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataGridViewListar = new System.Windows.Forms.DataGridView();
            this.tabpageME = new System.Windows.Forms.TabPage();
            this.tabpageAgregar = new System.Windows.Forms.TabPage();
            this.textBoxUrlAdd = new System.Windows.Forms.TextBox();
            this.labelUrlAdd = new System.Windows.Forms.Label();
            this.textBoxDescripAdd = new System.Windows.Forms.TextBox();
            this.labelDescripAdd = new System.Windows.Forms.Label();
            this.labelPrecioAdd = new System.Windows.Forms.Label();
            this.labelNombreAdd = new System.Windows.Forms.Label();
            this.labelCodigoAdd = new System.Windows.Forms.Label();
            this.labelIdAdd = new System.Windows.Forms.Label();
            this.textBoxPrecioAdd = new System.Windows.Forms.TextBox();
            this.textBoxNombreAdd = new System.Windows.Forms.TextBox();
            this.textBoxCodAdd = new System.Windows.Forms.TextBox();
            this.textBoxIdAdd = new System.Windows.Forms.TextBox();
            this.labelCategoriaAdd = new System.Windows.Forms.Label();
            this.labelMarcaAdd = new System.Windows.Forms.Label();
            this.comboBoxCategoriaAdd = new System.Windows.Forms.ComboBox();
            this.comboBoxMarcaAdd = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelImagenAdd = new System.Windows.Forms.Label();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.listarArticuloPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreDeArticulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descripcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rangoDePrecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tabpageListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListar)).BeginInit();
            this.tabpageAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabpageMenu);
            this.tabControl.Controls.Add(this.tabpageListar);
            this.tabControl.Controls.Add(this.tabpageME);
            this.tabControl.Controls.Add(this.tabpageAgregar);
            this.tabControl.Location = new System.Drawing.Point(4, 18);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(793, 445);
            this.tabControl.TabIndex = 0;
            // 
            // tabpageMenu
            // 
            this.tabpageMenu.Location = new System.Drawing.Point(4, 22);
            this.tabpageMenu.Name = "tabpageMenu";
            this.tabpageMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageMenu.Size = new System.Drawing.Size(785, 419);
            this.tabpageMenu.TabIndex = 0;
            this.tabpageMenu.Text = "Interfaz ";
            this.tabpageMenu.UseVisualStyleBackColor = true;
            // 
            // tabpageListar
            // 
            this.tabpageListar.Controls.Add(this.comboBoxCate_Marca);
            this.tabpageListar.Controls.Add(this.labelCategorias_o_Marcas);
            this.tabpageListar.Controls.Add(this.labelRangoPreciolistar);
            this.tabpageListar.Controls.Add(this.textBoxPrecioMAX);
            this.tabpageListar.Controls.Add(this.textBoxPrecioMIN);
            this.tabpageListar.Controls.Add(this.textBoxListar);
            this.tabpageListar.Controls.Add(this.labelListar);
            this.tabpageListar.Controls.Add(this.buttonBuscar);
            this.tabpageListar.Controls.Add(this.dataGridViewListar);
            this.tabpageListar.Location = new System.Drawing.Point(4, 22);
            this.tabpageListar.Name = "tabpageListar";
            this.tabpageListar.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageListar.Size = new System.Drawing.Size(785, 419);
            this.tabpageListar.TabIndex = 1;
            this.tabpageListar.Text = "Listar";
            this.tabpageListar.UseVisualStyleBackColor = true;
            // 
            // comboBoxCate_Marca
            // 
            this.comboBoxCate_Marca.FormattingEnabled = true;
            this.comboBoxCate_Marca.Location = new System.Drawing.Point(598, 38);
            this.comboBoxCate_Marca.Name = "comboBoxCate_Marca";
            this.comboBoxCate_Marca.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCate_Marca.TabIndex = 7;
            // 
            // labelCategorias_o_Marcas
            // 
            this.labelCategorias_o_Marcas.AutoSize = true;
            this.labelCategorias_o_Marcas.Location = new System.Drawing.Point(595, 22);
            this.labelCategorias_o_Marcas.Name = "labelCategorias_o_Marcas";
            this.labelCategorias_o_Marcas.Size = new System.Drawing.Size(0, 13);
            this.labelCategorias_o_Marcas.TabIndex = 6;
            this.labelCategorias_o_Marcas.Visible = false;
            // 
            // labelRangoPreciolistar
            // 
            this.labelRangoPreciolistar.AutoSize = true;
            this.labelRangoPreciolistar.Location = new System.Drawing.Point(342, 17);
            this.labelRangoPreciolistar.Name = "labelRangoPreciolistar";
            this.labelRangoPreciolistar.Size = new System.Drawing.Size(172, 13);
            this.labelRangoPreciolistar.TabIndex = 3;
            this.labelRangoPreciolistar.Text = "Precio Mínimo y Máximo del  rango";
            this.labelRangoPreciolistar.Visible = false;
            // 
            // textBoxPrecioMAX
            // 
            this.textBoxPrecioMAX.Location = new System.Drawing.Point(445, 38);
            this.textBoxPrecioMAX.Name = "textBoxPrecioMAX";
            this.textBoxPrecioMAX.Size = new System.Drawing.Size(56, 20);
            this.textBoxPrecioMAX.TabIndex = 5;
            this.textBoxPrecioMAX.Visible = false;
            // 
            // textBoxPrecioMIN
            // 
            this.textBoxPrecioMIN.Location = new System.Drawing.Point(345, 38);
            this.textBoxPrecioMIN.Name = "textBoxPrecioMIN";
            this.textBoxPrecioMIN.Size = new System.Drawing.Size(56, 20);
            this.textBoxPrecioMIN.TabIndex = 4;
            this.textBoxPrecioMIN.Visible = false;
            // 
            // textBoxListar
            // 
            this.textBoxListar.Location = new System.Drawing.Point(53, 38);
            this.textBoxListar.Name = "textBoxListar";
            this.textBoxListar.Size = new System.Drawing.Size(264, 20);
            this.textBoxListar.TabIndex = 3;
            this.textBoxListar.Visible = false;
            // 
            // labelListar
            // 
            this.labelListar.AutoSize = true;
            this.labelListar.Location = new System.Drawing.Point(103, 17);
            this.labelListar.Name = "labelListar";
            this.labelListar.Size = new System.Drawing.Size(0, 13);
            this.labelListar.TabIndex = 2;
            this.labelListar.Visible = false;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.DarkViolet;
            this.buttonBuscar.Location = new System.Drawing.Point(229, 360);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(305, 38);
            this.buttonBuscar.TabIndex = 1;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dataGridViewListar
            // 
            this.dataGridViewListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListar.Location = new System.Drawing.Point(17, 64);
            this.dataGridViewListar.Name = "dataGridViewListar";
            this.dataGridViewListar.Size = new System.Drawing.Size(728, 290);
            this.dataGridViewListar.TabIndex = 0;
            // 
            // tabpageME
            // 
            this.tabpageME.Location = new System.Drawing.Point(4, 22);
            this.tabpageME.Name = "tabpageME";
            this.tabpageME.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageME.Size = new System.Drawing.Size(785, 419);
            this.tabpageME.TabIndex = 2;
            this.tabpageME.Text = "Modificar o Eliminar";
            this.tabpageME.UseVisualStyleBackColor = true;
            // 
            // tabpageAgregar
            // 
            this.tabpageAgregar.Controls.Add(this.textBoxUrlAdd);
            this.tabpageAgregar.Controls.Add(this.labelUrlAdd);
            this.tabpageAgregar.Controls.Add(this.textBoxDescripAdd);
            this.tabpageAgregar.Controls.Add(this.labelDescripAdd);
            this.tabpageAgregar.Controls.Add(this.labelPrecioAdd);
            this.tabpageAgregar.Controls.Add(this.labelNombreAdd);
            this.tabpageAgregar.Controls.Add(this.labelCodigoAdd);
            this.tabpageAgregar.Controls.Add(this.labelIdAdd);
            this.tabpageAgregar.Controls.Add(this.textBoxPrecioAdd);
            this.tabpageAgregar.Controls.Add(this.textBoxNombreAdd);
            this.tabpageAgregar.Controls.Add(this.textBoxCodAdd);
            this.tabpageAgregar.Controls.Add(this.textBoxIdAdd);
            this.tabpageAgregar.Controls.Add(this.labelCategoriaAdd);
            this.tabpageAgregar.Controls.Add(this.labelMarcaAdd);
            this.tabpageAgregar.Controls.Add(this.comboBoxCategoriaAdd);
            this.tabpageAgregar.Controls.Add(this.comboBoxMarcaAdd);
            this.tabpageAgregar.Controls.Add(this.buttonAdd);
            this.tabpageAgregar.Controls.Add(this.labelImagenAdd);
            this.tabpageAgregar.Controls.Add(this.pictureBoxAdd);
            this.tabpageAgregar.Location = new System.Drawing.Point(4, 22);
            this.tabpageAgregar.Name = "tabpageAgregar";
            this.tabpageAgregar.Size = new System.Drawing.Size(785, 419);
            this.tabpageAgregar.TabIndex = 3;
            this.tabpageAgregar.Text = "Agregar";
            this.tabpageAgregar.UseVisualStyleBackColor = true;
            // 
            // textBoxUrlAdd
            // 
            this.textBoxUrlAdd.Location = new System.Drawing.Point(14, 373);
            this.textBoxUrlAdd.Multiline = true;
            this.textBoxUrlAdd.Name = "textBoxUrlAdd";
            this.textBoxUrlAdd.Size = new System.Drawing.Size(448, 25);
            this.textBoxUrlAdd.TabIndex = 18;
            this.textBoxUrlAdd.TextChanged += new System.EventHandler(this.changedAddVerific);
            // 
            // labelUrlAdd
            // 
            this.labelUrlAdd.AutoSize = true;
            this.labelUrlAdd.Location = new System.Drawing.Point(11, 354);
            this.labelUrlAdd.Name = "labelUrlAdd";
            this.labelUrlAdd.Size = new System.Drawing.Size(66, 13);
            this.labelUrlAdd.TabIndex = 17;
            this.labelUrlAdd.Text = "URL imagen";
            // 
            // textBoxDescripAdd
            // 
            this.textBoxDescripAdd.Location = new System.Drawing.Point(14, 157);
            this.textBoxDescripAdd.Multiline = true;
            this.textBoxDescripAdd.Name = "textBoxDescripAdd";
            this.textBoxDescripAdd.Size = new System.Drawing.Size(448, 194);
            this.textBoxDescripAdd.TabIndex = 16;
            this.textBoxDescripAdd.TextChanged += new System.EventHandler(this.changedAddVerific);
            // 
            // labelDescripAdd
            // 
            this.labelDescripAdd.AutoSize = true;
            this.labelDescripAdd.Location = new System.Drawing.Point(11, 141);
            this.labelDescripAdd.Name = "labelDescripAdd";
            this.labelDescripAdd.Size = new System.Drawing.Size(63, 13);
            this.labelDescripAdd.TabIndex = 15;
            this.labelDescripAdd.Text = "Descripcion";
            // 
            // labelPrecioAdd
            // 
            this.labelPrecioAdd.AutoSize = true;
            this.labelPrecioAdd.Location = new System.Drawing.Point(356, 61);
            this.labelPrecioAdd.Name = "labelPrecioAdd";
            this.labelPrecioAdd.Size = new System.Drawing.Size(37, 13);
            this.labelPrecioAdd.TabIndex = 14;
            this.labelPrecioAdd.Text = "Precio";
            // 
            // labelNombreAdd
            // 
            this.labelNombreAdd.AutoSize = true;
            this.labelNombreAdd.Location = new System.Drawing.Point(235, 61);
            this.labelNombreAdd.Name = "labelNombreAdd";
            this.labelNombreAdd.Size = new System.Drawing.Size(44, 13);
            this.labelNombreAdd.TabIndex = 13;
            this.labelNombreAdd.Text = "Nombre";
            // 
            // labelCodigoAdd
            // 
            this.labelCodigoAdd.AutoSize = true;
            this.labelCodigoAdd.Location = new System.Drawing.Point(113, 61);
            this.labelCodigoAdd.Name = "labelCodigoAdd";
            this.labelCodigoAdd.Size = new System.Drawing.Size(40, 13);
            this.labelCodigoAdd.TabIndex = 12;
            this.labelCodigoAdd.Text = "Codigo";
            // 
            // labelIdAdd
            // 
            this.labelIdAdd.AutoSize = true;
            this.labelIdAdd.Location = new System.Drawing.Point(10, 61);
            this.labelIdAdd.Name = "labelIdAdd";
            this.labelIdAdd.Size = new System.Drawing.Size(90, 13);
            this.labelIdAdd.TabIndex = 11;
            this.labelIdAdd.Text = "Id (Autonumerico)";
            // 
            // textBoxPrecioAdd
            // 
            this.textBoxPrecioAdd.Location = new System.Drawing.Point(359, 77);
            this.textBoxPrecioAdd.Name = "textBoxPrecioAdd";
            this.textBoxPrecioAdd.Size = new System.Drawing.Size(102, 20);
            this.textBoxPrecioAdd.TabIndex = 10;
            this.textBoxPrecioAdd.TextChanged += new System.EventHandler(this.changedAddVerific);
            // 
            // textBoxNombreAdd
            // 
            this.textBoxNombreAdd.Location = new System.Drawing.Point(238, 77);
            this.textBoxNombreAdd.Name = "textBoxNombreAdd";
            this.textBoxNombreAdd.Size = new System.Drawing.Size(115, 20);
            this.textBoxNombreAdd.TabIndex = 9;
            this.textBoxNombreAdd.TextChanged += new System.EventHandler(this.changedAddVerific);
            // 
            // textBoxCodAdd
            // 
            this.textBoxCodAdd.Location = new System.Drawing.Point(116, 77);
            this.textBoxCodAdd.Name = "textBoxCodAdd";
            this.textBoxCodAdd.Size = new System.Drawing.Size(116, 20);
            this.textBoxCodAdd.TabIndex = 8;
            this.textBoxCodAdd.TextChanged += new System.EventHandler(this.changedAddVerific);
            // 
            // textBoxIdAdd
            // 
            this.textBoxIdAdd.Enabled = false;
            this.textBoxIdAdd.Location = new System.Drawing.Point(13, 77);
            this.textBoxIdAdd.Name = "textBoxIdAdd";
            this.textBoxIdAdd.Size = new System.Drawing.Size(97, 20);
            this.textBoxIdAdd.TabIndex = 7;
            // 
            // labelCategoriaAdd
            // 
            this.labelCategoriaAdd.AutoSize = true;
            this.labelCategoriaAdd.Location = new System.Drawing.Point(235, 101);
            this.labelCategoriaAdd.Name = "labelCategoriaAdd";
            this.labelCategoriaAdd.Size = new System.Drawing.Size(52, 13);
            this.labelCategoriaAdd.TabIndex = 6;
            this.labelCategoriaAdd.Text = "Categoria";
            // 
            // labelMarcaAdd
            // 
            this.labelMarcaAdd.AutoSize = true;
            this.labelMarcaAdd.Location = new System.Drawing.Point(10, 101);
            this.labelMarcaAdd.Name = "labelMarcaAdd";
            this.labelMarcaAdd.Size = new System.Drawing.Size(37, 13);
            this.labelMarcaAdd.TabIndex = 5;
            this.labelMarcaAdd.Text = "Marca";
            // 
            // comboBoxCategoriaAdd
            // 
            this.comboBoxCategoriaAdd.FormattingEnabled = true;
            this.comboBoxCategoriaAdd.Location = new System.Drawing.Point(238, 117);
            this.comboBoxCategoriaAdd.Name = "comboBoxCategoriaAdd";
            this.comboBoxCategoriaAdd.Size = new System.Drawing.Size(223, 21);
            this.comboBoxCategoriaAdd.TabIndex = 4;
            this.comboBoxCategoriaAdd.SelectedIndexChanged += new System.EventHandler(this.changedAddVerific);
            // 
            // comboBoxMarcaAdd
            // 
            this.comboBoxMarcaAdd.FormattingEnabled = true;
            this.comboBoxMarcaAdd.Location = new System.Drawing.Point(13, 117);
            this.comboBoxMarcaAdd.Name = "comboBoxMarcaAdd";
            this.comboBoxMarcaAdd.Size = new System.Drawing.Size(219, 21);
            this.comboBoxMarcaAdd.TabIndex = 3;
            this.comboBoxMarcaAdd.SelectedIndexChanged += new System.EventHandler(this.changedAddVerific);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(467, 373);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(299, 25);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "AGREGAR";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelImagenAdd
            // 
            this.labelImagenAdd.AutoSize = true;
            this.labelImagenAdd.Location = new System.Drawing.Point(464, 61);
            this.labelImagenAdd.Name = "labelImagenAdd";
            this.labelImagenAdd.Size = new System.Drawing.Size(104, 13);
            this.labelImagenAdd.TabIndex = 1;
            this.labelImagenAdd.Text = "Imagen del producto";
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAdd.Location = new System.Drawing.Point(467, 77);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(299, 290);
            this.pictureBoxAdd.TabIndex = 0;
            this.pictureBoxAdd.TabStop = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarArticuloPorToolStripMenuItem,
            this.actualizarToolStripMenuItem,
            this.configuracionToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // listarArticuloPorToolStripMenuItem
            // 
            this.listarArticuloPorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todoToolStripMenuItem,
            this.IDToolStripMenuItem,
            this.codigoToolStripMenuItem,
            this.nombreDeArticulToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.descripcionToolStripMenuItem,
            this.rangoDePrecioToolStripMenuItem});
            this.listarArticuloPorToolStripMenuItem.Name = "listarArticuloPorToolStripMenuItem";
            this.listarArticuloPorToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.listarArticuloPorToolStripMenuItem.Text = "Listar Articulo Por";
            // 
            // todoToolStripMenuItem
            // 
            this.todoToolStripMenuItem.Name = "todoToolStripMenuItem";
            this.todoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.todoToolStripMenuItem.Text = "Todo";
            this.todoToolStripMenuItem.Click += new System.EventHandler(this.todoToolStripMenuItem_Click);
            // 
            // IDToolStripMenuItem
            // 
            this.IDToolStripMenuItem.Name = "IDToolStripMenuItem";
            this.IDToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.IDToolStripMenuItem.Text = "ID";
            this.IDToolStripMenuItem.Click += new System.EventHandler(this.iDToolStripMenuItem_Click);
            // 
            // codigoToolStripMenuItem
            // 
            this.codigoToolStripMenuItem.Name = "codigoToolStripMenuItem";
            this.codigoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.codigoToolStripMenuItem.Text = "Codigo";
            this.codigoToolStripMenuItem.Click += new System.EventHandler(this.codigoDeArticuloToolStripMenuItem_Click);
            // 
            // nombreDeArticulToolStripMenuItem
            // 
            this.nombreDeArticulToolStripMenuItem.Name = "nombreDeArticulToolStripMenuItem";
            this.nombreDeArticulToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.nombreDeArticulToolStripMenuItem.Text = "Nombre";
            this.nombreDeArticulToolStripMenuItem.Click += new System.EventHandler(this.nombreDeArticulToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // descripcionToolStripMenuItem
            // 
            this.descripcionToolStripMenuItem.Name = "descripcionToolStripMenuItem";
            this.descripcionToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.descripcionToolStripMenuItem.Text = "Descripcion";
            // 
            // rangoDePrecioToolStripMenuItem
            // 
            this.rangoDePrecioToolStripMenuItem.Name = "rangoDePrecioToolStripMenuItem";
            this.rangoDePrecioToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.rangoDePrecioToolStripMenuItem.Text = "Rango de Precio";
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarArticuloToolStripMenuItem});
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarToolStripMenuItem.Text = "Agregar Articulo";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.modificarToolStripMenuItem.Text = "Modificar Articulo";
            // 
            // eliminarArticuloToolStripMenuItem
            // 
            this.eliminarArticuloToolStripMenuItem.Name = "eliminarArticuloToolStripMenuItem";
            this.eliminarArticuloToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.eliminarArticuloToolStripMenuItem.Text = "Eliminar Articulo";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.tabControl);
            this.Name = "Window";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabpageListar.ResumeLayout(false);
            this.tabpageListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListar)).EndInit();
            this.tabpageAgregar.ResumeLayout(false);
            this.tabpageAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabpageMenu;
        private System.Windows.Forms.TabPage tabpageListar;
        private System.Windows.Forms.TabPage tabpageME;
        private System.Windows.Forms.TabPage tabpageAgregar;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem listarArticuloPorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreDeArticulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.Label labelRangoPreciolistar;
        private System.Windows.Forms.TextBox textBoxPrecioMAX;
        private System.Windows.Forms.TextBox textBoxPrecioMIN;
        private System.Windows.Forms.TextBox textBoxListar;
        private System.Windows.Forms.Label labelListar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dataGridViewListar;
        private System.Windows.Forms.ToolStripMenuItem todoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descripcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IDToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxCate_Marca;
        private System.Windows.Forms.Label labelCategorias_o_Marcas;
        private System.Windows.Forms.ToolStripMenuItem rangoDePrecioToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxUrlAdd;
        private System.Windows.Forms.Label labelUrlAdd;
        private System.Windows.Forms.TextBox textBoxDescripAdd;
        private System.Windows.Forms.Label labelDescripAdd;
        private System.Windows.Forms.Label labelPrecioAdd;
        private System.Windows.Forms.Label labelNombreAdd;
        private System.Windows.Forms.Label labelCodigoAdd;
        private System.Windows.Forms.Label labelIdAdd;
        private System.Windows.Forms.TextBox textBoxPrecioAdd;
        private System.Windows.Forms.TextBox textBoxNombreAdd;
        private System.Windows.Forms.TextBox textBoxCodAdd;
        private System.Windows.Forms.TextBox textBoxIdAdd;
        private System.Windows.Forms.Label labelCategoriaAdd;
        private System.Windows.Forms.Label labelMarcaAdd;
        private System.Windows.Forms.ComboBox comboBoxCategoriaAdd;
        private System.Windows.Forms.ComboBox comboBoxMarcaAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelImagenAdd;
        private System.Windows.Forms.PictureBox pictureBoxAdd;
    }
}

