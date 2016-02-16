using System;
using System.Collections.Generic;

namespace WilliamCooney.Diablo3.Domain.Entities
{
    public class HeroProfile
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public int Gender { get; set; }
        public int Level { get; set; }
        public int EliteKills { get; set; }
        public int ParagonLevel { get; set; }
        public bool Hardcore { get; set; }
        public bool Seasonal { get; set; }
        public int SeasonCreated { get; set; }
        public IEnumerable<HeroSkills> ActiveSkills { get; set; }
        public IEnumerable<HeroSkills> PassiveSkills { get; set; }
        public IEnumerable<string> Items { get; set; }
        //ignored followers
        public IEnumerable<HeroLegendaryPower> LegendaryPowers { get; set; }
        //ignored stats
        //ignored progression
        public bool Dead { get; set; }
        public DateTime LastUpdated { get; set; }
    }

    #region SubClass

    public class HeroSkills
    {
        public HeroSkillDetails Skill { get; set; }
        public HeroSkillsRune Rune { get; set; }
    }

    public class HeroSkillDetails
    {
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public int Level { get; set; }
        public string TooltipUrl { get; set; }
        public string Description { get; set; }
        public string Flavor { get; set; }
        public string SkillCalcId { get; set; }
    }

    public class HeroSkillsRune
    {
        public string Slug { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
        public string SimpleDescription { get; set; }
        public string TooltipParams { get; set; }
        public string SkillCalcId { get; set; }
        public int Order { get; set; }
    }

    public class HeroLegendaryPower
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string DisplayColor { get; set; }
        public string TooltipParams { get; set; }
    }

    #endregion
}