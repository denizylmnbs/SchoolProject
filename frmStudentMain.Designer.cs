namespace SchoolProject
{
    partial class frmStudentMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblStudentPhoneNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStudentEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGradeAverage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStudentDepartment = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStudentFullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCourseSelect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.lblStudentPhoneNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblStudentEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblGradeAverage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblStudentDepartment);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblStudentFullName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpdate.Location = new System.Drawing.Point(6, 172);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(252, 34);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Bilgilerimi Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // lblStudentPhoneNumber
            // 
            this.lblStudentPhoneNumber.AutoSize = true;
            this.lblStudentPhoneNumber.Location = new System.Drawing.Point(142, 148);
            this.lblStudentPhoneNumber.Name = "lblStudentPhoneNumber";
            this.lblStudentPhoneNumber.Size = new System.Drawing.Size(0, 21);
            this.lblStudentPhoneNumber.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefon Numarası:";
            // 
            // lblStudentEmail
            // 
            this.lblStudentEmail.AutoSize = true;
            this.lblStudentEmail.Location = new System.Drawing.Point(67, 117);
            this.lblStudentEmail.Name = "lblStudentEmail";
            this.lblStudentEmail.Size = new System.Drawing.Size(0, 21);
            this.lblStudentEmail.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email: ";
            // 
            // lblGradeAverage
            // 
            this.lblGradeAverage.AutoSize = true;
            this.lblGradeAverage.Location = new System.Drawing.Point(131, 86);
            this.lblGradeAverage.Name = "lblGradeAverage";
            this.lblGradeAverage.Size = new System.Drawing.Size(0, 21);
            this.lblGradeAverage.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Not Ortalaması:";
            // 
            // lblStudentDepartment
            // 
            this.lblStudentDepartment.AutoSize = true;
            this.lblStudentDepartment.Location = new System.Drawing.Point(70, 55);
            this.lblStudentDepartment.Name = "lblStudentDepartment";
            this.lblStudentDepartment.Size = new System.Drawing.Size(0, 21);
            this.lblStudentDepartment.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bölüm:";
            // 
            // lblStudentFullName
            // 
            this.lblStudentFullName.AutoSize = true;
            this.lblStudentFullName.Location = new System.Drawing.Point(96, 25);
            this.lblStudentFullName.Name = "lblStudentFullName";
            this.lblStudentFullName.Size = new System.Drawing.Size(0, 21);
            this.lblStudentFullName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hoş geldin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 392);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlı Olduğunuz Dersler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 364);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCourseSelect);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(282, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 214);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ders Kaydı";
            // 
            // btnCourseSelect
            // 
            this.btnCourseSelect.Location = new System.Drawing.Point(24, 110);
            this.btnCourseSelect.Name = "btnCourseSelect";
            this.btnCourseSelect.Size = new System.Drawing.Size(216, 31);
            this.btnCourseSelect.TabIndex = 1;
            this.btnCourseSelect.Text = "Ders Kaydı Ekranı";
            this.btnCourseSelect.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ders Kaydı için butona basınız.";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(559, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(537, 214);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ödevleriniz";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(531, 186);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView3);
            this.groupBox5.Location = new System.Drawing.Point(559, 232);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(534, 392);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Duyurularınız";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 25);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(528, 364);
            this.dataGridView3.TabIndex = 0;
            // 
            // frmStudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1108, 636);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmStudentMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Ana Paneli";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStudentPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStudentEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGradeAverage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStudentDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStudentFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCourseSelect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}