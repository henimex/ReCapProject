using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using Core.Entities.Concrete;
using Core.Utilities.Result;
using DataAccess.Abstract;


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
            return new SuccessResult($"{user.GetType().Name} {Messages.Added}");
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult($"{user.GetType().Name} {Messages.Deleted}");
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
            return new ErrorDataResult<User>(Messages.RequiredParamIsNull);
        }

        public IResult Update(User user)
        {
            ValidationTool.Validate(new UserValidator(), user);
            _userDal.Update(user);
            return new SuccessResult($"{user.GetType().Name} {Messages.Updated}");
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        IDataResult<User> IUserService.GetUserByMail(string email)
        {
            return new SuccessDataResult<User>(_userDal.Get(x => x.Email == email));
        }
    }
}
