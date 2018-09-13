using System;

namespace ClassePropriedadeMetodo.Biblioteca
{
    public class Pessoa
    {
        public string Nome;
        public string Sexo;
        public DateTime DataNascimento;
        private double eixoX, eixoY;

        // construtor
        public Pessoa(
            string nome,
            string sexo,
            DateTime dataNascimento,
            double x,
            double y
        ){
            this.Nome = nome;
            this.Sexo = sexo;
            this.DataNascimento = dataNascimento;
            this.SetPosicao(x, y);
        }

        public string ResumoPessoa() {
            return String.Format("Nome: {0}\nSexo: {1}\nData de Nascimento: {2}",
                this.Nome,
                this.Sexo,
                this.DataNascimento
            );
        }

        public string PegarPosicao() => String.Format("{0}, {1}", this.eixoX, this.eixoY);

        public void SetPosicao(double x, double y)
        {
            this.eixoX = x;
            this.eixoY = y;
        }
    }
}
