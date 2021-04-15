namespace Genshin_Calc
{
    partial class Defence_Calc
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
            this.PlayerDEF1_P = new System.Windows.Forms.TrackBar();
            this.PlayerDEF_Text = new System.Windows.Forms.Label();
            this.PlayerDEF1 = new System.Windows.Forms.TrackBar();
            this.PlayerDEF = new System.Windows.Forms.TextBox();
            this.PlayerDEF_P = new System.Windows.Forms.TextBox();
            this.PlayerDEF_P_Text = new System.Windows.Forms.Label();
            this.PlayerDEFBasic_Text = new System.Windows.Forms.Label();
            this.PlayerDEFBasic1 = new System.Windows.Forms.TrackBar();
            this.PlayerDEFBasic = new System.Windows.Forms.TextBox();
            this.PlayerDEFPlus1 = new System.Windows.Forms.TrackBar();
            this.PlayerDEFPlus = new System.Windows.Forms.TextBox();
            this.PlayerDEFPlus_Text = new System.Windows.Forms.Label();
            this.DEF_Text_Label = new System.Windows.Forms.Label();
            this.DEF_Text_Label1 = new System.Windows.Forms.Label();
            this.DEFInput_Box = new System.Windows.Forms.GroupBox();
            this.DEFCalc_Box = new System.Windows.Forms.GroupBox();
            this.DEFense = new System.Windows.Forms.Label();
            this.ToATK = new System.Windows.Forms.Label();
            this.Button_Confirm = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDEF1_P)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDEF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDEFBasic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDEFPlus1)).BeginInit();
            this.DEFInput_Box.SuspendLayout();
            this.DEFCalc_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerDEF1_P
            // 
            this.PlayerDEF1_P.AllowDrop = true;
            this.PlayerDEF1_P.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerDEF1_P.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerDEF1_P.LargeChange = 0;
            this.PlayerDEF1_P.Location = new System.Drawing.Point(260, 155);
            this.PlayerDEF1_P.Maximum = 1000;
            this.PlayerDEF1_P.Name = "PlayerDEF1_P";
            this.PlayerDEF1_P.Size = new System.Drawing.Size(494, 45);
            this.PlayerDEF1_P.TabIndex = 13;
            this.PlayerDEF1_P.TickStyle = System.Windows.Forms.TickStyle.None;
            this.PlayerDEF1_P.Scroll += new System.EventHandler(this.PlayerDEF1_P_Scroll);
            // 
            // PlayerDEF_Text
            // 
            this.PlayerDEF_Text.AutoSize = true;
            this.PlayerDEF_Text.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PlayerDEF_Text.Location = new System.Drawing.Point(10, 99);
            this.PlayerDEF_Text.Name = "PlayerDEF_Text";
            this.PlayerDEF_Text.Size = new System.Drawing.Size(117, 28);
            this.PlayerDEF_Text.TabIndex = 11;
            this.PlayerDEF_Text.Text = "绿字防御力";
            // 
            // PlayerDEF1
            // 
            this.PlayerDEF1.AllowDrop = true;
            this.PlayerDEF1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerDEF1.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerDEF1.LargeChange = 20;
            this.PlayerDEF1.Location = new System.Drawing.Point(260, 99);
            this.PlayerDEF1.Maximum = 3000;
            this.PlayerDEF1.Name = "PlayerDEF1";
            this.PlayerDEF1.Size = new System.Drawing.Size(494, 45);
            this.PlayerDEF1.TabIndex = 12;
            this.PlayerDEF1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.PlayerDEF1.Scroll += new System.EventHandler(this.PlayerDEF1_Scroll);
            // 
            // PlayerDEF
            // 
            this.PlayerDEF.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerDEF.Location = new System.Drawing.Point(145, 99);
            this.PlayerDEF.Name = "PlayerDEF";
            this.PlayerDEF.Size = new System.Drawing.Size(86, 32);
            this.PlayerDEF.TabIndex = 9;
            this.PlayerDEF.Text = "0";
            this.PlayerDEF.TextChanged += new System.EventHandler(this.PlayerDEF_TextChanged);
            // 
            // PlayerDEF_P
            // 
            this.PlayerDEF_P.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerDEF_P.Location = new System.Drawing.Point(145, 155);
            this.PlayerDEF_P.Name = "PlayerDEF_P";
            this.PlayerDEF_P.Size = new System.Drawing.Size(67, 32);
            this.PlayerDEF_P.TabIndex = 10;
            this.PlayerDEF_P.Text = "0";
            this.PlayerDEF_P.TextChanged += new System.EventHandler(this.PlayerDEF_P_TextChanged);
            // 
            // PlayerDEF_P_Text
            // 
            this.PlayerDEF_P_Text.AutoSize = true;
            this.PlayerDEF_P_Text.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PlayerDEF_P_Text.Location = new System.Drawing.Point(10, 155);
            this.PlayerDEF_P_Text.Name = "PlayerDEF_P_Text";
            this.PlayerDEF_P_Text.Size = new System.Drawing.Size(238, 28);
            this.PlayerDEF_P_Text.TabIndex = 14;
            this.PlayerDEF_P_Text.Text = "防御力加成                 %";
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
            // PlayerDEFBasic1
            // 
            this.PlayerDEFBasic1.AllowDrop = true;
            this.PlayerDEFBasic1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerDEFBasic1.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerDEFBasic1.LargeChange = 20;
            this.PlayerDEFBasic1.Location = new System.Drawing.Point(260, 43);
            this.PlayerDEFBasic1.Maximum = 1000;
            this.PlayerDEFBasic1.Name = "PlayerDEFBasic1";
            this.PlayerDEFBasic1.Size = new System.Drawing.Size(494, 45);
            this.PlayerDEFBasic1.TabIndex = 17;
            this.PlayerDEFBasic1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.PlayerDEFBasic1.Scroll += new System.EventHandler(this.PlayerDEFBasic1_Scroll);
            // 
            // PlayerDEFBasic
            // 
            this.PlayerDEFBasic.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerDEFBasic.Location = new System.Drawing.Point(145, 43);
            this.PlayerDEFBasic.Name = "PlayerDEFBasic";
            this.PlayerDEFBasic.Size = new System.Drawing.Size(86, 32);
            this.PlayerDEFBasic.TabIndex = 15;
            this.PlayerDEFBasic.Text = "0";
            this.PlayerDEFBasic.TextChanged += new System.EventHandler(this.PlayerDEFBasic_TextChanged);
            // 
            // PlayerDEFPlus1
            // 
            this.PlayerDEFPlus1.AllowDrop = true;
            this.PlayerDEFPlus1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerDEFPlus1.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerDEFPlus1.LargeChange = 0;
            this.PlayerDEFPlus1.Location = new System.Drawing.Point(260, 211);
            this.PlayerDEFPlus1.Maximum = 3000;
            this.PlayerDEFPlus1.Name = "PlayerDEFPlus1";
            this.PlayerDEFPlus1.Size = new System.Drawing.Size(494, 45);
            this.PlayerDEFPlus1.TabIndex = 19;
            this.PlayerDEFPlus1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.PlayerDEFPlus1.Scroll += new System.EventHandler(this.PlayerDEFPlus1_Scroll);
            // 
            // PlayerDEFPlus
            // 
            this.PlayerDEFPlus.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerDEFPlus.Location = new System.Drawing.Point(145, 211);
            this.PlayerDEFPlus.Name = "PlayerDEFPlus";
            this.PlayerDEFPlus.Size = new System.Drawing.Size(67, 32);
            this.PlayerDEFPlus.TabIndex = 18;
            this.PlayerDEFPlus.Text = "0";
            this.PlayerDEFPlus.TextChanged += new System.EventHandler(this.PlayerDEFPlus_TextChanged);
            // 
            // PlayerDEFPlus_Text
            // 
            this.PlayerDEFPlus_Text.AutoSize = true;
            this.PlayerDEFPlus_Text.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PlayerDEFPlus_Text.Location = new System.Drawing.Point(10, 211);
            this.PlayerDEFPlus_Text.Name = "PlayerDEFPlus_Text";
            this.PlayerDEFPlus_Text.Size = new System.Drawing.Size(238, 28);
            this.PlayerDEFPlus_Text.TabIndex = 20;
            this.PlayerDEFPlus_Text.Text = "防御转化率                 %";
            // 
            // DEF_Text_Label
            // 
            this.DEF_Text_Label.AutoSize = true;
            this.DEF_Text_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DEF_Text_Label.Location = new System.Drawing.Point(10, 37);
            this.DEF_Text_Label.Name = "DEF_Text_Label";
            this.DEF_Text_Label.Size = new System.Drawing.Size(138, 28);
            this.DEF_Text_Label.TabIndex = 21;
            this.DEF_Text_Label.Text = "防御力总值：";
            // 
            // DEF_Text_Label1
            // 
            this.DEF_Text_Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DEF_Text_Label1.AutoSize = true;
            this.DEF_Text_Label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DEF_Text_Label1.Location = new System.Drawing.Point(315, 37);
            this.DEF_Text_Label1.Name = "DEF_Text_Label1";
            this.DEF_Text_Label1.Size = new System.Drawing.Size(138, 28);
            this.DEF_Text_Label1.TabIndex = 22;
            this.DEF_Text_Label1.Text = "转化为攻击：";
            // 
            // DEFInput_Box
            // 
            this.DEFInput_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DEFInput_Box.Controls.Add(this.PlayerDEFBasic_Text);
            this.DEFInput_Box.Controls.Add(this.PlayerDEF_P);
            this.DEFInput_Box.Controls.Add(this.PlayerDEFPlus1);
            this.DEFInput_Box.Controls.Add(this.PlayerDEF);
            this.DEFInput_Box.Controls.Add(this.PlayerDEFPlus);
            this.DEFInput_Box.Controls.Add(this.PlayerDEF1);
            this.DEFInput_Box.Controls.Add(this.PlayerDEFPlus_Text);
            this.DEFInput_Box.Controls.Add(this.PlayerDEF_Text);
            this.DEFInput_Box.Controls.Add(this.PlayerDEF1_P);
            this.DEFInput_Box.Controls.Add(this.PlayerDEFBasic1);
            this.DEFInput_Box.Controls.Add(this.PlayerDEFBasic);
            this.DEFInput_Box.Controls.Add(this.PlayerDEF_P_Text);
            this.DEFInput_Box.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DEFInput_Box.Location = new System.Drawing.Point(12, 6);
            this.DEFInput_Box.Name = "DEFInput_Box";
            this.DEFInput_Box.Size = new System.Drawing.Size(760, 259);
            this.DEFInput_Box.TabIndex = 23;
            this.DEFInput_Box.TabStop = false;
            this.DEFInput_Box.Text = "防御属性填写";
            // 
            // DEFCalc_Box
            // 
            this.DEFCalc_Box.Controls.Add(this.ToATK);
            this.DEFCalc_Box.Controls.Add(this.DEFense);
            this.DEFCalc_Box.Controls.Add(this.DEF_Text_Label);
            this.DEFCalc_Box.Controls.Add(this.DEF_Text_Label1);
            this.DEFCalc_Box.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.DEFCalc_Box.Location = new System.Drawing.Point(12, 271);
            this.DEFCalc_Box.Name = "DEFCalc_Box";
            this.DEFCalc_Box.Size = new System.Drawing.Size(615, 88);
            this.DEFCalc_Box.TabIndex = 24;
            this.DEFCalc_Box.TabStop = false;
            this.DEFCalc_Box.Text = "计算结果";
            // 
            // DEFense
            // 
            this.DEFense.Font = new System.Drawing.Font("方正像素12", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DEFense.ForeColor = System.Drawing.Color.DarkRed;
            this.DEFense.Location = new System.Drawing.Point(140, 38);
            this.DEFense.Name = "DEFense";
            this.DEFense.Size = new System.Drawing.Size(165, 24);
            this.DEFense.TabIndex = 23;
            this.DEFense.Text = "0";
            this.DEFense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ToATK
            // 
            this.ToATK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToATK.Font = new System.Drawing.Font("方正像素12", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ToATK.ForeColor = System.Drawing.Color.DarkRed;
            this.ToATK.Location = new System.Drawing.Point(445, 37);
            this.ToATK.Name = "ToATK";
            this.ToATK.Size = new System.Drawing.Size(149, 24);
            this.ToATK.TabIndex = 24;
            this.ToATK.Text = "0";
            this.ToATK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Button_Confirm
            // 
            this.Button_Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Confirm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Button_Confirm.Location = new System.Drawing.Point(633, 281);
            this.Button_Confirm.Name = "Button_Confirm";
            this.Button_Confirm.Size = new System.Drawing.Size(139, 34);
            this.Button_Confirm.TabIndex = 25;
            this.Button_Confirm.Text = "确认填写";
            this.Button_Confirm.UseVisualStyleBackColor = true;
            this.Button_Confirm.Click += new System.EventHandler(this.Button_Confirm_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Cancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Button_Cancel.Location = new System.Drawing.Point(633, 325);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(139, 34);
            this.Button_Cancel.TabIndex = 26;
            this.Button_Cancel.Text = "取消填写";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Defence_Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 371);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Confirm);
            this.Controls.Add(this.DEFCalc_Box);
            this.Controls.Add(this.DEFInput_Box);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 410);
            this.Name = "Defence_Calc";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "防御收益计算";
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDEF1_P)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDEF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDEFBasic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDEFPlus1)).EndInit();
            this.DEFInput_Box.ResumeLayout(false);
            this.DEFInput_Box.PerformLayout();
            this.DEFCalc_Box.ResumeLayout(false);
            this.DEFCalc_Box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar PlayerDEF1_P;
        private System.Windows.Forms.Label PlayerDEF_Text;
        private System.Windows.Forms.TrackBar PlayerDEF1;
        private System.Windows.Forms.TextBox PlayerDEF;
        private System.Windows.Forms.TextBox PlayerDEF_P;
        private System.Windows.Forms.Label PlayerDEF_P_Text;
        private System.Windows.Forms.Label PlayerDEFBasic_Text;
        private System.Windows.Forms.TrackBar PlayerDEFBasic1;
        private System.Windows.Forms.TextBox PlayerDEFBasic;
        private System.Windows.Forms.TrackBar PlayerDEFPlus1;
        private System.Windows.Forms.TextBox PlayerDEFPlus;
        private System.Windows.Forms.Label PlayerDEFPlus_Text;
        private System.Windows.Forms.Label DEF_Text_Label;
        private System.Windows.Forms.Label DEF_Text_Label1;
        private System.Windows.Forms.GroupBox DEFInput_Box;
        private System.Windows.Forms.GroupBox DEFCalc_Box;
        private System.Windows.Forms.Label ToATK;
        private System.Windows.Forms.Label DEFense;
        private System.Windows.Forms.Button Button_Confirm;
        private System.Windows.Forms.Button Button_Cancel;
    }
}