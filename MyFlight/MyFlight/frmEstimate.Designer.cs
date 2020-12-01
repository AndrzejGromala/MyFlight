namespace MyFlight
{
    partial class frmEstimate
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
            this.lblEuroFlights = new System.Windows.Forms.Label();
            this.grpUKCities = new System.Windows.Forms.GroupBox();
            this.radioNewCastle = new System.Windows.Forms.RadioButton();
            this.radioLiverPool = new System.Windows.Forms.RadioButton();
            this.radioManchester = new System.Windows.Forms.RadioButton();
            this.radioLondon = new System.Windows.Forms.RadioButton();
            this.grpBaggage = new System.Windows.Forms.GroupBox();
            this.radioExtra = new System.Windows.Forms.RadioButton();
            this.radioStandard = new System.Windows.Forms.RadioButton();
            this.panelPrices = new System.Windows.Forms.Panel();
            this.txtNewCastle = new System.Windows.Forms.TextBox();
            this.txtLiverPool = new System.Windows.Forms.TextBox();
            this.txtMenchaster = new System.Windows.Forms.TextBox();
            this.txtLondon = new System.Windows.Forms.TextBox();
            this.lblCostPerFlight = new System.Windows.Forms.Label();
            this.cdmGO = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.panelDatesPrices = new System.Windows.Forms.Panel();
            this.lblOutput = new System.Windows.Forms.Label();
            this.cmdClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCostIncludingVatEuro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCostIncludingVAtGBP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCostExcludingVatEuro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCostExcludingVatGbp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSecondDatePicker = new System.Windows.Forms.Panel();
            this.dateTimePickerReturn = new System.Windows.Forms.DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.dateTimePickerDeparture = new System.Windows.Forms.DateTimePicker();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.checkReturnFlight = new System.Windows.Forms.CheckBox();
            this.panelExchangeRate = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExchangeRate = new System.Windows.Forms.TextBox();
            this.lblExchangeRate = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFromTopMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.grpUKCities.SuspendLayout();
            this.grpBaggage.SuspendLayout();
            this.panelPrices.SuspendLayout();
            this.panelDatesPrices.SuspendLayout();
            this.panelSecondDatePicker.SuspendLayout();
            this.panelExchangeRate.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEuroFlights
            // 
            this.lblEuroFlights.AutoSize = true;
            this.lblEuroFlights.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuroFlights.ForeColor = System.Drawing.Color.Red;
            this.lblEuroFlights.Location = new System.Drawing.Point(207, 19);
            this.lblEuroFlights.Name = "lblEuroFlights";
            this.lblEuroFlights.Size = new System.Drawing.Size(141, 26);
            this.lblEuroFlights.TabIndex = 0;
            this.lblEuroFlights.Text = "Euro Flights";
            // 
            // grpUKCities
            // 
            this.grpUKCities.Controls.Add(this.radioNewCastle);
            this.grpUKCities.Controls.Add(this.radioLiverPool);
            this.grpUKCities.Controls.Add(this.radioManchester);
            this.grpUKCities.Controls.Add(this.radioLondon);
            this.grpUKCities.Location = new System.Drawing.Point(36, 101);
            this.grpUKCities.Name = "grpUKCities";
            this.grpUKCities.Size = new System.Drawing.Size(131, 156);
            this.grpUKCities.TabIndex = 1;
            this.grpUKCities.TabStop = false;
            this.grpUKCities.Text = "UK Cities";
            // 
            // radioNewCastle
            // 
            this.radioNewCastle.AutoSize = true;
            this.radioNewCastle.Location = new System.Drawing.Point(7, 115);
            this.radioNewCastle.Name = "radioNewCastle";
            this.radioNewCastle.Size = new System.Drawing.Size(79, 17);
            this.radioNewCastle.TabIndex = 3;
            this.radioNewCastle.Text = "New Castle";
            this.radioNewCastle.UseVisualStyleBackColor = true;
            this.radioNewCastle.CheckedChanged += new System.EventHandler(this.radioNewCastle_CheckedChanged);
            // 
            // radioLiverPool
            // 
            this.radioLiverPool.AutoSize = true;
            this.radioLiverPool.Location = new System.Drawing.Point(7, 83);
            this.radioLiverPool.Name = "radioLiverPool";
            this.radioLiverPool.Size = new System.Drawing.Size(69, 17);
            this.radioLiverPool.TabIndex = 2;
            this.radioLiverPool.Text = "LiverPool";
            this.radioLiverPool.UseVisualStyleBackColor = true;
            this.radioLiverPool.CheckedChanged += new System.EventHandler(this.radioLiverPool_CheckedChanged);
            // 
            // radioManchester
            // 
            this.radioManchester.AutoSize = true;
            this.radioManchester.Location = new System.Drawing.Point(7, 52);
            this.radioManchester.Name = "radioManchester";
            this.radioManchester.Size = new System.Drawing.Size(81, 17);
            this.radioManchester.TabIndex = 1;
            this.radioManchester.Text = "Menchester";
            this.radioManchester.UseVisualStyleBackColor = true;
            this.radioManchester.CheckedChanged += new System.EventHandler(this.radioManchester_CheckedChanged);
            // 
            // radioLondon
            // 
            this.radioLondon.AutoSize = true;
            this.radioLondon.Checked = true;
            this.radioLondon.Location = new System.Drawing.Point(7, 20);
            this.radioLondon.Name = "radioLondon";
            this.radioLondon.Size = new System.Drawing.Size(61, 17);
            this.radioLondon.TabIndex = 0;
            this.radioLondon.TabStop = true;
            this.radioLondon.Text = "London";
            this.radioLondon.UseVisualStyleBackColor = true;
            this.radioLondon.CheckedChanged += new System.EventHandler(this.radioLondon_CheckedChanged);
            this.radioLondon.Enter += new System.EventHandler(this.radioLondon_Enter);
            this.radioLondon.Validated += new System.EventHandler(this.radioLondon_Validated);
            // 
            // grpBaggage
            // 
            this.grpBaggage.Controls.Add(this.radioExtra);
            this.grpBaggage.Controls.Add(this.radioStandard);
            this.grpBaggage.Location = new System.Drawing.Point(446, 101);
            this.grpBaggage.Name = "grpBaggage";
            this.grpBaggage.Size = new System.Drawing.Size(127, 100);
            this.grpBaggage.TabIndex = 2;
            this.grpBaggage.TabStop = false;
            this.grpBaggage.Text = "Bagage";
            // 
            // radioExtra
            // 
            this.radioExtra.AutoSize = true;
            this.radioExtra.Location = new System.Drawing.Point(15, 42);
            this.radioExtra.Name = "radioExtra";
            this.radioExtra.Size = new System.Drawing.Size(49, 17);
            this.radioExtra.TabIndex = 5;
            this.radioExtra.Text = "Extra";
            this.radioExtra.UseVisualStyleBackColor = true;
            // 
            // radioStandard
            // 
            this.radioStandard.AutoSize = true;
            this.radioStandard.Checked = true;
            this.radioStandard.Location = new System.Drawing.Point(15, 19);
            this.radioStandard.Name = "radioStandard";
            this.radioStandard.Size = new System.Drawing.Size(68, 17);
            this.radioStandard.TabIndex = 4;
            this.radioStandard.TabStop = true;
            this.radioStandard.Text = "Standard";
            this.radioStandard.UseVisualStyleBackColor = true;
            // 
            // panelPrices
            // 
            this.panelPrices.Controls.Add(this.txtNewCastle);
            this.panelPrices.Controls.Add(this.txtLiverPool);
            this.panelPrices.Controls.Add(this.txtMenchaster);
            this.panelPrices.Controls.Add(this.txtLondon);
            this.panelPrices.Controls.Add(this.lblCostPerFlight);
            this.panelPrices.Location = new System.Drawing.Point(193, 82);
            this.panelPrices.Name = "panelPrices";
            this.panelPrices.Size = new System.Drawing.Size(233, 176);
            this.panelPrices.TabIndex = 7;
            // 
            // txtNewCastle
            // 
            this.txtNewCastle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewCastle.Location = new System.Drawing.Point(39, 131);
            this.txtNewCastle.Name = "txtNewCastle";
            this.txtNewCastle.Size = new System.Drawing.Size(100, 20);
            this.txtNewCastle.TabIndex = 4;
            this.txtNewCastle.Text = "60.00";
            this.txtNewCastle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNewCastle.TextChanged += new System.EventHandler(this.txtNewCastle_TextChanged);
            // 
            // txtLiverPool
            // 
            this.txtLiverPool.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLiverPool.Location = new System.Drawing.Point(39, 99);
            this.txtLiverPool.Name = "txtLiverPool";
            this.txtLiverPool.Size = new System.Drawing.Size(100, 20);
            this.txtLiverPool.TabIndex = 3;
            this.txtLiverPool.Text = "75.00";
            this.txtLiverPool.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLiverPool.TextChanged += new System.EventHandler(this.txtLiverPool_TextChanged);
            // 
            // txtMenchaster
            // 
            this.txtMenchaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenchaster.Location = new System.Drawing.Point(39, 68);
            this.txtMenchaster.Name = "txtMenchaster";
            this.txtMenchaster.Size = new System.Drawing.Size(100, 20);
            this.txtMenchaster.TabIndex = 2;
            this.txtMenchaster.Text = "70.00";
            this.txtMenchaster.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMenchaster.TextChanged += new System.EventHandler(this.txtMenchester_TextChanged);
            // 
            // txtLondon
            // 
            this.txtLondon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLondon.Location = new System.Drawing.Point(39, 37);
            this.txtLondon.Name = "txtLondon";
            this.txtLondon.Size = new System.Drawing.Size(100, 20);
            this.txtLondon.TabIndex = 1;
            this.txtLondon.Text = "50.00";
            this.txtLondon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLondon.TextChanged += new System.EventHandler(this.txtLondon_TextChanged);
            // 
            // lblCostPerFlight
            // 
            this.lblCostPerFlight.AutoSize = true;
            this.lblCostPerFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostPerFlight.Location = new System.Drawing.Point(36, 9);
            this.lblCostPerFlight.Name = "lblCostPerFlight";
            this.lblCostPerFlight.Size = new System.Drawing.Size(86, 15);
            this.lblCostPerFlight.TabIndex = 0;
            this.lblCostPerFlight.Text = "Cost Per Flight";
            // 
            // cdmGO
            // 
            this.cdmGO.Location = new System.Drawing.Point(219, 451);
            this.cdmGO.Name = "cdmGO";
            this.cdmGO.Size = new System.Drawing.Size(75, 23);
            this.cdmGO.TabIndex = 9;
            this.cdmGO.Text = "GO";
            this.cdmGO.UseVisualStyleBackColor = true;
            this.cdmGO.Click += new System.EventHandler(this.cdmGO_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(503, 451);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 23);
            this.cmdExit.TabIndex = 10;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // panelDatesPrices
            // 
            this.panelDatesPrices.Controls.Add(this.lblOutput);
            this.panelDatesPrices.Controls.Add(this.cmdClear);
            this.panelDatesPrices.Controls.Add(this.label6);
            this.panelDatesPrices.Controls.Add(this.txtCostIncludingVatEuro);
            this.panelDatesPrices.Controls.Add(this.label7);
            this.panelDatesPrices.Controls.Add(this.txtCostIncludingVAtGBP);
            this.panelDatesPrices.Controls.Add(this.label8);
            this.panelDatesPrices.Controls.Add(this.cmdCalculate);
            this.panelDatesPrices.Controls.Add(this.label5);
            this.panelDatesPrices.Controls.Add(this.txtCostExcludingVatEuro);
            this.panelDatesPrices.Controls.Add(this.label4);
            this.panelDatesPrices.Controls.Add(this.txtCostExcludingVatGbp);
            this.panelDatesPrices.Controls.Add(this.label3);
            this.panelDatesPrices.Controls.Add(this.panelSecondDatePicker);
            this.panelDatesPrices.Controls.Add(this.dateTimePickerDeparture);
            this.panelDatesPrices.Controls.Add(this.lblDepartureDate);
            this.panelDatesPrices.Controls.Add(this.checkReturnFlight);
            this.panelDatesPrices.Location = new System.Drawing.Point(27, 264);
            this.panelDatesPrices.Name = "panelDatesPrices";
            this.panelDatesPrices.Size = new System.Drawing.Size(575, 181);
            this.panelDatesPrices.TabIndex = 11;
            this.panelDatesPrices.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDatesPrices_Paint);
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.Yellow;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(123, 145);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(300, 24);
            this.lblOutput.TabIndex = 16;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(476, 103);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 15;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Euro";
            // 
            // txtCostIncludingVatEuro
            // 
            this.txtCostIncludingVatEuro.Location = new System.Drawing.Point(308, 103);
            this.txtCostIncludingVatEuro.Name = "txtCostIncludingVatEuro";
            this.txtCostIncludingVatEuro.Size = new System.Drawing.Size(73, 20);
            this.txtCostIncludingVatEuro.TabIndex = 13;
            this.txtCostIncludingVatEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "GBP";
            // 
            // txtCostIncludingVAtGBP
            // 
            this.txtCostIncludingVAtGBP.Location = new System.Drawing.Point(157, 103);
            this.txtCostIncludingVAtGBP.Name = "txtCostIncludingVAtGBP";
            this.txtCostIncludingVAtGBP.Size = new System.Drawing.Size(73, 20);
            this.txtCostIncludingVAtGBP.TabIndex = 11;
            this.txtCostIncludingVAtGBP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostIncludingVAtGBP.TextChanged += new System.EventHandler(this.txtCostIncludingVAtGBP_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cost Including Vat";
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Location = new System.Drawing.Point(476, 65);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(75, 23);
            this.cmdCalculate.TabIndex = 9;
            this.cmdCalculate.Text = "Calculate";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Euro";
            // 
            // txtCostExcludingVatEuro
            // 
            this.txtCostExcludingVatEuro.Location = new System.Drawing.Point(308, 65);
            this.txtCostExcludingVatEuro.Name = "txtCostExcludingVatEuro";
            this.txtCostExcludingVatEuro.Size = new System.Drawing.Size(73, 20);
            this.txtCostExcludingVatEuro.TabIndex = 7;
            this.txtCostExcludingVatEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "GBP";
            // 
            // txtCostExcludingVatGbp
            // 
            this.txtCostExcludingVatGbp.Location = new System.Drawing.Point(157, 65);
            this.txtCostExcludingVatGbp.Name = "txtCostExcludingVatGbp";
            this.txtCostExcludingVatGbp.Size = new System.Drawing.Size(73, 20);
            this.txtCostExcludingVatGbp.TabIndex = 5;
            this.txtCostExcludingVatGbp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostExcludingVatGbp.TextChanged += new System.EventHandler(this.txtCostExcludingVatGbp_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cost Excluding Vat";
            // 
            // panelSecondDatePicker
            // 
            this.panelSecondDatePicker.Controls.Add(this.dateTimePickerReturn);
            this.panelSecondDatePicker.Controls.Add(this.lblReturnDate);
            this.panelSecondDatePicker.Location = new System.Drawing.Point(333, 4);
            this.panelSecondDatePicker.Name = "panelSecondDatePicker";
            this.panelSecondDatePicker.Size = new System.Drawing.Size(238, 38);
            this.panelSecondDatePicker.TabIndex = 3;
            // 
            // dateTimePickerReturn
            // 
            this.dateTimePickerReturn.Location = new System.Drawing.Point(94, 9);
            this.dateTimePickerReturn.Name = "dateTimePickerReturn";
            this.dateTimePickerReturn.Size = new System.Drawing.Size(136, 20);
            this.dateTimePickerReturn.TabIndex = 4;
            this.dateTimePickerReturn.ValueChanged += new System.EventHandler(this.dateTimePickerReturn_ValueChanged);
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(23, 12);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(65, 13);
            this.lblReturnDate.TabIndex = 3;
            this.lblReturnDate.Text = "Return Date";
            // 
            // dateTimePickerDeparture
            // 
            this.dateTimePickerDeparture.Location = new System.Drawing.Point(191, 13);
            this.dateTimePickerDeparture.Name = "dateTimePickerDeparture";
            this.dateTimePickerDeparture.Size = new System.Drawing.Size(136, 20);
            this.dateTimePickerDeparture.TabIndex = 2;
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.Location = new System.Drawing.Point(105, 17);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(80, 13);
            this.lblDepartureDate.TabIndex = 1;
            this.lblDepartureDate.Text = "Departure Date";
            // 
            // checkReturnFlight
            // 
            this.checkReturnFlight.AutoSize = true;
            this.checkReturnFlight.Location = new System.Drawing.Point(9, 16);
            this.checkReturnFlight.Name = "checkReturnFlight";
            this.checkReturnFlight.Size = new System.Drawing.Size(86, 17);
            this.checkReturnFlight.TabIndex = 0;
            this.checkReturnFlight.Text = "Return Flight";
            this.checkReturnFlight.UseVisualStyleBackColor = true;
            this.checkReturnFlight.CheckedChanged += new System.EventHandler(this.checkReturnFlight_CheckedChanged);
            // 
            // panelExchangeRate
            // 
            this.panelExchangeRate.Controls.Add(this.label2);
            this.panelExchangeRate.Controls.Add(this.txtExchangeRate);
            this.panelExchangeRate.Controls.Add(this.lblExchangeRate);
            this.panelExchangeRate.Location = new System.Drawing.Point(63, 48);
            this.panelExchangeRate.Name = "panelExchangeRate";
            this.panelExchangeRate.Size = new System.Drawing.Size(312, 28);
            this.panelExchangeRate.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Euro\'s";
            // 
            // txtExchangeRate
            // 
            this.txtExchangeRate.Location = new System.Drawing.Point(152, 3);
            this.txtExchangeRate.Name = "txtExchangeRate";
            this.txtExchangeRate.Size = new System.Drawing.Size(100, 20);
            this.txtExchangeRate.TabIndex = 7;
            this.txtExchangeRate.Text = "1.25";
            this.txtExchangeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtExchangeRate.TextChanged += new System.EventHandler(this.txtExchangeRate_TextChanged);
            // 
            // lblExchangeRate
            // 
            this.lblExchangeRate.AutoSize = true;
            this.lblExchangeRate.Location = new System.Drawing.Point(36, 6);
            this.lblExchangeRate.Name = "lblExchangeRate";
            this.lblExchangeRate.Size = new System.Drawing.Size(102, 13);
            this.lblExchangeRate.TabIndex = 6;
            this.lblExchangeRate.Text = "Exchange Rate:  £1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitFromTopMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitFromTopMenu
            // 
            this.exitFromTopMenu.Name = "exitFromTopMenu";
            this.exitFromTopMenu.Size = new System.Drawing.Size(92, 22);
            this.exitFromTopMenu.Text = "Exit";
            this.exitFromTopMenu.Click += new System.EventHandler(this.exitFromTopMenu_Click);
            // 
            // frmEstimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 507);
            this.Controls.Add(this.panelExchangeRate);
            this.Controls.Add(this.panelDatesPrices);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cdmGO);
            this.Controls.Add(this.panelPrices);
            this.Controls.Add(this.grpBaggage);
            this.Controls.Add(this.grpUKCities);
            this.Controls.Add(this.lblEuroFlights);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEstimate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Estimates";
            this.grpUKCities.ResumeLayout(false);
            this.grpUKCities.PerformLayout();
            this.grpBaggage.ResumeLayout(false);
            this.grpBaggage.PerformLayout();
            this.panelPrices.ResumeLayout(false);
            this.panelPrices.PerformLayout();
            this.panelDatesPrices.ResumeLayout(false);
            this.panelDatesPrices.PerformLayout();
            this.panelSecondDatePicker.ResumeLayout(false);
            this.panelSecondDatePicker.PerformLayout();
            this.panelExchangeRate.ResumeLayout(false);
            this.panelExchangeRate.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEuroFlights;
        private System.Windows.Forms.GroupBox grpUKCities;
        private System.Windows.Forms.GroupBox grpBaggage;
        private System.Windows.Forms.RadioButton radioNewCastle;
        private System.Windows.Forms.RadioButton radioLiverPool;
        private System.Windows.Forms.RadioButton radioManchester;
        private System.Windows.Forms.RadioButton radioLondon;
        private System.Windows.Forms.RadioButton radioExtra;
        private System.Windows.Forms.RadioButton radioStandard;
        private System.Windows.Forms.Panel panelPrices;
        private System.Windows.Forms.TextBox txtNewCastle;
        private System.Windows.Forms.TextBox txtLiverPool;
        private System.Windows.Forms.TextBox txtMenchaster;
        private System.Windows.Forms.TextBox txtLondon;
        private System.Windows.Forms.Label lblCostPerFlight;
        private System.Windows.Forms.Button cdmGO;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Panel panelDatesPrices;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeparture;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.CheckBox checkReturnFlight;
        private System.Windows.Forms.Panel panelSecondDatePicker;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturn;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCostIncludingVatEuro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCostIncludingVAtGBP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCostExcludingVatEuro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCostExcludingVatGbp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelExchangeRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExchangeRate;
        private System.Windows.Forms.Label lblExchangeRate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitFromTopMenu;
    }
}

