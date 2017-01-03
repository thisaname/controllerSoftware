using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;

namespace ControllerSoftware
{
    public partial class SetupForm : Skin_VS
    {
        public SetupForm()
        {
            InitializeComponent();
        }

        private void SetupForm_Load(object sender, EventArgs e)
        {

        }

        private void setChineseButton_Click(object sender, EventArgs e)
        {
            setChineseButton.BaseColor = Color.FromArgb(9, 163, 220);
            setEnglishButton.BaseColor = Color.Gray;
        }

        private void setEnglishButton_Click(object sender, EventArgs e)
        {
            setEnglishButton.BaseColor = Color.FromArgb(9, 163, 220);
            setChineseButton.BaseColor = Color.Gray;
        }
    }
}
