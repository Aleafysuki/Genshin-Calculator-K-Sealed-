namespace Genshin_Calc
{
    partial class Hutao_Calc
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
            this.Input_Box = new System.Windows.Forms.GroupBox();
            this.MaxHP_Label = new System.Windows.Forms.Label();
            this.SkillLevel = new System.Windows.Forms.TextBox();
            this.SkillLevel1 = new System.Windows.Forms.TrackBar();
            this.SkillLevel_Label = new System.Windows.Forms.Label();
            this.MaxHP1 = new System.Windows.Forms.TrackBar();
            this.MaxHP = new System.Windows.Forms.TextBox();
            this.Weapon_Type3 = new System.Windows.Forms.RadioButton();
            this.Weapon_Type2 = new System.Windows.Forms.RadioButton();
            this.Weapon_Type1 = new System.Windows.Forms.RadioButton();
            this.Calc_Box = new System.Windows.Forms.GroupBox();
            this.ToATK = new System.Windows.Forms.Label();
            this.ToAtk_Label = new System.Windows.Forms.Label();
            this.SpecialCalc_Box = new System.Windows.Forms.GroupBox();
            this.Normal_DMG = new System.Windows.Forms.Label();
            this.Crit_DMG = new System.Windows.Forms.Label();
            this.Avg_DMG = new System.Windows.Forms.Label();
            this.NormalDMG_Text = new System.Windows.Forms.Label();
            this.CritDMG_Text = new System.Windows.Forms.Label();
            this.AvgDMG_Text = new System.Windows.Forms.Label();
            this.Constellation_Check = new System.Windows.Forms.CheckBox();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Confirm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Weapon_Grade_Label = new System.Windows.Forms.Label();
            this.Weapon_Grade = new System.Windows.Forms.DomainUpDown();
            this.Input_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SkillLevel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxHP1)).BeginInit();
            this.Calc_Box.SuspendLayout();
            this.SpecialCalc_Box.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Input_Box
            // 
            this.Input_Box.Controls.Add(this.MaxHP_Label);
            this.Input_Box.Controls.Add(this.SkillLevel);
            this.Input_Box.Controls.Add(this.SkillLevel1);
            this.Input_Box.Controls.Add(this.SkillLevel_Label);
            this.Input_Box.Controls.Add(this.MaxHP1);
            this.Input_Box.Controls.Add(this.MaxHP);
            this.Input_Box.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.Input_Box.Location = new System.Drawing.Point(12, 12);
            this.Input_Box.Name = "Input_Box";
            this.Input_Box.Size = new System.Drawing.Size(573, 145);
            this.Input_Box.TabIndex = 24;
            this.Input_Box.TabStop = false;
            this.Input_Box.Text = "属性填写";
            // 
            // MaxHP_Label
            // 
            this.MaxHP_Label.AutoSize = true;
            this.MaxHP_Label.Font = new System.Drawing.Font("微软雅黑", 14.75F);
            this.MaxHP_Label.Location = new System.Drawing.Point(10, 39);
            this.MaxHP_Label.Name = "MaxHP_Label";
            this.MaxHP_Label.Size = new System.Drawing.Size(112, 27);
            this.MaxHP_Label.TabIndex = 16;
            this.MaxHP_Label.Text = "生命值上限";
            // 
            // SkillLevel
            // 
            this.SkillLevel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillLevel.Location = new System.Drawing.Point(145, 94);
            this.SkillLevel.Name = "SkillLevel";
            this.SkillLevel.Size = new System.Drawing.Size(69, 32);
            this.SkillLevel.TabIndex = 2;
            this.SkillLevel.Text = "1";
            this.SkillLevel.TextChanged += new System.EventHandler(this.SkillLevel_TextChanged);
            // 
            // SkillLevel1
            // 
            this.SkillLevel1.BackColor = System.Drawing.SystemColors.Control;
            this.SkillLevel1.LargeChange = 1;
            this.SkillLevel1.Location = new System.Drawing.Point(220, 88);
            this.SkillLevel1.Maximum = 13;
            this.SkillLevel1.Minimum = 1;
            this.SkillLevel1.Name = "SkillLevel1";
            this.SkillLevel1.Size = new System.Drawing.Size(349, 45);
            this.SkillLevel1.TabIndex = 6;
            this.SkillLevel1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SkillLevel1.Value = 1;
            this.SkillLevel1.Scroll += new System.EventHandler(this.SkillLevel1_Scroll);
            // 
            // SkillLevel_Label
            // 
            this.SkillLevel_Label.AutoSize = true;
            this.SkillLevel_Label.Font = new System.Drawing.Font("微软雅黑", 14.75F);
            this.SkillLevel_Label.Location = new System.Drawing.Point(10, 94);
            this.SkillLevel_Label.Name = "SkillLevel_Label";
            this.SkillLevel_Label.Size = new System.Drawing.Size(132, 27);
            this.SkillLevel_Label.TabIndex = 11;
            this.SkillLevel_Label.Text = "元素战技等级";
            // 
            // MaxHP1
            // 
            this.MaxHP1.AllowDrop = true;
            this.MaxHP1.BackColor = System.Drawing.SystemColors.Control;
            this.MaxHP1.LargeChange = 20;
            this.MaxHP1.Location = new System.Drawing.Point(220, 39);
            this.MaxHP1.Maximum = 60000;
            this.MaxHP1.Name = "MaxHP1";
            this.MaxHP1.Size = new System.Drawing.Size(349, 45);
            this.MaxHP1.TabIndex = 5;
            this.MaxHP1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.MaxHP1.Value = 10000;
            this.MaxHP1.Scroll += new System.EventHandler(this.MaxHP1_Scroll);
            // 
            // MaxHP
            // 
            this.MaxHP.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxHP.Location = new System.Drawing.Point(145, 39);
            this.MaxHP.Name = "MaxHP";
            this.MaxHP.Size = new System.Drawing.Size(69, 32);
            this.MaxHP.TabIndex = 1;
            this.MaxHP.Text = "10000";
            this.MaxHP.TextChanged += new System.EventHandler(this.MaxHP_TextChanged);
            // 
            // Weapon_Type3
            // 
            this.Weapon_Type3.Appearance = System.Windows.Forms.Appearance.Button;
            this.Weapon_Type3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Weapon_Type3.Font = new System.Drawing.Font("微软雅黑", 12.75F);
            this.Weapon_Type3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Weapon_Type3.Location = new System.Drawing.Point(15, 94);
            this.Weapon_Type3.Name = "Weapon_Type3";
            this.Weapon_Type3.Size = new System.Drawing.Size(177, 32);
            this.Weapon_Type3.TabIndex = 39;
            this.Weapon_Type3.TabStop = true;
            this.Weapon_Type3.Text = "其他武器";
            this.Weapon_Type3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Weapon_Type3.UseVisualStyleBackColor = true;
            this.Weapon_Type3.CheckedChanged += new System.EventHandler(this.Weapon_Type3_CheckedChanged);
            // 
            // Weapon_Type2
            // 
            this.Weapon_Type2.Appearance = System.Windows.Forms.Appearance.Button;
            this.Weapon_Type2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Weapon_Type2.Font = new System.Drawing.Font("微软雅黑", 12.75F);
            this.Weapon_Type2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Weapon_Type2.Location = new System.Drawing.Point(15, 64);
            this.Weapon_Type2.Name = "Weapon_Type2";
            this.Weapon_Type2.Size = new System.Drawing.Size(177, 32);
            this.Weapon_Type2.TabIndex = 38;
            this.Weapon_Type2.TabStop = true;
            this.Weapon_Type2.Text = "护摩之杖(半血以下)";
            this.Weapon_Type2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Weapon_Type2.UseVisualStyleBackColor = true;
            this.Weapon_Type2.CheckedChanged += new System.EventHandler(this.Weapon_Type2_CheckedChanged);
            // 
            // Weapon_Type1
            // 
            this.Weapon_Type1.Appearance = System.Windows.Forms.Appearance.Button;
            this.Weapon_Type1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Weapon_Type1.Font = new System.Drawing.Font("微软雅黑", 12.75F);
            this.Weapon_Type1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Weapon_Type1.Location = new System.Drawing.Point(15, 33);
            this.Weapon_Type1.Name = "Weapon_Type1";
            this.Weapon_Type1.Size = new System.Drawing.Size(177, 32);
            this.Weapon_Type1.TabIndex = 37;
            this.Weapon_Type1.TabStop = true;
            this.Weapon_Type1.Text = "护摩之杖(半血以上)";
            this.Weapon_Type1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Weapon_Type1.UseVisualStyleBackColor = true;
            this.Weapon_Type1.CheckedChanged += new System.EventHandler(this.Weapon_Type1_CheckedChanged);
            // 
            // Calc_Box
            // 
            this.Calc_Box.Controls.Add(this.ToATK);
            this.Calc_Box.Controls.Add(this.ToAtk_Label);
            this.Calc_Box.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.Calc_Box.Location = new System.Drawing.Point(593, 163);
            this.Calc_Box.Name = "Calc_Box";
            this.Calc_Box.Size = new System.Drawing.Size(319, 75);
            this.Calc_Box.TabIndex = 25;
            this.Calc_Box.TabStop = false;
            this.Calc_Box.Text = "计算结果";
            // 
            // ToATK
            // 
            this.ToATK.Font = new System.Drawing.Font("方正像素12", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ToATK.ForeColor = System.Drawing.Color.DarkRed;
            this.ToATK.Location = new System.Drawing.Point(140, 30);
            this.ToATK.Name = "ToATK";
            this.ToATK.Size = new System.Drawing.Size(173, 24);
            this.ToATK.TabIndex = 24;
            this.ToATK.Text = "0";
            this.ToATK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ToAtk_Label
            // 
            this.ToAtk_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToAtk_Label.AutoSize = true;
            this.ToAtk_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ToAtk_Label.Location = new System.Drawing.Point(10, 30);
            this.ToAtk_Label.Name = "ToAtk_Label";
            this.ToAtk_Label.Size = new System.Drawing.Size(138, 28);
            this.ToAtk_Label.TabIndex = 22;
            this.ToAtk_Label.Text = "转化为攻击：";
            // 
            // SpecialCalc_Box
            // 
            this.SpecialCalc_Box.Controls.Add(this.Normal_DMG);
            this.SpecialCalc_Box.Controls.Add(this.Crit_DMG);
            this.SpecialCalc_Box.Controls.Add(this.Avg_DMG);
            this.SpecialCalc_Box.Controls.Add(this.NormalDMG_Text);
            this.SpecialCalc_Box.Controls.Add(this.CritDMG_Text);
            this.SpecialCalc_Box.Controls.Add(this.AvgDMG_Text);
            this.SpecialCalc_Box.Controls.Add(this.Constellation_Check);
            this.SpecialCalc_Box.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.SpecialCalc_Box.Location = new System.Drawing.Point(12, 163);
            this.SpecialCalc_Box.Name = "SpecialCalc_Box";
            this.SpecialCalc_Box.Size = new System.Drawing.Size(575, 115);
            this.SpecialCalc_Box.TabIndex = 26;
            this.SpecialCalc_Box.TabStop = false;
            this.SpecialCalc_Box.Text = "血梅香伤害计算";
            // 
            // Normal_DMG
            // 
            this.Normal_DMG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Normal_DMG.Font = new System.Drawing.Font("方正像素12", 21F);
            this.Normal_DMG.ForeColor = System.Drawing.Color.DarkRed;
            this.Normal_DMG.Location = new System.Drawing.Point(97, 70);
            this.Normal_DMG.Name = "Normal_DMG";
            this.Normal_DMG.Size = new System.Drawing.Size(98, 24);
            this.Normal_DMG.TabIndex = 32;
            this.Normal_DMG.Text = "0";
            this.Normal_DMG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Crit_DMG
            // 
            this.Crit_DMG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Crit_DMG.Font = new System.Drawing.Font("方正像素12", 21F);
            this.Crit_DMG.ForeColor = System.Drawing.Color.DarkRed;
            this.Crit_DMG.Location = new System.Drawing.Point(284, 71);
            this.Crit_DMG.Name = "Crit_DMG";
            this.Crit_DMG.Size = new System.Drawing.Size(98, 24);
            this.Crit_DMG.TabIndex = 33;
            this.Crit_DMG.Text = "0";
            this.Crit_DMG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Avg_DMG
            // 
            this.Avg_DMG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Avg_DMG.Font = new System.Drawing.Font("方正像素12", 21F);
            this.Avg_DMG.ForeColor = System.Drawing.Color.IndianRed;
            this.Avg_DMG.Location = new System.Drawing.Point(471, 71);
            this.Avg_DMG.Name = "Avg_DMG";
            this.Avg_DMG.Size = new System.Drawing.Size(98, 24);
            this.Avg_DMG.TabIndex = 34;
            this.Avg_DMG.Text = "0";
            this.Avg_DMG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NormalDMG_Text
            // 
            this.NormalDMG_Text.AutoSize = true;
            this.NormalDMG_Text.Font = new System.Drawing.Font("方正像素14", 15.75F);
            this.NormalDMG_Text.Location = new System.Drawing.Point(18, 73);
            this.NormalDMG_Text.Name = "NormalDMG_Text";
            this.NormalDMG_Text.Size = new System.Drawing.Size(73, 21);
            this.NormalDMG_Text.TabIndex = 29;
            this.NormalDMG_Text.Text = "未暴击";
            // 
            // CritDMG_Text
            // 
            this.CritDMG_Text.AutoSize = true;
            this.CritDMG_Text.Font = new System.Drawing.Font("方正像素14", 15.75F);
            this.CritDMG_Text.Location = new System.Drawing.Point(205, 73);
            this.CritDMG_Text.Name = "CritDMG_Text";
            this.CritDMG_Text.Size = new System.Drawing.Size(73, 21);
            this.CritDMG_Text.TabIndex = 30;
            this.CritDMG_Text.Text = "已暴击";
            // 
            // AvgDMG_Text
            // 
            this.AvgDMG_Text.AutoSize = true;
            this.AvgDMG_Text.Font = new System.Drawing.Font("方正像素14", 15.75F);
            this.AvgDMG_Text.Location = new System.Drawing.Point(392, 74);
            this.AvgDMG_Text.Name = "AvgDMG_Text";
            this.AvgDMG_Text.Size = new System.Drawing.Size(73, 21);
            this.AvgDMG_Text.TabIndex = 31;
            this.AvgDMG_Text.Text = "平均值";
            // 
            // Constellation_Check
            // 
            this.Constellation_Check.Appearance = System.Windows.Forms.Appearance.Button;
            this.Constellation_Check.BackColor = System.Drawing.Color.Azure;
            this.Constellation_Check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Constellation_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Constellation_Check.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.Constellation_Check.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Constellation_Check.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.Constellation_Check.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Constellation_Check.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.Constellation_Check.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Constellation_Check.Location = new System.Drawing.Point(15, 29);
            this.Constellation_Check.Name = "Constellation_Check";
            this.Constellation_Check.Size = new System.Drawing.Size(554, 31);
            this.Constellation_Check.TabIndex = 28;
            this.Constellation_Check.Text = "  解锁第二命座「最不安神晴又复雨」";
            this.Constellation_Check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Constellation_Check.UseVisualStyleBackColor = false;
            this.Constellation_Check.CheckedChanged += new System.EventHandler(this.Constellation_Check_CheckedChanged);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Button_Cancel.Location = new System.Drawing.Point(756, 244);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(156, 34);
            this.Button_Cancel.TabIndex = 28;
            this.Button_Cancel.Text = "取消并清除填写";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Confirm
            // 
            this.Button_Confirm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Button_Confirm.Location = new System.Drawing.Point(593, 244);
            this.Button_Confirm.Name = "Button_Confirm";
            this.Button_Confirm.Size = new System.Drawing.Size(157, 34);
            this.Button_Confirm.TabIndex = 27;
            this.Button_Confirm.Text = "确认并导入数据";
            this.Button_Confirm.UseVisualStyleBackColor = true;
            this.Button_Confirm.Click += new System.EventHandler(this.Button_Confirm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Weapon_Grade_Label);
            this.groupBox1.Controls.Add(this.Weapon_Grade);
            this.groupBox1.Controls.Add(this.Weapon_Type1);
            this.groupBox1.Controls.Add(this.Weapon_Type3);
            this.groupBox1.Controls.Add(this.Weapon_Type2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.groupBox1.Location = new System.Drawing.Point(593, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 145);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "计算结果";
            // 
            // Weapon_Grade_Label
            // 
            this.Weapon_Grade_Label.AutoSize = true;
            this.Weapon_Grade_Label.Font = new System.Drawing.Font("微软雅黑", 14.75F);
            this.Weapon_Grade_Label.Location = new System.Drawing.Point(210, 44);
            this.Weapon_Grade_Label.Name = "Weapon_Grade_Label";
            this.Weapon_Grade_Label.Size = new System.Drawing.Size(92, 27);
            this.Weapon_Grade_Label.TabIndex = 17;
            this.Weapon_Grade_Label.Text = "精炼等级";
            // 
            // Weapon_Grade
            // 
            this.Weapon_Grade.Items.Add("精炼1");
            this.Weapon_Grade.Items.Add("精炼2");
            this.Weapon_Grade.Items.Add("精炼3");
            this.Weapon_Grade.Items.Add("精炼4");
            this.Weapon_Grade.Items.Add("精炼5");
            this.Weapon_Grade.Location = new System.Drawing.Point(206, 76);
            this.Weapon_Grade.Name = "Weapon_Grade";
            this.Weapon_Grade.ReadOnly = true;
            this.Weapon_Grade.Size = new System.Drawing.Size(100, 30);
            this.Weapon_Grade.TabIndex = 40;
            this.Weapon_Grade.SelectedItemChanged += new System.EventHandler(this.Weapon_Grade_SelectedItemChanged);
            // 
            // Hutao_Calc
            // 
            this.AcceptButton = this.Button_Confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(922, 290);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Confirm);
            this.Controls.Add(this.SpecialCalc_Box);
            this.Controls.Add(this.Calc_Box);
            this.Controls.Add(this.Input_Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Hutao_Calc";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "生命转攻击计算器（当前适用于胡桃）";
            this.Input_Box.ResumeLayout(false);
            this.Input_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SkillLevel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxHP1)).EndInit();
            this.Calc_Box.ResumeLayout(false);
            this.Calc_Box.PerformLayout();
            this.SpecialCalc_Box.ResumeLayout(false);
            this.SpecialCalc_Box.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Input_Box;
        private System.Windows.Forms.Label MaxHP_Label;
        private System.Windows.Forms.TextBox SkillLevel;
        private System.Windows.Forms.TrackBar SkillLevel1;
        private System.Windows.Forms.Label SkillLevel_Label;
        private System.Windows.Forms.TrackBar MaxHP1;
        private System.Windows.Forms.TextBox MaxHP;
        private System.Windows.Forms.GroupBox Calc_Box;
        private System.Windows.Forms.Label ToATK;
        private System.Windows.Forms.Label ToAtk_Label;
        private System.Windows.Forms.GroupBox SpecialCalc_Box;
        private System.Windows.Forms.CheckBox Constellation_Check;
        private System.Windows.Forms.Label Normal_DMG;
        private System.Windows.Forms.Label Crit_DMG;
        private System.Windows.Forms.Label Avg_DMG;
        private System.Windows.Forms.Label NormalDMG_Text;
        private System.Windows.Forms.Label CritDMG_Text;
        private System.Windows.Forms.Label AvgDMG_Text;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Confirm;
        private System.Windows.Forms.RadioButton Weapon_Type3;
        private System.Windows.Forms.RadioButton Weapon_Type2;
        private System.Windows.Forms.RadioButton Weapon_Type1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Weapon_Grade_Label;
        private System.Windows.Forms.DomainUpDown Weapon_Grade;
    }
}