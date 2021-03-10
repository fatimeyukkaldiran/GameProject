using GameProject.Adapter;
using GameProject.Business.Concrete;
using GameProject.DataAccess.Concrete.InMemory;
using GameProject.Entities.Concrete;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter(), new InMemoryGamerDal());

            gamerManager.Add(new Gamer
            {
                Id = 4,
                GameId = 3,
                CampaignId = 4,
                IdentityNumber = 58497509250,
                Name = "FATİME",
                LastName = "YÜKKALDIRAN",
                BirthYear = 1994,

            });

            foreach (var gamer in gamerManager.GetAllByGameId(2))
            {
                Console.WriteLine(gamer.Name + " " + gamer.LastName);
            }

            foreach (var gamer in gamerManager.GetAll())
            {
                Console.WriteLine(gamer.Name);
            }

            GameManager gameManager = new GameManager(new InMemoryGameDal());

            gameManager.Add(new Game
            {
                Id = 1,
                Name = "Candy Crash",
                Price = 115.54
            });
            GameCampaingManager campaingManager = new GameCampaingManager(new InMemoryCampaignDal());
            campaingManager.Add(new Campaign
            {
                Id = 4,
                Name = "2021 Summer Campaing",
                DiscountRate = 30
            });

            GameSalesManager salesManager = new GameSalesManager();
           // SellGame(salesManager);
          //  SellCampaigngame(salesManager);
        }

    

        private static void SellCampaigngame(GameSalesManager salesManager)
        {
            salesManager.CampaingSell(
                       new Game
                       {
                           Id = 2,
                           Name = "FIFA 2020",
                           Price = 2000
                       },

                new Gamer
                {
                    Id = 1,
                    IdentityNumber = 456789,
                    Name = "Serhat",
                    LastName = "Kaya",
                    BirthYear = 1993
                },

                new Campaign
                {
                    Id = 5,
                    Name = "Special for Winter",
                    DiscountRate = 40
                }

            );
        }

        private static void SellGame(GameSalesManager salesManager)
        {
            salesManager.SellGame(new Game
            {
                Id = 1,
                Name = "PUBG",
                Price = 500
            },
              new Gamer
              {
                  Id = 2,
                  IdentityNumber = 154789,
                  Name = "Ece",
                  LastName = "Deniz",
                  BirthYear = 2000
              }
              );
        }
           
    }
}
