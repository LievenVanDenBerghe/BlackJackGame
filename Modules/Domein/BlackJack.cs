using BlackJackGame.Models;
using System;

namespace BlackJackGame.Modules.Domein
{
    internal class BlackJack
    {
        #region Fields
        private Deck _deck;
        private bool FaceDown;
        private bool FaceUp;
        #endregion

        #region Properties
        public GameState GameState { get; set; }

        public Hand PlayerHand
        {
            get => default;
            set
            {
            }
        }

        public Hand DealerHand
        {
            get => default;
            set
            {
            }
        }
        #endregion

        #region Constructor
        public BlackJack() : this(new Deck()) { }

        public BlackJack(Deck deck)
        {
            _deck = deck;
            DealerHand = new Hand();
            PlayerHand = new Hand();
            Deal();
        }
        #endregion

        #region Methods
        private void AddCardToHand(Hand hand, bool faceUp)
        {
            throw new NotImplementedException();
        }

        private void AdjustGameState()
        {
            throw new NotImplementedException();
        }

        private void Deal()
        {
            throw new NotImplementedException();
        }

        public string GAmeSummary()
        {
            throw new NotImplementedException();
        }

        public void GivePlayerAnotherCard()
        {
            throw new NotImplementedException();
        }

        private void LetDealerFinalize()
        {
            throw new NotImplementedException();
        }

        public void PassToDealer()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
