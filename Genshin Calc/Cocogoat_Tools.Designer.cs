namespace Genshin_Calc
{
    partial class Cocogoat_Tools
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
            this.Flower = new System.Windows.Forms.GroupBox();
            this.Plume = new System.Windows.Forms.GroupBox();
            this.Sands = new System.Windows.Forms.GroupBox();
            this.Goblet = new System.Windows.Forms.GroupBox();
            this.Circlet = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Flower
            // 
            this.Flower.Location = new System.Drawing.Point(12, 12);
            this.Flower.Name = "Flower";
            this.Flower.Size = new System.Drawing.Size(180, 360);
            this.Flower.TabIndex = 0;
            this.Flower.TabStop = false;
            this.Flower.Text = "生之花";
            // 
            // Plume
            // 
            this.Plume.Location = new System.Drawing.Point(198, 12);
            this.Plume.Name = "Plume";
            this.Plume.Size = new System.Drawing.Size(180, 360);
            this.Plume.TabIndex = 1;
            this.Plume.TabStop = false;
            this.Plume.Text = "死之羽";
            // 
            // Sands
            // 
            this.Sands.Location = new System.Drawing.Point(384, 12);
            this.Sands.Name = "Sands";
            this.Sands.Size = new System.Drawing.Size(180, 360);
            this.Sands.TabIndex = 2;
            this.Sands.TabStop = false;
            this.Sands.Text = "时之沙";
            // 
            // Goblet
            // 
            this.Goblet.Location = new System.Drawing.Point(570, 12);
            this.Goblet.Name = "Goblet";
            this.Goblet.Size = new System.Drawing.Size(180, 360);
            this.Goblet.TabIndex = 2;
            this.Goblet.TabStop = false;
            this.Goblet.Text = "空之杯";
            // 
            // Circlet
            // 
            this.Circlet.Location = new System.Drawing.Point(756, 12);
            this.Circlet.Name = "Circlet";
            this.Circlet.Size = new System.Drawing.Size(180, 360);
            this.Circlet.TabIndex = 2;
            this.Circlet.TabStop = false;
            this.Circlet.Text = "理之冠";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(756, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "确认导入";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Cocogoat_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 426);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Circlet);
            this.Controls.Add(this.Goblet);
            this.Controls.Add(this.Sands);
            this.Controls.Add(this.Plume);
            this.Controls.Add(this.Flower);
            this.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Cocogoat_Tools";
            this.Text = "Cocogoat圣遗物录入";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Flower;
        private System.Windows.Forms.GroupBox Plume;
        private System.Windows.Forms.GroupBox Sands;
        private System.Windows.Forms.GroupBox Goblet;
        private System.Windows.Forms.GroupBox Circlet;
        private System.Windows.Forms.Button button1;
    }
}