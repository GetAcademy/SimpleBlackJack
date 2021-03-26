namespace SimpleBlackJack
{
    interface IBlackJackParticipant
    {
        bool IsBust();
        bool WantsOneMoreCard();
        void AddCard(Card card);
    }
}
