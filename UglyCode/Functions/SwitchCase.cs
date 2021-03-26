using System;
using System.ComponentModel;
using static CoreCode.ExtrasClasses;

namespace UglyCode.Functions
{
    public class SwitchCase
    {
        private const string COMMISIONED = "COMMISIONED";
        private const string HOURLY = "HOURLY";
        private const string SALARIED = "SALARIED";
        public string CalculatePay(Employee e)
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
}
