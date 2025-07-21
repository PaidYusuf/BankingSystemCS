using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemCS.VaultItems.Paper {
    internal class Stock {
        private int StockID { get; set; }
        public string StockName { get; private set; }
        private double StockPrice { get; set; }

        public Stock(string stockName, double StockPrice) {

            this.StockName = stockName;
            this.StockPrice = StockPrice;
        }


        public override string ToString() {
            return "Test ToString Stock";
        }


    }
}
