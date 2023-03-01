using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    public class CommisionEmployee : Employee
    {
        #region Properties
        public float ComissionPercentage { get; set; }
        public decimal Sales { get; set; }
        #endregion

        #region Methods

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)ConvertPercentage(ComissionPercentage);
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tCommision percentage..........{ConvertPercentage(ComissionPercentage)}" +
                $"\n\tSales.........................{Sales:C2}" +
                $"\n\tValue to pay..................{GetValueToPay():C2}";
        }

        public float ConvertPercentage(float commisionPercentage)
        {
            return (commisionPercentage / 100);
        }
        #endregion
    }
}
