namespace Estrutura.Biblioteca
{
    struct Polegada
    {
        /*
          construtores não podem ter valores diretamente atribuídos as suas propriedades
          até a construção é muito similar ao da classe
        */

        double centimetro;
        double polegada;
        public Polegada(double polegadas) {
          this.centimetro = 2.54;
          this.polegada = this.centimetro * polegadas;
        }

        public double getPolegadaCentimetros() => this.polegada;
    }
}
