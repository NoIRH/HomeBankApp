﻿using HomeBankApp.Interfaces;
using HomeBankApp.Models;

namespace HomeBankApp.Managers
{
    public static class ManagerOperation
    {
        private static IDataStorageManager _manager;

        public static IDataStorageManager Manager
        {
            get { return _manager; }
            set { _manager = value; }
        }

        private static List<(int monthNumber, double sumOfMonth)> GetOperationsForCurrentYearByExpression(Predicate<Operation> expression)
        {
            //добавь зависимость от юзера.
            if (expression == null) throw new NullReferenceException("Expression is null");
            int startMonth = _manager.GetMinDate().Month - 1; // Range from 0 to 11.
            int numberOfMonths = 12;
            var amountsByMonth = new List<(int monthNumber, double sumOfMonth)>();
            for (int i = 0; i < numberOfMonths; i++)
            {
                int currentMonth = (startMonth + i) % numberOfMonths + 1;
                double amountInCurrentMonth = _manager.GetOperations().Where(op => op.Date.Month == currentMonth && expression(op)).Sum(op => op.Value);
                if (amountInCurrentMonth != 0)
                    amountsByMonth.Add((currentMonth, amountInCurrentMonth));
            }
            return amountsByMonth;
        }

        public static List<(int monthNumber, double sumOfMonth)> GetOperationsForCurrentYearPositive() => GetOperationsForCurrentYearByExpression((op) => op.Value > 0);

        public static List<(int monthNumber, double sumOfMonth)> GetOperationsForCurrentYearNegative() => GetOperationsForCurrentYearByExpression((op) => op.Value < 0);

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
