﻿using System.ComponentModel;
using System.Windows.Forms;

namespace Intersect_Editor.Forms
{
    partial class FrmItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.cmbPic = new System.Windows.Forms.ComboBox();
            this.scrlAnim = new System.Windows.Forms.HScrollBar();
            this.lblAnim = new System.Windows.Forms.Label();
            this.scrlPrice = new System.Windows.Forms.HScrollBar();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPic = new System.Windows.Forms.Label();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblLevelReq = new System.Windows.Forms.Label();
            this.scrlLevelReq = new System.Windows.Forms.HScrollBar();
            this.lblSpeedReq = new System.Windows.Forms.Label();
            this.lblMagicResistReq = new System.Windows.Forms.Label();
            this.lblDefenseReq = new System.Windows.Forms.Label();
            this.lblAbilityPowerReq = new System.Windows.Forms.Label();
            this.lblAttackReq = new System.Windows.Forms.Label();
            this.scrlDefenseReq = new System.Windows.Forms.HScrollBar();
            this.scrlSpeedReq = new System.Windows.Forms.HScrollBar();
            this.scrlMagicResistReq = new System.Windows.Forms.HScrollBar();
            this.scrlAbilityPowerReq = new System.Windows.Forms.HScrollBar();
            this.scrlAttackReq = new System.Windows.Forms.HScrollBar();
            this.gbEquipment = new System.Windows.Forms.GroupBox();
            this.lblEffectPercent = new System.Windows.Forms.Label();
            this.scrlEffectAmount = new System.Windows.Forms.HScrollBar();
            this.cmbEquipmentBonus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbToolType = new System.Windows.Forms.ComboBox();
            this.lblToolType = new System.Windows.Forms.Label();
            this.chk2Hand = new System.Windows.Forms.CheckBox();
            this.cmbEquipmentSlot = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPaperdoll = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRange = new System.Windows.Forms.Label();
            this.scrlRange = new System.Windows.Forms.HScrollBar();
            this.picPaperdoll = new System.Windows.Forms.PictureBox();
            this.lblDamage = new System.Windows.Forms.Label();
            this.scrlDamage = new System.Windows.Forms.HScrollBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblMagicResist = new System.Windows.Forms.Label();
            this.lblDefense = new System.Windows.Forms.Label();
            this.lblAbilityPower = new System.Windows.Forms.Label();
            this.lblAttack = new System.Windows.Forms.Label();
            this.scrlDefense = new System.Windows.Forms.HScrollBar();
            this.scrlSpeed = new System.Windows.Forms.HScrollBar();
            this.scrlMagicResist = new System.Windows.Forms.HScrollBar();
            this.scrlAbilityPower = new System.Windows.Forms.HScrollBar();
            this.scrlAttack = new System.Windows.Forms.HScrollBar();
            this.gbConsumable = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbConsume = new System.Windows.Forms.ComboBox();
            this.scrlInterval = new System.Windows.Forms.HScrollBar();
            this.lblInterval = new System.Windows.Forms.Label();
            this.gbSpell = new System.Windows.Forms.GroupBox();
            this.scrlSpell = new System.Windows.Forms.HScrollBar();
            this.lblSpell = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gbEquipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPaperdoll)).BeginInit();
            this.gbConsumable.SuspendLayout();
            this.gbSpell.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lstItems);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 431);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(6, 398);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(190, 27);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.Location = new System.Drawing.Point(7, 366);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(190, 27);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 333);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(190, 27);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(6, 19);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(191, 303);
            this.lstItems.TabIndex = 1;
            this.lstItems.Click += new System.EventHandler(this.lstItems_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDesc);
            this.groupBox2.Controls.Add(this.cmbPic);
            this.groupBox2.Controls.Add(this.scrlAnim);
            this.groupBox2.Controls.Add(this.lblAnim);
            this.groupBox2.Controls.Add(this.scrlPrice);
            this.groupBox2.Controls.Add(this.lblPrice);
            this.groupBox2.Controls.Add(this.lblPic);
            this.groupBox2.Controls.Add(this.picItem);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbType);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Location = new System.Drawing.Point(225, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 220);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Desc:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(60, 72);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(135, 20);
            this.txtDesc.TabIndex = 12;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // cmbPic
            // 
            this.cmbPic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPic.FormattingEnabled = true;
            this.cmbPic.Items.AddRange(new object[] {
            "None"});
            this.cmbPic.Location = new System.Drawing.Point(60, 119);
            this.cmbPic.Name = "cmbPic";
            this.cmbPic.Size = new System.Drawing.Size(135, 21);
            this.cmbPic.TabIndex = 11;
            this.cmbPic.SelectedIndexChanged += new System.EventHandler(this.cmbPic_SelectedIndexChanged);
            // 
            // scrlAnim
            // 
            this.scrlAnim.Location = new System.Drawing.Point(19, 190);
            this.scrlAnim.Maximum = 1000;
            this.scrlAnim.Name = "scrlAnim";
            this.scrlAnim.Size = new System.Drawing.Size(176, 18);
            this.scrlAnim.TabIndex = 10;
            this.scrlAnim.ValueChanged += new System.EventHandler(this.scrlAnim_Scroll);
            // 
            // lblAnim
            // 
            this.lblAnim.AutoSize = true;
            this.lblAnim.Location = new System.Drawing.Point(16, 177);
            this.lblAnim.Name = "lblAnim";
            this.lblAnim.Size = new System.Drawing.Size(94, 13);
            this.lblAnim.TabIndex = 9;
            this.lblAnim.Text = "Animation: 0 None";
            // 
            // scrlPrice
            // 
            this.scrlPrice.Location = new System.Drawing.Point(19, 159);
            this.scrlPrice.Maximum = 1000;
            this.scrlPrice.Name = "scrlPrice";
            this.scrlPrice.Size = new System.Drawing.Size(176, 18);
            this.scrlPrice.TabIndex = 8;
            this.scrlPrice.ValueChanged += new System.EventHandler(this.scrlPrice_Scroll);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(16, 139);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(43, 13);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price: 0";
            // 
            // lblPic
            // 
            this.lblPic.AutoSize = true;
            this.lblPic.Location = new System.Drawing.Point(57, 103);
            this.lblPic.Name = "lblPic";
            this.lblPic.Size = new System.Drawing.Size(25, 13);
            this.lblPic.TabIndex = 6;
            this.lblPic.Text = "Pic:";
            // 
            // picItem
            // 
            this.picItem.Location = new System.Drawing.Point(15, 101);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(32, 32);
            this.picItem.TabIndex = 4;
            this.picItem.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type:";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "None",
            "Equipment",
            "Consumable",
            "Currency",
            "Spell"});
            this.cmbType.Location = new System.Drawing.Point(60, 45);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(135, 21);
            this.cmbType.TabIndex = 2;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(60, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cmbClass);
            this.groupBox3.Controls.Add(this.lblLevelReq);
            this.groupBox3.Controls.Add(this.scrlLevelReq);
            this.groupBox3.Controls.Add(this.lblSpeedReq);
            this.groupBox3.Controls.Add(this.lblMagicResistReq);
            this.groupBox3.Controls.Add(this.lblDefenseReq);
            this.groupBox3.Controls.Add(this.lblAbilityPowerReq);
            this.groupBox3.Controls.Add(this.lblAttackReq);
            this.groupBox3.Controls.Add(this.scrlDefenseReq);
            this.groupBox3.Controls.Add(this.scrlSpeedReq);
            this.groupBox3.Controls.Add(this.scrlMagicResistReq);
            this.groupBox3.Controls.Add(this.scrlAbilityPowerReq);
            this.groupBox3.Controls.Add(this.scrlAttackReq);
            this.groupBox3.Location = new System.Drawing.Point(438, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 220);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Requirements";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Class:";
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "None"});
            this.cmbClass.Location = new System.Drawing.Point(13, 190);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(194, 21);
            this.cmbClass.TabIndex = 12;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // lblLevelReq
            // 
            this.lblLevelReq.AutoSize = true;
            this.lblLevelReq.Location = new System.Drawing.Point(124, 122);
            this.lblLevelReq.Name = "lblLevelReq";
            this.lblLevelReq.Size = new System.Drawing.Size(45, 13);
            this.lblLevelReq.TabIndex = 11;
            this.lblLevelReq.Text = "Level: 0";
            // 
            // scrlLevelReq
            // 
            this.scrlLevelReq.Location = new System.Drawing.Point(127, 135);
            this.scrlLevelReq.Name = "scrlLevelReq";
            this.scrlLevelReq.Size = new System.Drawing.Size(80, 17);
            this.scrlLevelReq.TabIndex = 10;
            this.scrlLevelReq.ValueChanged += new System.EventHandler(this.scrlLevel_Scroll);
            // 
            // lblSpeedReq
            // 
            this.lblSpeedReq.AutoSize = true;
            this.lblSpeedReq.Location = new System.Drawing.Point(10, 121);
            this.lblSpeedReq.Name = "lblSpeedReq";
            this.lblSpeedReq.Size = new System.Drawing.Size(50, 13);
            this.lblSpeedReq.TabIndex = 9;
            this.lblSpeedReq.Text = "Speed: 0";
            // 
            // lblMagicResistReq
            // 
            this.lblMagicResistReq.AutoSize = true;
            this.lblMagicResistReq.Location = new System.Drawing.Point(124, 70);
            this.lblMagicResistReq.Name = "lblMagicResistReq";
            this.lblMagicResistReq.Size = new System.Drawing.Size(80, 13);
            this.lblMagicResistReq.TabIndex = 8;
            this.lblMagicResistReq.Text = "Magic Resist: 0";
            // 
            // lblDefenseReq
            // 
            this.lblDefenseReq.AutoSize = true;
            this.lblDefenseReq.Location = new System.Drawing.Point(10, 70);
            this.lblDefenseReq.Name = "lblDefenseReq";
            this.lblDefenseReq.Size = new System.Drawing.Size(59, 13);
            this.lblDefenseReq.TabIndex = 7;
            this.lblDefenseReq.Text = "Defense: 0";
            // 
            // lblAbilityPowerReq
            // 
            this.lblAbilityPowerReq.AutoSize = true;
            this.lblAbilityPowerReq.Location = new System.Drawing.Point(124, 20);
            this.lblAbilityPowerReq.Name = "lblAbilityPowerReq";
            this.lblAbilityPowerReq.Size = new System.Drawing.Size(67, 13);
            this.lblAbilityPowerReq.TabIndex = 6;
            this.lblAbilityPowerReq.Text = "Ability Pwr: 0";
            // 
            // lblAttackReq
            // 
            this.lblAttackReq.AutoSize = true;
            this.lblAttackReq.Location = new System.Drawing.Point(10, 20);
            this.lblAttackReq.Name = "lblAttackReq";
            this.lblAttackReq.Size = new System.Drawing.Size(50, 13);
            this.lblAttackReq.TabIndex = 5;
            this.lblAttackReq.Text = "Attack: 0";
            // 
            // scrlDefenseReq
            // 
            this.scrlDefenseReq.Location = new System.Drawing.Point(13, 85);
            this.scrlDefenseReq.Maximum = 255;
            this.scrlDefenseReq.Name = "scrlDefenseReq";
            this.scrlDefenseReq.Size = new System.Drawing.Size(80, 17);
            this.scrlDefenseReq.TabIndex = 4;
            this.scrlDefenseReq.ValueChanged += new System.EventHandler(this.scrlDefenseReq_Scroll);
            // 
            // scrlSpeedReq
            // 
            this.scrlSpeedReq.Location = new System.Drawing.Point(13, 134);
            this.scrlSpeedReq.Maximum = 255;
            this.scrlSpeedReq.Name = "scrlSpeedReq";
            this.scrlSpeedReq.Size = new System.Drawing.Size(80, 17);
            this.scrlSpeedReq.TabIndex = 3;
            this.scrlSpeedReq.ValueChanged += new System.EventHandler(this.scrlSpeedReq_Scroll);
            // 
            // scrlMagicResistReq
            // 
            this.scrlMagicResistReq.Location = new System.Drawing.Point(127, 85);
            this.scrlMagicResistReq.Maximum = 255;
            this.scrlMagicResistReq.Name = "scrlMagicResistReq";
            this.scrlMagicResistReq.Size = new System.Drawing.Size(80, 17);
            this.scrlMagicResistReq.TabIndex = 2;
            this.scrlMagicResistReq.ValueChanged += new System.EventHandler(this.scrlMagicResistReq_Scroll);
            // 
            // scrlAbilityPowerReq
            // 
            this.scrlAbilityPowerReq.Location = new System.Drawing.Point(127, 39);
            this.scrlAbilityPowerReq.Maximum = 255;
            this.scrlAbilityPowerReq.Name = "scrlAbilityPowerReq";
            this.scrlAbilityPowerReq.Size = new System.Drawing.Size(80, 17);
            this.scrlAbilityPowerReq.TabIndex = 1;
            this.scrlAbilityPowerReq.ValueChanged += new System.EventHandler(this.scrlAbilityPowerReq_Scroll);
            // 
            // scrlAttackReq
            // 
            this.scrlAttackReq.Location = new System.Drawing.Point(13, 39);
            this.scrlAttackReq.Maximum = 255;
            this.scrlAttackReq.Name = "scrlAttackReq";
            this.scrlAttackReq.Size = new System.Drawing.Size(80, 17);
            this.scrlAttackReq.TabIndex = 0;
            this.scrlAttackReq.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlAttackReq_Scroll);
            this.scrlAttackReq.ValueChanged += new System.EventHandler(this.scrlAttackReq_Scroll);
            // 
            // gbEquipment
            // 
            this.gbEquipment.Controls.Add(this.lblEffectPercent);
            this.gbEquipment.Controls.Add(this.scrlEffectAmount);
            this.gbEquipment.Controls.Add(this.cmbEquipmentBonus);
            this.gbEquipment.Controls.Add(this.label9);
            this.gbEquipment.Controls.Add(this.cmbToolType);
            this.gbEquipment.Controls.Add(this.lblToolType);
            this.gbEquipment.Controls.Add(this.chk2Hand);
            this.gbEquipment.Controls.Add(this.cmbEquipmentSlot);
            this.gbEquipment.Controls.Add(this.label7);
            this.gbEquipment.Controls.Add(this.cmbPaperdoll);
            this.gbEquipment.Controls.Add(this.label5);
            this.gbEquipment.Controls.Add(this.lblRange);
            this.gbEquipment.Controls.Add(this.scrlRange);
            this.gbEquipment.Controls.Add(this.picPaperdoll);
            this.gbEquipment.Controls.Add(this.lblDamage);
            this.gbEquipment.Controls.Add(this.scrlDamage);
            this.gbEquipment.Controls.Add(this.lblSpeed);
            this.gbEquipment.Controls.Add(this.lblMagicResist);
            this.gbEquipment.Controls.Add(this.lblDefense);
            this.gbEquipment.Controls.Add(this.lblAbilityPower);
            this.gbEquipment.Controls.Add(this.lblAttack);
            this.gbEquipment.Controls.Add(this.scrlDefense);
            this.gbEquipment.Controls.Add(this.scrlSpeed);
            this.gbEquipment.Controls.Add(this.scrlMagicResist);
            this.gbEquipment.Controls.Add(this.scrlAbilityPower);
            this.gbEquipment.Controls.Add(this.scrlAttack);
            this.gbEquipment.Location = new System.Drawing.Point(225, 233);
            this.gbEquipment.Name = "gbEquipment";
            this.gbEquipment.Size = new System.Drawing.Size(439, 205);
            this.gbEquipment.TabIndex = 12;
            this.gbEquipment.TabStop = false;
            this.gbEquipment.Text = "Equipment";
            this.gbEquipment.Visible = false;
            // 
            // lblEffectPercent
            // 
            this.lblEffectPercent.AutoSize = true;
            this.lblEffectPercent.Location = new System.Drawing.Point(323, 60);
            this.lblEffectPercent.Name = "lblEffectPercent";
            this.lblEffectPercent.Size = new System.Drawing.Size(94, 13);
            this.lblEffectPercent.TabIndex = 31;
            this.lblEffectPercent.Text = "Effect Amount: 0%";
            // 
            // scrlEffectAmount
            // 
            this.scrlEffectAmount.LargeChange = 1;
            this.scrlEffectAmount.Location = new System.Drawing.Point(326, 79);
            this.scrlEffectAmount.Name = "scrlEffectAmount";
            this.scrlEffectAmount.Size = new System.Drawing.Size(102, 17);
            this.scrlEffectAmount.TabIndex = 30;
            // 
            // cmbEquipmentBonus
            // 
            this.cmbEquipmentBonus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipmentBonus.FormattingEnabled = true;
            this.cmbEquipmentBonus.Location = new System.Drawing.Point(198, 76);
            this.cmbEquipmentBonus.Name = "cmbEquipmentBonus";
            this.cmbEquipmentBonus.Size = new System.Drawing.Size(108, 21);
            this.cmbEquipmentBonus.TabIndex = 29;
            this.cmbEquipmentBonus.SelectedIndexChanged += new System.EventHandler(this.cmbEquipmentBonus_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(195, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Bonus Effect:";
            // 
            // cmbToolType
            // 
            this.cmbToolType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToolType.FormattingEnabled = true;
            this.cmbToolType.Location = new System.Drawing.Point(326, 35);
            this.cmbToolType.Name = "cmbToolType";
            this.cmbToolType.Size = new System.Drawing.Size(107, 21);
            this.cmbToolType.TabIndex = 27;
            this.cmbToolType.Visible = false;
            this.cmbToolType.SelectedIndexChanged += new System.EventHandler(this.cmbToolType_SelectedIndexChanged);
            // 
            // lblToolType
            // 
            this.lblToolType.AutoSize = true;
            this.lblToolType.Location = new System.Drawing.Point(323, 19);
            this.lblToolType.Name = "lblToolType";
            this.lblToolType.Size = new System.Drawing.Size(58, 13);
            this.lblToolType.TabIndex = 26;
            this.lblToolType.Text = "Tool Type:";
            this.lblToolType.Visible = false;
            // 
            // chk2Hand
            // 
            this.chk2Hand.AutoSize = true;
            this.chk2Hand.Location = new System.Drawing.Point(198, 107);
            this.chk2Hand.Name = "chk2Hand";
            this.chk2Hand.Size = new System.Drawing.Size(61, 17);
            this.chk2Hand.TabIndex = 25;
            this.chk2Hand.Text = "2 Hand";
            this.chk2Hand.UseVisualStyleBackColor = true;
            this.chk2Hand.Visible = false;
            this.chk2Hand.CheckedChanged += new System.EventHandler(this.chk2Hand_CheckedChanged);
            // 
            // cmbEquipmentSlot
            // 
            this.cmbEquipmentSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipmentSlot.FormattingEnabled = true;
            this.cmbEquipmentSlot.Location = new System.Drawing.Point(198, 35);
            this.cmbEquipmentSlot.Name = "cmbEquipmentSlot";
            this.cmbEquipmentSlot.Size = new System.Drawing.Size(108, 21);
            this.cmbEquipmentSlot.TabIndex = 24;
            this.cmbEquipmentSlot.SelectedIndexChanged += new System.EventHandler(this.cmbEquipmentSlot_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Equipment Slot:";
            // 
            // cmbPaperdoll
            // 
            this.cmbPaperdoll.FormattingEnabled = true;
            this.cmbPaperdoll.Items.AddRange(new object[] {
            "None"});
            this.cmbPaperdoll.Location = new System.Drawing.Point(226, 181);
            this.cmbPaperdoll.Name = "cmbPaperdoll";
            this.cmbPaperdoll.Size = new System.Drawing.Size(194, 21);
            this.cmbPaperdoll.TabIndex = 22;
            this.cmbPaperdoll.Text = "None";
            this.cmbPaperdoll.SelectedIndexChanged += new System.EventHandler(this.cmbPaperdoll_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Paperdoll:";
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(9, 154);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(118, 13);
            this.lblRange.TabIndex = 20;
            this.lblRange.Text = "Stat Bonus Range: +- 0";
            // 
            // scrlRange
            // 
            this.scrlRange.Location = new System.Drawing.Point(13, 172);
            this.scrlRange.Name = "scrlRange";
            this.scrlRange.Size = new System.Drawing.Size(80, 18);
            this.scrlRange.TabIndex = 19;
            this.scrlRange.ValueChanged += new System.EventHandler(this.scrlRange_Scroll);
            // 
            // picPaperdoll
            // 
            this.picPaperdoll.Location = new System.Drawing.Point(292, 103);
            this.picPaperdoll.Name = "picPaperdoll";
            this.picPaperdoll.Size = new System.Drawing.Size(128, 64);
            this.picPaperdoll.TabIndex = 16;
            this.picPaperdoll.TabStop = false;
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Location = new System.Drawing.Point(101, 114);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(59, 13);
            this.lblDamage.TabIndex = 11;
            this.lblDamage.Text = "Damage: 0";
            this.lblDamage.Visible = false;
            // 
            // scrlDamage
            // 
            this.scrlDamage.Location = new System.Drawing.Point(104, 128);
            this.scrlDamage.Name = "scrlDamage";
            this.scrlDamage.Size = new System.Drawing.Size(80, 17);
            this.scrlDamage.TabIndex = 10;
            this.scrlDamage.Visible = false;
            this.scrlDamage.ValueChanged += new System.EventHandler(this.scrlDmg_Scroll);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(9, 114);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(50, 13);
            this.lblSpeed.TabIndex = 9;
            this.lblSpeed.Text = "Speed: 0";
            // 
            // lblMagicResist
            // 
            this.lblMagicResist.AutoSize = true;
            this.lblMagicResist.Location = new System.Drawing.Point(101, 70);
            this.lblMagicResist.Name = "lblMagicResist";
            this.lblMagicResist.Size = new System.Drawing.Size(80, 13);
            this.lblMagicResist.TabIndex = 8;
            this.lblMagicResist.Text = "Magic Resist: 0";
            // 
            // lblDefense
            // 
            this.lblDefense.AutoSize = true;
            this.lblDefense.Location = new System.Drawing.Point(10, 70);
            this.lblDefense.Name = "lblDefense";
            this.lblDefense.Size = new System.Drawing.Size(59, 13);
            this.lblDefense.TabIndex = 7;
            this.lblDefense.Text = "Defense: 0";
            // 
            // lblAbilityPower
            // 
            this.lblAbilityPower.AutoSize = true;
            this.lblAbilityPower.Location = new System.Drawing.Point(101, 20);
            this.lblAbilityPower.Name = "lblAbilityPower";
            this.lblAbilityPower.Size = new System.Drawing.Size(67, 13);
            this.lblAbilityPower.TabIndex = 6;
            this.lblAbilityPower.Text = "Ability Pwr: 0";
            // 
            // lblAttack
            // 
            this.lblAttack.AutoSize = true;
            this.lblAttack.Location = new System.Drawing.Point(10, 20);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.Size = new System.Drawing.Size(50, 13);
            this.lblAttack.TabIndex = 5;
            this.lblAttack.Text = "Attack: 0";
            // 
            // scrlDefense
            // 
            this.scrlDefense.Location = new System.Drawing.Point(13, 85);
            this.scrlDefense.Maximum = 255;
            this.scrlDefense.Name = "scrlDefense";
            this.scrlDefense.Size = new System.Drawing.Size(80, 17);
            this.scrlDefense.TabIndex = 4;
            this.scrlDefense.ValueChanged += new System.EventHandler(this.scrlDefense_Scroll);
            // 
            // scrlSpeed
            // 
            this.scrlSpeed.Location = new System.Drawing.Point(13, 127);
            this.scrlSpeed.Maximum = 255;
            this.scrlSpeed.Name = "scrlSpeed";
            this.scrlSpeed.Size = new System.Drawing.Size(80, 17);
            this.scrlSpeed.TabIndex = 3;
            this.scrlSpeed.ValueChanged += new System.EventHandler(this.scrlSpeed_Scroll);
            // 
            // scrlMagicResist
            // 
            this.scrlMagicResist.Location = new System.Drawing.Point(104, 85);
            this.scrlMagicResist.Maximum = 255;
            this.scrlMagicResist.Name = "scrlMagicResist";
            this.scrlMagicResist.Size = new System.Drawing.Size(80, 17);
            this.scrlMagicResist.TabIndex = 2;
            this.scrlMagicResist.ValueChanged += new System.EventHandler(this.scrlMagicResist_Scroll);
            // 
            // scrlAbilityPower
            // 
            this.scrlAbilityPower.Location = new System.Drawing.Point(104, 39);
            this.scrlAbilityPower.Maximum = 255;
            this.scrlAbilityPower.Name = "scrlAbilityPower";
            this.scrlAbilityPower.Size = new System.Drawing.Size(80, 17);
            this.scrlAbilityPower.TabIndex = 1;
            this.scrlAbilityPower.ValueChanged += new System.EventHandler(this.scrlAbilityPower_Scroll);
            // 
            // scrlAttack
            // 
            this.scrlAttack.Location = new System.Drawing.Point(13, 39);
            this.scrlAttack.Maximum = 255;
            this.scrlAttack.Name = "scrlAttack";
            this.scrlAttack.Size = new System.Drawing.Size(80, 17);
            this.scrlAttack.TabIndex = 0;
            this.scrlAttack.ValueChanged += new System.EventHandler(this.scrlAttack_Scroll);
            // 
            // gbConsumable
            // 
            this.gbConsumable.Controls.Add(this.label4);
            this.gbConsumable.Controls.Add(this.cmbConsume);
            this.gbConsumable.Controls.Add(this.scrlInterval);
            this.gbConsumable.Controls.Add(this.lblInterval);
            this.gbConsumable.Location = new System.Drawing.Point(225, 233);
            this.gbConsumable.Name = "gbConsumable";
            this.gbConsumable.Size = new System.Drawing.Size(217, 122);
            this.gbConsumable.TabIndex = 12;
            this.gbConsumable.TabStop = false;
            this.gbConsumable.Text = "Consumable";
            this.gbConsumable.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Vital:";
            // 
            // cmbConsume
            // 
            this.cmbConsume.FormattingEnabled = true;
            this.cmbConsume.Items.AddRange(new object[] {
            "Health",
            "Mana",
            "Experience"});
            this.cmbConsume.Location = new System.Drawing.Point(19, 36);
            this.cmbConsume.Name = "cmbConsume";
            this.cmbConsume.Size = new System.Drawing.Size(176, 21);
            this.cmbConsume.TabIndex = 11;
            this.cmbConsume.Text = "Health";
            this.cmbConsume.SelectedIndexChanged += new System.EventHandler(this.cmbConsume_SelectedIndexChanged);
            // 
            // scrlInterval
            // 
            this.scrlInterval.Location = new System.Drawing.Point(19, 88);
            this.scrlInterval.Maximum = 1000;
            this.scrlInterval.Name = "scrlInterval";
            this.scrlInterval.Size = new System.Drawing.Size(176, 18);
            this.scrlInterval.TabIndex = 10;
            this.scrlInterval.ValueChanged += new System.EventHandler(this.scrlInterval_Scroll);
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(19, 69);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(54, 13);
            this.lblInterval.TabIndex = 9;
            this.lblInterval.Text = "Interval: 0";
            // 
            // gbSpell
            // 
            this.gbSpell.Controls.Add(this.scrlSpell);
            this.gbSpell.Controls.Add(this.lblSpell);
            this.gbSpell.Location = new System.Drawing.Point(225, 233);
            this.gbSpell.Name = "gbSpell";
            this.gbSpell.Size = new System.Drawing.Size(217, 67);
            this.gbSpell.TabIndex = 13;
            this.gbSpell.TabStop = false;
            this.gbSpell.Text = "Spell";
            this.gbSpell.Visible = false;
            // 
            // scrlSpell
            // 
            this.scrlSpell.Location = new System.Drawing.Point(12, 39);
            this.scrlSpell.Maximum = 1000;
            this.scrlSpell.Name = "scrlSpell";
            this.scrlSpell.Size = new System.Drawing.Size(176, 18);
            this.scrlSpell.TabIndex = 12;
            this.scrlSpell.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlSpell_Scroll);
            this.scrlSpell.ValueChanged += new System.EventHandler(this.scrlSpell_Scroll);
            // 
            // lblSpell
            // 
            this.lblSpell.AutoSize = true;
            this.lblSpell.Location = new System.Drawing.Point(12, 20);
            this.lblSpell.Name = "lblSpell";
            this.lblSpell.Size = new System.Drawing.Size(71, 13);
            this.lblSpell.TabIndex = 11;
            this.lblSpell.Text = "Spell: 0 None";
            // 
            // FrmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbEquipment);
            this.Controls.Add(this.gbSpell);
            this.Controls.Add(this.gbConsumable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmItem";
            this.Text = "Item Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmItem_FormClosed);
            this.Load += new System.EventHandler(this.frmItem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbEquipment.ResumeLayout(false);
            this.gbEquipment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPaperdoll)).EndInit();
            this.gbConsumable.ResumeLayout(false);
            this.gbConsumable.PerformLayout();
            this.gbSpell.ResumeLayout(false);
            this.gbSpell.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lstItems;
        private Button btnDelete;
        private Button btnSave;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private ComboBox cmbType;
        private HScrollBar scrlAnim;
        private Label lblAnim;
        private HScrollBar scrlPrice;
        private Label lblPrice;
        private PictureBox picItem;
        private GroupBox groupBox3;
        private Label label3;
        private ComboBox cmbClass;
        private Label lblLevelReq;
        private HScrollBar scrlLevelReq;
        private Label lblSpeedReq;
        private Label lblMagicResistReq;
        private Label lblDefenseReq;
        private Label lblAbilityPowerReq;
        private Label lblAttackReq;
        private HScrollBar scrlDefenseReq;
        private HScrollBar scrlSpeedReq;
        private HScrollBar scrlMagicResistReq;
        private HScrollBar scrlAbilityPowerReq;
        private HScrollBar scrlAttackReq;
        private GroupBox gbEquipment;
        private Label lblDamage;
        private HScrollBar scrlDamage;
        private Label lblSpeed;
        private Label lblMagicResist;
        private Label lblDefense;
        private Label lblAbilityPower;
        private Label lblAttack;
        private HScrollBar scrlDefense;
        private HScrollBar scrlSpeed;
        private HScrollBar scrlMagicResist;
        private HScrollBar scrlAbilityPower;
        private HScrollBar scrlAttack;
        private PictureBox picPaperdoll;
        private GroupBox gbConsumable;
        private ComboBox cmbConsume;
        private HScrollBar scrlInterval;
        private Label lblInterval;
        private Label label4;
        private GroupBox gbSpell;
        private HScrollBar scrlSpell;
        private Label lblSpell;
        private Button btnCancel;
        private Label lblRange;
        private HScrollBar scrlRange;
        private ComboBox cmbPic;
        private Label lblPic;
        private ComboBox cmbPaperdoll;
        private Label label5;
        private Label label6;
        private TextBox txtDesc;
        private CheckBox chk2Hand;
        private ComboBox cmbEquipmentSlot;
        private Label label7;
        private Label lblEffectPercent;
        private HScrollBar scrlEffectAmount;
        private ComboBox cmbEquipmentBonus;
        private Label label9;
        private ComboBox cmbToolType;
        private Label lblToolType;

    }
}