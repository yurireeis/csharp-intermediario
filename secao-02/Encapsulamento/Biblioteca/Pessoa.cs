namespace Encapsulamento.Biblioteca
{
    public class Pessoa
    {
        private string Nome;
        private string CEP;
        private string Endereco;
        private string CPF;

        public void SetNome(string nome) => this.Nome = nome.Trim().ToUpper();

        public string GetNome() => this.Nome;
    }
}
