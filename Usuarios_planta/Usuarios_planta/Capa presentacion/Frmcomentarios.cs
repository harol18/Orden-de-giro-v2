using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuarios_planta.Capa_presentacion;
using Usuarios_planta.Formularios;

namespace Usuarios_planta.Capa_presentacion
{
    public partial class Frmcomentarios : Form
    {
        public Frmcomentarios()
        {
            InitializeComponent();
        }

        DateTime fecha = DateTime.Now;        

        private void Frmcomentarios_Load(object sender, EventArgs e)
        {
            lbfecha.Text = fecha.ToString("dd/MM/yyyy");           
        }

        private void cmbestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbestado.Text == "Instancia Superior")
            {
                txtcomentarios_vd.Text = "Operación en valoración instancia superior " + fecha.ToString("dd/MM/yyyy") + " " + cod_fun1.Text + " 611";
            }
            else if (cmbestado.Text == "Dactiloscopia")
            {
                txtcomentarios_vd.Text = "Pendiente Visto Bueno dactiloscopia " + fecha.ToString("dd/MM/yyyy") + " " + cod_fun1.Text + " 601";
            }
            else if (cmbestado.Text == "Area de seguros")
            {
                txtcomentarios_vd.Text = "Se reporta a seguros BBVA en espera de respuesta. " + fecha.ToString("dd/MM/yyyy") + " " + cod_fun1.Text + " 602";
            }
            else if (cmbestado.Text == "Base sigdoc")
            {
                txtcomentarios_vd.Text = "Pendiente llegada de documentación al cf para actualizar base sigdoc " + fecha.ToString("dd/MM/yyyy") + " " + cod_fun1.Text + " 605";
            }
        }

        private void cmbestado2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbestado2.Text == "Restriccion")
            {
                txtcomentarios_for.Text = "Convenio en periodo de restricción desde el xxx hasta el " + fecha_fin.Text + " se pasara a formalizar el " + fecha.ToString("dd/MM/yyyy") + " una vez finalice periodo de restricción " + fecha.ToString("dd/MM/yyyy") + " " + cod_fun2.Text + " 707";
            }
            else if (cmbestado2.Text == "Etapas Cumplidas")
            {
                txtcomentarios_for.Text = "Etapas cumplidas pendiente control de calidad " + fecha.ToString("dd/MM/yyyy") + " " + cod_fun2.Text + " 708";
            }
            else if (cmbestado2.Text == "Ok Formalizado")
            {
                txtcomentarios_for.Text = "412; SCORING; OK FORMALIZADO; CEDULA " + fecha.ToString("dd/MM/yyyy") + " " + cod_fun2.Text + " 702";
            }
            else if (cmbestado2.Text == "Ok credito girado")
            {
                txtcomentarios_for.Text = "Ok crédito girado " + fecha.ToString("dd/MM/yyyy") + " " + cod_fun2.Text + " 703";
            }
            else if (cmbestado2.Text == "Aplicacion de pago")
            {
                txtcomentarios_for.Text = "Ok punto de control, operación en espera de aplicación de pago, se dará continuidad al trámite una vez se refleje el pago en el sistema " + fecha.ToString("dd/MM/yyyy") + cod_fun2.Text + " 706";
            }
            else if (cmbestado2.Text == "411")
            {
                txtcomentarios_for.Text = "411 operación on line en espera de desembolso " + fecha.ToString("dd/MM/yyyy") + " " + cod_fun2.Text + " 700";
            }
            else if (cmbestado2.Text == "411 Ratificacion visto bueno")
            {
                txtcomentarios_for.Text = "411 operación on line en espera de desembolso " + fecha.ToString("dd/MM/yyyy") + " " + cod_fun2.Text + " 700 RVOBO";
            }
            else if (cmbestado2.Text == "411 Cuenta oficina")
            {
                txtcomentarios_for.Text = "411 operación on line en espera de desembolso. Cuenta. Oficina " + fecha.ToString("dd/MM/yyyy") + " " + cod_fun2.Text + " 700";
            }
        }

        private void btn_copiar1_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtcomentarios_vd.Text, true);
        }

        private void btn_copiar2_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtcomentarios_for.Text, true);
        }
    }
}
