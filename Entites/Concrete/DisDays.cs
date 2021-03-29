using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.Concrete
{
    public class DisDays : IEntity
    {
        public DateTime[] DisabledDays { get; set; }
    }
}
