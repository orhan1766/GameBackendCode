using GameBackendCode.Abstract;
using GameBackendCode.Entities;
using OyunKayitSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendCode.Concrete
{
    public class CampaignManager : ICampaignService
    {
        private Game _game;
        public CampaignManager(Game game)
        {
            _game = game;
        }
        public void Add(Campaign campaign)
        {
            Console.WriteLine("{0} adlı oyuna {1} uygulandı.",_game.Name,campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("{0} adlı oyundan {1} kaldırıldı.", _game.Name, campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("{0} adlı oyunda {1} güncellendi.", _game.Name, campaign.CampaignName);
        }
    }
}
