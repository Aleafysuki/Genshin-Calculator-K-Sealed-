
namespace Genshin_Calc
{
    partial class DPSCalc
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
            System.Windows.Forms.Label Elem_RES_Label;
            System.Windows.Forms.Label Phys_RES_Label;
            System.Windows.Forms.Label Elem_Buff_Label;
            System.Windows.Forms.Label Phys_Buff_Label;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tips_Label = new System.Windows.Forms.Label();
            this.CalcTable = new System.Windows.Forms.DataGridView();
            this.Skill_S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skill_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DamageBuffType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Reaction = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DamageStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skill_Group = new System.Windows.Forms.GroupBox();
            this.Anemo_RES = new System.Windows.Forms.TextBox();
            this.Phys_RES = new System.Windows.Forms.TextBox();
            this.Anemo_Buff = new System.Windows.Forms.TextBox();
            this.Phys_Buff = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DPS_Disp = new System.Windows.Forms.Label();
            this.DMG_Disp = new System.Windows.Forms.Label();
            this.DPS_Label = new System.Windows.Forms.Label();
            this.Time_Input = new System.Windows.Forms.TextBox();
            this.Damage_Label = new System.Windows.Forms.Label();
            this.Time_Label = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.Cryo_Buff = new System.Windows.Forms.TextBox();
            this.Electro_Buff = new System.Windows.Forms.TextBox();
            this.Cryo_RES = new System.Windows.Forms.TextBox();
            this.Electro_RES = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Geo_RES = new System.Windows.Forms.TextBox();
            this.Hydro_RES = new System.Windows.Forms.TextBox();
            this.Geo_Buff = new System.Windows.Forms.TextBox();
            this.Pyro_Buff = new System.Windows.Forms.TextBox();
            this.Hydro_Buff = new System.Windows.Forms.TextBox();
            this.Pyro_RES = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            Elem_RES_Label = new System.Windows.Forms.Label();
            Phys_RES_Label = new System.Windows.Forms.Label();
            Elem_Buff_Label = new System.Windows.Forms.Label();
            Phys_Buff_Label = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CalcTable)).BeginInit();
            this.Skill_Group.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elem_RES_Label
            // 
            Elem_RES_Label.AutoSize = true;
            Elem_RES_Label.Font = new System.Drawing.Font("微软雅黑", 14F);
            Elem_RES_Label.Location = new System.Drawing.Point(167, 54);
            Elem_RES_Label.Name = "Elem_RES_Label";
            Elem_RES_Label.Size = new System.Drawing.Size(139, 25);
            Elem_RES_Label.TabIndex = 1007;
            Elem_RES_Label.Text = "风抗            %";
            // 
            // Phys_RES_Label
            // 
            Phys_RES_Label.AutoSize = true;
            Phys_RES_Label.Font = new System.Drawing.Font("微软雅黑", 14F);
            Phys_RES_Label.Location = new System.Drawing.Point(167, 28);
            Phys_RES_Label.Name = "Phys_RES_Label";
            Phys_RES_Label.Size = new System.Drawing.Size(139, 25);
            Phys_RES_Label.TabIndex = 1005;
            Phys_RES_Label.Text = "物抗            %";
            // 
            // Elem_Buff_Label
            // 
            Elem_Buff_Label.AutoSize = true;
            Elem_Buff_Label.Font = new System.Drawing.Font("微软雅黑", 14F);
            Elem_Buff_Label.Location = new System.Drawing.Point(12, 54);
            Elem_Buff_Label.Name = "Elem_Buff_Label";
            Elem_Buff_Label.Size = new System.Drawing.Size(141, 25);
            Elem_Buff_Label.TabIndex = 1003;
            Elem_Buff_Label.Text = "风伤+          %";
            // 
            // Phys_Buff_Label
            // 
            Phys_Buff_Label.AutoSize = true;
            Phys_Buff_Label.Font = new System.Drawing.Font("微软雅黑", 14F);
            Phys_Buff_Label.Location = new System.Drawing.Point(12, 28);
            Phys_Buff_Label.Name = "Phys_Buff_Label";
            Phys_Buff_Label.Size = new System.Drawing.Size(141, 25);
            Phys_Buff_Label.TabIndex = 1001;
            Phys_Buff_Label.Text = "物伤+          %";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("微软雅黑", 14F);
            label1.Location = new System.Drawing.Point(12, 80);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(141, 25);
            label1.TabIndex = 1009;
            label1.Text = "冰伤+          %";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("微软雅黑", 14F);
            label2.Location = new System.Drawing.Point(12, 106);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(141, 25);
            label2.TabIndex = 1011;
            label2.Text = "雷伤+          %";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("微软雅黑", 14F);
            label3.Location = new System.Drawing.Point(167, 80);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(139, 25);
            label3.TabIndex = 1013;
            label3.Text = "冰抗            %";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("微软雅黑", 14F);
            label4.Location = new System.Drawing.Point(167, 106);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(139, 25);
            label4.TabIndex = 1015;
            label4.Text = "雷抗            %";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("微软雅黑", 14F);
            label5.Location = new System.Drawing.Point(12, 132);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(141, 25);
            label5.TabIndex = 1017;
            label5.Text = "火伤+          %";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("微软雅黑", 14F);
            label6.Location = new System.Drawing.Point(167, 184);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(139, 25);
            label6.TabIndex = 1027;
            label6.Text = "岩抗            %";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("微软雅黑", 14F);
            label7.Location = new System.Drawing.Point(167, 132);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(139, 25);
            label7.TabIndex = 1019;
            label7.Text = "火抗            %";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("微软雅黑", 14F);
            label8.Location = new System.Drawing.Point(167, 158);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(139, 25);
            label8.TabIndex = 1025;
            label8.Text = "水抗            %";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("微软雅黑", 14F);
            label9.Location = new System.Drawing.Point(12, 184);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(141, 25);
            label9.TabIndex = 1023;
            label9.Text = "岩伤+          %";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("微软雅黑", 14F);
            label10.Location = new System.Drawing.Point(12, 158);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(141, 25);
            label10.TabIndex = 1021;
            label10.Text = "水伤+          %";
            // 
            // Tips_Label
            // 
            this.Tips_Label.AutoSize = true;
            this.Tips_Label.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.Tips_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Tips_Label.Location = new System.Drawing.Point(2, 13);
            this.Tips_Label.Name = "Tips_Label";
            this.Tips_Label.Size = new System.Drawing.Size(531, 108);
            this.Tips_Label.TabIndex = 9;
            this.Tips_Label.Text = "请注意：\r\n目前仅支持单一角色的DPS计算，且剧变反应结果会失真。\r\n并请在主窗口事先填写好角色与敌人的各项属性。\r\n倍率处无需填写百分号。";
            // 
            // CalcTable
            // 
            this.CalcTable.AllowUserToResizeColumns = false;
            this.CalcTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CalcTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.CalcTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.CalcTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CalcTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CalcTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CalcTable.ColumnHeadersHeight = 33;
            this.CalcTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Skill_S,
            this.Skill_P,
            this.DamageBuffType,
            this.Reaction,
            this.DamageStat});
            this.CalcTable.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CalcTable.Location = new System.Drawing.Point(6, 28);
            this.CalcTable.Name = "CalcTable";
            this.CalcTable.RowHeadersWidth = 42;
            this.CalcTable.RowTemplate.Height = 33;
            this.CalcTable.ShowCellErrors = false;
            this.CalcTable.Size = new System.Drawing.Size(545, 351);
            this.CalcTable.TabIndex = 999;
            this.CalcTable.TabStop = false;
            this.CalcTable.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CalcTable_RowLeave);
            this.CalcTable.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.CalcTable_RowLeave);
            this.CalcTable.Enter += new System.EventHandler(this.ReCalculator);
            // 
            // Skill_S
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 15F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Format = "N1";
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Skill_S.DefaultCellStyle = dataGridViewCellStyle2;
            this.Skill_S.HeaderText = "单段倍率";
            this.Skill_S.MaxInputLength = 6;
            this.Skill_S.Name = "Skill_S";
            this.Skill_S.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Skill_S.ToolTipText = "无需填写百分号";
            // 
            // Skill_P
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 15F);
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Skill_P.DefaultCellStyle = dataGridViewCellStyle3;
            this.Skill_P.HeaderText = "伤害段数";
            this.Skill_P.MaxInputLength = 2;
            this.Skill_P.Name = "Skill_P";
            // 
            // DamageBuffType
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DamageBuffType.DefaultCellStyle = dataGridViewCellStyle4;
            this.DamageBuffType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.DamageBuffType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DamageBuffType.HeaderText = "属性加成";
            this.DamageBuffType.Items.AddRange(new object[] {
            "物理",
            "风",
            "冰",
            "雷",
            "火",
            "水",
            "岩"});
            this.DamageBuffType.MinimumWidth = 50;
            this.DamageBuffType.Name = "DamageBuffType";
            // 
            // Reaction
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Reaction.DefaultCellStyle = dataGridViewCellStyle5;
            this.Reaction.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Reaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reaction.HeaderText = "反应类型";
            this.Reaction.Items.AddRange(new object[] {
            "不反应",
            "超导",
            "扩散",
            "感电",
            "碎冰",
            "超载",
            "火蒸发",
            "水蒸发",
            "火融化",
            "冰融化"});
            this.Reaction.Name = "Reaction";
            this.Reaction.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Reaction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DamageStat
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 15F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Format = ".00%";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DamageStat.DefaultCellStyle = dataGridViewCellStyle6;
            this.DamageStat.HeaderText = "伤害占比";
            this.DamageStat.MaxInputLength = 8;
            this.DamageStat.Name = "DamageStat";
            this.DamageStat.ReadOnly = true;
            // 
            // Skill_Group
            // 
            this.Skill_Group.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Skill_Group.Controls.Add(this.CalcTable);
            this.Skill_Group.Location = new System.Drawing.Point(12, 146);
            this.Skill_Group.Name = "Skill_Group";
            this.Skill_Group.Size = new System.Drawing.Size(556, 385);
            this.Skill_Group.TabIndex = 1000;
            this.Skill_Group.TabStop = false;
            this.Skill_Group.Text = "倍率填写";
            // 
            // Anemo_RES
            // 
            this.Anemo_RES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))));
            this.Anemo_RES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Anemo_RES.Font = new System.Drawing.Font("Consolas", 14F);
            this.Anemo_RES.Location = new System.Drawing.Point(216, 55);
            this.Anemo_RES.MaxLength = 8;
            this.Anemo_RES.Name = "Anemo_RES";
            this.Anemo_RES.Size = new System.Drawing.Size(55, 22);
            this.Anemo_RES.TabIndex = 1006;
            this.Anemo_RES.Text = "10";
            this.Anemo_RES.TextChanged += new System.EventHandler(this.ReCalculator);
            // 
            // Phys_RES
            // 
            this.Phys_RES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))));
            this.Phys_RES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Phys_RES.Font = new System.Drawing.Font("Consolas", 14F);
            this.Phys_RES.Location = new System.Drawing.Point(216, 29);
            this.Phys_RES.MaxLength = 8;
            this.Phys_RES.Name = "Phys_RES";
            this.Phys_RES.Size = new System.Drawing.Size(55, 22);
            this.Phys_RES.TabIndex = 1004;
            this.Phys_RES.Text = "10";
            this.Phys_RES.TextChanged += new System.EventHandler(this.ReCalculator);
            // 
            // Anemo_Buff
            // 
            this.Anemo_Buff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))));
            this.Anemo_Buff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Anemo_Buff.Font = new System.Drawing.Font("Consolas", 14F);
            this.Anemo_Buff.Location = new System.Drawing.Point(70, 55);
            this.Anemo_Buff.MaxLength = 8;
            this.Anemo_Buff.Name = "Anemo_Buff";
            this.Anemo_Buff.Size = new System.Drawing.Size(56, 22);
            this.Anemo_Buff.TabIndex = 1002;
            this.Anemo_Buff.Text = "0";
            this.Anemo_Buff.TextChanged += new System.EventHandler(this.ReCalculator);
            // 
            // Phys_Buff
            // 
            this.Phys_Buff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))));
            this.Phys_Buff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Phys_Buff.Font = new System.Drawing.Font("Consolas", 14F);
            this.Phys_Buff.Location = new System.Drawing.Point(70, 29);
            this.Phys_Buff.MaxLength = 8;
            this.Phys_Buff.Name = "Phys_Buff";
            this.Phys_Buff.Size = new System.Drawing.Size(56, 22);
            this.Phys_Buff.TabIndex = 1000;
            this.Phys_Buff.Text = "0";
            this.Phys_Buff.TextChanged += new System.EventHandler(this.ReCalculator);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DPS_Disp);
            this.groupBox1.Controls.Add(this.DMG_Disp);
            this.groupBox1.Controls.Add(this.DPS_Label);
            this.groupBox1.Controls.Add(this.Time_Input);
            this.groupBox1.Controls.Add(this.Damage_Label);
            this.groupBox1.Controls.Add(this.Time_Label);
            this.groupBox1.Location = new System.Drawing.Point(574, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 260);
            this.groupBox1.TabIndex = 1003;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "结果计算";
            // 
            // DPS_Disp
            // 
            this.DPS_Disp.AutoEllipsis = true;
            this.DPS_Disp.BackColor = System.Drawing.Color.Transparent;
            this.DPS_Disp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DPS_Disp.Font = new System.Drawing.Font("方正像素12", 21F);
            this.DPS_Disp.ForeColor = System.Drawing.Color.Firebrick;
            this.DPS_Disp.Location = new System.Drawing.Point(105, 166);
            this.DPS_Disp.Name = "DPS_Disp";
            this.DPS_Disp.Size = new System.Drawing.Size(207, 81);
            this.DPS_Disp.TabIndex = 1011;
            this.DPS_Disp.Text = "0\r\n0\r\n0";
            this.DPS_Disp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DMG_Disp
            // 
            this.DMG_Disp.AutoEllipsis = true;
            this.DMG_Disp.BackColor = System.Drawing.Color.Transparent;
            this.DMG_Disp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DMG_Disp.Font = new System.Drawing.Font("方正像素12", 21F);
            this.DMG_Disp.ForeColor = System.Drawing.Color.Gray;
            this.DMG_Disp.Location = new System.Drawing.Point(105, 69);
            this.DMG_Disp.Name = "DMG_Disp";
            this.DMG_Disp.Size = new System.Drawing.Size(207, 85);
            this.DMG_Disp.TabIndex = 1002;
            this.DMG_Disp.Text = "0\r\n0\r\n0";
            this.DMG_Disp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DPS_Label
            // 
            this.DPS_Label.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.DPS_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DPS_Label.Location = new System.Drawing.Point(6, 165);
            this.DPS_Label.Name = "DPS_Label";
            this.DPS_Label.Size = new System.Drawing.Size(106, 81);
            this.DPS_Label.TabIndex = 1010;
            this.DPS_Label.Text = "DPS\r\nDPS(物理)\r\nDPS(元素)";
            this.DPS_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Time_Input
            // 
            this.Time_Input.Font = new System.Drawing.Font("Consolas", 14F);
            this.Time_Input.Location = new System.Drawing.Point(120, 27);
            this.Time_Input.MaxLength = 4;
            this.Time_Input.Name = "Time_Input";
            this.Time_Input.Size = new System.Drawing.Size(71, 29);
            this.Time_Input.TabIndex = 1008;
            this.Time_Input.Text = "20";
            this.Time_Input.TextChanged += new System.EventHandler(this.ReCalculator);
            // 
            // Damage_Label
            // 
            this.Damage_Label.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.Damage_Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Damage_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Damage_Label.Location = new System.Drawing.Point(6, 68);
            this.Damage_Label.Name = "Damage_Label";
            this.Damage_Label.Size = new System.Drawing.Size(106, 85);
            this.Damage_Label.TabIndex = 1001;
            this.Damage_Label.Text = "总伤害\r\n物理伤害\r\n元素伤害";
            this.Damage_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Time_Label
            // 
            this.Time_Label.AutoSize = true;
            this.Time_Label.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.Time_Label.Location = new System.Drawing.Point(13, 28);
            this.Time_Label.Name = "Time_Label";
            this.Time_Label.Size = new System.Drawing.Size(210, 27);
            this.Time_Label.TabIndex = 1009;
            this.Time_Label.Text = "输出总用时             秒";
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(735, 503);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(157, 28);
            this.ExitButton.TabIndex = 1004;
            this.ExitButton.Text = "完成";
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CalculateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CalculateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.CalculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateButton.Location = new System.Drawing.Point(574, 503);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(157, 28);
            this.CalculateButton.TabIndex = 1005;
            this.CalculateButton.Text = "计算";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.ReCalculator);
            // 
            // Cryo_Buff
            // 
            this.Cryo_Buff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))));
            this.Cryo_Buff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cryo_Buff.Font = new System.Drawing.Font("Consolas", 14F);
            this.Cryo_Buff.Location = new System.Drawing.Point(70, 81);
            this.Cryo_Buff.MaxLength = 8;
            this.Cryo_Buff.Name = "Cryo_Buff";
            this.Cryo_Buff.Size = new System.Drawing.Size(56, 22);
            this.Cryo_Buff.TabIndex = 1008;
            this.Cryo_Buff.Text = "0";
            this.Cryo_Buff.TextChanged += new System.EventHandler(this.ReCalculator);
            // 
            // Electro_Buff
            // 
            this.Electro_Buff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))));
            this.Electro_Buff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Electro_Buff.Font = new System.Drawing.Font("Consolas", 14F);
            this.Electro_Buff.Location = new System.Drawing.Point(70, 107);
            this.Electro_Buff.MaxLength = 8;
            this.Electro_Buff.Name = "Electro_Buff";
            this.Electro_Buff.Size = new System.Drawing.Size(56, 22);
            this.Electro_Buff.TabIndex = 1010;
            this.Electro_Buff.Text = "0";
            this.Electro_Buff.TextChanged += new System.EventHandler(this.ReCalculator);
            // 
            // Cryo_RES
            // 
            this.Cryo_RES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))));
            this.Cryo_RES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cryo_RES.Font = new System.Drawing.Font("Consolas", 14F);
            this.Cryo_RES.Location = new System.Drawing.Point(216, 81);
            this.Cryo_RES.MaxLength = 8;
            this.Cryo_RES.Name = "Cryo_RES";
            this.Cryo_RES.Size = new System.Drawing.Size(55, 22);
            this.Cryo_RES.TabIndex = 1012;
            this.Cryo_RES.Text = "10";
            this.Cryo_RES.TextChanged += new System.EventHandler(this.ReCalculator);
            // 
            // Electro_RES
            // 
            this.Electro_RES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))));
            this.Electro_RES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Electro_RES.Font = new System.Drawing.Font("Consolas", 14F);
            this.Electro_RES.Location = new System.Drawing.Point(216, 107);
            this.Electro_RES.MaxLength = 8;
            this.Electro_RES.Name = "Electro_RES";
            this.Electro_RES.Size = new System.Drawing.Size(55, 22);
            this.Electro_RES.TabIndex = 1014;
            this.Electro_RES.Text = "10";
            this.Electro_RES.TextChanged += new System.EventHandler(this.ReCalculator);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Geo_RES);
            this.groupBox2.Controls.Add(this.Hydro_RES);
            this.groupBox2.Controls.Add(this.Geo_Buff);
            this.groupBox2.Controls.Add(this.Pyro_Buff);
            this.groupBox2.Controls.Add(this.Hydro_Buff);
            this.groupBox2.Controls.Add(this.Pyro_RES);
            this.groupBox2.Controls.Add(label5);
            this.groupBox2.Controls.Add(label6);
            this.groupBox2.Controls.Add(label7);
            this.groupBox2.Controls.Add(label8);
            this.groupBox2.Controls.Add(label9);
            this.groupBox2.Controls.Add(label10);
            this.groupBox2.Controls.Add(this.Electro_RES);
            this.groupBox2.Controls.Add(this.Cryo_RES);
            this.groupBox2.Controls.Add(this.Phys_Buff);
            this.groupBox2.Controls.Add(this.Electro_Buff);
            this.groupBox2.Controls.Add(this.Anemo_Buff);
            this.groupBox2.Controls.Add(this.Phys_RES);
            this.groupBox2.Controls.Add(this.Cryo_Buff);
            this.groupBox2.Controls.Add(this.Anemo_RES);
            this.groupBox2.Controls.Add(Phys_Buff_Label);
            this.groupBox2.Controls.Add(Elem_Buff_Label);
            this.groupBox2.Controls.Add(label4);
            this.groupBox2.Controls.Add(Phys_RES_Label);
            this.groupBox2.Controls.Add(Elem_RES_Label);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Location = new System.Drawing.Point(574, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 222);
            this.groupBox2.TabIndex = 1016;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "敌我属性填写";
            // 
            // Geo_RES
            // 
            this.Geo_RES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))));
            this.Geo_RES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Geo_RES.Font = new System.Drawing.Font("Consolas", 14F);
            this.Geo_RES.Location = new System.Drawing.Point(216, 185);
            this.Geo_RES.MaxLength = 8;
            this.Geo_RES.Name = "Geo_RES";
            this.Geo_RES.Size = new System.Drawing.Size(55, 22);
            this.Geo_RES.TabIndex = 1026;
            this.Geo_RES.Text = "10";
            this.Geo_RES.TextChanged += new System.EventHandler(this.ReCalculator);
            // 
            // Hydro_RES
            // 
            this.Hydro_RES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))));
            this.Hydro_RES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Hydro_RES.Font = new System.Drawing.Font("Consolas", 14F);
            this.Hydro_RES.Location = new System.Drawing.Point(216, 159);
            this.Hydro_RES.MaxLength = 8;
            this.Hydro_RES.Name = "Hydro_RES";
            this.Hydro_RES.Size = new System.Drawing.Size(55, 22);
            this.Hydro_RES.TabIndex = 1024;
            this.Hydro_RES.Text = "10";
            this.Hydro_RES.TextChanged += new System.EventHandler(this.ReCalculator);
            // 
            // Geo_Buff
            // 
            this.Geo_Buff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))));
            this.Geo_Buff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Geo_Buff.Font = new System.Drawing.Font("Consolas", 14F);
            this.Geo_Buff.Location = new System.Drawing.Point(70, 185);
            this.Geo_Buff.MaxLength = 8;
            this.Geo_Buff.Name = "Geo_Buff";
            this.Geo_Buff.Size = new System.Drawing.Size(56, 22);
            this.Geo_Buff.TabIndex = 1022;
            this.Geo_Buff.Text = "0";
            this.Geo_Buff.TextChanged += new System.EventHandler(this.ReCalculator);
            // 
            // Pyro_Buff
            // 
            this.Pyro_Buff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))));
            this.Pyro_Buff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pyro_Buff.Font = new System.Drawing.Font("Consolas", 14F);
            this.Pyro_Buff.Location = new System.Drawing.Point(70, 133);
            this.Pyro_Buff.MaxLength = 8;
            this.Pyro_Buff.Name = "Pyro_Buff";
            this.Pyro_Buff.Size = new System.Drawing.Size(56, 22);
            this.Pyro_Buff.TabIndex = 1016;
            this.Pyro_Buff.Text = "0";
            this.Pyro_Buff.TextChanged += new System.EventHandler(this.ReCalculator);
            // 
            // Hydro_Buff
            // 
            this.Hydro_Buff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))));
            this.Hydro_Buff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Hydro_Buff.Font = new System.Drawing.Font("Consolas", 14F);
            this.Hydro_Buff.Location = new System.Drawing.Point(70, 159);
            this.Hydro_Buff.MaxLength = 8;
            this.Hydro_Buff.Name = "Hydro_Buff";
            this.Hydro_Buff.Size = new System.Drawing.Size(56, 22);
            this.Hydro_Buff.TabIndex = 1020;
            this.Hydro_Buff.Text = "0";
            this.Hydro_Buff.TextChanged += new System.EventHandler(this.ReCalculator);
            // 
            // Pyro_RES
            // 
            this.Pyro_RES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))));
            this.Pyro_RES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pyro_RES.Font = new System.Drawing.Font("Consolas", 14F);
            this.Pyro_RES.Location = new System.Drawing.Point(216, 133);
            this.Pyro_RES.MaxLength = 8;
            this.Pyro_RES.Name = "Pyro_RES";
            this.Pyro_RES.Size = new System.Drawing.Size(55, 22);
            this.Pyro_RES.TabIndex = 1018;
            this.Pyro_RES.Text = "10";
            this.Pyro_RES.TextChanged += new System.EventHandler(this.ReCalculator);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.Tips_Label);
            this.groupBox3.Location = new System.Drawing.Point(12, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(551, 131);
            this.groupBox3.TabIndex = 1017;
            this.groupBox3.TabStop = false;
            // 
            // DPSCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(904, 543);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Skill_Group);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(920, 582);
            this.Name = "DPSCalc";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DPS简易计算";
            this.Load += new System.EventHandler(this.DPSCalc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CalcTable)).EndInit();
            this.Skill_Group.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Tips_Label;
        private System.Windows.Forms.DataGridView CalcTable;
        private System.Windows.Forms.GroupBox Skill_Group;
        private System.Windows.Forms.TextBox Anemo_Buff;
        private System.Windows.Forms.TextBox Phys_Buff;
        private System.Windows.Forms.TextBox Anemo_RES;
        private System.Windows.Forms.TextBox Phys_RES;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Damage_Label;
        private System.Windows.Forms.Label DMG_Disp;
        private System.Windows.Forms.Label DPS_Label;
        private System.Windows.Forms.Label DPS_Disp;
        private System.Windows.Forms.TextBox Time_Input;
        private System.Windows.Forms.Label Time_Label;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox Cryo_Buff;
        private System.Windows.Forms.TextBox Electro_Buff;
        private System.Windows.Forms.TextBox Cryo_RES;
        private System.Windows.Forms.TextBox Electro_RES;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Geo_RES;
        private System.Windows.Forms.TextBox Hydro_RES;
        private System.Windows.Forms.TextBox Geo_Buff;
        private System.Windows.Forms.TextBox Pyro_Buff;
        private System.Windows.Forms.TextBox Hydro_Buff;
        private System.Windows.Forms.TextBox Pyro_RES;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skill_S;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skill_P;
        private System.Windows.Forms.DataGridViewComboBoxColumn DamageBuffType;
        private System.Windows.Forms.DataGridViewComboBoxColumn Reaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn DamageStat;
    }
}