using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemCS.VaultItems.Paper {
    internal class Stock {
        private int stockID { get; set; }
        public string stockName { get; private set; }
        private double stockPrice { get; set; }

        public Stock(string stockName, double StockPrice) {

            this.stockName = stockName;
            this.stockPrice = StockPrice;
        }


        public override string ToString() {
            return "Test ToString Stock";
        }


    }
}
