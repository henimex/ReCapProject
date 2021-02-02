using System;
using System.Collections.Generic;
using System.Text;
using Entites.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByColorId(int colorId);
        List<Car> GetAllByModelYear(string modelYear);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
