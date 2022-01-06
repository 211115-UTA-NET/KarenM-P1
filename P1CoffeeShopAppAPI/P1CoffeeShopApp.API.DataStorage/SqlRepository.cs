﻿using System.Text;
using P1CoffeeShopAPI.DataStorage;
using P1CoffeeShopAppAPI.Logic;
using Microsoft.Data.SqlClient;
namespace P1CoffeeShopAPI.Data
{

    //comment out for now
    public class SqlRepository : IRepository
    {
        private readonly string _connectionString;

        public SqlRepository(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        public Task<List<Customers>> GetAllCustomersAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Locations>> GetLocationsAsync()
        {
            List<Locations> locations = new List<Locations>();
            using SqlConnection connection = new(_connectionString);
            await connection.OpenAsync();
            using SqlCommand cmd = new SqlCommand(
                //0         1
                //id       location
                @"SELECT * FROM Store", connection);
            using SqlDataReader reader = cmd.ExecuteReader();

            while (await reader.ReadAsync())
            {
                
                locations.Add(new(reader.GetInt32(0), reader.GetString(1)));
            }
            await connection.CloseAsync();
            return locations;
        }

    }
}