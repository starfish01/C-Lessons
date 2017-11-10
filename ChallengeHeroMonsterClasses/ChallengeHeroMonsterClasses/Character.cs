using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeHeroMonsterClasses
{
    public class Character
    {
        Random rnd = new Random();

        public String Name { get; set; }
        public Double Health {
            get
            {
                return Health;
            }
            set
            {
                Health = 100;
            }

        }
        public int DamageMaximum { get; set; }
        
        public int AttackBonus { get; set; }
       
    }
}