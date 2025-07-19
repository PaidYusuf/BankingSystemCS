using BankingSystemCS.userCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemCS.UserCS {
    internal class LoginRegisterPage {

        public static String LoginString() {
            Console.WriteLine("Please press 1 or 2.\n" +
            "1 -| Sign in\n" +
            "2 -| Sign up");
            String choice = Console.ReadLine();
            return choice;
        }

        public static bool LoginMethod() {


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

                return true;
            }


            else {
                Console.Clear();

                Console.WriteLine("Invalid credentials, Please try again.\n");
                return false;
            }
        }


        public static bool RegisterMethod() {
            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            if (UserLoginRegister.RegisterUser(username, password, email)) {
                Console.WriteLine("Registration successful!, Please login again.");
                int UserID = UserLoginRegister.AuthenticateUser(username, password);

                return false;
            }

            Console.WriteLine("UNKNOWN ERROR PLEASE PROVIDE THIS CODE TO DEVELOPER (E_LRP_69)");
            return true;
        }

        public static bool LoginOrRegister(String choice) {
            if (choice.Equals("1")) { return LoginMethod(); }
            else if(choice.Equals("2")) {return RegisterMethod(); }
            else { Console.WriteLine($"{choice} is not a valid operation please try again.");
                return false;
            }
            return true;
        }


        public LoginRegisterPage() { }
    }
}
