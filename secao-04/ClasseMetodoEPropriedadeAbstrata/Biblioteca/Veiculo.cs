using System;

namespace ClasseMetodoEPropriedadeAbstrata.Biblioteca
{
    public abstract class Veiculo
    {
        protected string Marca;
        protected string Modelo;
        protected DateTime DataDeFabricacao;
        protected byte Rodas;
        protected byte Eixos;

        // criando uma propriedade abstrata para que seja implementada obrigatoriamente nos filhos
        abstract public string Montadora { get; set; }

        // método abstrato vem apenas com a assinatura!
        // não é necessário setar a palavra reservada virtual para métodos abstratos
        public abstract void MudarMarcha(byte numeroDaMarcha);
    }
}
