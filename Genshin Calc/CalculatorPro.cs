using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genshin_Calc
{
    public partial class CalculatorPro : Form
    {
        public CalculatorPro()
        {
            InitializeComponent();
            DmgType.SelectedIndex = 0;
            AttributeBox.SelectedIndex = 0;
        }
        int atk, element, lv_player, lv_enemy, react;
        double critrate, critdmg, dmgbuff, skill, indi, res, def, rebuff, dmg;
        double rp, rt,rx, defence, critornot = 1;
        private void CalculatorPro_Load(object sender, EventArgs e)
        {

        }
        public void Init()
        {
            AtkValue.Text = Convert.ToString(atk);
            CRValue.Text = Convert.ToString(critrate);
            CDValue.Text = Convert.ToString(critdmg);
            EMValue.Text = Convert.ToString(element);
            DMGBuffValue.Text = Convert.ToString(dmgbuff);
            SkillValue.Text = Convert.ToString(skill);
            IndiValue.Text = Convert.ToString(indi);
            PlayerLevelValue.Text = Convert.ToString(lv_player);
            EnemyLevelValue.Text = Convert.ToString(lv_enemy);
            EnemyRESValue.Text = Convert.ToString(res);
            EnemyDEFValue.Text = Convert.ToString(def);
            ReactBox.SelectedIndex = react;
            ReactBuffValue.Text = Convert.ToString(rebuff);
            DMGExpected.Text = Convert.ToString(dmg);
        }
        //输入所有数据//
        public void Input(int a, double cr, double cd, int em, double db, double sk, double i, int lv_m, int lv_e, double r, double d, int re, double reb)
        {
            atk = a;            //攻击
            lv_player = lv_m;   //我方等级
            lv_enemy = lv_e;    //敌方等级
            element = em;       //元素精通
            critrate = cr;      //暴击率
            critdmg = cd;       //暴击伤害
            dmgbuff = db;       //伤害加成
            skill = sk;         //天赋倍率
            indi = i;           //独立伤害乘区
            res = r;            //敌人抗性
            def = d;            //敌人防御
            react = re;         //反应相关
            rebuff = reb;       //反应增强
            Init();
        }
        private void AtkValue_TextChanged(object sender, EventArgs e)
        {
            try { atk = Convert.ToInt16(AtkValue.Text); } catch (Exception) { }
            UpdateIndex();
        }
        private void CRValue_TextChanged(object sender, EventArgs e)
        {
            try { critrate = Convert.ToDouble(CRValue.Text); } catch (Exception) { }
            UpdateIndex();
        }
        private void CDValue_TextChanged(object sender, EventArgs e)
        {
            try { critdmg = Convert.ToDouble(CDValue.Text); } catch (Exception) { }
            UpdateIndex();
        }
        private void EMValue_TextChanged(object sender, EventArgs e)
        {
            try { element = Convert.ToInt16(EMValue.Text); } catch (Exception) { }
            UpdateIndex();
        }
        private void DMGBuffValue_TextChanged(object sender, EventArgs e)
        {
            try { dmgbuff = Convert.ToDouble(DMGBuffValue.Text); } catch (Exception) { }
            UpdateIndex();
        }
        private void SkillValue_TextChanged(object sender, EventArgs e)
        {
            try { skill = Convert.ToDouble(SkillValue.Text); } catch (Exception) { }
            UpdateIndex();
        }
        private void ReactBuffValue_TextChanged(object sender, EventArgs e)
        {
            try { rebuff = Convert.ToDouble(ReactBuffValue.Text); } catch (Exception) { }
            UpdateIndex();
        }
        private void IndiValue_TextChanged(object sender, EventArgs e)
        {
            try
            { indi = Convert.ToDouble(IndiValue.Text); }
            catch (Exception) { }
            UpdateIndex();
        }
        private void PlayerLevelValue_TextChanged(object sender, EventArgs e)
        {
            try
            { lv_player = Convert.ToInt16(PlayerLevelValue.Text); }
            catch (Exception) { }
            UpdateIndex();
        }
        private void EnemyLevelvalue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lv_enemy = Convert.ToInt16(EnemyLevelValue.Text);
            }
            catch (Exception) { }
            UpdateIndex();
        }
        private void EnemyRESValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                res = Convert.ToDouble(EnemyRESValue.Text);
            }
            catch (Exception) { }
            UpdateIndex();
        }
        private void EnemyDEFValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                def = Convert.ToDouble(EnemyDEFValue.Text);
            }
            catch (Exception) { }
            UpdateIndex();
        }

        public void UpdateIndex()
        {
            try
            {
                dmg = double.Parse(DMGExpected.Text);
            }
            catch (Exception)
            {
                dmg = 0;
            }
            AttributeSelected();

        }//数据的更新操作
        private void DMGExpected_TextChanged(object sender, EventArgs e)
        {
            UpdateIndex();
        }
        //计算//
        public void Calc()
        {
            try
            {
                rt = rx*(1 + ((float)rp / (1 + 1400 / (double)element) + rebuff / 100));
                switch (ReactBox.SelectedIndex)
                {
                    case 0: rp = 0;     rt = 1; break;//无反应
                    case 1: rp = 6.66;  rx = 0.25; break;//超导
                    case 2: rp = 6.66;  rx = 0.3; break;//扩散
                    case 3: rp = 6.66;  rx = 0.6; break;//感电
                    case 4: rp = 6.66;  rx = 0.75; break;//碎冰
                    case 5: rp = 6.66;  rx = 1; break;//超载
                    case 6: rp = 2.78;  rx = 1.5; break;//1.5倍增幅
                    case 7: rp = 2.78;  rx = 2; break;//2.0倍增幅
                    default: ReactBox.SelectedIndex = 0; break;
                }
                
                if (float.Parse(EnemyRESValue.Text) < 0)
                {
                    res = 1 - float.Parse(EnemyRESValue.Text) / 200;
                }
                else if (0 <= float.Parse(EnemyRESValue.Text) && float.Parse(EnemyRESValue.Text) <= 75)
                {
                    res = 1 - float.Parse(EnemyRESValue.Text) / 100;
                }
                else if (75 < float.Parse(EnemyRESValue.Text))
                {
                    res = 1 / (1 + 4 * (float.Parse(EnemyRESValue.Text) / 100));
                }
                defence = (int.Parse(PlayerLevelValue.Text) + 100)//防御计算
                            / (int.Parse(PlayerLevelValue.Text) + 100 + (1 + float.Parse(EnemyDEFValue.Text) / 100)
                            * (int.Parse(EnemyLevelValue.Text) + 100));
            }
            catch (Exception)
            { }
        }
        private void Atkcalc()//攻击计算：已完成
        {
            switch (DmgType.SelectedIndex)
            {
                case 0:
                    Attribute_Text.Text = Convert.ToString(
                (int)
                (dmg / ((1 + dmgbuff / 100) * skill * indi * rt * res * defence * critornot / 10000) + 0.5)
                );
                    break;
                case 1:
                    Attribute_Text.Text = Convert.ToString(
                (int)
                (dmg / ((1 + dmgbuff / 100) * skill * indi * rt * res * defence * critornot / 10000) + 0.5)
                / (1 + critdmg / 100));
                    break;
                case 2:
                    Attribute_Text.Text = Convert.ToString(
                (int)
                (dmg / (((1 + dmgbuff / 100) * skill * indi * rt * res * defence * critornot / 10000 + 0)
                * (critrate * (100 + critdmg) / 10000 + (1 - critrate / 100))) + 0.5));
                    break;
            }
        }
        private void CRcalc()//暴击率计算：已完成
        {
            var temp = (dmg / ((1 + dmgbuff / 100) * skill * atk * indi * rt * res * defence * critornot / 10000
                    * (critdmg / 100)) - 2) * 100;
            switch (DmgType.SelectedIndex)
            {
                case 0:
                    Attribute_Text.Text = "无法通过改变暴击率而改变未暴击的伤害";
                    break;
                case 1:
                    Attribute_Text.Text = "无法通过改变暴击率而改变已暴击的伤害";
                    break;
                case 2:
                    if (temp >= 0 && temp <= 100)
                    {
                        Attribute_Text.Text = Convert.ToString(string.Format("{0:N2}", temp)) + "%";
                    }
                    else
                    {
                        Attribute_Text.Text = "暴击率超出范围\n请指定合适的伤害期望";
                    }
                    break;

                default: DmgType.SelectedIndex = 0; break;
            }
        }
        private void CDcalc()//暴击伤害计算：已完成
        {
            var temp = (dmg / (atk * (1 + dmgbuff / 100) * skill * indi * rt * res * defence * critornot / 10000) - 1) *100;
            switch (DmgType.SelectedIndex)
            {
                case 0:
                    Attribute_Text.Text = "暴击伤害不对未暴击的情况起效";
                    break;
                case 1:
                    Attribute_Text.Text = temp >= 0 ? Convert.ToString(string.Format("{0:N4}", temp)) + "%" : "要求的伤害过低\n请输入更大的伤害值";
                    break;
                case 2:
                    Attribute_Text.Text = temp >= 0 ? Convert.ToString(string.Format("{0:N4}", temp / critrate * 100)) + "%" : "要求的伤害过低\n请输入更大的伤害值";
                    break;
            }
        }
        private void EMcalc()//元素精通计算：已完成
        {
            double temp;
            Calc();
            switch (DmgType.SelectedIndex)
            {
                case 0:
                    temp = dmg / (atk * skill * indi * (1 + dmgbuff / 100) * res * defence * critornot / 10000);
                    break;
                case 1:
                    temp = dmg / (atk * skill * indi * (1 + dmgbuff / 100) * res * defence * critornot / 10000 * (1 + critdmg / 100));
                    break;
                case 2:
                    temp = dmg / (atk * skill * indi * (1 + dmgbuff / 100) * res * defence * critornot / 10000
                    * (critrate * (100 + critdmg) / 10000 + (1 - critrate / 100)));
                    break;
                default:temp = 0; break;
            }
            if (ReactBox.SelectedIndex == 0)
            {
                Attribute_Text.Text = "未触发元素反应时\n元素精通为无效属性";
            }
            else if (ReactBox.SelectedIndex >= 1 && ReactBox.SelectedIndex <= 5)
            {
                Attribute_Text.Text = "暂不支持剧变反应期望计算";
            }
            else if (1400 / (2.78 / (temp / 2 - 1 - rebuff / 100) - 1) > 0)
            {
                Attribute_Text.Text = Convert.ToString((int)(1400 / (2.78 / (temp / 2 - 1 - rebuff / 100) - 1) + 0.5));
            }
            else
            {
                Attribute_Text.Text = "计算结果为负\n需增大伤害需求";
            }

        }
        private void Buffcalc()//伤害乘区计算：已完成
        {
            switch (DmgType.SelectedIndex)
            {
                case 0:
                    Attribute_Text.Text = Convert.ToString(
                        string.Format("{0:N2}",
                100 * (dmg / (atk * skill * indi * rt * res * defence * critornot / 10000) - 1)
                )) + "%";
                    break;
                case 1:
                    Attribute_Text.Text = Convert.ToString(
                        string.Format("{0:N2}", 100 * (
                (dmg / (atk * skill * indi * rt * res * defence * critornot / 10000)
                / (1 + critdmg / 100)) - 1))) + "%";
                    break;
                case 2:
                    Attribute_Text.Text = Convert.ToString(
                        string.Format("{0:N2}",
                100 * (dmg / ((atk * skill * indi * rt * res * defence * critornot / 10000 + 0)
                * (critrate * (100 + critdmg) / 10000 + (1 - critrate / 100))) - 1))) + "%";
                    break;
            }
        }
        private void Skillcalc()//技能倍率计算：已完成
        {
            switch (DmgType.SelectedIndex)
            {
                case 0:
                    Attribute_Text.Text = Convert.ToString(
                string.Format("{0:N2}",
                (dmg / ((1 + dmgbuff / 100) * atk * indi * rt * res * defence * critornot / 10000))
                )) + "%";
                    break;
                case 1:
                    Attribute_Text.Text = Convert.ToString(
                string.Format("{0:N2}",
                (dmg / ((1 + dmgbuff / 100) * atk * indi * rt * res * defence * critornot / 10000))
                / (1 + critdmg / 100))) + "%";
                    break;
                case 2:
                    Attribute_Text.Text = Convert.ToString(
                string.Format("{0:N2}",
                (dmg / (((1 + dmgbuff / 100) * atk * indi * rt * res * defence * critornot / 10000)
                * (critrate * (100 + critdmg) / 10000 + (1 - critrate / 100))) + 0.5))) + "%";
                    break;
            }
        }
        private void Indicalc()//单独的乘区计算：已完成
        {
            switch (DmgType.SelectedIndex)
            {
                case 0:
                    Attribute_Text.Text = Convert.ToString(
                string.Format("{0:N2}",
                (dmg / ((1 + dmgbuff / 100) * atk * skill * rt * res * defence * critornot / 10000))
                )) + "%";
                    break;
                case 1:
                    Attribute_Text.Text = Convert.ToString(
                string.Format("{0:N2}",
                (dmg / ((1 + dmgbuff / 100) * atk * skill * rt * res * defence * critornot / 10000))
                / (1 + critdmg / 100))) + "%";
                    break;
                case 2:
                    Attribute_Text.Text = Convert.ToString(
                string.Format("{0:N2}",
                (dmg / (((1 + dmgbuff / 100) * atk * skill * rt * res * defence * critornot / 10000)
                * (critrate * (100 + critdmg) / 10000 + (1 - critrate / 100))) + 0.5))) + "%";
                    break;
            }
        }
        private void PlayerLVcalc()//我方等级计算：提示用户不可选
        {
            Attribute_Text.Text = "伤害函数并非连续\n暂不支持此项计算";
        }
        private void EnemyLVcalc()//敌方等级计算：提示用户不可选
        {
            Attribute_Text.Text = "伤害函数并非连续\n暂不支持此项计算";
        }
        private void Rescalc()//抗性计算：已完成
        {
            switch (DmgType.SelectedIndex)
            {
                case 0:
                    Attribute_Text.Text = Convert.ToString(
                        string.Format("{0:N2}",
                100 * (1 - dmg / ((1 + dmgbuff / 100) * skill * indi * rt * atk * defence * critornot / 10000))
                )) + "%";
                    break;
                case 1:
                    Attribute_Text.Text = Convert.ToString(
                        string.Format("{0:N2}",
                100 * (1 - dmg / ((1 + dmgbuff / 100) * skill * indi * rt * atk * defence * critornot / 10000) + 0.5)
                / (1 + critdmg / 100))) + "%";
                    break;
                case 2:
                    Attribute_Text.Text = Convert.ToString(
                        string.Format("{0:N2}",
                100 * (1 - dmg / (((1 + dmgbuff / 100) * skill * indi * rt * atk * defence * critornot / 10000 + 0)
                * (critrate * (100 + critdmg) / 10000 + (1 - critrate / 100))) + 0.5))) + "%";
                    break;
            }
        }
        private void Defcalc()//防御计算：已完成
        {
            double defencex;
            switch (DmgType.SelectedIndex)
            {
                case 0:
                    defencex =
                (dmg / ((1 + dmgbuff / 100) * atk * skill * rt * res * indi * critornot / 10000));
                    break;
                case 1:
                    defencex =
                (dmg / ((1 + dmgbuff / 100) * atk * skill * rt * res * indi * critornot / 10000))
                / (1 + critdmg / 100);
                    break;
                case 2:
                    defencex=
                (dmg / (((1 + dmgbuff / 100) * atk * skill * rt * res * indi * critornot / 10000)
                * (critrate * (100 + critdmg) / 10000 + (1 - critrate / 100))) + 0.5);
                    break;
                default:defencex = dmg / ((1 + dmgbuff / 100) * atk * skill * rt * res * indi * critornot / 10000); break;
            }
            Attribute_Text.Text = Convert.ToString(
                string.Format("{0:N2}",
                100 *
                (((lv_player + 100) / defencex - lv_player - 100) / (lv_enemy + 100) - 1)))
                + "%";

        }
        private void ReactTypecalc()//反应类型计算：提示用户不可选
        {
            Attribute_Text.Text = "此项不可参与计算";
        }
        private void ReactBuffcalc()//反应加成计算：暂时搁置
        {
            double tempx = 1 + ((float)rp / (1 + 1400 / (float)element));
            double reacttype=1;
            Calc();
            switch (ReactBox.SelectedIndex)
            {
                case 0: rp = 0;     reacttype = 1; break;//无反应
                case 1: rp = 6.66;  reacttype = 0.25; break;//超导
                case 2: rp = 6.66;  reacttype = 0.3; break;//扩散
                case 3: rp = 6.66;  reacttype = 0.6; break;//感电
                case 4: rp = 6.66;  reacttype = 0.75; break;//碎冰
                case 5: rp = 6.66;  reacttype = 1; break;//超载
                case 6: rp = 2.78;  reacttype = 1.5; break;//1.5倍增幅
                case 7: rp = 2.78;  reacttype = 2; break;//2.0倍增幅
                default: ReactBox.SelectedIndex = 0; break;
            }
            switch (DmgType.SelectedIndex)
            {
                case 0:
                    Attribute_Text.Text = Convert.ToString(
                        string.Format("{0:N2}",
                100*((dmg / ((1 + dmgbuff / 100) * skill * atk * indi * res * defence * critornot / 10000 ))
                /reacttype-tempx))) + "%";
                    break;
                case 1:
                    Attribute_Text.Text = Convert.ToString(
                        string.Format("{0:N2}",
                100 * ((dmg / ((1 + dmgbuff / 100) * skill * atk * indi * res * defence * critornot / 10000 + 0.5))
                / (1 + critdmg / 100) / reacttype - tempx))) + "%";
                    break;
                case 2:
                    Attribute_Text.Text = Convert.ToString(
                        string.Format("{0:N2}",
                100 *( (dmg / (((1 + dmgbuff / 100) * skill * atk * indi * res * defence * critornot / 10000)
                * (critrate * (100 + critdmg) / 10000 + (1 - critrate / 100))) + 0.5) / reacttype - tempx)) )+ "%";
                    break;
            }
        }

        private void ReactBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calc();
            UpdateIndex();
        }
        private void Attribute_SelectedIndexChanged(object sender, EventArgs e)
        {
            AttributeSelected();
        }
        public void AttributeSelected()
        {
            Calc();
            switch (AttributeBox.SelectedIndex)
            {
                case 0: Atkcalc(); break;
                case 1: CRcalc(); break;
                case 2: CDcalc(); break;
                case 3: EMcalc(); break;
                case 4: Buffcalc(); break;
                case 5: Skillcalc(); break;
                case 6: Indicalc(); break;
                case 7: PlayerLVcalc(); break;
                case 8: EnemyLVcalc(); break;
                case 9: Rescalc(); break;
                case 10: Defcalc(); break;
                case 11: ReactTypecalc(); break;
                case 12: ReactBuffcalc(); break;
                default: Attribute_Text.Text = "请在左侧列表中选择需要计算的项目"; break;
            }
        }
        private void DmgType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateIndex();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
