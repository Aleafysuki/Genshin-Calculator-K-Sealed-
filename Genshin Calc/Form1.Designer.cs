using System.Windows.Forms;

namespace Genshin_Calc
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "基础攻击",
            "0",
            "---"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "攻击加成",
            "1x",
            "0%"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "天赋倍率",
            "1x",
            "0%"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "伤害加深",
            "1x",
            "0%"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "暴击伤害",
            "1x",
            "0%"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "防御计算",
            "1x",
            "0%"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "抗性计算",
            "1x",
            "0%"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "元素反应",
            "1x",
            "0%"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "额外乘区",
            "1x",
            "0%"}, -1);
            System.Windows.Forms.DataVisualization.Charting.TextAnnotation textAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
            System.Windows.Forms.DataVisualization.Charting.TextAnnotation textAnnotation2 = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
            System.Windows.Forms.DataVisualization.Charting.TextAnnotation textAnnotation3 = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn1 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn2 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据存放文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读取ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.存档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数值上下限设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口置顶ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修复字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.角色与武器快捷输入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.敌人抗性快速查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cocogoat圣遗物导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.特殊计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.诺艾尔防御转攻击ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.阿贝多防御值加伤替换攻击ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.钟离生命值加伤ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.胡桃生命值加攻ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windows计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.锚定伤害计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.治疗量计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DPS简易计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.圣遗物简易比较器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使用入门ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算公式来源ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.P1 = new System.Windows.Forms.TabControl();
            this.Basic = new System.Windows.Forms.TabPage();
            this.BasicGroup = new System.Windows.Forms.GroupBox();
            this.DamageBuff_Elem = new Genshin_Calc.ValueTracker();
            this.Crit_Damage = new Genshin_Calc.ValueTracker();
            this.Crit_Rate = new Genshin_Calc.ValueTracker();
            this.ElemMastery = new Genshin_Calc.ValueTracker();
            this.ATK_Added = new Genshin_Calc.ValueTracker();
            this.ATK_Basic = new Genshin_Calc.ValueTracker();
            this.ATK_Buff = new System.Windows.Forms.TabPage();
            this.ATKBuff_Stack_Group = new System.Windows.Forms.GroupBox();
            this.ATKBuff_Stack_Count = new Genshin_Calc.ValueTracker();
            this.ATKBuff_Stack_Percent = new Genshin_Calc.ValueTracker();
            this.ATKBuff_Group = new System.Windows.Forms.GroupBox();
            this.ATKBuff_HP = new System.Windows.Forms.Label();
            this.ATKBuff_DEF = new System.Windows.Forms.Label();
            this.ATKBuff_HP_Label = new System.Windows.Forms.Label();
            this.ATKBuff_DEF_Label = new System.Windows.Forms.Label();
            this.ATKBuff_Percent = new Genshin_Calc.ValueTracker();
            this.ATKBuff_Static = new Genshin_Calc.ValueTracker();
            this.label15 = new System.Windows.Forms.Label();
            this.Damage_Buff = new System.Windows.Forms.TabPage();
            this.DamageBuff_Reaction_Group = new System.Windows.Forms.GroupBox();
            this.DamageBuff_Reaction = new Genshin_Calc.ValueTracker();
            this.DamageBuffStack_Group = new System.Windows.Forms.GroupBox();
            this.DamageBuff_Stack_Count = new Genshin_Calc.ValueTracker();
            this.DamageBuff_Stack_Percent = new Genshin_Calc.ValueTracker();
            this.DamageBuff_Group = new System.Windows.Forms.GroupBox();
            this.DamageBuff_Percent = new Genshin_Calc.ValueTracker();
            this.Level_And_Res = new System.Windows.Forms.TabPage();
            this.Resistance_Group = new System.Windows.Forms.GroupBox();
            this.Resistance_Percent = new Genshin_Calc.ValueTracker();
            this.LevelAndDefence_Group = new System.Windows.Forms.GroupBox();
            this.Defence_Debuff = new Genshin_Calc.ValueTracker();
            this.Level_Enemy = new Genshin_Calc.ValueTracker();
            this.Level_Player = new Genshin_Calc.ValueTracker();
            this.ChartViewer = new System.Windows.Forms.TabPage();
            this.DMGType2 = new System.Windows.Forms.RadioButton();
            this.DMGType1 = new System.Windows.Forms.RadioButton();
            this.DMGType0 = new System.Windows.Forms.RadioButton();
            this.AttributeList = new System.Windows.Forms.ListView();
            this.ColumnA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ComChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.NormalDMG_Text = new System.Windows.Forms.Label();
            this.CritDMG_Text = new System.Windows.Forms.Label();
            this.AvgDMG_Text = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Reaction = new System.Windows.Forms.Label();
            this.Reaction_Choose = new System.Windows.Forms.ComboBox();
            this.Normal_DMG = new System.Windows.Forms.Label();
            this.Crit_DMG = new System.Windows.Forms.Label();
            this.Avg_DMG = new System.Windows.Forms.Label();
            this.TransButton = new System.Windows.Forms.Button();
            this.statusStrips = new System.Windows.Forms.StatusStrip();
            this.toolStrips = new System.Windows.Forms.ToolStripStatusLabel();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.Skill = new Genshin_Calc.ValueTracker();
            this.Other = new Genshin_Calc.ValueTracker();
            this.menuStrip1.SuspendLayout();
            this.P1.SuspendLayout();
            this.Basic.SuspendLayout();
            this.BasicGroup.SuspendLayout();
            this.ATK_Buff.SuspendLayout();
            this.ATKBuff_Stack_Group.SuspendLayout();
            this.ATKBuff_Group.SuspendLayout();
            this.Damage_Buff.SuspendLayout();
            this.DamageBuff_Reaction_Group.SuspendLayout();
            this.DamageBuffStack_Group.SuspendLayout();
            this.DamageBuff_Group.SuspendLayout();
            this.Level_And_Res.SuspendLayout();
            this.Resistance_Group.SuspendLayout();
            this.LevelAndDefence_Group.SuspendLayout();
            this.ChartViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrips.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowItemReorder = true;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.设定ToolStripMenuItem,
            this.查询ToolStripMenuItem,
            this.特殊计算ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.DragEnter += new System.Windows.Forms.DragEventHandler(this.OpenFiles_Drag);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.文件ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据存放文件夹ToolStripMenuItem,
            this.读取ToolStripMenuItem,
            this.存档ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.文件ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(56, 28);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 数据存放文件夹ToolStripMenuItem
            // 
            this.数据存放文件夹ToolStripMenuItem.Name = "数据存放文件夹ToolStripMenuItem";
            this.数据存放文件夹ToolStripMenuItem.Size = new System.Drawing.Size(199, 28);
            this.数据存放文件夹ToolStripMenuItem.Text = "数据存放文件夹";
            this.数据存放文件夹ToolStripMenuItem.Click += new System.EventHandler(this.数据存放文件夹ToolStripMenuItem_Click);
            // 
            // 读取ToolStripMenuItem
            // 
            this.读取ToolStripMenuItem.Name = "读取ToolStripMenuItem";
            this.读取ToolStripMenuItem.Size = new System.Drawing.Size(199, 28);
            this.读取ToolStripMenuItem.Text = "读取";
            this.读取ToolStripMenuItem.Click += new System.EventHandler(this.OpenFiles);
            // 
            // 存档ToolStripMenuItem
            // 
            this.存档ToolStripMenuItem.Name = "存档ToolStripMenuItem";
            this.存档ToolStripMenuItem.Size = new System.Drawing.Size(199, 28);
            this.存档ToolStripMenuItem.Text = "存档";
            this.存档ToolStripMenuItem.Click += new System.EventHandler(this.SaveFiles);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(199, 28);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 设定ToolStripMenuItem
            // 
            this.设定ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.设定ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.设定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数值上下限设置ToolStripMenuItem,
            this.窗口置顶ToolStripMenuItem,
            this.修复字体ToolStripMenuItem});
            this.设定ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.设定ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.设定ToolStripMenuItem.Name = "设定ToolStripMenuItem";
            this.设定ToolStripMenuItem.Size = new System.Drawing.Size(56, 28);
            this.设定ToolStripMenuItem.Text = "设定";
            // 
            // 数值上下限设置ToolStripMenuItem
            // 
            this.数值上下限设置ToolStripMenuItem.Name = "数值上下限设置ToolStripMenuItem";
            this.数值上下限设置ToolStripMenuItem.Size = new System.Drawing.Size(199, 28);
            this.数值上下限设置ToolStripMenuItem.Text = "数值上下限设置";
            this.数值上下限设置ToolStripMenuItem.Click += new System.EventHandler(this.数值上下限设置ToolStripMenuItem_Click);
            // 
            // 窗口置顶ToolStripMenuItem
            // 
            this.窗口置顶ToolStripMenuItem.CheckOnClick = true;
            this.窗口置顶ToolStripMenuItem.Name = "窗口置顶ToolStripMenuItem";
            this.窗口置顶ToolStripMenuItem.Size = new System.Drawing.Size(199, 28);
            this.窗口置顶ToolStripMenuItem.Text = "窗口置顶";
            this.窗口置顶ToolStripMenuItem.Click += new System.EventHandler(this.窗口置顶ToolStripMenuItem_Click);
            // 
            // 修复字体ToolStripMenuItem
            // 
            this.修复字体ToolStripMenuItem.Name = "修复字体ToolStripMenuItem";
            this.修复字体ToolStripMenuItem.Size = new System.Drawing.Size(199, 28);
            this.修复字体ToolStripMenuItem.Text = "修复字体";
            this.修复字体ToolStripMenuItem.Click += new System.EventHandler(this.修复字体ToolStripMenuItem_Click);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.查询ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.角色与武器快捷输入ToolStripMenuItem,
            this.敌人抗性快速查询ToolStripMenuItem,
            this.Cocogoat圣遗物导入ToolStripMenuItem});
            this.查询ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.查询ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(56, 28);
            this.查询ToolStripMenuItem.Text = "查询";
            // 
            // 角色与武器快捷输入ToolStripMenuItem
            // 
            this.角色与武器快捷输入ToolStripMenuItem.Name = "角色与武器快捷输入ToolStripMenuItem";
            this.角色与武器快捷输入ToolStripMenuItem.Size = new System.Drawing.Size(271, 28);
            this.角色与武器快捷输入ToolStripMenuItem.Text = "角色与武器快捷输入";
            this.角色与武器快捷输入ToolStripMenuItem.Click += new System.EventHandler(this.角色与武器快捷输入ToolStripMenuItem_Click_1);
            // 
            // 敌人抗性快速查询ToolStripMenuItem
            // 
            this.敌人抗性快速查询ToolStripMenuItem.Name = "敌人抗性快速查询ToolStripMenuItem";
            this.敌人抗性快速查询ToolStripMenuItem.Size = new System.Drawing.Size(271, 28);
            this.敌人抗性快速查询ToolStripMenuItem.Text = "敌人抗性快速查询";
            this.敌人抗性快速查询ToolStripMenuItem.Click += new System.EventHandler(this.敌人抗性快速查询ToolStripMenuItem_Click_1);
            // 
            // Cocogoat圣遗物导入ToolStripMenuItem
            // 
            this.Cocogoat圣遗物导入ToolStripMenuItem.Name = "Cocogoat圣遗物导入ToolStripMenuItem";
            this.Cocogoat圣遗物导入ToolStripMenuItem.Size = new System.Drawing.Size(271, 28);
            this.Cocogoat圣遗物导入ToolStripMenuItem.Text = "圣遗物导入 ( JSON文件 )";
            this.Cocogoat圣遗物导入ToolStripMenuItem.Click += new System.EventHandler(this.ArtifactsApply);
            // 
            // 特殊计算ToolStripMenuItem
            // 
            this.特殊计算ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.特殊计算ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.特殊计算ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.诺艾尔防御转攻击ToolStripMenuItem,
            this.阿贝多防御值加伤替换攻击ToolStripMenuItem,
            this.钟离生命值加伤ToolStripMenuItem,
            this.胡桃生命值加攻ToolStripMenuItem});
            this.特殊计算ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.特殊计算ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.特殊计算ToolStripMenuItem.Name = "特殊计算ToolStripMenuItem";
            this.特殊计算ToolStripMenuItem.Size = new System.Drawing.Size(90, 28);
            this.特殊计算ToolStripMenuItem.Text = "角色计算";
            // 
            // 诺艾尔防御转攻击ToolStripMenuItem
            // 
            this.诺艾尔防御转攻击ToolStripMenuItem.Name = "诺艾尔防御转攻击ToolStripMenuItem";
            this.诺艾尔防御转攻击ToolStripMenuItem.Size = new System.Drawing.Size(325, 28);
            this.诺艾尔防御转攻击ToolStripMenuItem.Text = "诺艾尔（防御转攻击）";
            this.诺艾尔防御转攻击ToolStripMenuItem.Click += new System.EventHandler(this.诺艾尔防御转攻击ToolStripMenuItem_Click);
            // 
            // 阿贝多防御值加伤替换攻击ToolStripMenuItem
            // 
            this.阿贝多防御值加伤替换攻击ToolStripMenuItem.Name = "阿贝多防御值加伤替换攻击ToolStripMenuItem";
            this.阿贝多防御值加伤替换攻击ToolStripMenuItem.Size = new System.Drawing.Size(325, 28);
            this.阿贝多防御值加伤替换攻击ToolStripMenuItem.Text = "阿贝多（防御值加伤/替换攻击）";
            this.阿贝多防御值加伤替换攻击ToolStripMenuItem.Click += new System.EventHandler(this.阿贝多防御值加伤替换攻击ToolStripMenuItem_Click);
            // 
            // 钟离生命值加伤ToolStripMenuItem
            // 
            this.钟离生命值加伤ToolStripMenuItem.Name = "钟离生命值加伤ToolStripMenuItem";
            this.钟离生命值加伤ToolStripMenuItem.Size = new System.Drawing.Size(325, 28);
            this.钟离生命值加伤ToolStripMenuItem.Text = "钟离    （生命值加伤）";
            this.钟离生命值加伤ToolStripMenuItem.Click += new System.EventHandler(this.钟离生命值加伤ToolStripMenuItem_Click);
            // 
            // 胡桃生命值加攻ToolStripMenuItem
            // 
            this.胡桃生命值加攻ToolStripMenuItem.Name = "胡桃生命值加攻ToolStripMenuItem";
            this.胡桃生命值加攻ToolStripMenuItem.Size = new System.Drawing.Size(325, 28);
            this.胡桃生命值加攻ToolStripMenuItem.Text = "胡桃    （生命值加攻）";
            this.胡桃生命值加攻ToolStripMenuItem.Click += new System.EventHandler(this.胡桃生命值加攻ToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.工具ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windows计算器ToolStripMenuItem,
            this.锚定伤害计算器ToolStripMenuItem,
            this.治疗量计算器ToolStripMenuItem,
            this.DPS简易计算ToolStripMenuItem,
            this.圣遗物简易比较器ToolStripMenuItem});
            this.工具ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.工具ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(90, 28);
            this.工具ToolStripMenuItem.Text = "计算工具";
            // 
            // windows计算器ToolStripMenuItem
            // 
            this.windows计算器ToolStripMenuItem.Name = "windows计算器ToolStripMenuItem";
            this.windows计算器ToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.windows计算器ToolStripMenuItem.Text = "Windows系统计算器";
            this.windows计算器ToolStripMenuItem.Click += new System.EventHandler(this.Windows计算器ToolStripMenuItem_Click);
            // 
            // 锚定伤害计算器ToolStripMenuItem
            // 
            this.锚定伤害计算器ToolStripMenuItem.Name = "锚定伤害计算器ToolStripMenuItem";
            this.锚定伤害计算器ToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.锚定伤害计算器ToolStripMenuItem.Text = "锚定伤害计算器";
            this.锚定伤害计算器ToolStripMenuItem.Click += new System.EventHandler(this.锚定伤害计算器ToolStripMenuItem_Click);
            // 
            // 治疗量计算器ToolStripMenuItem
            // 
            this.治疗量计算器ToolStripMenuItem.Name = "治疗量计算器ToolStripMenuItem";
            this.治疗量计算器ToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.治疗量计算器ToolStripMenuItem.Text = "治疗/护盾量计算器";
            this.治疗量计算器ToolStripMenuItem.Click += new System.EventHandler(this.治疗量计算器ToolStripMenuItem_Click);
            // 
            // DPS简易计算ToolStripMenuItem
            // 
            this.DPS简易计算ToolStripMenuItem.Name = "DPS简易计算ToolStripMenuItem";
            this.DPS简易计算ToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.DPS简易计算ToolStripMenuItem.Text = "DPS简易计算";
            this.DPS简易计算ToolStripMenuItem.Click += new System.EventHandler(this.DPS简易计算ToolStripMenuItem_Click);
            // 
            // 圣遗物简易比较器ToolStripMenuItem
            // 
            this.圣遗物简易比较器ToolStripMenuItem.Name = "圣遗物简易比较器ToolStripMenuItem";
            this.圣遗物简易比较器ToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.圣遗物简易比较器ToolStripMenuItem.Text = "圣遗物简易比较器";
            this.圣遗物简易比较器ToolStripMenuItem.Click += new System.EventHandler(this.圣遗物简易比较器ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.帮助ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使用入门ToolStripMenuItem,
            this.计算公式来源ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.帮助ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.帮助ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(56, 28);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 使用入门ToolStripMenuItem
            // 
            this.使用入门ToolStripMenuItem.Name = "使用入门ToolStripMenuItem";
            this.使用入门ToolStripMenuItem.Size = new System.Drawing.Size(296, 28);
            this.使用入门ToolStripMenuItem.Text = "使用入门（需打开浏览器）";
            // 
            // 计算公式来源ToolStripMenuItem
            // 
            this.计算公式来源ToolStripMenuItem.Name = "计算公式来源ToolStripMenuItem";
            this.计算公式来源ToolStripMenuItem.Size = new System.Drawing.Size(296, 28);
            this.计算公式来源ToolStripMenuItem.Text = "计算公式来源(需打开浏览器)";
            this.计算公式来源ToolStripMenuItem.Click += new System.EventHandler(this.计算公式来源ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(296, 28);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // P1
            // 
            this.P1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P1.Controls.Add(this.Basic);
            this.P1.Controls.Add(this.ATK_Buff);
            this.P1.Controls.Add(this.Damage_Buff);
            this.P1.Controls.Add(this.Level_And_Res);
            this.P1.Controls.Add(this.ChartViewer);
            this.P1.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.P1.HotTrack = true;
            this.P1.ItemSize = new System.Drawing.Size(120, 28);
            this.P1.Location = new System.Drawing.Point(12, 34);
            this.P1.Name = "P1";
            this.P1.SelectedIndex = 0;
            this.P1.Size = new System.Drawing.Size(920, 367);
            this.P1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.P1.TabIndex = 12;
            this.P1.SelectedIndexChanged += new System.EventHandler(this.DetailedCalculate);
            this.P1.DragEnter += new System.Windows.Forms.DragEventHandler(this.OpenFiles_Drag);
            // 
            // Basic
            // 
            this.Basic.BackColor = System.Drawing.Color.Transparent;
            this.Basic.Controls.Add(this.BasicGroup);
            this.Basic.Font = new System.Drawing.Font("宋体", 9F);
            this.Basic.Location = new System.Drawing.Point(4, 32);
            this.Basic.Name = "Basic";
            this.Basic.Padding = new System.Windows.Forms.Padding(3);
            this.Basic.Size = new System.Drawing.Size(912, 331);
            this.Basic.TabIndex = 0;
            this.Basic.Text = "面板属性";
            // 
            // BasicGroup
            // 
            this.BasicGroup.BackColor = System.Drawing.SystemColors.Control;
            this.BasicGroup.Controls.Add(this.DamageBuff_Elem);
            this.BasicGroup.Controls.Add(this.Crit_Damage);
            this.BasicGroup.Controls.Add(this.Crit_Rate);
            this.BasicGroup.Controls.Add(this.ElemMastery);
            this.BasicGroup.Controls.Add(this.ATK_Added);
            this.BasicGroup.Controls.Add(this.ATK_Basic);
            this.BasicGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BasicGroup.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.BasicGroup.Location = new System.Drawing.Point(3, 3);
            this.BasicGroup.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.BasicGroup.Name = "BasicGroup";
            this.BasicGroup.Padding = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.BasicGroup.Size = new System.Drawing.Size(906, 325);
            this.BasicGroup.TabIndex = 3;
            this.BasicGroup.TabStop = false;
            this.BasicGroup.Text = "基础面板";
            // 
            // DamageBuff_Elem
            // 
            this.DamageBuff_Elem.Current = 0F;
            this.DamageBuff_Elem.CurrentStr = "0";
            this.DamageBuff_Elem.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.DamageBuff_Elem.Location = new System.Drawing.Point(9, 270);
            this.DamageBuff_Elem.Margin = new System.Windows.Forms.Padding(6);
            this.DamageBuff_Elem.Maximum = 1500;
            this.DamageBuff_Elem.Minimum = 0;
            this.DamageBuff_Elem.Name = "DamageBuff_Elem";
            this.DamageBuff_Elem.PercentShownOrNot = true;
            this.DamageBuff_Elem.Size = new System.Drawing.Size(891, 45);
            this.DamageBuff_Elem.TabIndex = 6;
            this.DamageBuff_Elem.Title = "元素伤害加成";
            this.DamageBuff_Elem.ValScale = 10D;
            this.DamageBuff_Elem.ValueChange += new Genshin_Calc.ValueTracker.ValueSettingsDelegate(this.ValueSet);
            // 
            // Crit_Damage
            // 
            this.Crit_Damage.Current = 500F;
            this.Crit_Damage.CurrentStr = "50";
            this.Crit_Damage.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.Crit_Damage.Location = new System.Drawing.Point(9, 221);
            this.Crit_Damage.Margin = new System.Windows.Forms.Padding(6);
            this.Crit_Damage.Maximum = 4000;
            this.Crit_Damage.Minimum = 500;
            this.Crit_Damage.Name = "Crit_Damage";
            this.Crit_Damage.PercentShownOrNot = true;
            this.Crit_Damage.Size = new System.Drawing.Size(891, 45);
            this.Crit_Damage.TabIndex = 5;
            this.Crit_Damage.Title = "暴击伤害";
            this.Crit_Damage.ValScale = 10D;
            this.Crit_Damage.ValueChange += new Genshin_Calc.ValueTracker.ValueSettingsDelegate(this.ValueSet);
            // 
            // Crit_Rate
            // 
            this.Crit_Rate.Current = 50F;
            this.Crit_Rate.CurrentStr = "5";
            this.Crit_Rate.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.Crit_Rate.Location = new System.Drawing.Point(9, 172);
            this.Crit_Rate.Margin = new System.Windows.Forms.Padding(6);
            this.Crit_Rate.Maximum = 1000;
            this.Crit_Rate.Minimum = 0;
            this.Crit_Rate.Name = "Crit_Rate";
            this.Crit_Rate.PercentShownOrNot = true;
            this.Crit_Rate.Size = new System.Drawing.Size(891, 45);
            this.Crit_Rate.TabIndex = 4;
            this.Crit_Rate.Title = "暴击率";
            this.Crit_Rate.ValScale = 10D;
            this.Crit_Rate.ValueChange += new Genshin_Calc.ValueTracker.ValueSettingsDelegate(this.ValueSet);
            // 
            // ElemMastery
            // 
            this.ElemMastery.Current = 0F;
            this.ElemMastery.CurrentStr = "0";
            this.ElemMastery.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.ElemMastery.Location = new System.Drawing.Point(9, 123);
            this.ElemMastery.Margin = new System.Windows.Forms.Padding(6, 1, 6, 1);
            this.ElemMastery.Maximum = 2000;
            this.ElemMastery.Minimum = 0;
            this.ElemMastery.Name = "ElemMastery";
            this.ElemMastery.PercentShownOrNot = false;
            this.ElemMastery.Size = new System.Drawing.Size(891, 45);
            this.ElemMastery.TabIndex = 3;
            this.ElemMastery.Title = "元素精通";
            this.ElemMastery.ValScale = 1D;
            this.ElemMastery.ValueChange += new Genshin_Calc.ValueTracker.ValueSettingsDelegate(this.ValueSet);
            // 
            // ATK_Added
            // 
            this.ATK_Added.Current = 400F;
            this.ATK_Added.CurrentStr = "400";
            this.ATK_Added.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.ATK_Added.Location = new System.Drawing.Point(9, 74);
            this.ATK_Added.Margin = new System.Windows.Forms.Padding(6, 1, 6, 1);
            this.ATK_Added.Maximum = 2000;
            this.ATK_Added.Minimum = 0;
            this.ATK_Added.Name = "ATK_Added";
            this.ATK_Added.PercentShownOrNot = false;
            this.ATK_Added.Size = new System.Drawing.Size(891, 45);
            this.ATK_Added.TabIndex = 2;
            this.ATK_Added.Title = "附加攻击力";
            this.ATK_Added.ValScale = 1D;
            this.ATK_Added.ValueChange += new Genshin_Calc.ValueTracker.ValueSettingsDelegate(this.ValueSet);
            // 
            // ATK_Basic
            // 
            this.ATK_Basic.Current = 400F;
            this.ATK_Basic.CurrentStr = "400";
            this.ATK_Basic.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.ATK_Basic.Location = new System.Drawing.Point(9, 25);
            this.ATK_Basic.Margin = new System.Windows.Forms.Padding(6, 1, 6, 1);
            this.ATK_Basic.Maximum = 1500;
            this.ATK_Basic.Minimum = 0;
            this.ATK_Basic.Name = "ATK_Basic";
            this.ATK_Basic.PercentShownOrNot = false;
            this.ATK_Basic.Size = new System.Drawing.Size(891, 45);
            this.ATK_Basic.TabIndex = 1;
            this.ATK_Basic.Title = "基础攻击力";
            this.ATK_Basic.ValScale = 1D;
            this.ATK_Basic.ValueChange += new Genshin_Calc.ValueTracker.ValueSettingsDelegate(this.ValueSet);
            // 
            // ATK_Buff
            // 
            this.ATK_Buff.Controls.Add(this.ATKBuff_Stack_Group);
            this.ATK_Buff.Controls.Add(this.ATKBuff_Group);
            this.ATK_Buff.Location = new System.Drawing.Point(4, 32);
            this.ATK_Buff.Name = "ATK_Buff";
            this.ATK_Buff.Padding = new System.Windows.Forms.Padding(3);
            this.ATK_Buff.Size = new System.Drawing.Size(912, 331);
            this.ATK_Buff.TabIndex = 7;
            this.ATK_Buff.Text = "攻击加成";
            this.ATK_Buff.UseVisualStyleBackColor = true;
            // 
            // ATKBuff_Stack_Group
            // 
            this.ATKBuff_Stack_Group.BackColor = System.Drawing.SystemColors.Control;
            this.ATKBuff_Stack_Group.Controls.Add(this.ATKBuff_Stack_Count);
            this.ATKBuff_Stack_Group.Controls.Add(this.ATKBuff_Stack_Percent);
            this.ATKBuff_Stack_Group.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ATKBuff_Stack_Group.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.ATKBuff_Stack_Group.Location = new System.Drawing.Point(3, 183);
            this.ATKBuff_Stack_Group.Name = "ATKBuff_Stack_Group";
            this.ATKBuff_Stack_Group.Size = new System.Drawing.Size(906, 145);
            this.ATKBuff_Stack_Group.TabIndex = 15;
            this.ATKBuff_Stack_Group.TabStop = false;
            this.ATKBuff_Stack_Group.Text = "可叠加的攻击力加成";
            // 
            // ATKBuff_Stack_Count
            // 
            this.ATKBuff_Stack_Count.Current = 0F;
            this.ATKBuff_Stack_Count.CurrentStr = "0";
            this.ATKBuff_Stack_Count.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.ATKBuff_Stack_Count.Location = new System.Drawing.Point(9, 90);
            this.ATKBuff_Stack_Count.Margin = new System.Windows.Forms.Padding(6);
            this.ATKBuff_Stack_Count.Maximum = 20;
            this.ATKBuff_Stack_Count.Minimum = 0;
            this.ATKBuff_Stack_Count.Name = "ATKBuff_Stack_Count";
            this.ATKBuff_Stack_Count.PercentShownOrNot = false;
            this.ATKBuff_Stack_Count.Size = new System.Drawing.Size(882, 45);
            this.ATKBuff_Stack_Count.TabIndex = 1;
            this.ATKBuff_Stack_Count.Title = "叠攻层数";
            this.ATKBuff_Stack_Count.ValScale = 1D;
            this.ATKBuff_Stack_Count.ValueChange += new Genshin_Calc.ValueTracker.ValueSettingsDelegate(this.ValueSet);
            // 
            // ATKBuff_Stack_Percent
            // 
            this.ATKBuff_Stack_Percent.Current = 0F;
            this.ATKBuff_Stack_Percent.CurrentStr = "0";
            this.ATKBuff_Stack_Percent.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.ATKBuff_Stack_Percent.Location = new System.Drawing.Point(9, 41);
            this.ATKBuff_Stack_Percent.Margin = new System.Windows.Forms.Padding(6);
            this.ATKBuff_Stack_Percent.Maximum = 1000;
            this.ATKBuff_Stack_Percent.Minimum = 0;
            this.ATKBuff_Stack_Percent.Name = "ATKBuff_Stack_Percent";
            this.ATKBuff_Stack_Percent.PercentShownOrNot = true;
            this.ATKBuff_Stack_Percent.Size = new System.Drawing.Size(882, 45);
            this.ATKBuff_Stack_Percent.TabIndex = 0;
            this.ATKBuff_Stack_Percent.Title = "每层叠攻百分比";
            this.ATKBuff_Stack_Percent.ValScale = 10D;
            this.ATKBuff_Stack_Percent.ValueChange += new Genshin_Calc.ValueTracker.ValueSettingsDelegate(this.ValueSet);
            // 
            // ATKBuff_Group
            // 
            this.ATKBuff_Group.BackColor = System.Drawing.SystemColors.Control;
            this.ATKBuff_Group.Controls.Add(this.ATKBuff_HP);
            this.ATKBuff_Group.Controls.Add(this.ATKBuff_DEF);
            this.ATKBuff_Group.Controls.Add(this.ATKBuff_HP_Label);
            this.ATKBuff_Group.Controls.Add(this.ATKBuff_DEF_Label);
            this.ATKBuff_Group.Controls.Add(this.ATKBuff_Percent);
            this.ATKBuff_Group.Controls.Add(this.ATKBuff_Static);
            this.ATKBuff_Group.Controls.Add(this.label15);
            this.ATKBuff_Group.Dock = System.Windows.Forms.DockStyle.Top;
            this.ATKBuff_Group.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ATKBuff_Group.Location = new System.Drawing.Point(3, 3);
            this.ATKBuff_Group.Name = "ATKBuff_Group";
            this.ATKBuff_Group.Size = new System.Drawing.Size(906, 180);
            this.ATKBuff_Group.TabIndex = 14;
            this.ATKBuff_Group.TabStop = false;
            this.ATKBuff_Group.Text = "不叠加的攻击力加成";
            // 
            // ATKBuff_HP
            // 
            this.ATKBuff_HP.AutoSize = true;
            this.ATKBuff_HP.Font = new System.Drawing.Font("方正像素12", 21F);
            this.ATKBuff_HP.Location = new System.Drawing.Point(662, 133);
            this.ATKBuff_HP.Name = "ATKBuff_HP";
            this.ATKBuff_HP.Size = new System.Drawing.Size(26, 28);
            this.ATKBuff_HP.TabIndex = 20;
            this.ATKBuff_HP.Text = "0";
            // 
            // ATKBuff_DEF
            // 
            this.ATKBuff_DEF.AutoSize = true;
            this.ATKBuff_DEF.Font = new System.Drawing.Font("方正像素12", 21F);
            this.ATKBuff_DEF.Location = new System.Drawing.Point(332, 133);
            this.ATKBuff_DEF.Name = "ATKBuff_DEF";
            this.ATKBuff_DEF.Size = new System.Drawing.Size(26, 28);
            this.ATKBuff_DEF.TabIndex = 19;
            this.ATKBuff_DEF.Text = "0";
            // 
            // ATKBuff_HP_Label
            // 
            this.ATKBuff_HP_Label.AutoSize = true;
            this.ATKBuff_HP_Label.Font = new System.Drawing.Font("微软雅黑 Light", 15.75F);
            this.ATKBuff_HP_Label.Location = new System.Drawing.Point(529, 133);
            this.ATKBuff_HP_Label.Name = "ATKBuff_HP_Label";
            this.ATKBuff_HP_Label.Size = new System.Drawing.Size(117, 28);
            this.ATKBuff_HP_Label.TabIndex = 18;
            this.ATKBuff_HP_Label.Text = "生命值收益";
            // 
            // ATKBuff_DEF_Label
            // 
            this.ATKBuff_DEF_Label.AutoSize = true;
            this.ATKBuff_DEF_Label.Font = new System.Drawing.Font("微软雅黑 Light", 15.75F);
            this.ATKBuff_DEF_Label.Location = new System.Drawing.Point(209, 133);
            this.ATKBuff_DEF_Label.Name = "ATKBuff_DEF_Label";
            this.ATKBuff_DEF_Label.Size = new System.Drawing.Size(117, 28);
            this.ATKBuff_DEF_Label.TabIndex = 17;
            this.ATKBuff_DEF_Label.Text = "防御力收益";
            // 
            // ATKBuff_Percent
            // 
            this.ATKBuff_Percent.Current = 0F;
            this.ATKBuff_Percent.CurrentStr = "0";
            this.ATKBuff_Percent.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.ATKBuff_Percent.Location = new System.Drawing.Point(9, 74);
            this.ATKBuff_Percent.Margin = new System.Windows.Forms.Padding(6);
            this.ATKBuff_Percent.Maximum = 2000;
            this.ATKBuff_Percent.Minimum = 0;
            this.ATKBuff_Percent.Name = "ATKBuff_Percent";
            this.ATKBuff_Percent.PercentShownOrNot = true;
            this.ATKBuff_Percent.Size = new System.Drawing.Size(882, 45);
            this.ATKBuff_Percent.TabIndex = 16;
            this.ATKBuff_Percent.Title = "百分比攻击加成";
            this.ATKBuff_Percent.ValScale = 10D;
            this.ATKBuff_Percent.ValueChange += new Genshin_Calc.ValueTracker.ValueSettingsDelegate(this.ValueSet);
            // 
            // ATKBuff_Static
            // 
            this.ATKBuff_Static.Current = 0F;
            this.ATKBuff_Static.CurrentStr = "0";
            this.ATKBuff_Static.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.ATKBuff_Static.Location = new System.Drawing.Point(9, 25);
            this.ATKBuff_Static.Margin = new System.Windows.Forms.Padding(6);
            this.ATKBuff_Static.Maximum = 2000;
            this.ATKBuff_Static.Minimum = 0;
            this.ATKBuff_Static.Name = "ATKBuff_Static";
            this.ATKBuff_Static.PercentShownOrNot = false;
            this.ATKBuff_Static.Size = new System.Drawing.Size(882, 45);
            this.ATKBuff_Static.TabIndex = 15;
            this.ATKBuff_Static.Title = "固定值攻击加成";
            this.ATKBuff_Static.ValScale = 1D;
            this.ATKBuff_Static.ValueChange += new Genshin_Calc.ValueTracker.ValueSettingsDelegate(this.ValueSet);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.label15.Location = new System.Drawing.Point(16, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 28);
            this.label15.TabIndex = 9;
            this.label15.Text = "其他攻击收益";
            // 
            // Damage_Buff
            // 
            this.Damage_Buff.Controls.Add(this.DamageBuff_Reaction_Group);
            this.Damage_Buff.Controls.Add(this.DamageBuffStack_Group);
            this.Damage_Buff.Controls.Add(this.DamageBuff_Group);
            this.Damage_Buff.Font = new System.Drawing.Font("宋体", 9F);
            this.Damage_Buff.Location = new System.Drawing.Point(4, 32);
            this.Damage_Buff.Name = "Damage_Buff";
            this.Damage_Buff.Padding = new System.Windows.Forms.Padding(3);
            this.Damage_Buff.Size = new System.Drawing.Size(912, 331);
            this.Damage_Buff.TabIndex = 5;
            this.Damage_Buff.Text = "伤害加深";
            this.Damage_Buff.UseVisualStyleBackColor = true;
            // 
            // DamageBuff_Reaction_Group
            // 
            this.DamageBuff_Reaction_Group.BackColor = System.Drawing.SystemColors.Control;
            this.DamageBuff_Reaction_Group.Controls.Add(this.DamageBuff_Reaction);
            this.DamageBuff_Reaction_Group.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DamageBuff_Reaction_Group.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DamageBuff_Reaction_Group.Location = new System.Drawing.Point(3, 242);
            this.DamageBuff_Reaction_Group.Name = "DamageBuff_Reaction_Group";
            this.DamageBuff_Reaction_Group.Size = new System.Drawing.Size(906, 86);
            this.DamageBuff_Reaction_Group.TabIndex = 18;
            this.DamageBuff_Reaction_Group.TabStop = false;
            this.DamageBuff_Reaction_Group.Text = "反应伤害增强";
            // 
            // DamageBuff_Reaction
            // 
            this.DamageBuff_Reaction.Current = 0F;
            this.DamageBuff_Reaction.CurrentStr = "0";
            this.DamageBuff_Reaction.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.DamageBuff_Reaction.Location = new System.Drawing.Point(9, 31);
            this.DamageBuff_Reaction.Margin = new System.Windows.Forms.Padding(6);
            this.DamageBuff_Reaction.Maximum = 2000;
            this.DamageBuff_Reaction.Minimum = 0;
            this.DamageBuff_Reaction.Name = "DamageBuff_Reaction";
            this.DamageBuff_Reaction.PercentShownOrNot = true;
            this.DamageBuff_Reaction.Size = new System.Drawing.Size(882, 45);
            this.DamageBuff_Reaction.TabIndex = 0;
            this.DamageBuff_Reaction.Title = "反应伤害提升";
            this.DamageBuff_Reaction.ValScale = 10D;
            this.DamageBuff_Reaction.ValueChange += new Genshin_Calc.ValueTracker.ValueSettingsDelegate(this.ValueSet);
            // 
            // DamageBuffStack_Group
            // 
            this.DamageBuffStack_Group.BackColor = System.Drawing.SystemColors.Control;
            this.DamageBuffStack_Group.Controls.Add(this.DamageBuff_Stack_Count);
            this.DamageBuffStack_Group.Controls.Add(this.DamageBuff_Stack_Percent);
            this.DamageBuffStack_Group.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.DamageBuffStack_Group.Location = new System.Drawing.Point(3, 88);
            this.DamageBuffStack_Group.Name = "DamageBuffStack_Group";
            this.DamageBuffStack_Group.Size = new System.Drawing.Size(906, 151);
            this.DamageBuffStack_Group.TabIndex = 17;
            this.DamageBuffStack_Group.TabStop = false;
            this.DamageBuffStack_Group.Text = "可叠加的伤害buff";
            // 
            // DamageBuff_Stack_Count
            // 
            this.DamageBuff_Stack_Count.Current = 0F;
            this.DamageBuff_Stack_Count.CurrentStr = "0";
            this.DamageBuff_Stack_Count.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.DamageBuff_Stack_Count.Location = new System.Drawing.Point(9, 87);
            this.DamageBuff_Stack_Count.Margin = new System.Windows.Forms.Padding(6);
            this.DamageBuff_Stack_Count.Maximum = 20;
            this.DamageBuff_Stack_Count.Minimum = 0;
            this.DamageBuff_Stack_Count.Name = "DamageBuff_Stack_Count";
            this.DamageBuff_Stack_Count.PercentShownOrNot = false;
            this.DamageBuff_Stack_Count.Size = new System.Drawing.Size(882, 45);
            this.DamageBuff_Stack_Count.TabIndex = 1;
            this.DamageBuff_Stack_Count.Title = "伤害叠加层数";
            this.DamageBuff_Stack_Count.ValScale = 1D;
            this.DamageBuff_Stack_Count.ValueChange += new Genshin_Calc.ValueTracker.ValueSettingsDelegate(this.ValueSet);
            // 
            // DamageBuff_Stack_Percent
            // 
            this.DamageBuff_Stack_Percent.Current = 0F;
            this.DamageBuff_Stack_Percent.CurrentStr = "0";
            this.DamageBuff_Stack_Percent.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.DamageBuff_Stack_Percent.Location = new System.Drawing.Point(9, 38);
            this.DamageBuff_Stack_Percent.Margin = new System.Windows.Forms.Padding(6);
            this.DamageBuff_Stack_Percent.Maximum = 2000;
            this.DamageBuff_Stack_Percent.Minimum = 0;
            this.DamageBuff_Stack_Percent.Name = "DamageBuff_Stack_Percent";
            this.DamageBuff_Stack_Percent.PercentShownOrNot = true;
            this.DamageBuff_Stack_Percent.Size = new System.Drawing.Size(882, 45);
            this.DamageBuff_Stack_Percent.TabIndex = 0;
            this.DamageBuff_Stack_Percent.Title = "每层伤害加成";
            this.DamageBuff_Stack_Percent.ValScale = 10D;
            this.DamageBuff_Stack_Percent.ValueChange += new Genshin_Calc.ValueTracker.ValueSettingsDelegate(this.ValueSet);
            // 
            // DamageBuff_Group
            // 
            this.DamageBuff_Group.BackColor = System.Drawing.SystemColors.Control;
            this.DamageBuff_Group.Controls.Add(this.DamageBuff_Percent);
            this.DamageBuff_Group.Dock = System.Windows.Forms.DockStyle.Top;
            this.DamageBuff_Group.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DamageBuff_Group.Location = new System.Drawing.Point(3, 3);
            this.DamageBuff_Group.Name = "DamageBuff_Group";
            this.DamageBuff_Group.Size = new System.Drawing.Size(906, 82);
            this.DamageBuff_Group.TabIndex = 16;
            this.DamageBuff_Group.TabStop = false;
            this.DamageBuff_Group.Text = "常驻伤害buff";
            // 
            // DamageBuff_Percent
            // 
            this.DamageBuff_Percent.Current = 0F;
            this.DamageBuff_Percent.CurrentStr = "0";
            this.DamageBuff_Percent.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.DamageBuff_Percent.Location = new System.Drawing.Point(9, 25);
            this.DamageBuff_Percent.Margin = new System.Windows.Forms.Padding(6);
            this.DamageBuff_Percent.Maximum = 2000;
            this.DamageBuff_Percent.Minimum = 0;
            this.DamageBuff_Percent.Name = "DamageBuff_Percent";
            this.DamageBuff_Percent.PercentShownOrNot = true;
            this.DamageBuff_Percent.Size = new System.Drawing.Size(882, 45);
            this.DamageBuff_Percent.TabIndex = 0;
            this.DamageBuff_Percent.Title = "伤害加成";
            this.DamageBuff_Percent.ValScale = 10D;
            this.DamageBuff_Percent.ValueChange += new Genshin_Calc.ValueTracker.ValueSettingsDelegate(this.ValueSet);
            // 
            // Level_And_Res
            // 
            this.Level_And_Res.Controls.Add(this.Resistance_Group);
            this.Level_And_Res.Controls.Add(this.LevelAndDefence_Group);
            this.Level_And_Res.Location = new System.Drawing.Point(4, 32);
            this.Level_And_Res.Name = "Level_And_Res";
            this.Level_And_Res.Padding = new System.Windows.Forms.Padding(3);
            this.Level_And_Res.Size = new System.Drawing.Size(912, 331);
            this.Level_And_Res.TabIndex = 6;
            this.Level_And_Res.Text = "等级与抗性";
            this.Level_And_Res.UseVisualStyleBackColor = true;
            // 
            // Resistance_Group
            // 
            this.Resistance_Group.BackColor = System.Drawing.SystemColors.Control;
            this.Resistance_Group.Controls.Add(this.Resistance_Percent);
            this.Resistance_Group.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Resistance_Group.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.Resistance_Group.Location = new System.Drawing.Point(3, 189);
            this.Resistance_Group.Name = "Resistance_Group";
            this.Resistance_Group.Size = new System.Drawing.Size(906, 139);
            this.Resistance_Group.TabIndex = 16;
            this.Resistance_Group.TabStop = false;
            this.Resistance_Group.Text = "抗性计算";
            // 
            // Resistance_Percent
            // 
            this.Resistance_Percent.Current = 100F;
            this.Resistance_Percent.CurrentStr = "10";
            this.Resistance_Percent.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.Resistance_Percent.Location = new System.Drawing.Point(9, 35);
            this.Resistance_Percent.Margin = new System.Windows.Forms.Padding(6);
            this.Resistance_Percent.Maximum = 3000;
            this.Resistance_Percent.Minimum = -1000;
            this.Resistance_Percent.Name = "Resistance_Percent";
            this.Resistance_Percent.PercentShownOrNot = true;
            this.Resistance_Percent.Size = new System.Drawing.Size(882, 45);
            this.Resistance_Percent.TabIndex = 0;
            this.Resistance_Percent.Title = "对应属性抗性";
            this.Resistance_Percent.ValScale = 10D;
            this.Resistance_Percent.ValueChange += new Genshin_Calc.ValueTracker.ValueSettingsDelegate(this.ValueSet);
            // 
            // LevelAndDefence_Group
            // 
            this.LevelAndDefence_Group.BackColor = System.Drawing.SystemColors.Control;
            this.LevelAndDefence_Group.Controls.Add(this.Defence_Debuff);
            this.LevelAndDefence_Group.Controls.Add(this.Level_Enemy);
            this.LevelAndDefence_Group.Controls.Add(this.Level_Player);
            this.LevelAndDefence_Group.Dock = System.Windows.Forms.DockStyle.Top;
            this.LevelAndDefence_Group.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LevelAndDefence_Group.Location = new System.Drawing.Point(3, 3);
            this.LevelAndDefence_Group.Name = "LevelAndDefence_Group";
            this.LevelAndDefence_Group.Size = new System.Drawing.Size(906, 184);
            this.LevelAndDefence_Group.TabIndex = 15;
            this.LevelAndDefence_Group.TabStop = false;
            this.LevelAndDefence_Group.Text = "防御计算";
            // 
            // Defence_Debuff
            // 
            this.Defence_Debuff.Current = 0F;
            this.Defence_Debuff.CurrentStr = "0";
            this.Defence_Debuff.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.Defence_Debuff.Location = new System.Drawing.Point(9, 123);
            this.Defence_Debuff.Margin = new System.Windows.Forms.Padding(6);
            this.Defence_Debuff.Maximum = 1000;
            this.Defence_Debuff.Minimum = -1000;
            this.Defence_Debuff.Name = "Defence_Debuff";
            this.Defence_Debuff.PercentShownOrNot = true;
            this.Defence_Debuff.Size = new System.Drawing.Size(882, 45);
            this.Defence_Debuff.TabIndex = 2;
            this.Defence_Debuff.Title = "敌方防御变化";
            this.Defence_Debuff.ValScale = 10D;
            this.Defence_Debuff.ValueChange += new Genshin_Calc.ValueTracker.ValueSettingsDelegate(this.ValueSet);
            // 
            // Level_Enemy
            // 
            this.Level_Enemy.Current = 1F;
            this.Level_Enemy.CurrentStr = "1";
            this.Level_Enemy.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.Level_Enemy.Location = new System.Drawing.Point(9, 74);
            this.Level_Enemy.Margin = new System.Windows.Forms.Padding(6);
            this.Level_Enemy.Maximum = 110;
            this.Level_Enemy.Minimum = 1;
            this.Level_Enemy.Name = "Level_Enemy";
            this.Level_Enemy.PercentShownOrNot = false;
            this.Level_Enemy.Size = new System.Drawing.Size(882, 45);
            this.Level_Enemy.TabIndex = 1;
            this.Level_Enemy.Title = "敌方等级";
            this.Level_Enemy.ValScale = 1D;
            this.Level_Enemy.ValueChange += new Genshin_Calc.ValueTracker.ValueSettingsDelegate(this.ValueSet);
            // 
            // Level_Player
            // 
            this.Level_Player.Current = 1F;
            this.Level_Player.CurrentStr = "1";
            this.Level_Player.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.Level_Player.Location = new System.Drawing.Point(9, 25);
            this.Level_Player.Margin = new System.Windows.Forms.Padding(6);
            this.Level_Player.Maximum = 90;
            this.Level_Player.Minimum = 1;
            this.Level_Player.Name = "Level_Player";
            this.Level_Player.PercentShownOrNot = false;
            this.Level_Player.Size = new System.Drawing.Size(882, 45);
            this.Level_Player.TabIndex = 0;
            this.Level_Player.Title = "我方等级";
            this.Level_Player.ValScale = 1D;
            this.Level_Player.ValueChange += new Genshin_Calc.ValueTracker.ValueSettingsDelegate(this.ValueSet);
            // 
            // ChartViewer
            // 
            this.ChartViewer.BackColor = System.Drawing.SystemColors.Control;
            this.ChartViewer.Controls.Add(this.DMGType2);
            this.ChartViewer.Controls.Add(this.DMGType1);
            this.ChartViewer.Controls.Add(this.DMGType0);
            this.ChartViewer.Controls.Add(this.AttributeList);
            this.ChartViewer.Controls.Add(this.ComChart);
            this.ChartViewer.Location = new System.Drawing.Point(4, 32);
            this.ChartViewer.Name = "ChartViewer";
            this.ChartViewer.Padding = new System.Windows.Forms.Padding(3);
            this.ChartViewer.Size = new System.Drawing.Size(912, 331);
            this.ChartViewer.TabIndex = 4;
            this.ChartViewer.Text = "伤害构成";
            // 
            // DMGType2
            // 
            this.DMGType2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DMGType2.Appearance = System.Windows.Forms.Appearance.Button;
            this.DMGType2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DMGType2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.DMGType2.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleTurquoise;
            this.DMGType2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.DMGType2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.DMGType2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DMGType2.Font = new System.Drawing.Font("微软雅黑", 13.5F);
            this.DMGType2.Location = new System.Drawing.Point(244, 292);
            this.DMGType2.Name = "DMGType2";
            this.DMGType2.Size = new System.Drawing.Size(122, 36);
            this.DMGType2.TabIndex = 51;
            this.DMGType2.Text = "伤害期望";
            this.DMGType2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DMGType2.UseVisualStyleBackColor = true;
            this.DMGType2.CheckedChanged += new System.EventHandler(this.DetailedCalculate);
            // 
            // DMGType1
            // 
            this.DMGType1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DMGType1.Appearance = System.Windows.Forms.Appearance.Button;
            this.DMGType1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DMGType1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.DMGType1.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleTurquoise;
            this.DMGType1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.DMGType1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.DMGType1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DMGType1.Font = new System.Drawing.Font("微软雅黑", 13.5F);
            this.DMGType1.Location = new System.Drawing.Point(123, 292);
            this.DMGType1.Name = "DMGType1";
            this.DMGType1.Size = new System.Drawing.Size(123, 36);
            this.DMGType1.TabIndex = 50;
            this.DMGType1.Text = "已暴击";
            this.DMGType1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DMGType1.UseVisualStyleBackColor = true;
            this.DMGType1.CheckedChanged += new System.EventHandler(this.DetailedCalculate);
            // 
            // DMGType0
            // 
            this.DMGType0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DMGType0.Appearance = System.Windows.Forms.Appearance.Button;
            this.DMGType0.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DMGType0.Checked = true;
            this.DMGType0.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.DMGType0.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleTurquoise;
            this.DMGType0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.DMGType0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.DMGType0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DMGType0.Font = new System.Drawing.Font("微软雅黑", 13.5F);
            this.DMGType0.Location = new System.Drawing.Point(3, 292);
            this.DMGType0.Name = "DMGType0";
            this.DMGType0.Size = new System.Drawing.Size(123, 36);
            this.DMGType0.TabIndex = 49;
            this.DMGType0.TabStop = true;
            this.DMGType0.Text = "未暴击";
            this.DMGType0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DMGType0.UseVisualStyleBackColor = true;
            this.DMGType0.CheckedChanged += new System.EventHandler(this.DetailedCalculate);
            // 
            // AttributeList
            // 
            this.AttributeList.BackColor = System.Drawing.SystemColors.Control;
            this.AttributeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnA,
            this.ColumnB,
            this.ColumnC});
            this.AttributeList.Dock = System.Windows.Forms.DockStyle.Left;
            this.AttributeList.Font = new System.Drawing.Font("微软雅黑", 13.5F);
            this.AttributeList.HideSelection = false;
            this.AttributeList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.AttributeList.Location = new System.Drawing.Point(3, 3);
            this.AttributeList.Name = "AttributeList";
            this.AttributeList.ShowGroups = false;
            this.AttributeList.Size = new System.Drawing.Size(363, 325);
            this.AttributeList.TabIndex = 48;
            this.AttributeList.UseCompatibleStateImageBehavior = false;
            this.AttributeList.View = System.Windows.Forms.View.Details;
            // 
            // ColumnA
            // 
            this.ColumnA.Text = "计算乘区";
            this.ColumnA.Width = 105;
            // 
            // ColumnB
            // 
            this.ColumnB.Text = "算术比率";
            this.ColumnB.Width = 135;
            // 
            // ColumnC
            // 
            this.ColumnC.Text = "乘区占比";
            this.ColumnC.Width = 120;
            // 
            // ComChart
            // 
            this.ComChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            textAnnotation1.AllowAnchorMoving = true;
            textAnnotation1.AnchorAlignment = System.Drawing.ContentAlignment.BottomRight;
            textAnnotation1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textAnnotation1.Name = "TextAnnotation1";
            textAnnotation1.Text = "在本页中，乘区占比越低的部分，提升后收益越高。双击此图可切换乘区计算逻辑。";
            textAnnotation1.X = 0D;
            textAnnotation1.Y = 93D;
            textAnnotation2.Name = "TextAnnotation2";
            textAnnotation2.Text = "当前：所有乘区（包括扣减伤害的乘区）均累加";
            textAnnotation2.X = 50D;
            textAnnotation2.Y = 1D;
            textAnnotation3.Name = "TextAnnotation3";
            textAnnotation3.Text = "当前：扣减伤害的乘区会表现为负数";
            textAnnotation3.Visible = false;
            textAnnotation3.X = 61D;
            textAnnotation3.Y = 1D;
            this.ComChart.Annotations.Add(textAnnotation1);
            this.ComChart.Annotations.Add(textAnnotation2);
            this.ComChart.Annotations.Add(textAnnotation3);
            this.ComChart.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Area3DStyle.Inclination = 3;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 2;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.BackSecondaryColor = System.Drawing.SystemColors.ControlDark;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 75F;
            chartArea1.Position.Width = 75F;
            chartArea1.Position.Y = 10F;
            this.ComChart.ChartAreas.Add(chartArea1);
            legend1.AutoFitMinFontSize = 9;
            legend1.BackColor = System.Drawing.SystemColors.Control;
            legendCellColumn1.ColumnType = System.Windows.Forms.DataVisualization.Charting.LegendCellColumnType.SeriesSymbol;
            legendCellColumn1.Name = "Column1";
            legendCellColumn2.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            legendCellColumn2.Name = "Column2";
            legendCellColumn2.Text = "#VALX : #PERCENT";
            legend1.CellColumns.Add(legendCellColumn1);
            legend1.CellColumns.Add(legendCellColumn2);
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 45F;
            legend1.Position.Width = 30F;
            legend1.Position.X = 70F;
            legend1.Position.Y = 50F;
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.ComChart.Legends.Add(legend1);
            this.ComChart.Location = new System.Drawing.Point(364, 3);
            this.ComChart.Name = "ComChart";
            this.ComChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.ComChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(235)))), ((int)(((byte)(205))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(238)))), ((int)(((byte)(108))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(204)))), ((int)(((byte)(234))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(195))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(185)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))))};
            series1.BackSecondaryColor = System.Drawing.SystemColors.HighlightText;
            series1.BorderColor = System.Drawing.SystemColors.ControlDark;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.SystemColors.AppWorkspace;
            series1.CustomProperties = "DoughnutRadius=30, MinimumRelativePieSize=50, PieLabelStyle=Outside, PieLineColor" +
    "=ControlDark";
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series1.LabelForeColor = System.Drawing.SystemColors.ControlDarkDark;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.SystemColors.ControlDark;
            series1.MarkerColor = System.Drawing.SystemColors.ControlDark;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.ComChart.Series.Add(series1);
            this.ComChart.Size = new System.Drawing.Size(545, 325);
            this.ComChart.TabIndex = 1;
            this.ComChart.Text = "chart1";
            this.ComChart.DoubleClick += new System.EventHandler(this.ComChart_Click);
            // 
            // NormalDMG_Text
            // 
            this.NormalDMG_Text.AutoSize = true;
            this.NormalDMG_Text.Font = new System.Drawing.Font("方正像素18", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NormalDMG_Text.Location = new System.Drawing.Point(49, 16);
            this.NormalDMG_Text.Name = "NormalDMG_Text";
            this.NormalDMG_Text.Size = new System.Drawing.Size(154, 24);
            this.NormalDMG_Text.TabIndex = 13;
            this.NormalDMG_Text.Text = "未暴击的伤害";
            // 
            // CritDMG_Text
            // 
            this.CritDMG_Text.AutoSize = true;
            this.CritDMG_Text.Font = new System.Drawing.Font("方正像素18", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CritDMG_Text.Location = new System.Drawing.Point(273, 16);
            this.CritDMG_Text.Name = "CritDMG_Text";
            this.CritDMG_Text.Size = new System.Drawing.Size(154, 24);
            this.CritDMG_Text.TabIndex = 14;
            this.CritDMG_Text.Text = "已暴击的伤害";
            // 
            // AvgDMG_Text
            // 
            this.AvgDMG_Text.AutoSize = true;
            this.AvgDMG_Text.Font = new System.Drawing.Font("方正像素18", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AvgDMG_Text.Location = new System.Drawing.Point(497, 16);
            this.AvgDMG_Text.Name = "AvgDMG_Text";
            this.AvgDMG_Text.Size = new System.Drawing.Size(154, 24);
            this.AvgDMG_Text.TabIndex = 15;
            this.AvgDMG_Text.Text = "单次伤害期望";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Reaction);
            this.panel1.Controls.Add(this.Reaction_Choose);
            this.panel1.Controls.Add(this.Normal_DMG);
            this.panel1.Controls.Add(this.Crit_DMG);
            this.panel1.Controls.Add(this.Avg_DMG);
            this.panel1.Controls.Add(this.NormalDMG_Text);
            this.panel1.Controls.Add(this.CritDMG_Text);
            this.panel1.Controls.Add(this.AvgDMG_Text);
            this.panel1.Location = new System.Drawing.Point(12, 498);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 105);
            this.panel1.TabIndex = 69;
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.OpenFiles_Drag);
            // 
            // Reaction
            // 
            this.Reaction.AutoSize = true;
            this.Reaction.Font = new System.Drawing.Font("方正像素18", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Reaction.Location = new System.Drawing.Point(726, 16);
            this.Reaction.Name = "Reaction";
            this.Reaction.Size = new System.Drawing.Size(154, 24);
            this.Reaction.TabIndex = 20;
            this.Reaction.Text = "是否触发反应";
            // 
            // Reaction_Choose
            // 
            this.Reaction_Choose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Reaction_Choose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Reaction_Choose.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Reaction_Choose.FormattingEnabled = true;
            this.Reaction_Choose.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Reaction_Choose.Items.AddRange(new object[] {
            "不触发反应",
            "触发超导反应",
            "触发扩散反应",
            "触发感电反应",
            "触发碎冰反应",
            "触发超载反应",
            "触发增幅反应(小)",
            "触发增幅反应(大)"});
            this.Reaction_Choose.Location = new System.Drawing.Point(715, 57);
            this.Reaction_Choose.Name = "Reaction_Choose";
            this.Reaction_Choose.Size = new System.Drawing.Size(176, 33);
            this.Reaction_Choose.TabIndex = 70;
            this.Reaction_Choose.SelectedIndexChanged += new System.EventHandler(this.Reaction_Choose_SelectedIndexChanged);
            // 
            // Normal_DMG
            // 
            this.Normal_DMG.Font = new System.Drawing.Font("方正像素12", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Normal_DMG.ForeColor = System.Drawing.Color.DarkRed;
            this.Normal_DMG.Location = new System.Drawing.Point(48, 57);
            this.Normal_DMG.Name = "Normal_DMG";
            this.Normal_DMG.Size = new System.Drawing.Size(154, 33);
            this.Normal_DMG.TabIndex = 16;
            this.Normal_DMG.Text = "0";
            this.Normal_DMG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Crit_DMG
            // 
            this.Crit_DMG.Font = new System.Drawing.Font("方正像素12", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Crit_DMG.ForeColor = System.Drawing.Color.DarkRed;
            this.Crit_DMG.Location = new System.Drawing.Point(273, 57);
            this.Crit_DMG.Name = "Crit_DMG";
            this.Crit_DMG.Size = new System.Drawing.Size(154, 33);
            this.Crit_DMG.TabIndex = 17;
            this.Crit_DMG.Text = "0";
            this.Crit_DMG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Avg_DMG
            // 
            this.Avg_DMG.Font = new System.Drawing.Font("方正像素12", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Avg_DMG.ForeColor = System.Drawing.Color.DarkRed;
            this.Avg_DMG.Location = new System.Drawing.Point(498, 57);
            this.Avg_DMG.Name = "Avg_DMG";
            this.Avg_DMG.Size = new System.Drawing.Size(154, 33);
            this.Avg_DMG.TabIndex = 18;
            this.Avg_DMG.Text = "0";
            this.Avg_DMG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TransButton
            // 
            this.TransButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TransButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TransButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TransButton.FlatAppearance.BorderSize = 0;
            this.TransButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TransButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransButton.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TransButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TransButton.Location = new System.Drawing.Point(743, 0);
            this.TransButton.Name = "TransButton";
            this.TransButton.Size = new System.Drawing.Size(201, 32);
            this.TransButton.TabIndex = 100;
            this.TransButton.Text = "按住以透明化此窗口";
            this.TransButton.UseVisualStyleBackColor = false;
            this.TransButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TransButton_MouseDown);
            this.TransButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TransButton_MouseUp);
            // 
            // statusStrips
            // 
            this.statusStrips.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrips});
            this.statusStrips.Location = new System.Drawing.Point(0, 614);
            this.statusStrips.Name = "statusStrips";
            this.statusStrips.Size = new System.Drawing.Size(944, 22);
            this.statusStrips.TabIndex = 25;
            this.statusStrips.Text = "statusStrip1";
            // 
            // toolStrips
            // 
            this.toolStrips.AutoSize = false;
            this.toolStrips.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrips.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.toolStrips.Name = "toolStrips";
            this.toolStrips.Size = new System.Drawing.Size(640, 17);
            this.toolStrips.Text = "点击此处添加备注";
            this.toolStrips.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStrips.Click += new System.EventHandler(this.Notes);
            // 
            // OpenFile
            // 
            this.OpenFile.Filter = "计算器角色文件|*.yschar|文本文件|*.txt|所有文件|*.*";
            this.OpenFile.InitialDirectory = "C:\\Users\\xcxxd\\AppData\\Roaming\\Genshin Calculator\\";
            // 
            // SaveFile
            // 
            this.SaveFile.DefaultExt = "ysdata";
            // 
            // Skill
            // 
            this.Skill.Current = 1000F;
            this.Skill.CurrentStr = "100";
            this.Skill.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.Skill.Location = new System.Drawing.Point(28, 403);
            this.Skill.Margin = new System.Windows.Forms.Padding(6);
            this.Skill.Maximum = 10000;
            this.Skill.Minimum = 0;
            this.Skill.Name = "Skill";
            this.Skill.PercentShownOrNot = true;
            this.Skill.Size = new System.Drawing.Size(891, 45);
            this.Skill.TabIndex = 101;
            this.Skill.Title = "技能倍率";
            this.Skill.ValScale = 10D;
            this.Skill.ValueChange += new Genshin_Calc.ValueTracker.ValueSettingsDelegate(this.ValueSet);
            // 
            // Other
            // 
            this.Other.Current = 1000F;
            this.Other.CurrentStr = "100";
            this.Other.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.Other.Location = new System.Drawing.Point(28, 448);
            this.Other.Margin = new System.Windows.Forms.Padding(6);
            this.Other.Maximum = 20000;
            this.Other.Minimum = 1000;
            this.Other.Name = "Other";
            this.Other.PercentShownOrNot = true;
            this.Other.Size = new System.Drawing.Size(891, 45);
            this.Other.TabIndex = 102;
            this.Other.Title = "额外伤害乘区";
            this.Other.ValScale = 10D;
            this.Other.ValueChange += new Genshin_Calc.ValueTracker.ValueSettingsDelegate(this.ValueSet);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 636);
            this.Controls.Add(this.Other);
            this.Controls.Add(this.Skill);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrips);
            this.Controls.Add(this.TransButton);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(960, 675);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "原神计算器 15.0.0.0";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragComplete);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.OpenFiles_Drag);
            this.DragLeave += new System.EventHandler(this.DragBreak);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.P1.ResumeLayout(false);
            this.Basic.ResumeLayout(false);
            this.BasicGroup.ResumeLayout(false);
            this.ATK_Buff.ResumeLayout(false);
            this.ATKBuff_Stack_Group.ResumeLayout(false);
            this.ATKBuff_Group.ResumeLayout(false);
            this.ATKBuff_Group.PerformLayout();
            this.Damage_Buff.ResumeLayout(false);
            this.DamageBuff_Reaction_Group.ResumeLayout(false);
            this.DamageBuffStack_Group.ResumeLayout(false);
            this.DamageBuff_Group.ResumeLayout(false);
            this.Level_And_Res.ResumeLayout(false);
            this.Resistance_Group.ResumeLayout(false);
            this.LevelAndDefence_Group.ResumeLayout(false);
            this.ChartViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrips.ResumeLayout(false);
            this.statusStrips.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读取ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 存档ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数值上下限设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 使用入门ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.TabControl P1;
        private System.Windows.Forms.TabPage Basic;
        private System.Windows.Forms.ToolStripMenuItem 窗口置顶ToolStripMenuItem;
        private System.Windows.Forms.Label NormalDMG_Text;
        private System.Windows.Forms.Label CritDMG_Text;
        private System.Windows.Forms.Label AvgDMG_Text;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Normal_DMG;
        private System.Windows.Forms.Label Crit_DMG;
        private System.Windows.Forms.Label Avg_DMG;
        private System.Windows.Forms.Label Reaction;
        private System.Windows.Forms.ComboBox Reaction_Choose;
        private System.Windows.Forms.Button TransButton;
        private StatusStrip statusStrips;
        private ToolStripStatusLabel toolStrips;
        private ToolStripMenuItem 工具ToolStripMenuItem;
        private ToolStripMenuItem 计算公式来源ToolStripMenuItem;
        private ToolStripMenuItem 锚定伤害计算器ToolStripMenuItem;
        private ToolStripMenuItem 特殊计算ToolStripMenuItem;
        private ToolStripMenuItem 诺艾尔防御转攻击ToolStripMenuItem;
        private ToolStripMenuItem 阿贝多防御值加伤替换攻击ToolStripMenuItem;
        private ToolStripMenuItem 钟离生命值加伤ToolStripMenuItem;
        private ToolStripMenuItem 胡桃生命值加攻ToolStripMenuItem;
        private ToolStripMenuItem 治疗量计算器ToolStripMenuItem;
        private ToolStripMenuItem windows计算器ToolStripMenuItem;
        private ToolStripMenuItem DPS简易计算ToolStripMenuItem;
        private ToolStripMenuItem 查询ToolStripMenuItem;
        private ToolStripMenuItem 角色与武器快捷输入ToolStripMenuItem;
        private ToolStripMenuItem 敌人抗性快速查询ToolStripMenuItem;
        private ToolStripMenuItem 修复字体ToolStripMenuItem;
        private ToolStripMenuItem 数据存放文件夹ToolStripMenuItem;
        private OpenFileDialog OpenFile;
        private SaveFileDialog SaveFile;
        private ToolStripMenuItem Cocogoat圣遗物导入ToolStripMenuItem;
        private ToolStripMenuItem 圣遗物简易比较器ToolStripMenuItem;
        private TabPage ChartViewer;
        //private SplitContainer Spliter;
        private RadioButton DMGType2;
        private RadioButton DMGType1;
        private RadioButton DMGType0;
        private ListView AttributeList;
        private ColumnHeader ColumnA;
        private ColumnHeader ColumnB;
        private ColumnHeader ColumnC;
        private System.Windows.Forms.DataVisualization.Charting.Chart ComChart;
        private TabPage Damage_Buff;

        private GroupBox BasicGroup;
        private ValueTracker ATK_Basic;
        private ValueTracker ATK_Added;
        private ValueTracker ElemMastery;
        private ValueTracker Crit_Rate;
        private ValueTracker Crit_Damage;
        private ValueTracker DamageBuff_Elem;
        private TabPage Level_And_Res;
        private TabPage ATK_Buff;
        private GroupBox ATKBuff_Stack_Group;
        private GroupBox ATKBuff_Group;
        private ValueTracker ATKBuff_Percent;
        private ValueTracker ATKBuff_Static;
        private Label label15;
        private ValueTracker ATKBuff_Stack_Count;
        private ValueTracker ATKBuff_Stack_Percent;
        private Label ATKBuff_HP;
        private Label ATKBuff_DEF;
        private Label ATKBuff_HP_Label;
        private Label ATKBuff_DEF_Label;
        private GroupBox DamageBuff_Reaction_Group;
        private ValueTracker DamageBuff_Reaction;
        private GroupBox DamageBuffStack_Group;
        private ValueTracker DamageBuff_Stack_Count;
        private ValueTracker DamageBuff_Stack_Percent;
        private GroupBox DamageBuff_Group;
        private ValueTracker DamageBuff_Percent;
        private GroupBox Resistance_Group;
        private ValueTracker Resistance_Percent;
        private GroupBox LevelAndDefence_Group;
        private ValueTracker Defence_Debuff;
        private ValueTracker Level_Enemy;
        private ValueTracker Level_Player;
        private ValueTracker Skill;
        private ValueTracker Other;
    }
}

