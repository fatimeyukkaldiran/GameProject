using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Abstract
{
   public interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
        List<Game> GetAll();
        List<Game> GetAllByCampaignId(int campaignId);

    }
}
