using Interface2.Entidades;
using Interface2.Servicos;
using System;
using System.Globalization;

namespace Interface2 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com os dados do contrato: ");
            Console.Write("Numero: ");
            int numero =int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do contrato: ");
            double valorContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o numero de parcelas: ");
            int parcelas = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numero, data, valorContrato);
            ContratoServico contratoServico = new ContratoServico(new ServicoPayPal());
            contratoServico.ProcessoContrato(contrato, parcelas);

            Console.WriteLine();
            Console.WriteLine("PARCELAS");
            foreach(Prestacao p in contrato.Prestacoes) {
                Console.WriteLine(p);
            }
        }
    }
}
