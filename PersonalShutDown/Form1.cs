using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using System.IO;

namespace PersonalShutDown
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 单击普通关机，StD意为ShutDown，关机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNormalStD_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("确认要关机？", "普通关机", MessageBoxButtons.OKCancel)) == DialogResult.OK)
            {
                //ShutDown in normal way
                try
                {
                    System.Diagnostics.Process.Start("shutdown.exe", "-s");
                }
                catch(Win32Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "异常");
                }
            }
            else
            {
                MessageBox.Show("关机动作已取消","提示");
            }
        }
       
        /// <summary>
        /// 单击滑动关机，采用快捷方式启动的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSlideToStD_Click(object sender, EventArgs e)
        {
            //无法使用Process.Start打开SlideToShutdown文件,权限不足
            //System.Diagnostics.Process.Start("SlideToShutdown.exe");
            //为了学习快捷方式的创建和使用，使用快捷方式启动滑动关机的方法
            string strcurrent = Environment.CurrentDirectory;
            string strsys = Environment.SystemDirectory;
            //创建滑动开机的快捷方式，如果存在则不创建
            Createlnk(strcurrent, "STSD", strsys + "\\SlideToShutDown.exe", "滑动关机", null);
            try
            {
                //打开该快捷方式，需要权限
                System.Diagnostics.Process.Start(strcurrent + "\\STSD.lnk");
            }
            catch (Win32Exception ex)
            {
                string str = ex.ToString();
                string str1 = "该操作已被系统取消，权限不足，请尝试其他关机方案。";
                string str2 = "\n若非要滑动关机，请单击程序外的“STSD.lnk”快捷方式。";
                MessageBox.Show(str1+str2, "异常信息！");
            }
        }

        /// <summary>
        /// 单击启动定时关机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimerStD_Click(object sender, EventArgs e)
        {
            FormTiming ftiming = new FormTiming();
            ftiming.ShowDialog();
        }

        /// <summary>
        /// 单击退出，并删除快捷方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            string strCurrent = Environment.CurrentDirectory;
            //此处可以删除多余快捷方式
            Environment.Exit(0);
        }

        private void LinkLabelAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String URL = "https://github.com/wanglida";
            System.Diagnostics.Process.Start(URL);
        }


        /// <summary>
        /// 该方法用于创建快捷方式。
        /// 需要引入IWshRuntimeLibrary(using IWshRuntimeLibrary)和System.IO，
        /// 打开添加引用，在COM中搜索Windows Script Host Object Model
        /// </summary>
        /// <param name="directory">快捷方式的文件目录</param>
        /// <param name="lnkName">快捷方式的文件名称</param>
        /// <param name="targetPath">目标路径</param>
        /// <param name="description">描述</param>
        /// <param name="iconLocation">ico图标的文件路径，格式：可执行文件或DLL路径，图标编号。
        /// 例如System.Environment.SystemDirectory + "\\" + "shell32.dll, 165"</param>
        public static void Createlnk(string directory, string lnkName, string targetPath, string description = null, string iconLocation = null)
        {
            if (Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);//在制定位置创建新目录（新文件夹）
            }
            string lnkPath = Path.Combine(directory, string.Format("{0}.lnk", lnkName));
            WshShell shell = new WshShell();
            IWshShortcut lnk = (IWshShortcut)shell.CreateShortcut(lnkPath);//创建快捷方式对象
            lnk.TargetPath = targetPath;//设置目标路径
            lnk.WorkingDirectory = Path.GetDirectoryName(targetPath);//设置起始位置
            lnk.WindowStyle = 1;//设置运行方式，默认为常规窗口
            lnk.Description = description;//添加备注
            lnk.IconLocation = string.IsNullOrWhiteSpace(iconLocation) ? targetPath : iconLocation;//设置图标路径
            lnk.Save();
        }

    }
}
