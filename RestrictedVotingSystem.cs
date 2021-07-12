using RestrictedVoting.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace RestrictedVoting
{


    class RestrictedVotingSystem
    {

        private String dataFilePath = " / data / test.csv";
        private const String settingsFilePath = "/data/settings.json";
        private int voterNum;

        private int loopNum;
        private int restrictNum;
        private Election election;
        //get csv file
        //iterate through csv file
        //for each voter, get winner and tally
        //output result

        public void start()
        {
            initSettings();
        }

        private void initSettings()
        {
            String jsonString = File.ReadAllText(settingsFilePath);
            JsonSerializer.Deserialize<Settings>(jsonString);

        }

        private void initElection()
        {

        }
    }
}
