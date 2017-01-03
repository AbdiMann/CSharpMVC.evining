using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MVCEvening.ViewModels;

namespace MVCEvening.Models
{
    public class Repository
    {

        public string _connectionString =
            System.Configuration.ConfigurationManager.ConnectionStrings["CSharpMVC"].ConnectionString;



        public void Create(CustomerForm customerForm)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"INSERT INTO CustomersTable (CustomerName,CustomerAddress,CustomerPhone)
                                                VALUES (@CustomerName,@CustomerAddress,@CustomerPhone)";
                command.Parameters.AddWithValue("@CustomerName", customerForm.CustomerName);
                command.Parameters.AddWithValue("@CustomerAddress", customerForm.CustomerAddress);
                command.Parameters.AddWithValue("@CustomerPHone", customerForm.CustomerPhone);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}