using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BankingSystemCS.UserCS {
    public class AdminPanel {
        private readonly string _connectionString;

        public AdminPanel(string connectionString) {
            _connectionString = connectionString;
        }

        public void ShowAdminMenu() {
            while (true) {
                Console.Clear();
                Console.WriteLine("=== ADMIN PANEL ===");
                Console.WriteLine("1. List All Users");
                Console.WriteLine("2. Search Users");
                Console.WriteLine("3. Reset Password");
                Console.WriteLine("4. Exit");
                Console.Write("Select option: ");

                var input = Console.ReadLine();

                switch (input) {
                    case "1":
                        ListAllUsers();
                        break;
                    case "2":
                        //SearchUsers();
                        break;
                    case "3":
                        //ResetPassword();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid option!");
                        Thread.Sleep(1000);
                        break;
                }
            }
        }

        private void ListAllUsers() {
            Console.Clear();
            Console.WriteLine("=== ALL USERS ===");

            var users = GetAllUsers();

            // Table header
            Console.WriteLine($"{"ID",-5} {"Username",-20} {"Created",-20} {"Admin",-5}");
            Console.WriteLine(new string('-', 50));

            foreach (var user in users) {
                Console.WriteLine($"{user.UserID,-5} {user.UserName,-20} {user.DateCreated,-20:yyyy-MM-dd} {(user.IsAdmin ? "Yes" : "No"),-5}");
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        private List<User> GetAllUsers() {
            var users = new List<User>();

            using (var connection = new SqlConnection(_connectionString)) {
                var command = new SqlCommand("SELECT UserID, Username, DateCreated, IsAdmin FROM Users", connection);
                connection.Open();

                using (var reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        users.Add(new User
                        {
                            UserID = reader.GetInt32(0),
                            UserName = reader.GetString(1),
                            DateCreated = reader.GetDateTime(2),
                            IsAdmin = reader.GetBoolean(3)
                        });
                    }
                }
            }

            return users;
        }
    }


}
