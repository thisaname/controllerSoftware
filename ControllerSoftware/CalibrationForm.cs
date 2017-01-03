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
    public partial class CalibrationForm : Skin_VS
    {
        public CalibrationForm()
        {
            InitializeComponent();
        }

        private void CalibrationForm_Load(object sender, EventArgs e)
        {
            
        }

        private void blankCalibrateButton_Click(object sender, EventArgs e)
        {

        }

        private void standardCalibrateButton_Click(object sender, EventArgs e)
        {

        }

        private void closeCalibrationFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void standardValueTextBox_MouseEnter(object sender, EventArgs e)
        {
            KeyPadOnScreen keypad = new KeyPadOnScreen();
            keypad.Show();
        }

        private void standardValueTextBox_Click(object sender, EventArgs e)
        {
            
        }
    }
}
