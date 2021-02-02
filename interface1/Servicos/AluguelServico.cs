using interface1.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace interface1.Servicos {
    class AluguelServico {

        public Double PrecoPorHora { get; private set; }
        public Double PrecoPorDia { get; private set; }

        private ITaxaServico _taxaServico;

        public AluguelServico(double precoPorHora, double precoPorDia, ITaxaServico taxaServico) {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            _taxaServico = taxaServico;
        }

        public void ProcessoAluguel(Aluguel aluguel) {
            TimeSpan duracao = aluguel.Fim.Subtract(aluguel.Inicio);

            double pagamentoBasico = 0.0;
            if (duracao.TotalHours <= 12.0)
                pagamentoBasico = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            else
                pagamentoBasico = PrecoPorDia * Math.Ceiling(duracao.TotalDays);

            double taxa = _taxaServico.Taxa(pagamentoBasico);

            aluguel.NotaPagamento = new Pagamento(pagamentoBasico, taxa);
        }
    }
}
