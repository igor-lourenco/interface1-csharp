using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace interface1.Entidades {
    class Pagamento {

        public double PagamentoBasico { get; set; }
        public double Taxa { get; set; }
     
        public Pagamento(double pagamentoBasico, double taxa) {
            PagamentoBasico = pagamentoBasico;
            Taxa = taxa;
            
       }

        public double PagamentoTotal {
            get { return PagamentoBasico + Taxa; }
        }

        public override string ToString() {
            return "\nPagamento básico-> " +
                PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture) +
                "\nTaxa-> " +
                Taxa.ToString("F2", CultureInfo.InvariantCulture) +
                "\nPagamento total -> " +
                PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture);
                
                }
    }
}
