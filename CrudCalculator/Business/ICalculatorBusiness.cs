using CrudCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudCalculator.Business
{
    public interface ICalculatorBusiness
    {
        string CalculatorRules(CalculatorModels calculatorModels);
    }
}
