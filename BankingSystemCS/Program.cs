using BankingSystemCS.userCS;
using BankingSystemCS.UserCS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemCS {
    internal class Program {
        //SERVICES
        private UserLoginRegister UserLoginRegister = new UserLoginRegister();
        private LoginRegisterPage LoginRegisterPage = new LoginRegisterPage();
        //SERVICES



        //private void ChangeMoney(User user, double Amount) {
        //    if (Amount >= 0) {
        //        user.GetAssetsPaper().SetMoneyAmount(Amount);
        //        Console.WriteLine($"Your New Balance is: {user.GetAssetsPaper().GetMoneyAmount()}");
        //    }
        //    else {
        //        Console.WriteLine($"You Will Be In Debt, Your New Balance is: {user.GetAssetsPaper().GetMoneyAmount()}");

        //    }
        //}

        private static void Login() {
            if (!LoginRegisterPage.LoginOrRegister(LoginRegisterPage.LoginString())) {
                Login();
            }
        }



        static void Main(string[] args) {
            Console.WriteLine("Welcome To The Banking System\n" +
                "Made by Yusuf");

            Login();


            Console.WriteLine("End Of Program!!");
            Console.ReadLine();

        }
    }
}
