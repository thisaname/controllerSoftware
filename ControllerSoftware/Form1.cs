using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
namespace ControllerSoftware
{
    public partial class mainForm : Skin_VS
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Move(object sender, EventArgs e)
        {
            this.Location= new Point(0, 0); //禁止窗口被移动
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;//禁止窗口被关闭
        }
    }
}
