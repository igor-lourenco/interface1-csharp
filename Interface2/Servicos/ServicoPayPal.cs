using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Interface2.Servicos {
    class ServicoPayPal : IPagamentoOnlineServico {

        private static double TAXA_PAGAMENTO = 0.02;
        private static double JUROS_MENSAL = 0.01;
        public double Juros(double quantia, int meses) {
            return quantia * meses * JUROS_MENSAL;
        }

        public double TaxaPagamento(double quantia) {
            return quantia * TAXA_PAGAMENTO;
        }
    }
}
