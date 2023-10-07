﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagementDataAccessLayer.Interfaces;
using UserManagementModels.Models;

namespace UserManagementDataAccessLayer.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<User> GetAllUsers()
        {
            // Imple
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var users = new List<User>();
            using var command = new SqlCommand("SELECT * FROM Users", connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                users.Add(new User
                {
                    Id = (int)reader["Id"],
                    Name = (string)reader["Name"],
                    
                });
            }

            return users;
        }

        public void AddUser(User user)
        {
            // ado.net code to add user.
        }
    }
}