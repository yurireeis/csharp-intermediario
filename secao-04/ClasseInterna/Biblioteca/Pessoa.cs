namespace ClasseInterna.Biblioteca
{
    public class Pessoa
    {
        // criando uma classe interna (Olho)
        public class Olho
        {
            /*
              essa propriedade estática poderá ser chamada através da pessoa
              caso a classe Olho esteja pública (do contrário somente poderá
              ser chamada dentro da classe pessoa)
            */
            public static string Iris = "Verde";
        }
    }
}