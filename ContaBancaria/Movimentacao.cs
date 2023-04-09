namespace ContaBancaria
{
    public class Movimentacao
    {
        private decimal valor;
        private string tipo;
        public decimal Valor
        {
            get
            {
                return this.valor;
            }
        }

        public string Tipo
        {
            get
            {
                return this.tipo;
            }
        }

        public Movimentacao(decimal valor, string tipo)
        {
            this.valor = valor;
            this.tipo = tipo;
        }
    }
}
