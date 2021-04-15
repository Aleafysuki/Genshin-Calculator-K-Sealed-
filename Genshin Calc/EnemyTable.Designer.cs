namespace Genshin_Calc
{
    partial class EnemyTable
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
            this.Enemy_Select = new System.Windows.Forms.ComboBox();
            this.RESSelectorBox = new System.Windows.Forms.ListBox();
            this.Confirm_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Enemy_Select
            // 
            this.Enemy_Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Enemy_Select.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Enemy_Select.FormattingEnabled = true;
            this.Enemy_Select.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Enemy_Select.Location = new System.Drawing.Point(12, 12);
            this.Enemy_Select.MaxDropDownItems = 16;
            this.Enemy_Select.Name = "Enemy_Select";
            this.Enemy_Select.Size = new System.Drawing.Size(274, 33);
            this.Enemy_Select.TabIndex = 31;
            this.Enemy_Select.SelectedIndexChanged += new System.EventHandler(this.Enemy_Select_SelectedIndexChanged);
            // 
            // RESSelectorBox
            // 
            this.RESSelectorBox.BackColor = System.Drawing.SystemColors.Control;
            this.RESSelectorBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RESSelectorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RESSelectorBox.Font = new System.Drawing.Font("微软雅黑 Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RESSelectorBox.FormattingEnabled = true;
            this.RESSelectorBox.ItemHeight = 31;
            this.RESSelectorBox.Location = new System.Drawing.Point(12, 51);
            this.RESSelectorBox.Name = "RESSelectorBox";
            this.RESSelectorBox.Size = new System.Drawing.Size(274, 279);
            this.RESSelectorBox.TabIndex = 34;
            // 
            // Confirm_Button
            // 
            this.Confirm_Button.Font = new System.Drawing.Font("微软雅黑", 13.25F);
            this.Confirm_Button.Location = new System.Drawing.Point(12, 336);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.Size = new System.Drawing.Size(134, 33);
            this.Confirm_Button.TabIndex = 35;
            this.Confirm_Button.Text = "完成";
            this.Confirm_Button.UseVisualStyleBackColor = true;
            this.Confirm_Button.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Font = new System.Drawing.Font("微软雅黑", 13.25F);
            this.Cancel_Button.Location = new System.Drawing.Point(152, 336);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(134, 33);
            this.Cancel_Button.TabIndex = 36;
            this.Cancel_Button.Text = "取消";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EnemyTable
            // 
            this.AcceptButton = this.Confirm_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 381);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Confirm_Button);
            this.Controls.Add(this.Enemy_Select);
            this.Controls.Add(this.RESSelectorBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnemyTable";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "敌方数据速查";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Enemy_Select;
        private System.Windows.Forms.ListBox RESSelectorBox;
        private System.Windows.Forms.Button Confirm_Button;
        private System.Windows.Forms.Button Cancel_Button;
    }
}