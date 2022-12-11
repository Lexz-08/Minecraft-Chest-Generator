using CometUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Minecraft_Chest_Generator
{
	public partial class MainForm : CometForm
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private Dictionary<int, ChestItem> dict_ChestSlots = new Dictionary<int, ChestItem>
		{
			{ 0, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 1, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 2, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 3, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 4, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 5, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 6, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 7, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 8, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 9, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 10, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 11, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 12, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 13, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 14, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 15, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 16, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 17, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 18, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 19, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 20, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 21, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 22, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 23, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 24, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 25, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } },
			{ 26, new ChestItem { Item = "air", Count = 1, NBTTag = string.Empty } }
		};

		private ChestItem GetCurrentSlot() => dict_ChestSlots[sldr_CurrentSlot.Value - 1];
		private void SetCurrentSlot(ChestItem SlotItem) => dict_ChestSlots[sldr_CurrentSlot.Value - 1] = SlotItem;

		private void CurrentSlot_ValueChanged(object sender, EventArgs e)
		{
			ChestItem chi_ChestSlot = GetCurrentSlot();

			inpt_SlotItem.Text = chi_ChestSlot.Item == "air" ? string.Empty : chi_ChestSlot.Item;
			sldr_SlotItemCount.Value = chi_ChestSlot.Count;
			inpt_SlotItemNBTTag.Text = chi_ChestSlot.NBTTag;
		}

		private void SlotItem_TextChanged(object sender, EventArgs e)
		{
			ChestItem chi_ChestSlot = GetCurrentSlot();

			chi_ChestSlot.Item = string.IsNullOrEmpty(inpt_SlotItem.Text) ? "air" : inpt_SlotItem.Text;
			SetCurrentSlot(chi_ChestSlot);
		}

		private void SlotItemCount_ValueChanged(object sender, EventArgs e)
		{
			ChestItem chi_ChestSlot = GetCurrentSlot();

			chi_ChestSlot.Count = sldr_SlotItemCount.Value;
			SetCurrentSlot(chi_ChestSlot);
		}

		private void SlotItemNBTTag_TextChanged(object sender, EventArgs e)
		{
			ChestItem chi_ChestSlot = GetCurrentSlot();

			chi_ChestSlot.NBTTag = inpt_SlotItemNBTTag.Text;
			SetCurrentSlot(chi_ChestSlot);
		}

		private void GenerateCommand_Click(object sender, EventArgs e)
		{
			string str_Command = string.Empty;

			if (chck_GenerateSetblock.Checked)
				str_Command = "/setblock ~ ~ ~ ";
			else str_Command = "/give @p ";

			string str_ChestNBT = string.Join(", ", dict_ChestSlots.ToArray()
				.Select(kvp_ChestSlot => kvp_ChestSlot.Value.ToString()
				.Replace("{0}", kvp_ChestSlot.Key.ToString()))
				.Where(str_ChestSlotNBT => !string.IsNullOrEmpty(str_ChestSlotNBT)));

			str_Command += $"chest{{ {(chck_GenerateSetblock.Checked ? str_ChestNBT : $"BlockEntityTag:{{ {str_ChestNBT} }}")} }}";

			MessageBox.Show("Command copied to clipboard", "Command Generated and Copied",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
			Clipboard.SetText(str_Command);
		}
	}
}
