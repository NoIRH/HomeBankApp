﻿using HomeBankApp.Contexts;
using HomeBankApp.Interfaces;
using HomeBankApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBankApp.Managers
{
    public class FileStorageManager : IDataStorageManager
    {
        public FileContext Context { get; set; }
        public string Path { get; set; } = "storage.json";
        public FileStorageManager() 
        {
            Context = JsonConverter.Deserialize(Path);
            SetStateDefault();
            CreateAdmin();
        }
        private void SetStateDefault()
        {
            if (Context.Users == null) Context.Users = new List<User>();
            if (Context.Operations == null) Context.Operations = new List<Operation>();
        }
        private void CreateAdmin()
        {
            if (Context.Users.FirstOrDefault(x => x.Role == 0) == null)
                AddUser(new User { Name = "admin", Password = "admin", Role = 0 });
        }

        public User GetAdmin() => Context.Users.FirstOrDefault(x => x.Role == 0);

        public IEnumerable<User> GetUsers() => Context.Users;

        public IEnumerable<Operation> GetOperations() => Context.Operations;

        public DateTime GetMinDate() => Context.Operations.Select(x => x.Date).Min();

        public void AddUser(User user)
        {
            Context.Users.Add(user);
            SaveChanges();
        }

        public void RemoveUser(User user)
        {
            Context.Users.Remove(user);
            SaveChanges();
        }

        public void AddOperation(Operation operation)
        {
            Context.Operations.Add(operation);
            SaveChanges();
        }

        public void RemoveOperation(Operation operation)
        {
            Context.Operations.Remove(operation);
            SaveChanges();
        }

        public void SaveChanges()
        {
            JsonConverter.Serialize(Context,Path);
        }
    }
}
