using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicioo.Persistencia
{
    internal class Persistenciaa
    {
        private List<string[]> datosClientes = new List<string[]>();

        public void AgregarDatosCliente(string[] datosCliente)
        {
            datosClientes.Add(datosCliente);
        }

        public List<string[]> ObtenerDatosClientes()
        {
            return datosClientes;
        }
    }
}
