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
    public partial class ValueTracker : UserControl
    {
        public ValueTracker()
        {
            InitializeComponent();
            Bar.ValueChanged += new EventHandler(ValueChanged);
            Value.TextChanged += new EventHandler(ValueChanged);
        }
        public bool PercentShown = false;
        public string[] Attributes = new string[7];
        /// <summary>
        /// 数据条的缩放倍数
        /// </summary>
        private double BarScale = 1;
        /// <summary>
        /// 改变文字的处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Value_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Bar.Value = Convert.ToInt32(float.Parse(Value.Text) * BarScale);
            }
            catch (FormatException)                     // 格式错误(通常为没输入完造成) 
            {
                if (Value.Text == "")                   // 清空了输入框时设为默认值
                {
                    Bar.Value = Bar.Minimum;
                }
            }
            catch (Exception)
            {
            }
        }
        /// <summary>
        /// 拖动数值条的处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bar_Scroll(object sender, EventArgs e)
        {
            try
            {
                Value.Text = ((float)Bar.Value / BarScale).ToString();
            }
            catch
            {
                // DoNothing;
            }
        }
        private void ValueChangeFX_Timer_Tick(object sender, EventArgs e)
        {
            // 当前值: Bar.Value
            // 要移动到的值: Convert.ToInt32(float.Parse(Value.Text) * BarScale)
            // 后者减前者, 若为正则右移, 反之左移, 结果为移动的距离
            //Bar.Value += (Convert.ToInt32(float.Parse(Value.Text) * BarScale) - Bar.Value)/10;
            //if (Math.Abs(Convert.ToInt32(float.Parse(Value.Text) * BarScale) - Bar.Value) < 2)
            //{
            ValueChangeFX_Timer.Stop();
            //}

        }
        private void FocusLost(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Value.Text))
            {
                Value.Text = CurrentStr;
            }
        }
        public delegate void ValueSettingsDelegate(object sender, EventArgs e);
        /// <summary>
        /// 更改其中数据时引发事件
        /// </summary>
        public event ValueSettingsDelegate ValueChange;
        public void ValueChanged(object sender, EventArgs e)
        {
            if (Value.Focused)
            {
                //加个炫酷的过渡动画
                // ValueChangeFX_Timer.Start();
            }
            ValueChange?.Invoke(sender, e);
        }
        /// <summary>
        /// 加载窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrackerLoad(object sender, EventArgs e)
        {
            Current = Convert.ToInt32(float.Parse(CurrentStr) * BarScale);
        }
        #region 各项属性的设置
        /// <summary>
        /// 数值条的标题
        /// </summary>
        [Description("数值条的标题。"), Category("自定义属性")]
        public string Title
        {
            get => ValueLabel.Text;
            set
            {
                ValueLabel.Text = value;
                Invalidate();
            }
        }
        [Description("选择是否显示百分比符号。\n需重启设计器才会生效。"), Category("自定义属性")]
        public bool PercentShownOrNot
        {
            get => PercentShown;
            set
            {
                PercentShown = value;
                if (!value)
                {
                    PercentSign.Dispose();
                    LayoutGrid.ColumnStyles[1].Width += LayoutGrid.ColumnStyles[2].Width;
                    LayoutGrid.ColumnStyles[2].Width = 0;
                }
                else
                {
                }
                Invalidate();
            }

        }
        /// <summary>
        /// 数值条的最小值
        /// </summary>
        [Description("数值条的最小值。\n(调节的最小值*放大倍数)"), Category("自定义属性")]
        public int Minimum
        {
            get => Bar.Minimum;
            set
            {
                Bar.Minimum = value;
                Invalidate();
            }
        }
        /// <summary>
        /// 数值条的最大值(调节的最大值*放大倍数)
        /// </summary>
        [Description("数值条的最大值。\n(调节的最大值*放大倍数)"), Category("自定义属性")]
        public int Maximum
        {
            get => Bar.Maximum;
            set
            {
                Bar.Maximum = value;
                Invalidate();
            }
        }
        [Description("数值条的当前值。"), Category("自定义属性")]
        public float Current
        {
            get => Bar.Value;
            set
            {
                Bar.Value = (int)value;
                Invalidate();
            }
        }
        [Description("数值条的缩放级别。"), Category("自定义属性")]
        public double ValScale
        {
            get => BarScale;
            set
            {
                BarScale = value;
                Invalidate();
            }
        }
        [Description("数值条的当前值(转换为文本)。"), Category("自定义属性"), Browsable(false)]
        public string CurrentStr
        {
            get => Value.Text;
            set
            {
                Value.Text = value;
                Invalidate();
            }
        }

        #endregion
    }
}
