using System;
using SimpleBlackJack.ParticipantsWithInheritance2;

namespace SimpleBlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck();

            var participants = new Participant[]
            {
                new Player(),
                new Dealer(),
            };

            foreach (var participant in participants)
            {
                while (!participant.IsBust() && participant.WantsOneMoreCard())
                {
                    var card = deck.Draw();
                    participant.AddCard(card);
                }
            }


            //IBlackJackParticipant player = new Player();
            //while (!player.IsBust() && player.WantsOneMoreCard())
            //{
            //    var card = deck.Draw();
            //    player.AddCard(card);
            //}

            //IBlackJackParticipant dealer = new Dealer();
            //while (!dealer.IsBust() && dealer.WantsOneMoreCard())
            //{
            //    var card = deck.Draw();
            //    dealer.AddCard(card);
            //}
        }

        private static void DataTypeTest()
        {
            ParticipantsWithInterface.Player p1 = new ParticipantsWithInterface.Player();
            p1.IsBust();
            IBlackJackParticipant p2 = p1;
            //p2.IsBust();
            Player p3 = (Player)p2;
            p3.IsBust();
        }
    }
}
