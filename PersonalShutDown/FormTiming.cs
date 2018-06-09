using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonalShutDown
{
    public partial class FormTiming : PersonalShutDown.FormFather
    {
        private int countTime;
        public FormTiming()
        {
            InitializeComponent();
            btnCancel.Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbxSec.Text != "")
            {
                restTime = (int.Parse(tbxSec.Text));//设置定时器间隔
                //FormTimer ft = new FormTimer();
                //ft.ShowDialog();
                label1.Visible = false;
                label2.Visible = false;
                tbxSec.Visible = false;
                btnOK.Visible = false;
                label3.Visible = true;
                countTime = restTime;
                label3.Text = "倒计时" + countTime + "秒后关机";
                btnCancel.Visible = true;
                timer1.Enabled = true;
            }
        }

        /// <summary>
        /// 输入时只允许数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxSec_KeyPress(object sender, KeyPressEventArgs e)
        {
            //输入时只允许数字输入
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))//不是数字不让输入
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 设置文本的上下限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxSec_TextChanged(object sender, EventArgs e)
        {
            //设置文本框的上下限值
            int upvar = 3600;//上限值
            int downvar = 1;
            if (tbxSec.Text != null && tbxSec.Text != "")//文本非空才能判断
            {
                if (int.Parse(tbxSec.Text) > upvar)
                {
                    tbxSec.Text = upvar.ToString();
                }
                else if (int.Parse(tbxSec.Text) < downvar)
                {
                    tbxSec.Text = downvar.ToString();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = "倒计时" + countTime + "秒后关机";
            countTime--;
            if(countTime==0)
            {
                label3.Text = "倒计时结束，即将关机！";
                timer1.Enabled = false;
                //ShutDown in normal way
                try
                {
                    System.Diagnostics.Process.Start("shutdown.exe", "-s");
                }
                catch (Win32Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "异常");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(countTime!=0)
            {
                timer1.Enabled = false;
                MessageBox.Show("关机动作已结束！\n单击确定返回主菜单。");
            }
            
        }
    }
}
