namespace ParkingStop.Forms
{
    partial class AddVehicleBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVehicleBox));
            this.picBxCancel = new System.Windows.Forms.PictureBox();
            this.btnAddConfirm = new System.Windows.Forms.Button();
            this.cmbBxVehType = new System.Windows.Forms.ComboBox();
            this.cmbBxVehModel = new System.Windows.Forms.ComboBox();
            this.txtBoxTag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblModelTxt = new System.Windows.Forms.Label();
            this.lblTagTxt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBxCancel)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBxCancel
            // 
            this.picBxCancel.BackColor = System.Drawing.SystemColors.Desktop;
            this.picBxCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBxCancel.Location = new System.Drawing.Point(284, 0);
            this.picBxCancel.Name = "picBxCancel";
            this.picBxCancel.Size = new System.Drawing.Size(55, 25);
            this.picBxCancel.TabIndex = 10;
            this.picBxCancel.TabStop = false;
            this.picBxCancel.Click += new System.EventHandler(this.picBxCancel_Click);
            // 
            // btnAddConfirm
            // 
            this.btnAddConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnAddConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddConfirm.BackgroundImage")));
            this.btnAddConfirm.FlatAppearance.BorderSize = 0;
            this.btnAddConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnAddConfirm.Location = new System.Drawing.Point(88, 190);
            this.btnAddConfirm.Name = "btnAddConfirm";
            this.btnAddConfirm.Size = new System.Drawing.Size(127, 23);
            this.btnAddConfirm.TabIndex = 11;
            this.btnAddConfirm.Text = "Add Vehicle";
            this.btnAddConfirm.UseVisualStyleBackColor = false;
            this.btnAddConfirm.Click += new System.EventHandler(this.btnAddConfirm_Click);
            // 
            // cmbBxVehType
            // 
            this.cmbBxVehType.FormattingEnabled = true;
            this.cmbBxVehType.Items.AddRange(new object[] {
            "Car",
            "SUV",
            "MotorCycle"});
            this.cmbBxVehType.Location = new System.Drawing.Point(88, 101);
            this.cmbBxVehType.Name = "cmbBxVehType";
            this.cmbBxVehType.Size = new System.Drawing.Size(127, 21);
            this.cmbBxVehType.TabIndex = 8;
            // 
            // cmbBxVehModel
            // 
            this.cmbBxVehModel.FormattingEnabled = true;
            this.cmbBxVehModel.Items.AddRange(new object[] {
            "Fiat",
            "Ford"});
            this.cmbBxVehModel.Location = new System.Drawing.Point(88, 147);
            this.cmbBxVehModel.Name = "cmbBxVehModel";
            this.cmbBxVehModel.Size = new System.Drawing.Size(127, 21);
            this.cmbBxVehModel.TabIndex = 9;
            // 
            // txtBoxTag
            // 
            this.txtBoxTag.Location = new System.Drawing.Point(88, 58);
            this.txtBoxTag.Name = "txtBoxTag";
            this.txtBoxTag.Size = new System.Drawing.Size(127, 20);
            this.txtBoxTag.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(114, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vehicle Type";
            // 
            // lblModelTxt
            // 
            this.lblModelTxt.AutoSize = true;
            this.lblModelTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblModelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelTxt.ForeColor = System.Drawing.SystemColors.Control;
            this.lblModelTxt.Location = new System.Drawing.Point(114, 131);
            this.lblModelTxt.Name = "lblModelTxt";
            this.lblModelTxt.Size = new System.Drawing.Size(87, 13);
            this.lblModelTxt.TabIndex = 5;
            this.lblModelTxt.Text = "Vehicle Model";
            // 
            // lblTagTxt
            // 
            this.lblTagTxt.AutoSize = true;
            this.lblTagTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblTagTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagTxt.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTagTxt.Location = new System.Drawing.Point(121, 42);
            this.lblTagTxt.Name = "lblTagTxt";
            this.lblTagTxt.Size = new System.Drawing.Size(71, 13);
            this.lblTagTxt.TabIndex = 6;
            this.lblTagTxt.Text = "Vehicle tag";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lblTagTxt);
            this.panel1.Controls.Add(this.lblModelTxt);
            this.panel1.Controls.Add(this.btnAddConfirm);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbBxVehType);
            this.panel1.Controls.Add(this.txtBoxTag);
            this.panel1.Controls.Add(this.cmbBxVehModel);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 282);
            this.panel1.TabIndex = 12;
            // 
            // AddVehicleBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(339, 293);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picBxCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddVehicleBox";
            this.Text = "AddVehicleBox";
            ((System.ComponentModel.ISupportInitialize)(this.picBxCancel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBxCancel;
        private System.Windows.Forms.Button btnAddConfirm;
        private System.Windows.Forms.ComboBox cmbBxVehType;
        private System.Windows.Forms.ComboBox cmbBxVehModel;
        public System.Windows.Forms.TextBox txtBoxTag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblModelTxt;
        private System.Windows.Forms.Label lblTagTxt;
        private System.Windows.Forms.Panel panel1;
    }
}