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
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<User> GetById(int userId)
        {
            if (userId != null)
            {
                return new SuccessDataResult<User>(_userDal.Get(u => u.Id == userId), Messages.ItemsListed);
            }
            //Its Always True But I just put this one for an example
            return new ErrorDataResult<User>(Messages.ReuqiredParamIsNull);
        }

        public IResult Update(User user)
        {
            if (DateTime.Now.Hour != 23)
            {
                if (user.FirstName.Length > 2 )
                {
                    _userDal.Update(user);
                    return new SuccessResult(Messages.Updated);
                }

                return new ErrorResult(Messages.NameInvalid);
            }

            return new ErrorResult(Messages.MaintenanceTime);
        }
    }
}
