using Ejercicioo.Logica;
using Ejercicioo.Persistencia;
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
    public partial class FormInformacionUsuario : Form
    {
        public bool DatosCompletos { get; set; }
        private ControlDeCampos logica;
     
        public FormInformacionUsuario()
        {
            InitializeComponent();
            logica = new ControlDeCampos();

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;
            string calle = txtCalle.Text;
            string puerta = txtPuerta.Text;

            if (logica.ValidarCampos(new string[] { telefono, correo, calle, puerta }))
            {

                MessageBox.Show("Valores ingresados correctamente");
                this.Hide();
                FormAltaUsuario formAltaUsuario = Owner as FormAltaUsuario;
                formAltaUsuario.guardarInformacionDeContacto(telefono, correo, calle, puerta);
                DatosCompletos = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Completa los campos vacios", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_volver_Click(object sender, EventArgs e)
        {
            Hide();
            FormAltaUsuario formAltaUsuario = new FormAltaUsuario();
            formAltaUsuario.ShowDialog();
        }
    }
}
