using System.Data;
using System.Data.SqlClient;

public static class DatabaseHelper {
    private static string connectionString = "Server=.\\MSSQLSERVER01;Database=BankingSystem;Integrated Security=True;";

    public static SqlConnection GetConnection() {
        return new SqlConnection(connectionString);
    }

    // For executing queries that return data (SELECT)
    public static SqlDataReader ExecuteReader(string query, SqlParameter[] parameters = null) {
        var connection = GetConnection();
        var command = new SqlCommand(query, connection);

        if (parameters != null)
            command.Parameters.AddRange(parameters);

        connection.Open();
        return command.ExecuteReader(CommandBehavior.CloseConnection);
    }

    // For executing queries that modify data (INSERT, UPDATE, DELETE)
    public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null) {
        using (var connection = GetConnection())
        using (var command = new SqlCommand(query, connection)) {
            if (parameters != null)
                command.Parameters.AddRange(parameters);

            connection.Open();
            return command.ExecuteNonQuery();
        }
    }
}