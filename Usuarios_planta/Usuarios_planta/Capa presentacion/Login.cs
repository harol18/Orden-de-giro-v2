using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Usuarios_planta.Capa_presentacion
{
    public partial class Login : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Indr42020$;database=dblibranza;port=3306;persistsecurityinfo=True;");

        public Login()
        {
            InitializeComponent();
        }

        private bool validate_login(string user, string pass)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from tf_usuarios where Identificacion=@Identificacion and Contraseña=@Contraseña";
            cmd.Parameters.AddWithValue("@Identificacion", user);
            cmd.Parameters.AddWithValue("@Contraseña", pass);
            cmd.Connection = con;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = Txtusuario.Text;
            string pass = Txtcontraseña.Text;
            if (user == "" || pass == "")
            {
                MessageBox.Show("Campos vacíos detectados ! Por favor, rellene todos los campos");
                return;
            }
            bool r = validate_login(user, pass);
            if (r)
            {
                MessageBox.Show("Bienvenido!!! " + Txtusuario.Text);
                Form formulario = new desembolso();
                formulario.Show();
                this.Hide();

                
            }               
            else
                MessageBox.Show("Credenciales de inicio de sesión incorrectas");
                Txtusuario.Clear();
                Txtcontraseña.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Txtcontraseña.PasswordChar = '*';
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Txtcontraseña.UseSystemPasswordChar = true;
            
        }

        private void Txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;// bloquea el ingreso de letras y el 8 corresponde a la barra espaciador
        }
    }
}
