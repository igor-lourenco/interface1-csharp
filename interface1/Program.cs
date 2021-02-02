using interface1.Entidades;
using interface1.Servicos;
using System;
using System.Globalization;

namespace interface1 {
    class Program {
        static void Main(string[] args) {

            
                Console.WriteLine("Entre com os dados do aluguel: ");
                Console.Write("Modelo do carro: ");
                string modelo = Console.ReadLine();
                Console.Write("Entrada (dd/MM yyyy hh:mm): ");
                DateTime saida = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                Console.Write("Entrada (dd/MM yyyy hh:mm): ");
                DateTime entrada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                Console.Write("Entre com o preço por hora: ");
                double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Entre com o preço por dia: ");
                double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Aluguel aluguel = new Aluguel(saida, entrada, new Veiculo(modelo));
                AluguelServico aluguelServico = new AluguelServico(hora, dia, new BrasilTaxaServico());

                aluguelServico.ProcessoAluguel(aluguel);

                Console.WriteLine();
                Console.WriteLine("FATURA: ");
                Console.WriteLine(aluguel.NotaPagamento);
            
        }
    }
}
