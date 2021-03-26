namespace SimpleBlackJack.ParticipantsWithInheritance
{
    class Dealer : Player
    {
        public override bool WantsOneMoreCard()
        {
            ShowCards();
            return ValueSum < 16;
            //return base.WantsOneMoreCard();
        }
    }
}
