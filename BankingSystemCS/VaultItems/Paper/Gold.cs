using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemCS.VaultItems.Paper {
    internal class Gold {
        private int Amount { get; set; }
        private int Price { get; set; }

        public Gold(int Amount, int Price) {
            this.Amount = Amount;
            this.Price = Price;
        }



        public override string ToString() {
            return $"Your balance is {Amount * Price} with {Amount} gold bars.\n";
        }
    }
}
