namespace TpSecurite
{
    partial class loginForm
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
            System.Windows.Forms.Button buttonHomeRegisterPage;
            System.Windows.Forms.Button buttonRegisterLoginPage;
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxusername = new System.Windows.Forms.TextBox();
            this.txtboxpassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            buttonHomeRegisterPage = new System.Windows.Forms.Button();
            buttonRegisterLoginPage = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHomeRegisterPage
            // 
            buttonHomeRegisterPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonHomeRegisterPage.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold);
            buttonHomeRegisterPage.ForeColor = System.Drawing.SystemColors.ScrollBar;
            buttonHomeRegisterPage.Location = new System.Drawing.Point(0, 77);
            buttonHomeRegisterPage.Name = "buttonHomeRegisterPage";
            buttonHomeRegisterPage.Size = new System.Drawing.Size(151, 48);
            buttonHomeRegisterPage.TabIndex = 2;
            buttonHomeRegisterPage.Text = "HOME";
            buttonHomeRegisterPage.UseVisualStyleBackColor = true;
            buttonHomeRegisterPage.Click += new System.EventHandler(this.buttonHomeRegisterPage_Click);
            // 
            // buttonRegisterLoginPage
            // 
            buttonRegisterLoginPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonRegisterLoginPage.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold);
            buttonRegisterLoginPage.ForeColor = System.Drawing.SystemColors.ScrollBar;
            buttonRegisterLoginPage.Location = new System.Drawing.Point(0, 121);
            buttonRegisterLoginPage.Name = "buttonRegisterLoginPage";
            buttonRegisterLoginPage.Size = new System.Drawing.Size(151, 48);
            buttonRegisterLoginPage.TabIndex = 3;
            buttonRegisterLoginPage.Text = "REGISTER";
            buttonRegisterLoginPage.UseVisualStyleBackColor = true;
            buttonRegisterLoginPage.Click += new System.EventHandler(this.buttonRegisterLoginPage_Click);
            // 
            // button2
            // 
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold);
            button2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            button2.Location = new System.Drawing.Point(469, 275);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(151, 48);
            button2.TabIndex = 5;
            button2.Text = "LOGIN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold);
            button1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            button1.Location = new System.Drawing.Point(290, 275);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(151, 48);
            button1.TabIndex = 6;
            button1.Text = "FORGOT PASSWORD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(buttonRegisterLoginPage);
            this.panel1.Controls.Add(buttonHomeRegisterPage);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 87);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = "SmL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(346, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "LOGIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(319, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD";
            // 
            // txtboxusername
            // 
            this.txtboxusername.Location = new System.Drawing.Point(439, 168);
            this.txtboxusername.Name = "txtboxusername";
            this.txtboxusername.Size = new System.Drawing.Size(124, 20);
            this.txtboxusername.TabIndex = 3;
            // 
            // txtboxpassword
            // 
            this.txtboxpassword.Location = new System.Drawing.Point(439, 211);
            this.txtboxpassword.Name = "txtboxpassword";
            this.txtboxpassword.PasswordChar = '*';
            this.txtboxpassword.Size = new System.Drawing.Size(124, 20);
            this.txtboxpassword.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(413, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 101);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(button1);
            this.Controls.Add(button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtboxpassword);
            this.Controls.Add(this.txtboxusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.Text = "+";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxusername;
        private System.Windows.Forms.TextBox txtboxpassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}