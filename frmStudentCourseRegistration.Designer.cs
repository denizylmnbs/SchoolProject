namespace SchoolProject
{
    partial class frmStudentCourseRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentCourseRegistration));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.txtCourseSection = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCourseAdd = new System.Windows.Forms.Button();
            this.btnSectionUpdate = new System.Windows.Forms.Button();
            this.btnCourseDrop = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıtlı Dersleriniz";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(355, 255);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCourseDrop);
            this.groupBox2.Controls.Add(this.btnSectionUpdate);
            this.groupBox2.Controls.Add(this.btnCourseAdd);
            this.groupBox2.Controls.Add(this.txtCourseSection);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCourseCode);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(379, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 283);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ders Kaydı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ders Kodu:";
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(228, 71);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(100, 29);
            this.txtCourseCode.TabIndex = 3;
            // 
            // txtCourseSection
            // 
            this.txtCourseSection.Location = new System.Drawing.Point(228, 106);
            this.txtCourseSection.Name = "txtCourseSection";
            this.txtCourseSection.Size = new System.Drawing.Size(100, 29);
            this.txtCourseSection.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sınıf:";
            // 
            // btnCourseAdd
            // 
            this.btnCourseAdd.Location = new System.Drawing.Point(141, 154);
            this.btnCourseAdd.Name = "btnCourseAdd";
            this.btnCourseAdd.Size = new System.Drawing.Size(117, 27);
            this.btnCourseAdd.TabIndex = 6;
            this.btnCourseAdd.Text = "Ders Ekle";
            this.btnCourseAdd.UseVisualStyleBackColor = true;
            // 
            // btnSectionUpdate
            // 
            this.btnSectionUpdate.Location = new System.Drawing.Point(264, 154);
            this.btnSectionUpdate.Name = "btnSectionUpdate";
            this.btnSectionUpdate.Size = new System.Drawing.Size(117, 27);
            this.btnSectionUpdate.TabIndex = 7;
            this.btnSectionUpdate.Text = "Sınıf Güncelle";
            this.btnSectionUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCourseDrop
            // 
            this.btnCourseDrop.Location = new System.Drawing.Point(141, 187);
            this.btnCourseDrop.Name = "btnCourseDrop";
            this.btnCourseDrop.Size = new System.Drawing.Size(240, 27);
            this.btnCourseDrop.TabIndex = 8;
            this.btnCourseDrop.Text = "Dersi Çıkar";
            this.btnCourseDrop.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(908, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 283);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aktif Dersler";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(364, 255);
            this.dataGridView2.TabIndex = 1;
            // 
            // frmStudentCourseRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1281, 399);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmStudentCourseRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Ders Kaydı Paneli";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCourseSection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCourseDrop;
        private System.Windows.Forms.Button btnSectionUpdate;
        private System.Windows.Forms.Button btnCourseAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}