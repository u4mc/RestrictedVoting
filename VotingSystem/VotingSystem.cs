using System;
using System.Collections.Generic;
using System.Text;

namespace RestrictedVoting
{
    abstract class VotingSystem
    {
        public bool[] getVote(int[] votes, bool[] restrictions)
        {//get highest ranking vote
            bool[] castedVotes = new bool[votes.Length];
            int highestVote = -1;
            for (int i = 0; i < votes.Length; i++)
            {
                if (restrictions[i] == true)
                {

                }
                else if (highestVote == -1)
                {
                    highestVote = votes[i];
                    castedVotes[i] = true;

                }
                else if (highestVote == votes[i])
                {
                    castedVotes[i] = true;
                }
                else if (highestVote < votes[i])
                {
                    castedVotes = new bool[votes.Length];
                    castedVotes[i] = true;
                }
            }
            return castedVotes;
        }

        public abstract int[] getResults();
    }
}
