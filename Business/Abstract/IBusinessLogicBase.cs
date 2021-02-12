using System.Collections.Generic;
using Core.Utilities.Result;

namespace Business.Abstract
{
    public interface IBusinessLogicBase<T>
    {
        IDataResult<List<T>> GetAll();
        IResult Add(T businessEntity);
        IResult Update(T businessEntity);
        IResult Delete(T businessEntity);
    }
}
