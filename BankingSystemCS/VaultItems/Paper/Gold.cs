using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemCS.VaultItems.Paper {
    internal class Gold {
        public double Amount { get; set; }
        public double Price { get; set; }

        public Gold(int Amount, double Price) {
            this.Amount = Amount;
            this.Price = Price;
        }



        public override string ToString() {
            return $"Your balance is {Amount * Price} with {Amount} gold bars.\n";
        }
    }
}
