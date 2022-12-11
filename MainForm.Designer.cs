namespace Minecraft_Chest_Generator
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.sldr_CurrentSlot = new CometUI.CometSlider();
			this.pic_Separator1 = new System.Windows.Forms.PictureBox();
			this.lbl_SlotItemLabel = new CometUI.CometLabel();
			this.lbl_SlotItemCount = new CometUI.CometLabel();
			this.lbl_CurrentSlotLabel = new CometUI.CometLabel();
			this.sldr_SlotItemCount = new CometUI.CometSlider();
			this.inpt_SlotItem = new CometUI.CometTextBox();
			this.lbl_SlotItemNBTTagLabel = new CometUI.CometLabel();
			this.inpt_SlotItemNBTTag = new CometUI.CometTextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.chck_GenerateSetblock = new CometUI.CometCheckBox();
			this.btn_GenerateCommand = new CometUI.CometFlatButton();
			((System.ComponentModel.ISupportInitialize)(this.pic_Separator1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// sldr_CurrentSlot
			// 
			this.sldr_CurrentSlot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sldr_CurrentSlot.Cursor = System.Windows.Forms.Cursors.Hand;
			this.sldr_CurrentSlot.DefaultValue = 1;
			this.sldr_CurrentSlot.DragColor = System.Drawing.Color.Gainsboro;
			this.sldr_CurrentSlot.KnobColor = System.Drawing.Color.Silver;
			this.sldr_CurrentSlot.Location = new System.Drawing.Point(58, 43);
			this.sldr_CurrentSlot.Maximum = 27;
			this.sldr_CurrentSlot.Minimum = 1;
			this.sldr_CurrentSlot.Name = "sldr_CurrentSlot";
			this.sldr_CurrentSlot.ShowSliderValue = true;
			this.sldr_CurrentSlot.Size = new System.Drawing.Size(554, 22);
			this.sldr_CurrentSlot.TabIndex = 0;
			this.sldr_CurrentSlot.TrackColor = System.Drawing.Color.White;
			this.sldr_CurrentSlot.TrackOutlineColor = System.Drawing.Color.LightGray;
			this.sldr_CurrentSlot.Value = 1;
			this.sldr_CurrentSlot.ValueTextColor = System.Drawing.Color.Black;
			this.sldr_CurrentSlot.ValueChanged += new System.EventHandler(this.CurrentSlot_ValueChanged);
			// 
			// pic_Separator1
			// 
			this.pic_Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_Separator1.BackColor = System.Drawing.Color.Silver;
			this.pic_Separator1.Location = new System.Drawing.Point(12, 76);
			this.pic_Separator1.Name = "pic_Separator1";
			this.pic_Separator1.Size = new System.Drawing.Size(600, 1);
			this.pic_Separator1.TabIndex = 1;
			this.pic_Separator1.TabStop = false;
			// 
			// lbl_SlotItemLabel
			// 
			this.lbl_SlotItemLabel.AutoSize = true;
			this.lbl_SlotItemLabel.BackColor = System.Drawing.Color.White;
			this.lbl_SlotItemLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lbl_SlotItemLabel.ForeColor = System.Drawing.Color.Black;
			this.lbl_SlotItemLabel.Location = new System.Drawing.Point(12, 90);
			this.lbl_SlotItemLabel.Name = "lbl_SlotItemLabel";
			this.lbl_SlotItemLabel.Size = new System.Drawing.Size(40, 19);
			this.lbl_SlotItemLabel.TabIndex = 2;
			this.lbl_SlotItemLabel.Text = "Item:";
			// 
			// lbl_SlotItemCount
			// 
			this.lbl_SlotItemCount.AutoSize = true;
			this.lbl_SlotItemCount.BackColor = System.Drawing.Color.White;
			this.lbl_SlotItemCount.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lbl_SlotItemCount.ForeColor = System.Drawing.Color.Black;
			this.lbl_SlotItemCount.Location = new System.Drawing.Point(12, 119);
			this.lbl_SlotItemCount.Name = "lbl_SlotItemCount";
			this.lbl_SlotItemCount.Size = new System.Drawing.Size(50, 19);
			this.lbl_SlotItemCount.TabIndex = 3;
			this.lbl_SlotItemCount.Text = "Count:";
			// 
			// lbl_CurrentSlotLabel
			// 
			this.lbl_CurrentSlotLabel.AutoSize = true;
			this.lbl_CurrentSlotLabel.BackColor = System.Drawing.Color.White;
			this.lbl_CurrentSlotLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lbl_CurrentSlotLabel.ForeColor = System.Drawing.Color.Black;
			this.lbl_CurrentSlotLabel.Location = new System.Drawing.Point(12, 43);
			this.lbl_CurrentSlotLabel.Name = "lbl_CurrentSlotLabel";
			this.lbl_CurrentSlotLabel.Size = new System.Drawing.Size(35, 19);
			this.lbl_CurrentSlotLabel.TabIndex = 4;
			this.lbl_CurrentSlotLabel.Text = "Slot:";
			// 
			// sldr_SlotItemCount
			// 
			this.sldr_SlotItemCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sldr_SlotItemCount.Cursor = System.Windows.Forms.Cursors.Hand;
			this.sldr_SlotItemCount.DefaultValue = 1;
			this.sldr_SlotItemCount.DragColor = System.Drawing.Color.Gainsboro;
			this.sldr_SlotItemCount.KnobColor = System.Drawing.Color.Silver;
			this.sldr_SlotItemCount.Location = new System.Drawing.Point(68, 118);
			this.sldr_SlotItemCount.Maximum = 64;
			this.sldr_SlotItemCount.Minimum = 1;
			this.sldr_SlotItemCount.Name = "sldr_SlotItemCount";
			this.sldr_SlotItemCount.ShowSliderValue = true;
			this.sldr_SlotItemCount.Size = new System.Drawing.Size(544, 22);
			this.sldr_SlotItemCount.TabIndex = 5;
			this.sldr_SlotItemCount.TrackColor = System.Drawing.Color.White;
			this.sldr_SlotItemCount.TrackOutlineColor = System.Drawing.Color.LightGray;
			this.sldr_SlotItemCount.Value = 1;
			this.sldr_SlotItemCount.ValueTextColor = System.Drawing.Color.Black;
			this.sldr_SlotItemCount.ValueChanged += new System.EventHandler(this.SlotItemCount_ValueChanged);
			// 
			// inpt_SlotItem
			// 
			this.inpt_SlotItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.inpt_SlotItem.BackColor = System.Drawing.Color.White;
			this.inpt_SlotItem.BorderColor = System.Drawing.Color.LightGray;
			this.inpt_SlotItem.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.inpt_SlotItem.FocusedBorderColor = System.Drawing.Color.DodgerBlue;
			this.inpt_SlotItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.inpt_SlotItem.ForeColor = System.Drawing.Color.Black;
			this.inpt_SlotItem.Location = new System.Drawing.Point(58, 88);
			this.inpt_SlotItem.Multiline = false;
			this.inpt_SlotItem.Name = "inpt_SlotItem";
			this.inpt_SlotItem.Readonly = false;
			this.inpt_SlotItem.Size = new System.Drawing.Size(554, 24);
			this.inpt_SlotItem.TabIndex = 6;
			this.inpt_SlotItem.UnderlineBorder = false;
			this.inpt_SlotItem.UseSystemPasswordChar = false;
			this.inpt_SlotItem.TextChanged += new System.EventHandler(this.SlotItem_TextChanged);
			// 
			// lbl_SlotItemNBTTagLabel
			// 
			this.lbl_SlotItemNBTTagLabel.AutoSize = true;
			this.lbl_SlotItemNBTTagLabel.BackColor = System.Drawing.Color.White;
			this.lbl_SlotItemNBTTagLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lbl_SlotItemNBTTagLabel.ForeColor = System.Drawing.Color.Black;
			this.lbl_SlotItemNBTTagLabel.Location = new System.Drawing.Point(12, 148);
			this.lbl_SlotItemNBTTagLabel.Name = "lbl_SlotItemNBTTagLabel";
			this.lbl_SlotItemNBTTagLabel.Size = new System.Drawing.Size(60, 19);
			this.lbl_SlotItemNBTTagLabel.TabIndex = 7;
			this.lbl_SlotItemNBTTagLabel.Text = "NBT Tag:";
			// 
			// inpt_SlotItemNBTTag
			// 
			this.inpt_SlotItemNBTTag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.inpt_SlotItemNBTTag.BackColor = System.Drawing.Color.White;
			this.inpt_SlotItemNBTTag.BorderColor = System.Drawing.Color.LightGray;
			this.inpt_SlotItemNBTTag.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.inpt_SlotItemNBTTag.FocusedBorderColor = System.Drawing.Color.DodgerBlue;
			this.inpt_SlotItemNBTTag.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.inpt_SlotItemNBTTag.ForeColor = System.Drawing.Color.Black;
			this.inpt_SlotItemNBTTag.Location = new System.Drawing.Point(78, 146);
			this.inpt_SlotItemNBTTag.Multiline = false;
			this.inpt_SlotItemNBTTag.Name = "inpt_SlotItemNBTTag";
			this.inpt_SlotItemNBTTag.Readonly = false;
			this.inpt_SlotItemNBTTag.Size = new System.Drawing.Size(534, 24);
			this.inpt_SlotItemNBTTag.TabIndex = 8;
			this.inpt_SlotItemNBTTag.UnderlineBorder = false;
			this.inpt_SlotItemNBTTag.UseSystemPasswordChar = false;
			this.inpt_SlotItemNBTTag.TextChanged += new System.EventHandler(this.SlotItemNBTTag_TextChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.Color.Silver;
			this.pictureBox1.Location = new System.Drawing.Point(12, 180);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(600, 1);
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// chck_GenerateSetblock
			// 
			this.chck_GenerateSetblock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chck_GenerateSetblock.AutoSize = true;
			this.chck_GenerateSetblock.BackColor = System.Drawing.Color.White;
			this.chck_GenerateSetblock.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
			this.chck_GenerateSetblock.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chck_GenerateSetblock.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.chck_GenerateSetblock.ForeColor = System.Drawing.Color.Black;
			this.chck_GenerateSetblock.Location = new System.Drawing.Point(397, 189);
			this.chck_GenerateSetblock.Name = "chck_GenerateSetblock";
			this.chck_GenerateSetblock.Size = new System.Drawing.Size(75, 19);
			this.chck_GenerateSetblock.TabIndex = 12;
			this.chck_GenerateSetblock.Text = "/setblock";
			this.chck_GenerateSetblock.UseVisualStyleBackColor = false;
			// 
			// btn_GenerateCommand
			// 
			this.btn_GenerateCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_GenerateCommand.BorderWidth = 1;
			this.btn_GenerateCommand.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_GenerateCommand.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btn_GenerateCommand.ForeColor = System.Drawing.Color.Black;
			this.btn_GenerateCommand.Location = new System.Drawing.Point(478, 185);
			this.btn_GenerateCommand.Name = "btn_GenerateCommand";
			this.btn_GenerateCommand.Size = new System.Drawing.Size(134, 26);
			this.btn_GenerateCommand.TabIndex = 13;
			this.btn_GenerateCommand.Text = "Generate Command";
			this.btn_GenerateCommand.Click += new System.EventHandler(this.GenerateCommand_Click);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.BorderColor = System.Drawing.Color.LightGray;
			this.CanResize = false;
			this.ClientSize = new System.Drawing.Size(624, 216);
			this.Controls.Add(this.btn_GenerateCommand);
			this.Controls.Add(this.chck_GenerateSetblock);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.inpt_SlotItemNBTTag);
			this.Controls.Add(this.lbl_SlotItemNBTTagLabel);
			this.Controls.Add(this.inpt_SlotItem);
			this.Controls.Add(this.sldr_SlotItemCount);
			this.Controls.Add(this.lbl_CurrentSlotLabel);
			this.Controls.Add(this.lbl_SlotItemCount);
			this.Controls.Add(this.lbl_SlotItemLabel);
			this.Controls.Add(this.pic_Separator1);
			this.Controls.Add(this.sldr_CurrentSlot);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ForeColor = System.Drawing.Color.Black;
			this.HeaderColor = System.Drawing.Color.WhiteSmoke;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MaximizeColor = System.Drawing.Color.Green;
			this.MinimumSize = new System.Drawing.Size(233, 116);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Minecraft Chest Generator";
			((System.ComponentModel.ISupportInitialize)(this.pic_Separator1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CometUI.CometSlider sldr_CurrentSlot;
		private System.Windows.Forms.PictureBox pic_Separator1;
		private CometUI.CometLabel lbl_SlotItemLabel;
		private CometUI.CometLabel lbl_SlotItemCount;
		private CometUI.CometLabel lbl_CurrentSlotLabel;
		private CometUI.CometSlider sldr_SlotItemCount;
		private CometUI.CometTextBox inpt_SlotItem;
		private CometUI.CometLabel lbl_SlotItemNBTTagLabel;
		private CometUI.CometTextBox inpt_SlotItemNBTTag;
		private System.Windows.Forms.PictureBox pictureBox1;
		private CometUI.CometCheckBox chck_GenerateSetblock;
		private CometUI.CometFlatButton btn_GenerateCommand;
	}
}

