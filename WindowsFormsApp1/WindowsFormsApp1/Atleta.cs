using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Atleta
    {
        private string nome;
        private double altura;
        private double peso;
        private int idade;

       
        public string Nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else {
                    throw new Exception("O nome nao pode ser vazio");
                }

            }
            get { 
                return this.nome;
            }
        }

        public double Altura
        {
            set
            {
                if(value > 0)
                {
                    this.altura = value;
                }
                else
                {
                    throw new Exception("Altura invalida");
                }
            }
            get
            {
                return this.altura;
            }
        }
        public double Peso
        {
            set
            {
                if (value > 0)
                {
                    this.peso = value;
                }
                else
                {
                    throw new Exception("Peso invalido");
                }
            }
            get
            {
                return this.peso;
            }
        }
        public int Idade
        {
            set
            {
                if (value > 0)
                {
                    this.idade = value;
                }
                else
                {
                    throw new Exception("Idade invalida");
                }
            }
            get
            {
                return this.idade;
            }
        }


        public double CalcularIMC()
        {
            double imc;
           return imc = this.peso / Math.Pow(this.altura,2);
        }

    }


}
