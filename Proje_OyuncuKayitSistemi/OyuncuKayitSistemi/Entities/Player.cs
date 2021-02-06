using System;
using System.Collections.Generic;
using System.Text;

namespace OyuncuKayitSistemi
{
   public class Player : IEntity
    {
        private object p;
        private int v1;
        private int v2;
        private int v3;

        public Player(object p, int v1, int v2, int v3)
        {
            this.p = p;
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public int İd { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }

    }
}
