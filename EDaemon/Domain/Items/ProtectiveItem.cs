using EDaemon.Domain.Utils;
using System.Collections.Generic;

namespace EDaemon.Domain.Items
{
    public class ProtectiveItem : Equipment
    {
        public int DexPenalty { get; set; }
        public int AgiPenalty { get; set; }
        public List<Protection> ProtectionIndexList { get; set; } = new List<Protection>();
        public List<int> ArmorSlot { get; set; } = new List<int>();
    }
}
