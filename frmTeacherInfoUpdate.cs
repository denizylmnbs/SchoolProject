using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject
{
    public partial class frmTeacherInfoUpdate: Form
    {
        public string _username;
        public frmTeacherInfoUpdate(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void frmTeacherInfoUpdate_Load(object sender, EventArgs e)
        {
            using(var context = new DbSchoolProjectEntities1())
            {
                var teacher = context.TblTeacher.FirstOrDefault(u => u.Username == _username);
                if (teacher != null)
                {
                    txtName.Text = teacher.Name;
                    txtSurname.Text = teacher.Surname;
                    txtEmail.Text = teacher.Email;
                    txtPhoneNumber.Text = teacher.PhoneNumber;
                    txtTitle.Text = teacher.Title;
                    txtDepartment.Text = teacher.Department;
                    txtUsername.Text = teacher.Username;
                    txtPassword.Text = teacher.Password;
                }
                else
                {
                    MessageBox.Show("Kayıt bilgileri yüklenirken bir hata oluştu!");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new DbSchoolProjectEntities1()) 
            {
                var teacher = context.TblTeacher.FirstOrDefault(u => u.Username == _username);
                if (teacher != null)
                {
                    teacher.Name = txtName.Text;
                    teacher.Surname = txtSurname.Text;
                    teacher.Email = txtEmail.Text;
                    teacher.PhoneNumber = txtPhoneNumber.Text;
                    teacher.Title = txtTitle.Text;
                    teacher.Department = txtDepartment.Text;
                    teacher.Username = txtUsername.Text;
                    teacher.Password = txtPassword.Text;
                    context.SaveChanges();
                    MessageBox.Show("Bilgileriniz başarıyla güncellendi!");
                }
                else
                {
                    MessageBox.Show("Bilgileriniz güncellenirken bir hata oluştu!");
                }
            }
        }
    }
}
