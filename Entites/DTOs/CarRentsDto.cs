using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entites.DTOs
{
    public class CarRentsDto : IDto
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerMail { get; set; }
        public string Company { get; set; }
        public decimal DailyPrice { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
