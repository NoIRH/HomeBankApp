using HomeBankApp.Contexts;
using HomeBankApp.Interfaces;
using HomeBankApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBankApp.Managers
{
    public class DbManager : IDataStorageManager
    {
       Contexts.ApplicationContext Context { get; set; }

        public DbManager()
        {
            Context = new Contexts.ApplicationContext();
            Context.Database.EnsureCreated();
            Context.Users.Load();
            Context.Operations.Load();
            CreateAdmin();
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

        public void SaveChanges() => Context.SaveChanges();

    }
}
