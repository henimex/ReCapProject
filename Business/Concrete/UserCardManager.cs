using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entites.Concrete;

namespace Business.Concrete
{
    public class UserCardManager : IUserCardService
    {
        IUserCardDal _userCardDal;

        public UserCardManager(IUserCardDal userCardDal)
        {
            _userCardDal = userCardDal;
        }

        public IDataResult<List<UserCard>> GetAll()
        {
            return new SuccessDataResult<List<UserCard>>(_userCardDal.GetAll());
        }

        public IDataResult<List<UserCard>> GetAllByUserId(int userId)
        {
            return new SuccessDataResult<List<UserCard>>(_userCardDal.GetAll(x => x.UserId == userId));
        }

        public IDataResult<UserCard> GetByCardId(int userId)
        {
            return new SuccessDataResult<UserCard>(_userCardDal.Get(x => x.Id == userId));
        }

        public IResult Add(UserCard userCard)
        {
            _userCardDal.Add(userCard);
            return new SuccessResult(Messages.Added);
        }

        public IResult Update(UserCard userCard)
        {
            _userCardDal.Update(userCard);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(UserCard userCard)
        {
            _userCardDal.Delete(userCard);
            return new SuccessResult(Messages.Deleted);
        }
    }
}
