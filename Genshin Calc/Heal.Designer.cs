namespace Genshin_Calc
{
    partial class Heal
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
            this.Calculate_Basic = new System.Windows.Forms.TextBox();
            this.Healing = new System.Windows.Forms.GroupBox();
            this.Heal_Skill = new System.Windows.Forms.TextBox();
            this.Heal_Skill_Label = new System.Windows.Forms.Label();
            this.ByHealed_Plus = new System.Windows.Forms.TextBox();
            this.ByHealed_Plus_Label = new System.Windows.Forms.Label();
            this.Heal_Plus = new System.Windows.Forms.TextBox();
            this.Heal_Plus_Label = new System.Windows.Forms.Label();
            this.Heal_P = new System.Windows.Forms.TextBox();
            this.Heal_P_Label = new System.Windows.Forms.Label();
            this.Shield = new System.Windows.Forms.GroupBox();
            this.Shield_Skill = new System.Windows.Forms.TextBox();
            this.Shield_Skill_Label = new System.Windows.Forms.Label();
            this.Shield_Type = new System.Windows.Forms.ComboBox();
            this.Shield_Type_Label = new System.Windows.Forms.Label();
            this.Shield_Plus = new System.Windows.Forms.TextBox();
            this.Shield_Plus_Label = new System.Windows.Forms.Label();
            this.Shield_P = new System.Windows.Forms.TextBox();
            this.Shield_P_Label = new System.Windows.Forms.Label();
            this.Basic_Attribute = new System.Windows.Forms.GroupBox();
            this.Player_Level = new System.Windows.Forms.TextBox();
            this.Player_Level_Label = new System.Windows.Forms.Label();
            this.Elemental_Mastery = new System.Windows.Forms.TextBox();
            this.Calculate_Basic_Label = new System.Windows.Forms.Label();
            this.Elemental_Mastery_Label = new System.Windows.Forms.Label();
            this.Heal_Result = new System.Windows.Forms.GroupBox();
            this.Heal_Result_1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Shield_Result_1_Label = new System.Windows.Forms.Label();
            this.Shield_Result_2_Label = new System.Windows.Forms.Label();
            this.Shield_Result_1 = new System.Windows.Forms.Label();
            this.Shield_Result_2 = new System.Windows.Forms.Label();
            this.Shield_Result = new System.Windows.Forms.GroupBox();
            this.Shield_Result_Type2 = new System.Windows.Forms.RadioButton();
            this.Shield_Result_Type1 = new System.Windows.Forms.RadioButton();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Healing.SuspendLayout();
            this.Shield.SuspendLayout();
            this.Basic_Attribute.SuspendLayout();
            this.Heal_Result.SuspendLayout();
            this.Shield_Result.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calculate_Basic
            // 
            this.Calculate_Basic.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate_Basic.Location = new System.Drawing.Point(130, 30);
            this.Calculate_Basic.MaxLength = 6;
            this.Calculate_Basic.Name = "Calculate_Basic";
            this.Calculate_Basic.Size = new System.Drawing.Size(86, 32);
            this.Calculate_Basic.TabIndex = 1;
            this.Calculate_Basic.Text = "0";
            this.Calculate_Basic.TextChanged += new System.EventHandler(this.Calculate_Basic_TextChanged);
            // 
            // Healing
            // 
            this.Healing.Controls.Add(this.Heal_Skill);
            this.Healing.Controls.Add(this.Heal_Skill_Label);
            this.Healing.Controls.Add(this.ByHealed_Plus);
            this.Healing.Controls.Add(this.ByHealed_Plus_Label);
            this.Healing.Controls.Add(this.Heal_Plus);
            this.Healing.Controls.Add(this.Heal_Plus_Label);
            this.Healing.Controls.Add(this.Heal_P);
            this.Healing.Controls.Add(this.Heal_P_Label);
            this.Healing.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.Healing.Location = new System.Drawing.Point(12, 12);
            this.Healing.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.Healing.Name = "Healing";
            this.Healing.Size = new System.Drawing.Size(247, 242);
            this.Healing.TabIndex = 24;
            this.Healing.TabStop = false;
            this.Healing.Text = "治疗相关";
            // 
            // Heal_Skill
            // 
            this.Heal_Skill.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heal_Skill.Location = new System.Drawing.Point(121, 37);
            this.Heal_Skill.MaxLength = 4;
            this.Heal_Skill.Name = "Heal_Skill";
            this.Heal_Skill.Size = new System.Drawing.Size(86, 32);
            this.Heal_Skill.TabIndex = 11;
            this.Heal_Skill.Text = "100";
            this.Heal_Skill.TextChanged += new System.EventHandler(this.Heal_Skill_TextChanged);
            // 
            // Heal_Skill_Label
            // 
            this.Heal_Skill_Label.AutoSize = true;
            this.Heal_Skill_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Heal_Skill_Label.Location = new System.Drawing.Point(6, 37);
            this.Heal_Skill_Label.Name = "Heal_Skill_Label";
            this.Heal_Skill_Label.Size = new System.Drawing.Size(235, 28);
            this.Heal_Skill_Label.TabIndex = 27;
            this.Heal_Skill_Label.Text = "治疗倍率                    %";
            // 
            // ByHealed_Plus
            // 
            this.ByHealed_Plus.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ByHealed_Plus.Location = new System.Drawing.Point(121, 187);
            this.ByHealed_Plus.MaxLength = 4;
            this.ByHealed_Plus.Name = "ByHealed_Plus";
            this.ByHealed_Plus.Size = new System.Drawing.Size(86, 32);
            this.ByHealed_Plus.TabIndex = 14;
            this.ByHealed_Plus.Text = "0";
            this.ByHealed_Plus.TextChanged += new System.EventHandler(this.ByHealed_Plus_TextChanged);
            // 
            // ByHealed_Plus_Label
            // 
            this.ByHealed_Plus_Label.AutoSize = true;
            this.ByHealed_Plus_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ByHealed_Plus_Label.Location = new System.Drawing.Point(6, 187);
            this.ByHealed_Plus_Label.Name = "ByHealed_Plus_Label";
            this.ByHealed_Plus_Label.Size = new System.Drawing.Size(235, 28);
            this.ByHealed_Plus_Label.TabIndex = 25;
            this.ByHealed_Plus_Label.Text = "受疗加成                    %";
            // 
            // Heal_Plus
            // 
            this.Heal_Plus.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heal_Plus.Location = new System.Drawing.Point(121, 137);
            this.Heal_Plus.MaxLength = 4;
            this.Heal_Plus.Name = "Heal_Plus";
            this.Heal_Plus.Size = new System.Drawing.Size(86, 32);
            this.Heal_Plus.TabIndex = 13;
            this.Heal_Plus.Text = "0";
            this.Heal_Plus.TextChanged += new System.EventHandler(this.Heal_Plus_TextChanged);
            // 
            // Heal_Plus_Label
            // 
            this.Heal_Plus_Label.AutoSize = true;
            this.Heal_Plus_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Heal_Plus_Label.Location = new System.Drawing.Point(6, 137);
            this.Heal_Plus_Label.Name = "Heal_Plus_Label";
            this.Heal_Plus_Label.Size = new System.Drawing.Size(235, 28);
            this.Heal_Plus_Label.TabIndex = 23;
            this.Heal_Plus_Label.Text = "治疗加成                    %";
            // 
            // Heal_P
            // 
            this.Heal_P.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heal_P.Location = new System.Drawing.Point(121, 87);
            this.Heal_P.MaxLength = 4;
            this.Heal_P.Name = "Heal_P";
            this.Heal_P.Size = new System.Drawing.Size(86, 32);
            this.Heal_P.TabIndex = 12;
            this.Heal_P.Text = "0";
            this.Heal_P.TextChanged += new System.EventHandler(this.Heal_P_TextChanged);
            // 
            // Heal_P_Label
            // 
            this.Heal_P_Label.AutoSize = true;
            this.Heal_P_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Heal_P_Label.Location = new System.Drawing.Point(6, 87);
            this.Heal_P_Label.Name = "Heal_P_Label";
            this.Heal_P_Label.Size = new System.Drawing.Size(117, 28);
            this.Heal_P_Label.TabIndex = 21;
            this.Heal_P_Label.Text = "加上固定值";
            // 
            // Shield
            // 
            this.Shield.Controls.Add(this.Shield_Skill);
            this.Shield.Controls.Add(this.Shield_Skill_Label);
            this.Shield.Controls.Add(this.Shield_Type);
            this.Shield.Controls.Add(this.Shield_Type_Label);
            this.Shield.Controls.Add(this.Shield_Plus);
            this.Shield.Controls.Add(this.Shield_Plus_Label);
            this.Shield.Controls.Add(this.Shield_P);
            this.Shield.Controls.Add(this.Shield_P_Label);
            this.Shield.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.Shield.Location = new System.Drawing.Point(12, 260);
            this.Shield.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.Shield.Name = "Shield";
            this.Shield.Size = new System.Drawing.Size(247, 242);
            this.Shield.TabIndex = 27;
            this.Shield.TabStop = false;
            this.Shield.Text = "护盾相关";
            // 
            // Shield_Skill
            // 
            this.Shield_Skill.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shield_Skill.Location = new System.Drawing.Point(121, 37);
            this.Shield_Skill.MaxLength = 4;
            this.Shield_Skill.Name = "Shield_Skill";
            this.Shield_Skill.Size = new System.Drawing.Size(86, 32);
            this.Shield_Skill.TabIndex = 21;
            this.Shield_Skill.Text = "100";
            this.Shield_Skill.TextChanged += new System.EventHandler(this.Shield_Skill_TextChanged);
            // 
            // Shield_Skill_Label
            // 
            this.Shield_Skill_Label.AutoSize = true;
            this.Shield_Skill_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Shield_Skill_Label.Location = new System.Drawing.Point(6, 37);
            this.Shield_Skill_Label.Name = "Shield_Skill_Label";
            this.Shield_Skill_Label.Size = new System.Drawing.Size(235, 28);
            this.Shield_Skill_Label.TabIndex = 29;
            this.Shield_Skill_Label.Text = "护盾倍率                    %";
            // 
            // Shield_Type
            // 
            this.Shield_Type.BackColor = System.Drawing.SystemColors.Window;
            this.Shield_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Shield_Type.Font = new System.Drawing.Font("微软雅黑", 13.5F);
            this.Shield_Type.FormattingEnabled = true;
            this.Shield_Type.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Shield_Type.Items.AddRange(new object[] {
            "岩盾",
            "其他"});
            this.Shield_Type.Location = new System.Drawing.Point(121, 187);
            this.Shield_Type.Name = "Shield_Type";
            this.Shield_Type.Size = new System.Drawing.Size(86, 32);
            this.Shield_Type.TabIndex = 24;
            this.Shield_Type.SelectedIndexChanged += new System.EventHandler(this.Shield_Type_SelectedIndexChanged);
            // 
            // Shield_Type_Label
            // 
            this.Shield_Type_Label.AutoSize = true;
            this.Shield_Type_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Shield_Type_Label.Location = new System.Drawing.Point(6, 187);
            this.Shield_Type_Label.Name = "Shield_Type_Label";
            this.Shield_Type_Label.Size = new System.Drawing.Size(96, 28);
            this.Shield_Type_Label.TabIndex = 27;
            this.Shield_Type_Label.Text = "元素类型";
            // 
            // Shield_Plus
            // 
            this.Shield_Plus.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shield_Plus.Location = new System.Drawing.Point(121, 137);
            this.Shield_Plus.MaxLength = 4;
            this.Shield_Plus.Name = "Shield_Plus";
            this.Shield_Plus.Size = new System.Drawing.Size(86, 32);
            this.Shield_Plus.TabIndex = 23;
            this.Shield_Plus.Text = "0";
            this.Shield_Plus.TextChanged += new System.EventHandler(this.Shield_Plus_TextChanged);
            // 
            // Shield_Plus_Label
            // 
            this.Shield_Plus_Label.AutoSize = true;
            this.Shield_Plus_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Shield_Plus_Label.Location = new System.Drawing.Point(6, 137);
            this.Shield_Plus_Label.Name = "Shield_Plus_Label";
            this.Shield_Plus_Label.Size = new System.Drawing.Size(235, 28);
            this.Shield_Plus_Label.TabIndex = 23;
            this.Shield_Plus_Label.Text = "护盾强效                    %";
            // 
            // Shield_P
            // 
            this.Shield_P.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shield_P.Location = new System.Drawing.Point(121, 87);
            this.Shield_P.MaxLength = 4;
            this.Shield_P.Name = "Shield_P";
            this.Shield_P.Size = new System.Drawing.Size(86, 32);
            this.Shield_P.TabIndex = 22;
            this.Shield_P.Text = "0";
            this.Shield_P.TextChanged += new System.EventHandler(this.Shield_P_TextChanged);
            // 
            // Shield_P_Label
            // 
            this.Shield_P_Label.AutoSize = true;
            this.Shield_P_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Shield_P_Label.Location = new System.Drawing.Point(6, 87);
            this.Shield_P_Label.Name = "Shield_P_Label";
            this.Shield_P_Label.Size = new System.Drawing.Size(117, 28);
            this.Shield_P_Label.TabIndex = 21;
            this.Shield_P_Label.Text = "加上固定值";
            // 
            // Basic_Attribute
            // 
            this.Basic_Attribute.Controls.Add(this.Player_Level);
            this.Basic_Attribute.Controls.Add(this.Player_Level_Label);
            this.Basic_Attribute.Controls.Add(this.Calculate_Basic);
            this.Basic_Attribute.Controls.Add(this.Elemental_Mastery);
            this.Basic_Attribute.Controls.Add(this.Calculate_Basic_Label);
            this.Basic_Attribute.Controls.Add(this.Elemental_Mastery_Label);
            this.Basic_Attribute.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.Basic_Attribute.Location = new System.Drawing.Point(268, 12);
            this.Basic_Attribute.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.Basic_Attribute.Name = "Basic_Attribute";
            this.Basic_Attribute.Size = new System.Drawing.Size(247, 169);
            this.Basic_Attribute.TabIndex = 28;
            this.Basic_Attribute.TabStop = false;
            this.Basic_Attribute.Text = "基础属性";
            // 
            // Player_Level
            // 
            this.Player_Level.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Level.Location = new System.Drawing.Point(130, 124);
            this.Player_Level.MaxLength = 4;
            this.Player_Level.Name = "Player_Level";
            this.Player_Level.Size = new System.Drawing.Size(86, 32);
            this.Player_Level.TabIndex = 3;
            this.Player_Level.Text = "1";
            this.Player_Level.TextChanged += new System.EventHandler(this.Level_TextChanged);
            // 
            // Player_Level_Label
            // 
            this.Player_Level_Label.AutoSize = true;
            this.Player_Level_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Player_Level_Label.Location = new System.Drawing.Point(15, 124);
            this.Player_Level_Label.Name = "Player_Level_Label";
            this.Player_Level_Label.Size = new System.Drawing.Size(96, 28);
            this.Player_Level_Label.TabIndex = 30;
            this.Player_Level_Label.Text = "角色等级";
            // 
            // Elemental_Mastery
            // 
            this.Elemental_Mastery.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Elemental_Mastery.Location = new System.Drawing.Point(130, 77);
            this.Elemental_Mastery.MaxLength = 4;
            this.Elemental_Mastery.Name = "Elemental_Mastery";
            this.Elemental_Mastery.Size = new System.Drawing.Size(86, 32);
            this.Elemental_Mastery.TabIndex = 2;
            this.Elemental_Mastery.Text = "0";
            this.Elemental_Mastery.TextChanged += new System.EventHandler(this.Elemental_Mastery_TextChanged);
            // 
            // Calculate_Basic_Label
            // 
            this.Calculate_Basic_Label.AutoSize = true;
            this.Calculate_Basic_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Calculate_Basic_Label.Location = new System.Drawing.Point(15, 34);
            this.Calculate_Basic_Label.Name = "Calculate_Basic_Label";
            this.Calculate_Basic_Label.Size = new System.Drawing.Size(117, 28);
            this.Calculate_Basic_Label.TabIndex = 29;
            this.Calculate_Basic_Label.Text = "计算基础值";
            // 
            // Elemental_Mastery_Label
            // 
            this.Elemental_Mastery_Label.AutoSize = true;
            this.Elemental_Mastery_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Elemental_Mastery_Label.Location = new System.Drawing.Point(15, 79);
            this.Elemental_Mastery_Label.Name = "Elemental_Mastery_Label";
            this.Elemental_Mastery_Label.Size = new System.Drawing.Size(96, 28);
            this.Elemental_Mastery_Label.TabIndex = 28;
            this.Elemental_Mastery_Label.Text = "元素精通";
            // 
            // Heal_Result
            // 
            this.Heal_Result.Controls.Add(this.Heal_Result_1);
            this.Heal_Result.Controls.Add(this.label7);
            this.Heal_Result.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.Heal_Result.Location = new System.Drawing.Point(268, 187);
            this.Heal_Result.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.Heal_Result.Name = "Heal_Result";
            this.Heal_Result.Size = new System.Drawing.Size(247, 67);
            this.Heal_Result.TabIndex = 29;
            this.Heal_Result.TabStop = false;
            this.Heal_Result.Text = "治疗计算";
            // 
            // Heal_Result_1
            // 
            this.Heal_Result_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Heal_Result_1.Font = new System.Drawing.Font("方正像素12", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Heal_Result_1.ForeColor = System.Drawing.Color.DarkRed;
            this.Heal_Result_1.Location = new System.Drawing.Point(137, 26);
            this.Heal_Result_1.Name = "Heal_Result_1";
            this.Heal_Result_1.Size = new System.Drawing.Size(92, 24);
            this.Heal_Result_1.TabIndex = 31;
            this.Heal_Result_1.Text = "0";
            this.Heal_Result_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(15, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 28);
            this.label7.TabIndex = 27;
            this.label7.Text = "单次奶量";
            // 
            // Shield_Result_1_Label
            // 
            this.Shield_Result_1_Label.AutoSize = true;
            this.Shield_Result_1_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Shield_Result_1_Label.Location = new System.Drawing.Point(15, 36);
            this.Shield_Result_1_Label.Name = "Shield_Result_1_Label";
            this.Shield_Result_1_Label.Size = new System.Drawing.Size(96, 28);
            this.Shield_Result_1_Label.TabIndex = 29;
            this.Shield_Result_1_Label.Text = "对应元素";
            // 
            // Shield_Result_2_Label
            // 
            this.Shield_Result_2_Label.AutoSize = true;
            this.Shield_Result_2_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Shield_Result_2_Label.Location = new System.Drawing.Point(15, 88);
            this.Shield_Result_2_Label.Name = "Shield_Result_2_Label";
            this.Shield_Result_2_Label.Size = new System.Drawing.Size(117, 28);
            this.Shield_Result_2_Label.TabIndex = 30;
            this.Shield_Result_2_Label.Text = "非对应元素";
            // 
            // Shield_Result_1
            // 
            this.Shield_Result_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Shield_Result_1.Font = new System.Drawing.Font("方正像素12", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Shield_Result_1.ForeColor = System.Drawing.Color.DarkRed;
            this.Shield_Result_1.Location = new System.Drawing.Point(137, 36);
            this.Shield_Result_1.Name = "Shield_Result_1";
            this.Shield_Result_1.Size = new System.Drawing.Size(92, 24);
            this.Shield_Result_1.TabIndex = 32;
            this.Shield_Result_1.Text = "0";
            this.Shield_Result_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Shield_Result_2
            // 
            this.Shield_Result_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Shield_Result_2.Font = new System.Drawing.Font("方正像素12", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Shield_Result_2.ForeColor = System.Drawing.Color.DarkRed;
            this.Shield_Result_2.Location = new System.Drawing.Point(137, 88);
            this.Shield_Result_2.Name = "Shield_Result_2";
            this.Shield_Result_2.Size = new System.Drawing.Size(92, 24);
            this.Shield_Result_2.TabIndex = 33;
            this.Shield_Result_2.Text = "0";
            this.Shield_Result_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Shield_Result
            // 
            this.Shield_Result.Controls.Add(this.Shield_Result_Type2);
            this.Shield_Result.Controls.Add(this.Shield_Result_Type1);
            this.Shield_Result.Controls.Add(this.Shield_Result_1_Label);
            this.Shield_Result.Controls.Add(this.Shield_Result_2);
            this.Shield_Result.Controls.Add(this.Shield_Result_2_Label);
            this.Shield_Result.Controls.Add(this.Shield_Result_1);
            this.Shield_Result.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.Shield_Result.Location = new System.Drawing.Point(268, 260);
            this.Shield_Result.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.Shield_Result.Name = "Shield_Result";
            this.Shield_Result.Size = new System.Drawing.Size(247, 199);
            this.Shield_Result.TabIndex = 32;
            this.Shield_Result.TabStop = false;
            this.Shield_Result.Text = "护盾计算";
            // 
            // Shield_Result_Type2
            // 
            this.Shield_Result_Type2.Appearance = System.Windows.Forms.Appearance.Button;
            this.Shield_Result_Type2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Shield_Result_Type2.Font = new System.Drawing.Font("微软雅黑", 13.25F);
            this.Shield_Result_Type2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Shield_Result_Type2.Location = new System.Drawing.Point(127, 140);
            this.Shield_Result_Type2.Name = "Shield_Result_Type2";
            this.Shield_Result_Type2.Size = new System.Drawing.Size(106, 32);
            this.Shield_Result_Type2.TabIndex = 32;
            this.Shield_Result_Type2.TabStop = true;
            this.Shield_Result_Type2.Text = "技能盾";
            this.Shield_Result_Type2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Shield_Result_Type2.UseVisualStyleBackColor = true;
            this.Shield_Result_Type2.CheckedChanged += new System.EventHandler(this.Shield_Result_Type2_CheckedChanged);
            // 
            // Shield_Result_Type1
            // 
            this.Shield_Result_Type1.Appearance = System.Windows.Forms.Appearance.Button;
            this.Shield_Result_Type1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Shield_Result_Type1.Font = new System.Drawing.Font("微软雅黑", 13.25F);
            this.Shield_Result_Type1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Shield_Result_Type1.Location = new System.Drawing.Point(17, 140);
            this.Shield_Result_Type1.Name = "Shield_Result_Type1";
            this.Shield_Result_Type1.Size = new System.Drawing.Size(106, 32);
            this.Shield_Result_Type1.TabIndex = 31;
            this.Shield_Result_Type1.TabStop = true;
            this.Shield_Result_Type1.Text = "结晶盾";
            this.Shield_Result_Type1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Shield_Result_Type1.UseVisualStyleBackColor = true;
            this.Shield_Result_Type1.CheckedChanged += new System.EventHandler(this.Shield_Result_Type1_CheckedChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.ExitButton.Location = new System.Drawing.Point(268, 469);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(247, 33);
            this.ExitButton.TabIndex = 33;
            this.ExitButton.Text = "完成并退出";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // Heal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(526, 513);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Shield_Result);
            this.Controls.Add(this.Heal_Result);
            this.Controls.Add(this.Basic_Attribute);
            this.Controls.Add(this.Shield);
            this.Controls.Add(this.Healing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Heal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "治疗量/护盾量计算器";
            this.Healing.ResumeLayout(false);
            this.Healing.PerformLayout();
            this.Shield.ResumeLayout(false);
            this.Shield.PerformLayout();
            this.Basic_Attribute.ResumeLayout(false);
            this.Basic_Attribute.PerformLayout();
            this.Heal_Result.ResumeLayout(false);
            this.Heal_Result.PerformLayout();
            this.Shield_Result.ResumeLayout(false);
            this.Shield_Result.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Calculate_Basic;
        private System.Windows.Forms.GroupBox Healing;
        private System.Windows.Forms.TextBox Heal_P;
        private System.Windows.Forms.Label Heal_P_Label;
        private System.Windows.Forms.TextBox ByHealed_Plus;
        private System.Windows.Forms.Label ByHealed_Plus_Label;
        private System.Windows.Forms.TextBox Heal_Plus;
        private System.Windows.Forms.Label Heal_Plus_Label;
        private System.Windows.Forms.GroupBox Shield;
        private System.Windows.Forms.ComboBox Shield_Type;
        private System.Windows.Forms.Label Shield_Type_Label;
        private System.Windows.Forms.TextBox Shield_Plus;
        private System.Windows.Forms.Label Shield_Plus_Label;
        private System.Windows.Forms.TextBox Shield_P;
        private System.Windows.Forms.Label Shield_P_Label;
        private System.Windows.Forms.GroupBox Basic_Attribute;
        private System.Windows.Forms.GroupBox Heal_Result;
        private System.Windows.Forms.Label Shield_Result_2_Label;
        private System.Windows.Forms.Label Shield_Result_1_Label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Heal_Result_1;
        private System.Windows.Forms.Label Shield_Result_1;
        private System.Windows.Forms.Label Shield_Result_2;
        private System.Windows.Forms.GroupBox Shield_Result;
        private System.Windows.Forms.RadioButton Shield_Result_Type2;
        private System.Windows.Forms.RadioButton Shield_Result_Type1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox Elemental_Mastery;
        private System.Windows.Forms.Label Elemental_Mastery_Label;
        private System.Windows.Forms.TextBox Heal_Skill;
        private System.Windows.Forms.Label Heal_Skill_Label;
        private System.Windows.Forms.TextBox Shield_Skill;
        private System.Windows.Forms.Label Shield_Skill_Label;
        private System.Windows.Forms.Label Calculate_Basic_Label;
        private System.Windows.Forms.TextBox Player_Level;
        private System.Windows.Forms.Label Player_Level_Label;
    }
}