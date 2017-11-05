using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaCasinoChallenge
{
    [Serializable]

    class CasionData
    {
        public int slotImage1int { get; set; }
        public int slotImage2int { get; set; }
        public int slotImage3int { get; set; }
            
        public Double betAmount { get; set; }
        public Double balanceAmount { get; set; }
        public Double winningAmount { get; set; }

    }
}