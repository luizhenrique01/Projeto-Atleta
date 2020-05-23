using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {




        }

        private void lbl_nome_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                Atleta novoAtleta = new Atleta();

                novoAtleta.Nome = txt_nome.Text;
                novoAtleta.Idade = int.Parse(txt_idade.Text);
                novoAtleta.Altura = double.Parse(txt_altura.Text);
                novoAtleta.Peso = double.Parse(txt_peso.Text);
                txt_resposta.Text = novoAtleta.CalcularIMC().ToString();
            }
            catch(FormatException exeception)
            {
                MessageBox.Show("Erro. \n" + exeception.Message);
            }
            catch (Exception exeception)
            {
                MessageBox.Show(exeception.Message);
            }


        }
    }
}
