using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entites.DTOs
{
    public class RentDto : IDto
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
