using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemCS.userCS {
    internal class UserLoginRegister {
        private static int UserID {get; set; }

        //HASH ALGORITHM
        private static string HashPassword(string password) {
            using (var sha256 = SHA256.Create()) {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
        //HASH ALGORITHM
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //USER LOGIN AUTHENTICATION
        public static int AuthenticateUser(string username, string password) {
            string hashedPassword = HashPassword(password);

            string query = "SELECT UserID FROM Users WHERE Username = @Username AND Password = @Password";

            SqlParameter[] parameters = {
        new SqlParameter("@Username", username),
        new SqlParameter("@Password", hashedPassword)
    };

            using (var reader = DatabaseHelper.ExecuteReader(query, parameters)) {
                if (reader.Read()) // This checks for rows AND advances to the first record
                {
                    return reader.GetInt32(reader.GetOrdinal("UserID")); // Safer column access
                }
                return -1; // Authentication failed
            }
        }
        //USER LOGIN AUTHENTICATION
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //NEW USER REGISTERATION
        public static bool RegisterUser(string username, string password, string email) {
            if (UsernameExists(username)) {
                Console.WriteLine("Username already exists!");
                return false;
            }

            string hashedPassword = HashPassword(password);

            string query = @"INSERT INTO Users (Username, Password, Email) 
                    VALUES (@Username, @Password, @Email)";

            SqlParameter[] parameters = {
        new SqlParameter("@Username", username),
        new SqlParameter("@Password", hashedPassword),
        new SqlParameter("@Email", email)
    };

            int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
        private static bool UsernameExists(string username) {
            string query = "SELECT 1 FROM Users WHERE Username = @Username";
            SqlParameter parameter = new SqlParameter("@Username", username);

            using (var reader = DatabaseHelper.ExecuteReader(query, new[] { parameter })) {
                return reader.HasRows;
            }
        }
        //NEW USER REGISTERATION
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //USERID SETTER
        public static void SetUserID(int ID) {
            UserID = ID;
        }
        //USERID SETTER

        public UserLoginRegister() { }
    }
}
