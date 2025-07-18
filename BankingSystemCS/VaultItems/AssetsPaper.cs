using BankingSystemCS.VaultItems.Paper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemCS {

    internal class AssetsPaper {


        private int MoneyAmount { get; set; }
        private int GoldAmount { get; set; }
        private List<Stock> Stocks { get; set; }

        public AssetsPaper() {
            MoneyAmount = 0;
            GoldAmount = 0;
            Stocks = new List<Stock>();
        }

        private String ListStocks() {
            string sentence = string.Join(" \n", Stocks);
            return sentence;
        }






        public override string ToString() {
            return $"Money Amount: {MoneyAmount}\n" +
                $"Gold Amount: {GoldAmount}\n" +
                $"{ListStocks()}";
        }

    }
}
