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



namespace Usuarios_planta
{
    class Comandos
    {
        MySqlConnection con = new MySqlConnection("server=localhost;Uid=root;password=;database=dblibranza;port=3306;persistsecurityinfo=True;");
        

        public void Guardar_desembolso(TextBox TxtRadicado, TextBox TxtCedula, TextBox TxtNombre, TextBox TxtEstatura, TextBox TxtPeso, TextBox TxtCuenta, TextBox TxtScoring, TextBox TxtValor_aprobado,
            TextBox TxtPlazo_solicitado, TextBox Txtplazo_aprobado, ComboBox cmbDestino, ComboBox cmbcambio_condiciones, TextBox TxtRauto, TextBox TxtConvenio, TextBox TxtCod_oficina, TextBox TxtNom_oficina, TextBox TxtCiudad,
            TextBox Txtcod_giro, TextBox Txtoficina_girar, TextBox TxtId_gestor, TextBox TxtNom_gestor,
            ComboBox cmbCoordinador, ComboBox cmbDactiloscopia, ComboBox cmbG_telefonica, TextBox Txtobligacion1, TextBox TxtNom_entidad1, TextBox TxtNit1, TextBox TxtValor1,
            TextBox Txtobligacion2, TextBox TxtNom_entidad2, TextBox TxtNit2, TextBox TxtValor2, TextBox Txtobligacion3, TextBox TxtNom_entidad3, TextBox TxtNit3, TextBox TxtValor3,
            TextBox Txtobligacion4, TextBox TxtNom_entidad4, TextBox TxtNit4, TextBox TxtValor4, TextBox Txtobligacion5, TextBox TxtNom_entidad5, TextBox TxtNit5, TextBox TxtValor5,
            TextBox Txtobligacion6, TextBox TxtNom_entidad6, TextBox TxtNit6, TextBox TxtValor6, TextBox Txtobligacion7, TextBox TxtNom_entidad7, TextBox TxtNit7, TextBox TxtValor7,
            TextBox Txtobligacion8, TextBox TxtNom_entidad8, TextBox TxtNit8, TextBox TxtValor8, TextBox TxtTotal, TextBox TxtSaldo, ComboBox cmbestado, TextBox TxtIDfuncionario, TextBox TxtNomFuncionario)
        {
            
            con.Open();            
            MySqlCommand cmd = new MySqlCommand("guardar_desembolso", con);
            MySqlTransaction myTrans; // Iniciar una transacción local 
            myTrans = con.BeginTransaction(); // Debe asignar tanto el objeto de transacción como la conexión // al objeto de Comando para una transacción local pendiente 
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_radicado", TxtRadicado.Text);
                cmd.Parameters.AddWithValue("@_cedula", TxtCedula.Text);
                cmd.Parameters.AddWithValue("@_nombre", TxtNombre.Text);
                cmd.Parameters.AddWithValue("@_cuenta", TxtCuenta.Text);
                cmd.Parameters.AddWithValue("@_estatura", TxtEstatura.Text);
                cmd.Parameters.AddWithValue("@_peso", TxtPeso.Text);               
                cmd.Parameters.AddWithValue("@_scoring", TxtScoring.Text);
                cmd.Parameters.AddWithValue("@_valor_aprobado", TxtValor_aprobado.Text);
                cmd.Parameters.AddWithValue("@_plazo_solicitado", TxtPlazo_solicitado.Text);
                cmd.Parameters.AddWithValue("@_plazo_aprobado", Txtplazo_aprobado.Text);
                cmd.Parameters.AddWithValue("@_destino", cmbDestino.Text);
                cmd.Parameters.AddWithValue("@_cambio_condiciones", cmbcambio_condiciones.Text);
                cmd.Parameters.AddWithValue("@_r_Automatico", TxtRauto.Text);
                cmd.Parameters.AddWithValue("@_convenio", TxtConvenio.Text);
                cmd.Parameters.AddWithValue("@_codigo_oficina", TxtCod_oficina.Text);
                cmd.Parameters.AddWithValue("@_sucursal", TxtNom_oficina.Text);
                cmd.Parameters.AddWithValue("@_ciudad", TxtCiudad.Text);
                cmd.Parameters.AddWithValue("@_oficina_girar", Txtcod_giro.Text);
                cmd.Parameters.AddWithValue("@_sucursal_girar", Txtoficina_girar.Text);
                cmd.Parameters.AddWithValue("@_cedula_gestor", TxtId_gestor.Text);
                cmd.Parameters.AddWithValue("@_nombre_gestor", TxtNom_gestor.Text);
                cmd.Parameters.AddWithValue("@_nombre_coordinador", cmbCoordinador.Text);
                cmd.Parameters.AddWithValue("@_dactiloscopia", cmbDactiloscopia.Text);
                cmd.Parameters.AddWithValue("@_g_telefonica", cmbG_telefonica.Text);
                cmd.Parameters.AddWithValue("@_numero_obligacion1", Txtobligacion1.Text);
                cmd.Parameters.AddWithValue("@_nit_entidad1", TxtNit1.Text);
                cmd.Parameters.AddWithValue("@_nombre_entidad1", TxtNom_entidad1.Text);
                cmd.Parameters.AddWithValue("@_valor_cartera1", TxtValor1.Text);
                cmd.Parameters.AddWithValue("@_numero_obligacion2", Txtobligacion2.Text);
                cmd.Parameters.AddWithValue("@_nit_entidad2", TxtNit2.Text);
                cmd.Parameters.AddWithValue("@_nombre_entidad2", TxtNom_entidad2.Text);
                cmd.Parameters.AddWithValue("@_valor_cartera2", TxtValor2.Text);
                cmd.Parameters.AddWithValue("@_numero_obligacion3", Txtobligacion3.Text);
                cmd.Parameters.AddWithValue("@_nit_entidad3", TxtNit3.Text);
                cmd.Parameters.AddWithValue("@_nombre_entidad3", TxtNom_entidad3.Text);
                cmd.Parameters.AddWithValue("@_valor_cartera3", TxtValor3.Text);
                cmd.Parameters.AddWithValue("@_numero_obligacion4", Txtobligacion4.Text);
                cmd.Parameters.AddWithValue("@_nit_entidad4", TxtNit4.Text);
                cmd.Parameters.AddWithValue("@_nombre_entidad4", TxtNom_entidad4.Text);
                cmd.Parameters.AddWithValue("@_valor_cartera4", TxtValor4.Text);
                cmd.Parameters.AddWithValue("@_numero_obligacion5", Txtobligacion5.Text);
                cmd.Parameters.AddWithValue("@_nit_entidad5", TxtNit5.Text);
                cmd.Parameters.AddWithValue("@_nombre_entidad5", TxtNom_entidad5.Text);
                cmd.Parameters.AddWithValue("@_valor_cartera5", TxtValor5.Text);
                cmd.Parameters.AddWithValue("@_numero_obligacion6", Txtobligacion6.Text);
                cmd.Parameters.AddWithValue("@_nit_entidad6", TxtNit6.Text);
                cmd.Parameters.AddWithValue("@_nombre_entidad6", TxtNom_entidad6.Text);
                cmd.Parameters.AddWithValue("@_valor_cartera6", TxtValor6.Text);
                cmd.Parameters.AddWithValue("@_numero_obligacion7", Txtobligacion7.Text);
                cmd.Parameters.AddWithValue("@_nit_entidad7", TxtNit7.Text);
                cmd.Parameters.AddWithValue("@_nombre_entidad7", TxtNom_entidad7.Text);
                cmd.Parameters.AddWithValue("@_valor_cartera7", TxtValor7.Text);
                cmd.Parameters.AddWithValue("@_numero_obligacion8", Txtobligacion8.Text);
                cmd.Parameters.AddWithValue("@_nit_entidad8", TxtNit8.Text);
                cmd.Parameters.AddWithValue("@_nombre_entidad8", TxtNom_entidad8.Text);
                cmd.Parameters.AddWithValue("@_valor_cartera8", TxtValor8.Text);
                cmd.Parameters.AddWithValue("@_total_cpk", TxtTotal.Text);
                cmd.Parameters.AddWithValue("@_saldo_cliente", TxtSaldo.Text);
                cmd.Parameters.AddWithValue("@_estado", cmbestado.Text);                
                cmd.Parameters.AddWithValue("@_identificacion", TxtIDfuncionario.Text);
                cmd.Parameters.AddWithValue("@_nombre_funcionario", TxtNomFuncionario.Text);                
                cmd.ExecuteNonQuery();
                myTrans.Commit();
                MessageBox.Show("Información Registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
                MessageBox.Show("Conexion cerrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Buscar_desembolso(TextBox TxtRadicado, TextBox TxtCedula, TextBox TxtNombre, TextBox TxtEstatura, TextBox TxtPeso, TextBox TxtCuenta, TextBox TxtScoring, TextBox TxtValor_aprobado,
            TextBox TxtPlazo_solicitado, TextBox Txtplazo_aprobado, ComboBox cmbDestino, ComboBox cmbcambio_condiciones, TextBox TxtRauto, TextBox TxtConvenio, TextBox TxtCod_oficina, TextBox TxtNom_oficina, TextBox TxtCiudad,
            TextBox Txtcod_giro, TextBox Txtoficina_girar, TextBox TxtId_gestor, TextBox TxtNom_gestor, 
            ComboBox cmbCoordinador, ComboBox cmbDactiloscopia, ComboBox cmbG_telefonica, TextBox Txtobligacion1, TextBox TxtNom_entidad1, TextBox TxtNit1, TextBox TxtValor1,
            TextBox Txtobligacion2, TextBox TxtNom_entidad2, TextBox TxtNit2, TextBox TxtValor2, TextBox Txtobligacion3, TextBox TxtNom_entidad3, TextBox TxtNit3, TextBox TxtValor3,
            TextBox Txtobligacion4, TextBox TxtNom_entidad4, TextBox TxtNit4, TextBox TxtValor4, TextBox Txtobligacion5, TextBox TxtNom_entidad5, TextBox TxtNit5, TextBox TxtValor5,
            TextBox Txtobligacion6, TextBox TxtNom_entidad6, TextBox TxtNit6, TextBox TxtValor6, TextBox Txtobligacion7, TextBox TxtNom_entidad7, TextBox TxtNit7, TextBox TxtValor7,
            TextBox Txtobligacion8, TextBox TxtNom_entidad8, TextBox TxtNit8, TextBox TxtValor8, TextBox TxtTotal, TextBox TxtSaldo, ComboBox cmbestado, TextBox TxtIDfuncionario, TextBox TxtNomFuncionario)
        {
            
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("buscar_desembolso", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_radicado", TxtRadicado.Text);
                MySqlDataReader registro;
                registro = cmd.ExecuteReader();
                if (registro.Read())
                {
                    TxtCedula.Text = registro["cedula"].ToString();
                    TxtNombre.Text = registro["nombre"].ToString();
                    TxtEstatura.Text = registro["estatura"].ToString();
                    TxtPeso.Text = registro["peso"].ToString();
                    TxtCuenta.Text = registro["cuenta"].ToString();
                    TxtScoring.Text = registro["scoring"].ToString();
                    TxtValor_aprobado.Text = registro["valor_aprobado"].ToString();
                    TxtPlazo_solicitado.Text = registro["plazo_solicitado"].ToString();
                    Txtplazo_aprobado.Text = registro["plazo_aprobado"].ToString();
                    cmbDestino.Text = registro["destino"].ToString();
                    cmbcambio_condiciones.Text = registro["cambio_condiciones"].ToString();
                    TxtRauto.Text = registro["r_Automatico"].ToString();
                    TxtConvenio.Text = registro["convenio"].ToString();
                    TxtCod_oficina.Text = registro["codigo_oficina"].ToString();
                    TxtNom_oficina.Text = registro["sucursal"].ToString();
                    TxtCiudad.Text = registro["ciudad"].ToString();
                    Txtcod_giro.Text = registro["oficina_girar"].ToString();
                    Txtoficina_girar.Text = registro["sucursal_girar"].ToString();
                    TxtId_gestor.Text = registro["cedula_gestor"].ToString();
                    TxtNom_gestor.Text = registro["nombre_gestor"].ToString();
                    cmbCoordinador.Text = registro["nombre_coordinador"].ToString();
                    cmbDactiloscopia.Text = registro["dactiloscopia"].ToString();
                    cmbG_telefonica.Text = registro["g_telefonica"].ToString();
                    Txtobligacion1.Text = registro["numero_obligacion1"].ToString();
                    TxtNom_entidad1.Text = registro["nombre_entidad1"].ToString();
                    TxtNit1.Text = registro["nit_entidad1"].ToString();
                    TxtValor1.Text = registro["valor_cartera1"].ToString();
                    Txtobligacion2.Text = registro["numero_obligacion2"].ToString();
                    TxtNom_entidad2.Text = registro["nombre_entidad2"].ToString();
                    TxtNit2.Text = registro["nit_entidad2"].ToString();
                    TxtValor2.Text = registro["valor_cartera2"].ToString();
                    Txtobligacion3.Text = registro["numero_obligacion3"].ToString();
                    TxtNom_entidad3.Text = registro["nombre_entidad3"].ToString();
                    TxtNit3.Text = registro["nit_entidad3"].ToString();
                    TxtValor3.Text = registro["valor_cartera3"].ToString();
                    Txtobligacion4.Text = registro["numero_obligacion4"].ToString();
                    TxtNom_entidad4.Text = registro["nombre_entidad4"].ToString();
                    TxtNit4.Text = registro["nit_entidad4"].ToString();
                    TxtValor4.Text = registro["valor_cartera4"].ToString();
                    Txtobligacion5.Text = registro["numero_obligacion5"].ToString();
                    TxtNom_entidad5.Text = registro["nombre_entidad5"].ToString();
                    TxtNit5.Text = registro["nit_entidad5"].ToString();
                    TxtValor5.Text = registro["valor_cartera5"].ToString();
                    Txtobligacion6.Text = registro["numero_obligacion6"].ToString();
                    TxtNom_entidad6.Text = registro["nombre_entidad6"].ToString();
                    TxtNit6.Text = registro["nit_entidad6"].ToString();
                    TxtValor6.Text = registro["valor_cartera6"].ToString();
                    Txtobligacion7.Text = registro["numero_obligacion7"].ToString();
                    TxtNom_entidad7.Text = registro["nombre_entidad7"].ToString();
                    TxtNit7.Text = registro["nit_entidad7"].ToString();
                    TxtValor7.Text = registro["valor_cartera7"].ToString();
                    Txtobligacion8.Text = registro["numero_obligacion8"].ToString();
                    TxtNom_entidad8.Text = registro["nombre_entidad8"].ToString();
                    TxtNit8.Text = registro["nit_entidad8"].ToString();
                    TxtValor8.Text = registro["valor_cartera8"].ToString();
                    TxtTotal.Text = registro["total_cpk"].ToString();
                    TxtSaldo.Text = registro["saldo_cliente"].ToString();
                    cmbestado.Text = registro["estado"].ToString();
                    TxtIDfuncionario.Text = registro["identificacion"].ToString();
                    TxtNomFuncionario.Text = registro["nombre_funcionario"].ToString();                    
                    con.Close();
                }
                else
                {
                    con.Close();
                    MySqlCommand comando = new MySqlCommand("SELECT * FROM datos_basicos_libranza WHERE radicado = @radicado ", con);
                    comando.Parameters.AddWithValue("@radicado", TxtRadicado.Text);
                    con.Open();
                    MySqlDataReader registro1 = comando.ExecuteReader();
                    if (registro1.Read())
                    {
                        TxtCedula.Text = registro1["cedula"].ToString();
                        TxtNombre.Text = registro1["nombre"].ToString();
                        TxtId_gestor.Text = registro1["cedula_gestor"].ToString();
                        TxtNom_gestor.Text = registro1["nombre_gestor"].ToString();
                        cmbCoordinador.Text = registro1["nombre_coordinador"].ToString();
                        con.Close();
                    }
                    con.Close();
                }
                con.Close();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.ToString());
                con.Close();
                MessageBox.Show("Conexion cerrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
    }
}
