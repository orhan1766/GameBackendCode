using GameBackendCode.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunKayitSistemi.Abstract
{
    public interface IGameSellManager
    {
        void Sell(Customer customer);
    }
}
