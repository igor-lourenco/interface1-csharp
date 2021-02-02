using System;
using System.Collections.Generic;
using System.Text;

namespace interface1.Servicos {
    class BrasilTaxaServico {

        public double Taxa(double quantia) {
            if (quantia <= 100.0)
                return quantia * 0.2;
            else
                return quantia * 0.15;
        }
    }
}
