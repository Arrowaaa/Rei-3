using System;

namespace Gerenciador_de_Tarefas
{
    internal class MySqlConnection
    {
        private string conexaoString;

        public MySqlConnection(string conexaoString)
        {
            this.conexaoString = conexaoString;
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}