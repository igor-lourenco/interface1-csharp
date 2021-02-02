using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Interface2.Entidades {
    class Prestacao {

        public DateTime DataVencimento { get; set; }
        public double Quantia { get; set; }

        public Prestacao(DateTime dataVencimento, double quantia) {
            DataVencimento = dataVencimento;
            Quantia = quantia;
        }

        public override string ToString() {
            return DataVencimento.ToString("dd/MM/yyyy") +
                " - " +
                Quantia.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
