namespace Minecraft_Chest_Generator
{
    /// <summary>
    /// Contains information for a single chest-slot
    /// </summary>
    public struct ChestItem
    {
        /// <summary>
        /// The item in the slot
        /// </summary>
        public string Item;

        /// <summary>
        /// The number of items in the item stack
        /// </summary>
        public int Count;

        /// <summary>
        /// Additional item nbt
        /// </summary>
        public string NBTTag;

        public override string ToString()
        {
            return Item == "air" ? string.Empty : $"{{ Slot: {{0}}b, id: \"{Item}\", Count: {Count}b{(string.IsNullOrEmpty(NBTTag) ? string.Empty : $", tag:{{ {NBTTag} }}")} }}";
        }
    }
}
