using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelogioMundial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void verHoras()
        {
            DateTime horaAtual = DateTime.Now;
            label1.Text = horaAtual.ToString("HH:mm:ss");

            TimeZoneInfo fuso = TimeZoneInfo.Local;
            label2.Text = fuso.ToString();

            label10.Text = horaAtual.ToString();

            DateTimeOffset dateTimeOffset = DateTimeOffset.UtcNow;

            lblBaker.Text = "       Islândia \n       " + dateTimeOffset.AddHours(-12).ToString("HH:mm:ss");
            lblMiller.Text = "       Yakutsk " + dateTimeOffset.AddHours(-11).ToString("HH:mm:ss");
            lblPaopao.Text = "       Estados Unidos da América " + dateTimeOffset.AddHours(-10).ToString("HH:mm:ss");
            lblAnchorage.Text = "       Illha Ellesmere " + dateTimeOffset.AddHours(-9).ToString("HH:mm:ss");
            lblLosAngeles.Text = "       Nunavut " + dateTimeOffset.AddHours(-8).ToString("HH:mm:ss");
            lblDawson.Text = "       Groenlândia " + dateTimeOffset.AddHours(-7).ToString("HH:mm:ss");
            lblMexico.Text = "       Russia " + dateTimeOffset.AddHours(-6).ToString("HH:mm:ss");
            lblLima.Text = "       Brasil " + dateTimeOffset.AddHours(-3).ToString("HH:mm:ss");
            lblManaus.Text = "       Túnisia " + dateTimeOffset.AddHours(-4).ToString("HH:mm:ss");
            lblSaoPaulo.Text = "       República Democrática \n "+ dateTimeOffset.AddHours(-5).ToString("HH:mm:ss");
            lblNuuk.Text = "       Suécia " + dateTimeOffset.AddHours(-2).ToString("HH:mm:ss");
            label3.Text = "       Noruega " + dateTimeOffset.AddHours(-2).ToString("HH:mm:ss");
            lblItto.Text = "       Svalbard " + dateTimeOffset.AddHours(-1).ToString("HH:mm:ss");
            lblAcra.Text = "       Reino Unido \n " + dateTimeOffset.AddHours(0).ToString("HH:mm:ss");
            lblParis.Text = "       Cazaquistão " + dateTimeOffset.AddHours(1).ToString("HH:mm:ss");
            lblCabo.Text = "       Madagasca " + dateTimeOffset.AddHours(2).ToString("HH:mm:ss");
            lblIstambul.Text = "       Mongólia " + dateTimeOffset.AddHours(3).ToString("HH:mm:ss");
            lblMascate.Text = "       China " + dateTimeOffset.AddHours(4).ToString("HH:mm:ss");
            lblMale.Text = "       Vietnã " + dateTimeOffset.AddHours(5).ToString("HH:mm:ss");
            lblAstana.Text = "       México " + dateTimeOffset.AddHours(6).ToString("HH:mm:ss");
            lblBangkok.Text = "       Ugolnye Kopi \n " + dateTimeOffset.AddHours(7).ToString("HH:mm:ss");
            lblTaipe.Text = "       Malásia " + dateTimeOffset.AddHours(8).ToString("HH:mm:ss");
            lblTokyo.Text = "       Australía " + dateTimeOffset.AddHours(9).ToString("HH:mm:ss");
            lblSydney.Text = "       Argentina " + dateTimeOffset.AddHours(10).ToString("HH:mm:ss");
            lblMagadan.Text = "       Canadá " + dateTimeOffset.AddHours(11).ToString("HH:mm:ss");
            lblSuva.Text = "       Nova Zelândia \n       " + dateTimeOffset.AddHours(12).ToString("HH:mm:ss");
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            verHoras();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             timer1.Interval = 1000;
             timer1.Enabled = true;
        }
    }
}
