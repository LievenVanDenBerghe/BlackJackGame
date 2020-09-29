using BlackJackGame.Models;
using System;

namespace BlackJackGame.Modules.Domein
{
    public class BlackJackCard : Domain.Card
    {
        #region Properties
        public bool FaceUp { get; set; }
        public int Value { get; }
        #endregion

        #region Constructor
        public BlackJackCard(Suit suit, FaceValue faceValue)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Methods
        public void TurnCard()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
