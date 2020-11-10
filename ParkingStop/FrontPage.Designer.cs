namespace ParkingStop
{
    partial class FrontPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontPage));
            this.timerDigClock = new System.Windows.Forms.Timer(this.components);
            this.dGrdViewList = new System.Windows.Forms.DataGridView();
            this.lblListTotal = new System.Windows.Forms.Label();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.lblTotalCar = new System.Windows.Forms.Label();
            this.lblTotalSUV = new System.Windows.Forms.Label();
            this.lblTotalBike = new System.Windows.Forms.Label();
            this.picBxTotalCar = new System.Windows.Forms.PictureBox();
            this.pnlSUVCount = new System.Windows.Forms.Panel();
            this.picBxTotalSUV = new System.Windows.Forms.PictureBox();
            this.pnlBikeCount = new System.Windows.Forms.Panel();
            this.pictureBike = new System.Windows.Forms.PictureBox();
            this.pnlChckOut = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblVCheckOut = new System.Windows.Forms.Label();
            this.picBxCancelChckOut = new System.Windows.Forms.PictureBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtBoxDurChkOut = new System.Windows.Forms.TextBox();
            this.txtBoxToPayChkOut = new System.Windows.Forms.TextBox();
            this.txtBoxTOOut = new System.Windows.Forms.TextBox();
            this.lblPayChckOut = new System.Windows.Forms.Label();
            this.txtBoxTIOut = new System.Windows.Forms.TextBox();
            this.lblDurationChckOut = new System.Windows.Forms.Label();
            this.lblTimeOutChckOut = new System.Windows.Forms.Label();
            this.lblTimeInChckOut = new System.Windows.Forms.Label();
            this.lblTagCheckOut = new System.Windows.Forms.Label();
            this.lblTagRemTxt = new System.Windows.Forms.Label();
            this.pnlAddVehicle = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.picBxCancel = new System.Windows.Forms.PictureBox();
            this.btnAddConfirm = new System.Windows.Forms.Button();
            this.cmbBxVehType = new System.Windows.Forms.ComboBox();
            this.cmbBxVehModel = new System.Windows.Forms.ComboBox();
            this.txtBoxTag = new System.Windows.Forms.TextBox();
            this.lblTypeTxt = new System.Windows.Forms.Label();
            this.lblModelTxt = new System.Windows.Forms.Label();
            this.lblTagTxt = new System.Windows.Forms.Label();
            this.DSGpnlTopBar = new System.Windows.Forms.Panel();
            this.pnlTick = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlOpenAdd = new System.Windows.Forms.Panel();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblParkStop = new System.Windows.Forms.Label();
            this.lblDigitalClock = new System.Windows.Forms.Label();
            this.pnlMinimize = new System.Windows.Forms.Panel();
            this.pnlMaximize = new System.Windows.Forms.Panel();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.pnlLeftBar = new System.Windows.Forms.Panel();
            this.pnlCarCount = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dGrdViewList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxTotalCar)).BeginInit();
            this.pnlSUVCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxTotalSUV)).BeginInit();
            this.pnlBikeCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBike)).BeginInit();
            this.pnlChckOut.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxCancelChckOut)).BeginInit();
            this.pnlAddVehicle.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxCancel)).BeginInit();
            this.DSGpnlTopBar.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlCarCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerDigClock
            // 
            this.timerDigClock.Enabled = true;
            this.timerDigClock.Interval = 1000;
            this.timerDigClock.Tick += new System.EventHandler(this.timerDigClock_Tick);
            // 
            // dGrdViewList
            // 
            this.dGrdViewList.AllowUserToAddRows = false;
            this.dGrdViewList.AllowUserToDeleteRows = false;
            this.dGrdViewList.AllowUserToOrderColumns = true;
            this.dGrdViewList.AllowUserToResizeColumns = false;
            this.dGrdViewList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dGrdViewList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGrdViewList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGrdViewList.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dGrdViewList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGrdViewList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGrdViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGrdViewList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGrdViewList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGrdViewList.EnableHeadersVisualStyles = false;
            this.dGrdViewList.Location = new System.Drawing.Point(5, 450);
            this.dGrdViewList.Name = "dGrdViewList";
            this.dGrdViewList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGrdViewList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dGrdViewList.RowHeadersVisible = false;
            this.dGrdViewList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dGrdViewList.Size = new System.Drawing.Size(1045, 100);
            this.dGrdViewList.TabIndex = 8;
            this.dGrdViewList.DoubleClick += new System.EventHandler(this.dGrdViewList_DoubleClick);
            // 
            // lblListTotal
            // 
            this.lblListTotal.AutoSize = true;
            this.lblListTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblListTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblListTotal.Location = new System.Drawing.Point(933, 151);
            this.lblListTotal.Name = "lblListTotal";
            this.lblListTotal.Size = new System.Drawing.Size(50, 13);
            this.lblListTotal.TabIndex = 10;
            this.lblListTotal.Text = "ListTotal:";
            this.lblListTotal.Visible = false;
            // 
            // timerMenu
            // 
            this.timerMenu.Interval = 1;
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick);
            // 
            // lblTotalCar
            // 
            this.lblTotalCar.AutoSize = true;
            this.lblTotalCar.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalCar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalCar.Image = global::ParkingStop.Properties.Resources.BG_25Wht;
            this.lblTotalCar.Location = new System.Drawing.Point(73, 30);
            this.lblTotalCar.Name = "lblTotalCar";
            this.lblTotalCar.Size = new System.Drawing.Size(21, 23);
            this.lblTotalCar.TabIndex = 13;
            this.lblTotalCar.Text = "0";
            // 
            // lblTotalSUV
            // 
            this.lblTotalSUV.AutoSize = true;
            this.lblTotalSUV.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalSUV.Font = new System.Drawing.Font("Arial Black", 12F);
            this.lblTotalSUV.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalSUV.Image = global::ParkingStop.Properties.Resources.BG_25Wht;
            this.lblTotalSUV.Location = new System.Drawing.Point(82, 30);
            this.lblTotalSUV.Name = "lblTotalSUV";
            this.lblTotalSUV.Size = new System.Drawing.Size(21, 23);
            this.lblTotalSUV.TabIndex = 13;
            this.lblTotalSUV.Text = "0";
            // 
            // lblTotalBike
            // 
            this.lblTotalBike.AutoSize = true;
            this.lblTotalBike.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalBike.Font = new System.Drawing.Font("Arial Black", 12F);
            this.lblTotalBike.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalBike.Image = global::ParkingStop.Properties.Resources.BG_25Wht;
            this.lblTotalBike.Location = new System.Drawing.Point(83, 31);
            this.lblTotalBike.Name = "lblTotalBike";
            this.lblTotalBike.Size = new System.Drawing.Size(21, 23);
            this.lblTotalBike.TabIndex = 13;
            this.lblTotalBike.Text = "0";
            // 
            // picBxTotalCar
            // 
            this.picBxTotalCar.BackColor = System.Drawing.Color.Transparent;
            this.picBxTotalCar.BackgroundImage = global::ParkingStop.Properties.Resources.Logo_Car3d;
            this.picBxTotalCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxTotalCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBxTotalCar.Enabled = false;
            this.picBxTotalCar.Location = new System.Drawing.Point(14, 4);
            this.picBxTotalCar.Name = "picBxTotalCar";
            this.picBxTotalCar.Size = new System.Drawing.Size(146, 79);
            this.picBxTotalCar.TabIndex = 3;
            this.picBxTotalCar.TabStop = false;
            // 
            // pnlSUVCount
            // 
            this.pnlSUVCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlSUVCount.BackColor = System.Drawing.Color.Transparent;
            this.pnlSUVCount.Controls.Add(this.lblTotalSUV);
            this.pnlSUVCount.Controls.Add(this.picBxTotalSUV);
            this.pnlSUVCount.Location = new System.Drawing.Point(465, 121);
            this.pnlSUVCount.Name = "pnlSUVCount";
            this.pnlSUVCount.Size = new System.Drawing.Size(175, 90);
            this.pnlSUVCount.TabIndex = 15;
            this.pnlSUVCount.Visible = false;
            // 
            // picBxTotalSUV
            // 
            this.picBxTotalSUV.BackColor = System.Drawing.Color.Transparent;
            this.picBxTotalSUV.BackgroundImage = global::ParkingStop.Properties.Resources.Logo_SUV3d;
            this.picBxTotalSUV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxTotalSUV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBxTotalSUV.Enabled = false;
            this.picBxTotalSUV.Location = new System.Drawing.Point(16, 5);
            this.picBxTotalSUV.Name = "picBxTotalSUV";
            this.picBxTotalSUV.Size = new System.Drawing.Size(146, 79);
            this.picBxTotalSUV.TabIndex = 3;
            this.picBxTotalSUV.TabStop = false;
            // 
            // pnlBikeCount
            // 
            this.pnlBikeCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlBikeCount.BackColor = System.Drawing.Color.Transparent;
            this.pnlBikeCount.Controls.Add(this.lblTotalBike);
            this.pnlBikeCount.Controls.Add(this.pictureBike);
            this.pnlBikeCount.Location = new System.Drawing.Point(669, 121);
            this.pnlBikeCount.Name = "pnlBikeCount";
            this.pnlBikeCount.Size = new System.Drawing.Size(175, 90);
            this.pnlBikeCount.TabIndex = 16;
            this.pnlBikeCount.Visible = false;
            // 
            // pictureBike
            // 
            this.pictureBike.BackColor = System.Drawing.Color.Transparent;
            this.pictureBike.BackgroundImage = global::ParkingStop.Properties.Resources.Logo_Bike3d;
            this.pictureBike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBike.Enabled = false;
            this.pictureBike.Location = new System.Drawing.Point(15, 6);
            this.pictureBike.Name = "pictureBike";
            this.pictureBike.Size = new System.Drawing.Size(146, 79);
            this.pictureBike.TabIndex = 3;
            this.pictureBike.TabStop = false;
            // 
            // pnlChckOut
            // 
            this.pnlChckOut.BackColor = System.Drawing.Color.Transparent;
            this.pnlChckOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlChckOut.BackgroundImage")));
            this.pnlChckOut.Controls.Add(this.panel3);
            this.pnlChckOut.Controls.Add(this.panel2);
            this.pnlChckOut.Controls.Add(this.picBxCancelChckOut);
            this.pnlChckOut.Controls.Add(this.btnCheckOut);
            this.pnlChckOut.Controls.Add(this.txtBoxDurChkOut);
            this.pnlChckOut.Controls.Add(this.txtBoxToPayChkOut);
            this.pnlChckOut.Controls.Add(this.txtBoxTOOut);
            this.pnlChckOut.Controls.Add(this.lblPayChckOut);
            this.pnlChckOut.Controls.Add(this.txtBoxTIOut);
            this.pnlChckOut.Controls.Add(this.lblDurationChckOut);
            this.pnlChckOut.Controls.Add(this.lblTimeOutChckOut);
            this.pnlChckOut.Controls.Add(this.lblTimeInChckOut);
            this.pnlChckOut.Controls.Add(this.lblTagCheckOut);
            this.pnlChckOut.Controls.Add(this.lblTagRemTxt);
            this.pnlChckOut.Enabled = false;
            this.pnlChckOut.Location = new System.Drawing.Point(613, 385);
            this.pnlChckOut.Name = "pnlChckOut";
            this.pnlChckOut.Size = new System.Drawing.Size(347, 339);
            this.pnlChckOut.TabIndex = 6;
            this.pnlChckOut.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ParkingStop.Properties.Resources.BG_50Wht;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 339);
            this.panel3.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ParkingStop.Properties.Resources.BG_25Wht;
            this.panel2.Controls.Add(this.lblVCheckOut);
            this.panel2.Location = new System.Drawing.Point(50, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 27);
            this.panel2.TabIndex = 13;
            // 
            // lblVCheckOut
            // 
            this.lblVCheckOut.AutoSize = true;
            this.lblVCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVCheckOut.ForeColor = System.Drawing.SystemColors.Control;
            this.lblVCheckOut.Location = new System.Drawing.Point(46, 4);
            this.lblVCheckOut.Name = "lblVCheckOut";
            this.lblVCheckOut.Size = new System.Drawing.Size(158, 20);
            this.lblVCheckOut.TabIndex = 0;
            this.lblVCheckOut.Text = "Vehicle Check-Out";
            // 
            // picBxCancelChckOut
            // 
            this.picBxCancelChckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBxCancelChckOut.BackColor = System.Drawing.SystemColors.Control;
            this.picBxCancelChckOut.BackgroundImage = global::ParkingStop.Properties.Resources.Btn_Quit;
            this.picBxCancelChckOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxCancelChckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBxCancelChckOut.Location = new System.Drawing.Point(328, 4);
            this.picBxCancelChckOut.Name = "picBxCancelChckOut";
            this.picBxCancelChckOut.Size = new System.Drawing.Size(15, 15);
            this.picBxCancelChckOut.TabIndex = 3;
            this.picBxCancelChckOut.TabStop = false;
            this.picBxCancelChckOut.Click += new System.EventHandler(this.picBxCancelChckOut_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.Location = new System.Drawing.Point(112, 296);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(127, 23);
            this.btnCheckOut.TabIndex = 12;
            this.btnCheckOut.Text = "Check-Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtBoxDurChkOut
            // 
            this.txtBoxDurChkOut.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxDurChkOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDurChkOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDurChkOut.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBoxDurChkOut.Location = new System.Drawing.Point(48, 180);
            this.txtBoxDurChkOut.Name = "txtBoxDurChkOut";
            this.txtBoxDurChkOut.Size = new System.Drawing.Size(265, 20);
            this.txtBoxDurChkOut.TabIndex = 5;
            this.txtBoxDurChkOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxToPayChkOut
            // 
            this.txtBoxToPayChkOut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxToPayChkOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxToPayChkOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxToPayChkOut.ForeColor = System.Drawing.SystemColors.Info;
            this.txtBoxToPayChkOut.Location = new System.Drawing.Point(140, 241);
            this.txtBoxToPayChkOut.Name = "txtBoxToPayChkOut";
            this.txtBoxToPayChkOut.Size = new System.Drawing.Size(127, 20);
            this.txtBoxToPayChkOut.TabIndex = 1;
            // 
            // txtBoxTOOut
            // 
            this.txtBoxTOOut.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxTOOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxTOOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTOOut.ForeColor = System.Drawing.SystemColors.Control;
            this.txtBoxTOOut.Location = new System.Drawing.Point(186, 134);
            this.txtBoxTOOut.Name = "txtBoxTOOut";
            this.txtBoxTOOut.Size = new System.Drawing.Size(127, 20);
            this.txtBoxTOOut.TabIndex = 1;
            this.txtBoxTOOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPayChckOut
            // 
            this.lblPayChckOut.AutoSize = true;
            this.lblPayChckOut.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPayChckOut.Location = new System.Drawing.Point(49, 244);
            this.lblPayChckOut.Name = "lblPayChckOut";
            this.lblPayChckOut.Size = new System.Drawing.Size(70, 13);
            this.lblPayChckOut.TabIndex = 0;
            this.lblPayChckOut.Text = "Total to Pay :";
            // 
            // txtBoxTIOut
            // 
            this.txtBoxTIOut.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxTIOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxTIOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTIOut.ForeColor = System.Drawing.SystemColors.Control;
            this.txtBoxTIOut.Location = new System.Drawing.Point(48, 134);
            this.txtBoxTIOut.Name = "txtBoxTIOut";
            this.txtBoxTIOut.Size = new System.Drawing.Size(127, 20);
            this.txtBoxTIOut.TabIndex = 1;
            this.txtBoxTIOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDurationChckOut
            // 
            this.lblDurationChckOut.AutoSize = true;
            this.lblDurationChckOut.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDurationChckOut.Location = new System.Drawing.Point(162, 165);
            this.lblDurationChckOut.Name = "lblDurationChckOut";
            this.lblDurationChckOut.Size = new System.Drawing.Size(53, 13);
            this.lblDurationChckOut.TabIndex = 0;
            this.lblDurationChckOut.Text = "Duration :";
            // 
            // lblTimeOutChckOut
            // 
            this.lblTimeOutChckOut.AutoSize = true;
            this.lblTimeOutChckOut.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTimeOutChckOut.Location = new System.Drawing.Point(225, 112);
            this.lblTimeOutChckOut.Name = "lblTimeOutChckOut";
            this.lblTimeOutChckOut.Size = new System.Drawing.Size(56, 13);
            this.lblTimeOutChckOut.TabIndex = 0;
            this.lblTimeOutChckOut.Text = "Time Out :";
            // 
            // lblTimeInChckOut
            // 
            this.lblTimeInChckOut.AutoSize = true;
            this.lblTimeInChckOut.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTimeInChckOut.Location = new System.Drawing.Point(90, 112);
            this.lblTimeInChckOut.Name = "lblTimeInChckOut";
            this.lblTimeInChckOut.Size = new System.Drawing.Size(48, 13);
            this.lblTimeInChckOut.TabIndex = 0;
            this.lblTimeInChckOut.Text = "Time In :";
            // 
            // lblTagCheckOut
            // 
            this.lblTagCheckOut.AutoSize = true;
            this.lblTagCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagCheckOut.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTagCheckOut.Location = new System.Drawing.Point(138, 73);
            this.lblTagCheckOut.Name = "lblTagCheckOut";
            this.lblTagCheckOut.Size = new System.Drawing.Size(86, 24);
            this.lblTagCheckOut.TabIndex = 0;
            this.lblTagCheckOut.Text = "###-####";
            // 
            // lblTagRemTxt
            // 
            this.lblTagRemTxt.AutoSize = true;
            this.lblTagRemTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagRemTxt.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTagRemTxt.Location = new System.Drawing.Point(149, 55);
            this.lblTagRemTxt.Name = "lblTagRemTxt";
            this.lblTagRemTxt.Size = new System.Drawing.Size(59, 13);
            this.lblTagRemTxt.TabIndex = 0;
            this.lblTagRemTxt.Text = "Vehicle tag";
            // 
            // pnlAddVehicle
            // 
            this.pnlAddVehicle.BackColor = System.Drawing.Color.Transparent;
            this.pnlAddVehicle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAddVehicle.BackgroundImage")));
            this.pnlAddVehicle.Controls.Add(this.panel5);
            this.pnlAddVehicle.Controls.Add(this.panel4);
            this.pnlAddVehicle.Controls.Add(this.picBxCancel);
            this.pnlAddVehicle.Controls.Add(this.btnAddConfirm);
            this.pnlAddVehicle.Controls.Add(this.cmbBxVehType);
            this.pnlAddVehicle.Controls.Add(this.cmbBxVehModel);
            this.pnlAddVehicle.Controls.Add(this.txtBoxTag);
            this.pnlAddVehicle.Controls.Add(this.lblTypeTxt);
            this.pnlAddVehicle.Controls.Add(this.lblModelTxt);
            this.pnlAddVehicle.Controls.Add(this.lblTagTxt);
            this.pnlAddVehicle.Enabled = false;
            this.pnlAddVehicle.Location = new System.Drawing.Point(115, 423);
            this.pnlAddVehicle.Name = "pnlAddVehicle";
            this.pnlAddVehicle.Size = new System.Drawing.Size(286, 281);
            this.pnlAddVehicle.TabIndex = 6;
            this.pnlAddVehicle.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::ParkingStop.Properties.Resources.BG_50Wht;
            this.panel5.Location = new System.Drawing.Point(275, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 279);
            this.panel5.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::ParkingStop.Properties.Resources.BG_25Wht;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(-1, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 27);
            this.panel4.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(66, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Vehicle Check-In";
            // 
            // picBxCancel
            // 
            this.picBxCancel.BackColor = System.Drawing.SystemColors.Control;
            this.picBxCancel.BackgroundImage = global::ParkingStop.Properties.Resources.Btn_Quit;
            this.picBxCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBxCancel.Location = new System.Drawing.Point(260, 3);
            this.picBxCancel.Name = "picBxCancel";
            this.picBxCancel.Size = new System.Drawing.Size(15, 15);
            this.picBxCancel.TabIndex = 3;
            this.picBxCancel.TabStop = false;
            this.picBxCancel.Click += new System.EventHandler(this.picBxCancel_Click);
            // 
            // btnAddConfirm
            // 
            this.btnAddConfirm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddConfirm.FlatAppearance.BorderSize = 0;
            this.btnAddConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddConfirm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddConfirm.Location = new System.Drawing.Point(105, 218);
            this.btnAddConfirm.Name = "btnAddConfirm";
            this.btnAddConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnAddConfirm.TabIndex = 3;
            this.btnAddConfirm.Text = "Add";
            this.btnAddConfirm.UseVisualStyleBackColor = false;
            this.btnAddConfirm.Click += new System.EventHandler(this.btnAddConfirm_Click);
            // 
            // cmbBxVehType
            // 
            this.cmbBxVehType.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbBxVehType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBxVehType.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbBxVehType.FormattingEnabled = true;
            this.cmbBxVehType.Items.AddRange(new object[] {
            "Car",
            "SUV",
            "MotorCycle"});
            this.cmbBxVehType.Location = new System.Drawing.Point(85, 120);
            this.cmbBxVehType.Name = "cmbBxVehType";
            this.cmbBxVehType.Size = new System.Drawing.Size(127, 21);
            this.cmbBxVehType.TabIndex = 2;
            this.cmbBxVehType.SelectedIndexChanged += new System.EventHandler(this.cmbBxVehType_SelectedIndexChanged);
            // 
            // cmbBxVehModel
            // 
            this.cmbBxVehModel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbBxVehModel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBxVehModel.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbBxVehModel.FormattingEnabled = true;
            this.cmbBxVehModel.Location = new System.Drawing.Point(85, 166);
            this.cmbBxVehModel.Name = "cmbBxVehModel";
            this.cmbBxVehModel.Size = new System.Drawing.Size(127, 21);
            this.cmbBxVehModel.TabIndex = 2;
            // 
            // txtBoxTag
            // 
            this.txtBoxTag.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxTag.Location = new System.Drawing.Point(85, 77);
            this.txtBoxTag.Name = "txtBoxTag";
            this.txtBoxTag.Size = new System.Drawing.Size(127, 20);
            this.txtBoxTag.TabIndex = 1;
            // 
            // lblTypeTxt
            // 
            this.lblTypeTxt.AutoSize = true;
            this.lblTypeTxt.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTypeTxt.Location = new System.Drawing.Point(111, 104);
            this.lblTypeTxt.Name = "lblTypeTxt";
            this.lblTypeTxt.Size = new System.Drawing.Size(69, 13);
            this.lblTypeTxt.TabIndex = 0;
            this.lblTypeTxt.Text = "Vehicle Type";
            // 
            // lblModelTxt
            // 
            this.lblModelTxt.AutoSize = true;
            this.lblModelTxt.ForeColor = System.Drawing.SystemColors.Control;
            this.lblModelTxt.Location = new System.Drawing.Point(111, 150);
            this.lblModelTxt.Name = "lblModelTxt";
            this.lblModelTxt.Size = new System.Drawing.Size(74, 13);
            this.lblModelTxt.TabIndex = 0;
            this.lblModelTxt.Text = "Vehicle Model";
            // 
            // lblTagTxt
            // 
            this.lblTagTxt.AutoSize = true;
            this.lblTagTxt.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTagTxt.Location = new System.Drawing.Point(118, 61);
            this.lblTagTxt.Name = "lblTagTxt";
            this.lblTagTxt.Size = new System.Drawing.Size(60, 13);
            this.lblTagTxt.TabIndex = 0;
            this.lblTagTxt.Text = "Vehicle tag";
            // 
            // DSGpnlTopBar
            // 
            this.DSGpnlTopBar.BackColor = System.Drawing.Color.Transparent;
            this.DSGpnlTopBar.BackgroundImage = global::ParkingStop.Properties.Resources.BG_50Blck;
            this.DSGpnlTopBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DSGpnlTopBar.Controls.Add(this.pnlTick);
            this.DSGpnlTopBar.Controls.Add(this.panel1);
            this.DSGpnlTopBar.Controls.Add(this.pnlOpenAdd);
            this.DSGpnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.DSGpnlTopBar.Location = new System.Drawing.Point(5, 18);
            this.DSGpnlTopBar.Name = "DSGpnlTopBar";
            this.DSGpnlTopBar.Size = new System.Drawing.Size(1045, 62);
            this.DSGpnlTopBar.TabIndex = 7;
            // 
            // pnlTick
            // 
            this.pnlTick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTick.BackColor = System.Drawing.Color.Transparent;
            this.pnlTick.BackgroundImage = global::ParkingStop.Properties.Resources.LogoParkStop;
            this.pnlTick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTick.Location = new System.Drawing.Point(956, 0);
            this.pnlTick.Name = "pnlTick";
            this.pnlTick.Size = new System.Drawing.Size(66, 61);
            this.pnlTick.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ParkingStop.Properties.Resources.CheckOUT;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(545, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(76, 60);
            this.panel1.TabIndex = 11;
            this.panel1.Click += new System.EventHandler(this.pnlRemove_Click);
            // 
            // pnlOpenAdd
            // 
            this.pnlOpenAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlOpenAdd.BackColor = System.Drawing.Color.Transparent;
            this.pnlOpenAdd.BackgroundImage = global::ParkingStop.Properties.Resources.CheckIN;
            this.pnlOpenAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlOpenAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlOpenAdd.Location = new System.Drawing.Point(415, 1);
            this.pnlOpenAdd.Name = "pnlOpenAdd";
            this.pnlOpenAdd.Size = new System.Drawing.Size(76, 60);
            this.pnlOpenAdd.TabIndex = 11;
            this.pnlOpenAdd.Click += new System.EventHandler(this.pnlOpenAdd_Click);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlTopBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTopBar.BackgroundImage")));
            this.pnlTopBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTopBar.Controls.Add(this.lblParkStop);
            this.pnlTopBar.Controls.Add(this.lblDigitalClock);
            this.pnlTopBar.Controls.Add(this.pnlMinimize);
            this.pnlTopBar.Controls.Add(this.pnlMaximize);
            this.pnlTopBar.Controls.Add(this.pnlExit);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(5, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1045, 18);
            this.pnlTopBar.TabIndex = 11;
            this.pnlTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseDown);
            this.pnlTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseMove);
            this.pnlTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseUp);
            // 
            // lblParkStop
            // 
            this.lblParkStop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblParkStop.AutoSize = true;
            this.lblParkStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParkStop.ForeColor = System.Drawing.Color.White;
            this.lblParkStop.Location = new System.Drawing.Point(480, 3);
            this.lblParkStop.Name = "lblParkStop";
            this.lblParkStop.Size = new System.Drawing.Size(89, 13);
            this.lblParkStop.TabIndex = 0;
            this.lblParkStop.Text = "PARKstop App";
            // 
            // lblDigitalClock
            // 
            this.lblDigitalClock.AutoSize = true;
            this.lblDigitalClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitalClock.ForeColor = System.Drawing.Color.White;
            this.lblDigitalClock.Location = new System.Drawing.Point(4, 4);
            this.lblDigitalClock.Name = "lblDigitalClock";
            this.lblDigitalClock.Size = new System.Drawing.Size(57, 13);
            this.lblDigitalClock.TabIndex = 0;
            this.lblDigitalClock.Text = "22:00:00";
            // 
            // pnlMinimize
            // 
            this.pnlMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMinimize.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMinimize.BackgroundImage")));
            this.pnlMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMinimize.Location = new System.Drawing.Point(940, 2);
            this.pnlMinimize.Name = "pnlMinimize";
            this.pnlMinimize.Size = new System.Drawing.Size(15, 15);
            this.pnlMinimize.TabIndex = 11;
            this.pnlMinimize.Click += new System.EventHandler(this.pnlMinimize_Click);
            // 
            // pnlMaximize
            // 
            this.pnlMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMaximize.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMaximize.BackgroundImage = global::ParkingStop.Properties.Resources.Btn_Max;
            this.pnlMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMaximize.Location = new System.Drawing.Point(980, 2);
            this.pnlMaximize.Name = "pnlMaximize";
            this.pnlMaximize.Size = new System.Drawing.Size(15, 15);
            this.pnlMaximize.TabIndex = 11;
            this.pnlMaximize.Click += new System.EventHandler(this.pnlMaximize_Click);
            // 
            // pnlExit
            // 
            this.pnlExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlExit.BackColor = System.Drawing.SystemColors.Control;
            this.pnlExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlExit.BackgroundImage")));
            this.pnlExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlExit.Location = new System.Drawing.Point(1020, 2);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(15, 15);
            this.pnlExit.TabIndex = 11;
            this.pnlExit.Click += new System.EventHandler(this.pnlExit_Click);
            // 
            // pnlLeftBar
            // 
            this.pnlLeftBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeftBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLeftBar.BackgroundImage")));
            this.pnlLeftBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftBar.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftBar.Name = "pnlLeftBar";
            this.pnlLeftBar.Size = new System.Drawing.Size(5, 550);
            this.pnlLeftBar.TabIndex = 12;
            // 
            // pnlCarCount
            // 
            this.pnlCarCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlCarCount.BackColor = System.Drawing.Color.Transparent;
            this.pnlCarCount.Controls.Add(this.lblTotalCar);
            this.pnlCarCount.Controls.Add(this.picBxTotalCar);
            this.pnlCarCount.Location = new System.Drawing.Point(270, 120);
            this.pnlCarCount.Name = "pnlCarCount";
            this.pnlCarCount.Size = new System.Drawing.Size(175, 90);
            this.pnlCarCount.TabIndex = 14;
            this.pnlCarCount.Visible = false;
            // 
            // FrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ParkingStop.Properties.Resources.BG_02;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1050, 550);
            this.Controls.Add(this.pnlChckOut);
            this.Controls.Add(this.pnlAddVehicle);
            this.Controls.Add(this.lblListTotal);
            this.Controls.Add(this.DSGpnlTopBar);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.dGrdViewList);
            this.Controls.Add(this.pnlLeftBar);
            this.Controls.Add(this.pnlCarCount);
            this.Controls.Add(this.pnlSUVCount);
            this.Controls.Add(this.pnlBikeCount);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrontPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParkStop";
            this.DoubleClick += new System.EventHandler(this.FrontPage_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dGrdViewList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxTotalCar)).EndInit();
            this.pnlSUVCount.ResumeLayout(false);
            this.pnlSUVCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxTotalSUV)).EndInit();
            this.pnlBikeCount.ResumeLayout(false);
            this.pnlBikeCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBike)).EndInit();
            this.pnlChckOut.ResumeLayout(false);
            this.pnlChckOut.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxCancelChckOut)).EndInit();
            this.pnlAddVehicle.ResumeLayout(false);
            this.pnlAddVehicle.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxCancel)).EndInit();
            this.DSGpnlTopBar.ResumeLayout(false);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlCarCount.ResumeLayout(false);
            this.pnlCarCount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerDigClock;
        private System.Windows.Forms.Panel pnlTick;
        private System.Windows.Forms.DataGridView dGrdViewList;
        private System.Windows.Forms.Panel pnlAddVehicle;
        private System.Windows.Forms.Label lblModelTxt;
        private System.Windows.Forms.Label lblTagTxt;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.PictureBox picBxCancel;
        private System.Windows.Forms.Label lblTypeTxt;
        public System.Windows.Forms.TextBox txtBoxTag;
        private System.Windows.Forms.Label lblListTotal;
        public System.Windows.Forms.Label lblDigitalClock;
        private System.Windows.Forms.Panel pnlOpenAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.Panel DSGpnlTopBar;
        private System.Windows.Forms.Panel pnlLeftBar;
        private System.Windows.Forms.Panel pnlMaximize;
        private System.Windows.Forms.Panel pnlMinimize;
        public System.Windows.Forms.ComboBox cmbBxVehType;
        public System.Windows.Forms.ComboBox cmbBxVehModel;
        private System.Windows.Forms.Panel pnlChckOut;
        private System.Windows.Forms.PictureBox picBxCancelChckOut;
        private System.Windows.Forms.Label lblTagRemTxt;
        public System.Windows.Forms.TextBox txtBoxToPayChkOut;
        public System.Windows.Forms.TextBox txtBoxTOOut;
        private System.Windows.Forms.Label lblPayChckOut;
        public System.Windows.Forms.TextBox txtBoxTIOut;
        private System.Windows.Forms.Label lblDurationChckOut;
        private System.Windows.Forms.Label lblTimeOutChckOut;
        private System.Windows.Forms.Label lblTimeInChckOut;
        private System.Windows.Forms.Label lblVCheckOut;
        private System.Windows.Forms.Label lblTagCheckOut;
        private System.Windows.Forms.TextBox txtBoxDurChkOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.PictureBox picBxTotalCar;
        private System.Windows.Forms.Label lblTotalCar;
        private System.Windows.Forms.PictureBox picBxTotalSUV;
        private System.Windows.Forms.Label lblTotalSUV;
        private System.Windows.Forms.PictureBox pictureBike;
        private System.Windows.Forms.Label lblTotalBike;
        private System.Windows.Forms.Panel pnlSUVCount;
        private System.Windows.Forms.Panel pnlBikeCount;
        public System.Windows.Forms.Label lblParkStop;
        private System.Windows.Forms.Panel pnlCarCount;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddConfirm;
        private System.Windows.Forms.Panel panel5;
    }
}

