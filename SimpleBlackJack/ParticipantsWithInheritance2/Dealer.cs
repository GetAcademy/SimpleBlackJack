using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBlackJack.ParticipantsWithInheritance2
{
    class Dealer : Participant
    {
        public override bool WantsOneMoreCard()
        {
            ShowCards();
            return ValueSum < 16;
        }
    }
}
