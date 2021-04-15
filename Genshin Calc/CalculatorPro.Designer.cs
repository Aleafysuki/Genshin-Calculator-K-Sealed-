namespace Genshin_Calc
{
    partial class CalculatorPro
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
            System.Windows.Forms.Label 备注;
            this.AttributeBox = new System.Windows.Forms.ListBox();
            this.AtkValue = new System.Windows.Forms.TextBox();
            this.CRValue = new System.Windows.Forms.TextBox();
            this.CDValue = new System.Windows.Forms.TextBox();
            this.EMValue = new System.Windows.Forms.TextBox();
            this.DMGBuffValue = new System.Windows.Forms.TextBox();
            this.SkillValue = new System.Windows.Forms.TextBox();
            this.IndiValue = new System.Windows.Forms.TextBox();
            this.PlayerLevelValue = new System.Windows.Forms.TextBox();
            this.EnemyLevelValue = new System.Windows.Forms.TextBox();
            this.EnemyRESValue = new System.Windows.Forms.TextBox();
            this.EnemyDEFValue = new System.Windows.Forms.TextBox();
            this.DmgExpected_Label = new System.Windows.Forms.Label();
            this.DMGExpected = new System.Windows.Forms.TextBox();
            this.Group_1 = new System.Windows.Forms.GroupBox();
            this.ReactBox = new System.Windows.Forms.ComboBox();
            this.ReactBuffValue = new System.Windows.Forms.TextBox();
            this.Attribute_Label = new System.Windows.Forms.Label();
            this.DmgType = new System.Windows.Forms.ComboBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Attribute_Text = new System.Windows.Forms.Label();
            备注 = new System.Windows.Forms.Label();
            this.Group_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 备注
            // 
            备注.Enabled = false;
            备注.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            备注.Location = new System.Drawing.Point(306, 360);
            备注.Name = "备注";
            备注.Size = new System.Drawing.Size(237, 88);
            备注.TabIndex = 23;
            备注.Text = "备注：\r\n由于米忽悠的各项数值存在强行取整，故计算结果存在一定误差。一切以游戏内实测为准。";
            // 
            // AttributeBox
            // 
            this.AttributeBox.BackColor = System.Drawing.SystemColors.Control;
            this.AttributeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AttributeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AttributeBox.Font = new System.Drawing.Font("微软雅黑 Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AttributeBox.FormattingEnabled = true;
            this.AttributeBox.ItemHeight = 31;
            this.AttributeBox.Items.AddRange(new object[] {
            "攻击力",
            "暴击率\t\t%",
            "暴击伤害\t\t%",
            "元素精通",
            "伤害加成\t\t%",
            "天赋倍率\t\t%",
            "额外乘区\t\t%",
            "我方等级",
            "敌方等级",
            "敌人抗性\t\t%",
            "防御变化\t\t%",
            "反应类型",
            "反应增强\t\t%"});
            this.AttributeBox.Location = new System.Drawing.Point(14, 25);
            this.AttributeBox.Name = "AttributeBox";
            this.AttributeBox.Size = new System.Drawing.Size(251, 403);
            this.AttributeBox.TabIndex = 2;
            this.AttributeBox.SelectedIndexChanged += new System.EventHandler(this.Attribute_SelectedIndexChanged);
            // 
            // AtkValue
            // 
            this.AtkValue.AcceptsReturn = true;
            this.AtkValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AtkValue.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.AtkValue.Location = new System.Drawing.Point(137, 24);
            this.AtkValue.Margin = new System.Windows.Forms.Padding(0);
            this.AtkValue.MaxLength = 16;
            this.AtkValue.Name = "AtkValue";
            this.AtkValue.Size = new System.Drawing.Size(94, 32);
            this.AtkValue.TabIndex = 3;
            this.AtkValue.TextChanged += new System.EventHandler(this.AtkValue_TextChanged);
            // 
            // CRValue
            // 
            this.CRValue.AcceptsReturn = true;
            this.CRValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRValue.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.CRValue.Location = new System.Drawing.Point(137, 55);
            this.CRValue.Margin = new System.Windows.Forms.Padding(0);
            this.CRValue.MaxLength = 16;
            this.CRValue.Name = "CRValue";
            this.CRValue.Size = new System.Drawing.Size(94, 32);
            this.CRValue.TabIndex = 4;
            this.CRValue.TextChanged += new System.EventHandler(this.CRValue_TextChanged);
            // 
            // CDValue
            // 
            this.CDValue.AcceptsReturn = true;
            this.CDValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CDValue.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.CDValue.Location = new System.Drawing.Point(137, 86);
            this.CDValue.Margin = new System.Windows.Forms.Padding(0);
            this.CDValue.MaxLength = 16;
            this.CDValue.Name = "CDValue";
            this.CDValue.Size = new System.Drawing.Size(94, 32);
            this.CDValue.TabIndex = 5;
            this.CDValue.TextChanged += new System.EventHandler(this.CDValue_TextChanged);
            // 
            // EMValue
            // 
            this.EMValue.AcceptsReturn = true;
            this.EMValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EMValue.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.EMValue.Location = new System.Drawing.Point(137, 117);
            this.EMValue.Margin = new System.Windows.Forms.Padding(0);
            this.EMValue.MaxLength = 16;
            this.EMValue.Name = "EMValue";
            this.EMValue.Size = new System.Drawing.Size(94, 32);
            this.EMValue.TabIndex = 6;
            this.EMValue.TextChanged += new System.EventHandler(this.EMValue_TextChanged);
            // 
            // DMGBuffValue
            // 
            this.DMGBuffValue.AcceptsReturn = true;
            this.DMGBuffValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DMGBuffValue.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.DMGBuffValue.Location = new System.Drawing.Point(137, 148);
            this.DMGBuffValue.Margin = new System.Windows.Forms.Padding(0);
            this.DMGBuffValue.MaxLength = 16;
            this.DMGBuffValue.Name = "DMGBuffValue";
            this.DMGBuffValue.Size = new System.Drawing.Size(94, 32);
            this.DMGBuffValue.TabIndex = 7;
            this.DMGBuffValue.TextChanged += new System.EventHandler(this.DMGBuffValue_TextChanged);
            // 
            // SkillValue
            // 
            this.SkillValue.AcceptsReturn = true;
            this.SkillValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SkillValue.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.SkillValue.Location = new System.Drawing.Point(137, 179);
            this.SkillValue.Margin = new System.Windows.Forms.Padding(0);
            this.SkillValue.MaxLength = 16;
            this.SkillValue.Name = "SkillValue";
            this.SkillValue.Size = new System.Drawing.Size(94, 32);
            this.SkillValue.TabIndex = 8;
            this.SkillValue.TextChanged += new System.EventHandler(this.SkillValue_TextChanged);
            // 
            // IndiValue
            // 
            this.IndiValue.AcceptsReturn = true;
            this.IndiValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IndiValue.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.IndiValue.Location = new System.Drawing.Point(137, 210);
            this.IndiValue.Margin = new System.Windows.Forms.Padding(0);
            this.IndiValue.MaxLength = 16;
            this.IndiValue.Name = "IndiValue";
            this.IndiValue.Size = new System.Drawing.Size(94, 32);
            this.IndiValue.TabIndex = 9;
            this.IndiValue.TextChanged += new System.EventHandler(this.IndiValue_TextChanged);
            // 
            // PlayerLevelValue
            // 
            this.PlayerLevelValue.AcceptsReturn = true;
            this.PlayerLevelValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerLevelValue.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.PlayerLevelValue.Location = new System.Drawing.Point(137, 241);
            this.PlayerLevelValue.Margin = new System.Windows.Forms.Padding(0);
            this.PlayerLevelValue.MaxLength = 16;
            this.PlayerLevelValue.Name = "PlayerLevelValue";
            this.PlayerLevelValue.Size = new System.Drawing.Size(94, 32);
            this.PlayerLevelValue.TabIndex = 10;
            this.PlayerLevelValue.TextChanged += new System.EventHandler(this.PlayerLevelValue_TextChanged);
            // 
            // EnemyLevelValue
            // 
            this.EnemyLevelValue.AcceptsReturn = true;
            this.EnemyLevelValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnemyLevelValue.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.EnemyLevelValue.Location = new System.Drawing.Point(137, 272);
            this.EnemyLevelValue.Margin = new System.Windows.Forms.Padding(0);
            this.EnemyLevelValue.MaxLength = 16;
            this.EnemyLevelValue.Name = "EnemyLevelValue";
            this.EnemyLevelValue.Size = new System.Drawing.Size(94, 32);
            this.EnemyLevelValue.TabIndex = 11;
            this.EnemyLevelValue.TextChanged += new System.EventHandler(this.EnemyLevelvalue_TextChanged);
            // 
            // EnemyRESValue
            // 
            this.EnemyRESValue.AcceptsReturn = true;
            this.EnemyRESValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnemyRESValue.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.EnemyRESValue.Location = new System.Drawing.Point(137, 303);
            this.EnemyRESValue.Margin = new System.Windows.Forms.Padding(0);
            this.EnemyRESValue.MaxLength = 16;
            this.EnemyRESValue.Name = "EnemyRESValue";
            this.EnemyRESValue.Size = new System.Drawing.Size(94, 32);
            this.EnemyRESValue.TabIndex = 12;
            this.EnemyRESValue.TextChanged += new System.EventHandler(this.EnemyRESValue_TextChanged);
            // 
            // EnemyDEFValue
            // 
            this.EnemyDEFValue.AcceptsReturn = true;
            this.EnemyDEFValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnemyDEFValue.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.EnemyDEFValue.Location = new System.Drawing.Point(137, 334);
            this.EnemyDEFValue.Margin = new System.Windows.Forms.Padding(0);
            this.EnemyDEFValue.MaxLength = 16;
            this.EnemyDEFValue.Name = "EnemyDEFValue";
            this.EnemyDEFValue.Size = new System.Drawing.Size(94, 32);
            this.EnemyDEFValue.TabIndex = 13;
            this.EnemyDEFValue.TextChanged += new System.EventHandler(this.EnemyDEFValue_TextChanged);
            // 
            // DmgExpected_Label
            // 
            this.DmgExpected_Label.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.DmgExpected_Label.Location = new System.Drawing.Point(306, 30);
            this.DmgExpected_Label.Name = "DmgExpected_Label";
            this.DmgExpected_Label.Size = new System.Drawing.Size(237, 35);
            this.DmgExpected_Label.TabIndex = 15;
            this.DmgExpected_Label.Text = "期望达到的伤害值";
            this.DmgExpected_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DMGExpected
            // 
            this.DMGExpected.BackColor = System.Drawing.SystemColors.Control;
            this.DMGExpected.Font = new System.Drawing.Font("方正像素12", 19F);
            this.DMGExpected.Location = new System.Drawing.Point(387, 68);
            this.DMGExpected.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.DMGExpected.MaxLength = 16;
            this.DMGExpected.Name = "DMGExpected";
            this.DMGExpected.Size = new System.Drawing.Size(157, 33);
            this.DMGExpected.TabIndex = 1;
            this.DMGExpected.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DMGExpected.TextChanged += new System.EventHandler(this.DMGExpected_TextChanged);
            // 
            // Group_1
            // 
            this.Group_1.Controls.Add(this.ReactBox);
            this.Group_1.Controls.Add(this.ReactBuffValue);
            this.Group_1.Controls.Add(this.IndiValue);
            this.Group_1.Controls.Add(this.AtkValue);
            this.Group_1.Controls.Add(this.CRValue);
            this.Group_1.Controls.Add(this.EnemyDEFValue);
            this.Group_1.Controls.Add(this.CDValue);
            this.Group_1.Controls.Add(this.EnemyRESValue);
            this.Group_1.Controls.Add(this.EMValue);
            this.Group_1.Controls.Add(this.EnemyLevelValue);
            this.Group_1.Controls.Add(this.DMGBuffValue);
            this.Group_1.Controls.Add(this.PlayerLevelValue);
            this.Group_1.Controls.Add(this.SkillValue);
            this.Group_1.Controls.Add(this.AttributeBox);
            this.Group_1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Group_1.Location = new System.Drawing.Point(12, 8);
            this.Group_1.Name = "Group_1";
            this.Group_1.Size = new System.Drawing.Size(271, 440);
            this.Group_1.TabIndex = 16;
            this.Group_1.TabStop = false;
            this.Group_1.Text = "面板属性";
            // 
            // ReactBox
            // 
            this.ReactBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReactBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ReactBox.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.ReactBox.FormattingEnabled = true;
            this.ReactBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ReactBox.Items.AddRange(new object[] {
            "无",
            "超导",
            "扩散",
            "感电",
            "碎冰",
            "超载",
            "增幅(小)",
            "增幅(大)"});
            this.ReactBox.Location = new System.Drawing.Point(137, 365);
            this.ReactBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.ReactBox.Name = "ReactBox";
            this.ReactBox.Size = new System.Drawing.Size(94, 33);
            this.ReactBox.TabIndex = 23;
            this.ReactBox.SelectedIndexChanged += new System.EventHandler(this.ReactBox_SelectedIndexChanged);
            // 
            // ReactBuffValue
            // 
            this.ReactBuffValue.AcceptsReturn = true;
            this.ReactBuffValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReactBuffValue.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.ReactBuffValue.Location = new System.Drawing.Point(137, 396);
            this.ReactBuffValue.Margin = new System.Windows.Forms.Padding(0);
            this.ReactBuffValue.MaxLength = 16;
            this.ReactBuffValue.Name = "ReactBuffValue";
            this.ReactBuffValue.Size = new System.Drawing.Size(94, 32);
            this.ReactBuffValue.TabIndex = 24;
            this.ReactBuffValue.TextChanged += new System.EventHandler(this.ReactBuffValue_TextChanged);
            // 
            // Attribute_Label
            // 
            this.Attribute_Label.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attribute_Label.Location = new System.Drawing.Point(306, 119);
            this.Attribute_Label.Name = "Attribute_Label";
            this.Attribute_Label.Size = new System.Drawing.Size(237, 70);
            this.Attribute_Label.TabIndex = 18;
            this.Attribute_Label.Text = "欲达到期望伤害\r\n对应属性应变为";
            this.Attribute_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DmgType
            // 
            this.DmgType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DmgType.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DmgType.FormattingEnabled = true;
            this.DmgType.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DmgType.Items.AddRange(new object[] {
            "未暴击",
            "已暴击",
            "平均值"});
            this.DmgType.Location = new System.Drawing.Point(306, 68);
            this.DmgType.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.DmgType.Name = "DmgType";
            this.DmgType.Size = new System.Drawing.Size(81, 33);
            this.DmgType.TabIndex = 20;
            this.DmgType.SelectedIndexChanged += new System.EventHandler(this.DmgType_SelectedIndexChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.ExitButton.Location = new System.Drawing.Point(305, 320);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(238, 37);
            this.ExitButton.TabIndex = 21;
            this.ExitButton.Text = "完成并退出";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Attribute_Text
            // 
            this.Attribute_Text.Font = new System.Drawing.Font("方正像素12", 21F);
            this.Attribute_Text.Location = new System.Drawing.Point(306, 189);
            this.Attribute_Text.Name = "Attribute_Text";
            this.Attribute_Text.Size = new System.Drawing.Size(236, 128);
            this.Attribute_Text.TabIndex = 22;
            this.Attribute_Text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CalculatorPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(562, 458);
            this.Controls.Add(备注);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DmgType);
            this.Controls.Add(this.Attribute_Label);
            this.Controls.Add(this.DMGExpected);
            this.Controls.Add(this.DmgExpected_Label);
            this.Controls.Add(this.Group_1);
            this.Controls.Add(this.Attribute_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalculatorPro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "伤害锚定计算";
            this.Load += new System.EventHandler(this.CalculatorPro_Load);
            this.Group_1.ResumeLayout(false);
            this.Group_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox AttributeBox;
        private System.Windows.Forms.TextBox AtkValue;
        private System.Windows.Forms.TextBox CRValue;
        private System.Windows.Forms.TextBox CDValue;
        private System.Windows.Forms.TextBox EMValue;
        private System.Windows.Forms.TextBox DMGBuffValue;
        private System.Windows.Forms.TextBox SkillValue;
        private System.Windows.Forms.TextBox IndiValue;
        private System.Windows.Forms.TextBox PlayerLevelValue;
        private System.Windows.Forms.TextBox EnemyLevelValue;
        private System.Windows.Forms.TextBox EnemyRESValue;
        private System.Windows.Forms.TextBox EnemyDEFValue;
        private System.Windows.Forms.Label DmgExpected_Label;
        private System.Windows.Forms.TextBox DMGExpected;
        private System.Windows.Forms.GroupBox Group_1;
        private System.Windows.Forms.Label Attribute_Label;
        private System.Windows.Forms.ComboBox DmgType;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label Attribute_Text;
        private System.Windows.Forms.ComboBox ReactBox;
        private System.Windows.Forms.TextBox ReactBuffValue;
    }
}