namespace ControllerSoftware
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.chartGroupBox = new CCWin.SkinControl.SkinGroupBox();
            this.dataViewChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.measurementGroupBox = new CCWin.SkinControl.SkinGroupBox();
            this.productValueLable = new CCWin.SkinControl.SkinLabel();
            this.productNameLable = new CCWin.SkinControl.SkinLabel();
            this.setupButton = new CCWin.SkinControl.SkinButton();
            this.controlGroupBox = new CCWin.SkinControl.SkinGroupBox();
            this.setPumbOnButton = new CCWin.SkinControl.SkinButton();
            this.setPumbOffButton = new CCWin.SkinControl.SkinButton();
            this.autoManulSwitchButton = new CCWin.SkinControl.SkinButton();
            this.lowerLimitValueLable = new CCWin.SkinControl.SkinLabel();
            this.upperLimitValueLable = new CCWin.SkinControl.SkinLabel();
            this.lowerLimitLable = new CCWin.SkinControl.SkinLabel();
            this.upperLimitLable = new CCWin.SkinControl.SkinLabel();
            this.statusGroupBox = new CCWin.SkinControl.SkinGroupBox();
            this.flowStatusLable = new CCWin.SkinControl.SkinLabel();
            this.pumbStatusLable = new CCWin.SkinControl.SkinLabel();
            this.controlStatusLable = new CCWin.SkinControl.SkinLabel();
            this.flowStatusPicBox = new System.Windows.Forms.PictureBox();
            this.pumbStatusPicBox = new System.Windows.Forms.PictureBox();
            this.controlStatusPicBox = new System.Windows.Forms.PictureBox();
            this.calibButton = new CCWin.SkinControl.SkinButton();
            this.historyDataViewButton = new CCWin.SkinControl.SkinButton();
            this.diagnosisButton = new CCWin.SkinControl.SkinButton();
            this.dataExportButton = new CCWin.SkinControl.SkinButton();
            this.chartGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewChart)).BeginInit();
            this.measurementGroupBox.SuspendLayout();
            this.controlGroupBox.SuspendLayout();
            this.statusGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flowStatusPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pumbStatusPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlStatusPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGroupBox
            // 
            this.chartGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.chartGroupBox.BorderColor = System.Drawing.Color.White;
            this.chartGroupBox.Controls.Add(this.dataViewChart);
            this.chartGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chartGroupBox.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartGroupBox.ForeColor = System.Drawing.Color.Blue;
            this.chartGroupBox.Location = new System.Drawing.Point(8, 449);
            this.chartGroupBox.Name = "chartGroupBox";
            this.chartGroupBox.RectBackColor = System.Drawing.Color.White;
            this.chartGroupBox.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.chartGroupBox.Size = new System.Drawing.Size(1008, 311);
            this.chartGroupBox.TabIndex = 0;
            this.chartGroupBox.TabStop = false;
            this.chartGroupBox.Text = "Chart";
            this.chartGroupBox.TitleBorderColor = System.Drawing.Color.Black;
            this.chartGroupBox.TitleRectBackColor = System.Drawing.Color.White;
            this.chartGroupBox.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // dataViewChart
            // 
            chartArea1.Name = "ChartArea1";
            this.dataViewChart.ChartAreas.Add(chartArea1);
            this.dataViewChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.dataViewChart.Legends.Add(legend1);
            this.dataViewChart.Location = new System.Drawing.Point(3, 24);
            this.dataViewChart.Name = "dataViewChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.dataViewChart.Series.Add(series1);
            this.dataViewChart.Size = new System.Drawing.Size(1002, 284);
            this.dataViewChart.TabIndex = 0;
            this.dataViewChart.Text = "chart1";
            // 
            // measurementGroupBox
            // 
            this.measurementGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.measurementGroupBox.BorderColor = System.Drawing.Color.White;
            this.measurementGroupBox.Controls.Add(this.productValueLable);
            this.measurementGroupBox.Controls.Add(this.productNameLable);
            this.measurementGroupBox.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementGroupBox.ForeColor = System.Drawing.Color.Blue;
            this.measurementGroupBox.Location = new System.Drawing.Point(8, 148);
            this.measurementGroupBox.Name = "measurementGroupBox";
            this.measurementGroupBox.RectBackColor = System.Drawing.Color.White;
            this.measurementGroupBox.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.measurementGroupBox.Size = new System.Drawing.Size(320, 295);
            this.measurementGroupBox.TabIndex = 1;
            this.measurementGroupBox.TabStop = false;
            this.measurementGroupBox.Text = "Measurement";
            this.measurementGroupBox.TitleBorderColor = System.Drawing.Color.Black;
            this.measurementGroupBox.TitleRectBackColor = System.Drawing.Color.White;
            this.measurementGroupBox.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // productValueLable
            // 
            this.productValueLable.AutoSize = true;
            this.productValueLable.BackColor = System.Drawing.Color.Transparent;
            this.productValueLable.BorderColor = System.Drawing.Color.White;
            this.productValueLable.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productValueLable.Location = new System.Drawing.Point(54, 145);
            this.productValueLable.Name = "productValueLable";
            this.productValueLable.Size = new System.Drawing.Size(172, 51);
            this.productValueLable.TabIndex = 1;
            this.productValueLable.Text = "100ppb";
            // 
            // productNameLable
            // 
            this.productNameLable.AutoSize = true;
            this.productNameLable.BackColor = System.Drawing.Color.Transparent;
            this.productNameLable.BorderColor = System.Drawing.Color.White;
            this.productNameLable.Font = new System.Drawing.Font("Arial", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productNameLable.Location = new System.Drawing.Point(74, 71);
            this.productNameLable.Name = "productNameLable";
            this.productNameLable.Size = new System.Drawing.Size(137, 49);
            this.productNameLable.TabIndex = 0;
            this.productNameLable.Text = "PTSA";
            this.productNameLable.Click += new System.EventHandler(this.productNameLable_Click);
            // 
            // setupButton
            // 
            this.setupButton.BackColor = System.Drawing.Color.Transparent;
            this.setupButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.setupButton.DownBack = null;
            this.setupButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setupButton.IsDrawGlass = false;
            this.setupButton.Location = new System.Drawing.Point(14, 61);
            this.setupButton.MouseBack = null;
            this.setupButton.Name = "setupButton";
            this.setupButton.NormlBack = null;
            this.setupButton.Size = new System.Drawing.Size(90, 80);
            this.setupButton.TabIndex = 2;
            this.setupButton.Text = "SETTING";
            this.setupButton.UseVisualStyleBackColor = false;
            this.setupButton.Click += new System.EventHandler(this.setupButton_Click);
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.controlGroupBox.BorderColor = System.Drawing.Color.White;
            this.controlGroupBox.Controls.Add(this.setPumbOnButton);
            this.controlGroupBox.Controls.Add(this.setPumbOffButton);
            this.controlGroupBox.Controls.Add(this.autoManulSwitchButton);
            this.controlGroupBox.Controls.Add(this.lowerLimitValueLable);
            this.controlGroupBox.Controls.Add(this.upperLimitValueLable);
            this.controlGroupBox.Controls.Add(this.lowerLimitLable);
            this.controlGroupBox.Controls.Add(this.upperLimitLable);
            this.controlGroupBox.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlGroupBox.ForeColor = System.Drawing.Color.Blue;
            this.controlGroupBox.Location = new System.Drawing.Point(341, 148);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.RectBackColor = System.Drawing.Color.White;
            this.controlGroupBox.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.controlGroupBox.Size = new System.Drawing.Size(334, 295);
            this.controlGroupBox.TabIndex = 3;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "Control";
            this.controlGroupBox.TitleBorderColor = System.Drawing.Color.Black;
            this.controlGroupBox.TitleRectBackColor = System.Drawing.Color.White;
            this.controlGroupBox.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // setPumbOnButton
            // 
            this.setPumbOnButton.BackColor = System.Drawing.Color.Transparent;
            this.setPumbOnButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.setPumbOnButton.DownBack = null;
            this.setPumbOnButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPumbOnButton.IsDrawGlass = false;
            this.setPumbOnButton.Location = new System.Drawing.Point(181, 170);
            this.setPumbOnButton.MouseBack = null;
            this.setPumbOnButton.Name = "setPumbOnButton";
            this.setPumbOnButton.NormlBack = null;
            this.setPumbOnButton.Size = new System.Drawing.Size(71, 102);
            this.setPumbOnButton.TabIndex = 11;
            this.setPumbOnButton.Text = "PUMB  ON";
            this.setPumbOnButton.UseVisualStyleBackColor = false;
            this.setPumbOnButton.Click += new System.EventHandler(this.setPumbOnButton_Click);
            // 
            // setPumbOffButton
            // 
            this.setPumbOffButton.BackColor = System.Drawing.Color.Transparent;
            this.setPumbOffButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.setPumbOffButton.DownBack = null;
            this.setPumbOffButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPumbOffButton.IsDrawGlass = false;
            this.setPumbOffButton.Location = new System.Drawing.Point(259, 170);
            this.setPumbOffButton.MouseBack = null;
            this.setPumbOffButton.Name = "setPumbOffButton";
            this.setPumbOffButton.NormlBack = null;
            this.setPumbOffButton.Size = new System.Drawing.Size(71, 102);
            this.setPumbOffButton.TabIndex = 10;
            this.setPumbOffButton.Text = "PUMB OFF";
            this.setPumbOffButton.UseVisualStyleBackColor = false;
            this.setPumbOffButton.Click += new System.EventHandler(this.setPumbOffButton_Click);
            // 
            // autoManulSwitchButton
            // 
            this.autoManulSwitchButton.BackColor = System.Drawing.Color.Transparent;
            this.autoManulSwitchButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.autoManulSwitchButton.DownBack = null;
            this.autoManulSwitchButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoManulSwitchButton.IsDrawGlass = false;
            this.autoManulSwitchButton.Location = new System.Drawing.Point(181, 48);
            this.autoManulSwitchButton.MouseBack = null;
            this.autoManulSwitchButton.Name = "autoManulSwitchButton";
            this.autoManulSwitchButton.NormlBack = null;
            this.autoManulSwitchButton.Size = new System.Drawing.Size(149, 102);
            this.autoManulSwitchButton.TabIndex = 9;
            this.autoManulSwitchButton.Text = "AUTO";
            this.autoManulSwitchButton.UseVisualStyleBackColor = false;
            this.autoManulSwitchButton.Click += new System.EventHandler(this.autoManulSwitchButton_Click);
            // 
            // lowerLimitValueLable
            // 
            this.lowerLimitValueLable.AutoSize = true;
            this.lowerLimitValueLable.BackColor = System.Drawing.Color.Transparent;
            this.lowerLimitValueLable.BorderColor = System.Drawing.Color.White;
            this.lowerLimitValueLable.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerLimitValueLable.Location = new System.Drawing.Point(22, 227);
            this.lowerLimitValueLable.Name = "lowerLimitValueLable";
            this.lowerLimitValueLable.Size = new System.Drawing.Size(131, 45);
            this.lowerLimitValueLable.TabIndex = 4;
            this.lowerLimitValueLable.Text = "90ppb";
            this.lowerLimitValueLable.Click += new System.EventHandler(this.lowerLimitValueLable_Click);
            // 
            // upperLimitValueLable
            // 
            this.upperLimitValueLable.AutoSize = true;
            this.upperLimitValueLable.BackColor = System.Drawing.Color.Transparent;
            this.upperLimitValueLable.BorderColor = System.Drawing.Color.White;
            this.upperLimitValueLable.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperLimitValueLable.Location = new System.Drawing.Point(11, 122);
            this.upperLimitValueLable.Name = "upperLimitValueLable";
            this.upperLimitValueLable.Size = new System.Drawing.Size(150, 45);
            this.upperLimitValueLable.TabIndex = 3;
            this.upperLimitValueLable.Text = "110ppb";
            this.upperLimitValueLable.Click += new System.EventHandler(this.upperLimitValueLable_Click);
            // 
            // lowerLimitLable
            // 
            this.lowerLimitLable.AutoSize = true;
            this.lowerLimitLable.BackColor = System.Drawing.Color.Transparent;
            this.lowerLimitLable.BorderColor = System.Drawing.Color.White;
            this.lowerLimitLable.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerLimitLable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lowerLimitLable.Location = new System.Drawing.Point(5, 181);
            this.lowerLimitLable.Name = "lowerLimitLable";
            this.lowerLimitLable.Size = new System.Drawing.Size(164, 32);
            this.lowerLimitLable.TabIndex = 2;
            this.lowerLimitLable.Text = "Lower limit";
            // 
            // upperLimitLable
            // 
            this.upperLimitLable.AutoSize = true;
            this.upperLimitLable.BackColor = System.Drawing.Color.Transparent;
            this.upperLimitLable.BorderColor = System.Drawing.Color.White;
            this.upperLimitLable.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperLimitLable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.upperLimitLable.Location = new System.Drawing.Point(6, 76);
            this.upperLimitLable.Name = "upperLimitLable";
            this.upperLimitLable.Size = new System.Drawing.Size(162, 32);
            this.upperLimitLable.TabIndex = 1;
            this.upperLimitLable.Text = "Upper limit";
            // 
            // statusGroupBox
            // 
            this.statusGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.statusGroupBox.BorderColor = System.Drawing.Color.White;
            this.statusGroupBox.Controls.Add(this.flowStatusLable);
            this.statusGroupBox.Controls.Add(this.pumbStatusLable);
            this.statusGroupBox.Controls.Add(this.controlStatusLable);
            this.statusGroupBox.Controls.Add(this.flowStatusPicBox);
            this.statusGroupBox.Controls.Add(this.pumbStatusPicBox);
            this.statusGroupBox.Controls.Add(this.controlStatusPicBox);
            this.statusGroupBox.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusGroupBox.ForeColor = System.Drawing.Color.Blue;
            this.statusGroupBox.Location = new System.Drawing.Point(686, 60);
            this.statusGroupBox.Name = "statusGroupBox";
            this.statusGroupBox.RectBackColor = System.Drawing.Color.White;
            this.statusGroupBox.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.statusGroupBox.Size = new System.Drawing.Size(330, 383);
            this.statusGroupBox.TabIndex = 4;
            this.statusGroupBox.TabStop = false;
            this.statusGroupBox.Text = "Status";
            this.statusGroupBox.TitleBorderColor = System.Drawing.Color.Black;
            this.statusGroupBox.TitleRectBackColor = System.Drawing.Color.White;
            this.statusGroupBox.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // flowStatusLable
            // 
            this.flowStatusLable.AutoSize = true;
            this.flowStatusLable.BackColor = System.Drawing.Color.Transparent;
            this.flowStatusLable.BorderColor = System.Drawing.Color.White;
            this.flowStatusLable.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowStatusLable.Location = new System.Drawing.Point(12, 315);
            this.flowStatusLable.Name = "flowStatusLable";
            this.flowStatusLable.Size = new System.Drawing.Size(106, 29);
            this.flowStatusLable.TabIndex = 6;
            this.flowStatusLable.Text = "Flowing";
            // 
            // pumbStatusLable
            // 
            this.pumbStatusLable.AutoSize = true;
            this.pumbStatusLable.BackColor = System.Drawing.Color.Transparent;
            this.pumbStatusLable.BorderColor = System.Drawing.Color.White;
            this.pumbStatusLable.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pumbStatusLable.Location = new System.Drawing.Point(12, 226);
            this.pumbStatusLable.Name = "pumbStatusLable";
            this.pumbStatusLable.Size = new System.Drawing.Size(120, 29);
            this.pumbStatusLable.TabIndex = 5;
            this.pumbStatusLable.Text = "Pumb On";
            // 
            // controlStatusLable
            // 
            this.controlStatusLable.AutoSize = true;
            this.controlStatusLable.BackColor = System.Drawing.Color.Transparent;
            this.controlStatusLable.BorderColor = System.Drawing.Color.White;
            this.controlStatusLable.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlStatusLable.Location = new System.Drawing.Point(12, 141);
            this.controlStatusLable.Name = "controlStatusLable";
            this.controlStatusLable.Size = new System.Drawing.Size(219, 29);
            this.controlStatusLable.TabIndex = 4;
            this.controlStatusLable.Text = "Automatic control";
            // 
            // flowStatusPicBox
            // 
            this.flowStatusPicBox.Image = global::ControllerSoftware.Properties.Resources.flowing;
            this.flowStatusPicBox.Location = new System.Drawing.Point(244, 292);
            this.flowStatusPicBox.Name = "flowStatusPicBox";
            this.flowStatusPicBox.Size = new System.Drawing.Size(80, 80);
            this.flowStatusPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flowStatusPicBox.TabIndex = 2;
            this.flowStatusPicBox.TabStop = false;
            // 
            // pumbStatusPicBox
            // 
            this.pumbStatusPicBox.Image = global::ControllerSoftware.Properties.Resources.pumbon;
            this.pumbStatusPicBox.Location = new System.Drawing.Point(244, 204);
            this.pumbStatusPicBox.Name = "pumbStatusPicBox";
            this.pumbStatusPicBox.Size = new System.Drawing.Size(80, 80);
            this.pumbStatusPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pumbStatusPicBox.TabIndex = 1;
            this.pumbStatusPicBox.TabStop = false;
            // 
            // controlStatusPicBox
            // 
            this.controlStatusPicBox.Image = global::ControllerSoftware.Properties.Resources.autocontrol;
            this.controlStatusPicBox.Location = new System.Drawing.Point(244, 116);
            this.controlStatusPicBox.Name = "controlStatusPicBox";
            this.controlStatusPicBox.Size = new System.Drawing.Size(80, 80);
            this.controlStatusPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.controlStatusPicBox.TabIndex = 0;
            this.controlStatusPicBox.TabStop = false;
            // 
            // calibButton
            // 
            this.calibButton.BackColor = System.Drawing.Color.Transparent;
            this.calibButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calibButton.DownBack = null;
            this.calibButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calibButton.IsDrawGlass = false;
            this.calibButton.Location = new System.Drawing.Point(141, 60);
            this.calibButton.MouseBack = null;
            this.calibButton.Name = "calibButton";
            this.calibButton.NormlBack = null;
            this.calibButton.Size = new System.Drawing.Size(90, 80);
            this.calibButton.TabIndex = 5;
            this.calibButton.Text = "CALIB";
            this.calibButton.UseVisualStyleBackColor = false;
            this.calibButton.Click += new System.EventHandler(this.calibButton_Click);
            // 
            // historyDataViewButton
            // 
            this.historyDataViewButton.BackColor = System.Drawing.Color.Transparent;
            this.historyDataViewButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.historyDataViewButton.DownBack = null;
            this.historyDataViewButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyDataViewButton.IsDrawGlass = false;
            this.historyDataViewButton.Location = new System.Drawing.Point(267, 60);
            this.historyDataViewButton.MouseBack = null;
            this.historyDataViewButton.Name = "historyDataViewButton";
            this.historyDataViewButton.NormlBack = null;
            this.historyDataViewButton.Size = new System.Drawing.Size(90, 80);
            this.historyDataViewButton.TabIndex = 6;
            this.historyDataViewButton.Text = "HISTORY DATA VIEW";
            this.historyDataViewButton.UseVisualStyleBackColor = false;
            this.historyDataViewButton.Click += new System.EventHandler(this.historyDataViewButton_Click);
            // 
            // diagnosisButton
            // 
            this.diagnosisButton.BackColor = System.Drawing.Color.Transparent;
            this.diagnosisButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.diagnosisButton.DownBack = null;
            this.diagnosisButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosisButton.IsDrawGlass = false;
            this.diagnosisButton.Location = new System.Drawing.Point(395, 60);
            this.diagnosisButton.MouseBack = null;
            this.diagnosisButton.Name = "diagnosisButton";
            this.diagnosisButton.NormlBack = null;
            this.diagnosisButton.Size = new System.Drawing.Size(90, 80);
            this.diagnosisButton.TabIndex = 7;
            this.diagnosisButton.Text = "DIAGNOSIS";
            this.diagnosisButton.UseVisualStyleBackColor = false;
            this.diagnosisButton.Click += new System.EventHandler(this.diagnosisButton_Click);
            // 
            // dataExportButton
            // 
            this.dataExportButton.BackColor = System.Drawing.Color.Transparent;
            this.dataExportButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.dataExportButton.DownBack = null;
            this.dataExportButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataExportButton.IsDrawGlass = false;
            this.dataExportButton.Location = new System.Drawing.Point(522, 60);
            this.dataExportButton.MouseBack = null;
            this.dataExportButton.Name = "dataExportButton";
            this.dataExportButton.NormlBack = null;
            this.dataExportButton.Size = new System.Drawing.Size(90, 80);
            this.dataExportButton.TabIndex = 8;
            this.dataExportButton.Text = "DATA EXPORT";
            this.dataExportButton.UseVisualStyleBackColor = false;
            this.dataExportButton.Click += new System.EventHandler(this.dataExportButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.dataExportButton);
            this.Controls.Add(this.diagnosisButton);
            this.Controls.Add(this.historyDataViewButton);
            this.Controls.Add(this.calibButton);
            this.Controls.Add(this.statusGroupBox);
            this.Controls.Add(this.controlGroupBox);
            this.Controls.Add(this.setupButton);
            this.Controls.Add(this.measurementGroupBox);
            this.Controls.Add(this.chartGroupBox);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Controller";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.chartGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewChart)).EndInit();
            this.measurementGroupBox.ResumeLayout(false);
            this.measurementGroupBox.PerformLayout();
            this.controlGroupBox.ResumeLayout(false);
            this.controlGroupBox.PerformLayout();
            this.statusGroupBox.ResumeLayout(false);
            this.statusGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flowStatusPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pumbStatusPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlStatusPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinGroupBox chartGroupBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart dataViewChart;
        private CCWin.SkinControl.SkinGroupBox measurementGroupBox;
        private CCWin.SkinControl.SkinLabel productNameLable;
        private CCWin.SkinControl.SkinButton setupButton;
        private CCWin.SkinControl.SkinGroupBox controlGroupBox;
        private CCWin.SkinControl.SkinGroupBox statusGroupBox;
        private CCWin.SkinControl.SkinLabel productValueLable;
        private CCWin.SkinControl.SkinLabel lowerLimitLable;
        private CCWin.SkinControl.SkinLabel upperLimitLable;
        private CCWin.SkinControl.SkinLabel lowerLimitValueLable;
        private CCWin.SkinControl.SkinLabel upperLimitValueLable;
        private CCWin.SkinControl.SkinButton calibButton;
        private CCWin.SkinControl.SkinButton historyDataViewButton;
        private CCWin.SkinControl.SkinButton diagnosisButton;
        private CCWin.SkinControl.SkinButton dataExportButton;
        private CCWin.SkinControl.SkinButton setPumbOffButton;
        private CCWin.SkinControl.SkinButton autoManulSwitchButton;
        private CCWin.SkinControl.SkinButton setPumbOnButton;
        private CCWin.SkinControl.SkinLabel flowStatusLable;
        private CCWin.SkinControl.SkinLabel pumbStatusLable;
        private CCWin.SkinControl.SkinLabel controlStatusLable;
        private System.Windows.Forms.PictureBox flowStatusPicBox;
        private System.Windows.Forms.PictureBox pumbStatusPicBox;
        private System.Windows.Forms.PictureBox controlStatusPicBox;
    }
}