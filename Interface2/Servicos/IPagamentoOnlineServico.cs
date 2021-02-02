using System;
using System.Collections.Generic;
using System.Text;

namespace Interface2.Servicos {
    interface IPagamentoOnlineServico {

        double TaxaPagamento(double quantia);
        double Juros(double quantia, int meses);
    }
}
