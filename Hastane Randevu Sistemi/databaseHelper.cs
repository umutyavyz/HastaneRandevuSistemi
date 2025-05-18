using System;
using System.Data;
using System.Data.SqlClient;

public class DatabaseHelper
{
    // MSSQL bağlantı cümlesi – Kendi sunucu ve veritabanı adını kontrol etmeyi unutma
    private static string connectionString = "Server=MONSTER\\SQLEXPRESS;Database=HastaneRandevu;Trusted_Connection=True;";

    /// <summary>
    /// INSERT, UPDATE, DELETE gibi sorguları çalıştırır ve etkilenen satır sayısını döner.
    /// </summary>
    public static int ExecuteNonQuery(string query, params SqlParameter[] parameters)
    {
        using (var conn = new SqlConnection(connectionString))
        {
            conn.Open();
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery(); // Kaç satır etkilendiğini döndür
            }
        }
    }

    /// <summary>
    /// SELECT sorgularını çalıştırır ve sonucu DataTable olarak döner.
    /// </summary>
    public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
    {
        using (var conn = new SqlConnection(connectionString))
        {
            conn.Open();
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddRange(parameters);
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
