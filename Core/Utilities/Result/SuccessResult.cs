using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message)
        {
            //İşlemimin sonucu olumlu ise bu class cagrılır. Class geldiginde benden tercihen mesaj ister. eger mesaj verilir ise bu alan calısarak base olan Result a bool degerini true ve 
            //girilmiş ise mesajı dondurur.
        }

        public SuccessResult() : base(true)
        {
            //eger mesaj girilmemis ise burası calısır ve base e yani Resul clasına sadece true doner.
        }
    }
}
