using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entites.Concrete
{
    public class Payment : IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public decimal DailyPrice { get; set; }
        public int DaysForRent { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime? PaymentDay { get; set; }
    }
}
