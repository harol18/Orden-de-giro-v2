using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuarios_planta.Formularios;
using Usuarios_planta.Capa_presentacion;
using FontAwesome.Sharp; // libreria para utilizar los iconbutton y los iconos
using MySql.Data.MySqlClient;

namespace Usuarios_planta
{
    public partial class desembolso : Form
    {
        MySqlConnection con = new MySqlConnection("server=82.2.121.99;Uid=userapp;password=userapp;database=dblibranza;port=3306;persistsecurityinfo=True;");
        Comandos cmds = new Comandos();

        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public desembolso()
        {
            InitializeComponent();
            //leftBorderBtn = new Panel();
            //leftBorderBtn.Size = new Size(7, 44);
            leftBorderBtn = new Panel
            {
                Size = new Size(7, 55)
            };
            panelSideMenu.Controls.Add(leftBorderBtn);
            //hideSubMenu();

            this.Text = string.Empty;
            this.ControlBox = false; //quitar caja de control
            this.DoubleBuffered = true; // activar el buffer para reducri el parpadeo en los graficos del formulario
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // establecer limites para dejar el formulario como el area del escritorio
        }

        bool move = false;

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(251, 187, 33);
            public static Color color2 = Color.FromArgb(52, 179, 29);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(53, 41, 237);
            public static Color color5 = Color.FromArgb(56, 171, 179);
            public static Color color6 = Color.FromArgb(56, 171, 179);

        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = Color.FromArgb(215, 219, 222);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 66, 84);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void BtnOrden_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form formulario = new FormOrden();
            formulario.Show();
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnOrden_MouseHover(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            labelInicio.Text = BtnOrden.Text;
            icon2.IconChar = BtnOrden.IconChar;
            icon2.IconColor = BtnOrden.IconColor;
            
        }

        private void BtnSalir_MouseHover(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
        }

        private void AbrirFormHijo(object formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false; // decimos que es un formulario secundario
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void panelTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (move ==true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
        }

        private void panelTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
