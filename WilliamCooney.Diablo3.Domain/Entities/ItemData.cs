using System.Collections.Generic;

namespace WilliamCooney.Diablo3.Domain.Entities
{
    public class ItemData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string DisplayColor { get; set; }
        public string TooltipParams { get; set; }
        public int RequiredLevel { get; set; }
        public int ItemLevel { get; set; }
        public int StackSizeMax { get; set; }
        public int BonusAffixes { get; set; }
        public int BonusAffixesMax { get; set; }
        public bool AccountBound { get; set; }
        public string FlavorText { get; set; }
        public string TypeName { get; set; }
        public bool TwoHanded { get; set; }
        public string TypeId { get; set; }
        public string DamageRange { get; set; }
        public int ArmorMin { get; set; }
        public int ArmorMax { get; set; }
        public IEnumerable<string> Slots { get; set; }
        public IEnumerable<ItemAttribute> PrimaryAttributes { get; set; }
        public IEnumerable<ItemAttribute> SecondaryAttributes { get; set; }
        public IEnumerable<ItemAttribute> PassiveAttributes { get; set; }
        //attrsRaw TODO: Raw Attribute for ItemData
        //ignored random affixes
        public IEnumerable<ItemGem> Gems { get; set; }
        //ignored socket effects
        public string SetName { get; set; }
        public string SetSlug { get; set; }
        //TODO: Handle Sets?
        //ignored set items equipped
        //ignored crafted by
        public int SeasonRequiredToDrop { get; set; }
        public bool IsSeasonRequiredToDrop { get; set; }
        public string Description { get; set; }
        public string BlockChance { get; set; }
    }

    #region SubClass

    public class ItemAttribute
    {
        public string Text { get; set; }
        public string Color { get; set; }
        public string AffixType { get; set; }
    }

    public class ItemGem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string DisplayColor { get; set; }
        public string TooltipParam { get; set; }
        public bool IsGem { get; set; }
        public bool IsJewel { get; set; }
        public IEnumerable<ItemAttribute> PrimaryAttributes { get; set; }
        public IEnumerable<ItemAttribute> SecondaryAttributes { get; set; }
        public IEnumerable<ItemAttribute> PassiveAttributes { get; set; }
        //attrsRaw TODO: Raw Attribute for ItemData Gems
    }

    #endregion
}