using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeHeroMonsterClasses
{

    [Serializable]
    public class Character
    {
        Random rnd = new Random();

        public String Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public int AttackBonus { get; set; }
       
    }
}