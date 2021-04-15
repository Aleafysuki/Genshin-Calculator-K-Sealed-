namespace Genshin_Calc
{
    partial class Zhongli_Calc
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
            this.HP1 = new System.Windows.Forms.TrackBar();
            this.HP = new System.Windows.Forms.TextBox();
            this.HP_Label = new System.Windows.Forms.Label();
            this.SkillSelection = new System.Windows.Forms.ListBox();
            this.Text_DMGPlus = new System.Windows.Forms.Label();
            this.DMG_Group = new System.Windows.Forms.GroupBox();
            this.Normal_DMG = new System.Windows.Forms.Label();
            this.Crit_DMG = new System.Windows.Forms.Label();
            this.Avg_DMG = new System.Windows.Forms.Label();
            this.NormalDMG_Text = new System.Windows.Forms.Label();
            this.CritDMG_Text = new System.Windows.Forms.Label();
            this.AvgDMG_Text = new System.Windows.Forms.Label();
            this.SkillInput = new System.Windows.Forms.GroupBox();
            this.Skill1 = new System.Windows.Forms.TrackBar();
            this.Skill_Label = new System.Windows.Forms.Label();
            this.Skill = new System.Windows.Forms.TextBox();
            this.ATK1 = new System.Windows.Forms.TrackBar();
            this.ATK = new System.Windows.Forms.TextBox();
            this.ATK_Label = new System.Windows.Forms.Label();
            this.EnemyRES1 = new System.Windows.Forms.TrackBar();
            this.EnemyRES = new System.Windows.Forms.TextBox();
            this.RES_Label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BuffGroup = new System.Windows.Forms.GroupBox();
            this.Other_Buff = new System.Windows.Forms.TextBox();
            this.Other_buff_Text = new System.Windows.Forms.Label();
            this.Geo_Buff = new System.Windows.Forms.TextBox();
            this.Phys_Buff = new System.Windows.Forms.TextBox();
            this.Geo_Buff_Text = new System.Windows.Forms.Label();
            this.Phys_Buff_Text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HP1)).BeginInit();
            this.DMG_Group.SuspendLayout();
            this.SkillInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Skill1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATK1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyRES1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.BuffGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // HP1
            // 
            this.HP1.AllowDrop = true;
            this.HP1.BackColor = System.Drawing.SystemColors.Control;
            this.HP1.LargeChange = 0;
            this.HP1.Location = new System.Drawing.Point(320, 33);
            this.HP1.Maximum = 60000;
            this.HP1.Name = "HP1";
            this.HP1.Size = new System.Drawing.Size(552, 45);
            this.HP1.TabIndex = 15;
            this.HP1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.HP1.Value = 10000;
            this.HP1.Scroll += new System.EventHandler(this.HP1_Scroll);
            // 
            // HP
            // 
            this.HP.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HP.Location = new System.Drawing.Point(204, 33);
            this.HP.MaxLength = 8;
            this.HP.Name = "HP";
            this.HP.Size = new System.Drawing.Size(96, 32);
            this.HP.TabIndex = 14;
            this.HP.Text = "10000";
            this.HP.TextChanged += new System.EventHandler(this.HP_TextChanged);
            // 
            // HP_Label
            // 
            this.HP_Label.AutoSize = true;
            this.HP_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HP_Label.Location = new System.Drawing.Point(22, 33);
            this.HP_Label.Name = "HP_Label";
            this.HP_Label.Size = new System.Drawing.Size(117, 28);
            this.HP_Label.TabIndex = 16;
            this.HP_Label.Text = "生命值上限";
            // 
            // SkillSelection
            // 
            this.SkillSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SkillSelection.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SkillSelection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SkillSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SkillSelection.Font = new System.Drawing.Font("微软雅黑", 14.75F);
            this.SkillSelection.FormattingEnabled = true;
            this.SkillSelection.ItemHeight = 27;
            this.SkillSelection.Items.AddRange(new object[] {
            "普通攻击（包括重击/下落攻击）",
            "元素战技（包括地心的岩脊/共鸣伤害/长按伤害）",
            "元素爆发"});
            this.SkillSelection.Location = new System.Drawing.Point(6, 29);
            this.SkillSelection.Name = "SkillSelection";
            this.SkillSelection.Size = new System.Drawing.Size(428, 81);
            this.SkillSelection.TabIndex = 18;
            this.SkillSelection.SelectedIndexChanged += new System.EventHandler(this.SkillSelection_SelectedIndexChanged);
            // 
            // Text_DMGPlus
            // 
            this.Text_DMGPlus.AutoSize = true;
            this.Text_DMGPlus.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_DMGPlus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Text_DMGPlus.Location = new System.Drawing.Point(1, 120);
            this.Text_DMGPlus.Name = "Text_DMGPlus";
            this.Text_DMGPlus.Size = new System.Drawing.Size(138, 28);
            this.Text_DMGPlus.TabIndex = 19;
            this.Text_DMGPlus.Text = "伤害提高量：";
            // 
            // DMG_Group
            // 
            this.DMG_Group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DMG_Group.Controls.Add(this.Normal_DMG);
            this.DMG_Group.Controls.Add(this.Crit_DMG);
            this.DMG_Group.Controls.Add(this.Avg_DMG);
            this.DMG_Group.Controls.Add(this.NormalDMG_Text);
            this.DMG_Group.Controls.Add(this.CritDMG_Text);
            this.DMG_Group.Controls.Add(this.AvgDMG_Text);
            this.DMG_Group.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.DMG_Group.Location = new System.Drawing.Point(672, 235);
            this.DMG_Group.Name = "DMG_Group";
            this.DMG_Group.Size = new System.Drawing.Size(218, 128);
            this.DMG_Group.TabIndex = 27;
            this.DMG_Group.TabStop = false;
            this.DMG_Group.Text = "计算输出结果";
            // 
            // Normal_DMG
            // 
            this.Normal_DMG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Normal_DMG.Font = new System.Drawing.Font("方正像素12", 21F);
            this.Normal_DMG.ForeColor = System.Drawing.Color.DarkRed;
            this.Normal_DMG.Location = new System.Drawing.Point(85, 26);
            this.Normal_DMG.Name = "Normal_DMG";
            this.Normal_DMG.Size = new System.Drawing.Size(127, 24);
            this.Normal_DMG.TabIndex = 22;
            this.Normal_DMG.Text = "0";
            this.Normal_DMG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Crit_DMG
            // 
            this.Crit_DMG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Crit_DMG.Font = new System.Drawing.Font("方正像素12", 21F);
            this.Crit_DMG.ForeColor = System.Drawing.Color.DarkRed;
            this.Crit_DMG.Location = new System.Drawing.Point(85, 59);
            this.Crit_DMG.Name = "Crit_DMG";
            this.Crit_DMG.Size = new System.Drawing.Size(127, 24);
            this.Crit_DMG.TabIndex = 23;
            this.Crit_DMG.Text = "0";
            this.Crit_DMG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Avg_DMG
            // 
            this.Avg_DMG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Avg_DMG.Font = new System.Drawing.Font("方正像素12", 21F);
            this.Avg_DMG.ForeColor = System.Drawing.Color.IndianRed;
            this.Avg_DMG.Location = new System.Drawing.Point(85, 92);
            this.Avg_DMG.Name = "Avg_DMG";
            this.Avg_DMG.Size = new System.Drawing.Size(127, 24);
            this.Avg_DMG.TabIndex = 24;
            this.Avg_DMG.Text = "0";
            this.Avg_DMG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NormalDMG_Text
            // 
            this.NormalDMG_Text.AutoSize = true;
            this.NormalDMG_Text.Font = new System.Drawing.Font("方正像素14", 15.75F);
            this.NormalDMG_Text.Location = new System.Drawing.Point(11, 29);
            this.NormalDMG_Text.Name = "NormalDMG_Text";
            this.NormalDMG_Text.Size = new System.Drawing.Size(73, 21);
            this.NormalDMG_Text.TabIndex = 19;
            this.NormalDMG_Text.Text = "未暴击";
            // 
            // CritDMG_Text
            // 
            this.CritDMG_Text.AutoSize = true;
            this.CritDMG_Text.Font = new System.Drawing.Font("方正像素14", 15.75F);
            this.CritDMG_Text.Location = new System.Drawing.Point(11, 62);
            this.CritDMG_Text.Name = "CritDMG_Text";
            this.CritDMG_Text.Size = new System.Drawing.Size(73, 21);
            this.CritDMG_Text.TabIndex = 20;
            this.CritDMG_Text.Text = "已暴击";
            // 
            // AvgDMG_Text
            // 
            this.AvgDMG_Text.AutoSize = true;
            this.AvgDMG_Text.Font = new System.Drawing.Font("方正像素14", 15.75F);
            this.AvgDMG_Text.Location = new System.Drawing.Point(11, 95);
            this.AvgDMG_Text.Name = "AvgDMG_Text";
            this.AvgDMG_Text.Size = new System.Drawing.Size(73, 21);
            this.AvgDMG_Text.TabIndex = 21;
            this.AvgDMG_Text.Text = "平均值";
            // 
            // SkillInput
            // 
            this.SkillInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SkillInput.Controls.Add(this.SkillSelection);
            this.SkillInput.Controls.Add(this.Text_DMGPlus);
            this.SkillInput.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.SkillInput.Location = new System.Drawing.Point(12, 235);
            this.SkillInput.Name = "SkillInput";
            this.SkillInput.Size = new System.Drawing.Size(440, 164);
            this.SkillInput.TabIndex = 28;
            this.SkillInput.TabStop = false;
            this.SkillInput.Text = "技能属性选择";
            // 
            // Skill1
            // 
            this.Skill1.AllowDrop = true;
            this.Skill1.BackColor = System.Drawing.SystemColors.Control;
            this.Skill1.LargeChange = 200;
            this.Skill1.Location = new System.Drawing.Point(320, 123);
            this.Skill1.Maximum = 10000;
            this.Skill1.Name = "Skill1";
            this.Skill1.Size = new System.Drawing.Size(552, 45);
            this.Skill1.TabIndex = 29;
            this.Skill1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Skill1.Value = 1000;
            this.Skill1.Scroll += new System.EventHandler(this.Skill1_Scroll);
            // 
            // Skill_Label
            // 
            this.Skill_Label.AutoSize = true;
            this.Skill_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Skill_Label.Location = new System.Drawing.Point(22, 121);
            this.Skill_Label.Name = "Skill_Label";
            this.Skill_Label.Size = new System.Drawing.Size(295, 28);
            this.Skill_Label.TabIndex = 30;
            this.Skill_Label.Text = "天赋倍率                              %";
            // 
            // Skill
            // 
            this.Skill.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Skill.Location = new System.Drawing.Point(204, 121);
            this.Skill.MaxLength = 8;
            this.Skill.Name = "Skill";
            this.Skill.Size = new System.Drawing.Size(77, 32);
            this.Skill.TabIndex = 31;
            this.Skill.Text = "100";
            this.Skill.TextChanged += new System.EventHandler(this.Skill_TextChanged);
            // 
            // ATK1
            // 
            this.ATK1.AllowDrop = true;
            this.ATK1.BackColor = System.Drawing.SystemColors.Control;
            this.ATK1.LargeChange = 50;
            this.ATK1.Location = new System.Drawing.Point(320, 78);
            this.ATK1.Maximum = 4000;
            this.ATK1.Name = "ATK1";
            this.ATK1.Size = new System.Drawing.Size(552, 45);
            this.ATK1.TabIndex = 33;
            this.ATK1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ATK1.Value = 400;
            this.ATK1.Scroll += new System.EventHandler(this.ATK1_Scroll);
            // 
            // ATK
            // 
            this.ATK.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATK.ForeColor = System.Drawing.Color.Black;
            this.ATK.Location = new System.Drawing.Point(204, 77);
            this.ATK.MaxLength = 4;
            this.ATK.Name = "ATK";
            this.ATK.Size = new System.Drawing.Size(96, 32);
            this.ATK.TabIndex = 32;
            this.ATK.Text = "400";
            this.ATK.TextChanged += new System.EventHandler(this.ATK_TextChanged);
            // 
            // ATK_Label
            // 
            this.ATK_Label.AutoSize = true;
            this.ATK_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ATK_Label.Location = new System.Drawing.Point(22, 77);
            this.ATK_Label.Name = "ATK_Label";
            this.ATK_Label.Size = new System.Drawing.Size(75, 28);
            this.ATK_Label.TabIndex = 34;
            this.ATK_Label.Text = "攻击力";
            // 
            // EnemyRES1
            // 
            this.EnemyRES1.BackColor = System.Drawing.SystemColors.Control;
            this.EnemyRES1.LargeChange = 0;
            this.EnemyRES1.Location = new System.Drawing.Point(320, 168);
            this.EnemyRES1.Maximum = 3000;
            this.EnemyRES1.Name = "EnemyRES1";
            this.EnemyRES1.Size = new System.Drawing.Size(552, 45);
            this.EnemyRES1.SmallChange = 10;
            this.EnemyRES1.TabIndex = 36;
            this.EnemyRES1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.EnemyRES1.Value = 1100;
            this.EnemyRES1.Scroll += new System.EventHandler(this.EnemyRES1_Scroll);
            // 
            // EnemyRES
            // 
            this.EnemyRES.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyRES.Location = new System.Drawing.Point(204, 165);
            this.EnemyRES.MaxLength = 8;
            this.EnemyRES.Name = "EnemyRES";
            this.EnemyRES.Size = new System.Drawing.Size(77, 32);
            this.EnemyRES.TabIndex = 35;
            this.EnemyRES.Text = "10";
            this.EnemyRES.TextChanged += new System.EventHandler(this.EnemyRES_TextChanged);
            // 
            // RES_Label
            // 
            this.RES_Label.AutoSize = true;
            this.RES_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RES_Label.Location = new System.Drawing.Point(22, 165);
            this.RES_Label.Name = "RES_Label";
            this.RES_Label.Size = new System.Drawing.Size(295, 28);
            this.RES_Label.TabIndex = 37;
            this.RES_Label.Text = "敌人相应属性抗性                %";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.HP_Label);
            this.groupBox1.Controls.Add(this.EnemyRES1);
            this.groupBox1.Controls.Add(this.EnemyRES);
            this.groupBox1.Controls.Add(this.Skill1);
            this.groupBox1.Controls.Add(this.RES_Label);
            this.groupBox1.Controls.Add(this.HP);
            this.groupBox1.Controls.Add(this.ATK1);
            this.groupBox1.Controls.Add(this.HP1);
            this.groupBox1.Controls.Add(this.ATK);
            this.groupBox1.Controls.Add(this.Skill);
            this.groupBox1.Controls.Add(this.ATK_Label);
            this.groupBox1.Controls.Add(this.Skill_Label);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 217);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本属性填写";
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Font = new System.Drawing.Font("微软雅黑", 13.5F);
            this.ExitButton.Location = new System.Drawing.Point(672, 369);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(218, 30);
            this.ExitButton.TabIndex = 38;
            this.ExitButton.Text = "完成并退出";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // BuffGroup
            // 
            this.BuffGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuffGroup.Controls.Add(this.Other_Buff);
            this.BuffGroup.Controls.Add(this.Other_buff_Text);
            this.BuffGroup.Controls.Add(this.Geo_Buff);
            this.BuffGroup.Controls.Add(this.Phys_Buff);
            this.BuffGroup.Controls.Add(this.Geo_Buff_Text);
            this.BuffGroup.Controls.Add(this.Phys_Buff_Text);
            this.BuffGroup.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.BuffGroup.Location = new System.Drawing.Point(458, 235);
            this.BuffGroup.Name = "BuffGroup";
            this.BuffGroup.Size = new System.Drawing.Size(208, 161);
            this.BuffGroup.TabIndex = 28;
            this.BuffGroup.TabStop = false;
            this.BuffGroup.Text = "属性伤害加成";
            // 
            // Other_Buff
            // 
            this.Other_Buff.Font = new System.Drawing.Font("Consolas", 14.75F);
            this.Other_Buff.Location = new System.Drawing.Point(99, 118);
            this.Other_Buff.MaxLength = 4;
            this.Other_Buff.Name = "Other_Buff";
            this.Other_Buff.Size = new System.Drawing.Size(67, 31);
            this.Other_Buff.TabIndex = 42;
            this.Other_Buff.Text = "0";
            this.Other_Buff.TextChanged += new System.EventHandler(this.Other_Buff_TextChanged);
            // 
            // Other_buff_Text
            // 
            this.Other_buff_Text.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Other_buff_Text.Location = new System.Drawing.Point(6, 118);
            this.Other_buff_Text.Name = "Other_buff_Text";
            this.Other_buff_Text.Size = new System.Drawing.Size(196, 28);
            this.Other_buff_Text.TabIndex = 41;
            this.Other_buff_Text.Text = "其他加成             %";
            this.Other_buff_Text.Click += new System.EventHandler(this.Other_buff_Text_Click);
            // 
            // Geo_Buff
            // 
            this.Geo_Buff.Font = new System.Drawing.Font("Consolas", 14.75F);
            this.Geo_Buff.Location = new System.Drawing.Point(99, 76);
            this.Geo_Buff.MaxLength = 4;
            this.Geo_Buff.Name = "Geo_Buff";
            this.Geo_Buff.Size = new System.Drawing.Size(67, 31);
            this.Geo_Buff.TabIndex = 40;
            this.Geo_Buff.Text = "61.6";
            this.Geo_Buff.TextChanged += new System.EventHandler(this.Geo_Buff_TextChanged);
            // 
            // Phys_Buff
            // 
            this.Phys_Buff.Font = new System.Drawing.Font("Consolas", 14.75F);
            this.Phys_Buff.Location = new System.Drawing.Point(99, 34);
            this.Phys_Buff.MaxLength = 4;
            this.Phys_Buff.Name = "Phys_Buff";
            this.Phys_Buff.Size = new System.Drawing.Size(67, 31);
            this.Phys_Buff.TabIndex = 38;
            this.Phys_Buff.Text = "0";
            this.Phys_Buff.TextChanged += new System.EventHandler(this.Phys_Buff_TextChanged);
            // 
            // Geo_Buff_Text
            // 
            this.Geo_Buff_Text.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Geo_Buff_Text.Location = new System.Drawing.Point(6, 76);
            this.Geo_Buff_Text.Name = "Geo_Buff_Text";
            this.Geo_Buff_Text.Size = new System.Drawing.Size(196, 28);
            this.Geo_Buff_Text.TabIndex = 39;
            this.Geo_Buff_Text.Text = "岩伤加成             %";
            // 
            // Phys_Buff_Text
            // 
            this.Phys_Buff_Text.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Phys_Buff_Text.Location = new System.Drawing.Point(6, 34);
            this.Phys_Buff_Text.Name = "Phys_Buff_Text";
            this.Phys_Buff_Text.Size = new System.Drawing.Size(196, 28);
            this.Phys_Buff_Text.TabIndex = 38;
            this.Phys_Buff_Text.Text = "物伤加成             %";
            // 
            // Zhongli_Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(902, 408);
            this.Controls.Add(this.BuffGroup);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SkillInput);
            this.Controls.Add(this.DMG_Group);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Zhongli_Calc";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "生命值增加伤害计算（适用于钟离）";
            ((System.ComponentModel.ISupportInitialize)(this.HP1)).EndInit();
            this.DMG_Group.ResumeLayout(false);
            this.DMG_Group.PerformLayout();
            this.SkillInput.ResumeLayout(false);
            this.SkillInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Skill1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATK1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyRES1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.BuffGroup.ResumeLayout(false);
            this.BuffGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar HP1;
        private System.Windows.Forms.TextBox HP;
        private System.Windows.Forms.Label HP_Label;
        private System.Windows.Forms.ListBox SkillSelection;
        private System.Windows.Forms.Label Text_DMGPlus;
        private System.Windows.Forms.GroupBox DMG_Group;
        private System.Windows.Forms.Label Normal_DMG;
        private System.Windows.Forms.Label Crit_DMG;
        private System.Windows.Forms.Label Avg_DMG;
        private System.Windows.Forms.Label NormalDMG_Text;
        private System.Windows.Forms.Label CritDMG_Text;
        private System.Windows.Forms.Label AvgDMG_Text;
        private System.Windows.Forms.GroupBox SkillInput;
        private System.Windows.Forms.TrackBar Skill1;
        private System.Windows.Forms.Label Skill_Label;
        private System.Windows.Forms.TextBox Skill;
        private System.Windows.Forms.TrackBar ATK1;
        private System.Windows.Forms.TextBox ATK;
        private System.Windows.Forms.Label ATK_Label;
        private System.Windows.Forms.TrackBar EnemyRES1;
        private System.Windows.Forms.TextBox EnemyRES;
        private System.Windows.Forms.Label RES_Label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox BuffGroup;
        private System.Windows.Forms.Label Geo_Buff_Text;
        private System.Windows.Forms.Label Phys_Buff_Text;
        private System.Windows.Forms.TextBox Geo_Buff;
        private System.Windows.Forms.TextBox Phys_Buff;
        private System.Windows.Forms.TextBox Other_Buff;
        private System.Windows.Forms.Label Other_buff_Text;
    }
}