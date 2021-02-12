using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public class ErrorResult :Result
    {
        public ErrorResult(string message) : base(false, message)
        {
            //success metodu ile aynı sekilde sadece donus degerleri false olarak calısır
        }

        public ErrorResult() : base(false)
        {
        }
    }
}
