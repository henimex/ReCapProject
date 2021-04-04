using System.Collections.Generic;
using Core.Utilities.Result;
using Entites.Concrete;

namespace Business.Abstract
{
    public interface IUserCardService
    {
        IDataResult<List<UserCard>> GetAll();
        IDataResult<List<UserCard>> GetAllByUserId(int userId);
        IDataResult<UserCard> GetByCardId(int cardId);
        IResult Add(UserCard userCard);
        IResult Update(UserCard userCard);
        IResult Delete(UserCard userCard);
    }
}