using MySql.Data.MySqlClient;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_Tarefas
{
    public partial class Form1 : Form
    {
        string conexaoString = "server=62.72.62.1;user=u687609827_alunos;database=u687609827_TI21;port=3306;password=@Aluno12345";
        public Form1()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CarregarDados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfigurarDataGridView();

            CarregarDados();
        }

        private void ConfigurarDataGridView()
        {

            dgvTarefas.ColumnCount = 4;
            dgvTarefas.Columns[0].Name = "ID";
            dgvTarefas.Columns[1].Name = "Tarefa";
            dgvTarefas.Columns[2].Name = "Descrição";
            dgvTarefas.Columns[3].Name = "Vencimento";

            DataGridViewButtonColumn coluna = new DataGridViewButtonColumn();
            coluna.Name = "Ag";
            coluna.Text = "Dell";
            coluna.UseColumnTextForButtonValue = true;
            dgvTarefas.Columns.Add(coluna);

            dgvTarefas.Columns["ID"].Width = 25;
            dgvTarefas.Columns["Tarefa"].Width = 115;
            dgvTarefas.Columns["Descrição"].Width = 150;
            dgvTarefas.Columns["Vencimento"].Width = 70;
            dgvTarefas.Columns["Ag"].Width = 50;

        }
        private void LimparCampos()
        {
            txbTarefa.Text = string.Empty;
            txbDesc.Text = string.Empty;
            dtpVencimento.Value = DateTime.Today;
        }

        private void CarregarDados()
        {
            dgvTarefas.Rows.Clear();
            string conexaoString = "server=62.72.62.1;user=u687609827_alunos;database=u687609827_TI21;port=3306;password=@Aluno12345";

            using (MySql.Data.MySqlClient.MySqlConnection conexao = new MySql.Data.MySqlClient.MySqlConnection(conexaoString))
            {
                string scriptSQL = "SELECT * FROM tb_tarefa";
                using (MySql.Data.MySqlClient.MySqlCommand comando = new MySql.Data.MySqlClient.MySqlCommand(scriptSQL, conexao))
                {
                    try
                    {
                        conexao.Open();
                        using (MySql.Data.MySqlClient.MySqlDataReader Ler = comando.ExecuteReader())
                        {
                            while (Ler.Read())
                            {
                                dgvTarefas.Rows.Add(Ler.GetInt32("ID"), Ler.GetString("Tarefa"), Ler.GetString("Descrição"), Ler.GetDateTime("Vencimento").ToString("Ano-Mes-Dia"));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar dados: " + ex.Message);
                    }
                }
            }

        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnAdicionarTarefa_Click(object sender, EventArgs e)
        {
            string tarefa = txbTarefa.Text;
            string desc = txbDesc.Text;
            string venc = dtpVencimento.Value.ToString("Ano-Mes-Dia");

            try
            {
                using (MySql.Data.MySqlClient.MySqlConnection conexao = new MySql.Data.MySqlClient.MySqlConnection(conexaoString))
                {
                    string scriptSQL = "INSERT INTO tb_tarefa (Tarefa, Descrição, Vencimento) VALUES (@Tarefa, @Descrição, @Vencimento)";
                    using (MySql.Data.MySqlClient.MySqlCommand comando = new MySql.Data.MySqlClient.MySqlCommand(scriptSQL, conexao))
                    {
                        comando.Parameters.AddWithValue("@Tarefa", tarefa);
                        comando.Parameters.AddWithValue("@Descrição", desc);
                        comando.Parameters.AddWithValue("@Vencimento", venc);

                        conexao.Open();
                        int Afetadas = comando.ExecuteNonQuery();
                        if (Afetadas > 0)
                        {
                            MessageBox.Show("Tarefa cadastrada com sucesso");
                            LimparCampos();
                            CarregarDados();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar tarefa: " + ex.Message);
            }

            CarregarDados();
        }

        private void dgvTarefas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvTarefas.Columns["Ag"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja deletar esta tarefa ?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string id = dgvTarefas.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    try
                    {
                        using (MySql.Data.MySqlClient.MySqlConnection conexao = new MySql.Data.MySqlClient.MySqlConnection(conexaoString))
                        {
                            string scriptSQL = "DELETE FROM tb_tarefa WHERE ID = @ID";
                            using (MySql.Data.MySqlClient.MySqlCommand comando = new MySql.Data.MySqlClient.MySqlCommand(scriptSQL, conexao))
                            {
                                comando.Parameters.AddWithValue("@ID", id);
                                conexao.Open();
                                int Afetadas = comando.ExecuteNonQuery();
                                if (Afetadas > 0)
                                {
                                    MessageBox.Show("Tarefa removida com sucesso");
                                    CarregarDados();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao deletar tarefa: " + ex.Message);
                    }
                }
            }


        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja atualizar estas tarefas?", "Confirmar Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySql.Data.MySqlClient.MySqlConnection conexao = new MySql.Data.MySqlClient.MySqlConnection(conexaoString))
                    {
                        conexao.Open();
                        foreach (DataGridViewRow row in dgvTarefas.Rows)
                        {
                            string id = row.Cells["ID"].Value.ToString();
                            string novaTarefa = row.Cells["Tarefa"].Value.ToString();
                            string novaDesc = row.Cells["Descrição"].Value.ToString();
                            string novoVencimento = ((DateTime)row.Cells["Vencimento"].Value).ToString("Ano-Mes-Dia");

                            string scriptSQL = "UPDATE tb_tarefa SET Tarefa = @Tarefa, Descrição = @Descrição, Vencimento = @Vencimento WHERE ID = @ID";
                            using (MySql.Data.MySqlClient.MySqlCommand comando = new MySql.Data.MySqlClient.MySqlCommand(scriptSQL, conexao))
                            {
                                comando.Parameters.AddWithValue("@Tarefa", novaTarefa);
                                comando.Parameters.AddWithValue("@Descrição", novaDesc);
                                comando.Parameters.AddWithValue("@Vencimento", novoVencimento);
                                comando.Parameters.AddWithValue("@ID", id);

                                int Afetadas = comando.ExecuteNonQuery();
                                if (Afetadas > 0)
                                {
                                    MessageBox.Show("Tarefa atualizada com sucesso");
                                }
                            }
                        }
                    }
                    CarregarDados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar tarefas: " + ex.Message);
                }
            }
        }
    }
}
