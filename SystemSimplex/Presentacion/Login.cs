using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Presentacion
{
    public partial class Login : Form
    {


        //Falta obtener estos datos: por ahora estan vacios

        TextWriter archivoBD = new StreamWriter("Connection_Database.txt");
        const string nameUser = "Usuario";
        const string passUser = "123456";
        const string nameAdmin = "Administrador";
        const string passAdmin = "123456";
        public bool close;
        private bool logueado;
        
        public Login()
        {
            
            InitializeComponent();
            close = logueado = false;
            

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

                    MessageBox.Show("Logueado correctamente");
                    logueado = true;
                    this.Close();
                    //if (datasource != "" && initialcatalog != "")
                    //{
                       
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Usuario y contraseña correctos, pero no se encuentra ninguna base de datos ni servidor");
                    //}
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
                    initialcatalog = textBoxDataBase.Text;

                    archivoBD.WriteLine("data source = " + textBoxServer.Text + "; initial catalog = " + textBoxDataBase.Text + "; integrated security = true; ");
                    archivoBD.Close();
                    MessageBox.Show("Logueado correctamente");
                    logueado = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hubo un error, verifica tu usario o contraseña y completa todos los campos");
                }
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (logueado==false) { 
            close = true;
            }
        }
    }
}
