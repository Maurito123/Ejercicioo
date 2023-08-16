using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicioo.Persistencia;
using Ejercicioo.Logica;

namespace Ejercicioo.Presentacion
{
    public partial class FormAltaUsuario : Form
    {
        private ControlDeCampos logica;
        private Persistenciaa persistencia;
        public FormAltaUsuario()
        {
            InitializeComponent();
            CargarDatosDesdeArchivo();
            logica = new ControlDeCampos();
        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            string[] datos = new string[3];
            datos[0]= txtNombre.Text;
            datos[1]= txtApellido.Text;
            datos[2]= txtDocumento.Text;

            if (!logica.ValidarCampos(datos))
            {
                MessageBox.Show("Completa los campos vacios", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FormInformacionUsuario formInformacionUsuario = new FormInformacionUsuario();
                formInformacionUsuario.ShowDialog();
                if (formInformacionUsuario.DatosCompletos)
                {
                    ActualizarDataGridView();
                    GuardarDatosEnArchivo();
                }
            }
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Hide();
            FormMenu formMenu = new FormMenu();
            formMenu.ShowDialog();
        }
        private void FormularioAltaUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {

            GuardarDatosEnArchivo();
        }
        private void ActualizarDataGridView()
        {
            var datosClientes = persistencia.ObtenerDatosClientes();

            foreach (var datos in datosClientes)
            {
                dataGridView1.Rows.Add(datos);
            }
        }
        private void CargarDatosDesdeArchivo()
        {
            if (File.Exists("datos.txt"))
            {
                using (StreamReader reader = new StreamReader("datos.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] datos = line.Split('\t');
                        dataGridView1.Rows.Add(datos);
                    }
                }
            }
        }

        private void GuardarDatosEnArchivo()
        {
            using (StreamWriter writer = new StreamWriter("datos.txt"))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string line = string.Join("\t", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value.ToString()));
                        writer.WriteLine(line);
                    }
                }
            }
        }

        internal void guardarInformacionDeContacto(string telefono, string correo, string calle, string puerta)
        {
            throw new NotImplementedException();
        }
    }
}