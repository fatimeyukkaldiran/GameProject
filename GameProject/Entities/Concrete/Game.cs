using GameProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities.Concrete
{
   public class Game : IEntity
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

    }
}
