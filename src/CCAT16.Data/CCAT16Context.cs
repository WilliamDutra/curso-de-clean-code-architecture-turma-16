using Npgsql;

namespace CCAT16.Data
{
    public class CCAT16Context
    {
        public NpgsqlConnection Conexao;

        public CCAT16Context(string connectionString)
        {
            Conexao = new NpgsqlConnection(connectionString);
            Conexao.Open();
        }
    }
}