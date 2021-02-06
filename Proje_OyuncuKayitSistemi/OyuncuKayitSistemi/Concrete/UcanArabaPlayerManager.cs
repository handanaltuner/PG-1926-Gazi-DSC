using OyuncuKayitSistemi.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyuncuKayitSistemi.Concrete
{
    public class UcanArabaPlayerManager : BasePlayerManager
    {
        private IPlayerCheckService _playerCheckService;

        if (_playerCheckService.CheckIfRealPerson(Player))
	    {
            base.Save(player);
        }
   
        else
        {
        throw new Exception("Not a valid person");
        }


    }
}
