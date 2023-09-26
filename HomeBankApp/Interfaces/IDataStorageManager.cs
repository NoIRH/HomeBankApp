using HomeBankApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBankApp.Interfaces
{
    public interface IDataStorageManager
    {

        public User GetAdmin();

        public IEnumerable<User> GetUsers();

        public IEnumerable<Operation> GetOperations();

        public DateTime GetMinDate();

        public void AddUser(User user);

        public void RemoveUser(User user);

        public void AddOperation(Operation operation);


        public void RemoveOperation(Operation operation);

        public void SaveChanges();
    }
}
