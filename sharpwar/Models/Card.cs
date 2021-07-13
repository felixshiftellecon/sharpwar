using System;
namespace sharpwar.Models
{
    public class Card
    {
        public Card(Suit suit, FaceValue facevalue)
        {
            Suit = suit;
            FaceValue = facevalue;
        }

        public Suit Suit { get; set; }
        public FaceValue FaceValue { get; set; }
    }
}
