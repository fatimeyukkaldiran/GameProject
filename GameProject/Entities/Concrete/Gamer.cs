using GameProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities.Concrete
{
    public class Gamer : IEntity
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int CampaignId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public long IdentityNumber { get; set; }

    }
}
