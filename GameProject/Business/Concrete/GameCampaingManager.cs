using GameProject.Business.Abstract;
using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    public class GameCampaingManager : IGameCampaingService
    {
        List<Campaign> campaigns;

        public GameCampaingManager()
        {
            campaigns = new List<Campaign>();
        }

        public void Add(Campaign campaign)
        {
            campaigns.Add(campaign);
            Console.WriteLine("Campaing is added");
        }

        public void Delete(Campaign campaign)
        {
            campaigns.Remove(campaign);
            Console.WriteLine("Campaing is deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaing is updated");
        }
    }
}
