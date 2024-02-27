using System;

namespace Gerenciador_de_Tarefas
{
    internal class MySqlCommand
    {
        private string scriptSQL;
        private MySqlConnection conexao;

        public MySqlCommand(string scriptSQL, MySqlConnection conexao)
        {
            this.scriptSQL = scriptSQL;
            this.conexao = conexao;
        }

        internal int ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }

        internal MySqlDataReader ExecuteReader()
        {
            throw new NotImplementedException();
        }
    }
}