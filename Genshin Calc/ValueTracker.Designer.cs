
namespace Genshin_Calc
{
    partial class ValueTracker
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Bar = new System.Windows.Forms.TrackBar();
            this.Value = new System.Windows.Forms.TextBox();
            this.LayoutGrid = new System.Windows.Forms.TableLayoutPanel();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.PercentSign = new System.Windows.Forms.Label();
            this.ValueChangeFX_Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Bar)).BeginInit();
            this.LayoutGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bar
            // 
            this.Bar.AllowDrop = true;
            this.Bar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bar.LargeChange = 50;
            this.Bar.Location = new System.Drawing.Point(296, 6);
            this.Bar.Margin = new System.Windows.Forms.Padding(6);
            this.Bar.Maximum = 2000;
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(475, 33);
            this.Bar.TabIndex = 8;
            this.Bar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Bar.Scroll += new System.EventHandler(this.Bar_Scroll);
            // 
            // Value
            // 
            this.Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Value.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value.ForeColor = System.Drawing.Color.Black;
            this.Value.Location = new System.Drawing.Point(177, 6);
            this.Value.Margin = new System.Windows.Forms.Padding(1, 6, 1, 6);
            this.Value.MaxLength = 6;
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(82, 32);
            this.Value.TabIndex = 7;
            this.Value.TextChanged += new System.EventHandler(this.Value_TextChanged);
            this.Value.Leave += new System.EventHandler(this.FocusLost);
            // 
            // LayoutGrid
            // 
            this.LayoutGrid.ColumnCount = 4;
            this.LayoutGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.LayoutGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.LayoutGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LayoutGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutGrid.Controls.Add(this.Value, 1, 0);
            this.LayoutGrid.Controls.Add(this.Bar, 3, 0);
            this.LayoutGrid.Controls.Add(this.ValueLabel, 0, 0);
            this.LayoutGrid.Controls.Add(this.PercentSign, 2, 0);
            this.LayoutGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutGrid.Location = new System.Drawing.Point(0, 0);
            this.LayoutGrid.Margin = new System.Windows.Forms.Padding(1, 6, 1, 6);
            this.LayoutGrid.Name = "LayoutGrid";
            this.LayoutGrid.RowCount = 1;
            this.LayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.LayoutGrid.Size = new System.Drawing.Size(777, 45);
            this.LayoutGrid.TabIndex = 10;
            // 
            // ValueLabel
            // 
            this.ValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValueLabel.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ValueLabel.Location = new System.Drawing.Point(6, 0);
            this.ValueLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(164, 45);
            this.ValueLabel.TabIndex = 9;
            this.ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PercentSign
            // 
            this.PercentSign.AutoSize = true;
            this.PercentSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PercentSign.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.PercentSign.Location = new System.Drawing.Point(263, 0);
            this.PercentSign.Name = "PercentSign";
            this.PercentSign.Size = new System.Drawing.Size(24, 45);
            this.PercentSign.TabIndex = 10;
            this.PercentSign.Text = "%";
            this.PercentSign.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ValueChangeFX_Timer
            // 
            this.ValueChangeFX_Timer.Enabled = true;
            this.ValueChangeFX_Timer.Interval = 10;
            this.ValueChangeFX_Timer.Tick += new System.EventHandler(this.ValueChangeFX_Timer_Tick);
            // 
            // ValueTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LayoutGrid);
            this.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ValueTracker";
            this.Size = new System.Drawing.Size(777, 45);
            this.Load += new System.EventHandler(this.TrackerLoad);
            ((System.ComponentModel.ISupportInitialize)(this.Bar)).EndInit();
            this.LayoutGrid.ResumeLayout(false);
            this.LayoutGrid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label ValueLabel;
        public System.Windows.Forms.TrackBar Bar;
        public System.Windows.Forms.TextBox Value;
        public System.Windows.Forms.TableLayoutPanel LayoutGrid;
        private System.Windows.Forms.Label PercentSign;
        private System.Windows.Forms.Timer ValueChangeFX_Timer;
    }
}
