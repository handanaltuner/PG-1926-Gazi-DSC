using OyuncuKayitSistemi.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyuncuKayitSistemi.Abstract
{
    public class PlayerCheckManager : IPlayerCheckService
    {
        public interface IPlayerCheckService
        {
           public bool CheckIfRealPerson(Player player)
            {
                return true;
            }
        }
}
