namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta contaComum = new Conta(230, 100, false, 100);
            Conta contaEspecial = new Conta(231, 100, true, 100);
            contaComum.RealizarTransferencia(contaEspecial, 50);
            Console.WriteLine(contaComum.RealizarSaque(150));
            Console.WriteLine(contaEspecial.RealizarDeposito(50));
            Console.WriteLine(contaComum.ExibirExtrato());
            Console.WriteLine(contaEspecial.ExibirExtrato());
            Console.ReadLine();
        }
    }
}