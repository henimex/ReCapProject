using System;
using System.Collections.Generic;
using System.Text;
using Entites.Abstract;

namespace Entites.Concrete
{
    public class Car : IEntity
    {
        public int CarId { get; set; }
        public string Brand { get; set; }
        public int ColorId { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
