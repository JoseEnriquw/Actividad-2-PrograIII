
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
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelUser);
            this.groupBox1.Controls.Add(this.labelPass);
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
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(6, 58);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(46, 13);
            this.labelUser.TabIndex = 16;
            this.labelUser.Text = "Usuario:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(-3, 91);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(64, 13);
            this.labelPass.TabIndex = 15;
            this.labelPass.Text = "Contraseña:";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(71, 91);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(138, 20);
            this.textBoxPass.TabIndex = 12;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(71, 51);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(138, 20);
            this.textBoxUser.TabIndex = 11;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(215, 92);
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
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Button buttonLogin;
    }
}