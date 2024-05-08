

using Practica3_TaxCalculadora.Interfaces;

namespace Practica3_TaxCalculadora.Classes
{
    public class TaxCalculatorForIN : ICountryTaxCalculator
    {
        public decimal TotalIncome { get; set; }
        public decimal TotalDeduction { get; set; }
        public decimal CalculateTaxAmount()
        {
            decimal taxableIncome = TotalIncome - TotalDeduction;
            decimal total = taxableIncome * 20 / 100;
            return total;
        }

    }
}
