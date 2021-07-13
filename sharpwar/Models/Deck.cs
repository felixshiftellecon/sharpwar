using System;
using System.Collections.Generic;

namespace sharpwar.Models
{
    public class Deck
    {
        public List<Card> Cards;

        public Deck()
        {
            Cards = new List<Card>();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (FaceValue facevalue in Enum.GetValues(typeof(FaceValue)))
                {
                    Cards.Add(new Card(suit, facevalue));
                }
            }
            Shuffler.Shuffle(Cards);
        }
    }

}
