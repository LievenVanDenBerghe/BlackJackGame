using System;
using System.Collections.Generic;

namespace BlackJackGame.Modules.Domein
{
    public class Deck
    {
        #region Fields
        private Random _random = new Random();
        protected IList<BlackJackCard> _cards;
        #endregion

        #region Constructor
        public Deck()
        {
            _cards = new List<BlackJackCard>();
            //throw new NotImplementedException();
        }
        #endregion

        #region Methods
        public BlackJackCard Draw()
        {

            throw new NotImplementedException();
        }

        public void Shuffle()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
