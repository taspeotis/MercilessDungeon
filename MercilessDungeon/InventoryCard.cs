using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercilessDungeon
{
    class InventoryCard : Card
    {
        public int Reputation { get; private set; }
        public int? Duration { get; private set; }

        public InventoryCard(string title, string description, int reputation, int? duration)
            : base(title, description)
        {
            if (reputation <0) throw new ArgumentOutOfRangeException("reputation", "Reputation can not be below 0");
            Reputation = reputation;

            if (duration < 0) throw new ArgumentOutOfRangeException("duration", "Duration can not be below 0");
            Duration = duration;


        }

    }
}
