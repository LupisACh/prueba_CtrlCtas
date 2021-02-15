using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SistemaControlCuentas.Datos;

namespace SistemaControlCuentas.Negocio
{
    public class NCuentas
    {
        public DataTable Listar()
        {
            DCuentas Datos = new DCuentas();
            return Datos.Listar();
        }

       /* public DataTable Buscar(string Valor)
        {
            DCuentas Datos = new DCuentas();
            return Datos.Buscar(Valor);
        }*/
    }
}
