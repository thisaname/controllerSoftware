namespace ControllerSoftware
{
    partial class CalibrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalibrationForm));
            this.blankCalibGroupBox = new CCWin.SkinControl.SkinGroupBox();
            this.standardClaibrateGroupBox = new CCWin.SkinControl.SkinGroupBox();
            this.standardCalibrateButton = new CCWin.SkinControl.SkinButton();
            this.blankCalibrateButton = new CCWin.SkinControl.SkinButton();
            this.closeCalibrationFormButton = new CCWin.SkinControl.SkinButton();
            this.standardValueUintLable = new CCWin.SkinControl.SkinLabel();
            this.standardValueTextBox = new System.Windows.Forms.TextBox();
            this.blankCalibGroupBox.SuspendLayout();
            this.standardClaibrateGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // blankCalibGroupBox
            // 
            this.blankCalibGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.blankCalibGroupBox.BorderColor = System.Drawing.Color.White;
            this.blankCalibGroupBox.Controls.Add(this.blankCalibrateButton);
            this.blankCalibGroupBox.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blankCalibGroupBox.ForeColor = System.Drawing.Color.Blue;
            this.blankCalibGroupBox.Location = new System.Drawing.Point(11, 54);
            this.blankCalibGroupBox.Name = "blankCalibGroupBox";
            this.blankCalibGroupBox.RectBackColor = System.Drawing.Color.White;
            this.blankCalibGroupBox.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.blankCalibGroupBox.Size = new System.Drawing.Size(448, 117);
            this.blankCalibGroupBox.TabIndex = 6;
            this.blankCalibGroupBox.TabStop = false;
            this.blankCalibGroupBox.Text = "Blank Calibration";
            this.blankCalibGroupBox.TitleBorderColor = System.Drawing.Color.Black;
            this.blankCalibGroupBox.TitleRectBackColor = System.Drawing.Color.White;
            this.blankCalibGroupBox.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // standardClaibrateGroupBox
            // 
            this.standardClaibrateGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.standardClaibrateGroupBox.BorderColor = System.Drawing.Color.White;
            this.standardClaibrateGroupBox.Controls.Add(this.standardValueTextBox);
            this.standardClaibrateGroupBox.Controls.Add(this.standardValueUintLable);
            this.standardClaibrateGroupBox.Controls.Add(this.standardCalibrateButton);
            this.standardClaibrateGroupBox.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardClaibrateGroupBox.ForeColor = System.Drawing.Color.Blue;
            this.standardClaibrateGroupBox.Location = new System.Drawing.Point(11, 195);
            this.standardClaibrateGroupBox.Name = "standardClaibrateGroupBox";
            this.standardClaibrateGroupBox.RectBackColor = System.Drawing.Color.White;
            this.standardClaibrateGroupBox.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.standardClaibrateGroupBox.Size = new System.Drawing.Size(448, 117);
            this.standardClaibrateGroupBox.TabIndex = 7;
            this.standardClaibrateGroupBox.TabStop = false;
            this.standardClaibrateGroupBox.Text = "Standard Soultion Caliration";
            this.standardClaibrateGroupBox.TitleBorderColor = System.Drawing.Color.BlueViolet;
            this.standardClaibrateGroupBox.TitleRectBackColor = System.Drawing.Color.White;
            this.standardClaibrateGroupBox.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // standardCalibrateButton
            // 
            this.standardCalibrateButton.BackColor = System.Drawing.Color.Transparent;
            this.standardCalibrateButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.standardCalibrateButton.DownBack = null;
            this.standardCalibrateButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardCalibrateButton.IsDrawGlass = false;
            this.standardCalibrateButton.Location = new System.Drawing.Point(294, 24);
            this.standardCalibrateButton.MouseBack = null;
            this.standardCalibrateButton.MouseBaseColor = System.Drawing.Color.Empty;
            this.standardCalibrateButton.Name = "standardCalibrateButton";
            this.standardCalibrateButton.NormlBack = null;
            this.standardCalibrateButton.Size = new System.Drawing.Size(147, 80);
            this.standardCalibrateButton.TabIndex = 7;
            this.standardCalibrateButton.Text = "Calibrate";
            this.standardCalibrateButton.UseVisualStyleBackColor = false;
            this.standardCalibrateButton.Click += new System.EventHandler(this.standardCalibrateButton_Click);
            // 
            // blankCalibrateButton
            // 
            this.blankCalibrateButton.BackColor = System.Drawing.Color.Transparent;
            this.blankCalibrateButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.blankCalibrateButton.DownBack = null;
            this.blankCalibrateButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blankCalibrateButton.IsDrawGlass = false;
            this.blankCalibrateButton.Location = new System.Drawing.Point(6, 27);
            this.blankCalibrateButton.MouseBack = null;
            this.blankCalibrateButton.MouseBaseColor = System.Drawing.Color.Empty;
            this.blankCalibrateButton.Name = "blankCalibrateButton";
            this.blankCalibrateButton.NormlBack = null;
            this.blankCalibrateButton.Size = new System.Drawing.Size(436, 80);
            this.blankCalibrateButton.TabIndex = 7;
            this.blankCalibrateButton.Text = "Blank";
            this.blankCalibrateButton.UseVisualStyleBackColor = false;
            this.blankCalibrateButton.Click += new System.EventHandler(this.blankCalibrateButton_Click);
            // 
            // closeCalibrationFormButton
            // 
            this.closeCalibrationFormButton.BackColor = System.Drawing.Color.Transparent;
            this.closeCalibrationFormButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.closeCalibrationFormButton.DownBack = null;
            this.closeCalibrationFormButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeCalibrationFormButton.IsDrawGlass = false;
            this.closeCalibrationFormButton.Location = new System.Drawing.Point(11, 327);
            this.closeCalibrationFormButton.MouseBack = null;
            this.closeCalibrationFormButton.MouseBaseColor = System.Drawing.Color.Empty;
            this.closeCalibrationFormButton.Name = "closeCalibrationFormButton";
            this.closeCalibrationFormButton.NormlBack = null;
            this.closeCalibrationFormButton.Size = new System.Drawing.Size(449, 80);
            this.closeCalibrationFormButton.TabIndex = 8;
            this.closeCalibrationFormButton.Text = "Close";
            this.closeCalibrationFormButton.UseVisualStyleBackColor = false;
            this.closeCalibrationFormButton.Click += new System.EventHandler(this.closeCalibrationFormButton_Click);
            // 
            // standardValueUintLable
            // 
            this.standardValueUintLable.AutoSize = true;
            this.standardValueUintLable.BackColor = System.Drawing.Color.Transparent;
            this.standardValueUintLable.BorderColor = System.Drawing.Color.White;
            this.standardValueUintLable.Font = new System.Drawing.Font("Arial", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardValueUintLable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.standardValueUintLable.Location = new System.Drawing.Point(168, 40);
            this.standardValueUintLable.Name = "standardValueUintLable";
            this.standardValueUintLable.Size = new System.Drawing.Size(100, 49);
            this.standardValueUintLable.TabIndex = 9;
            this.standardValueUintLable.Text = "ppb";
            // 
            // standardValueTextBox
            // 
            this.standardValueTextBox.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardValueTextBox.ForeColor = System.Drawing.Color.Blue;
            this.standardValueTextBox.Location = new System.Drawing.Point(6, 42);
            this.standardValueTextBox.Name = "standardValueTextBox";
            this.standardValueTextBox.Size = new System.Drawing.Size(156, 50);
            this.standardValueTextBox.TabIndex = 10;
            this.standardValueTextBox.Text = "100";
            this.standardValueTextBox.Click += new System.EventHandler(this.standardValueTextBox_Click);
            this.standardValueTextBox.MouseEnter += new System.EventHandler(this.standardValueTextBox_MouseEnter);
            // 
            // CalibrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 429);
            this.Controls.Add(this.closeCalibrationFormButton);
            this.Controls.Add(this.standardClaibrateGroupBox);
            this.Controls.Add(this.blankCalibGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalibrationForm";
            this.Text = "Calibration";
            this.Load += new System.EventHandler(this.CalibrationForm_Load);
            this.blankCalibGroupBox.ResumeLayout(false);
            this.standardClaibrateGroupBox.ResumeLayout(false);
            this.standardClaibrateGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinGroupBox blankCalibGroupBox;
        private CCWin.SkinControl.SkinButton blankCalibrateButton;
        private CCWin.SkinControl.SkinGroupBox standardClaibrateGroupBox;
        private CCWin.SkinControl.SkinButton standardCalibrateButton;
        private CCWin.SkinControl.SkinButton closeCalibrationFormButton;
        private CCWin.SkinControl.SkinLabel standardValueUintLable;
        private System.Windows.Forms.TextBox standardValueTextBox;
    }
}