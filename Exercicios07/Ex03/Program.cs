namespace Lista07Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cli1 = new Cliente();
            Carro car1 = new Carro();
            Aluguel aluguel = new Aluguel();

            cli1.pedirDados();
            car1.pedirCarro();

            aluguel.seguro = true;
            aluguel.inicio = new DateTime(2022, 10, 10, 14, 0, 0);
            aluguel.termino = new DateTime(2022, 10, 15, 18, 0, 0);
            aluguel.valorDiaria = 240;
            aluguel.carro = car1;
            aluguel.cliente = cli1;

            aluguel.exibeAluguel();
            cli1.exibeCliente();
            car1.exibeCarro();
        }
        
    }
}
