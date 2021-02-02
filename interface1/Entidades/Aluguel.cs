using System;
using System.Collections.Generic;
using System.Text;

namespace interface1.Entidades {
    class Aluguel {

        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public Veiculo Veiculo { get; set; }
        public Pagamento NotaPagamento { get; set; }

        public Aluguel(DateTime inicio, DateTime fim, Veiculo veiculo) {
            Inicio = inicio;
            Fim = fim;
            Veiculo = veiculo;
            NotaPagamento = null;
        }

       
    }
}
