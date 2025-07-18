using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemCS.VaultItems.Paper {
    internal class Money {

        public double Amount { get; set; }

        public Money(double Amount) {
            this.Amount = Amount;
        }

        public override string ToString() {
            return "Your balance is: " + Amount;
        }
    }
}
