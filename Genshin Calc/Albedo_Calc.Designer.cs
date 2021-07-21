using System;

namespace Genshin_Calc
{
    partial class Albedo_Calc
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
            this.DEFInput_Box = new System.Windows.Forms.GroupBox();
            this.GeoRES = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GeoBuff = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PlayerDEFBasic_Text = new System.Windows.Forms.Label();
            this.PlayerDEF = new System.Windows.Forms.TextBox();
            this.PlayerDEF1 = new System.Windows.Forms.TrackBar();
            this.PlayerDEF_Text = new System.Windows.Forms.Label();
            this.PlayerDEFBasic1 = new System.Windows.Forms.TrackBar();
            this.PlayerDEFBasic = new System.Windows.Forms.TextBox();
            this.ElemSkill_Box = new System.Windows.Forms.GroupBox();
            this.EnemyHP_Check = new System.Windows.Forms.CheckBox();
            this.SkillB = new System.Windows.Forms.Label();
            this.SkillA = new System.Windows.Forms.Label();
            this.SkillMultiplier_Label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SB_Normal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SB_Crit = new System.Windows.Forms.Label();
            this.SB_Avg = new System.Windows.Forms.Label();
            this.SA_Normal = new System.Windows.Forms.Label();
            this.SA_Crit = new System.Windows.Forms.Label();
            this.SkillB_Label = new System.Windows.Forms.Label();
            this.SA_Avg = new System.Windows.Forms.Label();
            this.Skill_Level_Label = new System.Windows.Forms.Label();
            this.SkillA_Label = new System.Windows.Forms.Label();
            this.Skill_Level = new System.Windows.Forms.DomainUpDown();
            this.Constellation_Check = new System.Windows.Forms.CheckBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ElemBurst_Box = new System.Windows.Forms.GroupBox();
            this.BurstCount_Label = new System.Windows.Forms.Label();
            this.BurstCount = new System.Windows.Forms.DomainUpDown();
            this.BurstB = new System.Windows.Forms.Label();
            this.BurstA = new System.Windows.Forms.Label();
            this.BurstMultiplier_Label = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.BB_Normal = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.BB_Crit = new System.Windows.Forms.Label();
            this.BB_Avg = new System.Windows.Forms.Label();
            this.BA_Normal = new System.Windows.Forms.Label();
            this.BA_Crit = new System.Windows.Forms.Label();
            this.BurstB_Label = new System.Windows.Forms.Label();
            this.BA_Avg = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.BurstA_Label = new System.Windows.Forms.Label();
            this.Burst_Level = new System.Windows.Forms.DomainUpDown();
            this.DEFInput_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDEF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDEFBasic1)).BeginInit();
            this.ElemSkill_Box.SuspendLayout();
            this.ElemBurst_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // DEFInput_Box
            // 
            this.DEFInput_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DEFInput_Box.Controls.Add(this.GeoRES);
            this.DEFInput_Box.Controls.Add(this.label8);
            this.DEFInput_Box.Controls.Add(this.GeoBuff);
            this.DEFInput_Box.Controls.Add(this.label6);
            this.DEFInput_Box.Controls.Add(this.PlayerDEFBasic_Text);
            this.DEFInput_Box.Controls.Add(this.PlayerDEF);
            this.DEFInput_Box.Controls.Add(this.PlayerDEF1);
            this.DEFInput_Box.Controls.Add(this.PlayerDEF_Text);
            this.DEFInput_Box.Controls.Add(this.PlayerDEFBasic1);
            this.DEFInput_Box.Controls.Add(this.PlayerDEFBasic);
            this.DEFInput_Box.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.DEFInput_Box.Location = new System.Drawing.Point(12, 12);
            this.DEFInput_Box.Name = "DEFInput_Box";
            this.DEFInput_Box.Size = new System.Drawing.Size(980, 151);
            this.DEFInput_Box.TabIndex = 24;
            this.DEFInput_Box.TabStop = false;
            this.DEFInput_Box.Text = "防御属性填写";
            // 
            // GeoRES
            // 
            this.GeoRES.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeoRES.Location = new System.Drawing.Point(867, 94);
            this.GeoRES.MaxLength = 6;
            this.GeoRES.Name = "GeoRES";
            this.GeoRES.Size = new System.Drawing.Size(67, 32);
            this.GeoRES.TabIndex = 38;
            this.GeoRES.Text = "10";
            this.GeoRES.TextChanged += new System.EventHandler(this.ContentChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(768, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 28);
            this.label8.TabIndex = 39;
            this.label8.Text = "敌方岩抗              %";
            // 
            // GeoBuff
            // 
            this.GeoBuff.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeoBuff.Location = new System.Drawing.Point(867, 41);
            this.GeoBuff.MaxLength = 5;
            this.GeoBuff.Name = "GeoBuff";
            this.GeoBuff.Size = new System.Drawing.Size(67, 32);
            this.GeoBuff.TabIndex = 34;
            this.GeoBuff.Text = "0";
            this.GeoBuff.TextChanged += new System.EventHandler(this.ContentChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(768, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 28);
            this.label6.TabIndex = 35;
            this.label6.Text = "岩伤加成              %";
            // 
            // PlayerDEFBasic_Text
            // 
            this.PlayerDEFBasic_Text.AutoSize = true;
            this.PlayerDEFBasic_Text.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PlayerDEFBasic_Text.Location = new System.Drawing.Point(10, 43);
            this.PlayerDEFBasic_Text.Name = "PlayerDEFBasic_Text";
            this.PlayerDEFBasic_Text.Size = new System.Drawing.Size(117, 28);
            this.PlayerDEFBasic_Text.TabIndex = 16;
            this.PlayerDEFBasic_Text.Text = "白字防御力";
            // 
            // PlayerDEF
            // 
            this.PlayerDEF.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerDEF.Location = new System.Drawing.Point(145, 96);
            this.PlayerDEF.Name = "PlayerDEF";
            this.PlayerDEF.Size = new System.Drawing.Size(86, 32);
            this.PlayerDEF.TabIndex = 3;
            this.PlayerDEF.Text = "0";
            this.PlayerDEF.TextChanged += new System.EventHandler(this.PlayerDEFB_TextChanged);
            // 
            // PlayerDEF1
            // 
            this.PlayerDEF1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerDEF1.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerDEF1.LargeChange = 20;
            this.PlayerDEF1.Location = new System.Drawing.Point(260, 96);
            this.PlayerDEF1.Maximum = 3000;
            this.PlayerDEF1.Name = "PlayerDEF1";
            this.PlayerDEF1.Size = new System.Drawing.Size(466, 45);
            this.PlayerDEF1.TabIndex = 4;
            this.PlayerDEF1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.PlayerDEF1.Scroll += new System.EventHandler(this.PlayerDEFB_Scroll);
            // 
            // PlayerDEF_Text
            // 
            this.PlayerDEF_Text.AutoSize = true;
            this.PlayerDEF_Text.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PlayerDEF_Text.Location = new System.Drawing.Point(10, 96);
            this.PlayerDEF_Text.Name = "PlayerDEF_Text";
            this.PlayerDEF_Text.Size = new System.Drawing.Size(117, 28);
            this.PlayerDEF_Text.TabIndex = 11;
            this.PlayerDEF_Text.Text = "绿字防御力";
            // 
            // PlayerDEFBasic1
            // 
            this.PlayerDEFBasic1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerDEFBasic1.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerDEFBasic1.LargeChange = 20;
            this.PlayerDEFBasic1.Location = new System.Drawing.Point(260, 43);
            this.PlayerDEFBasic1.Maximum = 1000;
            this.PlayerDEFBasic1.Name = "PlayerDEFBasic1";
            this.PlayerDEFBasic1.Size = new System.Drawing.Size(466, 45);
            this.PlayerDEFBasic1.TabIndex = 2;
            this.PlayerDEFBasic1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.PlayerDEFBasic1.Scroll += new System.EventHandler(this.PlayerDEFA_Scroll);
            // 
            // PlayerDEFBasic
            // 
            this.PlayerDEFBasic.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerDEFBasic.Location = new System.Drawing.Point(145, 43);
            this.PlayerDEFBasic.Name = "PlayerDEFBasic";
            this.PlayerDEFBasic.Size = new System.Drawing.Size(86, 32);
            this.PlayerDEFBasic.TabIndex = 1;
            this.PlayerDEFBasic.Text = "0";
            this.PlayerDEFBasic.TextChanged += new System.EventHandler(this.PlayerDEFA_TextChanged);
            // 
            // ElemSkill_Box
            // 
            this.ElemSkill_Box.Controls.Add(this.EnemyHP_Check);
            this.ElemSkill_Box.Controls.Add(this.SkillB);
            this.ElemSkill_Box.Controls.Add(this.SkillA);
            this.ElemSkill_Box.Controls.Add(this.SkillMultiplier_Label);
            this.ElemSkill_Box.Controls.Add(this.label11);
            this.ElemSkill_Box.Controls.Add(this.label12);
            this.ElemSkill_Box.Controls.Add(this.SB_Normal);
            this.ElemSkill_Box.Controls.Add(this.label13);
            this.ElemSkill_Box.Controls.Add(this.SB_Crit);
            this.ElemSkill_Box.Controls.Add(this.SB_Avg);
            this.ElemSkill_Box.Controls.Add(this.SA_Normal);
            this.ElemSkill_Box.Controls.Add(this.SA_Crit);
            this.ElemSkill_Box.Controls.Add(this.SkillB_Label);
            this.ElemSkill_Box.Controls.Add(this.SA_Avg);
            this.ElemSkill_Box.Controls.Add(this.Skill_Level_Label);
            this.ElemSkill_Box.Controls.Add(this.SkillA_Label);
            this.ElemSkill_Box.Controls.Add(this.Skill_Level);
            this.ElemSkill_Box.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.ElemSkill_Box.Location = new System.Drawing.Point(12, 169);
            this.ElemSkill_Box.Name = "ElemSkill_Box";
            this.ElemSkill_Box.Size = new System.Drawing.Size(487, 288);
            this.ElemSkill_Box.TabIndex = 25;
            this.ElemSkill_Box.TabStop = false;
            this.ElemSkill_Box.Text = "元素战技";
            // 
            // EnemyHP_Check
            // 
            this.EnemyHP_Check.Appearance = System.Windows.Forms.Appearance.Button;
            this.EnemyHP_Check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EnemyHP_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnemyHP_Check.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.EnemyHP_Check.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EnemyHP_Check.Location = new System.Drawing.Point(15, 33);
            this.EnemyHP_Check.Name = "EnemyHP_Check";
            this.EnemyHP_Check.Size = new System.Drawing.Size(460, 32);
            this.EnemyHP_Check.TabIndex = 10;
            this.EnemyHP_Check.Text = "触发固定天赋1（对半血以下敌人伤害+25%）";
            this.EnemyHP_Check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnemyHP_Check.UseVisualStyleBackColor = true;
            this.EnemyHP_Check.CheckedChanged += new System.EventHandler(this.ContentChanged);
            // 
            // SkillB
            // 
            this.SkillB.AutoSize = true;
            this.SkillB.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.SkillB.Location = new System.Drawing.Point(337, 126);
            this.SkillB.Name = "SkillB";
            this.SkillB.Size = new System.Drawing.Size(22, 24);
            this.SkillB.TabIndex = 52;
            this.SkillB.Text = "0";
            // 
            // SkillA
            // 
            this.SkillA.AutoSize = true;
            this.SkillA.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.SkillA.Location = new System.Drawing.Point(196, 126);
            this.SkillA.Name = "SkillA";
            this.SkillA.Size = new System.Drawing.Size(22, 24);
            this.SkillA.TabIndex = 51;
            this.SkillA.Text = "0";
            // 
            // SkillMultiplier_Label
            // 
            this.SkillMultiplier_Label.AutoSize = true;
            this.SkillMultiplier_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.SkillMultiplier_Label.Location = new System.Drawing.Point(69, 124);
            this.SkillMultiplier_Label.Name = "SkillMultiplier_Label";
            this.SkillMultiplier_Label.Size = new System.Drawing.Size(96, 28);
            this.SkillMultiplier_Label.TabIndex = 50;
            this.SkillMultiplier_Label.Text = "技能倍率";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.label11.Location = new System.Drawing.Point(90, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 28);
            this.label11.TabIndex = 22;
            this.label11.Text = "未暴击";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.label12.Location = new System.Drawing.Point(90, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 28);
            this.label12.TabIndex = 23;
            this.label12.Text = "已暴击";
            // 
            // SB_Normal
            // 
            this.SB_Normal.Font = new System.Drawing.Font("方正像素12", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SB_Normal.ForeColor = System.Drawing.Color.DarkRed;
            this.SB_Normal.Location = new System.Drawing.Point(337, 162);
            this.SB_Normal.Name = "SB_Normal";
            this.SB_Normal.Size = new System.Drawing.Size(128, 24);
            this.SB_Normal.TabIndex = 47;
            this.SB_Normal.Text = "0";
            this.SB_Normal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.label13.Location = new System.Drawing.Point(90, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 28);
            this.label13.TabIndex = 24;
            this.label13.Text = "平均值";
            // 
            // SB_Crit
            // 
            this.SB_Crit.Font = new System.Drawing.Font("方正像素12", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SB_Crit.ForeColor = System.Drawing.Color.DarkRed;
            this.SB_Crit.Location = new System.Drawing.Point(337, 205);
            this.SB_Crit.Name = "SB_Crit";
            this.SB_Crit.Size = new System.Drawing.Size(128, 24);
            this.SB_Crit.TabIndex = 48;
            this.SB_Crit.Text = "0";
            this.SB_Crit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SB_Avg
            // 
            this.SB_Avg.Font = new System.Drawing.Font("方正像素12", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SB_Avg.ForeColor = System.Drawing.Color.IndianRed;
            this.SB_Avg.Location = new System.Drawing.Point(337, 248);
            this.SB_Avg.Name = "SB_Avg";
            this.SB_Avg.Size = new System.Drawing.Size(128, 24);
            this.SB_Avg.TabIndex = 49;
            this.SB_Avg.Text = "0";
            this.SB_Avg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SA_Normal
            // 
            this.SA_Normal.Font = new System.Drawing.Font("方正像素12", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SA_Normal.ForeColor = System.Drawing.Color.DarkRed;
            this.SA_Normal.Location = new System.Drawing.Point(196, 162);
            this.SA_Normal.Name = "SA_Normal";
            this.SA_Normal.Size = new System.Drawing.Size(128, 24);
            this.SA_Normal.TabIndex = 22;
            this.SA_Normal.Text = "0";
            this.SA_Normal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SA_Crit
            // 
            this.SA_Crit.Font = new System.Drawing.Font("方正像素12", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SA_Crit.ForeColor = System.Drawing.Color.DarkRed;
            this.SA_Crit.Location = new System.Drawing.Point(196, 205);
            this.SA_Crit.Name = "SA_Crit";
            this.SA_Crit.Size = new System.Drawing.Size(128, 24);
            this.SA_Crit.TabIndex = 23;
            this.SA_Crit.Text = "0";
            this.SA_Crit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SkillB_Label
            // 
            this.SkillB_Label.AutoSize = true;
            this.SkillB_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SkillB_Label.Location = new System.Drawing.Point(337, 81);
            this.SkillB_Label.Name = "SkillB_Label";
            this.SkillB_Label.Size = new System.Drawing.Size(138, 28);
            this.SkillB_Label.TabIndex = 35;
            this.SkillB_Label.Text = "刹那之花伤害";
            // 
            // SA_Avg
            // 
            this.SA_Avg.Font = new System.Drawing.Font("方正像素12", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SA_Avg.ForeColor = System.Drawing.Color.IndianRed;
            this.SA_Avg.Location = new System.Drawing.Point(196, 248);
            this.SA_Avg.Name = "SA_Avg";
            this.SA_Avg.Size = new System.Drawing.Size(128, 24);
            this.SA_Avg.TabIndex = 24;
            this.SA_Avg.Text = "0";
            this.SA_Avg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Skill_Level_Label
            // 
            this.Skill_Level_Label.AutoSize = true;
            this.Skill_Level_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Skill_Level_Label.Location = new System.Drawing.Point(10, 81);
            this.Skill_Level_Label.Name = "Skill_Level_Label";
            this.Skill_Level_Label.Size = new System.Drawing.Size(96, 28);
            this.Skill_Level_Label.TabIndex = 40;
            this.Skill_Level_Label.Text = "技能等级";
            // 
            // SkillA_Label
            // 
            this.SkillA_Label.AutoSize = true;
            this.SkillA_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SkillA_Label.Location = new System.Drawing.Point(196, 81);
            this.SkillA_Label.Name = "SkillA_Label";
            this.SkillA_Label.Size = new System.Drawing.Size(96, 28);
            this.SkillA_Label.TabIndex = 34;
            this.SkillA_Label.Text = "技能伤害";
            // 
            // Skill_Level
            // 
            this.Skill_Level.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Skill_Level.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Skill_Level.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.Skill_Level.Items.Add("13");
            this.Skill_Level.Items.Add("12");
            this.Skill_Level.Items.Add("11");
            this.Skill_Level.Items.Add("10");
            this.Skill_Level.Items.Add("9");
            this.Skill_Level.Items.Add("8");
            this.Skill_Level.Items.Add("7");
            this.Skill_Level.Items.Add("6");
            this.Skill_Level.Items.Add("5");
            this.Skill_Level.Items.Add("4");
            this.Skill_Level.Items.Add("3");
            this.Skill_Level.Items.Add("2");
            this.Skill_Level.Items.Add("1");
            this.Skill_Level.Location = new System.Drawing.Point(108, 80);
            this.Skill_Level.Name = "Skill_Level";
            this.Skill_Level.ReadOnly = true;
            this.Skill_Level.Size = new System.Drawing.Size(59, 30);
            this.Skill_Level.TabIndex = 11;
            this.Skill_Level.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Skill_Level.SelectedItemChanged += new System.EventHandler(this.Skill_Level_SelectedItemChanged);
            // 
            // Constellation_Check
            // 
            this.Constellation_Check.Appearance = System.Windows.Forms.Appearance.Button;
            this.Constellation_Check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Constellation_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Constellation_Check.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.Constellation_Check.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Constellation_Check.Location = new System.Drawing.Point(15, 33);
            this.Constellation_Check.Name = "Constellation_Check";
            this.Constellation_Check.Size = new System.Drawing.Size(293, 32);
            this.Constellation_Check.TabIndex = 20;
            this.Constellation_Check.Text = "解锁第二命座「显生之宙」";
            this.Constellation_Check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Constellation_Check.UseVisualStyleBackColor = true;
            this.Constellation_Check.CheckedChanged += new System.EventHandler(this.Constellation_Check_CheckedChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.ExitButton.Location = new System.Drawing.Point(11, 463);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(982, 34);
            this.ExitButton.TabIndex = 50;
            this.ExitButton.Text = "完成并退出";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ElemBurst_Box
            // 
            this.ElemBurst_Box.Controls.Add(this.BurstCount_Label);
            this.ElemBurst_Box.Controls.Add(this.BurstCount);
            this.ElemBurst_Box.Controls.Add(this.BurstB);
            this.ElemBurst_Box.Controls.Add(this.BurstA);
            this.ElemBurst_Box.Controls.Add(this.BurstMultiplier_Label);
            this.ElemBurst_Box.Controls.Add(this.label20);
            this.ElemBurst_Box.Controls.Add(this.label21);
            this.ElemBurst_Box.Controls.Add(this.BB_Normal);
            this.ElemBurst_Box.Controls.Add(this.label23);
            this.ElemBurst_Box.Controls.Add(this.BB_Crit);
            this.ElemBurst_Box.Controls.Add(this.BB_Avg);
            this.ElemBurst_Box.Controls.Add(this.BA_Normal);
            this.ElemBurst_Box.Controls.Add(this.BA_Crit);
            this.ElemBurst_Box.Controls.Add(this.BurstB_Label);
            this.ElemBurst_Box.Controls.Add(this.BA_Avg);
            this.ElemBurst_Box.Controls.Add(this.label30);
            this.ElemBurst_Box.Controls.Add(this.BurstA_Label);
            this.ElemBurst_Box.Controls.Add(this.Burst_Level);
            this.ElemBurst_Box.Controls.Add(this.Constellation_Check);
            this.ElemBurst_Box.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.ElemBurst_Box.Location = new System.Drawing.Point(505, 169);
            this.ElemBurst_Box.Name = "ElemBurst_Box";
            this.ElemBurst_Box.Size = new System.Drawing.Size(487, 288);
            this.ElemBurst_Box.TabIndex = 32;
            this.ElemBurst_Box.TabStop = false;
            this.ElemBurst_Box.Text = "元素爆发";
            // 
            // BurstCount_Label
            // 
            this.BurstCount_Label.AutoSize = true;
            this.BurstCount_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BurstCount_Label.Location = new System.Drawing.Point(314, 35);
            this.BurstCount_Label.Name = "BurstCount_Label";
            this.BurstCount_Label.Size = new System.Drawing.Size(96, 28);
            this.BurstCount_Label.TabIndex = 69;
            this.BurstCount_Label.Text = "生灭计数";
            // 
            // BurstCount
            // 
            this.BurstCount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BurstCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BurstCount.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.BurstCount.Items.Add("4");
            this.BurstCount.Items.Add("3");
            this.BurstCount.Items.Add("2");
            this.BurstCount.Items.Add("1");
            this.BurstCount.Items.Add("0");
            this.BurstCount.Location = new System.Drawing.Point(412, 34);
            this.BurstCount.Name = "BurstCount";
            this.BurstCount.ReadOnly = true;
            this.BurstCount.Size = new System.Drawing.Size(59, 30);
            this.BurstCount.TabIndex = 21;
            this.BurstCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BurstCount.TextChanged += new System.EventHandler(this.ContentChanged);
            // 
            // BurstB
            // 
            this.BurstB.AutoSize = true;
            this.BurstB.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.BurstB.Location = new System.Drawing.Point(337, 126);
            this.BurstB.Name = "BurstB";
            this.BurstB.Size = new System.Drawing.Size(22, 24);
            this.BurstB.TabIndex = 68;
            this.BurstB.Text = "0";
            // 
            // BurstA
            // 
            this.BurstA.AutoSize = true;
            this.BurstA.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.BurstA.Location = new System.Drawing.Point(196, 126);
            this.BurstA.Name = "BurstA";
            this.BurstA.Size = new System.Drawing.Size(22, 24);
            this.BurstA.TabIndex = 67;
            this.BurstA.Text = "0";
            // 
            // BurstMultiplier_Label
            // 
            this.BurstMultiplier_Label.AutoSize = true;
            this.BurstMultiplier_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.BurstMultiplier_Label.Location = new System.Drawing.Point(69, 124);
            this.BurstMultiplier_Label.Name = "BurstMultiplier_Label";
            this.BurstMultiplier_Label.Size = new System.Drawing.Size(96, 28);
            this.BurstMultiplier_Label.TabIndex = 66;
            this.BurstMultiplier_Label.Text = "技能倍率";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.label20.Location = new System.Drawing.Point(90, 160);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 28);
            this.label20.TabIndex = 53;
            this.label20.Text = "未暴击";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.label21.Location = new System.Drawing.Point(90, 203);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 28);
            this.label21.TabIndex = 55;
            this.label21.Text = "已暴击";
            // 
            // BB_Normal
            // 
            this.BB_Normal.Font = new System.Drawing.Font("方正像素12", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BB_Normal.ForeColor = System.Drawing.Color.DarkRed;
            this.BB_Normal.Location = new System.Drawing.Point(337, 162);
            this.BB_Normal.Name = "BB_Normal";
            this.BB_Normal.Size = new System.Drawing.Size(128, 24);
            this.BB_Normal.TabIndex = 63;
            this.BB_Normal.Text = "0";
            this.BB_Normal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.label23.Location = new System.Drawing.Point(90, 246);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(75, 28);
            this.label23.TabIndex = 57;
            this.label23.Text = "平均值";
            // 
            // BB_Crit
            // 
            this.BB_Crit.Font = new System.Drawing.Font("方正像素12", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BB_Crit.ForeColor = System.Drawing.Color.DarkRed;
            this.BB_Crit.Location = new System.Drawing.Point(337, 205);
            this.BB_Crit.Name = "BB_Crit";
            this.BB_Crit.Size = new System.Drawing.Size(128, 24);
            this.BB_Crit.TabIndex = 64;
            this.BB_Crit.Text = "0";
            this.BB_Crit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BB_Avg
            // 
            this.BB_Avg.Font = new System.Drawing.Font("方正像素12", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BB_Avg.ForeColor = System.Drawing.Color.IndianRed;
            this.BB_Avg.Location = new System.Drawing.Point(337, 248);
            this.BB_Avg.Name = "BB_Avg";
            this.BB_Avg.Size = new System.Drawing.Size(128, 24);
            this.BB_Avg.TabIndex = 65;
            this.BB_Avg.Text = "0";
            this.BB_Avg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BA_Normal
            // 
            this.BA_Normal.Font = new System.Drawing.Font("方正像素12", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BA_Normal.ForeColor = System.Drawing.Color.DarkRed;
            this.BA_Normal.Location = new System.Drawing.Point(196, 162);
            this.BA_Normal.Name = "BA_Normal";
            this.BA_Normal.Size = new System.Drawing.Size(128, 24);
            this.BA_Normal.TabIndex = 54;
            this.BA_Normal.Text = "0";
            this.BA_Normal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BA_Crit
            // 
            this.BA_Crit.Font = new System.Drawing.Font("方正像素12", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BA_Crit.ForeColor = System.Drawing.Color.DarkRed;
            this.BA_Crit.Location = new System.Drawing.Point(196, 205);
            this.BA_Crit.Name = "BA_Crit";
            this.BA_Crit.Size = new System.Drawing.Size(128, 24);
            this.BA_Crit.TabIndex = 56;
            this.BA_Crit.Text = "0";
            this.BA_Crit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BurstB_Label
            // 
            this.BurstB_Label.AutoSize = true;
            this.BurstB_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BurstB_Label.Location = new System.Drawing.Point(337, 81);
            this.BurstB_Label.Name = "BurstB_Label";
            this.BurstB_Label.Size = new System.Drawing.Size(138, 28);
            this.BurstB_Label.TabIndex = 60;
            this.BurstB_Label.Text = "生灭之花伤害";
            // 
            // BA_Avg
            // 
            this.BA_Avg.Font = new System.Drawing.Font("方正像素12", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BA_Avg.ForeColor = System.Drawing.Color.IndianRed;
            this.BA_Avg.Location = new System.Drawing.Point(196, 248);
            this.BA_Avg.Name = "BA_Avg";
            this.BA_Avg.Size = new System.Drawing.Size(128, 24);
            this.BA_Avg.TabIndex = 58;
            this.BA_Avg.Text = "0";
            this.BA_Avg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label30.Location = new System.Drawing.Point(10, 81);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(96, 28);
            this.label30.TabIndex = 61;
            this.label30.Text = "技能等级";
            // 
            // BurstA_Label
            // 
            this.BurstA_Label.AutoSize = true;
            this.BurstA_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BurstA_Label.Location = new System.Drawing.Point(196, 81);
            this.BurstA_Label.Name = "BurstA_Label";
            this.BurstA_Label.Size = new System.Drawing.Size(96, 28);
            this.BurstA_Label.TabIndex = 59;
            this.BurstA_Label.Text = "爆发伤害";
            // 
            // Burst_Level
            // 
            this.Burst_Level.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Burst_Level.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Burst_Level.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.Burst_Level.Items.Add("13");
            this.Burst_Level.Items.Add("12");
            this.Burst_Level.Items.Add("11");
            this.Burst_Level.Items.Add("10");
            this.Burst_Level.Items.Add("9");
            this.Burst_Level.Items.Add("8");
            this.Burst_Level.Items.Add("7");
            this.Burst_Level.Items.Add("6");
            this.Burst_Level.Items.Add("5");
            this.Burst_Level.Items.Add("4");
            this.Burst_Level.Items.Add("3");
            this.Burst_Level.Items.Add("2");
            this.Burst_Level.Items.Add("1");
            this.Burst_Level.Location = new System.Drawing.Point(108, 80);
            this.Burst_Level.Name = "Burst_Level";
            this.Burst_Level.ReadOnly = true;
            this.Burst_Level.Size = new System.Drawing.Size(59, 30);
            this.Burst_Level.TabIndex = 22;
            this.Burst_Level.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Burst_Level.SelectedItemChanged += new System.EventHandler(this.Burst_Level_SelectedItemChanged);
            // 
            // Albedo_Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(1004, 507);
            this.Controls.Add(this.ElemBurst_Box);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ElemSkill_Box);
            this.Controls.Add(this.DEFInput_Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Albedo_Calc";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "防御转换/增加伤害计算（当前适用于阿贝多）";
            this.DEFInput_Box.ResumeLayout(false);
            this.DEFInput_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDEF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDEFBasic1)).EndInit();
            this.ElemSkill_Box.ResumeLayout(false);
            this.ElemSkill_Box.PerformLayout();
            this.ElemBurst_Box.ResumeLayout(false);
            this.ElemBurst_Box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DEFInput_Box;
        private System.Windows.Forms.Label PlayerDEFBasic_Text;
        private System.Windows.Forms.TextBox PlayerDEF;
        private System.Windows.Forms.TrackBar PlayerDEF1;
        private System.Windows.Forms.Label PlayerDEF_Text;
        private System.Windows.Forms.TrackBar PlayerDEFBasic1;
        private System.Windows.Forms.TextBox PlayerDEFBasic;
        private System.Windows.Forms.GroupBox ElemSkill_Box;
        private System.Windows.Forms.CheckBox Constellation_Check;
        private System.Windows.Forms.Label SA_Normal;
        private System.Windows.Forms.Label SA_Crit;
        private System.Windows.Forms.Label SA_Avg;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox ElemBurst_Box;
        private System.Windows.Forms.TextBox GeoBuff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GeoRES;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DomainUpDown Skill_Level;
        private System.Windows.Forms.Label SB_Normal;
        private System.Windows.Forms.Label SB_Crit;
        private System.Windows.Forms.Label SB_Avg;
        private System.Windows.Forms.Label SkillB_Label;
        private System.Windows.Forms.Label Skill_Level_Label;
        private System.Windows.Forms.Label SkillA_Label;
        private System.Windows.Forms.Label SkillB;
        private System.Windows.Forms.Label SkillA;
        private System.Windows.Forms.Label SkillMultiplier_Label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label BurstCount_Label;
        private System.Windows.Forms.DomainUpDown BurstCount;
        private System.Windows.Forms.Label BurstB;
        private System.Windows.Forms.Label BurstA;
        private System.Windows.Forms.Label BurstMultiplier_Label;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label BB_Normal;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label BB_Crit;
        private System.Windows.Forms.Label BB_Avg;
        private System.Windows.Forms.Label BA_Normal;
        private System.Windows.Forms.Label BA_Crit;
        private System.Windows.Forms.Label BurstB_Label;
        private System.Windows.Forms.Label BA_Avg;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label BurstA_Label;
        private System.Windows.Forms.DomainUpDown Burst_Level;
        private System.Windows.Forms.CheckBox EnemyHP_Check;
    }
}