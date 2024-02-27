using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PrevisaoDoTempo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarregarCidades();
        }
        private void CarregarCidades()
        {
            // Adicione aqui as cidades que você deseja incluir no ComboBox
            comboBoxCidades.Items.AddRange(new string[] { "São Paulo", "Rio de Janeiro", "Campinas","Americana","Piracicaba","Buenos Aires","Catalão","Barcelona","Portugal" });
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            string cidade = comboBoxCidades.SelectedItem.ToString();
            string url = $"http://api.openweathermap.org/data/2.5/weather?q={cidade}&appid=9b5afda0ba6c452f83eebdb9321a07f7";

            using (WebClient wc = new WebClient())
            {
                try
                {
                    string json = wc.DownloadString(url);
                    dynamic data = JsonConvert.DeserializeObject(json);

                    string descricao = data.weather[0].description;
                    double temperatura = Convert.ToDouble(data.main.temp) - 273.15; // Converter de Kelvin para Celsius

                    labelPrevisao.Text = "Previsão para " + cidade;
                    labelInfoAdicional.Text = "Condição: " + descricao;

                    // Exibir ícone de clima
                    string iconCode = data.weather[0].icon;
                    pictureBoxIcone.ImageLocation = $"http://openweathermap.org/img/w/{iconCode}.png";
                    pictureBoxIcone.SizeMode = PictureBoxSizeMode.StretchImage;

                    // Exibir mais informações em labels separadas
                    double tempMax = Convert.ToDouble(data.main.temp_max) - 273.15;
                    double tempMin = Convert.ToDouble(data.main.temp_min) - 273.15;
                    double umidade = Convert.ToDouble(data.main.humidity);

                    labelTempMax.Text = $"Temperatura Máxima: {tempMax:F1}°C";
                    labelTempMin.Text = $"Temperatura Mínima: {tempMin:F1}°C";
                    labelUmidade.Text = $"Umidade: {umidade}%";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao obter previsão do tempo: " + ex.Message);
                }
            }
        }

        private void comboBoxCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelPrevisao.Text = string.Empty; // Limpar a previsão ao selecionar uma nova cidade
            pictureBoxIcone.Image = null; // Limpar o ícone de clima ao selecionar uma nova cidade
        }
    }
}
