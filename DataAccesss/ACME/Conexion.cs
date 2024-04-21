using Microsoft.Data.SqlClient;


namespace DataAccesss.ACME
{
    internal class Conexion
    {
        private readonly string? _cadenaConexion;

        public Conexion()

        {
            string? _cadenaConexion;
            cadenaConexion = Environment.GetEnvironmentVariable("SQLServerXE");
            _cadenaConexion = cadenaConexion;

        }
        public SqlConnection Conectar()
        {
            SqlConnection sqlConn;
            sqlConn = new SqlConnection(_cadenaConexion);
            return sqlConn;
        }
    }
}
