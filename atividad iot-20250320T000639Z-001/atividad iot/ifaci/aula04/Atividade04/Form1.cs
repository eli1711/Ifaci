using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade04
{
    public partial class Form1 : Form
    {
        // Lista para armazenar as imagens
        private List<Image> imagens1;
        private List<Image> imagens2;
        private int imagemAtual1;
        private int imagemAtual2;

        public Form1()
        {
            InitializeComponent();


            imagens1 = new List<Image>
            {
                Image.FromFile("c:\\imagens\\TanqueEnchendo1.bmp"),
                Image.FromFile("c:\\imagens\\TanqueEnchendo2.bmp"),
                Image.FromFile("c:\\imagens\\TanqueEnchendo3.bmp"),
                Image.FromFile("c:\\imagens\\TanqueEnchendo4.bmp")
            };
           
            imagens2 = new List<Image>
            {
                Image.FromFile("c:\\imagens\\TanqueEsvaziando1.bmp"),
                Image.FromFile("c:\\imagens\\TanqueEsvaziando2.bmp"),
                Image.FromFile("c:\\imagens\\TanqueEsvaziando3.bmp"),
                Image.FromFile("c:\\imagens\\TanqueEsvaziando4.bmp"),
                Image.FromFile("c:\\imagens\\TanqueVazio.bmp")
            };

            pictureBox1.Image = Image.FromFile("c:\\imagens\\TanqueCheio.bmp");
            imagemAtual2 = 0; 
             pictureBox1.Image = Image.FromFile("c:\\imagens\\TanqueVazio.bmp");
            imagemAtual1 = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        
        private void button7_Click(object sender, EventArgs e)
        {
            timer2.Start(); 
        }

        
        private void timer2_Tick(object sender, EventArgs e)
        {
           
            pictureBox1.Image = imagens1[imagemAtual1];

           
            imagemAtual1++;

            
            if (imagemAtual1 >= imagens1.Count)
            {
                timer2.Stop(); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer3.Start();

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            pictureBox1.Image = imagens2[imagemAtual2];


            imagemAtual2++;


            if (imagemAtual2 >= imagens2.Count)
            {
                timer3.Stop();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timer3.Stop();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
