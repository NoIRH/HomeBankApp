using HomeBankApp.Models;

namespace HomeBankApp.Contexts
{
    public class FileContext
    {
        public List<User> Users { get; set; }

        public List<Operation> Operations { get; set; }
    }
}