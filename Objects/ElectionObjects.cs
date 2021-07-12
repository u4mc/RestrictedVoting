using System;
using System.Collections.Generic;
using System.Text;

namespace RestrictedVoting.Objects
{
    class Candidate
    {
        String name;
        int voteCount;

    }

    class Election
    {
        //Election data
        private Dictionary<Candidate, int> candidates;
        private VotingSystem votingSystem;

        private csvParser electionData;
        public int voterCount;

        public Election(String dataFilepath, String settingsFilepath)
        {
            electionData = new csvParser(dataFilepath);
        }

        public void runElection()
        {
            votingSystem.getResults();
        }
        public void printElectionResult()
        {

        }

    }
}
