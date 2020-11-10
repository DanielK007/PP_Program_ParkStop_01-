namespace ParkingStop.Forms
{
    partial class AppExit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppExit));
            this.lblMsgExitTxt = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlMessage = new System.Windows.Forms.Panel();
            this.lblConfirmTxt = new System.Windows.Forms.Label();
            this.pnlMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMsgExitTxt
            // 
            this.lblMsgExitTxt.AutoSize = true;
            this.lblMsgExitTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgExitTxt.ForeColor = System.Drawing.Color.White;
            this.lblMsgExitTxt.Location = new System.Drawing.Point(7, 9);
            this.lblMsgExitTxt.Name = "lblMsgExitTxt";
            this.lblMsgExitTxt.Size = new System.Drawing.Size(231, 13);
            this.lblMsgExitTxt.TabIndex = 0;
            this.lblMsgExitTxt.Text = "You are about to quit the StopPark App";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(153, 109);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(54, 109);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlMessage
            // 
            this.pnlMessage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMessage.BackgroundImage")));
            this.pnlMessage.Controls.Add(this.lblMsgExitTxt);
            this.pnlMessage.Location = new System.Drawing.Point(0, 10);
            this.pnlMessage.Name = "pnlMessage";
            this.pnlMessage.Size = new System.Drawing.Size(252, 30);
            this.pnlMessage.TabIndex = 2;
            // 
            // lblConfirmTxt
            // 
            this.lblConfirmTxt.AutoSize = true;
            this.lblConfirmTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmTxt.ForeColor = System.Drawing.Color.White;
            this.lblConfirmTxt.Location = new System.Drawing.Point(78, 69);
            this.lblConfirmTxt.Name = "lblConfirmTxt";
            this.lblConfirmTxt.Size = new System.Drawing.Size(110, 17);
            this.lblConfirmTxt.TabIndex = 0;
            this.lblConfirmTxt.Text = "Confirm to Quit?";
            // 
            // AppExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.lblConfirmTxt);
            this.Controls.Add(this.pnlMessage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExit);
            this.Name = "AppExit";
            this.Size = new System.Drawing.Size(279, 150);
            this.pnlMessage.ResumeLayout(false);
            this.pnlMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsgExitTxt;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlMessage;
        private System.Windows.Forms.Label lblConfirmTxt;
    }
}
