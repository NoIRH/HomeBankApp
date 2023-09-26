using HomeBankApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBankApp.Contexts
{
    public class FileContext
    {
        public List<User> Users { get; set; }
        public List<Operation> Operations { get; set; }
    }
}
