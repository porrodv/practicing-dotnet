using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Npgsql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTINGCS
{
    class FoodDB
    {
        private string host = "localhost";
        private string port = "5432";
        private string database = "foods";
        private string user = "postgres";
        private string password = "password";
        private string connectionString = null;

        public FoodDB()
        {
            connectionString = $"Host={host};Port={port};Database={database};Username={user};Password={password}";
        }

        public List<Food> GetFoods()
        {
            List<Food> foods = new List<Food>();
            string query = "SELECT * FROM food";

            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            NpgsqlCommand comm = new NpgsqlCommand(query, conn);
            conn.Open();

            try
            {
                NpgsqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader.GetString(1);
                    double price = reader.GetDouble(2);
                    int quantity = reader.GetInt32(3);
                    Food food = new Food(name, price, quantity);
                    foods.Add(food);
                }
            }
            catch (Exception e) { Console.WriteLine(e); }
            finally { conn.Close(); }

            return foods;
        }

    }
}
