using System;
using System.Collections.Generic;
using System.Text;

namespace RestrictedVoting
{
    class csvParser
    {
        int currentRow;
        public csvParser(String filepath)
        {
            //use to access csv file and store in memory

        }
        public int[] getNextVoter()
        {
            int[] votes=new int[0];
            //return set of votes
            //on reaching end of csv return -1, terminating loop
            return votes;
        }
    }
}
