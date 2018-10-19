namespace VRAM.Gui
{
    partial class RegisterForm
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
            this.rbMember = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.CtrlPanel = new System.Windows.Forms.Panel();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.lbMemberId = new System.Windows.Forms.Label();
            this.CtrlPanel2 = new System.Windows.Forms.Panel();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.CtrlPanel3 = new System.Windows.Forms.Panel();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.lbPhoneNum = new System.Windows.Forms.Label();
            this.CtrlPanel4 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.CtrlPanel5 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.CtrlPanel.SuspendLayout();
            this.CtrlPanel2.SuspendLayout();
            this.CtrlPanel3.SuspendLayout();
            this.CtrlPanel4.SuspendLayout();
            this.CtrlPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbMember
            // 
            this.rbMember.AutoSize = true;
            this.rbMember.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMember.Location = new System.Drawing.Point(395, 106);
            this.rbMember.Margin = new System.Windows.Forms.Padding(4);
            this.rbMember.Name = "rbMember";
            this.rbMember.Size = new System.Drawing.Size(91, 26);
            this.rbMember.TabIndex = 43;
            this.rbMember.TabStop = true;
            this.rbMember.Text = "Member";
            this.rbMember.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdmin.Location = new System.Drawing.Point(149, 106);
            this.rbAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(81, 26);
            this.rbAdmin.TabIndex = 42;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(395, 468);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(205, 56);
            this.btnRegister.TabIndex = 33;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Consolas", 28F);
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbTitle.Location = new System.Drawing.Point(207, 28);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(232, 55);
            this.lbTitle.TabIndex = 31;
            this.lbTitle.Text = "Register";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CtrlPanel
            // 
            this.CtrlPanel.Controls.Add(this.txtMemberId);
            this.CtrlPanel.Controls.Add(this.lbMemberId);
            this.CtrlPanel.Location = new System.Drawing.Point(58, 168);
            this.CtrlPanel.Name = "CtrlPanel";
            this.CtrlPanel.Size = new System.Drawing.Size(543, 48);
            this.CtrlPanel.TabIndex = 44;
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(148, 13);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(394, 29);
            this.txtMemberId.TabIndex = 1;
            // 
            // lbMemberId
            // 
            this.lbMemberId.AutoSize = true;
            this.lbMemberId.Location = new System.Drawing.Point(3, 16);
            this.lbMemberId.Name = "lbMemberId";
            this.lbMemberId.Size = new System.Drawing.Size(90, 22);
            this.lbMemberId.TabIndex = 0;
            this.lbMemberId.Text = "MemberID";
            // 
            // CtrlPanel2
            // 
            this.CtrlPanel2.Controls.Add(this.txtMemberName);
            this.CtrlPanel2.Controls.Add(this.lbMemberName);
            this.CtrlPanel2.Location = new System.Drawing.Point(58, 222);
            this.CtrlPanel2.Name = "CtrlPanel2";
            this.CtrlPanel2.Size = new System.Drawing.Size(543, 48);
            this.CtrlPanel2.TabIndex = 45;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(148, 13);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(394, 29);
            this.txtMemberName.TabIndex = 1;
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Location = new System.Drawing.Point(3, 16);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(120, 22);
            this.lbMemberName.TabIndex = 0;
            this.lbMemberName.Text = "Member Name";
            // 
            // CtrlPanel3
            // 
            this.CtrlPanel3.Controls.Add(this.txtPhoneNum);
            this.CtrlPanel3.Controls.Add(this.lbPhoneNum);
            this.CtrlPanel3.Location = new System.Drawing.Point(58, 276);
            this.CtrlPanel3.Name = "CtrlPanel3";
            this.CtrlPanel3.Size = new System.Drawing.Size(543, 48);
            this.CtrlPanel3.TabIndex = 46;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(148, 13);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(394, 29);
            this.txtPhoneNum.TabIndex = 1;
            // 
            // lbPhoneNum
            // 
            this.lbPhoneNum.AutoSize = true;
            this.lbPhoneNum.Location = new System.Drawing.Point(3, 16);
            this.lbPhoneNum.Name = "lbPhoneNum";
            this.lbPhoneNum.Size = new System.Drawing.Size(110, 22);
            this.lbPhoneNum.TabIndex = 0;
            this.lbPhoneNum.Text = "Mobile No.";
            // 
            // CtrlPanel4
            // 
            this.CtrlPanel4.Controls.Add(this.txtEmail);
            this.CtrlPanel4.Controls.Add(this.lbEmail);
            this.CtrlPanel4.Location = new System.Drawing.Point(58, 330);
            this.CtrlPanel4.Name = "CtrlPanel4";
            this.CtrlPanel4.Size = new System.Drawing.Size(543, 48);
            this.CtrlPanel4.TabIndex = 46;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(148, 13);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(394, 29);
            this.txtEmail.TabIndex = 1;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(3, 16);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(60, 22);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email";
            // 
            // CtrlPanel5
            // 
            this.CtrlPanel5.Controls.Add(this.txtPassword);
            this.CtrlPanel5.Controls.Add(this.lbPassword);
            this.CtrlPanel5.Location = new System.Drawing.Point(58, 393);
            this.CtrlPanel5.Name = "CtrlPanel5";
            this.CtrlPanel5.Size = new System.Drawing.Size(543, 48);
            this.CtrlPanel5.TabIndex = 46;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(148, 13);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(394, 29);
            this.txtPassword.TabIndex = 1;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(3, 16);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(90, 22);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Password";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(58, 468);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(205, 56);
            this.btnReset.TabIndex = 47;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 554);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.CtrlPanel5);
            this.Controls.Add(this.CtrlPanel4);
            this.Controls.Add(this.CtrlPanel3);
            this.Controls.Add(this.CtrlPanel2);
            this.Controls.Add(this.CtrlPanel);
            this.Controls.Add(this.rbMember);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.CtrlPanel.ResumeLayout(false);
            this.CtrlPanel.PerformLayout();
            this.CtrlPanel2.ResumeLayout(false);
            this.CtrlPanel2.PerformLayout();
            this.CtrlPanel3.ResumeLayout(false);
            this.CtrlPanel3.PerformLayout();
            this.CtrlPanel4.ResumeLayout(false);
            this.CtrlPanel4.PerformLayout();
            this.CtrlPanel5.ResumeLayout(false);
            this.CtrlPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbMember;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel CtrlPanel;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label lbMemberId;
        private System.Windows.Forms.Panel CtrlPanel2;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.Panel CtrlPanel3;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label lbPhoneNum;
        private System.Windows.Forms.Panel CtrlPanel4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Panel CtrlPanel5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnReset;
    }
}