using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudCalculator.Models
{
    interface ICalculatorModels
    {
         double num1 { get; set; }
         double num2 { get; set; }
         string operation { get; set; }
    }
}
