using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;


namespace Entites.Concrete
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
    }
}
