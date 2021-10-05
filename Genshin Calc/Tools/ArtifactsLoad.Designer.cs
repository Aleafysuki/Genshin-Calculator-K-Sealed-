namespace Genshin_Calc
{
    partial class ArtifactsLoad
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
            this.components = new System.ComponentModel.Container();
            this.Flower = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Flower_Filter = new System.Windows.Forms.ComboBox();
            this.FlowerPreview = new System.Windows.Forms.TextBox();
            this.List_Flower = new System.Windows.Forms.ListBox();
            this.Plume = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Plume_Filter = new System.Windows.Forms.ComboBox();
            this.PlumePreview = new System.Windows.Forms.TextBox();
            this.List_Plume = new System.Windows.Forms.ListBox();
            this.Sands = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Sands_Filter = new System.Windows.Forms.ComboBox();
            this.SandsPreview = new System.Windows.Forms.TextBox();
            this.List_Sands = new System.Windows.Forms.ListBox();
            this.Goblet = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Goblet_Filter = new System.Windows.Forms.ComboBox();
            this.GobletPreview = new System.Windows.Forms.TextBox();
            this.List_Goblet = new System.Windows.Forms.ListBox();
            this.Circlet = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Circlet_Filter = new System.Windows.Forms.ComboBox();
            this.CircletPreview = new System.Windows.Forms.TextBox();
            this.List_Circlet = new System.Windows.Forms.ListBox();
            this.ArtifactInfo = new System.Windows.Forms.ToolTip(this.components);
            this.ArtifactResult = new System.Windows.Forms.GroupBox();
            this.IgnoreMainTags = new System.Windows.Forms.CheckBox();
            this.ResultList = new System.Windows.Forms.ListView();
            this.SumAttributeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SumAttributeValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SumAttributeEntries = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InputButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BasicATK_Auto = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.BasicATK_Manual = new System.Windows.Forms.TextBox();
            this.ArtifactCancelButton = new System.Windows.Forms.Button();
            this.OtherAttributesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WhoTao_Check = new System.Windows.Forms.CheckBox();
            this.TotalEntriesCount = new System.Windows.Forms.Label();
            this.BasicLife = new System.Windows.Forms.TextBox();
            this.BasicDefence = new System.Windows.Forms.TextBox();
            this.JsonFileLocation = new System.Windows.Forms.TextBox();
            this.JsonFileLabel = new System.Windows.Forms.Label();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.SelectJsonFile = new System.Windows.Forms.OpenFileDialog();
            this.Flower.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Plume.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Sands.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.Goblet.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.Circlet.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.ArtifactResult.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Flower
            // 
            this.Flower.Controls.Add(this.tableLayoutPanel1);
            this.Flower.Location = new System.Drawing.Point(7, 54);
            this.Flower.Margin = new System.Windows.Forms.Padding(1);
            this.Flower.Name = "Flower";
            this.Flower.Size = new System.Drawing.Size(200, 528);
            this.Flower.TabIndex = 0;
            this.Flower.TabStop = false;
            this.Flower.Text = "生之花";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Flower_Filter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FlowerPreview, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.List_Flower, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(194, 499);
            this.tableLayoutPanel1.TabIndex = 72;
            // 
            // Flower_Filter
            // 
            this.Flower_Filter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flower_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Flower_Filter.Enabled = false;
            this.Flower_Filter.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Flower_Filter.FormattingEnabled = true;
            this.Flower_Filter.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Flower_Filter.Items.AddRange(new object[] {
            "全部"});
            this.Flower_Filter.Location = new System.Drawing.Point(3, 3);
            this.Flower_Filter.Name = "Flower_Filter";
            this.Flower_Filter.Size = new System.Drawing.Size(188, 33);
            this.Flower_Filter.TabIndex = 71;
            this.Flower_Filter.Visible = false;
            // 
            // FlowerPreview
            // 
            this.FlowerPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowerPreview.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F);
            this.FlowerPreview.Location = new System.Drawing.Point(0, 331);
            this.FlowerPreview.Margin = new System.Windows.Forms.Padding(0);
            this.FlowerPreview.Multiline = true;
            this.FlowerPreview.Name = "FlowerPreview";
            this.FlowerPreview.ReadOnly = true;
            this.FlowerPreview.Size = new System.Drawing.Size(194, 168);
            this.FlowerPreview.TabIndex = 5;
            // 
            // List_Flower
            // 
            this.List_Flower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List_Flower.FormattingEnabled = true;
            this.List_Flower.ItemHeight = 23;
            this.List_Flower.Location = new System.Drawing.Point(3, 3);
            this.List_Flower.Name = "List_Flower";
            this.List_Flower.Size = new System.Drawing.Size(188, 325);
            this.List_Flower.TabIndex = 5;
            this.List_Flower.SelectedIndexChanged += new System.EventHandler(this.ListClick_1);
            // 
            // Plume
            // 
            this.Plume.Controls.Add(this.tableLayoutPanel2);
            this.Plume.Location = new System.Drawing.Point(209, 54);
            this.Plume.Margin = new System.Windows.Forms.Padding(1);
            this.Plume.Name = "Plume";
            this.Plume.Size = new System.Drawing.Size(200, 528);
            this.Plume.TabIndex = 1;
            this.Plume.TabStop = false;
            this.Plume.Text = "死之羽";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Plume_Filter, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.PlumePreview, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.List_Plume, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(194, 499);
            this.tableLayoutPanel2.TabIndex = 73;
            // 
            // Plume_Filter
            // 
            this.Plume_Filter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Plume_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Plume_Filter.Enabled = false;
            this.Plume_Filter.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Plume_Filter.FormattingEnabled = true;
            this.Plume_Filter.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Plume_Filter.Items.AddRange(new object[] {
            "全部"});
            this.Plume_Filter.Location = new System.Drawing.Point(3, 3);
            this.Plume_Filter.Name = "Plume_Filter";
            this.Plume_Filter.Size = new System.Drawing.Size(188, 33);
            this.Plume_Filter.TabIndex = 72;
            this.Plume_Filter.Visible = false;
            // 
            // PlumePreview
            // 
            this.PlumePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlumePreview.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F);
            this.PlumePreview.Location = new System.Drawing.Point(0, 331);
            this.PlumePreview.Margin = new System.Windows.Forms.Padding(0);
            this.PlumePreview.Multiline = true;
            this.PlumePreview.Name = "PlumePreview";
            this.PlumePreview.ReadOnly = true;
            this.PlumePreview.Size = new System.Drawing.Size(194, 168);
            this.PlumePreview.TabIndex = 6;
            // 
            // List_Plume
            // 
            this.List_Plume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List_Plume.FormattingEnabled = true;
            this.List_Plume.ItemHeight = 23;
            this.List_Plume.Location = new System.Drawing.Point(3, 3);
            this.List_Plume.Name = "List_Plume";
            this.List_Plume.Size = new System.Drawing.Size(188, 325);
            this.List_Plume.TabIndex = 0;
            this.List_Plume.SelectedIndexChanged += new System.EventHandler(this.ListClick_2);
            // 
            // Sands
            // 
            this.Sands.Controls.Add(this.tableLayoutPanel3);
            this.Sands.Location = new System.Drawing.Point(411, 54);
            this.Sands.Margin = new System.Windows.Forms.Padding(1);
            this.Sands.Name = "Sands";
            this.Sands.Size = new System.Drawing.Size(200, 528);
            this.Sands.TabIndex = 2;
            this.Sands.TabStop = false;
            this.Sands.Text = "时之沙";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.Sands_Filter, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.SandsPreview, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.List_Sands, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(194, 499);
            this.tableLayoutPanel3.TabIndex = 74;
            // 
            // Sands_Filter
            // 
            this.Sands_Filter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sands_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sands_Filter.Enabled = false;
            this.Sands_Filter.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Sands_Filter.FormattingEnabled = true;
            this.Sands_Filter.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Sands_Filter.Items.AddRange(new object[] {
            "全部"});
            this.Sands_Filter.Location = new System.Drawing.Point(3, 3);
            this.Sands_Filter.Name = "Sands_Filter";
            this.Sands_Filter.Size = new System.Drawing.Size(188, 33);
            this.Sands_Filter.TabIndex = 72;
            this.Sands_Filter.Visible = false;
            // 
            // SandsPreview
            // 
            this.SandsPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SandsPreview.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F);
            this.SandsPreview.Location = new System.Drawing.Point(0, 331);
            this.SandsPreview.Margin = new System.Windows.Forms.Padding(0);
            this.SandsPreview.Multiline = true;
            this.SandsPreview.Name = "SandsPreview";
            this.SandsPreview.ReadOnly = true;
            this.SandsPreview.Size = new System.Drawing.Size(194, 168);
            this.SandsPreview.TabIndex = 6;
            // 
            // List_Sands
            // 
            this.List_Sands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List_Sands.FormattingEnabled = true;
            this.List_Sands.ItemHeight = 23;
            this.List_Sands.Location = new System.Drawing.Point(3, 3);
            this.List_Sands.Name = "List_Sands";
            this.List_Sands.Size = new System.Drawing.Size(188, 325);
            this.List_Sands.TabIndex = 1;
            this.List_Sands.SelectedIndexChanged += new System.EventHandler(this.ListClick_3);
            // 
            // Goblet
            // 
            this.Goblet.Controls.Add(this.tableLayoutPanel4);
            this.Goblet.Location = new System.Drawing.Point(613, 54);
            this.Goblet.Margin = new System.Windows.Forms.Padding(1);
            this.Goblet.Name = "Goblet";
            this.Goblet.Size = new System.Drawing.Size(200, 528);
            this.Goblet.TabIndex = 2;
            this.Goblet.TabStop = false;
            this.Goblet.Text = "空之杯";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.Goblet_Filter, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.GobletPreview, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.List_Goblet, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(194, 499);
            this.tableLayoutPanel4.TabIndex = 74;
            // 
            // Goblet_Filter
            // 
            this.Goblet_Filter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Goblet_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Goblet_Filter.Enabled = false;
            this.Goblet_Filter.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Goblet_Filter.FormattingEnabled = true;
            this.Goblet_Filter.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Goblet_Filter.Items.AddRange(new object[] {
            "全部"});
            this.Goblet_Filter.Location = new System.Drawing.Point(3, 3);
            this.Goblet_Filter.Name = "Goblet_Filter";
            this.Goblet_Filter.Size = new System.Drawing.Size(188, 33);
            this.Goblet_Filter.TabIndex = 72;
            this.Goblet_Filter.Visible = false;
            // 
            // GobletPreview
            // 
            this.GobletPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GobletPreview.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F);
            this.GobletPreview.Location = new System.Drawing.Point(0, 331);
            this.GobletPreview.Margin = new System.Windows.Forms.Padding(0);
            this.GobletPreview.Multiline = true;
            this.GobletPreview.Name = "GobletPreview";
            this.GobletPreview.ReadOnly = true;
            this.GobletPreview.Size = new System.Drawing.Size(194, 168);
            this.GobletPreview.TabIndex = 6;
            // 
            // List_Goblet
            // 
            this.List_Goblet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List_Goblet.FormattingEnabled = true;
            this.List_Goblet.ItemHeight = 23;
            this.List_Goblet.Location = new System.Drawing.Point(3, 3);
            this.List_Goblet.Name = "List_Goblet";
            this.List_Goblet.Size = new System.Drawing.Size(188, 325);
            this.List_Goblet.TabIndex = 1;
            this.List_Goblet.SelectedIndexChanged += new System.EventHandler(this.ListClick_4);
            // 
            // Circlet
            // 
            this.Circlet.Controls.Add(this.tableLayoutPanel5);
            this.Circlet.Location = new System.Drawing.Point(815, 54);
            this.Circlet.Margin = new System.Windows.Forms.Padding(1);
            this.Circlet.Name = "Circlet";
            this.Circlet.Size = new System.Drawing.Size(200, 528);
            this.Circlet.TabIndex = 2;
            this.Circlet.TabStop = false;
            this.Circlet.Text = "理之冠";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.Circlet_Filter, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.CircletPreview, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.List_Circlet, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(194, 499);
            this.tableLayoutPanel5.TabIndex = 74;
            // 
            // Circlet_Filter
            // 
            this.Circlet_Filter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Circlet_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Circlet_Filter.Enabled = false;
            this.Circlet_Filter.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Circlet_Filter.FormattingEnabled = true;
            this.Circlet_Filter.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Circlet_Filter.Items.AddRange(new object[] {
            "全部"});
            this.Circlet_Filter.Location = new System.Drawing.Point(3, 3);
            this.Circlet_Filter.Name = "Circlet_Filter";
            this.Circlet_Filter.Size = new System.Drawing.Size(188, 33);
            this.Circlet_Filter.TabIndex = 72;
            this.Circlet_Filter.Visible = false;
            // 
            // CircletPreview
            // 
            this.CircletPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CircletPreview.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F);
            this.CircletPreview.Location = new System.Drawing.Point(0, 331);
            this.CircletPreview.Margin = new System.Windows.Forms.Padding(0);
            this.CircletPreview.Multiline = true;
            this.CircletPreview.Name = "CircletPreview";
            this.CircletPreview.ReadOnly = true;
            this.CircletPreview.Size = new System.Drawing.Size(194, 168);
            this.CircletPreview.TabIndex = 6;
            // 
            // List_Circlet
            // 
            this.List_Circlet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List_Circlet.FormattingEnabled = true;
            this.List_Circlet.ItemHeight = 23;
            this.List_Circlet.Location = new System.Drawing.Point(3, 3);
            this.List_Circlet.Name = "List_Circlet";
            this.List_Circlet.Size = new System.Drawing.Size(188, 325);
            this.List_Circlet.TabIndex = 1;
            this.List_Circlet.SelectedIndexChanged += new System.EventHandler(this.ListClick_5);
            // 
            // ArtifactInfo
            // 
            this.ArtifactInfo.AutomaticDelay = 20;
            this.ArtifactInfo.AutoPopDelay = 10000;
            this.ArtifactInfo.InitialDelay = 20;
            this.ArtifactInfo.ReshowDelay = 4;
            // 
            // ArtifactResult
            // 
            this.ArtifactResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArtifactResult.Controls.Add(this.IgnoreMainTags);
            this.ArtifactResult.Controls.Add(this.ResultList);
            this.ArtifactResult.Location = new System.Drawing.Point(1020, 54);
            this.ArtifactResult.Name = "ArtifactResult";
            this.ArtifactResult.Size = new System.Drawing.Size(274, 449);
            this.ArtifactResult.TabIndex = 4;
            this.ArtifactResult.TabStop = false;
            this.ArtifactResult.Text = "总体结果";
            // 
            // IgnoreMainTags
            // 
            this.IgnoreMainTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.IgnoreMainTags.Location = new System.Drawing.Point(3, 26);
            this.IgnoreMainTags.Name = "IgnoreMainTags";
            this.IgnoreMainTags.Size = new System.Drawing.Size(268, 28);
            this.IgnoreMainTags.TabIndex = 17;
            this.IgnoreMainTags.Text = "仅查看副属性 (便于词条pvp)";
            this.IgnoreMainTags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IgnoreMainTags.UseVisualStyleBackColor = true;
            this.IgnoreMainTags.CheckedChanged += new System.EventHandler(this.IgnoreMainTags_CheckedChanged);
            // 
            // ResultList
            // 
            this.ResultList.AllowColumnReorder = true;
            this.ResultList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ResultList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultList.CheckBoxes = true;
            this.ResultList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SumAttributeName,
            this.SumAttributeValue,
            this.SumAttributeEntries});
            this.ResultList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ResultList.HideSelection = false;
            this.ResultList.Location = new System.Drawing.Point(3, 54);
            this.ResultList.Name = "ResultList";
            this.ResultList.Size = new System.Drawing.Size(268, 392);
            this.ResultList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ResultList.TabIndex = 0;
            this.ResultList.UseCompatibleStateImageBehavior = false;
            this.ResultList.View = System.Windows.Forms.View.Details;
            this.ResultList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.EntriesSum);
            // 
            // SumAttributeName
            // 
            this.SumAttributeName.Text = "属性";
            this.SumAttributeName.Width = 92;
            // 
            // SumAttributeValue
            // 
            this.SumAttributeValue.Text = "数值";
            this.SumAttributeValue.Width = 98;
            // 
            // SumAttributeEntries
            // 
            this.SumAttributeEntries.Text = "词条数";
            this.SumAttributeEntries.Width = 64;
            // 
            // InputButton
            // 
            this.InputButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputButton.Location = new System.Drawing.Point(1023, 509);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(274, 31);
            this.InputButton.TabIndex = 5;
            this.InputButton.Text = "导入至主窗口";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BasicATK_Auto);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.BasicATK_Manual);
            this.groupBox1.Location = new System.Drawing.Point(7, 586);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 69);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基础攻击力 (必填)";
            // 
            // BasicATK_Auto
            // 
            this.BasicATK_Auto.Location = new System.Drawing.Point(121, 27);
            this.BasicATK_Auto.Name = "BasicATK_Auto";
            this.BasicATK_Auto.Size = new System.Drawing.Size(128, 30);
            this.BasicATK_Auto.TabIndex = 14;
            this.BasicATK_Auto.Text = "查询";
            this.BasicATK_Auto.UseVisualStyleBackColor = true;
            this.BasicATK_Auto.Click += new System.EventHandler(this.BasicATK_Auto_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.Checked = true;
            this.radioButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioButton2.Location = new System.Drawing.Point(266, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 30);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "手动输入";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.InputMethodSelection);
            // 
            // radioButton1
            // 
            this.radioButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioButton1.Location = new System.Drawing.Point(12, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 30);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.Text = "自行查询";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.InputMethodSelection);
            // 
            // BasicATK_Manual
            // 
            this.BasicATK_Manual.Location = new System.Drawing.Point(375, 27);
            this.BasicATK_Manual.Name = "BasicATK_Manual";
            this.BasicATK_Manual.Size = new System.Drawing.Size(128, 30);
            this.BasicATK_Manual.TabIndex = 11;
            this.BasicATK_Manual.TextChanged += new System.EventHandler(this.BasicATK_Manual_TextChanged);
            // 
            // ArtifactCancelButton
            // 
            this.ArtifactCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArtifactCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ArtifactCancelButton.Location = new System.Drawing.Point(1023, 546);
            this.ArtifactCancelButton.Name = "ArtifactCancelButton";
            this.ArtifactCancelButton.Size = new System.Drawing.Size(274, 31);
            this.ArtifactCancelButton.TabIndex = 7;
            this.ArtifactCancelButton.Text = "取消填写";
            this.ArtifactCancelButton.UseVisualStyleBackColor = true;
            // 
            // OtherAttributesLabel
            // 
            this.OtherAttributesLabel.Location = new System.Drawing.Point(533, 590);
            this.OtherAttributesLabel.Name = "OtherAttributesLabel";
            this.OtherAttributesLabel.Size = new System.Drawing.Size(407, 24);
            this.OtherAttributesLabel.TabIndex = 8;
            this.OtherAttributesLabel.Text = "其他属性基础值填写（选填，计算副词条数量用）：";
            this.OtherAttributesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(533, 622);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "基础生命值";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(768, 622);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "基础防御力";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WhoTao_Check
            // 
            this.WhoTao_Check.AutoSize = true;
            this.WhoTao_Check.Location = new System.Drawing.Point(1018, 586);
            this.WhoTao_Check.Name = "WhoTao_Check";
            this.WhoTao_Check.Size = new System.Drawing.Size(245, 28);
            this.WhoTao_Check.TabIndex = 11;
            this.WhoTao_Check.Text = "攻击降权（胡桃词条计算）";
            this.WhoTao_Check.UseVisualStyleBackColor = true;
            this.WhoTao_Check.CheckedChanged += new System.EventHandler(this.BasicATK_Manual_TextChanged);
            // 
            // TotalEntriesCount
            // 
            this.TotalEntriesCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalEntriesCount.Location = new System.Drawing.Point(1014, 621);
            this.TotalEntriesCount.Name = "TotalEntriesCount";
            this.TotalEntriesCount.Size = new System.Drawing.Size(283, 24);
            this.TotalEntriesCount.TabIndex = 12;
            this.TotalEntriesCount.Text = "选中的总词条数：";
            this.TotalEntriesCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BasicLife
            // 
            this.BasicLife.Location = new System.Drawing.Point(634, 619);
            this.BasicLife.Name = "BasicLife";
            this.BasicLife.Size = new System.Drawing.Size(128, 30);
            this.BasicLife.TabIndex = 15;
            this.BasicLife.TextChanged += new System.EventHandler(this.BasicATK_Manual_TextChanged);
            // 
            // BasicDefence
            // 
            this.BasicDefence.Location = new System.Drawing.Point(870, 619);
            this.BasicDefence.Name = "BasicDefence";
            this.BasicDefence.Size = new System.Drawing.Size(128, 30);
            this.BasicDefence.TabIndex = 16;
            this.BasicDefence.TextChanged += new System.EventHandler(this.BasicATK_Manual_TextChanged);
            // 
            // JsonFileLocation
            // 
            this.JsonFileLocation.AllowDrop = true;
            this.JsonFileLocation.Location = new System.Drawing.Point(152, 13);
            this.JsonFileLocation.Name = "JsonFileLocation";
            this.JsonFileLocation.Size = new System.Drawing.Size(857, 30);
            this.JsonFileLocation.TabIndex = 17;
            this.JsonFileLocation.WordWrap = false;
            this.JsonFileLocation.DragDrop += new System.Windows.Forms.DragEventHandler(this.JsonFileLocation_DragDrop);
            this.JsonFileLocation.DragEnter += new System.Windows.Forms.DragEventHandler(this.JsonFileLocation_DragDrop);
            this.JsonFileLocation.Leave += new System.EventHandler(this.JsonFileLocation_Leave);
            // 
            // JsonFileLabel
            // 
            this.JsonFileLabel.AutoSize = true;
            this.JsonFileLabel.Location = new System.Drawing.Point(9, 16);
            this.JsonFileLabel.Name = "JsonFileLabel";
            this.JsonFileLabel.Size = new System.Drawing.Size(137, 24);
            this.JsonFileLabel.TabIndex = 18;
            this.JsonFileLabel.Text = "Json文件路径：";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(1015, 13);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(138, 30);
            this.OpenFileButton.TabIndex = 19;
            this.OpenFileButton.Text = "读取路径";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(1159, 13);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(138, 30);
            this.SelectFileButton.TabIndex = 20;
            this.SelectFileButton.Text = "手动选择";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // SelectJsonFile
            // 
            this.SelectJsonFile.DefaultExt = "json";
            this.SelectJsonFile.Filter = "Json文件|*.json|文本文件|*.txt|所有文件|*.*";
            this.SelectJsonFile.Title = "选择Json文件";
            // 
            // ArtifactsLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 662);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.JsonFileLabel);
            this.Controls.Add(this.JsonFileLocation);
            this.Controls.Add(this.BasicDefence);
            this.Controls.Add(this.BasicLife);
            this.Controls.Add(this.TotalEntriesCount);
            this.Controls.Add(this.WhoTao_Check);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OtherAttributesLabel);
            this.Controls.Add(this.ArtifactCancelButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.ArtifactResult);
            this.Controls.Add(this.Circlet);
            this.Controls.Add(this.Goblet);
            this.Controls.Add(this.Sands);
            this.Controls.Add(this.Plume);
            this.Controls.Add(this.Flower);
            this.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ArtifactsLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "圣遗物录入( 仅兼容适用于莫娜占卜铺对应的Json 文件 )";
            this.Flower.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Plume.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.Sands.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.Goblet.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.Circlet.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ArtifactResult.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Flower;
        private System.Windows.Forms.GroupBox Plume;
        private System.Windows.Forms.GroupBox Sands;
        private System.Windows.Forms.GroupBox Goblet;
        private System.Windows.Forms.GroupBox Circlet;
        private System.Windows.Forms.ToolTip ArtifactInfo;
        private System.Windows.Forms.GroupBox ArtifactResult;
        private System.Windows.Forms.ListView ResultList;
        private System.Windows.Forms.ColumnHeader SumAttributeName;
        private System.Windows.Forms.ColumnHeader SumAttributeValue;
        private System.Windows.Forms.ListBox List_Flower;
        private System.Windows.Forms.ListBox List_Plume;
        private System.Windows.Forms.ListBox List_Sands;
        private System.Windows.Forms.ListBox List_Goblet;
        private System.Windows.Forms.ListBox List_Circlet;
        private System.Windows.Forms.TextBox FlowerPreview;
        private System.Windows.Forms.TextBox PlumePreview;
        private System.Windows.Forms.TextBox SandsPreview;
        private System.Windows.Forms.TextBox GobletPreview;
        private System.Windows.Forms.TextBox CircletPreview;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BasicATK_Auto;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox BasicATK_Manual;
        private System.Windows.Forms.Button ArtifactCancelButton;
        private System.Windows.Forms.ColumnHeader SumAttributeEntries;
        private System.Windows.Forms.Label OtherAttributesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox WhoTao_Check;
        private System.Windows.Forms.Label TotalEntriesCount;
        private System.Windows.Forms.TextBox BasicLife;
        private System.Windows.Forms.TextBox BasicDefence;
        private System.Windows.Forms.CheckBox IgnoreMainTags;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox Flower_Filter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox Plume_Filter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox Sands_Filter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox Goblet_Filter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ComboBox Circlet_Filter;
        private System.Windows.Forms.TextBox JsonFileLocation;
        private System.Windows.Forms.Label JsonFileLabel;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.OpenFileDialog SelectJsonFile;
    }
}