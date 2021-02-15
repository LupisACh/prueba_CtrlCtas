using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;



namespace SistemaControlCuentas.Datos
{
    class Conexion
    {
        MySqlConnection conBD;//contendra la direccion de la bases datos\\
        #region Iniciar Conexion
        //----------------------Iniciar Conexion---------------\\
        public MySqlConnection iniciarConexion()
        {
            try
            {
                conBD = new MySqlConnection("server=192.168.4.17; database=control_cuentas; Uid=root; pwd = sis123.");
                conBD.Open();
                return conBD;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al conectarse a la base de datos");
            }
            return conBD;
        }
        #endregion

        #region cerrar conexion
        //---------------------------cerrar conexion--------------------------\\
        public void CerrarConexion()
        {
            try
            {
                conBD.Close();
                //  MessageBox.Show("El cierre de la conexion se realizo");
            }
            catch (MySqlException)
            {
                // MessageBox.Show("Error al Cerrarse a la base datos");

            }

        }
        #endregion
    }
}
