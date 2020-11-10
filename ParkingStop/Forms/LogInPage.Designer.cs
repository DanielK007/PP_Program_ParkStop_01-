namespace ParkingStop.Forms
{
    partial class LogInPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInPage));
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.pnlTick = new System.Windows.Forms.Panel();
            this.pnlMessage = new System.Windows.Forms.Panel();
            this.lblMsgExitTxt = new System.Windows.Forms.Label();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.lblTagTxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.lblClear = new System.Windows.Forms.Label();
            this.pnlInvalid = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.chkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.pnlMessage.SuspendLayout();
            this.pnlInvalid.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(73, 374);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlExit
            // 
            this.pnlExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlExit.BackColor = System.Drawing.SystemColors.Control;
            this.pnlExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlExit.BackgroundImage")));
            this.pnlExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlExit.Location = new System.Drawing.Point(198, 14);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(15, 15);
            this.pnlExit.TabIndex = 12;
            this.pnlExit.Click += new System.EventHandler(this.pnlExit_Click);
            // 
            // pnlTick
            // 
            this.pnlTick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTick.BackColor = System.Drawing.Color.Transparent;
            this.pnlTick.BackgroundImage = global::ParkingStop.Properties.Resources.LogoParkStop;
            this.pnlTick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTick.Location = new System.Drawing.Point(42, 67);
            this.pnlTick.Name = "pnlTick";
            this.pnlTick.Size = new System.Drawing.Size(136, 133);
            this.pnlTick.TabIndex = 13;
            // 
            // pnlMessage
            // 
            this.pnlMessage.BackColor = System.Drawing.Color.Transparent;
            this.pnlMessage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMessage.BackgroundImage")));
            this.pnlMessage.Controls.Add(this.lblMsgExitTxt);
            this.pnlMessage.Location = new System.Drawing.Point(-3, 8);
            this.pnlMessage.Name = "pnlMessage";
            this.pnlMessage.Size = new System.Drawing.Size(167, 30);
            this.pnlMessage.TabIndex = 14;
            // 
            // lblMsgExitTxt
            // 
            this.lblMsgExitTxt.AutoSize = true;
            this.lblMsgExitTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblMsgExitTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgExitTxt.ForeColor = System.Drawing.Color.White;
            this.lblMsgExitTxt.Location = new System.Drawing.Point(57, 8);
            this.lblMsgExitTxt.Name = "lblMsgExitTxt";
            this.lblMsgExitTxt.Size = new System.Drawing.Size(89, 13);
            this.lblMsgExitTxt.TabIndex = 0;
            this.lblMsgExitTxt.Text = "Park Stop App";
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxUser.ForeColor = System.Drawing.SystemColors.Control;
            this.txtBoxUser.Location = new System.Drawing.Point(45, 262);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(127, 20);
            this.txtBoxUser.TabIndex = 16;
            // 
            // lblTagTxt
            // 
            this.lblTagTxt.AutoSize = true;
            this.lblTagTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblTagTxt.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTagTxt.Location = new System.Drawing.Point(94, 246);
            this.lblTagTxt.Name = "lblTagTxt";
            this.lblTagTxt.Size = new System.Drawing.Size(78, 13);
            this.lblTagTxt.TabIndex = 15;
            this.lblTagTxt.Text = "User (User = a)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(82, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Password (Passowrd = 1)";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.txtBoxPassword.Location = new System.Drawing.Point(45, 308);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(127, 20);
            this.txtBoxPassword.TabIndex = 16;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.BackColor = System.Drawing.Color.Transparent;
            this.lblClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblClear.Location = new System.Drawing.Point(86, 413);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(45, 13);
            this.lblClear.TabIndex = 15;
            this.lblClear.Text = "Clear All";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // pnlInvalid
            // 
            this.pnlInvalid.BackColor = System.Drawing.Color.Transparent;
            this.pnlInvalid.BackgroundImage = global::ParkingStop.Properties.Resources.BG_50Blck;
            this.pnlInvalid.Controls.Add(this.label2);
            this.pnlInvalid.Location = new System.Drawing.Point(59, 216);
            this.pnlInvalid.Name = "pnlInvalid";
            this.pnlInvalid.Size = new System.Drawing.Size(101, 20);
            this.pnlInvalid.TabIndex = 14;
            this.pnlInvalid.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Invalid Login";
            // 
            // chkBoxShowPass
            // 
            this.chkBoxShowPass.AutoSize = true;
            this.chkBoxShowPass.BackColor = System.Drawing.Color.Transparent;
            this.chkBoxShowPass.ForeColor = System.Drawing.SystemColors.Control;
            this.chkBoxShowPass.Location = new System.Drawing.Point(57, 335);
            this.chkBoxShowPass.Name = "chkBoxShowPass";
            this.chkBoxShowPass.Size = new System.Drawing.Size(102, 17);
            this.chkBoxShowPass.TabIndex = 17;
            this.chkBoxShowPass.Text = "Show Password";
            this.chkBoxShowPass.UseVisualStyleBackColor = false;
            this.chkBoxShowPass.CheckedChanged += new System.EventHandler(this.chkBoxShowPass_CheckedChanged);
            // 
            // LogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ParkingStop.Properties.Resources.BG_75Blck;
            this.ClientSize = new System.Drawing.Size(225, 450);
            this.Controls.Add(this.chkBoxShowPass);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxUser);
            this.Controls.Add(this.lblTagTxt);
            this.Controls.Add(this.pnlInvalid);
            this.Controls.Add(this.pnlMessage);
            this.Controls.Add(this.pnlTick);
            this.Controls.Add(this.pnlExit);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInPage";
            this.pnlMessage.ResumeLayout(false);
            this.pnlMessage.PerformLayout();
            this.pnlInvalid.ResumeLayout(false);
            this.pnlInvalid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.Panel pnlTick;
        private System.Windows.Forms.Panel pnlMessage;
        private System.Windows.Forms.Label lblMsgExitTxt;
        public System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.Label lblTagTxt;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.Panel pnlInvalid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkBoxShowPass;
    }
}