using System;
using System.Windows.Forms;

namespace PrevisaoDoTempo
{
    public partial class FormPrevisaoDoTempo : Form
    {
        public FormPrevisaoDoTempo()
        {
            InitializeComponent();
        }

        private void comboBoxCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lógica para buscar e exibir a previsão do tempo para a cidade selecionada
            string cidadeSelecionada = comboBoxCidades.SelectedItem.ToString();
            // Implemente a lógica para recuperar a previsão do tempo de uma API de previsão do tempo
            // Exibir a previsão do tempo em um Label
            labelPrevisaoTempo.Text = "Previsão do tempo para " + cidadeSelecionada;
        }
    }
}

