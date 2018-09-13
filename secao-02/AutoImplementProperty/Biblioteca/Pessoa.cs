namespace AutoImplementProperty.Biblioteca
{
    public class Pessoa
    {
        public string Nome { get; private set; }

        // modo personalizado
        // acrescenta o nome da variável com underline na frente como sendo privada
        // depois realiza a implementação logo após o get e o set
        private string _Telefone;
        public string Telefone {
          get {
            return _Telefone.ToUpper();
          }
          set {
            _Telefone = value.Trim().ToUpper();
          }
        }
        private string _Endereco;
        public string Endereco { 
          get => _Endereco.ToLower();
          set => _Endereco = value.Trim().ToLower();
        }

        public void SetNome(string nome) => this.Nome = nome;
    }
}
