using System;
using System.Collections.Generic;
using System.Text;

namespace OyuncuKayitSistemi.Abstract
{
    public abstract class BasePlayerManager : IPlayerService
    {
        public virtual void Save(Player player)
        {
            Console.WriteLine("Saved to db :" + player.FirstName);
        }
    }
}
