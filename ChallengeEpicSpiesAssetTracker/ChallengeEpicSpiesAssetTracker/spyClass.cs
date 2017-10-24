using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeEpicSpiesAssetTracker
{

    [Serializable]
    public class SpyClass
    {
        public string Name { get; set; }
        public int ElectionsRigged { get; set; }
        public int SubterfugePerformed { get; set; }
        
    }
}