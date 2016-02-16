using System;
using System.Collections.Generic;

namespace WilliamCooney.Diablo3.Domain.Entities
{
    public class CareerProfile
    {
        public string BattleTag { get; set; }
        public int ParagonLevel { get; set; }
        public int ParagonHardcore { get; set; }
        public int ParagonSeasonLevel { get; set; }
        public int ParagonSeasonHardcore { get; set; }
        public string GuildName { get; set; }
        public IEnumerable<string> Heroes { get; set; }
        public string LastHeroPlayed { get; set; }
        public DateTime LastUpdated { get; set; }
        public CareerKills Kills { get; set; }
        public int HighestHardcoreLevel { get; set; }
        public CareerTimePlayed TimePlayed { get; set; }
        //ignored progression
        //ignored fallen heroes
        //ignored all artisans
        //ignored seasonalProfiles
    }

    #region SubClasses

    public class CareerKills
    {
        public int Monsters { get; set; }
        public int Elites { get; set; }
        public int HardcoreMonsters { get; set; }
    }

    public class CareerTimePlayed
    {
        public decimal Barbarian { get; set; }
        public decimal Crusader { get; set; }
        public decimal DemonHunter { get; set; }
        public decimal Monk { get; set; }
        public decimal WitchDoctor { get; set; }
        public decimal Wizard { get; set; }
    }

    #endregion
}