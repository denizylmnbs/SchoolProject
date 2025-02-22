namespace SchoolProject
{
    partial class frmTeacherInfoUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacherInfoUpdate));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(190, 314);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(162, 35);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(189, 264);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(162, 29);
            this.txtDepartment.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Bölüm:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(189, 20);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(162, 29);
            this.txtUsername.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Kullanıcı Adı:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(189, 229);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(162, 29);
            this.txtPhoneNumber.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Telefon Numarası:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(189, 194);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(162, 29);
            this.txtEmail.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "E-mail:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(189, 125);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(162, 29);
            this.txtSurname.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Soyad:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(189, 90);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(162, 29);
            this.txtName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ad:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(189, 160);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(162, 29);
            this.txtTitle.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Ünvan:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(189, 55);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(162, 29);
            this.txtPassword.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 21);
            this.label8.TabIndex = 30;
            this.label8.Text = "Şifre:";
            // 
            // frmTeacherInfoUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(526, 361);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmTeacherInfoUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Akademik Üye Bilgi Güncelleme Paneli";
            this.Load += new System.EventHandler(this.frmTeacherInfoUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label8;
    }
}