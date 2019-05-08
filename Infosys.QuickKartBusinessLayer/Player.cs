using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    class Player
    {
        public int height;
        public string playerId;
        public string playerName;
        public string role;
        public int score;
        public float weight;
        public Player(string playerId, string playerName, int height, float weight, string role = "Defender")
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.height = height;
            this.weight = weight;
            this.role = role;
        }
        public void CalculateScore(out string reward, int noOfHits, int noOfMisses, int noOfRetries = 3,bool complete = true)
        {
            score = (noOfHits * 100) - (noOfMisses * 25) - (noOfRetries * 50);
            if (complete)
                reward = DetermineReward();
            else
                reward = "NA";
        }
        public string DetermineReward()
        {
            if (score >= 50 && score < 1000)
                return "Coupons";
            else if (score >= 1000 && score < 2500)
                return "Extra_Chance";
            else if (score >= 2500)
                return "Cash_Coupons";
            else
                return "No_Reward";
        }
    }
}
