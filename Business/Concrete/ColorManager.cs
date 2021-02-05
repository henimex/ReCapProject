using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entites.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        private IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int colorId)
        {
            return _colorDal.Get(p => p.Id == colorId);
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
            Console.WriteLine("Color {0} Added", color.ColorName);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
            Console.WriteLine("Color {0} Updated", color.ColorName);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
            Console.WriteLine("Color {0} Deleted", color.ColorName);
        }
    }
}
