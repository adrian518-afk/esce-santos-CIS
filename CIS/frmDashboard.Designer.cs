namespace CIS
{
    partial class frmDashboard
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
            BunifuAnimatorNS.Animation animation12 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation11 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelRegister = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.datePickerAge = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.slideTransitionHamburger = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnSortCancel = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.cmbSortProvince = new System.Windows.Forms.ComboBox();
            this.dataGridMain = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExitApp = new Bunifu.Framework.UI.BunifuImageButton();
            this.label6 = new System.Windows.Forms.Label();
            this.sliderTransitionMain = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.txtNoRecords = new System.Windows.Forms.Label();
            this.panelRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitApp)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelRegister
            // 
            this.panelRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.panelRegister.Controls.Add(this.label7);
            this.panelRegister.Controls.Add(this.txtSchool);
            this.panelRegister.Controls.Add(this.label3);
            this.panelRegister.Controls.Add(this.label2);
            this.panelRegister.Controls.Add(this.label1);
            this.panelRegister.Controls.Add(this.bunifuImageButton1);
            this.panelRegister.Controls.Add(this.datePickerAge);
            this.panelRegister.Controls.Add(this.btnCancel);
            this.panelRegister.Controls.Add(this.cmbProvince);
            this.panelRegister.Controls.Add(this.txtEmail);
            this.panelRegister.Controls.Add(this.label4);
            this.panelRegister.Controls.Add(this.txtLastName);
            this.panelRegister.Controls.Add(this.txtFirstName);
            this.panelRegister.Controls.Add(this.btnDelete);
            this.panelRegister.Controls.Add(this.btnEdit);
            this.panelRegister.Controls.Add(this.btnAdd);
            this.sliderTransitionMain.SetDecoration(this.panelRegister, BunifuAnimatorNS.DecorationType.None);
            this.slideTransitionHamburger.SetDecoration(this.panelRegister, BunifuAnimatorNS.DecorationType.None);
            this.panelRegister.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRegister.Location = new System.Drawing.Point(0, 0);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(231, 616);
            this.panelRegister.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.slideTransitionHamburger.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.sliderTransitionMain.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(18, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "School";
            this.label7.Visible = false;
            // 
            // txtSchool
            // 
            this.txtSchool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.slideTransitionHamburger.SetDecoration(this.txtSchool, BunifuAnimatorNS.DecorationType.None);
            this.sliderTransitionMain.SetDecoration(this.txtSchool, BunifuAnimatorNS.DecorationType.None);
            this.txtSchool.Enabled = false;
            this.txtSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchool.ForeColor = System.Drawing.Color.Gray;
            this.txtSchool.Location = new System.Drawing.Point(12, 203);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Size = new System.Drawing.Size(206, 24);
            this.txtSchool.TabIndex = 4;
            this.txtSchool.Text = "School";
            this.txtSchool.TextChanged += new System.EventHandler(this.txtSchool_TextChanged);
            this.txtSchool.Leave += new System.EventHandler(this.txtSchool_Leave);
            this.txtSchool.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSchool_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.slideTransitionHamburger.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.sliderTransitionMain.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(18, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Email";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.slideTransitionHamburger.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.sliderTransitionMain.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(18, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Lastname";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.slideTransitionHamburger.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.sliderTransitionMain.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(19, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Firstname";
            this.label1.Visible = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderTransitionMain.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.slideTransitionHamburger.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(10, 11);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(33, 33);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 57;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // datePickerAge
            // 
            this.datePickerAge.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerAge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slideTransitionHamburger.SetDecoration(this.datePickerAge, BunifuAnimatorNS.DecorationType.None);
            this.sliderTransitionMain.SetDecoration(this.datePickerAge, BunifuAnimatorNS.DecorationType.None);
            this.datePickerAge.Enabled = false;
            this.datePickerAge.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerAge.Location = new System.Drawing.Point(12, 273);
            this.datePickerAge.Name = "datePickerAge";
            this.datePickerAge.Size = new System.Drawing.Size(206, 20);
            this.datePickerAge.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slideTransitionHamburger.SetDecoration(this.btnCancel, BunifuAnimatorNS.DecorationType.None);
            this.sliderTransitionMain.SetDecoration(this.btnCancel, BunifuAnimatorNS.DecorationType.None);
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(12, 574);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(206, 29);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // cmbProvince
            // 
            this.cmbProvince.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.cmbProvince.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderTransitionMain.SetDecoration(this.cmbProvince, BunifuAnimatorNS.DecorationType.None);
            this.slideTransitionHamburger.SetDecoration(this.cmbProvince, BunifuAnimatorNS.DecorationType.None);
            this.cmbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvince.Enabled = false;
            this.cmbProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProvince.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Location = new System.Drawing.Point(12, 238);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(206, 26);
            this.cmbProvince.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.slideTransitionHamburger.SetDecoration(this.txtEmail, BunifuAnimatorNS.DecorationType.None);
            this.sliderTransitionMain.SetDecoration(this.txtEmail, BunifuAnimatorNS.DecorationType.None);
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(12, 169);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 24);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "Email";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            this.txtEmail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtEmail_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.slideTransitionHamburger.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.sliderTransitionMain.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 24);
            this.label4.TabIndex = 63;
            this.label4.Text = "File Maintenance";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.slideTransitionHamburger.SetDecoration(this.txtLastName, BunifuAnimatorNS.DecorationType.None);
            this.sliderTransitionMain.SetDecoration(this.txtLastName, BunifuAnimatorNS.DecorationType.None);
            this.txtLastName.Enabled = false;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.Gray;
            this.txtLastName.Location = new System.Drawing.Point(12, 130);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(206, 24);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Text = "Lastname";
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            this.txtLastName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtLastName_MouseDown);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(74)))));
            this.slideTransitionHamburger.SetDecoration(this.txtFirstName, BunifuAnimatorNS.DecorationType.None);
            this.sliderTransitionMain.SetDecoration(this.txtFirstName, BunifuAnimatorNS.DecorationType.None);
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.Gray;
            this.txtFirstName.Location = new System.Drawing.Point(12, 96);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(206, 24);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Text = "Firstname";
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            this.txtFirstName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtFirstName_MouseDown);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gray;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slideTransitionHamburger.SetDecoration(this.btnDelete, BunifuAnimatorNS.DecorationType.None);
            this.sliderTransitionMain.SetDecoration(this.btnDelete, BunifuAnimatorNS.DecorationType.None);
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(12, 539);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(206, 29);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Gray;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slideTransitionHamburger.SetDecoration(this.btnEdit, BunifuAnimatorNS.DecorationType.None);
            this.sliderTransitionMain.SetDecoration(this.btnEdit, BunifuAnimatorNS.DecorationType.None);
            this.btnEdit.Enabled = false;
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(12, 504);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(206, 29);
            this.btnEdit.TabIndex = 48;
            this.btnEdit.Text = "UPDATE";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slideTransitionHamburger.SetDecoration(this.btnAdd, BunifuAnimatorNS.DecorationType.None);
            this.sliderTransitionMain.SetDecoration(this.btnAdd, BunifuAnimatorNS.DecorationType.None);
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(12, 469);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(206, 29);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // shapeContainer1
            // 
            this.slideTransitionHamburger.SetDecoration(this.shapeContainer1, BunifuAnimatorNS.DecorationType.None);
            this.sliderTransitionMain.SetDecoration(this.shapeContainer1, BunifuAnimatorNS.DecorationType.None);
            this.shapeContainer1.Location = new System.Drawing.Point(10, 10);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Size = new System.Drawing.Size(936, 447);
            this.shapeContainer1.TabIndex = 36;
            this.shapeContainer1.TabStop = false;
            // 
            // slideTransitionHamburger
            // 
            this.slideTransitionHamburger.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.slideTransitionHamburger.Cursor = null;
            animation12.AnimateOnlyDifferences = true;
            animation12.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.BlindCoeff")));
            animation12.LeafCoeff = 0F;
            animation12.MaxTime = 1F;
            animation12.MinTime = 0F;
            animation12.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicCoeff")));
            animation12.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicShift")));
            animation12.MosaicSize = 0;
            animation12.Padding = new System.Windows.Forms.Padding(0);
            animation12.RotateCoeff = 0F;
            animation12.RotateLimit = 0F;
            animation12.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.ScaleCoeff")));
            animation12.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.SlideCoeff")));
            animation12.TimeCoeff = 0F;
            animation12.TransparencyCoeff = 0F;
            this.slideTransitionHamburger.DefaultAnimation = animation12;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.txtNoRecords);
            this.panelMain.Controls.Add(this.lblRecordCount);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.lblID);
            this.panelMain.Controls.Add(this.btnSortCancel);
            this.panelMain.Controls.Add(this.txtSearchBox);
            this.panelMain.Controls.Add(this.cmbSortProvince);
            this.panelMain.Controls.Add(this.dataGridMain);
            this.panelMain.Controls.Add(this.panel1);
            this.sliderTransitionMain.SetDecoration(this.panelMain, BunifuAnimatorNS.DecorationType.None);
            this.slideTransitionHamburger.SetDecoration(this.panelMain, BunifuAnimatorNS.DecorationType.None);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain.Location = new System.Drawing.Point(231, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(725, 616);
            this.panelMain.TabIndex = 51;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecordCount.AutoSize = true;
            this.slideTransitionHamburger.SetDecoration(this.lblRecordCount, BunifuAnimatorNS.DecorationType.None);
            this.sliderTransitionMain.SetDecoration(this.lblRecordCount, BunifuAnimatorNS.DecorationType.None);
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.ForeColor = System.Drawing.Color.White;
            this.lblRecordCount.Location = new System.Drawing.Point(673, 585);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(54, 20);
            this.lblRecordCount.TabIndex = 68;
            this.lblRecordCount.Text = "12356";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.slideTransitionHamburger.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.sliderTransitionMain.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(531, 585);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "Number of records:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.slideTransitionHamburger.SetDecoration(this.lblID, BunifuAnimatorNS.DecorationType.None);
            this.sliderTransitionMain.SetDecoration(this.lblID, BunifuAnimatorNS.DecorationType.None);
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(690, 63);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 16);
            this.lblID.TabIndex = 43;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // btnSortCancel
            // 
            this.slideTransitionHamburger.SetDecoration(this.btnSortCancel, BunifuAnimatorNS.DecorationType.None);
            this.sliderTransitionMain.SetDecoration(this.btnSortCancel, BunifuAnimatorNS.DecorationType.None);
            this.btnSortCancel.Enabled = false;
            this.btnSortCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortCancel.Location = new System.Drawing.Point(382, 582);
            this.btnSortCancel.Name = "btnSortCancel";
            this.btnSortCancel.Size = new System.Drawing.Size(23, 23);
            this.btnSortCancel.TabIndex = 66;
            this.btnSortCancel.Text = "X";
            this.btnSortCancel.UseVisualStyleBackColor = true;
            this.btnSortCancel.Click += new System.EventHandler(this.btnSortCancel_Click);
            // 
            // txtSearchBox
            // 
            this.slideTransitionHamburger.SetDecoration(this.txtSearchBox, BunifuAnimatorNS.DecorationType.None);
            this.sliderTransitionMain.SetDecoration(this.txtSearchBox, BunifuAnimatorNS.DecorationType.None);
            this.txtSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchBox.Location = new System.Drawing.Point(8, 580);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(181, 24);
            this.txtSearchBox.TabIndex = 8;
            this.txtSearchBox.Text = "Type here to search...";
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            this.txtSearchBox.Leave += new System.EventHandler(this.txtSearchBox_Leave);
            this.txtSearchBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSearchBox_MouseDown);
            // 
            // cmbSortProvince
            // 
            this.sliderTransitionMain.SetDecoration(this.cmbSortProvince, BunifuAnimatorNS.DecorationType.None);
            this.slideTransitionHamburger.SetDecoration(this.cmbSortProvince, BunifuAnimatorNS.DecorationType.None);
            this.cmbSortProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSortProvince.FormattingEnabled = true;
            this.cmbSortProvince.Location = new System.Drawing.Point(195, 581);
            this.cmbSortProvince.Name = "cmbSortProvince";
            this.cmbSortProvince.Size = new System.Drawing.Size(181, 24);
            this.cmbSortProvince.TabIndex = 64;
            this.cmbSortProvince.TextChanged += new System.EventHandler(this.cmbSortProvince_TextChanged);
            // 
            // dataGridMain
            // 
            this.dataGridMain.AllowUserToAddRows = false;
            this.dataGridMain.AllowUserToDeleteRows = false;
            this.dataGridMain.AllowUserToResizeColumns = false;
            this.dataGridMain.AllowUserToResizeRows = false;
            this.dataGridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.dataGridMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMain.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sliderTransitionMain.SetDecoration(this.dataGridMain, BunifuAnimatorNS.DecorationType.None);
            this.slideTransitionHamburger.SetDecoration(this.dataGridMain, BunifuAnimatorNS.DecorationType.None);
            this.dataGridMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridMain.Location = new System.Drawing.Point(0, 52);
            this.dataGridMain.MultiSelect = false;
            this.dataGridMain.Name = "dataGridMain";
            this.dataGridMain.RowHeadersVisible = false;
            this.dataGridMain.Size = new System.Drawing.Size(725, 524);
            this.dataGridMain.TabIndex = 62;
            this.dataGridMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMain_CellClick_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(16)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.btnExitApp);
            this.panel1.Controls.Add(this.label6);
            this.sliderTransitionMain.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.slideTransitionHamburger.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 52);
            this.panel1.TabIndex = 69;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderTransitionMain.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.slideTransitionHamburger.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(657, 13);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 69;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Tag = "Exit";
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitApp.BackColor = System.Drawing.Color.Transparent;
            this.btnExitApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExitApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderTransitionMain.SetDecoration(this.btnExitApp, BunifuAnimatorNS.DecorationType.None);
            this.slideTransitionHamburger.SetDecoration(this.btnExitApp, BunifuAnimatorNS.DecorationType.None);
            this.btnExitApp.Image = ((System.Drawing.Image)(resources.GetObject("btnExitApp.Image")));
            this.btnExitApp.ImageActive = null;
            this.btnExitApp.Location = new System.Drawing.Point(689, 13);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(25, 25);
            this.btnExitApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExitApp.TabIndex = 67;
            this.btnExitApp.TabStop = false;
            this.btnExitApp.Tag = "Exit";
            this.btnExitApp.Zoom = 10;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.slideTransitionHamburger.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.sliderTransitionMain.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 24);
            this.label6.TabIndex = 68;
            this.label6.Text = "Citizen Information";
            // 
            // sliderTransitionMain
            // 
            this.sliderTransitionMain.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.sliderTransitionMain.Cursor = null;
            animation11.AnimateOnlyDifferences = true;
            animation11.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.BlindCoeff")));
            animation11.LeafCoeff = 0F;
            animation11.MaxTime = 1F;
            animation11.MinTime = 0F;
            animation11.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicCoeff")));
            animation11.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicShift")));
            animation11.MosaicSize = 0;
            animation11.Padding = new System.Windows.Forms.Padding(0);
            animation11.RotateCoeff = 0F;
            animation11.RotateLimit = 0F;
            animation11.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.ScaleCoeff")));
            animation11.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.SlideCoeff")));
            animation11.TimeCoeff = 0F;
            animation11.TransparencyCoeff = 0F;
            this.sliderTransitionMain.DefaultAnimation = animation11;
            // 
            // txtNoRecords
            // 
            this.txtNoRecords.AutoSize = true;
            this.txtNoRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.slideTransitionHamburger.SetDecoration(this.txtNoRecords, BunifuAnimatorNS.DecorationType.None);
            this.sliderTransitionMain.SetDecoration(this.txtNoRecords, BunifuAnimatorNS.DecorationType.None);
            this.txtNoRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoRecords.ForeColor = System.Drawing.Color.White;
            this.txtNoRecords.Location = new System.Drawing.Point(270, 315);
            this.txtNoRecords.Name = "txtNoRecords";
            this.txtNoRecords.Size = new System.Drawing.Size(188, 24);
            this.txtNoRecords.TabIndex = 69;
            this.txtNoRecords.Text = "No Records Found";
            // 
            // frmDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(956, 616);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelRegister);
            this.slideTransitionHamburger.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.sliderTransitionMain.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DASHBOARD";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.DateTimePicker datePickerAge;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private BunifuAnimatorNS.BunifuTransition slideTransitionHamburger;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSortCancel;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.ComboBox cmbSortProvince;
        private System.Windows.Forms.DataGridView dataGridMain;
        private System.Windows.Forms.Label label4;
        private BunifuAnimatorNS.BunifuTransition sliderTransitionMain;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton btnExitApp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.Label txtNoRecords;
    }
}