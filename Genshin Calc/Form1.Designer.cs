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
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windows计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.锚定伤害计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.治疗量计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DPS简易计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.圣遗物简易比较器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.角色与武器快捷输入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.敌人抗性快速查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cocogoat圣遗物导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.特殊计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.诺艾尔防御转攻击ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.阿贝多防御值加伤替换攻击ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.钟离生命值加伤ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.胡桃生命值加攻ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使用入门ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算公式来源ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ATK1 = new System.Windows.Forms.TrackBar();
            this.ATK = new System.Windows.Forms.TextBox();
            this.CritRate = new System.Windows.Forms.TextBox();
            this.CritRate1 = new System.Windows.Forms.TrackBar();
            this.ATK_Label = new System.Windows.Forms.Label();
            this.CR_Label = new System.Windows.Forms.Label();
            this.CritDMG1 = new System.Windows.Forms.TrackBar();
            this.CritDMG = new System.Windows.Forms.TextBox();
            this.CD_Label = new System.Windows.Forms.Label();
            this.Group_A = new System.Windows.Forms.GroupBox();
            this.ATKPlus1 = new System.Windows.Forms.TrackBar();
            this.ATKPlus = new System.Windows.Forms.TextBox();
            this.EP1 = new System.Windows.Forms.TrackBar();
            this.EP = new System.Windows.Forms.TextBox();
            this.EP_Label = new System.Windows.Forms.Label();
            this.EM1 = new System.Windows.Forms.TrackBar();
            this.EM = new System.Windows.Forms.TextBox();
            this.EM_Label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.P1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BUFF_ATK2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ATKBuff1_Sf = new System.Windows.Forms.TrackBar();
            this.ATKBuff_Sf = new System.Windows.Forms.TextBox();
            this.ATKBuff1_S = new System.Windows.Forms.TrackBar();
            this.ATKBuff_S = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BUFF_ATK_1 = new System.Windows.Forms.GroupBox();
            this.ATKBuff_HP = new System.Windows.Forms.Label();
            this.ATKBuff_DEF = new System.Windows.Forms.Label();
            this.ATKBuff_HP_Label = new System.Windows.Forms.Label();
            this.ATKBuff_DEF_Label = new System.Windows.Forms.Label();
            this.ATKBuff_other_label = new System.Windows.Forms.Label();
            this.ATKBuff1_P = new System.Windows.Forms.TrackBar();
            this.ATK_Buff_Num = new System.Windows.Forms.Label();
            this.ATKBuff1 = new System.Windows.Forms.TrackBar();
            this.ATKBuff = new System.Windows.Forms.TextBox();
            this.ATKBuff_P = new System.Windows.Forms.TextBox();
            this.ATK_Buff_Percent = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.RES = new System.Windows.Forms.GroupBox();
            this.EnemyRES1 = new System.Windows.Forms.TrackBar();
            this.EnemyRES = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DEF = new System.Windows.Forms.GroupBox();
            this.Defense1 = new System.Windows.Forms.TrackBar();
            this.LVL_E = new System.Windows.Forms.Label();
            this.Defense = new System.Windows.Forms.TextBox();
            this.EnemyLevel1 = new System.Windows.Forms.TrackBar();
            this.DEF_Text = new System.Windows.Forms.Label();
            this.EnemyLevel = new System.Windows.Forms.TextBox();
            this.LVL_P = new System.Windows.Forms.Label();
            this.PlayerLevel1 = new System.Windows.Forms.TrackBar();
            this.PlayerLevel = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ReactBuff1 = new System.Windows.Forms.TrackBar();
            this.ReactBuff = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DMGBuff1_Sf = new System.Windows.Forms.TrackBar();
            this.DMGBuff_Sf = new System.Windows.Forms.TextBox();
            this.DMGBuff1_S = new System.Windows.Forms.TrackBar();
            this.DMGBuff_S = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DMGBuff1 = new System.Windows.Forms.TrackBar();
            this.DMGBuff = new System.Windows.Forms.TextBox();
            this.DMG_Buff = new System.Windows.Forms.Label();
            this.NormalDMG_Text = new System.Windows.Forms.Label();
            this.CritDMG_Text = new System.Windows.Forms.Label();
            this.AvgDMG_Text = new System.Windows.Forms.Label();
            this.Skill1 = new System.Windows.Forms.TrackBar();
            this.Skill = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Other1 = new System.Windows.Forms.TrackBar();
            this.Other = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Reaction = new System.Windows.Forms.Label();
            this.Reaction_Choose = new System.Windows.Forms.ComboBox();
            this.Normal_DMG = new System.Windows.Forms.Label();
            this.Crit_DMG = new System.Windows.Forms.Label();
            this.Avg_DMG = new System.Windows.Forms.Label();
            this.TransButton = new System.Windows.Forms.Button();
            this.statusStrips = new System.Windows.Forms.StatusStrip();
            this.toolStrips = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ATK1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CritRate1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CritDMG1)).BeginInit();
            this.Group_A.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ATKPlus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EM1)).BeginInit();
            this.P1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.BUFF_ATK2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ATKBuff1_Sf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATKBuff1_S)).BeginInit();
            this.BUFF_ATK_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ATKBuff1_P)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATKBuff1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.RES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyRES1)).BeginInit();
            this.DEF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Defense1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyLevel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerLevel1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReactBuff1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DMGBuff1_Sf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DMGBuff1_S)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DMGBuff1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skill1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Other1)).BeginInit();
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
            this.工具ToolStripMenuItem,
            this.查询ToolStripMenuItem,
            this.特殊计算ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 32);
            this.menuStrip1.TabIndex = 0;
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
            this.角色与武器快捷输入ToolStripMenuItem.Size = new System.Drawing.Size(244, 28);
            this.角色与武器快捷输入ToolStripMenuItem.Text = "角色与武器快捷输入";
            this.角色与武器快捷输入ToolStripMenuItem.Click += new System.EventHandler(this.角色与武器快捷输入ToolStripMenuItem_Click_1);
            // 
            // 敌人抗性快速查询ToolStripMenuItem
            // 
            this.敌人抗性快速查询ToolStripMenuItem.Name = "敌人抗性快速查询ToolStripMenuItem";
            this.敌人抗性快速查询ToolStripMenuItem.Size = new System.Drawing.Size(244, 28);
            this.敌人抗性快速查询ToolStripMenuItem.Text = "敌人抗性快速查询";
            this.敌人抗性快速查询ToolStripMenuItem.Click += new System.EventHandler(this.敌人抗性快速查询ToolStripMenuItem_Click_1);
            // 
            // Cocogoat圣遗物导入ToolStripMenuItem
            // 
            this.Cocogoat圣遗物导入ToolStripMenuItem.Name = "Cocogoat圣遗物导入ToolStripMenuItem";
            this.Cocogoat圣遗物导入ToolStripMenuItem.Size = new System.Drawing.Size(244, 28);
            this.Cocogoat圣遗物导入ToolStripMenuItem.Text = "Cocogoat圣遗物导入";
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
            // ATK1
            // 
            this.ATK1.AllowDrop = true;
            this.ATK1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ATK1.BackColor = System.Drawing.SystemColors.Control;
            this.ATK1.LargeChange = 50;
            this.ATK1.Location = new System.Drawing.Point(304, 34);
            this.ATK1.Maximum = 2000;
            this.ATK1.Name = "ATK1";
            this.ATK1.Size = new System.Drawing.Size(566, 45);
            this.ATK1.TabIndex = 2;
            this.ATK1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ATK1.Value = 400;
            this.ATK1.Scroll += new System.EventHandler(this.ATK1_Scroll);
            // 
            // ATK
            // 
            this.ATK.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATK.ForeColor = System.Drawing.Color.Gray;
            this.ATK.Location = new System.Drawing.Point(200, 34);
            this.ATK.MaxLength = 4;
            this.ATK.Name = "ATK";
            this.ATK.Size = new System.Drawing.Size(96, 32);
            this.ATK.TabIndex = 1;
            this.ATK.Text = "400";
            this.ATK.TextChanged += new System.EventHandler(this.ATK_TextChanged);
            // 
            // CritRate
            // 
            this.CritRate.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CritRate.Location = new System.Drawing.Point(200, 130);
            this.CritRate.MaxLength = 8;
            this.CritRate.Name = "CritRate";
            this.CritRate.Size = new System.Drawing.Size(77, 32);
            this.CritRate.TabIndex = 5;
            this.CritRate.Text = "5";
            this.CritRate.TextChanged += new System.EventHandler(this.CritRate_TextChanged);
            // 
            // CritRate1
            // 
            this.CritRate1.AllowDrop = true;
            this.CritRate1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CritRate1.BackColor = System.Drawing.SystemColors.Control;
            this.CritRate1.LargeChange = 0;
            this.CritRate1.Location = new System.Drawing.Point(304, 130);
            this.CritRate1.Maximum = 1000;
            this.CritRate1.Name = "CritRate1";
            this.CritRate1.Size = new System.Drawing.Size(566, 45);
            this.CritRate1.TabIndex = 6;
            this.CritRate1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.CritRate1.Value = 50;
            this.CritRate1.Scroll += new System.EventHandler(this.CritRate1_Scroll);
            // 
            // ATK_Label
            // 
            this.ATK_Label.AutoSize = true;
            this.ATK_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ATK_Label.Location = new System.Drawing.Point(22, 34);
            this.ATK_Label.Name = "ATK_Label";
            this.ATK_Label.Size = new System.Drawing.Size(117, 28);
            this.ATK_Label.TabIndex = 6;
            this.ATK_Label.Text = "白字攻击力";
            // 
            // CR_Label
            // 
            this.CR_Label.AutoSize = true;
            this.CR_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CR_Label.Location = new System.Drawing.Point(22, 130);
            this.CR_Label.Name = "CR_Label";
            this.CR_Label.Size = new System.Drawing.Size(289, 28);
            this.CR_Label.TabIndex = 7;
            this.CR_Label.Text = "暴击率                       字      %";
            // 
            // CritDMG1
            // 
            this.CritDMG1.AllowDrop = true;
            this.CritDMG1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CritDMG1.BackColor = System.Drawing.SystemColors.Control;
            this.CritDMG1.LargeChange = 0;
            this.CritDMG1.Location = new System.Drawing.Point(304, 178);
            this.CritDMG1.Maximum = 4000;
            this.CritDMG1.Minimum = 500;
            this.CritDMG1.Name = "CritDMG1";
            this.CritDMG1.Size = new System.Drawing.Size(566, 45);
            this.CritDMG1.TabIndex = 8;
            this.CritDMG1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.CritDMG1.Value = 1000;
            this.CritDMG1.Scroll += new System.EventHandler(this.CritDMG1_Scroll);
            // 
            // CritDMG
            // 
            this.CritDMG.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CritDMG.Location = new System.Drawing.Point(200, 178);
            this.CritDMG.MaxLength = 8;
            this.CritDMG.Name = "CritDMG";
            this.CritDMG.Size = new System.Drawing.Size(77, 32);
            this.CritDMG.TabIndex = 7;
            this.CritDMG.Text = "50";
            this.CritDMG.TextChanged += new System.EventHandler(this.CritDMG_TextChanged);
            // 
            // CD_Label
            // 
            this.CD_Label.AutoSize = true;
            this.CD_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CD_Label.Location = new System.Drawing.Point(22, 178);
            this.CD_Label.Name = "CD_Label";
            this.CD_Label.Size = new System.Drawing.Size(289, 28);
            this.CD_Label.TabIndex = 10;
            this.CD_Label.Text = "暴击伤害                             %";
            // 
            // Group_A
            // 
            this.Group_A.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Group_A.BackColor = System.Drawing.SystemColors.Control;
            this.Group_A.Controls.Add(this.ATKPlus1);
            this.Group_A.Controls.Add(this.ATKPlus);
            this.Group_A.Controls.Add(this.EP1);
            this.Group_A.Controls.Add(this.EP);
            this.Group_A.Controls.Add(this.EP_Label);
            this.Group_A.Controls.Add(this.EM1);
            this.Group_A.Controls.Add(this.EM);
            this.Group_A.Controls.Add(this.EM_Label);
            this.Group_A.Controls.Add(this.CritRate1);
            this.Group_A.Controls.Add(this.CritDMG1);
            this.Group_A.Controls.Add(this.CritDMG);
            this.Group_A.Controls.Add(this.ATK1);
            this.Group_A.Controls.Add(this.ATK);
            this.Group_A.Controls.Add(this.CritRate);
            this.Group_A.Controls.Add(this.CR_Label);
            this.Group_A.Controls.Add(this.CD_Label);
            this.Group_A.Controls.Add(this.ATK_Label);
            this.Group_A.Controls.Add(this.label8);
            this.Group_A.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Group_A.Location = new System.Drawing.Point(6, 6);
            this.Group_A.Name = "Group_A";
            this.Group_A.Size = new System.Drawing.Size(900, 320);
            this.Group_A.TabIndex = 11;
            this.Group_A.TabStop = false;
            this.Group_A.Text = "我方攻击面板";
            // 
            // ATKPlus1
            // 
            this.ATKPlus1.AllowDrop = true;
            this.ATKPlus1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ATKPlus1.BackColor = System.Drawing.SystemColors.Control;
            this.ATKPlus1.LargeChange = 50;
            this.ATKPlus1.Location = new System.Drawing.Point(304, 82);
            this.ATKPlus1.Maximum = 3000;
            this.ATKPlus1.Name = "ATKPlus1";
            this.ATKPlus1.Size = new System.Drawing.Size(566, 45);
            this.ATKPlus1.TabIndex = 4;
            this.ATKPlus1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ATKPlus1.Value = 400;
            this.ATKPlus1.Scroll += new System.EventHandler(this.ATKPlus1_Scroll);
            // 
            // ATKPlus
            // 
            this.ATKPlus.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATKPlus.ForeColor = System.Drawing.Color.Green;
            this.ATKPlus.Location = new System.Drawing.Point(200, 82);
            this.ATKPlus.MaxLength = 8;
            this.ATKPlus.Name = "ATKPlus";
            this.ATKPlus.Size = new System.Drawing.Size(96, 32);
            this.ATKPlus.TabIndex = 3;
            this.ATKPlus.Text = "400";
            this.ATKPlus.TextChanged += new System.EventHandler(this.ATKPlus_TextChanged);
            // 
            // EP1
            // 
            this.EP1.AllowDrop = true;
            this.EP1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EP1.BackColor = System.Drawing.SystemColors.Control;
            this.EP1.LargeChange = 0;
            this.EP1.Location = new System.Drawing.Point(304, 274);
            this.EP1.Maximum = 1500;
            this.EP1.Name = "EP1";
            this.EP1.Size = new System.Drawing.Size(566, 45);
            this.EP1.TabIndex = 12;
            this.EP1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.EP1.Value = 616;
            this.EP1.Scroll += new System.EventHandler(this.EP1_Scroll);
            // 
            // EP
            // 
            this.EP.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EP.Location = new System.Drawing.Point(200, 274);
            this.EP.MaxLength = 8;
            this.EP.Name = "EP";
            this.EP.Size = new System.Drawing.Size(77, 32);
            this.EP.TabIndex = 11;
            this.EP.Text = "61.6";
            this.EP.TextChanged += new System.EventHandler(this.EP_TextChanged);
            // 
            // EP_Label
            // 
            this.EP_Label.AutoSize = true;
            this.EP_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EP_Label.Location = new System.Drawing.Point(22, 274);
            this.EP_Label.Name = "EP_Label";
            this.EP_Label.Size = new System.Drawing.Size(289, 28);
            this.EP_Label.TabIndex = 16;
            this.EP_Label.Text = "属性伤害加成                      %";
            // 
            // EM1
            // 
            this.EM1.AllowDrop = true;
            this.EM1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EM1.BackColor = System.Drawing.SystemColors.Control;
            this.EM1.LargeChange = 0;
            this.EM1.Location = new System.Drawing.Point(304, 226);
            this.EM1.Maximum = 1500;
            this.EM1.Name = "EM1";
            this.EM1.Size = new System.Drawing.Size(566, 45);
            this.EM1.TabIndex = 10;
            this.EM1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.EM1.Scroll += new System.EventHandler(this.EM1_Scroll);
            // 
            // EM
            // 
            this.EM.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EM.Location = new System.Drawing.Point(200, 226);
            this.EM.MaxLength = 4;
            this.EM.Name = "EM";
            this.EM.Size = new System.Drawing.Size(96, 32);
            this.EM.TabIndex = 9;
            this.EM.Text = "0";
            this.EM.TextChanged += new System.EventHandler(this.EM_TextChanged);
            // 
            // EM_Label
            // 
            this.EM_Label.AutoSize = true;
            this.EM_Label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EM_Label.Location = new System.Drawing.Point(22, 226);
            this.EM_Label.Name = "EM_Label";
            this.EM_Label.Size = new System.Drawing.Size(96, 28);
            this.EM_Label.TabIndex = 13;
            this.EM_Label.Text = "元素精通";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(22, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 28);
            this.label8.TabIndex = 19;
            this.label8.Text = "绿字攻击力";
            // 
            // P1
            // 
            this.P1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P1.Controls.Add(this.tabPage1);
            this.P1.Controls.Add(this.tabPage2);
            this.P1.Controls.Add(this.tabPage4);
            this.P1.Controls.Add(this.tabPage3);
            this.P1.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.P1.Location = new System.Drawing.Point(12, 34);
            this.P1.Name = "P1";
            this.P1.SelectedIndex = 0;
            this.P1.Size = new System.Drawing.Size(920, 367);
            this.P1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Group_A);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(912, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "面板属性";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BUFF_ATK2);
            this.tabPage2.Controls.Add(this.BUFF_ATK_1);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(912, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "攻击加成";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BUFF_ATK2
            // 
            this.BUFF_ATK2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BUFF_ATK2.BackColor = System.Drawing.SystemColors.Control;
            this.BUFF_ATK2.Controls.Add(this.label1);
            this.BUFF_ATK2.Controls.Add(this.ATKBuff1_Sf);
            this.BUFF_ATK2.Controls.Add(this.ATKBuff_Sf);
            this.BUFF_ATK2.Controls.Add(this.ATKBuff1_S);
            this.BUFF_ATK2.Controls.Add(this.ATKBuff_S);
            this.BUFF_ATK2.Controls.Add(this.label3);
            this.BUFF_ATK2.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.BUFF_ATK2.Location = new System.Drawing.Point(6, 185);
            this.BUFF_ATK2.Name = "BUFF_ATK2";
            this.BUFF_ATK2.Size = new System.Drawing.Size(900, 141);
            this.BUFF_ATK2.TabIndex = 13;
            this.BUFF_ATK2.TabStop = false;
            this.BUFF_ATK2.Text = "可叠加的攻击力加成";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(22, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "叠加的层数";
            // 
            // ATKBuff1_Sf
            // 
            this.ATKBuff1_Sf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ATKBuff1_Sf.BackColor = System.Drawing.SystemColors.Control;
            this.ATKBuff1_Sf.LargeChange = 1;
            this.ATKBuff1_Sf.Location = new System.Drawing.Point(342, 91);
            this.ATKBuff1_Sf.Maximum = 30;
            this.ATKBuff1_Sf.Name = "ATKBuff1_Sf";
            this.ATKBuff1_Sf.Size = new System.Drawing.Size(528, 45);
            this.ATKBuff1_Sf.TabIndex = 8;
            this.ATKBuff1_Sf.Scroll += new System.EventHandler(this.ATKBuff1_Sf_Scroll_1);
            // 
            // ATKBuff_Sf
            // 
            this.ATKBuff_Sf.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATKBuff_Sf.Location = new System.Drawing.Point(250, 91);
            this.ATKBuff_Sf.MaxLength = 8;
            this.ATKBuff_Sf.Name = "ATKBuff_Sf";
            this.ATKBuff_Sf.Size = new System.Drawing.Size(67, 32);
            this.ATKBuff_Sf.TabIndex = 7;
            this.ATKBuff_Sf.Text = "0";
            this.ATKBuff_Sf.TextChanged += new System.EventHandler(this.ATKBuff_Sf_TextChanged);
            // 
            // ATKBuff1_S
            // 
            this.ATKBuff1_S.AllowDrop = true;
            this.ATKBuff1_S.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ATKBuff1_S.BackColor = System.Drawing.SystemColors.Control;
            this.ATKBuff1_S.LargeChange = 0;
            this.ATKBuff1_S.Location = new System.Drawing.Point(342, 45);
            this.ATKBuff1_S.Maximum = 500;
            this.ATKBuff1_S.Name = "ATKBuff1_S";
            this.ATKBuff1_S.Size = new System.Drawing.Size(528, 45);
            this.ATKBuff1_S.TabIndex = 6;
            this.ATKBuff1_S.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ATKBuff1_S.Scroll += new System.EventHandler(this.ATKBuff1_S_Scroll_1);
            // 
            // ATKBuff_S
            // 
            this.ATKBuff_S.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATKBuff_S.Location = new System.Drawing.Point(250, 45);
            this.ATKBuff_S.MaxLength = 8;
            this.ATKBuff_S.Name = "ATKBuff_S";
            this.ATKBuff_S.Size = new System.Drawing.Size(67, 32);
            this.ATKBuff_S.TabIndex = 5;
            this.ATKBuff_S.Text = "0";
            this.ATKBuff_S.TextChanged += new System.EventHandler(this.ATKBuff_S_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(22, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "每层叠加的攻击百分比              %";
            // 
            // BUFF_ATK_1
            // 
            this.BUFF_ATK_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BUFF_ATK_1.BackColor = System.Drawing.SystemColors.Control;
            this.BUFF_ATK_1.Controls.Add(this.ATKBuff_HP);
            this.BUFF_ATK_1.Controls.Add(this.ATKBuff_DEF);
            this.BUFF_ATK_1.Controls.Add(this.ATKBuff_HP_Label);
            this.BUFF_ATK_1.Controls.Add(this.ATKBuff_DEF_Label);
            this.BUFF_ATK_1.Controls.Add(this.ATKBuff_other_label);
            this.BUFF_ATK_1.Controls.Add(this.ATKBuff1_P);
            this.BUFF_ATK_1.Controls.Add(this.ATK_Buff_Num);
            this.BUFF_ATK_1.Controls.Add(this.ATKBuff1);
            this.BUFF_ATK_1.Controls.Add(this.ATKBuff);
            this.BUFF_ATK_1.Controls.Add(this.ATKBuff_P);
            this.BUFF_ATK_1.Controls.Add(this.ATK_Buff_Percent);
            this.BUFF_ATK_1.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BUFF_ATK_1.Location = new System.Drawing.Point(6, 6);
            this.BUFF_ATK_1.Name = "BUFF_ATK_1";
            this.BUFF_ATK_1.Size = new System.Drawing.Size(900, 173);
            this.BUFF_ATK_1.TabIndex = 12;
            this.BUFF_ATK_1.TabStop = false;
            this.BUFF_ATK_1.Text = "不叠加的攻击力加成";
            // 
            // ATKBuff_HP
            // 
            this.ATKBuff_HP.AutoSize = true;
            this.ATKBuff_HP.Font = new System.Drawing.Font("方正像素12", 21F);
            this.ATKBuff_HP.Location = new System.Drawing.Point(658, 130);
            this.ATKBuff_HP.Name = "ATKBuff_HP";
            this.ATKBuff_HP.Size = new System.Drawing.Size(26, 28);
            this.ATKBuff_HP.TabIndex = 14;
            this.ATKBuff_HP.Text = "0";
            // 
            // ATKBuff_DEF
            // 
            this.ATKBuff_DEF.AutoSize = true;
            this.ATKBuff_DEF.Font = new System.Drawing.Font("方正像素12", 21F);
            this.ATKBuff_DEF.Location = new System.Drawing.Point(328, 130);
            this.ATKBuff_DEF.Name = "ATKBuff_DEF";
            this.ATKBuff_DEF.Size = new System.Drawing.Size(26, 28);
            this.ATKBuff_DEF.TabIndex = 13;
            this.ATKBuff_DEF.Text = "0";
            // 
            // ATKBuff_HP_Label
            // 
            this.ATKBuff_HP_Label.AutoSize = true;
            this.ATKBuff_HP_Label.Font = new System.Drawing.Font("微软雅黑 Light", 15.75F);
            this.ATKBuff_HP_Label.Location = new System.Drawing.Point(525, 130);
            this.ATKBuff_HP_Label.Name = "ATKBuff_HP_Label";
            this.ATKBuff_HP_Label.Size = new System.Drawing.Size(117, 28);
            this.ATKBuff_HP_Label.TabIndex = 11;
            this.ATKBuff_HP_Label.Text = "生命值收益";
            // 
            // ATKBuff_DEF_Label
            // 
            this.ATKBuff_DEF_Label.AutoSize = true;
            this.ATKBuff_DEF_Label.Font = new System.Drawing.Font("微软雅黑 Light", 15.75F);
            this.ATKBuff_DEF_Label.Location = new System.Drawing.Point(205, 130);
            this.ATKBuff_DEF_Label.Name = "ATKBuff_DEF_Label";
            this.ATKBuff_DEF_Label.Size = new System.Drawing.Size(117, 28);
            this.ATKBuff_DEF_Label.TabIndex = 10;
            this.ATKBuff_DEF_Label.Text = "防御力收益";
            // 
            // ATKBuff_other_label
            // 
            this.ATKBuff_other_label.AutoSize = true;
            this.ATKBuff_other_label.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.ATKBuff_other_label.Location = new System.Drawing.Point(22, 130);
            this.ATKBuff_other_label.Name = "ATKBuff_other_label";
            this.ATKBuff_other_label.Size = new System.Drawing.Size(138, 28);
            this.ATKBuff_other_label.TabIndex = 9;
            this.ATKBuff_other_label.Text = "其他攻击收益";
            // 
            // ATKBuff1_P
            // 
            this.ATKBuff1_P.AllowDrop = true;
            this.ATKBuff1_P.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ATKBuff1_P.BackColor = System.Drawing.SystemColors.Control;
            this.ATKBuff1_P.LargeChange = 0;
            this.ATKBuff1_P.Location = new System.Drawing.Point(304, 82);
            this.ATKBuff1_P.Maximum = 1000;
            this.ATKBuff1_P.Name = "ATKBuff1_P";
            this.ATKBuff1_P.Size = new System.Drawing.Size(566, 45);
            this.ATKBuff1_P.TabIndex = 4;
            this.ATKBuff1_P.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ATKBuff1_P.Scroll += new System.EventHandler(this.ATKBuff1_P_Scroll);
            // 
            // ATK_Buff_Num
            // 
            this.ATK_Buff_Num.AutoSize = true;
            this.ATK_Buff_Num.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ATK_Buff_Num.Location = new System.Drawing.Point(22, 34);
            this.ATK_Buff_Num.Name = "ATK_Buff_Num";
            this.ATK_Buff_Num.Size = new System.Drawing.Size(138, 28);
            this.ATK_Buff_Num.TabIndex = 6;
            this.ATK_Buff_Num.Text = "固定数值攻击";
            // 
            // ATKBuff1
            // 
            this.ATKBuff1.AllowDrop = true;
            this.ATKBuff1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ATKBuff1.BackColor = System.Drawing.SystemColors.Control;
            this.ATKBuff1.LargeChange = 20;
            this.ATKBuff1.Location = new System.Drawing.Point(304, 34);
            this.ATKBuff1.Maximum = 18000;
            this.ATKBuff1.Name = "ATKBuff1";
            this.ATKBuff1.Size = new System.Drawing.Size(566, 45);
            this.ATKBuff1.TabIndex = 2;
            this.ATKBuff1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ATKBuff1.Scroll += new System.EventHandler(this.ATKBuff1_Scroll_1);
            // 
            // ATKBuff
            // 
            this.ATKBuff.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATKBuff.Location = new System.Drawing.Point(210, 34);
            this.ATKBuff.MaxLength = 8;
            this.ATKBuff.Name = "ATKBuff";
            this.ATKBuff.Size = new System.Drawing.Size(86, 32);
            this.ATKBuff.TabIndex = 1;
            this.ATKBuff.Text = "0";
            this.ATKBuff.TextChanged += new System.EventHandler(this.ATKBuff_TextChanged_1);
            // 
            // ATKBuff_P
            // 
            this.ATKBuff_P.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATKBuff_P.Location = new System.Drawing.Point(210, 82);
            this.ATKBuff_P.MaxLength = 8;
            this.ATKBuff_P.Name = "ATKBuff_P";
            this.ATKBuff_P.Size = new System.Drawing.Size(67, 32);
            this.ATKBuff_P.TabIndex = 3;
            this.ATKBuff_P.Text = "0";
            this.ATKBuff_P.TextChanged += new System.EventHandler(this.ATKBuff_P_TextChanged);
            // 
            // ATK_Buff_Percent
            // 
            this.ATK_Buff_Percent.AutoSize = true;
            this.ATK_Buff_Percent.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ATK_Buff_Percent.Location = new System.Drawing.Point(22, 82);
            this.ATK_Buff_Percent.Name = "ATK_Buff_Percent";
            this.ATK_Buff_Percent.Size = new System.Drawing.Size(286, 28);
            this.ATK_Buff_Percent.TabIndex = 8;
            this.ATK_Buff_Percent.Text = "固定百分比攻击                  %";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.RES);
            this.tabPage4.Controls.Add(this.DEF);
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(912, 333);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "敌我属性";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // RES
            // 
            this.RES.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RES.BackColor = System.Drawing.SystemColors.Control;
            this.RES.Controls.Add(this.EnemyRES1);
            this.RES.Controls.Add(this.EnemyRES);
            this.RES.Controls.Add(this.label7);
            this.RES.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.RES.Location = new System.Drawing.Point(6, 212);
            this.RES.Name = "RES";
            this.RES.Size = new System.Drawing.Size(900, 114);
            this.RES.TabIndex = 14;
            this.RES.TabStop = false;
            this.RES.Text = "减伤计算";
            // 
            // EnemyRES1
            // 
            this.EnemyRES1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnemyRES1.BackColor = System.Drawing.SystemColors.Control;
            this.EnemyRES1.LargeChange = 0;
            this.EnemyRES1.Location = new System.Drawing.Point(304, 49);
            this.EnemyRES1.Maximum = 3000;
            this.EnemyRES1.Minimum = -1000;
            this.EnemyRES1.Name = "EnemyRES1";
            this.EnemyRES1.Size = new System.Drawing.Size(566, 45);
            this.EnemyRES1.SmallChange = 10;
            this.EnemyRES1.TabIndex = 8;
            this.EnemyRES1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.EnemyRES1.Value = 100;
            this.EnemyRES1.Scroll += new System.EventHandler(this.EnemyRES1_Scroll);
            // 
            // EnemyRES
            // 
            this.EnemyRES.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyRES.Location = new System.Drawing.Point(210, 49);
            this.EnemyRES.MaxLength = 8;
            this.EnemyRES.Name = "EnemyRES";
            this.EnemyRES.Size = new System.Drawing.Size(67, 32);
            this.EnemyRES.TabIndex = 7;
            this.EnemyRES.Text = "10";
            this.EnemyRES.TextChanged += new System.EventHandler(this.EnemyRES_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(22, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(289, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "敌人相应属性抗性               %";
            // 
            // DEF
            // 
            this.DEF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DEF.BackColor = System.Drawing.SystemColors.Control;
            this.DEF.Controls.Add(this.Defense1);
            this.DEF.Controls.Add(this.LVL_E);
            this.DEF.Controls.Add(this.Defense);
            this.DEF.Controls.Add(this.EnemyLevel1);
            this.DEF.Controls.Add(this.DEF_Text);
            this.DEF.Controls.Add(this.EnemyLevel);
            this.DEF.Controls.Add(this.LVL_P);
            this.DEF.Controls.Add(this.PlayerLevel1);
            this.DEF.Controls.Add(this.PlayerLevel);
            this.DEF.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DEF.Location = new System.Drawing.Point(6, 6);
            this.DEF.Name = "DEF";
            this.DEF.Size = new System.Drawing.Size(900, 200);
            this.DEF.TabIndex = 13;
            this.DEF.TabStop = false;
            this.DEF.Text = "防御计算";
            // 
            // Defense1
            // 
            this.Defense1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Defense1.BackColor = System.Drawing.SystemColors.Control;
            this.Defense1.LargeChange = 10;
            this.Defense1.Location = new System.Drawing.Point(304, 148);
            this.Defense1.Maximum = 2000;
            this.Defense1.Name = "Defense1";
            this.Defense1.Size = new System.Drawing.Size(566, 45);
            this.Defense1.SmallChange = 10;
            this.Defense1.TabIndex = 6;
            this.Defense1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Defense1.Value = 1000;
            this.Defense1.Scroll += new System.EventHandler(this.Defense1_Scroll);
            // 
            // LVL_E
            // 
            this.LVL_E.AutoSize = true;
            this.LVL_E.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LVL_E.Location = new System.Drawing.Point(22, 90);
            this.LVL_E.Name = "LVL_E";
            this.LVL_E.Size = new System.Drawing.Size(96, 28);
            this.LVL_E.TabIndex = 18;
            this.LVL_E.Text = "敌方等级";
            // 
            // Defense
            // 
            this.Defense.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Defense.Location = new System.Drawing.Point(210, 148);
            this.Defense.MaxLength = 8;
            this.Defense.Name = "Defense";
            this.Defense.Size = new System.Drawing.Size(67, 32);
            this.Defense.TabIndex = 5;
            this.Defense.Text = "0";
            this.Defense.TextChanged += new System.EventHandler(this.Defense_TextChanged);
            // 
            // EnemyLevel1
            // 
            this.EnemyLevel1.AllowDrop = true;
            this.EnemyLevel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnemyLevel1.BackColor = System.Drawing.SystemColors.Control;
            this.EnemyLevel1.LargeChange = 1;
            this.EnemyLevel1.Location = new System.Drawing.Point(304, 90);
            this.EnemyLevel1.Maximum = 110;
            this.EnemyLevel1.Minimum = 1;
            this.EnemyLevel1.Name = "EnemyLevel1";
            this.EnemyLevel1.Size = new System.Drawing.Size(566, 45);
            this.EnemyLevel1.TabIndex = 4;
            this.EnemyLevel1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.EnemyLevel1.Value = 1;
            this.EnemyLevel1.Scroll += new System.EventHandler(this.EnemyLevel1_Scroll);
            // 
            // DEF_Text
            // 
            this.DEF_Text.AutoSize = true;
            this.DEF_Text.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DEF_Text.Location = new System.Drawing.Point(22, 148);
            this.DEF_Text.Name = "DEF_Text";
            this.DEF_Text.Size = new System.Drawing.Size(289, 28);
            this.DEF_Text.TabIndex = 14;
            this.DEF_Text.Text = "敌人防御值变化           字    %";
            // 
            // EnemyLevel
            // 
            this.EnemyLevel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyLevel.Location = new System.Drawing.Point(210, 90);
            this.EnemyLevel.MaxLength = 8;
            this.EnemyLevel.Name = "EnemyLevel";
            this.EnemyLevel.Size = new System.Drawing.Size(86, 32);
            this.EnemyLevel.TabIndex = 3;
            this.EnemyLevel.Text = "1";
            this.EnemyLevel.TextChanged += new System.EventHandler(this.EnemyLevel_TextChanged);
            // 
            // LVL_P
            // 
            this.LVL_P.AutoSize = true;
            this.LVL_P.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LVL_P.Location = new System.Drawing.Point(22, 34);
            this.LVL_P.Name = "LVL_P";
            this.LVL_P.Size = new System.Drawing.Size(96, 28);
            this.LVL_P.TabIndex = 6;
            this.LVL_P.Text = "我方等级";
            // 
            // PlayerLevel1
            // 
            this.PlayerLevel1.AllowDrop = true;
            this.PlayerLevel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerLevel1.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerLevel1.LargeChange = 1;
            this.PlayerLevel1.Location = new System.Drawing.Point(304, 34);
            this.PlayerLevel1.Maximum = 90;
            this.PlayerLevel1.Minimum = 1;
            this.PlayerLevel1.Name = "PlayerLevel1";
            this.PlayerLevel1.Size = new System.Drawing.Size(566, 45);
            this.PlayerLevel1.TabIndex = 2;
            this.PlayerLevel1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.PlayerLevel1.Value = 1;
            this.PlayerLevel1.Scroll += new System.EventHandler(this.PlayerLevel1_Scroll);
            // 
            // PlayerLevel
            // 
            this.PlayerLevel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLevel.Location = new System.Drawing.Point(210, 34);
            this.PlayerLevel.MaxLength = 8;
            this.PlayerLevel.Name = "PlayerLevel";
            this.PlayerLevel.Size = new System.Drawing.Size(86, 32);
            this.PlayerLevel.TabIndex = 1;
            this.PlayerLevel.Text = "1";
            this.PlayerLevel.TextChanged += new System.EventHandler(this.PlayerLevel_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(912, 333);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "伤害加深";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.ReactBuff1);
            this.groupBox3.Controls.Add(this.ReactBuff);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(6, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(900, 88);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "反应伤害增强";
            // 
            // ReactBuff1
            // 
            this.ReactBuff1.AllowDrop = true;
            this.ReactBuff1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReactBuff1.BackColor = System.Drawing.SystemColors.Control;
            this.ReactBuff1.Location = new System.Drawing.Point(304, 34);
            this.ReactBuff1.Maximum = 1000;
            this.ReactBuff1.Name = "ReactBuff1";
            this.ReactBuff1.Size = new System.Drawing.Size(566, 45);
            this.ReactBuff1.TabIndex = 21;
            this.ReactBuff1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ReactBuff1.Scroll += new System.EventHandler(this.ReactBuff1_Scroll);
            // 
            // ReactBuff
            // 
            this.ReactBuff.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReactBuff.Location = new System.Drawing.Point(200, 34);
            this.ReactBuff.MaxLength = 8;
            this.ReactBuff.Name = "ReactBuff";
            this.ReactBuff.Size = new System.Drawing.Size(77, 32);
            this.ReactBuff.TabIndex = 20;
            this.ReactBuff.Text = "0";
            this.ReactBuff.TextChanged += new System.EventHandler(this.ReactBuff_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(22, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(286, 28);
            this.label9.TabIndex = 19;
            this.label9.Text = "反应提升百分比                  %";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DMGBuff1_Sf);
            this.groupBox1.Controls.Add(this.DMGBuff_Sf);
            this.groupBox1.Controls.Add(this.DMGBuff1_S);
            this.groupBox1.Controls.Add(this.DMGBuff_S);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(6, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 145);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "可叠加的伤害buff";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(22, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "叠加的层数";
            // 
            // DMGBuff1_Sf
            // 
            this.DMGBuff1_Sf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DMGBuff1_Sf.BackColor = System.Drawing.SystemColors.Control;
            this.DMGBuff1_Sf.LargeChange = 2;
            this.DMGBuff1_Sf.Location = new System.Drawing.Point(342, 97);
            this.DMGBuff1_Sf.Maximum = 30;
            this.DMGBuff1_Sf.Name = "DMGBuff1_Sf";
            this.DMGBuff1_Sf.Size = new System.Drawing.Size(528, 45);
            this.DMGBuff1_Sf.TabIndex = 13;
            this.DMGBuff1_Sf.Scroll += new System.EventHandler(this.DMGBuff1_Sf_Scroll);
            // 
            // DMGBuff_Sf
            // 
            this.DMGBuff_Sf.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DMGBuff_Sf.Location = new System.Drawing.Point(250, 93);
            this.DMGBuff_Sf.MaxLength = 8;
            this.DMGBuff_Sf.Name = "DMGBuff_Sf";
            this.DMGBuff_Sf.Size = new System.Drawing.Size(67, 32);
            this.DMGBuff_Sf.TabIndex = 12;
            this.DMGBuff_Sf.Text = "0";
            this.DMGBuff_Sf.TextChanged += new System.EventHandler(this.DMGBuff_Sf_TextChanged);
            // 
            // DMGBuff1_S
            // 
            this.DMGBuff1_S.AllowDrop = true;
            this.DMGBuff1_S.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DMGBuff1_S.BackColor = System.Drawing.SystemColors.Control;
            this.DMGBuff1_S.LargeChange = 0;
            this.DMGBuff1_S.Location = new System.Drawing.Point(342, 43);
            this.DMGBuff1_S.Maximum = 1000;
            this.DMGBuff1_S.Name = "DMGBuff1_S";
            this.DMGBuff1_S.Size = new System.Drawing.Size(528, 45);
            this.DMGBuff1_S.TabIndex = 11;
            this.DMGBuff1_S.TickStyle = System.Windows.Forms.TickStyle.None;
            this.DMGBuff1_S.Scroll += new System.EventHandler(this.DMGBuff1_S_Scroll);
            // 
            // DMGBuff_S
            // 
            this.DMGBuff_S.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DMGBuff_S.Location = new System.Drawing.Point(250, 43);
            this.DMGBuff_S.MaxLength = 8;
            this.DMGBuff_S.Name = "DMGBuff_S";
            this.DMGBuff_S.Size = new System.Drawing.Size(67, 32);
            this.DMGBuff_S.TabIndex = 10;
            this.DMGBuff_S.Text = "0";
            this.DMGBuff_S.TextChanged += new System.EventHandler(this.DMGBuff_S_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(22, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "每层叠加的增伤百分比              %";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.DMGBuff1);
            this.groupBox2.Controls.Add(this.DMGBuff);
            this.groupBox2.Controls.Add(this.DMG_Buff);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(900, 82);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "常驻伤害buff";
            // 
            // DMGBuff1
            // 
            this.DMGBuff1.AllowDrop = true;
            this.DMGBuff1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DMGBuff1.BackColor = System.Drawing.SystemColors.Control;
            this.DMGBuff1.LargeChange = 0;
            this.DMGBuff1.Location = new System.Drawing.Point(304, 34);
            this.DMGBuff1.Maximum = 1000;
            this.DMGBuff1.Name = "DMGBuff1";
            this.DMGBuff1.Size = new System.Drawing.Size(566, 45);
            this.DMGBuff1.TabIndex = 2;
            this.DMGBuff1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.DMGBuff1.Scroll += new System.EventHandler(this.DMGBuff1_Scroll);
            // 
            // DMGBuff
            // 
            this.DMGBuff.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DMGBuff.Location = new System.Drawing.Point(200, 34);
            this.DMGBuff.MaxLength = 8;
            this.DMGBuff.Name = "DMGBuff";
            this.DMGBuff.Size = new System.Drawing.Size(77, 32);
            this.DMGBuff.TabIndex = 1;
            this.DMGBuff.Text = "0";
            this.DMGBuff.TextChanged += new System.EventHandler(this.DMGBuff_TextChanged);
            // 
            // DMG_Buff
            // 
            this.DMG_Buff.AutoSize = true;
            this.DMG_Buff.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DMG_Buff.Location = new System.Drawing.Point(22, 34);
            this.DMG_Buff.Name = "DMG_Buff";
            this.DMG_Buff.Size = new System.Drawing.Size(286, 28);
            this.DMG_Buff.TabIndex = 8;
            this.DMG_Buff.Text = "伤害提升百分比                  %";
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
            // Skill1
            // 
            this.Skill1.AllowDrop = true;
            this.Skill1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Skill1.BackColor = System.Drawing.SystemColors.Control;
            this.Skill1.LargeChange = 200;
            this.Skill1.Location = new System.Drawing.Point(326, 406);
            this.Skill1.Maximum = 10000;
            this.Skill1.Name = "Skill1";
            this.Skill1.Size = new System.Drawing.Size(566, 45);
            this.Skill1.TabIndex = 61;
            this.Skill1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Skill1.Value = 1000;
            this.Skill1.Scroll += new System.EventHandler(this.Skill1_Scroll);
            // 
            // Skill
            // 
            this.Skill.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Skill.Location = new System.Drawing.Point(222, 406);
            this.Skill.MaxLength = 8;
            this.Skill.Name = "Skill";
            this.Skill.Size = new System.Drawing.Size(77, 32);
            this.Skill.TabIndex = 60;
            this.Skill.Text = "100";
            this.Skill.TextChanged += new System.EventHandler(this.Skill_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(44, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "天赋倍率                             %";
            // 
            // Other1
            // 
            this.Other1.AllowDrop = true;
            this.Other1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Other1.BackColor = System.Drawing.SystemColors.Control;
            this.Other1.LargeChange = 100;
            this.Other1.Location = new System.Drawing.Point(326, 457);
            this.Other1.Maximum = 5000;
            this.Other1.Minimum = 1000;
            this.Other1.Name = "Other1";
            this.Other1.Size = new System.Drawing.Size(566, 45);
            this.Other1.TabIndex = 63;
            this.Other1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Other1.Value = 1000;
            this.Other1.Scroll += new System.EventHandler(this.Other1_Scroll);
            // 
            // Other
            // 
            this.Other.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Other.Location = new System.Drawing.Point(222, 453);
            this.Other.MaxLength = 8;
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(77, 32);
            this.Other.TabIndex = 62;
            this.Other.Text = "100";
            this.Other.TextChanged += new System.EventHandler(this.Other_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(44, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 28);
            this.label6.TabIndex = 22;
            this.label6.Text = "额外伤害乘区                      %";
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
            this.Reaction_Choose.Size = new System.Drawing.Size(175, 33);
            this.Reaction_Choose.TabIndex = 70;
            this.Reaction_Choose.SelectedIndexChanged += new System.EventHandler(this.Reaction_Choose_SelectedIndexChanged);
            // 
            // Normal_DMG
            // 
            this.Normal_DMG.Font = new System.Drawing.Font("方正像素12", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Normal_DMG.ForeColor = System.Drawing.Color.DarkRed;
            this.Normal_DMG.Location = new System.Drawing.Point(48, 57);
            this.Normal_DMG.Name = "Normal_DMG";
            this.Normal_DMG.Size = new System.Drawing.Size(154, 24);
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
            this.Crit_DMG.Size = new System.Drawing.Size(154, 24);
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
            this.Avg_DMG.Size = new System.Drawing.Size(154, 24);
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
            this.toolStrips.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStrips.Click += new System.EventHandler(this.ToolStrips_Click);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 636);
            this.panel2.TabIndex = 101;
            this.panel2.Visible = false;
            this.panel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.OpenFiles);
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
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 636);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrips);
            this.Controls.Add(this.TransButton);
            this.Controls.Add(this.Other);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Skill1);
            this.Controls.Add(this.Skill);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Other1);
            this.Controls.Add(this.panel2);
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
            ((System.ComponentModel.ISupportInitialize)(this.ATK1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CritRate1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CritDMG1)).EndInit();
            this.Group_A.ResumeLayout(false);
            this.Group_A.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ATKPlus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EM1)).EndInit();
            this.P1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.BUFF_ATK2.ResumeLayout(false);
            this.BUFF_ATK2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ATKBuff1_Sf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATKBuff1_S)).EndInit();
            this.BUFF_ATK_1.ResumeLayout(false);
            this.BUFF_ATK_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ATKBuff1_P)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATKBuff1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.RES.ResumeLayout(false);
            this.RES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyRES1)).EndInit();
            this.DEF.ResumeLayout(false);
            this.DEF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Defense1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyLevel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerLevel1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReactBuff1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DMGBuff1_Sf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DMGBuff1_S)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DMGBuff1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skill1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Other1)).EndInit();
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
        private System.Windows.Forms.TrackBar ATK1;
        private System.Windows.Forms.TextBox ATK;
        private System.Windows.Forms.TextBox CritRate;
        private System.Windows.Forms.TrackBar CritRate1;
        private System.Windows.Forms.Label ATK_Label;
        private System.Windows.Forms.Label CR_Label;
        private System.Windows.Forms.TrackBar CritDMG1;
        private System.Windows.Forms.TextBox CritDMG;
        private System.Windows.Forms.Label CD_Label;
        private System.Windows.Forms.GroupBox Group_A;
        private System.Windows.Forms.TrackBar EM1;
        private System.Windows.Forms.TextBox EM;
        private System.Windows.Forms.Label EM_Label;
        private System.Windows.Forms.TrackBar EP1;
        private System.Windows.Forms.TextBox EP;
        private System.Windows.Forms.Label EP_Label;
        private System.Windows.Forms.TabControl P1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox BUFF_ATK_1;
        private System.Windows.Forms.TrackBar ATKBuff1_P;
        private System.Windows.Forms.Label ATK_Buff_Num;
        private System.Windows.Forms.TrackBar ATKBuff1;
        private System.Windows.Forms.TextBox ATKBuff;
        private System.Windows.Forms.TextBox ATKBuff_P;
        private System.Windows.Forms.Label ATK_Buff_Percent;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox DEF;
        private System.Windows.Forms.Label LVL_E;
        private System.Windows.Forms.TrackBar EnemyLevel1;
        private System.Windows.Forms.TextBox EnemyLevel;
        private System.Windows.Forms.Label LVL_P;
        private System.Windows.Forms.TrackBar PlayerLevel1;
        private System.Windows.Forms.TextBox PlayerLevel;
        private System.Windows.Forms.GroupBox BUFF_ATK2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar ATKBuff1_Sf;
        private System.Windows.Forms.TextBox ATKBuff_Sf;
        private System.Windows.Forms.TrackBar ATKBuff1_S;
        private System.Windows.Forms.TextBox ATKBuff_S;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox RES;
        private System.Windows.Forms.TrackBar EnemyRES1;
        private System.Windows.Forms.TextBox EnemyRES;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar DMGBuff1_Sf;
        private System.Windows.Forms.TextBox DMGBuff_Sf;
        private System.Windows.Forms.TrackBar DMGBuff1_S;
        private System.Windows.Forms.TextBox DMGBuff_S;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar DMGBuff1;
        private System.Windows.Forms.TextBox DMGBuff;
        private System.Windows.Forms.Label DMG_Buff;
        private System.Windows.Forms.ToolStripMenuItem 窗口置顶ToolStripMenuItem;
        private System.Windows.Forms.Label NormalDMG_Text;
        private System.Windows.Forms.Label CritDMG_Text;
        private System.Windows.Forms.Label AvgDMG_Text;
        private System.Windows.Forms.TrackBar Skill1;
        private System.Windows.Forms.TextBox Skill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar Other1;
        private System.Windows.Forms.TextBox Other;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Normal_DMG;
        private System.Windows.Forms.Label Crit_DMG;
        private System.Windows.Forms.Label Avg_DMG;
        private System.Windows.Forms.Label Reaction;
        private System.Windows.Forms.ComboBox Reaction_Choose;
        private System.Windows.Forms.TrackBar ATKPlus1;
        private System.Windows.Forms.TextBox ATKPlus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar Defense1;
        private System.Windows.Forms.TextBox Defense;
        private System.Windows.Forms.Label DEF_Text;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar ReactBuff1;
        private System.Windows.Forms.TextBox ReactBuff;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button TransButton;
        private StatusStrip statusStrips;
        private ToolStripStatusLabel toolStrips;
        private ToolStripMenuItem 工具ToolStripMenuItem;
        private Label ATKBuff_HP;
        private Label ATKBuff_DEF;
        private Label ATKBuff_HP_Label;
        private Label ATKBuff_DEF_Label;
        private Label ATKBuff_other_label;
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
        private Panel panel2;
        private OpenFileDialog OpenFile;
        private SaveFileDialog SaveFile;
        private ToolStripMenuItem Cocogoat圣遗物导入ToolStripMenuItem;
        private ToolStripMenuItem 圣遗物简易比较器ToolStripMenuItem;
    }
}

