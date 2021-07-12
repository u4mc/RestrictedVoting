using System;
using System.Collections.Generic;
using System.Text;

namespace RestrictedVoting.VotingSystem
{
    abstract class VotingSystem
    {
        public abstract int getVote(int[]votes);
        //accepts set of votes and returns the winner
    }
}
