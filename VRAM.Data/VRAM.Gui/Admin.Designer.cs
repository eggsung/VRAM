namespace VRAM.Gui
{
    partial class Admin
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
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.btnNotice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearch
            // 
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UserName,
            this.Password,
            this.PhoneNum,
            this.Email});
            this.dgvSearch.Location = new System.Drawing.Point(30, 121);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.RowTemplate.Height = 27;
            this.dgvSearch.Size = new System.Drawing.Size(745, 317);
            this.dgvSearch.TabIndex = 10;
            this.dgvSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellContentClick);
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // PhoneNum
            // 
            this.PhoneNum.DataPropertyName = "PhoneNum";
            this.PhoneNum.HeaderText = "PhoneNum";
            this.PhoneNum.Name = "PhoneNum";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtMemberName.Location = new System.Drawing.Point(82, 60);
            this.txtMemberName.Multiline = true;
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(171, 37);
            this.txtMemberName.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnDelete.Location = new System.Drawing.Point(498, 60);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 37);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(387, 60);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 37);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnSearch.Location = new System.Drawing.Point(272, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 37);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Font = new System.Drawing.Font("Consolas", 12F);
            this.lbMemberName.Location = new System.Drawing.Point(36, 67);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(40, 23);
            this.lbMemberName.TabIndex = 11;
            this.lbMemberName.Text = "이름";
            // 
            // btnNotice
            // 
            this.btnNotice.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnNotice.Location = new System.Drawing.Point(672, 60);
            this.btnNotice.Name = "btnNotice";
            this.btnNotice.Size = new System.Drawing.Size(83, 37);
            this.btnNotice.TabIndex = 12;
            this.btnNotice.Text = "알림";
            this.btnNotice.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNotice);
            this.Controls.Add(this.lbMemberName);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.Button btnNotice;
    }
}