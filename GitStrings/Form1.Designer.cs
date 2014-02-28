namespace GitStrings
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
            this.strTitle = new System.Windows.Forms.Label();
            this.strName = new System.Windows.Forms.Label();
            this.strSubTitle = new System.Windows.Forms.Label();
            this.strAddress = new System.Windows.Forms.Label();
            this.strCity = new System.Windows.Forms.Label();
            this.strState = new System.Windows.Forms.Label();
            this.strZip = new System.Windows.Forms.Label();
            this.strPhone = new System.Windows.Forms.Label();
            this.strHelpLine = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.tbZip = new System.Windows.Forms.TextBox();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // strTitle
            // 
            this.strTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.strTitle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strTitle.Location = new System.Drawing.Point(26, 26);
            this.strTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.strTitle.Name = "strTitle";
            this.strTitle.Size = new System.Drawing.Size(424, 22);
            this.strTitle.TabIndex = 0;
            this.strTitle.Text = "strTitle";
            this.strTitle.Click += new System.EventHandler(this.strTitle_Click);
            // 
            // strName
            // 
            this.strName.AutoSize = true;
            this.strName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strName.Location = new System.Drawing.Point(26, 111);
            this.strName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.strName.Name = "strName";
            this.strName.Size = new System.Drawing.Size(57, 16);
            this.strName.TabIndex = 1;
            this.strName.Text = "strName";
            // 
            // strSubTitle
            // 
            this.strSubTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.strSubTitle.Location = new System.Drawing.Point(26, 48);
            this.strSubTitle.Name = "strSubTitle";
            this.strSubTitle.Size = new System.Drawing.Size(420, 39);
            this.strSubTitle.TabIndex = 2;
            this.strSubTitle.Text = "strSubTitle";
            // 
            // strAddress
            // 
            this.strAddress.AutoSize = true;
            this.strAddress.Location = new System.Drawing.Point(26, 137);
            this.strAddress.Name = "strAddress";
            this.strAddress.Size = new System.Drawing.Size(71, 16);
            this.strAddress.TabIndex = 3;
            this.strAddress.Text = "strAddress";
            // 
            // strCity
            // 
            this.strCity.AutoSize = true;
            this.strCity.Location = new System.Drawing.Point(26, 163);
            this.strCity.Name = "strCity";
            this.strCity.Size = new System.Drawing.Size(46, 16);
            this.strCity.TabIndex = 4;
            this.strCity.Text = "strCity";
            // 
            // strState
            // 
            this.strState.AutoSize = true;
            this.strState.Location = new System.Drawing.Point(26, 189);
            this.strState.Name = "strState";
            this.strState.Size = new System.Drawing.Size(54, 16);
            this.strState.TabIndex = 5;
            this.strState.Text = "strState";
            // 
            // strZip
            // 
            this.strZip.AutoSize = true;
            this.strZip.Location = new System.Drawing.Point(26, 215);
            this.strZip.Name = "strZip";
            this.strZip.Size = new System.Drawing.Size(40, 16);
            this.strZip.TabIndex = 6;
            this.strZip.Text = "strZip";
            // 
            // strPhone
            // 
            this.strPhone.AutoSize = true;
            this.strPhone.Location = new System.Drawing.Point(26, 241);
            this.strPhone.Name = "strPhone";
            this.strPhone.Size = new System.Drawing.Size(60, 16);
            this.strPhone.TabIndex = 7;
            this.strPhone.Text = "strPhone";
            // 
            // strHelpLine
            // 
            this.strHelpLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.strHelpLine.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strHelpLine.Location = new System.Drawing.Point(26, 283);
            this.strHelpLine.Name = "strHelpLine";
            this.strHelpLine.Size = new System.Drawing.Size(420, 34);
            this.strHelpLine.TabIndex = 8;
            this.strHelpLine.Text = "strHelpLine";
            // 
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDone.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(29, 376);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(149, 108);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(237, 22);
            this.tbName.TabIndex = 10;
            this.tbName.Enter += new System.EventHandler(this.tbName_Enter);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(149, 134);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(237, 22);
            this.tbAddress.TabIndex = 11;
            this.tbAddress.Enter += new System.EventHandler(this.tbAddress_Enter);
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(149, 160);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(237, 22);
            this.tbCity.TabIndex = 12;
            this.tbCity.Enter += new System.EventHandler(this.tbCity_Enter);
            // 
            // tbState
            // 
            this.tbState.Location = new System.Drawing.Point(149, 186);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(81, 22);
            this.tbState.TabIndex = 13;
            this.tbState.Enter += new System.EventHandler(this.tbState_Enter);
            // 
            // tbZip
            // 
            this.tbZip.Location = new System.Drawing.Point(149, 212);
            this.tbZip.Name = "tbZip";
            this.tbZip.Size = new System.Drawing.Size(81, 22);
            this.tbZip.TabIndex = 14;
            this.tbZip.Enter += new System.EventHandler(this.tbZip_Enter);
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(149, 238);
            this.mtbPhone.Mask = "(999) 000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(116, 22);
            this.mtbPhone.TabIndex = 15;
            this.mtbPhone.Enter += new System.EventHandler(this.mtbPhone_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(478, 425);
            this.Controls.Add(this.mtbPhone);
            this.Controls.Add(this.tbZip);
            this.Controls.Add(this.tbState);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.strHelpLine);
            this.Controls.Add(this.strPhone);
            this.Controls.Add(this.strZip);
            this.Controls.Add(this.strState);
            this.Controls.Add(this.strCity);
            this.Controls.Add(this.strAddress);
            this.Controls.Add(this.strSubTitle);
            this.Controls.Add(this.strName);
            this.Controls.Add(this.strTitle);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Git Strings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label strTitle;
        private System.Windows.Forms.Label strName;
        private System.Windows.Forms.Label strSubTitle;
        private System.Windows.Forms.Label strAddress;
        private System.Windows.Forms.Label strCity;
        private System.Windows.Forms.Label strState;
        private System.Windows.Forms.Label strZip;
        private System.Windows.Forms.Label strPhone;
        private System.Windows.Forms.Label strHelpLine;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.TextBox tbZip;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
    }
}

