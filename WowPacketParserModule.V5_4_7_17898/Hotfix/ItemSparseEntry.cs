using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V5_4_7_17898.Hotfix
{
    [HotfixStructure(DB2Hash.ItemSparse)]
    public class ItemSparseEntry
    {
        public uint ID { get; set; }
        public uint Quality { get; set; }
        [HotfixArray(3)]
        public uint[] Flags { get; set; }
        public float PriceRandomValue { get; set; }
        public float PriceVariance { get; set; }
        public uint BuyCount { get; set; }
        public uint BuyPrice { get; set; }
        public uint SellPrice { get; set; }
        public uint InventoryType { get; set; }
        public int AllowableClass { get; set; }
        public int AllowableRace { get; set; }
        public uint ItemLevel { get; set; }
        public int RequiredLevel { get; set; }
        public uint RequiredSkill { get; set; }
        public uint RequiredSkillRank { get; set; }
        public uint RequiredSpell { get; set; }
        public uint RequiredHonorRank { get; set; }
        public uint RequiredCityRank { get; set; }
        public uint RequiredReputationFaction { get; set; }
        public uint RequiredReputationRank { get; set; }
        public uint MaxCount { get; set; }
        public uint Stackable { get; set; }
        public uint ContainerSlots { get; set; }
        [HotfixArray(10)]
        public int[] StatType { get; set; }
        [HotfixArray(10)]
        public int[] StatValue { get; set; }
        [HotfixArray(10)]
        public int[] ScalingStatValue { get; set; }
        [HotfixArray(10)]
        public int[] SocketCostRate { get; set; }
        public uint ScalingStatDistribution { get; set; }
        public uint DamageType { get; set; }
        public uint Delay { get; set; }
        public float RangedModRange { get; set; }
        [HotfixArray(5)]
        public int[] TriggeredSpell { get; set; }
        [HotfixArray(5)]
        public int[] TriggeredSpellType { get; set; }
        [HotfixArray(5)]
        public int[] TriggeredSpellCharge { get; set; }
        [HotfixArray(5)]
        public int[] TriggeredSpellCooldown { get; set; }
        [HotfixArray(5)]
        public int[] TriggeredSpellCategories { get; set; }
        [HotfixArray(5)]
        public int[] TriggeredSpellCategoryCooldown { get; set; }
        public uint Bonding;
        public string Name { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public string Name4 { get; set; }
        public string Description { get; set; }
        public uint PageText { get; set; }
        public uint LanguageID { get; set; }
        public uint PageMaterial { get; set; }
        public uint StartQuest { get; set; }
        public uint LockID { get; set; }
        public int Material { get; set; }
        public uint Sheath { get; set; }
        public uint RandomProperty { get; set; }
        public uint RandomSuffix { get; set; }
        public uint ItemSet { get; set; }
        public uint Area { get; set; }
        public uint Map { get; set; }
        public uint BagFamily { get; set; }
        public uint TotemCategory { get; set; }
        [HotfixArray(3)]
        public uint[] Color { get; set; }
        [HotfixArray(3)]
        public uint[] Content { get; set; }
        public int SocketBonus { get; set; }
        public uint GemProperties { get; set; }
        public float ArmorDamageModifier { get; set; }
        public uint Duration { get; set; }
        public uint ItemLimitCategory { get; set; }
        public uint HolidayId { get; set; }
        public float StatScalingFactor { get; set; }
        public int CurrencySubstitutionId { get; set; }
        public int CurrencySubstitutionCount { get; set; }
    }
}
