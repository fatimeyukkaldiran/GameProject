using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.DataAccess.Abstract
{
   public interface IGamerDal
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
        List<Gamer> GetAll();
        List<Gamer> GetAllByCampaignId(int campaignId);
        List<Gamer> GetAllByGameId(int gameId);

       
        
    }
}
