using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserCardDal : EfEntityRepositoryBase<HenRentACarContext, UserCard>, IUserCardDal
    {
    }
}