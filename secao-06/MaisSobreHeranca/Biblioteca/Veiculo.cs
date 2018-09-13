using System;

namespace MaisSobreHeranca.Biblioteca
{
    public abstract class Veiculo
    {
        protected DateTime AnoFabricacao { get; set; }
        public Veiculo() => this.AnoFabricacao = new DateTime();
    }
}
