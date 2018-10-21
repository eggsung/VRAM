namespace VRAM.Gui
{
    partial class BoardForm
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
            this.lbBoard = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.tabMenus = new System.Windows.Forms.TabControl();
            this.t_Qlist = new System.Windows.Forms.TabPage();
            this.btnWrite = new System.Windows.Forms.Button();
            this.db_Qlist = new System.Windows.Forms.DataGridView();
            this.t_MQlist = new System.Windows.Forms.TabPage();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.db_MQlist = new System.Windows.Forms.DataGridView();
            this.t_AttSit = new System.Windows.Forms.TabPage();
            this.db_AttSit = new System.Windows.Forms.DataGridView();
            this.btnEntry = new System.Windows.Forms.Button();
            this.tabMenus.SuspendLayout();
            this.t_Qlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_Qlist)).BeginInit();
            this.t_MQlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_MQlist)).BeginInit();
            this.t_AttSit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_AttSit)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBoard
            // 
            this.lbBoard.AutoSize = true;
            this.lbBoard.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBoard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbBoard.Location = new System.Drawing.Point(32, 31);
            this.lbBoard.Name = "lbBoard";
            this.lbBoard.Size = new System.Drawing.Size(141, 56);
            this.lbBoard.TabIndex = 7;
            this.lbBoard.Text = "게시판";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(677, 48);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(103, 50);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "관리";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // tabMenus
            // 
            this.tabMenus.Controls.Add(this.t_Qlist);
            this.tabMenus.Controls.Add(this.t_MQlist);
            this.tabMenus.Controls.Add(this.t_AttSit);
            this.tabMenus.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMenus.Location = new System.Drawing.Point(15, 139);
            this.tabMenus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabMenus.Name = "tabMenus";
            this.tabMenus.SelectedIndex = 0;
            this.tabMenus.Size = new System.Drawing.Size(776, 389);
            this.tabMenus.TabIndex = 5;
            // 
            // t_Qlist
            // 
            this.t_Qlist.Controls.Add(this.btnWrite);
            this.t_Qlist.Controls.Add(this.db_Qlist);
            this.t_Qlist.Location = new System.Drawing.Point(4, 32);
            this.t_Qlist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.t_Qlist.Name = "t_Qlist";
            this.t_Qlist.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.t_Qlist.Size = new System.Drawing.Size(768, 353);
            this.t_Qlist.TabIndex = 0;
            this.t_Qlist.Text = "질문목록";
            this.t_Qlist.UseVisualStyleBackColor = true;
            // 
            // btnWrite
            // 
            this.btnWrite.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.Location = new System.Drawing.Point(658, 301);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(103, 42);
            this.btnWrite.TabIndex = 4;
            this.btnWrite.Text = "글쓰기";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // db_Qlist
            // 
            this.db_Qlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_Qlist.Location = new System.Drawing.Point(4, 5);
            this.db_Qlist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.db_Qlist.Name = "db_Qlist";
            this.db_Qlist.RowTemplate.Height = 27;
            this.db_Qlist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.db_Qlist.Size = new System.Drawing.Size(761, 290);
            this.db_Qlist.TabIndex = 0;
            // 
            // t_MQlist
            // 
            this.t_MQlist.Controls.Add(this.btn_Delete);
            this.t_MQlist.Controls.Add(this.btn_Modify);
            this.t_MQlist.Controls.Add(this.db_MQlist);
            this.t_MQlist.Location = new System.Drawing.Point(4, 32);
            this.t_MQlist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.t_MQlist.Name = "t_MQlist";
            this.t_MQlist.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.t_MQlist.Size = new System.Drawing.Size(768, 353);
            this.t_MQlist.TabIndex = 1;
            this.t_MQlist.Text = "내가 작성한 목록";
            this.t_MQlist.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(659, 184);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(103, 155);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "삭제";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Modify
            // 
            this.btn_Modify.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modify.Location = new System.Drawing.Point(658, 5);
            this.btn_Modify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(103, 155);
            this.btn_Modify.TabIndex = 1;
            this.btn_Modify.Text = "수정";
            this.btn_Modify.UseVisualStyleBackColor = true;
            // 
            // db_MQlist
            // 
            this.db_MQlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_MQlist.Location = new System.Drawing.Point(4, 5);
            this.db_MQlist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.db_MQlist.Name = "db_MQlist";
            this.db_MQlist.RowTemplate.Height = 27;
            this.db_MQlist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.db_MQlist.Size = new System.Drawing.Size(648, 337);
            this.db_MQlist.TabIndex = 0;
            // 
            // t_AttSit
            // 
            this.t_AttSit.Controls.Add(this.db_AttSit);
            this.t_AttSit.Location = new System.Drawing.Point(4, 32);
            this.t_AttSit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.t_AttSit.Name = "t_AttSit";
            this.t_AttSit.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.t_AttSit.Size = new System.Drawing.Size(768, 353);
            this.t_AttSit.TabIndex = 2;
            this.t_AttSit.Text = "출결 현황";
            this.t_AttSit.UseVisualStyleBackColor = true;
            // 
            // db_AttSit
            // 
            this.db_AttSit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_AttSit.Location = new System.Drawing.Point(4, 5);
            this.db_AttSit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.db_AttSit.Name = "db_AttSit";
            this.db_AttSit.RowTemplate.Height = 27;
            this.db_AttSit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.db_AttSit.Size = new System.Drawing.Size(757, 342);
            this.db_AttSit.TabIndex = 0;
            // 
            // btnEntry
            // 
            this.btnEntry.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntry.Location = new System.Drawing.Point(554, 49);
            this.btnEntry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(103, 50);
            this.btnEntry.TabIndex = 4;
            this.btnEntry.Text = "입/퇴실";
            this.btnEntry.UseVisualStyleBackColor = true;
            // 
            // BoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.lbBoard);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.tabMenus);
            this.Controls.Add(this.btnEntry);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Board";
            this.tabMenus.ResumeLayout(false);
            this.t_Qlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_Qlist)).EndInit();
            this.t_MQlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_MQlist)).EndInit();
            this.t_AttSit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_AttSit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBoard;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.TabControl tabMenus;
        private System.Windows.Forms.TabPage t_Qlist;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.DataGridView db_Qlist;
        private System.Windows.Forms.TabPage t_MQlist;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.DataGridView db_MQlist;
        private System.Windows.Forms.TabPage t_AttSit;
        private System.Windows.Forms.DataGridView db_AttSit;
        private System.Windows.Forms.Button btnEntry;
    }
}