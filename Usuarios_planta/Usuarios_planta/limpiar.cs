using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // libreria para utilizar todo el formulario de windows

namespace Usuarios_planta
{
    class limpiar
    {
        public void BorrarCampos(GroupBox gb)
        {
            foreach (var combo in gb.Controls)
            {
                if (combo is TextBox)
                {
                    ((TextBox)combo).Clear();
                }
            }
        }
    }
}
