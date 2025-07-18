using BankingSystemCS.VaultItems.Paper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemCS {

    internal class AssetsPaper {

        //VARIABLES
        private Gold Gold {  get; set; }
        private Money Money { get; set; }
        private List<Stock> Stocks { get; set; }
        //VARIABLES
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //CONSTRUCTER
        public AssetsPaper() {
            Gold = new Gold(0,0);
            Money = new Money(0);
            Stocks = new List<Stock>();
        }
        public AssetsPaper(double MAmount, int GAmount, double GPrice) {
            Gold = new Gold(GAmount, GPrice);
            Money = new Money(MAmount);
            Stocks = new List<Stock>();
        }
        //CONSTRUCTER
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                            //METHODS//
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //STOCK METHOD
        public void AddStock(Stock stock) {  Stocks.Add(stock); }
        public void RemoveStock(Stock stock) {  Stocks.Remove(stock); }
        //STOCK METHOD
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //SET GOLD / MONEY METHOD
        public void SetMoneyAmount(double Amount) { Money.Amount = Amount; }
        public void SetGoldAmount(double Amount) { Gold.Amount = Amount; }
        public void SetGoldPrice(double Price) { Gold.Price = Price; }
        //SET GOLD / MONEY METHOD
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //GET GOLD / MONEY METHOD
        public double GetMoneyAmount() { return Money.Amount; }
        public double GetGoldAmount() { return Gold.Amount; }
        public double GetGoldPrice() { return Gold.Price; }
        //GET GOLD / MONEY METHOD
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        private String ListStocks() {
            string sentence = string.Join(" \n", Stocks);
            return sentence;
        }






        public override string ToString() {
            return $"{ListStocks()}";
        }

    }
}
