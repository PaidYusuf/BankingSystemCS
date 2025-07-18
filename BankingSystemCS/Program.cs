using BankingSystemCS.userCS;
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

        private UserLoginRegister UserLoginRegister = new UserLoginRegister();

        private void changeMoney(User user, double Amount) {
            if (Amount >= 0) {
                user.GetAssetsPaper().SetMoneyAmount(Amount);
                Console.WriteLine($"Your New Balance is: {user.GetAssetsPaper().GetMoneyAmount()}");
            }
            else {
                Console.WriteLine($"You Will Be In Debt, Your New Balance is: {user.GetAssetsPaper().GetMoneyAmount()}");

            }
        }




        static void Main(string[] args) {


            Console.WriteLine("Hello! Please press 1 or 2.\n" +
                "1 -| Sign in\n" +
                "2 -| Sign up");

            string choice = Console.ReadLine();

            if (choice == "1") {
                Console.Write("Username: ");
                string username = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                int UserID = UserLoginRegister.AuthenticateUser(username, password);

                if (UserID >= 0) {
                    Console.WriteLine("Login successful!");
                    UserLoginRegister.SetUserID(UserID);
                    User user1 = new User(UserID);

                    Console.WriteLine(user1);
                }



                else
                    Console.WriteLine("Invalid credentials");
            }

            else if (choice == "2") {
                Console.Write("Username: ");
                string username = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                if (UserLoginRegister.RegisterUser(username, password, email)) {
                    Console.WriteLine("Registration successful!");
                    int UserID = UserLoginRegister.AuthenticateUser(username, password);

                    User user1 = new User(UserID);
                    Console.WriteLine(user1);
                    
                }
            }








            Console.WriteLine("End Of Program!!");


            Console.ReadLine();

        }
    }
}
