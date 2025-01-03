using GGlease.Model.ViewModel;

namespace GGlease.Services.Interfaces
{
    public interface ICalculatorService
    {
        CalculatorCalculationModel CalculateByFormula(CalculatorCalculationRequestModel calculatorCalculationRequestModel);
    }
}