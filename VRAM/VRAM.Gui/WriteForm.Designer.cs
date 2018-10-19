namespace VRAM.Gui
{
    partial class WriteForm
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
            this.btnWriteSend = new System.Windows.Forms.Button();
            this.txt_Wr_Page = new System.Windows.Forms.TextBox();
            this.chbSecret = new System.Windows.Forms.CheckBox();
            this.txtWriteTitle = new System.Windows.Forms.TextBox();
            this.lbWriteTitle = new System.Windows.Forms.Label();
            this.txtWriter = new System.Windows.Forms.TextBox();
            this.lbWriter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWriteSend
            // 
            this.btnWriteSend.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnWriteSend.Location = new System.Drawing.Point(190, 414);
            this.btnWriteSend.Name = "btnWriteSend";
            this.btnWriteSend.Size = new System.Drawing.Size(81, 36);
            this.btnWriteSend.TabIndex = 13;
            this.btnWriteSend.Text = "전송(&S)";
            this.btnWriteSend.UseVisualStyleBackColor = true;
            this.btnWriteSend.Click += new System.EventHandler(this.btnWriteSend_Click);
            // 
            // txt_Wr_Page
            // 
            this.txt_Wr_Page.Font = new System.Drawing.Font("Consolas", 12F);
            this.txt_Wr_Page.Location = new System.Drawing.Point(32, 117);
            this.txt_Wr_Page.Multiline = true;
            this.txt_Wr_Page.Name = "txt_Wr_Page";
            this.txt_Wr_Page.Size = new System.Drawing.Size(381, 276);
            this.txt_Wr_Page.TabIndex = 12;
            // 
            // chbSecret
            // 
            this.chbSecret.AutoSize = true;
            this.chbSecret.Font = new System.Drawing.Font("Consolas", 12F);
            this.chbSecret.Location = new System.Drawing.Point(336, 25);
            this.chbSecret.Name = "chbSecret";
            this.chbSecret.Size = new System.Drawing.Size(77, 27);
            this.chbSecret.TabIndex = 11;
            this.chbSecret.Text = "비밀글";
            this.chbSecret.UseVisualStyleBackColor = true;
            // 
            // txtWriteTitle
            // 
            this.txtWriteTitle.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtWriteTitle.Location = new System.Drawing.Point(99, 67);
            this.txtWriteTitle.Name = "txtWriteTitle";
            this.txtWriteTitle.Size = new System.Drawing.Size(314, 31);
            this.txtWriteTitle.TabIndex = 10;
            // 
            // lbWriteTitle
            // 
            this.lbWriteTitle.AutoSize = true;
            this.lbWriteTitle.Font = new System.Drawing.Font("Consolas", 12F);
            this.lbWriteTitle.Location = new System.Drawing.Point(33, 70);
            this.lbWriteTitle.Name = "lbWriteTitle";
            this.lbWriteTitle.Size = new System.Drawing.Size(40, 23);
            this.lbWriteTitle.TabIndex = 9;
            this.lbWriteTitle.Text = "제목";
            // 
            // txtWriter
            // 
            this.txtWriter.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtWriter.Location = new System.Drawing.Point(99, 21);
            this.txtWriter.Name = "txtWriter";
            this.txtWriter.ReadOnly = true;
            this.txtWriter.Size = new System.Drawing.Size(201, 31);
            this.txtWriter.TabIndex = 8;
            // 
            // lbWriter
            // 
            this.lbWriter.AutoSize = true;
            this.lbWriter.Font = new System.Drawing.Font("Consolas", 12F);
            this.lbWriter.Location = new System.Drawing.Point(33, 24);
            this.lbWriter.Name = "lbWriter";
            this.lbWriter.Size = new System.Drawing.Size(55, 23);
            this.lbWriter.TabIndex = 7;
            this.lbWriter.Text = "작성자";
            // 
            // WriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 462);
            this.Controls.Add(this.btnWriteSend);
            this.Controls.Add(this.txt_Wr_Page);
            this.Controls.Add(this.chbSecret);
            this.Controls.Add(this.txtWriteTitle);
            this.Controls.Add(this.lbWriteTitle);
            this.Controls.Add(this.txtWriter);
            this.Controls.Add(this.lbWriter);
            this.Name = "WriteForm";
            this.Text = "Write";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWriteSend;
        private System.Windows.Forms.TextBox txt_Wr_Page;
        private System.Windows.Forms.CheckBox chbSecret;
        private System.Windows.Forms.TextBox txtWriteTitle;
        private System.Windows.Forms.Label lbWriteTitle;
        private System.Windows.Forms.TextBox txtWriter;
        private System.Windows.Forms.Label lbWriter;
    }
}