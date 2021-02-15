using System;
using System.Data;
using SistemaControlCuentas.Entidades;
using MySql.Data.MySqlClient;

namespace SistemaControlCuentas.Datos
{
    public class DCuentas
    {
        Conexion bd = new Conexion();
        public DataTable Listar()
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            
            try
            {
                MySqlCommand comando = new MySqlCommand("cuentas_listar", bd.iniciarConexion());
                comando.CommandType = CommandType.StoredProcedure;
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                bd.CerrarConexion();
            }
        }
    
       
    }
}
