using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercilessDungeon
{
   class Card
    {
       // Card properties
       public string Title { get; private set; }
       public string Description { get; private set; }

       // Play method
       public void Play()
       {

           //Things that happen when a card wants to be played
       }

       // Constructor
       public Card(string title, string description)
       {
           if (String.IsNullOrWhiteSpace(title)) throw new ArgumentOutOfRangeException("title", "Card title can not be empty");
           Title = title;
           if (String.IsNullOrWhiteSpace(description)) throw new ArgumentOutOfRangeException("description", "Card description can not be empty");
           Description = description;

       }

    }
}
