namespace ParkingStop
{
    partial class VehicleControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleControl));
            this.VehicleControlTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlVCMenu = new System.Windows.Forms.Panel();
            this.lblTESST = new System.Windows.Forms.Label();
            this.btnEndPark = new System.Windows.Forms.Button();
            this.lblTimeIn = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.chkBxWash = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlVCMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // VehicleControlTimer
            // 
            this.VehicleControlTimer.Interval = 1;
            this.VehicleControlTimer.Tick += new System.EventHandler(this.VehicleControlTimer_Tick);
            // 
            // pnlVCMenu
            // 
            this.pnlVCMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlVCMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlVCMenu.BackgroundImage")));
            this.pnlVCMenu.Controls.Add(this.pictureBox1);
            this.pnlVCMenu.Controls.Add(this.chkBxWash);
            this.pnlVCMenu.Controls.Add(this.lblTimeIn);
            this.pnlVCMenu.Controls.Add(this.lblCost);
            this.pnlVCMenu.Controls.Add(this.lblTESST);
            this.pnlVCMenu.Controls.Add(this.btnEndPark);
            this.pnlVCMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVCMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlVCMenu.MaximumSize = new System.Drawing.Size(100, 180);
            this.pnlVCMenu.MinimumSize = new System.Drawing.Size(100, 100);
            this.pnlVCMenu.Name = "pnlVCMenu";
            this.pnlVCMenu.Size = new System.Drawing.Size(100, 100);
            this.pnlVCMenu.TabIndex = 1;
            this.pnlVCMenu.Click += new System.EventHandler(this.pnlVCMenu_Click);
            this.pnlVCMenu.MouseEnter += new System.EventHandler(this.pnlVCMenu_MouseHover);
            this.pnlVCMenu.MouseLeave += new System.EventHandler(this.pnlVCMenu_MouseLeave);
            // 
            // lblTESST
            // 
            this.lblTESST.AutoSize = true;
            this.lblTESST.BackColor = System.Drawing.Color.Transparent;
            this.lblTESST.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTESST.ForeColor = System.Drawing.Color.White;
            this.lblTESST.Location = new System.Drawing.Point(19, 37);
            this.lblTESST.Name = "lblTESST";
            this.lblTESST.Size = new System.Drawing.Size(63, 13);
            this.lblTESST.TabIndex = 3;
            this.lblTESST.Text = "AAA-0000";
            // 
            // btnEndPark
            // 
            this.btnEndPark.BackColor = System.Drawing.Color.Transparent;
            this.btnEndPark.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEndPark.BackgroundImage")));
            this.btnEndPark.FlatAppearance.BorderSize = 0;
            this.btnEndPark.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEndPark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEndPark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndPark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndPark.ForeColor = System.Drawing.Color.White;
            this.btnEndPark.Location = new System.Drawing.Point(0, 155);
            this.btnEndPark.Name = "btnEndPark";
            this.btnEndPark.Size = new System.Drawing.Size(100, 25);
            this.btnEndPark.TabIndex = 2;
            this.btnEndPark.Text = "End Park";
            this.btnEndPark.UseVisualStyleBackColor = false;
            this.btnEndPark.Click += new System.EventHandler(this.btnEndPark_Click);
            // 
            // lblTimeIn
            // 
            this.lblTimeIn.AutoSize = true;
            this.lblTimeIn.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeIn.ForeColor = System.Drawing.Color.White;
            this.lblTimeIn.Location = new System.Drawing.Point(26, 56);
            this.lblTimeIn.Name = "lblTimeIn";
            this.lblTimeIn.Size = new System.Drawing.Size(49, 13);
            this.lblTimeIn.TabIndex = 3;
            this.lblTimeIn.Text = "00:00:00";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.White;
            this.lblCost.Location = new System.Drawing.Point(40, 78);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(21, 13);
            this.lblCost.TabIndex = 3;
            this.lblCost.Text = "$0";
            // 
            // chkBxWash
            // 
            this.chkBxWash.AutoSize = true;
            this.chkBxWash.ForeColor = System.Drawing.Color.White;
            this.chkBxWash.Location = new System.Drawing.Point(8, 115);
            this.chkBxWash.Name = "chkBxWash";
            this.chkBxWash.Size = new System.Drawing.Size(70, 17);
            this.chkBxWash.TabIndex = 4;
            this.chkBxWash.Text = "WashCar";
            this.chkBxWash.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(16, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 30);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // VehicleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlVCMenu);
            this.MaximumSize = new System.Drawing.Size(100, 200);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "VehicleControl";
            this.Size = new System.Drawing.Size(100, 200);
            this.pnlVCMenu.ResumeLayout(false);
            this.pnlVCMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer VehicleControlTimer;
        private System.Windows.Forms.Button btnEndPark;
        public System.Windows.Forms.Panel pnlVCMenu;
        public System.Windows.Forms.Label lblTESST;
        public System.Windows.Forms.Label lblTimeIn;
        public System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.CheckBox chkBxWash;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
