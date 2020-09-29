using System;
using System.Collections.Generic;

namespace BlackJackGame.Modules.Domein
{
    public class Hand
    {
        #region Fields
        private IList<BlackJackCard> _cards;
        #endregion

        #region Properties
        public IEnumerable<BlackJackCard> Card { get; }
        public int NrOfCards { get; }
        public int Value { get; }
        #endregion

        #region Constructor
        public Hand()
        {
            _cards = new List<BlackJackCard>();

        }
        #endregion

        #region Methods
        public void AddCard(BlackJackCard blackJackCard)
        {
            throw new NotImplementedException();
        }

        private int CalvulateValue()
        {
            throw new NotImplementedException();
        }

        public void TurnAllCardsFaceUp()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
