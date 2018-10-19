namespace VRAM.Gui
{
    partial class LoginForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbMemberId = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtMemeberId = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnLogin.Location = new System.Drawing.Point(353, 297);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(160, 51);
            this.btnLogin.TabIndex = 21;
            this.btnLogin.Text = "Login(&L)";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnRegister.Location = new System.Drawing.Point(58, 297);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(160, 51);
            this.btnRegister.TabIndex = 20;
            this.btnRegister.Text = "Register(&R)";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbMemberId
            // 
            this.lbMemberId.AutoSize = true;
            this.lbMemberId.Font = new System.Drawing.Font("Consolas", 12F);
            this.lbMemberId.Location = new System.Drawing.Point(54, 168);
            this.lbMemberId.Name = "lbMemberId";
            this.lbMemberId.Size = new System.Drawing.Size(109, 23);
            this.lbMemberId.TabIndex = 19;
            this.lbMemberId.Text = "Member ID";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Consolas", 12F);
            this.lbPassword.Location = new System.Drawing.Point(54, 234);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(98, 23);
            this.lbPassword.TabIndex = 16;
            this.lbPassword.Text = "Password";
            // 
            // txtMemeberId
            // 
            this.txtMemeberId.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtMemeberId.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMemeberId.Location = new System.Drawing.Point(200, 170);
            this.txtMemeberId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemeberId.Name = "txtMemeberId";
            this.txtMemeberId.Size = new System.Drawing.Size(313, 31);
            this.txtMemeberId.TabIndex = 17;
            this.txtMemeberId.Text = "Member ID";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPassword.Location = new System.Drawing.Point(200, 231);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(313, 31);
            this.txtPassword.TabIndex = 18;
            this.txtPassword.Text = "Password";
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Consolas", 28F, System.Drawing.FontStyle.Bold);
            this.lbWelcome.Location = new System.Drawing.Point(44, 40);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(206, 55);
            this.lbWelcome.TabIndex = 22;
            this.lbWelcome.Text = "WELCOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F);
            this.label2.Location = new System.Drawing.Point(50, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Login to get Started!";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 388);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lbMemberId);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtMemeberId);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lbMemberId;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtMemeberId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Label label2;
    }
}

