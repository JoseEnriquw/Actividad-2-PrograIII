
namespace Presentacion
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAdm = new System.Windows.Forms.RadioButton();
            this.radioButtonUser = new System.Windows.Forms.RadioButton();
            this.labelServer = new System.Windows.Forms.Label();
            this.labelDataBase = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.textBoxDataBase = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonAdm);
            this.groupBox1.Controls.Add(this.radioButtonUser);
            this.groupBox1.Controls.Add(this.labelServer);
            this.groupBox1.Controls.Add(this.labelDataBase);
            this.groupBox1.Controls.Add(this.labelUser);
            this.groupBox1.Controls.Add(this.labelPass);
            this.groupBox1.Controls.Add(this.textBoxServer);
            this.groupBox1.Controls.Add(this.textBoxDataBase);
            this.groupBox1.Controls.Add(this.textBoxPass);
            this.groupBox1.Controls.Add(this.textBoxUser);
            this.groupBox1.Controls.Add(this.buttonLogin);
            this.groupBox1.Location = new System.Drawing.Point(10, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loguate con tu usuario*";
            // 
            // radioButtonAdm
            // 
            this.radioButtonAdm.AutoSize = true;
            this.radioButtonAdm.Location = new System.Drawing.Point(297, 87);
            this.radioButtonAdm.Name = "radioButtonAdm";
            this.radioButtonAdm.Size = new System.Drawing.Size(88, 17);
            this.radioButtonAdm.TabIndex = 19;
            this.radioButtonAdm.Text = "Administrador";
            this.radioButtonAdm.UseVisualStyleBackColor = true;
            this.radioButtonAdm.CheckedChanged += new System.EventHandler(this.radioButtonAdm_CheckedChanged);
            // 
            // radioButtonUser
            // 
            this.radioButtonUser.AutoSize = true;
            this.radioButtonUser.Checked = true;
            this.radioButtonUser.Location = new System.Drawing.Point(215, 87);
            this.radioButtonUser.Name = "radioButtonUser";
            this.radioButtonUser.Size = new System.Drawing.Size(61, 17);
            this.radioButtonUser.TabIndex = 1;
            this.radioButtonUser.TabStop = true;
            this.radioButtonUser.Text = "Usuario";
            this.radioButtonUser.UseVisualStyleBackColor = true;
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(5, 32);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(39, 13);
            this.labelServer.TabIndex = 18;
            this.labelServer.Text = "server:";
            this.labelServer.Visible = false;
            // 
            // labelDataBase
            // 
            this.labelDataBase.AutoSize = true;
            this.labelDataBase.Location = new System.Drawing.Point(5, 57);
            this.labelDataBase.Name = "labelDataBase";
            this.labelDataBase.Size = new System.Drawing.Size(57, 13);
            this.labelDataBase.TabIndex = 17;
            this.labelDataBase.Text = "DataBase:";
            this.labelDataBase.Visible = false;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(5, 88);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(46, 13);
            this.labelUser.TabIndex = 16;
            this.labelUser.Text = "Usuario:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(5, 114);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(64, 13);
            this.labelPass.TabIndex = 15;
            this.labelPass.Text = "Contraseña:";
            // 
            // textBoxServer
            // 
            this.textBoxServer.Enabled = false;
            this.textBoxServer.Location = new System.Drawing.Point(73, 29);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(312, 20);
            this.textBoxServer.TabIndex = 14;
            this.textBoxServer.Visible = false;
            // 
            // textBoxDataBase
            // 
            this.textBoxDataBase.Enabled = false;
            this.textBoxDataBase.Location = new System.Drawing.Point(73, 55);
            this.textBoxDataBase.Name = "textBoxDataBase";
            this.textBoxDataBase.Size = new System.Drawing.Size(312, 20);
            this.textBoxDataBase.TabIndex = 13;
            this.textBoxDataBase.Visible = false;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(73, 111);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(138, 20);
            this.textBoxPass.TabIndex = 12;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(73, 86);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(138, 20);
            this.textBoxUser.TabIndex = 11;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(215, 112);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(169, 19);
            this.buttonLogin.TabIndex = 10;
            this.buttonLogin.Text = "INGRESAR";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 194);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Logueo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonAdm;
        private System.Windows.Forms.RadioButton radioButtonUser;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.Label labelDataBase;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.TextBox textBoxDataBase;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Button buttonLogin;
    }
}