namespace TpSecurite
{
    partial class codeInformation
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
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button button2;
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold);
            button1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            button1.Location = new System.Drawing.Point(22, 186);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(115, 36);
            button1.TabIndex = 4;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold);
            button2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            button2.Location = new System.Drawing.Point(143, 186);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(115, 36);
            button2.TabIndex = 7;
            button2.Text = "CANCEL";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code :";
            // 
            // txtboxcode
            // 
            this.txtboxcode.Location = new System.Drawing.Point(111, 135);
            this.txtboxcode.Name = "txtboxcode";
            this.txtboxcode.Size = new System.Drawing.Size(100, 20);
            this.txtboxcode.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Find your code at your email adress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(0, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 65);
            this.label3.TabIndex = 8;
            this.label3.Text = "SmL";
            // 
            // codeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(281, 250);
            this.Controls.Add(this.label3);
            this.Controls.Add(button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxcode);
            this.Controls.Add(button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "codeInformation";
            this.Text = "codeInformation";
            this.Load += new System.EventHandler(this.codeInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}