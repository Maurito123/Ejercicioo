using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicioo.Presentacion
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btn_AltaUuario_Click(object sender, EventArgs e)
        {
            Hide();
            FormAltaUsuario formAltaUsuario = new FormAltaUsuario();
            formAltaUsuario.ShowDialog();
        }

        private void btn_BajaUsuario_Click(object sender, EventArgs e)
        {
            Hide();
            FormBajaUsuario formBajaUsuario = new FormBajaUsuario();
            formBajaUsuario.ShowDialog();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Hide();
            FormModificar formModificar = new FormModificar();
            formModificar.ShowDialog();
        }
    }
}
