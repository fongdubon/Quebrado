namespace ProBas09
{
    public class Fraccion
    {
        #region Propiedades
        public int Numerador { get; set; }
        public int Denominador { get; set; }
        #endregion
        #region Métodos
        public Fraccion()
        {
            this.Numerador = 0;
            this.Denominador = 1;
        }
        public Fraccion(int numerador, int denominador)
        {
            this.Numerador = numerador;
            this.Denominador = denominador;
        }
        public Fraccion Multiplicacion(Fraccion B)
        {
            return new Fraccion(this.Numerador * B.Numerador, this.Denominador * B.Denominador);
        }
        #endregion
    }
}
