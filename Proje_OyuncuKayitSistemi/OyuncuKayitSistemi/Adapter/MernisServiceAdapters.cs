using System;
using System.Collections.Generic;
using System.Text;

namespace OyuncuKayitSistemi.Adapters
{
    public class MernisServiceAdapter : IPlayerCheckService
    {
    }

   public class MernisServiceAdapter : IPlayerCheckService
    { 
        public bool CheckIfRealPerson(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDgrula(Convert.ToInt64(player.NationalityId, player.FirstName.ToUpper(), player.LastName.ToUpper(), player.DateOfBirth.Year ))
        }
    
    }
}
