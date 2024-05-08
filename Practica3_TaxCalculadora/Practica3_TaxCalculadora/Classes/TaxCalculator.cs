using Practica3_TaxCalculadora.Interfaces;


namespace Practica3_TaxCalculadora.Classes
{
    public class TaxCalculator
    {
        public decimal Calculate(ICountryTaxCalculator country)
        {
            decimal taxAmount = 0;
            taxAmount = country.CalculateTaxAmount();
            return taxAmount;
        }






    }
}
