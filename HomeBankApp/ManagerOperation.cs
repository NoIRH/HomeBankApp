using HomeBankApp.Models;
using ScottPlot;


namespace HomeBankApp
{
    internal static class ManagerOperation
    {
        private static DbManager _manager = new DbManager();

        public static IEnumerable<Operation> GetOperationsByCurrentMonth() => _manager.GetOperations().Where(op => op.Date.Month == DateTime.Now.Month);

        public static IEnumerable<Operation> GetOperationsByCurrentYearAdd() => _manager.GetOperations().Where(op => op.Date.Year == DateTime.Now.Year && op.Value > 0);

        public static IEnumerable<Operation> GetOperationsByCurrentYearRemove() => _manager.GetOperations().Where(op => op.Date.Year == DateTime.Now.Year && op.Value < 0);

        public static double GetTotalMoney() => _manager.GetOperations().Sum(op => op.Value);

        public static void AddMoney(double value)
        {
            if (value == 0) throw new ArgumentException("Invalid value"); // Add an upper and lower bound to the value.
            _manager.AddOperation(new Operation() { Value = value, Date = DateTime.Now });
        }

        public static void RemoveMoney(double value) => AddMoney(-value);

    }
}
