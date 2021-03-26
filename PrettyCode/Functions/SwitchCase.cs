using System;
using System.ComponentModel;

namespace PrettyCode.Functions
{
    // inserir o switch no fundo da abstração
    public interface EmployeeFactory
    {
        public string makeEmployee(EmployeeRecord r);
    }

    public class SwitchCase : EmployeeFactory
    {
        private const string COMMISIONED = "COMMISIONED";
        private const string HOURLY = "HOURLY";
        private const string SALARIED = "SALARIED";

        public string makeEmployee(EmployeeRecord e)
        {
            switch (e.Type)
            {
                case COMMISIONED:
                    return calculateCommisionedPay(e);
                case HOURLY:
                    return calculateHourlyPay(e);
                case SALARIED:
                    return calculateSalariedPay(e);
                default:
                    throw new InvalidEnumArgumentException(e.Type);
            }
        }

        private string calculateSalariedPay(Employee e) => throw new NotImplementedException();
        private string calculateHourlyPay(Employee e) => throw new NotImplementedException();
        private string calculateCommisionedPay(Employee e) => throw new NotImplementedException();
    }

    public abstract class Employee
    {
        public abstract bool IsPayDay();
        public abstract string CalculatePay();
        public abstract void DeliveryPay(string pay);
        public string Type { get; set; }
    }

    public class EmployeeRecord : Employee
    {
        public override string CalculatePay() => throw new NotImplementedException();
        public override void DeliveryPay(string pay) => throw new NotImplementedException();
        public override bool IsPayDay() => throw new NotImplementedException();
    }

}
