using Interface2.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface2.Servicos {
    class ContratoServico {

        private IPagamentoOnlineServico _pagamentoOnlineServico;

        public ContratoServico(IPagamentoOnlineServico pagamentoOnlineServico) {
            _pagamentoOnlineServico = pagamentoOnlineServico;
        }

        public void ProcessoContrato(Contrato contrato, int meses) {
            double quotaBasica = contrato.ValorTotal / meses;
            for(int i = 1; i <= meses; i++) {
                DateTime data = contrato.Data.AddMonths(i);
                double quotaJuros = quotaBasica + _pagamentoOnlineServico.Juros(quotaBasica, i);
                double quotaTotal = quotaJuros + _pagamentoOnlineServico.TaxaPagamento(quotaJuros);
                contrato.AddPrestacao(new Prestacao(data, quotaTotal));
            }

        }
    }
}
