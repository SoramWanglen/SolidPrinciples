using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrn
{
   
    public abstract class ChefSalaryCalculator
    {

        public abstract double CalculateSalary();
    }
    public class JuniorChefSalary : ChefSalaryCalculator
    {
        public double BPay { get; set; }
        public double VariablePay { get; set; }
        public double NetPay { get; set; }
        public override double CalculateSalary()
        {
            return BPay + VariablePay + NetPay;
        }
    }
    public class SeniorChefSalary : ChefSalaryCalculator
    {
        public double BPay { get; set; }
        public double BPay2{ get; set; }
        public double Allowances { get; set; }
        public double VariablePay{ get; set; }
        public double NetPay { get; set; }
        public override double CalculateSalary()
        {
            return BPay + BPay2 + Allowances + VariablePay + NetPay;
        }
    }
    class ResOpenClosed
    {
        public void CalculateTotalSalary()
        {
            JuniorChefSalary calculator = new JuniorChefSalary();
            calculator.BPay = 5000;
            calculator.VariablePay = 2000;
            calculator.NetPay = 100;
            calculator.CalculateSalary();
            
        }
    }
}
