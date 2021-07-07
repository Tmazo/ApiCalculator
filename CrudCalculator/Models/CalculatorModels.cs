using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudCalculator.Models
{
    public class CalculatorModels : ICalculatorModels
    {
        public double num1 { get; set; }
        public double num2 { get; set; }
        public string operation { get; set; }
        
    }
}
