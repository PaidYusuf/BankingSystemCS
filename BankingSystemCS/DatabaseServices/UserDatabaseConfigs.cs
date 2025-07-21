using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemCS.DatabaseTools {
    internal class UserDatabaseConfigs {

        private static string connectionString = "Server=.\\MSSQLSERVER01;Database=BankingSystem;Integrated Security=True;";


        public static string GetUsernameByUserID(int userID) {
            try {
                string query = @"
            SELECT Username 
            FROM Users 
            WHERE UserID = @UserID";

                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@UserID", userID);
                    connection.Open();

                    // ExecuteScalar returns first column of first row
                    return command.ExecuteScalar() as string;
                }
            }
            catch (SqlException ex) {
                // Log error (you might want to use a logging framework)
                Console.WriteLine($"Database error: {ex.Message}");
                return null;
            }
        }




        public UserDatabaseConfigs() { }


    }
}
