﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entites.Concrete
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
