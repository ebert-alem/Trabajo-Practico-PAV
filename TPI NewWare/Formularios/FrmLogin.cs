using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_NewWare.Negocio;

namespace TPI_NewWare
{
    public partial class FrmLogin : Form
    {
        Ng_Usuario ng_Usuario = new Ng_Usuario();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            
        }
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            // guardar variables
            string nom = txtNom.Text;
            string pass = txtPass.Text;

            if (nom == "" || pass == "")
            {
                //Si no se ingresan datos
                txtDatosIncorrectos.Visible = false;
                txtIngresarDatos.Visible = true;
                return;
            }
                
            //Verifica si el usuario existe
            if (ng_Usuario.Validar_usuario(nom, pass))
            {
                txtIngresarDatos.Visible = false;
                //Crea la ventana del menu
                FrmInicio ventana = new FrmInicio();
                ventana.Show();
                //Elimina la ventana 
                this.Hide();
            }
            else
            {
                //Oculta los campos de ingreso de datos
                txtIngresarDatos.Visible = false;
                txtDatosIncorrectos.Visible = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string pass = txtPass.Text;

            if (nom == "" || pass == "")
            {
                //Si no se ingresan datos
                txtDatosIncorrectos.Visible = false;
                txtIngresarDatos.Visible = true;
                return;
            }

            if (ng_Usuario.Insertar_usuario(nom, pass))
            {
                FrmInicio ventana = new FrmInicio();
                ventana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error , verifique los datos ingresados , el usuario ya existe ");
            }
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
