using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entites.Concrete
{
    public class UserCard : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Alias { get; set; }
        public string CardNumber { get; set; }
        public string ExpMonth { get; set; }
        public string ExpYear { get; set; }
        public string Cvc { get; set; }
    }
}
