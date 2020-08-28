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

namespace TPI_NewWare
{
    public partial class FrmLogin : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source = pavTpGrupal.mssql.somee.com; Persist Security Info = True; User ID = ebertalem_SQLLogin_1; Password = 4m8u7yha3i");

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtNom.Text == "" || txtPass.Text == "")
            {
                txtDatosIncorrectos.Visible = false;
                txtIngresarDatos.Visible = true;
            }


            else
            {
                //conectar a bd

                try
                {
                    // guardar variables
                    string nom = txtNom.Text;
                    string pass = txtPass.Text;
                 // se abre la conexion
                    conexion.Open();
                    // select para ver si el usuario existe en la bd y esta bien la contraseña
                    string consulta = "SELECT * FROM USUARIOS WHERE nombreUsuario = '" + nom + "' and contraseña = HASHBYTES('SHA1','" + pass + "')";

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    SqlDataReader lector = comando.ExecuteReader();
                    // si hay un elemento en el select
                    if (lector.Read())
                    {

                        string nombre = lector.GetString(0);
                        string contra = lector.GetString(1);
                        if (nombre != "" && contra != "")
                        {
                         
                            conexion.Close();

                            txtIngresarDatos.Visible = false;
                            FrmInicio ventana = new FrmInicio();
                            ventana.Show();
                            this.Hide();
                        }




                    }
                    else
                    {

                        txtIngresarDatos.Visible = false;
                        txtDatosIncorrectos.Visible = true;
                        conexion.Close();

                    }





                }
                catch (Exception ex)
                {

                    MessageBox.Show("" + ex);
                    conexion.Close();
                }
        

            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string pass = txtPass.Text;
            try
            {
                conexion.Open();
                string consulta = "INSERT INTO USUARIOS (nombreUsuario,contraseña) VALUES ('" + nom + "',HASHBYTES('SHA1','" + pass + "'))";


                SqlCommand comando = new SqlCommand(consulta, conexion);
                int cant = comando.ExecuteNonQuery();

                if (cant > 0)
                {

                    FrmInicio ventana = new FrmInicio();
                    ventana.Show();
                    this.Hide();
                    conexion.Close();



                }
                else
                {

                    MessageBox.Show("Error , verifique los datos ingresados , el usuario ya existe ");
                    conexion.Close();

                }










            }
            catch (Exception)
            {

                MessageBox.Show("El usuario ya existe");
                conexion.Close();
            }
        }
    }
}
