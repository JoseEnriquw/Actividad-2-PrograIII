using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Login : Form
    {

        
        //Falta obtener estos datos: por ahora estan vacios
        const string nameUser = "Usuario";
        const string passUser = "123456";
        const string nameAdmin = "Administrador";
        const string passAdmin = "123456";
        public bool close;
        public Login()
        {
            close = false;
            InitializeComponent();
        }

        private void radioButtonAdm_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAdm.Checked == true)
            {
                labelDataBase.Visible = true;
                labelServer.Visible = true;
                textBoxDataBase.Enabled = true;
                textBoxDataBase.Visible = true;
                textBoxServer.Enabled = true;
                textBoxServer.Visible = true;
            }
            else
            {
                labelDataBase.Visible = false;
                labelServer.Visible = false;
                textBoxDataBase.Enabled = false;
                textBoxDataBase.Visible = false;
                textBoxServer.Enabled = false;
                textBoxServer.Visible = false;
                textBoxDataBase.Text = "";
                textBoxServer.Text = "";
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Falta guardar el server y el data base:
            string datasource = "";
            string initialcatalog = "";
            if (radioButtonUser.Checked == true)
            {
                if (textBoxUser.Text == nameAdmin && textBoxPass.Text == passAdmin || textBoxUser.Text == nameUser && textBoxPass.Text == passUser)
                {
                    if (datasource != "" && initialcatalog != "")
                    {
                        MessageBox.Show("Logueado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Usuario y contraseña correctos, pero no se encuentra ninguna base de datos ni servidor");
                    }
                }
                else
                {
                    MessageBox.Show("Hubo un error, verifica tu usario o contraseña");
                }
            }
            else
            {
                if (textBoxUser.Text == nameAdmin && textBoxPass.Text == passAdmin && textBoxServer.Text != "" && textBoxDataBase.Text != "")
                {
                    datasource = textBoxServer.Text;

                    initialcatalog = textBoxServer.Text;
                    MessageBox.Show("Logueado correctamente");
                }
                else
                {
                    MessageBox.Show("Hubo un error, verifica tu usario o contraseña y completa todos los campos");
                }
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            close = true;
        }
    }
}
