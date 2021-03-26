using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBlackJack.ParticipantsWithInheritance2
{
    class Player : Participant
    {
        public override bool WantsOneMoreCard()
        {
            ShowCards();
            Console.Write("Vil du ha et kort til (j/n)? ");
            var answer = Console.ReadLine();
            return answer?.ToLower() == "j";
        }
    }
}
