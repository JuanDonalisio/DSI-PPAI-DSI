using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DSI_PPAI.DBconection
{
    class Acceso_Datos
    {
        public enum EstadoTransaccion { error, correcto }
        public enum TipoConexion { simple, transaccion }

        string CadenaConexion = "Data Source=MNL;Initial Catalog=PPAI;Integrated Security=True";
        SqlConnection Conexion = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        //Hago una reserva del nombre pero no lo defino con = new SqlCommand
        SqlTransaction Transaction;

        EstadoTransaccion ControlTransaccion = EstadoTransaccion.correcto;
        TipoConexion ControlConexion = TipoConexion.simple;

        public void InicioTransaccion()
        {
            ControlTransaccion = EstadoTransaccion.correcto;
            ControlConexion = TipoConexion.transaccion;
        }

        public EstadoTransaccion FinalTransaccion()
        {
            if (ControlConexion == TipoConexion.transaccion)
            {
                if (ControlTransaccion == EstadoTransaccion.correcto)
                {
                    Transaction.Commit();
                }
                else
                {
                    Transaction.Rollback();
                }
            }
            ControlConexion = TipoConexion.simple;
            Desconectar();
            return ControlTransaccion;
        }

        private void Conectar()
        {
            //Pregunto si el estado de la conexion es igual a Close, si fuese igual a Open no debería ejecutarlo
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();
                Cmd.Connection = Conexion;
                Cmd.CommandType = CommandType.Text;

                if (ControlConexion == TipoConexion.transaccion)
                {
                    //Comienzo de transaccion
                    //Con IsolationLevel.ReadCommitted le digo que me permita ver lo que está en el buffer en tiempo de transaccion, si hago una consulta va a mostrarme los datos de la tabla y los datos del buffer
                    Transaction = Conexion.BeginTransaction(IsolationLevel.ReadCommitted);
                    //Le digo al comando quien maneja la transaccion
                    Cmd.Transaction = Transaction;
                }
            }
        }

        private void Desconectar()
        {
            if (ControlConexion == TipoConexion.simple)
                Conexion.Close();
        }

        public DataTable EjecutarSelect(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            try
            {
                tabla.Load(Cmd.ExecuteReader());
            }
            catch (Exception e)
            {

                ControlTransaccion = EstadoTransaccion.error;
                MessageBox.Show("Error en la consulta: \n  " + sql + "\n El mensaje de error es: \n" + e.Message);
            }

            Desconectar();
            return tabla;
        }

        public EstadoTransaccion Insertar(string SqlInsertar)
        {
            return InsModBorr(SqlInsertar);
        }

        public EstadoTransaccion Modificar(string SqlModificar)
        {
            return InsModBorr(SqlModificar);
        }

        public EstadoTransaccion Borrar(string SqlBorrar)
        {
            return InsModBorr(SqlBorrar);
        }

        private EstadoTransaccion InsModBorr(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ControlTransaccion = EstadoTransaccion.error;
                MessageBox.Show("Error en el comando: \n  " + sql + "\n El mensaje de error es: \n" + e.Message);

            }
            Desconectar();
            return ControlTransaccion;
        }
    }
}
