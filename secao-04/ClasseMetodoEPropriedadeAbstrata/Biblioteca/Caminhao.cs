using System;

namespace ClasseMetodoEPropriedadeAbstrata.Biblioteca
{

    public class Caminhao : Veiculo
    {
        private string _Montadora;
        public override string Montadora {
            get => this._Montadora;
            set => this._Montadora = value;
        }

        public override void MudarMarcha(byte numeroDaMarcha) => Console.WriteLine(String.Format(
            "Passou para a {0} marcha",
            numeroDaMarcha
        ));
    }
}
