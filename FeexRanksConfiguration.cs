﻿using Rocket.API;
using System.Collections.Generic;

namespace FeexRanks
{
    public class FeexRanksConfiguration : IRocketPluginConfiguration
    {
        public string DatabaseAddress = "127.0.0.1";
        public string DatabaseName = "unturned";
        public string DatabaseUsername = "admin";
        public string DatabasePassword = "root";
        public int DatabasePort = 3306;
        public string FeexRanksTableName = "ranks";
        public string UconomyTableName = "uconomy";
        public string ChatIconURL = "https://add-image-url.com";
        public string UconomyCurrencyName = "Credits";
        public string RankPointsName = "experience";
        public uint PointsLoseWhenDie = 0;
        public string PointsLoseRGBColorNotify = "255,0,0";
        public uint PointsEarnPerTime = 0;
        public string PointsEarnRGBColorNotify = "0,255,0";
        public bool NotifyPointsEarnPerTime = true;
        public uint TickratePointsEarnPerTime = 36000;
        public bool RankGlobalNotify = true;
        public bool RankLocalNotify = false;
        public string RankRGBColorNotify = "0,255,0";
        public bool RankLoginGlobalNotify = true;
        public bool RankLoginLocalNotify = false;
        public string RankLoginRGBColorNotify = "0,255,0";
        public bool RankLogoutGlobalNotify = true;
        public string RankLogoutRGBColorNotify = "0,255,0";

        public int KillPlayersPoints = 10;
        public bool KillPlayerNotify = true;
        public string KillPlayerRGBColorNotify = "255,0,0";
        public int KillZombiePoints = 1;
        public bool KillZombieNotify = false;
        public string KillZombieRGBColorNotify = "0,255,0";
        public int KillMegaZombiePoints = 50;
        public bool KillMegaZombieNotify = true;
        public string KillMegaRGBColorNotify = "0,255,0";
        public List<Rank> Ranks = new();

        public void LoadDefaults()
        {
            Ranks = new List<Rank>()
            {
                new()
                {
                    points = 0,
                    rankName = "Rank 0",
                    groupReward = null,
                    groupNotify = false,
                    uconomyReward = 0,
                    uconomyNotify = true,
                    groupRGBColorNotify = "0,255,0",
                    uconomyRGBColorNotify = "0,255,0",
                },
                new()
                {
                    points = 100,
                    rankName = "Rank 1",
                    itemsReward = new RankItem()
                    {
                        id = 10,
                        quantity = 5
                    },
                    groupReward = "VIP",
                    groupNotify = true,
                    uconomyReward = 0,
                    uconomyNotify = true,
                    groupRGBColorNotify = "255,0,0",
                    uconomyRGBColorNotify = "0,255,0",
                }
            };
        }
    }

    public class Rank
    {
        public string rankName;
        public uint points;
        public RankItem itemsReward;
        public string groupReward;
        public bool groupNotify;
        public uint uconomyReward;
        public bool uconomyNotify;
        public string groupRGBColorNotify;
        public string uconomyRGBColorNotify;
    }
    public class RankItem
    {
        public int id;
        public uint quantity;
    }
}
