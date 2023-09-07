using HomeBankApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBankApp
{
    public class DbManager
    {
        ApplicationContext Context = new ApplicationContext();
        public void InitializeDb() 
        {
            Context.Database.EnsureCreated();
            Context.Users.Load();
            Context.Operations.Load();
        }
        public IEnumerable<User> GetUsers() => Context.Users;
        public IEnumerable<Operation> GetOperations() => Context.Operations;
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
