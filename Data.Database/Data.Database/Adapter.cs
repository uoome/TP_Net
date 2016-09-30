using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Data.Database
{
    public class Adapter
    {
        //Clave por defecto a utlizar para la cadena de conexion
        const string consKeyDefaultCnnString = "ConnStringLocal";
        //Para SQL Express: const string consKeyDefaultCnnString = "ConnStringExpress";
        //Para usar el serverisi: const string consKeyDefaultCnnString = "ConnStringServerISI";

        private SqlConnection sqlConnection;
        public SqlConnection sqlConn
        {
            get { return sqlConnection; }
            set { sqlConnection = value; }
        }

        protected void OpenConnection()
        {
            try
            {
                string conexion = ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString;
                sqlConn = new SqlConnection(conexion);
                sqlConn.Open();
            }
            catch (Exception Ex) {
                string s=Ex.Message;
            }
        }

        protected void CloseConnection()
        {
            sqlConn.Close();
            //Para liberar memoria usada se le asigna null a la conexion
            sqlConn = null;
        }

        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }
    }
}
