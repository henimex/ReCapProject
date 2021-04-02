using System.Collections.Generic;
using Core.Entities.Concrete;
using Core.Utilities.Result;


namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int userId);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
        IDataResult<User> GetUserByMail(string email);
    }
}