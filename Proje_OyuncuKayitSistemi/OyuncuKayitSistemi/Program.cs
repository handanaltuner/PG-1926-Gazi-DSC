using System;

namespace OyuncuKayitSistemi
{
    class Program
    {
        public static object PlayerManager { get; private set; }

        static void Main(string[] args)
        {
            BasePlayerManager playerManager = new UcanPlayerManager();
            playerManager.Save(new Player(DateOfBirth = new DateTime(1985, 3, 2), FirstName = "Handan", LastName = "Altuner" NationalityId = ""));
            Console.Readline();  
    }
    }
}
