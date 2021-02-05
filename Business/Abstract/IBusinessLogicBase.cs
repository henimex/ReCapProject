using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBusinessLogicBase<T>
    {
        List<T> GetAll();
        void Add(T businessEntity);
        void Update(T businessEntity);
        void Delete(T businessEntity);
    }
}
