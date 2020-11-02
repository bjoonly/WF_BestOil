namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gaseStationGroupBox = new System.Windows.Forms.GroupBox();
            this.sumGasNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.countGasNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.toPayGasGroupBox = new System.Windows.Forms.GroupBox();
            this.toPayGasStationLabel = new System.Windows.Forms.Label();
            this.ulToPayGasLabel = new System.Windows.Forms.Label();
            this.lCountGasStationLabel = new System.Windows.Forms.Label();
            this.uahSubGasStationLabel = new System.Windows.Forms.Label();
            this.countSumPanel = new System.Windows.Forms.Panel();
            this.sumGasRadioButton = new System.Windows.Forms.RadioButton();
            this.countGasRadioButton = new System.Windows.Forms.RadioButton();
            this.uahGasStationLabel = new System.Windows.Forms.Label();
            this.pricePetrolTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.petrolLabel = new System.Windows.Forms.Label();
            this.petrolComboBox = new System.Windows.Forms.ComboBox();
            this.cafeGroupBox = new System.Windows.Forms.GroupBox();
            this.countCocaColaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.countFrenchFriesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.countHamburgerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.countHotdogNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CountCafeLabel = new System.Windows.Forms.Label();
            this.PriceCafeLabel = new System.Windows.Forms.Label();
            this.priceCocaColaTextBox = new System.Windows.Forms.TextBox();
            this.priceFrenchFriesTextBox = new System.Windows.Forms.TextBox();
            this.priceHamburgerTextBox = new System.Windows.Forms.TextBox();
            this.priceHotDogTextBox = new System.Windows.Forms.TextBox();
            this.cocaColaCheckBox = new System.Windows.Forms.CheckBox();
            this.frenchFriesCheckBox = new System.Windows.Forms.CheckBox();
            this.hamburgerCheckBox = new System.Windows.Forms.CheckBox();
            this.hotDogCheckBox = new System.Windows.Forms.CheckBox();
            this.ToPayCafeGroupBox = new System.Windows.Forms.GroupBox();
            this.ToPayCafeLabel = new System.Windows.Forms.Label();
            this.ulToPayCafeLabel = new System.Windows.Forms.Label();
            this.totalToPayGroupBox = new System.Windows.Forms.GroupBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.ulTotalToPay = new System.Windows.Forms.Label();
            this.ToPayLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gaseStationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumGasNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countGasNumericUpDown)).BeginInit();
            this.toPayGasGroupBox.SuspendLayout();
            this.countSumPanel.SuspendLayout();
            this.cafeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countCocaColaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countFrenchFriesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countHamburgerNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countHotdogNumericUpDown)).BeginInit();
            this.ToPayCafeGroupBox.SuspendLayout();
            this.totalToPayGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gaseStationGroupBox
            // 
            this.gaseStationGroupBox.Controls.Add(this.sumGasNumericUpDown);
            this.gaseStationGroupBox.Controls.Add(this.countGasNumericUpDown);
            this.gaseStationGroupBox.Controls.Add(this.toPayGasGroupBox);
            this.gaseStationGroupBox.Controls.Add(this.lCountGasStationLabel);
            this.gaseStationGroupBox.Controls.Add(this.uahSubGasStationLabel);
            this.gaseStationGroupBox.Controls.Add(this.countSumPanel);
            this.gaseStationGroupBox.Controls.Add(this.uahGasStationLabel);
            this.gaseStationGroupBox.Controls.Add(this.pricePetrolTextBox);
            this.gaseStationGroupBox.Controls.Add(this.priceLabel);
            this.gaseStationGroupBox.Controls.Add(this.petrolLabel);
            this.gaseStationGroupBox.Controls.Add(this.petrolComboBox);
            this.gaseStationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gaseStationGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gaseStationGroupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gaseStationGroupBox.Location = new System.Drawing.Point(24, 28);
            this.gaseStationGroupBox.Name = "gaseStationGroupBox";
            this.gaseStationGroupBox.Size = new System.Drawing.Size(281, 315);
            this.gaseStationGroupBox.TabIndex = 0;
            this.gaseStationGroupBox.TabStop = false;
            this.gaseStationGroupBox.Text = "Gas station";
            // 
            // sumGasNumericUpDown
            // 
            this.sumGasNumericUpDown.DecimalPlaces = 2;
            this.sumGasNumericUpDown.Enabled = false;
            this.sumGasNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sumGasNumericUpDown.Location = new System.Drawing.Point(156, 189);
            this.sumGasNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.sumGasNumericUpDown.Name = "sumGasNumericUpDown";
            this.sumGasNumericUpDown.ReadOnly = true;
            this.sumGasNumericUpDown.Size = new System.Drawing.Size(79, 21);
            this.sumGasNumericUpDown.TabIndex = 16;
            this.sumGasNumericUpDown.ValueChanged += new System.EventHandler(this.sumGasNumericUpDown_ValueChanged);
            // 
            // countGasNumericUpDown
            // 
            this.countGasNumericUpDown.DecimalPlaces = 2;
            this.countGasNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.countGasNumericUpDown.Location = new System.Drawing.Point(156, 149);
            this.countGasNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.countGasNumericUpDown.Name = "countGasNumericUpDown";
            this.countGasNumericUpDown.Size = new System.Drawing.Size(79, 21);
            this.countGasNumericUpDown.TabIndex = 15;
            this.countGasNumericUpDown.ValueChanged += new System.EventHandler(this.countGasNumericUpDown_ValueChanged);
            // 
            // toPayGasGroupBox
            // 
            this.toPayGasGroupBox.Controls.Add(this.toPayGasStationLabel);
            this.toPayGasGroupBox.Controls.Add(this.ulToPayGasLabel);
            this.toPayGasGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toPayGasGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toPayGasGroupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toPayGasGroupBox.Location = new System.Drawing.Point(6, 241);
            this.toPayGasGroupBox.Name = "toPayGasGroupBox";
            this.toPayGasGroupBox.Size = new System.Drawing.Size(266, 64);
            this.toPayGasGroupBox.TabIndex = 3;
            this.toPayGasGroupBox.TabStop = false;
            this.toPayGasGroupBox.Text = "To pay";
            // 
            // toPayGasStationLabel
            // 
            this.toPayGasStationLabel.AutoSize = true;
            this.toPayGasStationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toPayGasStationLabel.Location = new System.Drawing.Point(64, 16);
            this.toPayGasStationLabel.MinimumSize = new System.Drawing.Size(100, 40);
            this.toPayGasStationLabel.Name = "toPayGasStationLabel";
            this.toPayGasStationLabel.Size = new System.Drawing.Size(100, 40);
            this.toPayGasStationLabel.TabIndex = 11;
            this.toPayGasStationLabel.Text = "0,00";
            this.toPayGasStationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ulToPayGasLabel
            // 
            this.ulToPayGasLabel.AutoSize = true;
            this.ulToPayGasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ulToPayGasLabel.Location = new System.Drawing.Point(179, 37);
            this.ulToPayGasLabel.Name = "ulToPayGasLabel";
            this.ulToPayGasLabel.Size = new System.Drawing.Size(32, 17);
            this.ulToPayGasLabel.TabIndex = 10;
            this.ulToPayGasLabel.Text = "uah";
            // 
            // lCountGasStationLabel
            // 
            this.lCountGasStationLabel.AutoSize = true;
            this.lCountGasStationLabel.Location = new System.Drawing.Point(241, 155);
            this.lCountGasStationLabel.Name = "lCountGasStationLabel";
            this.lCountGasStationLabel.Size = new System.Drawing.Size(10, 15);
            this.lCountGasStationLabel.TabIndex = 9;
            this.lCountGasStationLabel.Text = "l";
            // 
            // uahSubGasStationLabel
            // 
            this.uahSubGasStationLabel.AutoSize = true;
            this.uahSubGasStationLabel.Location = new System.Drawing.Point(241, 194);
            this.uahSubGasStationLabel.Name = "uahSubGasStationLabel";
            this.uahSubGasStationLabel.Size = new System.Drawing.Size(28, 15);
            this.uahSubGasStationLabel.TabIndex = 8;
            this.uahSubGasStationLabel.Text = "uah";
            // 
            // countSumPanel
            // 
            this.countSumPanel.Controls.Add(this.sumGasRadioButton);
            this.countSumPanel.Controls.Add(this.countGasRadioButton);
            this.countSumPanel.Location = new System.Drawing.Point(6, 146);
            this.countSumPanel.Name = "countSumPanel";
            this.countSumPanel.Size = new System.Drawing.Size(144, 70);
            this.countSumPanel.TabIndex = 0;
            // 
            // sumGasRadioButton
            // 
            this.sumGasRadioButton.AutoSize = true;
            this.sumGasRadioButton.Location = new System.Drawing.Point(12, 43);
            this.sumGasRadioButton.Name = "sumGasRadioButton";
            this.sumGasRadioButton.Size = new System.Drawing.Size(51, 19);
            this.sumGasRadioButton.TabIndex = 4;
            this.sumGasRadioButton.Text = "Sum";
            this.sumGasRadioButton.UseVisualStyleBackColor = true;
            this.sumGasRadioButton.CheckedChanged += new System.EventHandler(this.CountRadioButton_CheckedChanged);
            // 
            // countGasRadioButton
            // 
            this.countGasRadioButton.AutoSize = true;
            this.countGasRadioButton.Checked = true;
            this.countGasRadioButton.Location = new System.Drawing.Point(12, 9);
            this.countGasRadioButton.Name = "countGasRadioButton";
            this.countGasRadioButton.Size = new System.Drawing.Size(57, 19);
            this.countGasRadioButton.TabIndex = 3;
            this.countGasRadioButton.TabStop = true;
            this.countGasRadioButton.Text = "Count";
            this.countGasRadioButton.UseVisualStyleBackColor = true;
            this.countGasRadioButton.CheckedChanged += new System.EventHandler(this.CountRadioButton_CheckedChanged);
            // 
            // uahGasStationLabel
            // 
            this.uahGasStationLabel.AutoSize = true;
            this.uahGasStationLabel.Location = new System.Drawing.Point(241, 106);
            this.uahGasStationLabel.Name = "uahGasStationLabel";
            this.uahGasStationLabel.Size = new System.Drawing.Size(28, 15);
            this.uahGasStationLabel.TabIndex = 5;
            this.uahGasStationLabel.Text = "uah";
            // 
            // pricePetrolTextBox
            // 
            this.pricePetrolTextBox.Enabled = false;
            this.pricePetrolTextBox.Location = new System.Drawing.Point(75, 98);
            this.pricePetrolTextBox.Name = "pricePetrolTextBox";
            this.pricePetrolTextBox.ReadOnly = true;
            this.pricePetrolTextBox.Size = new System.Drawing.Size(164, 21);
            this.pricePetrolTextBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(15, 102);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(35, 15);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price";
            // 
            // petrolLabel
            // 
            this.petrolLabel.AutoSize = true;
            this.petrolLabel.Location = new System.Drawing.Point(15, 55);
            this.petrolLabel.Name = "petrolLabel";
            this.petrolLabel.Size = new System.Drawing.Size(39, 15);
            this.petrolLabel.TabIndex = 3;
            this.petrolLabel.Text = "Petrol";
            // 
            // petrolComboBox
            // 
            this.petrolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.petrolComboBox.FormattingEnabled = true;
            this.petrolComboBox.Location = new System.Drawing.Point(75, 51);
            this.petrolComboBox.Name = "petrolComboBox";
            this.petrolComboBox.Size = new System.Drawing.Size(164, 23);
            this.petrolComboBox.TabIndex = 0;
            this.petrolComboBox.SelectionChangeCommitted += new System.EventHandler(this.PetrolComboBox_SelectionChangeCommitted);
            // 
            // cafeGroupBox
            // 
            this.cafeGroupBox.Controls.Add(this.countCocaColaNumericUpDown);
            this.cafeGroupBox.Controls.Add(this.countFrenchFriesNumericUpDown);
            this.cafeGroupBox.Controls.Add(this.countHamburgerNumericUpDown);
            this.cafeGroupBox.Controls.Add(this.countHotdogNumericUpDown);
            this.cafeGroupBox.Controls.Add(this.CountCafeLabel);
            this.cafeGroupBox.Controls.Add(this.PriceCafeLabel);
            this.cafeGroupBox.Controls.Add(this.priceCocaColaTextBox);
            this.cafeGroupBox.Controls.Add(this.priceFrenchFriesTextBox);
            this.cafeGroupBox.Controls.Add(this.priceHamburgerTextBox);
            this.cafeGroupBox.Controls.Add(this.priceHotDogTextBox);
            this.cafeGroupBox.Controls.Add(this.cocaColaCheckBox);
            this.cafeGroupBox.Controls.Add(this.frenchFriesCheckBox);
            this.cafeGroupBox.Controls.Add(this.hamburgerCheckBox);
            this.cafeGroupBox.Controls.Add(this.hotDogCheckBox);
            this.cafeGroupBox.Controls.Add(this.ToPayCafeGroupBox);
            this.cafeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cafeGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cafeGroupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cafeGroupBox.Location = new System.Drawing.Point(324, 28);
            this.cafeGroupBox.Name = "cafeGroupBox";
            this.cafeGroupBox.Size = new System.Drawing.Size(281, 315);
            this.cafeGroupBox.TabIndex = 1;
            this.cafeGroupBox.TabStop = false;
            this.cafeGroupBox.Text = "Mini-Cafe";
            // 
            // countCocaColaNumericUpDown
            // 
            this.countCocaColaNumericUpDown.Enabled = false;
            this.countCocaColaNumericUpDown.Location = new System.Drawing.Point(211, 190);
            this.countCocaColaNumericUpDown.Name = "countCocaColaNumericUpDown";
            this.countCocaColaNumericUpDown.ReadOnly = true;
            this.countCocaColaNumericUpDown.Size = new System.Drawing.Size(61, 21);
            this.countCocaColaNumericUpDown.TabIndex = 20;
            this.countCocaColaNumericUpDown.ValueChanged += new System.EventHandler(this.ToPayCafe);
            // 
            // countFrenchFriesNumericUpDown
            // 
            this.countFrenchFriesNumericUpDown.Enabled = false;
            this.countFrenchFriesNumericUpDown.Location = new System.Drawing.Point(211, 145);
            this.countFrenchFriesNumericUpDown.Name = "countFrenchFriesNumericUpDown";
            this.countFrenchFriesNumericUpDown.ReadOnly = true;
            this.countFrenchFriesNumericUpDown.Size = new System.Drawing.Size(61, 21);
            this.countFrenchFriesNumericUpDown.TabIndex = 19;
            this.countFrenchFriesNumericUpDown.ValueChanged += new System.EventHandler(this.ToPayCafe);
            // 
            // countHamburgerNumericUpDown
            // 
            this.countHamburgerNumericUpDown.Enabled = false;
            this.countHamburgerNumericUpDown.Location = new System.Drawing.Point(211, 100);
            this.countHamburgerNumericUpDown.Name = "countHamburgerNumericUpDown";
            this.countHamburgerNumericUpDown.ReadOnly = true;
            this.countHamburgerNumericUpDown.Size = new System.Drawing.Size(61, 21);
            this.countHamburgerNumericUpDown.TabIndex = 18;
            this.countHamburgerNumericUpDown.ValueChanged += new System.EventHandler(this.ToPayCafe);
            // 
            // countHotdogNumericUpDown
            // 
            this.countHotdogNumericUpDown.Enabled = false;
            this.countHotdogNumericUpDown.Location = new System.Drawing.Point(211, 55);
            this.countHotdogNumericUpDown.Name = "countHotdogNumericUpDown";
            this.countHotdogNumericUpDown.ReadOnly = true;
            this.countHotdogNumericUpDown.Size = new System.Drawing.Size(61, 21);
            this.countHotdogNumericUpDown.TabIndex = 17;
            this.countHotdogNumericUpDown.ValueChanged += new System.EventHandler(this.ToPayCafe);
            // 
            // CountCafeLabel
            // 
            this.CountCafeLabel.AutoSize = true;
            this.CountCafeLabel.Location = new System.Drawing.Point(224, 25);
            this.CountCafeLabel.Name = "CountCafeLabel";
            this.CountCafeLabel.Size = new System.Drawing.Size(39, 15);
            this.CountCafeLabel.TabIndex = 17;
            this.CountCafeLabel.Text = "Count";
            // 
            // PriceCafeLabel
            // 
            this.PriceCafeLabel.AutoSize = true;
            this.PriceCafeLabel.Location = new System.Drawing.Point(134, 25);
            this.PriceCafeLabel.Name = "PriceCafeLabel";
            this.PriceCafeLabel.Size = new System.Drawing.Size(35, 15);
            this.PriceCafeLabel.TabIndex = 10;
            this.PriceCafeLabel.Text = "Price";
            // 
            // priceCocaColaTextBox
            // 
            this.priceCocaColaTextBox.Location = new System.Drawing.Point(123, 190);
            this.priceCocaColaTextBox.Name = "priceCocaColaTextBox";
            this.priceCocaColaTextBox.ReadOnly = true;
            this.priceCocaColaTextBox.Size = new System.Drawing.Size(56, 21);
            this.priceCocaColaTextBox.TabIndex = 13;
            this.priceCocaColaTextBox.Text = "15,50";
            this.priceCocaColaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceFrenchFriesTextBox
            // 
            this.priceFrenchFriesTextBox.Location = new System.Drawing.Point(123, 145);
            this.priceFrenchFriesTextBox.Name = "priceFrenchFriesTextBox";
            this.priceFrenchFriesTextBox.ReadOnly = true;
            this.priceFrenchFriesTextBox.Size = new System.Drawing.Size(56, 21);
            this.priceFrenchFriesTextBox.TabIndex = 12;
            this.priceFrenchFriesTextBox.Text = "25,20";
            this.priceFrenchFriesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceHamburgerTextBox
            // 
            this.priceHamburgerTextBox.Location = new System.Drawing.Point(123, 100);
            this.priceHamburgerTextBox.Name = "priceHamburgerTextBox";
            this.priceHamburgerTextBox.ReadOnly = true;
            this.priceHamburgerTextBox.Size = new System.Drawing.Size(56, 21);
            this.priceHamburgerTextBox.TabIndex = 11;
            this.priceHamburgerTextBox.Text = "20,00";
            this.priceHamburgerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceHotDogTextBox
            // 
            this.priceHotDogTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.priceHotDogTextBox.Location = new System.Drawing.Point(123, 55);
            this.priceHotDogTextBox.Name = "priceHotDogTextBox";
            this.priceHotDogTextBox.ReadOnly = true;
            this.priceHotDogTextBox.Size = new System.Drawing.Size(56, 21);
            this.priceHotDogTextBox.TabIndex = 10;
            this.priceHotDogTextBox.Text = "17,20";
            this.priceHotDogTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cocaColaCheckBox
            // 
            this.cocaColaCheckBox.AutoSize = true;
            this.cocaColaCheckBox.Location = new System.Drawing.Point(6, 190);
            this.cocaColaCheckBox.Name = "cocaColaCheckBox";
            this.cocaColaCheckBox.Size = new System.Drawing.Size(83, 19);
            this.cocaColaCheckBox.TabIndex = 8;
            this.cocaColaCheckBox.Tag = "15,50";
            this.cocaColaCheckBox.Text = "Coca-Cola";
            this.cocaColaCheckBox.UseVisualStyleBackColor = true;
            this.cocaColaCheckBox.CheckedChanged += new System.EventHandler(this.cocaColaCheckBox_CheckedChanged);
            // 
            // frenchFriesCheckBox
            // 
            this.frenchFriesCheckBox.AutoSize = true;
            this.frenchFriesCheckBox.Location = new System.Drawing.Point(6, 145);
            this.frenchFriesCheckBox.Name = "frenchFriesCheckBox";
            this.frenchFriesCheckBox.Size = new System.Drawing.Size(90, 19);
            this.frenchFriesCheckBox.TabIndex = 7;
            this.frenchFriesCheckBox.Tag = "25,20";
            this.frenchFriesCheckBox.Text = "French fries";
            this.frenchFriesCheckBox.UseVisualStyleBackColor = true;
            this.frenchFriesCheckBox.CheckedChanged += new System.EventHandler(this.frenchFriesCheckBox_CheckedChanged);
            // 
            // hamburgerCheckBox
            // 
            this.hamburgerCheckBox.AutoSize = true;
            this.hamburgerCheckBox.Location = new System.Drawing.Point(6, 100);
            this.hamburgerCheckBox.Name = "hamburgerCheckBox";
            this.hamburgerCheckBox.Size = new System.Drawing.Size(89, 19);
            this.hamburgerCheckBox.TabIndex = 6;
            this.hamburgerCheckBox.Tag = "20,00";
            this.hamburgerCheckBox.Text = "Hamburger";
            this.hamburgerCheckBox.UseVisualStyleBackColor = true;
            this.hamburgerCheckBox.CheckedChanged += new System.EventHandler(this.hamburgerCheckBox_CheckedChanged);
            // 
            // hotDogCheckBox
            // 
            this.hotDogCheckBox.AutoSize = true;
            this.hotDogCheckBox.Location = new System.Drawing.Point(6, 55);
            this.hotDogCheckBox.Name = "hotDogCheckBox";
            this.hotDogCheckBox.Size = new System.Drawing.Size(70, 19);
            this.hotDogCheckBox.TabIndex = 5;
            this.hotDogCheckBox.Tag = "17,20";
            this.hotDogCheckBox.Text = "Hot-dog";
            this.hotDogCheckBox.UseVisualStyleBackColor = true;
            this.hotDogCheckBox.CheckedChanged += new System.EventHandler(this.hotDogCheckBox_CheckedChanged);
            // 
            // ToPayCafeGroupBox
            // 
            this.ToPayCafeGroupBox.Controls.Add(this.ToPayCafeLabel);
            this.ToPayCafeGroupBox.Controls.Add(this.ulToPayCafeLabel);
            this.ToPayCafeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToPayCafeGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ToPayCafeGroupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ToPayCafeGroupBox.Location = new System.Drawing.Point(6, 241);
            this.ToPayCafeGroupBox.Name = "ToPayCafeGroupBox";
            this.ToPayCafeGroupBox.Size = new System.Drawing.Size(266, 64);
            this.ToPayCafeGroupBox.TabIndex = 4;
            this.ToPayCafeGroupBox.TabStop = false;
            this.ToPayCafeGroupBox.Text = "To pay";
            // 
            // ToPayCafeLabel
            // 
            this.ToPayCafeLabel.AutoSize = true;
            this.ToPayCafeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToPayCafeLabel.Location = new System.Drawing.Point(66, 16);
            this.ToPayCafeLabel.MinimumSize = new System.Drawing.Size(100, 40);
            this.ToPayCafeLabel.Name = "ToPayCafeLabel";
            this.ToPayCafeLabel.Size = new System.Drawing.Size(100, 40);
            this.ToPayCafeLabel.TabIndex = 14;
            this.ToPayCafeLabel.Text = "0,00";
            this.ToPayCafeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ulToPayCafeLabel
            // 
            this.ulToPayCafeLabel.AutoSize = true;
            this.ulToPayCafeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ulToPayCafeLabel.Location = new System.Drawing.Point(182, 37);
            this.ulToPayCafeLabel.Name = "ulToPayCafeLabel";
            this.ulToPayCafeLabel.Size = new System.Drawing.Size(32, 17);
            this.ulToPayCafeLabel.TabIndex = 12;
            this.ulToPayCafeLabel.Text = "uah";
            // 
            // totalToPayGroupBox
            // 
            this.totalToPayGroupBox.Controls.Add(this.pictureBox1);
            this.totalToPayGroupBox.Controls.Add(this.calculateButton);
            this.totalToPayGroupBox.Controls.Add(this.ulTotalToPay);
            this.totalToPayGroupBox.Controls.Add(this.ToPayLabel);
            this.totalToPayGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalToPayGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.totalToPayGroupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.totalToPayGroupBox.Location = new System.Drawing.Point(24, 359);
            this.totalToPayGroupBox.Name = "totalToPayGroupBox";
            this.totalToPayGroupBox.Size = new System.Drawing.Size(581, 172);
            this.totalToPayGroupBox.TabIndex = 2;
            this.totalToPayGroupBox.TabStop = false;
            this.totalToPayGroupBox.Text = "Total to pay";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(156, 82);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(150, 56);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // ulTotalToPay
            // 
            this.ulTotalToPay.AutoSize = true;
            this.ulTotalToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ulTotalToPay.Location = new System.Drawing.Point(487, 125);
            this.ulTotalToPay.Name = "ulTotalToPay";
            this.ulTotalToPay.Size = new System.Drawing.Size(32, 17);
            this.ulTotalToPay.TabIndex = 13;
            this.ulTotalToPay.Text = "uah";
            // 
            // ToPayLabel
            // 
            this.ToPayLabel.AutoSize = true;
            this.ToPayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToPayLabel.Location = new System.Drawing.Point(354, 98);
            this.ToPayLabel.MinimumSize = new System.Drawing.Size(100, 40);
            this.ToPayLabel.Name = "ToPayLabel";
            this.ToPayLabel.Size = new System.Drawing.Size(100, 40);
            this.ToPayLabel.TabIndex = 12;
            this.ToPayLabel.Text = "0,00";
            this.ToPayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.unnamed;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(18, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 544);
            this.Controls.Add(this.totalToPayGroupBox);
            this.Controls.Add(this.cafeGroupBox);
            this.Controls.Add(this.gaseStationGroupBox);
            this.Name = "Form1";
            this.Text = "Best Oil";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.gaseStationGroupBox.ResumeLayout(false);
            this.gaseStationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumGasNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countGasNumericUpDown)).EndInit();
            this.toPayGasGroupBox.ResumeLayout(false);
            this.toPayGasGroupBox.PerformLayout();
            this.countSumPanel.ResumeLayout(false);
            this.countSumPanel.PerformLayout();
            this.cafeGroupBox.ResumeLayout(false);
            this.cafeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countCocaColaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countFrenchFriesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countHamburgerNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countHotdogNumericUpDown)).EndInit();
            this.ToPayCafeGroupBox.ResumeLayout(false);
            this.ToPayCafeGroupBox.PerformLayout();
            this.totalToPayGroupBox.ResumeLayout(false);
            this.totalToPayGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gaseStationGroupBox;
        private System.Windows.Forms.Label uahGasStationLabel;
        private System.Windows.Forms.TextBox pricePetrolTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label petrolLabel;
        private System.Windows.Forms.ComboBox petrolComboBox;
        private System.Windows.Forms.GroupBox cafeGroupBox;
        private System.Windows.Forms.GroupBox totalToPayGroupBox;
        private System.Windows.Forms.Panel countSumPanel;
        private System.Windows.Forms.RadioButton sumGasRadioButton;
        private System.Windows.Forms.RadioButton countGasRadioButton;
        private System.Windows.Forms.Label lCountGasStationLabel;
        private System.Windows.Forms.Label uahSubGasStationLabel;
        private System.Windows.Forms.GroupBox toPayGasGroupBox;
        private System.Windows.Forms.TextBox priceHotDogTextBox;
        private System.Windows.Forms.CheckBox cocaColaCheckBox;
        private System.Windows.Forms.CheckBox frenchFriesCheckBox;
        private System.Windows.Forms.CheckBox hamburgerCheckBox;
        private System.Windows.Forms.CheckBox hotDogCheckBox;
        private System.Windows.Forms.GroupBox ToPayCafeGroupBox;
        private System.Windows.Forms.Label CountCafeLabel;
        private System.Windows.Forms.Label PriceCafeLabel;
        private System.Windows.Forms.TextBox priceCocaColaTextBox;
        private System.Windows.Forms.TextBox priceFrenchFriesTextBox;
        private System.Windows.Forms.TextBox priceHamburgerTextBox;
        private System.Windows.Forms.Label toPayGasStationLabel;
        private System.Windows.Forms.Label ulToPayGasLabel;
        private System.Windows.Forms.Label ulToPayCafeLabel;
        private System.Windows.Forms.Label ToPayLabel;
        private System.Windows.Forms.Label ToPayCafeLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label ulTotalToPay;
        private System.Windows.Forms.NumericUpDown sumGasNumericUpDown;
        private System.Windows.Forms.NumericUpDown countGasNumericUpDown;
        private System.Windows.Forms.NumericUpDown countCocaColaNumericUpDown;
        private System.Windows.Forms.NumericUpDown countFrenchFriesNumericUpDown;
        private System.Windows.Forms.NumericUpDown countHamburgerNumericUpDown;
        private System.Windows.Forms.NumericUpDown countHotdogNumericUpDown;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

