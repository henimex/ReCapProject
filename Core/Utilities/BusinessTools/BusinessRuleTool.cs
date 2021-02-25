using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Result;

namespace Core.Utilities.BusinessTools
{
    public class BusinessRuleTool
    {
        public static IResult Run(params IResult[] logics)
        {
            foreach (var result in logics)
            {
                if (!result.Success) return result;
            }

            return null;
        }
    }
}
