
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
            this.tabpageME = new System.Windows.Forms.TabPage();
            this.tabpageAgregar = new System.Windows.Forms.TabPage();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.listarArticuloPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codigoDeArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreDeArticulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.labelPictureBox = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabpageAgregar.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabpageMenu);
            this.tabControl.Controls.Add(this.tabpageListar);
            this.tabControl.Controls.Add(this.tabpageME);
            this.tabControl.Controls.Add(this.tabpageAgregar);
            this.tabControl.Location = new System.Drawing.Point(4, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(793, 445);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
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
            this.tabpageListar.Location = new System.Drawing.Point(4, 22);
            this.tabpageListar.Name = "tabpageListar";
            this.tabpageListar.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageListar.Size = new System.Drawing.Size(785, 419);
            this.tabpageListar.TabIndex = 1;
            this.tabpageListar.Text = "Listar";
            this.tabpageListar.UseVisualStyleBackColor = true;
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
            this.tabpageAgregar.Controls.Add(this.labelPrecio);
            this.tabpageAgregar.Controls.Add(this.labelNombre);
            this.tabpageAgregar.Controls.Add(this.labelCodigo);
            this.tabpageAgregar.Controls.Add(this.labelID);
            this.tabpageAgregar.Controls.Add(this.textBox4);
            this.tabpageAgregar.Controls.Add(this.textBox3);
            this.tabpageAgregar.Controls.Add(this.textBox2);
            this.tabpageAgregar.Controls.Add(this.textBox1);
            this.tabpageAgregar.Controls.Add(this.labelCategoria);
            this.tabpageAgregar.Controls.Add(this.labelMarca);
            this.tabpageAgregar.Controls.Add(this.comboBox2);
            this.tabpageAgregar.Controls.Add(this.comboBox1);
            this.tabpageAgregar.Controls.Add(this.buttonAdd);
            this.tabpageAgregar.Controls.Add(this.labelPictureBox);
            this.tabpageAgregar.Controls.Add(this.pictureBoxAdd);
            this.tabpageAgregar.Location = new System.Drawing.Point(4, 22);
            this.tabpageAgregar.Name = "tabpageAgregar";
            this.tabpageAgregar.Size = new System.Drawing.Size(785, 419);
            this.tabpageAgregar.TabIndex = 3;
            this.tabpageAgregar.Text = "Agregar";
            this.tabpageAgregar.UseVisualStyleBackColor = true;
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
            this.codigoDeArticuloToolStripMenuItem,
            this.nombreDeArticulToolStripMenuItem});
            this.listarArticuloPorToolStripMenuItem.Name = "listarArticuloPorToolStripMenuItem";
            this.listarArticuloPorToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.listarArticuloPorToolStripMenuItem.Text = "Listar Articulo Por";
            // 
            // codigoDeArticuloToolStripMenuItem
            // 
            this.codigoDeArticuloToolStripMenuItem.Name = "codigoDeArticuloToolStripMenuItem";
            this.codigoDeArticuloToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.codigoDeArticuloToolStripMenuItem.Text = "Codigo de Articulo";
            // 
            // nombreDeArticulToolStripMenuItem
            // 
            this.nombreDeArticulToolStripMenuItem.Name = "nombreDeArticulToolStripMenuItem";
            this.nombreDeArticulToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.nombreDeArticulToolStripMenuItem.Text = "Nombre de Articul";
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
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.agregarToolStripMenuItem.Text = "Agregar Articulo";
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
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.Location = new System.Drawing.Point(467, 77);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(299, 257);
            this.pictureBoxAdd.TabIndex = 0;
            this.pictureBoxAdd.TabStop = false;
            // 
            // labelPictureBox
            // 
            this.labelPictureBox.AutoSize = true;
            this.labelPictureBox.Location = new System.Drawing.Point(509, 52);
            this.labelPictureBox.Name = "labelPictureBox";
            this.labelPictureBox.Size = new System.Drawing.Size(104, 13);
            this.labelPictureBox.TabIndex = 1;
            this.labelPictureBox.Text = "Imagen del producto";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(467, 340);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(299, 25);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "AGREGAR";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(223, 133);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(192, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(10, 117);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(37, 13);
            this.labelMarca.TabIndex = 5;
            this.labelMarca.Text = "Marca";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(220, 117);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(52, 13);
            this.labelCategoria.TabIndex = 6;
            this.labelCategoria.Text = "Categoria";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(238, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(115, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(359, 77);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(102, 20);
            this.textBox4.TabIndex = 10;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(10, 61);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(90, 13);
            this.labelID.TabIndex = 11;
            this.labelID.Text = "Id (Autonumerico)";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(113, 61);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 12;
            this.labelCodigo.Text = "Codigo";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(235, 61);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 13;
            this.labelNombre.Text = "Nombre";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(356, 61);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 14;
            this.labelPrecio.Text = "Precio";
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
            this.tabpageAgregar.ResumeLayout(false);
            this.tabpageAgregar.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem codigoDeArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreDeArticulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelPictureBox;
        private System.Windows.Forms.PictureBox pictureBoxAdd;
    }
}

