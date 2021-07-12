using System;
using System.Collections.Generic;
using System.Text;

namespace RestrictedVoting.Objects
{
    class Voter
    {
        public int Id { get; set; }
        public Candidate[] votes { get; set; }
    }

    class Candidate
    {
        String name;
        int voteCount;

    }

    class Election
    {
        //Election data
        public Dictionary<Candidate, int> candidates;
        public int voterCount;


        public void addCandidate(Candidate candidate)
        {

        }
        
        public void printElectionResult()
        {

        }

    }
}
