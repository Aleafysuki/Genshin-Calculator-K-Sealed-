namespace Genshin_Calc
{
    partial class Characters_Weapons
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
            this.角色属性 = new System.Windows.Forms.GroupBox();
            this.Skill_Check_Button = new System.Windows.Forms.Button();
            this.Tip_Label = new System.Windows.Forms.Label();
            this.Character_Elem = new System.Windows.Forms.ComboBox();
            this.Character_Check = new System.Windows.Forms.CheckBox();
            this.Character_Choose = new System.Windows.Forms.ComboBox();
            this.Character_Level = new System.Windows.Forms.TextBox();
            this.武器属性 = new System.Windows.Forms.GroupBox();
            this.Weapon_Level = new System.Windows.Forms.DomainUpDown();
            this.Weapon_Type = new System.Windows.Forms.ComboBox();
            this.Weapon_Choose = new System.Windows.Forms.ComboBox();
            this.Character_Result = new System.Windows.Forms.TextBox();
            this.Weapon_Result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.角色属性.SuspendLayout();
            this.武器属性.SuspendLayout();
            this.SuspendLayout();
            // 
            // 角色属性
            // 
            this.角色属性.Controls.Add(this.Skill_Check_Button);
            this.角色属性.Controls.Add(this.Tip_Label);
            this.角色属性.Controls.Add(this.Character_Elem);
            this.角色属性.Controls.Add(this.Character_Check);
            this.角色属性.Controls.Add(this.Character_Choose);
            this.角色属性.Controls.Add(this.Character_Level);
            this.角色属性.Location = new System.Drawing.Point(12, 12);
            this.角色属性.Name = "角色属性";
            this.角色属性.Size = new System.Drawing.Size(381, 170);
            this.角色属性.TabIndex = 0;
            this.角色属性.TabStop = false;
            this.角色属性.Text = "角色属性";
            // 
            // Skill_Check_Button
            // 
            this.Skill_Check_Button.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Skill_Check_Button.Location = new System.Drawing.Point(15, 128);
            this.Skill_Check_Button.Name = "Skill_Check_Button";
            this.Skill_Check_Button.Size = new System.Drawing.Size(349, 30);
            this.Skill_Check_Button.TabIndex = 45;
            this.Skill_Check_Button.Text = "在wiki中查看角色详情";
            this.Skill_Check_Button.UseVisualStyleBackColor = true;
            this.Skill_Check_Button.Click += new System.EventHandler(this.Skill_Check_Button_Click);
            // 
            // Tip_Label
            // 
            this.Tip_Label.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Tip_Label.Location = new System.Drawing.Point(15, 73);
            this.Tip_Label.Name = "Tip_Label";
            this.Tip_Label.Size = new System.Drawing.Size(349, 48);
            this.Tip_Label.TabIndex = 44;
            this.Tip_Label.Text = "技能倍率实在肝不动了\r\n放过我吧orz";
            this.Tip_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Character_Elem
            // 
            this.Character_Elem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Character_Elem.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Character_Elem.FormattingEnabled = true;
            this.Character_Elem.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Character_Elem.Location = new System.Drawing.Point(15, 32);
            this.Character_Elem.Name = "Character_Elem";
            this.Character_Elem.Size = new System.Drawing.Size(49, 33);
            this.Character_Elem.TabIndex = 43;
            this.Character_Elem.SelectedIndexChanged += new System.EventHandler(this.Character_Elem_SelectedIndexChanged);
            // 
            // Character_Check
            // 
            this.Character_Check.Appearance = System.Windows.Forms.Appearance.Button;
            this.Character_Check.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Character_Check.Location = new System.Drawing.Point(292, 33);
            this.Character_Check.Name = "Character_Check";
            this.Character_Check.Size = new System.Drawing.Size(72, 32);
            this.Character_Check.TabIndex = 1;
            this.Character_Check.Text = "未突破";
            this.Character_Check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Character_Check.UseVisualStyleBackColor = true;
            this.Character_Check.CheckedChanged += new System.EventHandler(this.Character_Check_CheckedChanged);
            // 
            // Character_Choose
            // 
            this.Character_Choose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Character_Choose.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Character_Choose.FormattingEnabled = true;
            this.Character_Choose.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Character_Choose.Location = new System.Drawing.Point(70, 32);
            this.Character_Choose.Name = "Character_Choose";
            this.Character_Choose.Size = new System.Drawing.Size(147, 33);
            this.Character_Choose.TabIndex = 31;
            this.Character_Choose.SelectedIndexChanged += new System.EventHandler(this.Character_Choose_SelectedIndexChanged);
            // 
            // Character_Level
            // 
            this.Character_Level.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Character_Level.Location = new System.Drawing.Point(223, 33);
            this.Character_Level.MaxLength = 8;
            this.Character_Level.Name = "Character_Level";
            this.Character_Level.Size = new System.Drawing.Size(63, 32);
            this.Character_Level.TabIndex = 7;
            this.Character_Level.Text = "90";
            this.Character_Level.TextChanged += new System.EventHandler(this.Character_Level_TextChanged);
            // 
            // 武器属性
            // 
            this.武器属性.Controls.Add(this.Weapon_Level);
            this.武器属性.Controls.Add(this.Weapon_Type);
            this.武器属性.Controls.Add(this.Weapon_Choose);
            this.武器属性.Location = new System.Drawing.Point(399, 12);
            this.武器属性.Name = "武器属性";
            this.武器属性.Size = new System.Drawing.Size(375, 91);
            this.武器属性.TabIndex = 40;
            this.武器属性.TabStop = false;
            this.武器属性.Text = "武器属性";
            // 
            // Weapon_Level
            // 
            this.Weapon_Level.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.Weapon_Level.Items.Add("90");
            this.Weapon_Level.Items.Add("85");
            this.Weapon_Level.Items.Add("80+");
            this.Weapon_Level.Items.Add("80");
            this.Weapon_Level.Items.Add("75");
            this.Weapon_Level.Items.Add("70+");
            this.Weapon_Level.Items.Add("70");
            this.Weapon_Level.Items.Add("65");
            this.Weapon_Level.Items.Add("60+");
            this.Weapon_Level.Items.Add("60");
            this.Weapon_Level.Items.Add("55");
            this.Weapon_Level.Items.Add("50+");
            this.Weapon_Level.Items.Add("50");
            this.Weapon_Level.Items.Add("45");
            this.Weapon_Level.Items.Add("40+");
            this.Weapon_Level.Items.Add("40");
            this.Weapon_Level.Items.Add("35");
            this.Weapon_Level.Items.Add("30");
            this.Weapon_Level.Items.Add("25");
            this.Weapon_Level.Items.Add("20+");
            this.Weapon_Level.Items.Add("20");
            this.Weapon_Level.Items.Add("15");
            this.Weapon_Level.Items.Add("10");
            this.Weapon_Level.Items.Add("5");
            this.Weapon_Level.Items.Add("1");
            this.Weapon_Level.Location = new System.Drawing.Point(300, 34);
            this.Weapon_Level.Name = "Weapon_Level";
            this.Weapon_Level.ReadOnly = true;
            this.Weapon_Level.Size = new System.Drawing.Size(59, 34);
            this.Weapon_Level.TabIndex = 45;
            this.Weapon_Level.SelectedItemChanged += new System.EventHandler(this.Weapon_Level_SelectedItemChanged);
            // 
            // Weapon_Type
            // 
            this.Weapon_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Weapon_Type.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Weapon_Type.FormattingEnabled = true;
            this.Weapon_Type.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Weapon_Type.Items.AddRange(new object[] {
            "单手剑",
            "双手剑",
            "弓箭",
            "法器",
            "长柄武器"});
            this.Weapon_Type.Location = new System.Drawing.Point(17, 34);
            this.Weapon_Type.Name = "Weapon_Type";
            this.Weapon_Type.Size = new System.Drawing.Size(104, 33);
            this.Weapon_Type.TabIndex = 44;
            this.Weapon_Type.SelectedIndexChanged += new System.EventHandler(this.Weapon_Type_SelectedIndexChanged);
            // 
            // Weapon_Choose
            // 
            this.Weapon_Choose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Weapon_Choose.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Weapon_Choose.FormattingEnabled = true;
            this.Weapon_Choose.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Weapon_Choose.Location = new System.Drawing.Point(127, 34);
            this.Weapon_Choose.Name = "Weapon_Choose";
            this.Weapon_Choose.Size = new System.Drawing.Size(167, 33);
            this.Weapon_Choose.TabIndex = 31;
            this.Weapon_Choose.SelectedIndexChanged += new System.EventHandler(this.Weapon_Choose_SelectedIndexChanged);
            // 
            // Character_Result
            // 
            this.Character_Result.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Character_Result.Location = new System.Drawing.Point(493, 112);
            this.Character_Result.MaxLength = 8;
            this.Character_Result.Name = "Character_Result";
            this.Character_Result.Size = new System.Drawing.Size(63, 32);
            this.Character_Result.TabIndex = 45;
            this.Character_Result.Text = "1";
            this.Character_Result.TextChanged += new System.EventHandler(this.Character_Result_TextChanged);
            // 
            // Weapon_Result
            // 
            this.Weapon_Result.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weapon_Result.Location = new System.Drawing.Point(493, 146);
            this.Weapon_Result.MaxLength = 8;
            this.Weapon_Result.Name = "Weapon_Result";
            this.Weapon_Result.Size = new System.Drawing.Size(63, 32);
            this.Weapon_Result.TabIndex = 46;
            this.Weapon_Result.Text = "1";
            this.Weapon_Result.TextChanged += new System.EventHandler(this.Weapon_Result_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(408, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 45;
            this.label2.Text = "角色白值";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(408, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 28);
            this.label3.TabIndex = 47;
            this.label3.Text = "武器白值";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(570, 113);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(204, 28);
            this.Result.TabIndex = 48;
            this.Result.Text = "输出结果";
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(570, 147);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(99, 30);
            this.Confirm.TabIndex = 49;
            this.Confirm.Text = "确认";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(675, 147);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(99, 30);
            this.Cancel.TabIndex = 50;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Characters_Weapons
            // 
            this.AcceptButton = this.Confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(789, 196);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Weapon_Result);
            this.Controls.Add(this.Character_Result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.武器属性);
            this.Controls.Add(this.角色属性);
            this.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(805, 235);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(805, 235);
            this.Name = "Characters_Weapons";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "角色/武器属性填写";
            this.角色属性.ResumeLayout(false);
            this.角色属性.PerformLayout();
            this.武器属性.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox 角色属性;
        private System.Windows.Forms.TextBox Character_Level;
        private System.Windows.Forms.CheckBox Character_Check;
        private System.Windows.Forms.ComboBox Character_Choose;
        private System.Windows.Forms.GroupBox 武器属性;
        private System.Windows.Forms.ComboBox Weapon_Choose;
        private System.Windows.Forms.ComboBox Character_Elem;
        private System.Windows.Forms.ComboBox Weapon_Type;
        private System.Windows.Forms.Label Tip_Label;
        private System.Windows.Forms.TextBox Character_Result;
        private System.Windows.Forms.TextBox Weapon_Result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button Skill_Check_Button;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DomainUpDown Weapon_Level;
    }
}