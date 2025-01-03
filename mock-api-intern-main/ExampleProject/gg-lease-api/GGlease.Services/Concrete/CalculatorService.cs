using GGlease.Data;
using GGlease.Model.ViewModel;
using GGlease.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GGlease.Services.Concrete
{
    public class CalculatorService : ICalculatorService
    {
        public CalculatorService()
        {
        }

        public CalculatorCalculationModel CalculateByFormula(CalculatorCalculationRequestModel calculatorCalculationRequestModel)
        {
            var tutar = Convert.ToDouble(calculatorCalculationRequestModel.EquipmentValue) - Convert.ToDouble(calculatorCalculationRequestModel.PaymentValue);
            var rateValueByMonth = (Convert.ToDouble(calculatorCalculationRequestModel.RateValue)/100) / 12;

            var quotient = tutar * rateValueByMonth;
            var powBase = 1 + rateValueByMonth;

            var powAppliedPartOfDividend = Math.Pow(Convert.ToDouble(powBase),calculatorCalculationRequestModel.MaturityOptionValue);
            
            var dividend = 1 - (1 / powAppliedPartOfDividend);
            var monthlyPaymentValue = quotient / dividend;
            var totalPaymentValue = monthlyPaymentValue * calculatorCalculationRequestModel.MaturityOptionValue + Convert.ToDouble(calculatorCalculationRequestModel.PaymentValue);

            return new CalculatorCalculationModel()
            {
                MonthlyPaymentValue = Math.Round(Convert.ToDecimal(monthlyPaymentValue),2),
                TotalPaymentValue = Math.Round(Convert.ToDecimal(totalPaymentValue),2)
            };
        }
    }
}