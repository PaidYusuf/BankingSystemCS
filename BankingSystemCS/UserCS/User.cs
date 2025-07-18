using BankingSystemCS.VaultItems.Paper;
using BankingSystemCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemCS {
    internal class User {

        //USER INFORMATIONS
        protected int UserID { get; set; }
        protected String UserName { get; set; }
        protected String Password { get; set; }
        protected String UserEmail { get; set; }
        protected String UserPhone { get; set; }
        protected String UserPassword { get; set; }

        //VAULT
        protected Vault UserVault { get; set; }
        protected AssetsPaper AssetsPaper { get; set; }


        //PAPER ASSSETS
        protected Gold Gold { get; set; }
        public Money Money { get; set; }
        protected Stock Stock { get; set; }

        //LAND ASSETS



        public User() { }

        public User(int UserID, String UserName, int GAmount, int Price, int MAmount) {
            this.UserID = UserID;
            this.UserName = UserName;
            Gold = new Gold(GAmount, Price);
            Money = new Money(MAmount);
            Stock = new Stock("AAPL", 210.02);
        }




        public override string ToString() {
            Console.Clear();
            return $"--------------------\n" +
                $"Welcome {UserName}!  USERID=== {UserID}\n" +
                $"== Your Balance ==\n" +
                $"--------------------\n\n" +
                $"Money= {Money}$\n\n" +
                $"Gold= {Gold}$\n\n" +
                $"Stock= {Stock}\n" +
                $"\n" +
                $"\n" +
                $"\n" +
                $"{AssetsPaper}";
        }



    }
}
