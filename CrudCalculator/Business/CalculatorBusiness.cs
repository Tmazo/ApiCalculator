using CrudCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudCalculator.Business
{
    public class CalculatorBusiness : ICalculatorBusiness
    {   
        public string CalculatorRules(CalculatorModels calculatorModels)
        {

            switch (calculatorModels.operation)
            {
                case "a":
                    return ($"{calculatorModels.num1} + {calculatorModels.num2} = {calculatorModels.num1 + calculatorModels.num2}");
                    break;

                case "s":
                    return ($"{calculatorModels.num1} - {calculatorModels.num2} = {calculatorModels.num1 - calculatorModels.num2}");
                    break;

                case "x":
                    return ($"{calculatorModels.num1} * {calculatorModels.num2} = {calculatorModels.num1 * calculatorModels.num2}");
                    break;

                case "di":
                    return ($"{calculatorModels.num1} / {calculatorModels.num2} = {calculatorModels.num1 / calculatorModels.num2}");
                    break;
                default:
                    return "Operation not exist.";
                    break;

            }

        }

    }
}

