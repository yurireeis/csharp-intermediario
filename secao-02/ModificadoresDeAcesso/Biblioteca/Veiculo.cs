using System;

namespace ModificadoresDeAcesso.Biblioteca
{
    public class Veiculo
    {
        public Veiculo(string marca, string modelo, DateTime dataDeFabricacao)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.DataDeFabricacao = dataDeFabricacao;
        }
        protected string Marca;
        protected string Modelo;
        protected DateTime DataDeFabricacao;
        public string InfoVeiculo() => String.Format(
            "Marca: {0}\nModelo: {1}\nData de Fabricação: {2}",
            this.Marca,
            this.Modelo,
            this.DataDeFabricacao
        );
    }
}
