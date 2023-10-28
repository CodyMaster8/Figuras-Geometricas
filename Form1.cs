using System;

namespace Figuras_Geometricas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double pi = 3.141592;
            double radio1, area1, volumen1;
            radio1 = double.Parse(radioCirc.Text);
            area1 = 4 * pi * radio1 * radio1; volumen1 = 4 / 3 * pi * Math.Pow(radio1, 3);
            areaCirc.Text = area1.ToString();
            volumenCirc.Text = volumen1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double base1, altura1, area1;
            base1 = double.Parse(baseTri.Text);
            altura1 = double.Parse(alturaTri.Text);
            area1 = base1 * altura1 / 2.0;
            areaTri.Text = area1.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double lado1, area1, volumen1;
            lado1 = double.Parse(ladoCubo.Text);
            area1 = 6 * Math.Pow(lado1, 2);
            volumen1 = Math.Pow(lado1, 3);
            areaCubo.Text = area1.ToString();
            volumenCubo.Text = volumen1.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            const double pi = 3.141592;
            double radio1, altura1, area1, volumen1;
            radio1 = double.Parse(radioCilindro.Text);
            altura1 = double.Parse(alturaCilindro.Text);
            area1 = 2 * pi * radio1 * (radio1 + altura1);
            volumen1 = pi * Math.Pow(radio1, 2) * altura1;
            areaCilindro.Text = area1.ToString();
            volumenCilindro.Text = volumen1.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double diagonal1, diagonal2, area1;
            diagonal1 = double.Parse(textBox1.Text);
            diagonal2 = double.Parse(textBox2.Text);
            area1 = diagonal1 * diagonal2 / 2.0;
            textBox3.Text = area1.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double arista1, area1, volumen1;
            arista1 = double.Parse(textBox4.Text);
            area1 = 2 * Math.Sqrt(3) * Math.Pow(arista1, 2);
            volumen1 = Math.Sqrt(2)/3.0 * Math.Pow(arista1, 3);
            textBox5.Text = area1.ToString();
            textBox6.Text = volumen1.ToString();
        }
    }
}