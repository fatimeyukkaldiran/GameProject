using GameProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities.Concrete
{
   public class Campaign : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DiscountRate { get; set; }
    }
}
