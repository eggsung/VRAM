﻿namespace VRAM.Gui
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
            this.lbl_Board = new System.Windows.Forms.Label();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabMenus.SuspendLayout();
            this.t_Qlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_Qlist)).BeginInit();
            this.t_MQlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_MQlist)).BeginInit();
            this.t_AttSit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_AttSit)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Board
            // 
            this.lbl_Board.AutoSize = true;
            this.lbl_Board.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Board.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Board.Location = new System.Drawing.Point(32, 26);
            this.lbl_Board.Name = "lbl_Board";
            this.lbl_Board.Size = new System.Drawing.Size(141, 56);
            this.lbl_Board.TabIndex = 7;
            this.lbl_Board.Text = "게시판";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(575, 41);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(103, 42);
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
            this.tabMenus.Location = new System.Drawing.Point(15, 116);
            this.tabMenus.Name = "tabMenus";
            this.tabMenus.SelectedIndex = 0;
            this.tabMenus.Size = new System.Drawing.Size(776, 324);
            this.tabMenus.TabIndex = 5;
            this.tabMenus.SelectedIndexChanged += new System.EventHandler(this.tabMenus_SelectedIndexChanged);
            // 
            // t_Qlist
            // 
            this.t_Qlist.Controls.Add(this.btnWrite);
            this.t_Qlist.Controls.Add(this.db_Qlist);
            this.t_Qlist.Location = new System.Drawing.Point(4, 32);
            this.t_Qlist.Name = "t_Qlist";
            this.t_Qlist.Padding = new System.Windows.Forms.Padding(3);
            this.t_Qlist.Size = new System.Drawing.Size(768, 288);
            this.t_Qlist.TabIndex = 0;
            this.t_Qlist.Text = "질문목록";
            this.t_Qlist.UseVisualStyleBackColor = true;
            // 
            // btnWrite
            // 
            this.btnWrite.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.Location = new System.Drawing.Point(658, 251);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(103, 35);
            this.btnWrite.TabIndex = 4;
            this.btnWrite.Text = "글쓰기";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // db_Qlist
            // 
            this.db_Qlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_Qlist.Location = new System.Drawing.Point(4, 4);
            this.db_Qlist.Name = "db_Qlist";
            this.db_Qlist.RowTemplate.Height = 27;
            this.db_Qlist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.db_Qlist.Size = new System.Drawing.Size(761, 242);
            this.db_Qlist.TabIndex = 0;
            // 
            // t_MQlist
            // 
            this.t_MQlist.Controls.Add(this.btn_Delete);
            this.t_MQlist.Controls.Add(this.btn_Modify);
            this.t_MQlist.Controls.Add(this.db_MQlist);
            this.t_MQlist.Location = new System.Drawing.Point(4, 32);
            this.t_MQlist.Name = "t_MQlist";
            this.t_MQlist.Padding = new System.Windows.Forms.Padding(3);
            this.t_MQlist.Size = new System.Drawing.Size(768, 288);
            this.t_MQlist.TabIndex = 1;
            this.t_MQlist.Text = "내가 작성한 목록";
            this.t_MQlist.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(659, 153);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(103, 129);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "삭제";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Modify
            // 
            this.btn_Modify.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modify.Location = new System.Drawing.Point(658, 4);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(103, 129);
            this.btn_Modify.TabIndex = 1;
            this.btn_Modify.Text = "수정";
            this.btn_Modify.UseVisualStyleBackColor = true;
            // 
            // db_MQlist
            // 
            this.db_MQlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_MQlist.Location = new System.Drawing.Point(4, 4);
            this.db_MQlist.Name = "db_MQlist";
            this.db_MQlist.RowTemplate.Height = 27;
            this.db_MQlist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.db_MQlist.Size = new System.Drawing.Size(648, 281);
            this.db_MQlist.TabIndex = 0;
            // 
            // t_AttSit
            // 
            this.t_AttSit.Controls.Add(this.db_AttSit);
            this.t_AttSit.Location = new System.Drawing.Point(4, 32);
            this.t_AttSit.Name = "t_AttSit";
            this.t_AttSit.Padding = new System.Windows.Forms.Padding(3);
            this.t_AttSit.Size = new System.Drawing.Size(768, 288);
            this.t_AttSit.TabIndex = 2;
            this.t_AttSit.Text = "출결 현황";
            this.t_AttSit.UseVisualStyleBackColor = true;
            // 
            // db_AttSit
            // 
            this.db_AttSit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_AttSit.Location = new System.Drawing.Point(4, 4);
            this.db_AttSit.Name = "db_AttSit";
            this.db_AttSit.RowTemplate.Height = 27;
            this.db_AttSit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.db_AttSit.Size = new System.Drawing.Size(757, 285);
            this.db_AttSit.TabIndex = 0;
            // 
            // btnEntry
            // 
            this.btnEntry.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntry.Location = new System.Drawing.Point(466, 41);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(103, 42);
            this.btnEntry.TabIndex = 4;
            this.btnEntry.Text = "입/퇴실";
            this.btnEntry.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(357, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "입/퇴실";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(684, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "관리";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Board);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.tabMenus);
            this.Controls.Add(this.btnEntry);
            this.Name = "BoardForm";
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

        private System.Windows.Forms.Label lbl_Board;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}