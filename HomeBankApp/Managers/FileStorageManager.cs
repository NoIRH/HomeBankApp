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
        public void AddOperation(Operation operation)
        {
            throw new NotImplementedException();
        }

        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public User GetAdmin()
        {
            throw new NotImplementedException();
        }

        public DateTime GetMinDate()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Operation> GetOperations()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void RemoveOperation(Operation operation)
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(User user)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
