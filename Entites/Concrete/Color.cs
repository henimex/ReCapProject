using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;


namespace Entites.Concrete
{
    public class Color : IEntity
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
    }
}
