namespace Bai17_DocGhiFile_SaveFile
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnGhiFile = new System.Windows.Forms.Button();
			this.btnDocFile = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtDocFile = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtGhiFile = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSave);
			this.groupBox1.Controls.Add(this.btnGhiFile);
			this.groupBox1.Controls.Add(this.btnDocFile);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox1.Location = new System.Drawing.Point(0, 483);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1000, 72);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(694, 25);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(233, 35);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "&Save (New) File";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnGhiFile
			// 
			this.btnGhiFile.Location = new System.Drawing.Point(378, 25);
			this.btnGhiFile.Name = "btnGhiFile";
			this.btnGhiFile.Size = new System.Drawing.Size(233, 35);
			this.btnGhiFile.TabIndex = 1;
			this.btnGhiFile.Text = "&Write File";
			this.btnGhiFile.UseVisualStyleBackColor = true;
			this.btnGhiFile.Click += new System.EventHandler(this.btnGhiFile_Click);
			// 
			// btnDocFile
			// 
			this.btnDocFile.Location = new System.Drawing.Point(55, 25);
			this.btnDocFile.Name = "btnDocFile";
			this.btnDocFile.Size = new System.Drawing.Size(233, 35);
			this.btnDocFile.TabIndex = 0;
			this.btnDocFile.Text = "&Read File";
			this.btnDocFile.UseVisualStyleBackColor = true;
			this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtDocFile);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(494, 483);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Đọc file";
			// 
			// txtDocFile
			// 
			this.txtDocFile.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtDocFile.ForeColor = System.Drawing.Color.Red;
			this.txtDocFile.Location = new System.Drawing.Point(3, 23);
			this.txtDocFile.Multiline = true;
			this.txtDocFile.Name = "txtDocFile";
			this.txtDocFile.Size = new System.Drawing.Size(488, 457);
			this.txtDocFile.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtGhiFile);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(494, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(506, 483);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Ghi file";
			// 
			// txtGhiFile
			// 
			this.txtGhiFile.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtGhiFile.ForeColor = System.Drawing.Color.Red;
			this.txtGhiFile.Location = new System.Drawing.Point(3, 23);
			this.txtGhiFile.Multiline = true;
			this.txtGhiFile.Name = "txtGhiFile";
			this.txtGhiFile.Size = new System.Drawing.Size(500, 457);
			this.txtGhiFile.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGreen;
			this.ClientSize = new System.Drawing.Size(1000, 555);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Red;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bài 17: Đọc-Ghi File và Lưu File";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGhiFile;
        private System.Windows.Forms.Button btnDocFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDocFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtGhiFile;
        private System.Windows.Forms.Button btnSave;
    }
}

