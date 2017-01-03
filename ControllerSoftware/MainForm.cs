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
    public partial class MainForm : Skin_VS
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void setupButton_Click(object sender, EventArgs e)
        {
            SetupForm setupForm = new SetupForm();
            setupForm.ShowDialog();
        }

        KeyPadOnScreen softKeyPad = new KeyPadOnScreen();
        private void calibButton_Click(object sender, EventArgs e)
        {
            CalibrationForm calibForm = new CalibrationForm();
            calibForm.ShowDialog();

        }

        private void historyDataViewButton_Click(object sender, EventArgs e)
        {
            HistoryDataViewForm historyDataView = new HistoryDataViewForm();
            historyDataView.ShowDialog();

        }

        private void diagnosisButton_Click(object sender, EventArgs e)
        {

        }

        private void dataExportButton_Click(object sender, EventArgs e)
        {

        }

        private void productNameLable_Click(object sender, EventArgs e)
        {

        }

        private void upperLimitValueLable_Click(object sender, EventArgs e)
        {

        }

        private void lowerLimitValueLable_Click(object sender, EventArgs e)
        {

        }

        private void autoManulSwitchButton_Click(object sender, EventArgs e)
        {

        }

        private void setPumbOnButton_Click(object sender, EventArgs e)
        {

        }

        private void setPumbOffButton_Click(object sender, EventArgs e)
        {

        }
    }
}
