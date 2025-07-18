using BankingSystemCS.VaultItems.Paper;
using BankingSystemCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingSystemCS.DatabaseTools;

namespace BankingSystemCS {
    internal class User {
        //Services
        private UserDatabaseConfigs UserDatabaseConfigs = new UserDatabaseConfigs();
        //Services


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //USER INFORMATIONS
        protected int UserID { get; set; }
        protected String UserName { get; set; }
        protected Bank UserBank { get; set; }
        //protected String Password { get; set; }
        //protected String UserEmail { get; set; }
        //protected String UserPhone { get; set; }
        //protected String UserPassword { get; set; }

        //USER INFORMATIONS
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //VAULT
        protected Vault UserVault { get; set; }
        protected AssetsPaper AssetsPaper { get; set; }
        protected AssetsLand AssetsLand { get; set; }
        //VAULT
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //GETTER SETTER
        public Vault GetUserVault() { return UserVault; }
        public AssetsPaper GetAssetsPaper() {  return AssetsPaper; }
        public AssetsLand GetAssetsLand() { return AssetsLand; }
        //GETTER SETTER
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //PAPER ASSSETS

        //protected Gold Gold { get; set; }
        //public Money Money { get; set; }
        //protected Stock Stock { get; set; }

        //PAPER ASSSETS
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //LAND ASSETS

        //LAND ASSETS


        //CONSTRUCTER

        //public User() { }

        //public User(int UserID, String UserName, int GAmount, int GPrice, int MAmount) {
        //    this.UserID = UserID;
        //    this.UserName = UserName;
        //    AssetsPaper = new AssetsPaper(MAmount, GAmount, GPrice);
        //    Gold = new Gold(GAmount, GPrice);
        //    Money = new Money(MAmount);
        //    Stock stock = new Stock("AAPL", 210.02);
        //    AssetsPaper.AddStock(stock);
        //}

        public User(int UserID) { 
            this.UserID = UserID; 
            UserName =  UserDatabaseConfigs.GetUsernameByUserID(UserID);
        }

        //CONSTRUCTER







        public override string ToString() {
            Console.Clear();

            return $"You are currently in User class with username {UserName} and UserID {UserID}";



            //return $"--------------------\n" +
            //    $"Welcome {UserName}!  USERID=== {UserID}\n" +
            //    $"== Your Balance ==\n" +
            //    $"--------------------\n\n" +
            //    $"Money= {Money}$\n\n" +
            //    $"Gold= {Gold}$\n\n" +
            //    $"Stock= {Stock}\n\n" +
            //    $"{AssetsPaper}";
        }



    }
}
