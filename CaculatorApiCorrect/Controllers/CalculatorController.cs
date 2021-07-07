using CrudCalculator.Business;
using CrudCalculator.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace CaculatorApiCorrect.Controllers
{ 
    [Route("[controller]")]
    [ApiController]
    public class CalculatorController :  ControllerBase
    {
        private ICalculatorBusiness _calculatorBusiness;
        public CalculatorController(ICalculatorBusiness calculatorBusiness)
        {
            _calculatorBusiness = calculatorBusiness;
        }

        [HttpPost]
        [Route("calcular")]
        public string ResponseResult([FromBody]CalculatorModels calculatorModels)
        {
            
            return _calculatorBusiness.CalculatorRules(calculatorModels);
            
        }
    }
}
