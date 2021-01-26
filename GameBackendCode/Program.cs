using GameBackendCode.Abstract;
using GameBackendCode.Concrete;
using GameBackendCode.Entities;
using OyunKayitSistemi.Concrete;
using OyunKayitSistemi.Entities;
using System;

namespace GameBackendCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { FirstName = "Orhan", LastName = "Doğan", BirthYear = 1990, NationalityId = 12345678910 };

            BaseCustomerManager customerManager = new CustomerManager(new CheckPersonManager());
            customerManager.Add(customer1);

            Game game1 = new Game { Name="PES",Category="Futbol",UnitPrice=100,CategoryId=11,Id=10};

            GameSellManager gameSaleManager = new GameSellManager(game1);
            gameSaleManager.Sell(customer1);

            Campaign campaign = new Campaign { CampaignName = "KIŞ KAMPANYASI" };

            CampaignManager campaignManager = new CampaignManager(game1);
            campaignManager.Add(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);

            Console.ReadLine();
        }
    }
}
