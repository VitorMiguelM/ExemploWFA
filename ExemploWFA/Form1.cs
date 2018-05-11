using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!!");
            MessageBox.Show("A soma é: " + (2 + 2));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nomeUsuario = txtNome.Text;
            string sobrenomeUsuario = txtSobrenome.Text;
            MessageBox.Show(nomeUsuario + " " + sobrenomeUsuario);
        }

        private void BtnMeuPrimeiroBotão_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalcularMedia_Click(object sender, EventArgs e)
        {
            double nota1 = 0;
            double nota2 = 0;
            double nota3 = 0;
            double nota4 = 0;
            try
            {
                nota1 = Convert.ToDouble(txtNota1.Text);
            
            }
            catch 
            {
                MessageBox.Show("\"NOTA 1\"Deve conter apenas números");
                txtNota1.Focus();
                return;
            }
            try
            {
                nota2 = Convert.ToDouble(txtNota2.Text);

            }
            catch
            {
                MessageBox.Show("\"Nota 2\"Deve conter apenas números");
                txtNota2.Focus();
                return;
            }
            try
            {
                nota3 = Convert.ToDouble(txtNota3.Text);

            }
            catch
            {
                MessageBox.Show("\"NOTA 3\"Deve conter apenas números");
                txtNota3.Focus();
                return;
            }
            try
            {
                nota4 = Convert.ToDouble(txtNota4.Text);

            }
            catch
            {
                MessageBox.Show("\"Nota 4\"Deve conter apenas números");
                txtNota4.Focus();
                return;

            }

            double media = (nota1 + nota2 + nota3 + nota4) / 4;
            string textao = String.Format(@"Nota 1: {0:n}
Nota 2: {1:n}
Nota 3: {2:n}
Nota 4: {3:n}
Média:  {4:n}", nota1, nota2, nota3, nota4, media);

            txtResultado.Text = textao;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }        
    }
}
