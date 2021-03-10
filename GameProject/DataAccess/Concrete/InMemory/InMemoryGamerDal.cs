using GameProject.DataAccess.Abstract;
using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameProject.DataAccess.Concrete.InMemory
{
    class InMemoryGamerDal : IGamerDal
    {
        List<Gamer> _gamers;

        public InMemoryGamerDal()
        {
            _gamers = new List<Gamer>
            {
                new Gamer{Id = 1, GameId = 2, CampaignId = 2, IdentityNumber = 1254789654,
                Name = "Deniz", LastName = "Hale", BirthYear = 1985},
                new Gamer{Id = 2, GameId = 3, CampaignId = 1, IdentityNumber = 125478847,
                Name = "Şeniz", LastName = "Narcı", BirthYear = 1995},
                new Gamer{Id = 3, GameId = 2, CampaignId = 3, IdentityNumber = 89549654,
                Name = "Miran", LastName = "Karaman", BirthYear = 1994 }

            };
        }

        public void Add(Gamer gamer)
        {
            _gamers.Add(gamer);
        }

        public void Delete(Gamer gamer)
        {
            Gamer deleteToGamer = null;

            //foreach (var g in _gamers)
            //{
            //    if (g.Id == gamer.Id)
            //    {
            //        deleteToGamer = g;
            //    }
            //}
            deleteToGamer = _gamers.SingleOrDefault(g => g.Id == gamer.Id);
            _gamers.Remove(deleteToGamer);
        }

        public List<Gamer> GetAll()
        {
            return _gamers;
        }

        public List<Gamer> GetAllByCampaignId(int campaignId)
        {
            return _gamers.Where(g => g.CampaignId == campaignId).ToList();
        }

        public List<Gamer> GetAllByGameId(int gameId)
        {
          return _gamers.Where(g => g.GameId == gameId).ToList();
        }

        public void Update(Gamer gamer)
        {
           Gamer updateToGamer = _gamers.SingleOrDefault(g => g.Id == gamer.Id);

            updateToGamer.Id = gamer.Id;
            updateToGamer.GameId = gamer.GameId;
            updateToGamer.CampaignId = gamer.CampaignId;
            updateToGamer.IdentityNumber = gamer.IdentityNumber;
            updateToGamer.Name = gamer.Name;
            updateToGamer.LastName = gamer.LastName;
            updateToGamer.BirthYear = gamer.BirthYear;
             
            
        }
    }
}