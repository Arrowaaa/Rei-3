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

            lblIceland.Text = "       Islândia \n       " + dateTimeOffset.AddHours(0).ToString("HH:mm:ss");
            lblYakutsk.Text = "       Yakutsk " + dateTimeOffset.AddHours(9).ToString("HH:mm:ss");
            lblUs.Text = "       Estados Unidos da América " + dateTimeOffset.AddHours(-5).ToString("HH:mm:ss");
            lblEllesmere.Text = "       Illha Ellesmere " + dateTimeOffset.AddHours(-5).ToString("HH:mm:ss");
            lblNunavut.Text = "       Nunavut " + dateTimeOffset.AddHours(-8).ToString("HH:mm:ss");
            lblGreenland.Text = "       Groenlândia " + dateTimeOffset.AddHours(-3).ToString("HH:mm:ss");
            lblRussia.Text = "       Russia " + dateTimeOffset.AddHours(11).ToString("HH:mm:ss");
            lblBrazil.Text = "       Brasil " + dateTimeOffset.AddHours(-3).ToString("HH:mm:ss");
            lblTunisia.Text = "       Túnisia " + dateTimeOffset.AddHours(1).ToString("HH:mm:ss");
            lblDemocraticRepublic.Text = "       República Democrática \n "+ dateTimeOffset.AddHours(-3).ToString("HH:mm:ss");
            lblSweden.Text = "       Suécia " + dateTimeOffset.AddHours(-1).ToString("HH:mm:ss");
            lblNorway.Text = "       Noruega " + dateTimeOffset.AddHours(-1).ToString("HH:mm:ss");
            lblSvalbard.Text = "       Svalbard " + dateTimeOffset.AddHours(1).ToString("HH:mm:ss");
            lblUk.Text = "       Reino Unido \n " + dateTimeOffset.AddHours(0).ToString("HH:mm:ss");
            lblKazakhstan.Text = "       Cazaquistão " + dateTimeOffset.AddHours(6).ToString("HH:mm:ss");
            lblMadagascar.Text = "       Madagasca " + dateTimeOffset.AddHours(3).ToString("HH:mm:ss");
            lblMongolia.Text = "       Mongólia " + dateTimeOffset.AddHours(8).ToString("HH:mm:ss");
            lblChina.Text = "       China " + dateTimeOffset.AddHours(8).ToString("HH:mm:ss");
            lblVietnam.Text = "       Vietnã " + dateTimeOffset.AddHours(7).ToString("HH:mm:ss");
            lblMexico.Text = "       México " + dateTimeOffset.AddHours(6).ToString("HH:mm:ss");
            lblKopi.Text = "       Ugolnye Kopi \n " + dateTimeOffset.AddHours(9).ToString("HH:mm:ss");
            lblMalaysia.Text = "       Malásia " + dateTimeOffset.AddHours(8).ToString("HH:mm:ss");
            lblAustralia.Text = "       Australía " + dateTimeOffset.AddHours(10).ToString("HH:mm:ss");
            lblArgentina.Text = "       Argentina " + dateTimeOffset.AddHours(-3).ToString("HH:mm:ss");
            lblCanada.Text = "       Canadá " + dateTimeOffset.AddHours(11).ToString("HH:mm:ss");
            lblNewZealand.Text = "       Nova Zelândia \n       " + dateTimeOffset.AddHours(12).ToString("HH:mm:ss");
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
