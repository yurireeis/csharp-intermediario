namespace ClasseSealed.Biblioteca
{
    public sealed class Carro : Veiculo
    {
        private string _Marca;
        public override string Marca { get => this._Marca.ToUpper(); set => this._Marca = value; }
    }
}
