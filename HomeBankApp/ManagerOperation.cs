using HomeBankApp.Models;

namespace HomeBankApp
{
    public static class ManagerOperation
    {
        private static DbManager _manager = new DbManager();

        private static List<(int monthNumber, double sumOfMonth)> GetOperationsForCurrentYearByExpression(Predicate<Operation> expression)
        {
            if (expression == null) throw new NullReferenceException("Expression is null");
            int numberOfMonths = 12;
            var amountsByMonth = new List<(int monthNumber, double sumOfMonth)>();
            for (int i = 1; i < numberOfMonths + 1; i++)
            {
                var amountInCurrentMonth = _manager.GetOperations().Where(op => op.Date.Month == i && expression(op)).Sum(op => op.Value);
                if (amountInCurrentMonth != 0)
                    amountsByMonth.Add((i, amountInCurrentMonth));
            }
            return amountsByMonth;
        }

        public static List<(int monthNumber, double sumOfMonth)> GetOperationsForCurrentYearPositive() => GetOperationsForCurrentYearByExpression((Operation op) => op.Value > 0);

        public static List<(int monthNumber, double sumOfMonth)> GetOperationsForCurrentYearNegative() => GetOperationsForCurrentYearByExpression((Operation op) => op.Value < 0);

        public static IEnumerable<Operation> GetOperationsForCurrentMonth() => _manager.GetOperations().Where(op => op.Date.Month == DateTime.Now.Month);

        public static double GetTotalMoney() => _manager.GetOperations().Sum(op => op.Value);

        public static void AddOperation(double value)
        {
            if (value == 0) throw new ArgumentException("Invalid value. The value is zero.");
            _manager.AddOperation(new Operation()
            {
                Value = value,
                Date = DateTime.Now,
                User = _manager.GetAdmin()
            });
        }

    }
}
