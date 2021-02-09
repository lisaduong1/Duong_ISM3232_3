namespace Duong_3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxBalloon = new System.Windows.Forms.PictureBox();
            this.labelCompany = new System.Windows.Forms.Label();
            this.groupBoxCusInfo = new System.Windows.Forms.GroupBox();
            this.textBoxZip = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelZip = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.comboBoxTitle = new System.Windows.Forms.ComboBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxDeliveInfo = new System.Windows.Forms.GroupBox();
            this.labelDeliveryPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonDelivery = new System.Windows.Forms.RadioButton();
            this.radioButtonStore = new System.Windows.Forms.RadioButton();
            this.maskedTextBoxDelivery = new System.Windows.Forms.MaskedTextBox();
            this.labelDeliveryDate = new System.Windows.Forms.Label();
            this.groupBoxOrderInfo = new System.Windows.Forms.GroupBox();
            this.labelOccasions = new System.Windows.Forms.Label();
            this.labelMaxLimit = new System.Windows.Forms.Label();
            this.textBoxPersonalMessage = new System.Windows.Forms.TextBox();
            this.labelMessagePrice = new System.Windows.Forms.Label();
            this.checkBoxMessage = new System.Windows.Forms.CheckBox();
            this.labelExtraInfo = new System.Windows.Forms.Label();
            this.labelExtras = new System.Windows.Forms.Label();
            this.listBoxExtras = new System.Windows.Forms.ListBox();
            this.comboBoxOccasions = new System.Windows.Forms.ComboBox();
            this.labelDozenPrice = new System.Windows.Forms.Label();
            this.labelHalfDozenPrice = new System.Windows.Forms.Label();
            this.labelSinglePrice = new System.Windows.Forms.Label();
            this.radioButtonDozen = new System.Windows.Forms.RadioButton();
            this.radioButtonHalfDozen = new System.Windows.Forms.RadioButton();
            this.radioButtonSingle = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelOrderTotalAmount = new System.Windows.Forms.Label();
            this.labelOrderTotal = new System.Windows.Forms.Label();
            this.labelSalesTaxAmount = new System.Windows.Forms.Label();
            this.labelSalesTax = new System.Windows.Forms.Label();
            this.labelSubtotalAmount = new System.Windows.Forms.Label();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.buttonSummary = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTipSummary = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipClear = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipExit = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBalloon)).BeginInit();
            this.groupBoxCusInfo.SuspendLayout();
            this.groupBoxDeliveInfo.SuspendLayout();
            this.groupBoxOrderInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBalloon
            // 
            this.pictureBoxBalloon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBalloon.Image")));
            this.pictureBoxBalloon.Location = new System.Drawing.Point(51, 12);
            this.pictureBoxBalloon.Name = "pictureBoxBalloon";
            this.pictureBoxBalloon.Size = new System.Drawing.Size(303, 123);
            this.pictureBoxBalloon.TabIndex = 0;
            this.pictureBoxBalloon.TabStop = false;
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCompany.Font = new System.Drawing.Font("Lucida Handwriting", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompany.Location = new System.Drawing.Point(382, 44);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(404, 51);
            this.labelCompany.TabIndex = 1;
            this.labelCompany.Text = "Bonnie\'s Balloons";
            this.labelCompany.Click += new System.EventHandler(this.labelCompany_Click);
            // 
            // groupBoxCusInfo
            // 
            this.groupBoxCusInfo.Controls.Add(this.textBoxZip);
            this.groupBoxCusInfo.Controls.Add(this.maskedTextBoxPhone);
            this.groupBoxCusInfo.Controls.Add(this.labelPhone);
            this.groupBoxCusInfo.Controls.Add(this.labelZip);
            this.groupBoxCusInfo.Controls.Add(this.textBoxState);
            this.groupBoxCusInfo.Controls.Add(this.textBoxCity);
            this.groupBoxCusInfo.Controls.Add(this.textBoxStreet);
            this.groupBoxCusInfo.Controls.Add(this.textBoxLastName);
            this.groupBoxCusInfo.Controls.Add(this.textBoxFirstName);
            this.groupBoxCusInfo.Controls.Add(this.labelState);
            this.groupBoxCusInfo.Controls.Add(this.labelCity);
            this.groupBoxCusInfo.Controls.Add(this.labelStreet);
            this.groupBoxCusInfo.Controls.Add(this.labelLastName);
            this.groupBoxCusInfo.Controls.Add(this.labelFirstName);
            this.groupBoxCusInfo.Controls.Add(this.comboBoxTitle);
            this.groupBoxCusInfo.Controls.Add(this.labelTitle);
            this.groupBoxCusInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxCusInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCusInfo.Location = new System.Drawing.Point(12, 141);
            this.groupBoxCusInfo.Name = "groupBoxCusInfo";
            this.groupBoxCusInfo.Size = new System.Drawing.Size(832, 170);
            this.groupBoxCusInfo.TabIndex = 2;
            this.groupBoxCusInfo.TabStop = false;
            this.groupBoxCusInfo.Text = "Customer Information";
            // 
            // textBoxZip
            // 
            this.textBoxZip.Location = new System.Drawing.Point(589, 97);
            this.textBoxZip.MaxLength = 5;
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(100, 28);
            this.textBoxZip.TabIndex = 13;
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(589, 131);
            this.maskedTextBoxPhone.Mask = "(999) 000-0000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(141, 28);
            this.maskedTextBoxPhone.TabIndex = 15;
            this.maskedTextBoxPhone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxPhone_MaskInputRejected);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(441, 136);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(120, 20);
            this.labelPhone.TabIndex = 14;
            this.labelPhone.Text = "Phone Number";
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZip.Location = new System.Drawing.Point(441, 102);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(31, 20);
            this.labelZip.TabIndex = 12;
            this.labelZip.Text = "Zip";
            // 
            // textBoxState
            // 
            this.textBoxState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxState.Location = new System.Drawing.Point(589, 63);
            this.textBoxState.MaxLength = 2;
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(54, 28);
            this.textBoxState.TabIndex = 11;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(589, 29);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(210, 28);
            this.textBoxCity.TabIndex = 9;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(153, 128);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(210, 28);
            this.textBoxStreet.TabIndex = 7;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(153, 94);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(210, 28);
            this.textBoxLastName.TabIndex = 5;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(153, 60);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(210, 28);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.Location = new System.Drawing.Point(441, 65);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(48, 20);
            this.labelState.TabIndex = 10;
            this.labelState.Text = "State";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(441, 34);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(38, 20);
            this.labelCity.TabIndex = 8;
            this.labelCity.Text = "City";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStreet.Location = new System.Drawing.Point(27, 136);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(54, 20);
            this.labelStreet.TabIndex = 6;
            this.labelStreet.Text = "Street";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(27, 102);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(91, 20);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(26, 68);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(92, 20);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "First Name";
            // 
            // comboBoxTitle
            // 
            this.comboBoxTitle.FormattingEnabled = true;
            this.comboBoxTitle.Items.AddRange(new object[] {
            "Dr.",
            "Mr.",
            "Mrs.",
            "Ms.",
            "Rev."});
            this.comboBoxTitle.Location = new System.Drawing.Point(154, 24);
            this.comboBoxTitle.Name = "comboBoxTitle";
            this.comboBoxTitle.Size = new System.Drawing.Size(117, 30);
            this.comboBoxTitle.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(27, 32);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(41, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // groupBoxDeliveInfo
            // 
            this.groupBoxDeliveInfo.Controls.Add(this.labelDeliveryPrice);
            this.groupBoxDeliveInfo.Controls.Add(this.label1);
            this.groupBoxDeliveInfo.Controls.Add(this.radioButtonDelivery);
            this.groupBoxDeliveInfo.Controls.Add(this.radioButtonStore);
            this.groupBoxDeliveInfo.Controls.Add(this.maskedTextBoxDelivery);
            this.groupBoxDeliveInfo.Controls.Add(this.labelDeliveryDate);
            this.groupBoxDeliveInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDeliveInfo.Location = new System.Drawing.Point(12, 317);
            this.groupBoxDeliveInfo.Name = "groupBoxDeliveInfo";
            this.groupBoxDeliveInfo.Size = new System.Drawing.Size(832, 80);
            this.groupBoxDeliveInfo.TabIndex = 16;
            this.groupBoxDeliveInfo.TabStop = false;
            this.groupBoxDeliveInfo.Text = "Delivery Information";
            // 
            // labelDeliveryPrice
            // 
            this.labelDeliveryPrice.AutoSize = true;
            this.labelDeliveryPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeliveryPrice.Location = new System.Drawing.Point(697, 48);
            this.labelDeliveryPrice.Name = "labelDeliveryPrice";
            this.labelDeliveryPrice.Size = new System.Drawing.Size(93, 20);
            this.labelDeliveryPrice.TabIndex = 22;
            this.labelDeliveryPrice.Text = "Extra $7.50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Delivery type";
            // 
            // radioButtonDelivery
            // 
            this.radioButtonDelivery.AutoSize = true;
            this.radioButtonDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDelivery.Location = new System.Drawing.Point(514, 46);
            this.radioButtonDelivery.Name = "radioButtonDelivery";
            this.radioButtonDelivery.Size = new System.Drawing.Size(141, 24);
            this.radioButtonDelivery.TabIndex = 21;
            this.radioButtonDelivery.Text = "Home Delivery";
            this.radioButtonDelivery.UseVisualStyleBackColor = true;
            this.radioButtonDelivery.CheckedChanged += new System.EventHandler(this.checkChange);
            // 
            // radioButtonStore
            // 
            this.radioButtonStore.AutoSize = true;
            this.radioButtonStore.Checked = true;
            this.radioButtonStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonStore.Location = new System.Drawing.Point(514, 16);
            this.radioButtonStore.Name = "radioButtonStore";
            this.radioButtonStore.Size = new System.Drawing.Size(134, 24);
            this.radioButtonStore.TabIndex = 20;
            this.radioButtonStore.TabStop = true;
            this.radioButtonStore.Text = "Store Pick-Up";
            this.radioButtonStore.UseVisualStyleBackColor = true;
            this.radioButtonStore.CheckedChanged += new System.EventHandler(this.checkChange);
            // 
            // maskedTextBoxDelivery
            // 
            this.maskedTextBoxDelivery.Location = new System.Drawing.Point(154, 43);
            this.maskedTextBoxDelivery.Mask = "(00/00/0000)";
            this.maskedTextBoxDelivery.Name = "maskedTextBoxDelivery";
            this.maskedTextBoxDelivery.Size = new System.Drawing.Size(127, 28);
            this.maskedTextBoxDelivery.TabIndex = 18;
            this.maskedTextBoxDelivery.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDelivery.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxDelivery_MaskInputRejected);
            // 
            // labelDeliveryDate
            // 
            this.labelDeliveryDate.AutoSize = true;
            this.labelDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeliveryDate.Location = new System.Drawing.Point(26, 49);
            this.labelDeliveryDate.Name = "labelDeliveryDate";
            this.labelDeliveryDate.Size = new System.Drawing.Size(111, 20);
            this.labelDeliveryDate.TabIndex = 17;
            this.labelDeliveryDate.Text = "Delivery Date";
            // 
            // groupBoxOrderInfo
            // 
            this.groupBoxOrderInfo.Controls.Add(this.labelOccasions);
            this.groupBoxOrderInfo.Controls.Add(this.labelMaxLimit);
            this.groupBoxOrderInfo.Controls.Add(this.textBoxPersonalMessage);
            this.groupBoxOrderInfo.Controls.Add(this.labelMessagePrice);
            this.groupBoxOrderInfo.Controls.Add(this.checkBoxMessage);
            this.groupBoxOrderInfo.Controls.Add(this.labelExtraInfo);
            this.groupBoxOrderInfo.Controls.Add(this.labelExtras);
            this.groupBoxOrderInfo.Controls.Add(this.listBoxExtras);
            this.groupBoxOrderInfo.Controls.Add(this.comboBoxOccasions);
            this.groupBoxOrderInfo.Controls.Add(this.labelDozenPrice);
            this.groupBoxOrderInfo.Controls.Add(this.labelHalfDozenPrice);
            this.groupBoxOrderInfo.Controls.Add(this.labelSinglePrice);
            this.groupBoxOrderInfo.Controls.Add(this.radioButtonDozen);
            this.groupBoxOrderInfo.Controls.Add(this.radioButtonHalfDozen);
            this.groupBoxOrderInfo.Controls.Add(this.radioButtonSingle);
            this.groupBoxOrderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOrderInfo.Location = new System.Drawing.Point(13, 403);
            this.groupBoxOrderInfo.Name = "groupBoxOrderInfo";
            this.groupBoxOrderInfo.Size = new System.Drawing.Size(831, 203);
            this.groupBoxOrderInfo.TabIndex = 22;
            this.groupBoxOrderInfo.TabStop = false;
            this.groupBoxOrderInfo.Text = "Order Details";
            // 
            // labelOccasions
            // 
            this.labelOccasions.AutoSize = true;
            this.labelOccasions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOccasions.Location = new System.Drawing.Point(492, 161);
            this.labelOccasions.Name = "labelOccasions";
            this.labelOccasions.Size = new System.Drawing.Size(94, 20);
            this.labelOccasions.TabIndex = 37;
            this.labelOccasions.Text = "Occasions:";
            // 
            // labelMaxLimit
            // 
            this.labelMaxLimit.AutoSize = true;
            this.labelMaxLimit.Enabled = false;
            this.labelMaxLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxLimit.Location = new System.Drawing.Point(26, 145);
            this.labelMaxLimit.Name = "labelMaxLimit";
            this.labelMaxLimit.Size = new System.Drawing.Size(203, 20);
            this.labelMaxLimit.TabIndex = 36;
            this.labelMaxLimit.Text = "Max limit of 30 characters";
            // 
            // textBoxPersonalMessage
            // 
            this.textBoxPersonalMessage.Enabled = false;
            this.textBoxPersonalMessage.Location = new System.Drawing.Point(29, 168);
            this.textBoxPersonalMessage.MaxLength = 30;
            this.textBoxPersonalMessage.Name = "textBoxPersonalMessage";
            this.textBoxPersonalMessage.Size = new System.Drawing.Size(390, 28);
            this.textBoxPersonalMessage.TabIndex = 35;
            this.textBoxPersonalMessage.TextChanged += new System.EventHandler(this.textBoxPersonalMessage_TextChanged);
            // 
            // labelMessagePrice
            // 
            this.labelMessagePrice.AutoSize = true;
            this.labelMessagePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessagePrice.Location = new System.Drawing.Point(305, 119);
            this.labelMessagePrice.Name = "labelMessagePrice";
            this.labelMessagePrice.Size = new System.Drawing.Size(93, 20);
            this.labelMessagePrice.TabIndex = 34;
            this.labelMessagePrice.Text = "Extra $2.50";
            // 
            // checkBoxMessage
            // 
            this.checkBoxMessage.AutoSize = true;
            this.checkBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMessage.Location = new System.Drawing.Point(29, 118);
            this.checkBoxMessage.Name = "checkBoxMessage";
            this.checkBoxMessage.Size = new System.Drawing.Size(239, 24);
            this.checkBoxMessage.TabIndex = 33;
            this.checkBoxMessage.Text = "Personalized message card";
            this.checkBoxMessage.UseVisualStyleBackColor = true;
            this.checkBoxMessage.CheckedChanged += new System.EventHandler(this.checkChange);
            // 
            // labelExtraInfo
            // 
            this.labelExtraInfo.AutoSize = true;
            this.labelExtraInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExtraInfo.Location = new System.Drawing.Point(654, 24);
            this.labelExtraInfo.Name = "labelExtraInfo";
            this.labelExtraInfo.Size = new System.Drawing.Size(135, 40);
            this.labelExtraInfo.TabIndex = 31;
            this.labelExtraInfo.Text = "Each extra is an \r\nadditional $9.50";
            // 
            // labelExtras
            // 
            this.labelExtras.AutoSize = true;
            this.labelExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExtras.Location = new System.Drawing.Point(654, 87);
            this.labelExtras.Name = "labelExtras";
            this.labelExtras.Size = new System.Drawing.Size(0, 20);
            this.labelExtras.TabIndex = 32;
            // 
            // listBoxExtras
            // 
            this.listBoxExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxExtras.FormattingEnabled = true;
            this.listBoxExtras.ItemHeight = 20;
            this.listBoxExtras.Location = new System.Drawing.Point(444, 24);
            this.listBoxExtras.Name = "listBoxExtras";
            this.listBoxExtras.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxExtras.Size = new System.Drawing.Size(186, 124);
            this.listBoxExtras.Sorted = true;
            this.listBoxExtras.TabIndex = 30;
            this.listBoxExtras.SelectedIndexChanged += new System.EventHandler(this.checkChange);
            // 
            // comboBoxOccasions
            // 
            this.comboBoxOccasions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOccasions.FormattingEnabled = true;
            this.comboBoxOccasions.Location = new System.Drawing.Point(623, 156);
            this.comboBoxOccasions.Name = "comboBoxOccasions";
            this.comboBoxOccasions.Size = new System.Drawing.Size(180, 30);
            this.comboBoxOccasions.Sorted = true;
            this.comboBoxOccasions.TabIndex = 29;
            this.comboBoxOccasions.SelectedIndexChanged += new System.EventHandler(this.comboBoxOccasions_SelectedIndexChanged);
            // 
            // labelDozenPrice
            // 
            this.labelDozenPrice.AutoSize = true;
            this.labelDozenPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDozenPrice.Location = new System.Drawing.Point(158, 89);
            this.labelDozenPrice.Name = "labelDozenPrice";
            this.labelDozenPrice.Size = new System.Drawing.Size(0, 20);
            this.labelDozenPrice.TabIndex = 28;
            // 
            // labelHalfDozenPrice
            // 
            this.labelHalfDozenPrice.AutoSize = true;
            this.labelHalfDozenPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHalfDozenPrice.Location = new System.Drawing.Point(158, 59);
            this.labelHalfDozenPrice.Name = "labelHalfDozenPrice";
            this.labelHalfDozenPrice.Size = new System.Drawing.Size(0, 20);
            this.labelHalfDozenPrice.TabIndex = 26;
            // 
            // labelSinglePrice
            // 
            this.labelSinglePrice.AutoSize = true;
            this.labelSinglePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSinglePrice.Location = new System.Drawing.Point(158, 29);
            this.labelSinglePrice.Name = "labelSinglePrice";
            this.labelSinglePrice.Size = new System.Drawing.Size(0, 20);
            this.labelSinglePrice.TabIndex = 24;
            // 
            // radioButtonDozen
            // 
            this.radioButtonDozen.AutoSize = true;
            this.radioButtonDozen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDozen.Location = new System.Drawing.Point(29, 87);
            this.radioButtonDozen.Name = "radioButtonDozen";
            this.radioButtonDozen.Size = new System.Drawing.Size(79, 24);
            this.radioButtonDozen.TabIndex = 27;
            this.radioButtonDozen.Text = "Dozen";
            this.radioButtonDozen.UseVisualStyleBackColor = true;
            this.radioButtonDozen.Resize += new System.EventHandler(this.checkChange);
            // 
            // radioButtonHalfDozen
            // 
            this.radioButtonHalfDozen.AutoSize = true;
            this.radioButtonHalfDozen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHalfDozen.Location = new System.Drawing.Point(29, 57);
            this.radioButtonHalfDozen.Name = "radioButtonHalfDozen";
            this.radioButtonHalfDozen.Size = new System.Drawing.Size(116, 24);
            this.radioButtonHalfDozen.TabIndex = 25;
            this.radioButtonHalfDozen.Text = "Half-Dozen";
            this.radioButtonHalfDozen.UseVisualStyleBackColor = true;
            this.radioButtonHalfDozen.CheckedChanged += new System.EventHandler(this.checkChange);
            // 
            // radioButtonSingle
            // 
            this.radioButtonSingle.AutoSize = true;
            this.radioButtonSingle.Checked = true;
            this.radioButtonSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSingle.Location = new System.Drawing.Point(29, 27);
            this.radioButtonSingle.Name = "radioButtonSingle";
            this.radioButtonSingle.Size = new System.Drawing.Size(76, 24);
            this.radioButtonSingle.TabIndex = 23;
            this.radioButtonSingle.TabStop = true;
            this.radioButtonSingle.Text = "Single";
            this.radioButtonSingle.UseVisualStyleBackColor = true;
            this.radioButtonSingle.CheckedChanged += new System.EventHandler(this.checkChange);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelOrderTotalAmount);
            this.groupBox1.Controls.Add(this.labelOrderTotal);
            this.groupBox1.Controls.Add(this.labelSalesTaxAmount);
            this.groupBox1.Controls.Add(this.labelSalesTax);
            this.groupBox1.Controls.Add(this.labelSubtotalAmount);
            this.groupBox1.Controls.Add(this.labelSubtotal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 612);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 63);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Totals";
            // 
            // labelOrderTotalAmount
            // 
            this.labelOrderTotalAmount.AutoSize = true;
            this.labelOrderTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderTotalAmount.Location = new System.Drawing.Point(675, 28);
            this.labelOrderTotalAmount.Name = "labelOrderTotalAmount";
            this.labelOrderTotalAmount.Size = new System.Drawing.Size(0, 20);
            this.labelOrderTotalAmount.TabIndex = 5;
            // 
            // labelOrderTotal
            // 
            this.labelOrderTotal.AutoSize = true;
            this.labelOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderTotal.Location = new System.Drawing.Point(542, 28);
            this.labelOrderTotal.Name = "labelOrderTotal";
            this.labelOrderTotal.Size = new System.Drawing.Size(99, 20);
            this.labelOrderTotal.TabIndex = 4;
            this.labelOrderTotal.Text = "Order Total:";
            // 
            // labelSalesTaxAmount
            // 
            this.labelSalesTaxAmount.AutoSize = true;
            this.labelSalesTaxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalesTaxAmount.Location = new System.Drawing.Point(387, 28);
            this.labelSalesTaxAmount.Name = "labelSalesTaxAmount";
            this.labelSalesTaxAmount.Size = new System.Drawing.Size(0, 20);
            this.labelSalesTaxAmount.TabIndex = 3;
            // 
            // labelSalesTax
            // 
            this.labelSalesTax.AutoSize = true;
            this.labelSalesTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalesTax.Location = new System.Drawing.Point(273, 28);
            this.labelSalesTax.Name = "labelSalesTax";
            this.labelSalesTax.Size = new System.Drawing.Size(88, 20);
            this.labelSalesTax.TabIndex = 2;
            this.labelSalesTax.Text = "Sales Tax:";
            // 
            // labelSubtotalAmount
            // 
            this.labelSubtotalAmount.AutoSize = true;
            this.labelSubtotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtotalAmount.Location = new System.Drawing.Point(116, 28);
            this.labelSubtotalAmount.Name = "labelSubtotalAmount";
            this.labelSubtotalAmount.Size = new System.Drawing.Size(0, 20);
            this.labelSubtotalAmount.TabIndex = 1;
            this.labelSubtotalAmount.Click += new System.EventHandler(this.labelSubtotalAmount_Click);
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtotal.Location = new System.Drawing.Point(16, 28);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(75, 20);
            this.labelSubtotal.TabIndex = 0;
            this.labelSubtotal.Text = "Subtotal:";
            this.labelSubtotal.Click += new System.EventHandler(this.labelSubtotal_Click);
            // 
            // buttonSummary
            // 
            this.buttonSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSummary.Location = new System.Drawing.Point(34, 681);
            this.buttonSummary.Name = "buttonSummary";
            this.buttonSummary.Size = new System.Drawing.Size(230, 43);
            this.buttonSummary.TabIndex = 24;
            this.buttonSummary.Text = "&Display Summary";
            this.toolTipSummary.SetToolTip(this.buttonSummary, "This button will display entire contents in a message box.");
            this.buttonSummary.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(364, 681);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(175, 43);
            this.buttonClear.TabIndex = 25;
            this.buttonClear.Text = "&Clear Form";
            this.toolTipExit.SetToolTip(this.buttonClear, "This button will reset form to default.");
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(636, 681);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(175, 43);
            this.buttonExit.TabIndex = 26;
            this.buttonExit.Text = "&Exit Program";
            this.toolTipSummary.SetToolTip(this.buttonExit, "This button will close program.");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // toolTipSummary
            // 
            this.toolTipSummary.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTipSummary_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(858, 731);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSummary);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxOrderInfo);
            this.Controls.Add(this.groupBoxDeliveInfo);
            this.Controls.Add(this.groupBoxCusInfo);
            this.Controls.Add(this.labelCompany);
            this.Controls.Add(this.pictureBoxBalloon);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBalloon)).EndInit();
            this.groupBoxCusInfo.ResumeLayout(false);
            this.groupBoxCusInfo.PerformLayout();
            this.groupBoxDeliveInfo.ResumeLayout(false);
            this.groupBoxDeliveInfo.PerformLayout();
            this.groupBoxOrderInfo.ResumeLayout(false);
            this.groupBoxOrderInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBalloon;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.GroupBox groupBoxCusInfo;
        private System.Windows.Forms.GroupBox groupBoxDeliveInfo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxTitle;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelZip;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.Label labelDeliveryDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDelivery;
        private System.Windows.Forms.TextBox textBoxZip;
        private System.Windows.Forms.RadioButton radioButtonDelivery;
        private System.Windows.Forms.RadioButton radioButtonStore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxOrderInfo;
        private System.Windows.Forms.RadioButton radioButtonDozen;
        private System.Windows.Forms.RadioButton radioButtonHalfDozen;
        private System.Windows.Forms.RadioButton radioButtonSingle;
        private System.Windows.Forms.Label labelSinglePrice;
        private System.Windows.Forms.Label labelDozenPrice;
        private System.Windows.Forms.Label labelHalfDozenPrice;
        private System.Windows.Forms.ComboBox comboBoxOccasions;
        private System.Windows.Forms.ListBox listBoxExtras;
        private System.Windows.Forms.Label labelExtras;
        private System.Windows.Forms.Label labelExtraInfo;
        private System.Windows.Forms.CheckBox checkBoxMessage;
        private System.Windows.Forms.Label labelMessagePrice;
        private System.Windows.Forms.TextBox textBoxPersonalMessage;
        private System.Windows.Forms.Label labelMaxLimit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelOrderTotalAmount;
        private System.Windows.Forms.Label labelOrderTotal;
        private System.Windows.Forms.Label labelSalesTaxAmount;
        private System.Windows.Forms.Label labelSalesTax;
        private System.Windows.Forms.Label labelSubtotalAmount;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Button buttonSummary;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTipSummary;
        private System.Windows.Forms.ToolTip toolTipExit;
        private System.Windows.Forms.ToolTip toolTipClear;
        private System.Windows.Forms.Label labelDeliveryPrice;
        private System.Windows.Forms.Label labelOccasions;
    }
}

