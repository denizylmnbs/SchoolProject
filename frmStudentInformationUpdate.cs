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
    public partial class frmStudentInformationUpdate : Form
    {
        public string _username;
        public frmStudentInformationUpdate(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void frmStudentInformationUpdate_Load(object sender, EventArgs e)
        {
            using (var context = new DbSchoolProjectEntities1())
            {
                var student = context.TblStudent.FirstOrDefault(u => u.Username == _username);
                if (student != null)
                {
                    txtPassword.Text = student.Password;
                    txtName.Text = student.Name;
                    txtSurname.Text = student.Surname;
                    txtEmail.Text = student.Email;
                    txtPhoneNumber.Text = student.PhoneNumber;
                    txtUsername.Text = student.Username;
                    txtDepartment.Text = student.Department;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new DbSchoolProjectEntities1())
            {
                var student = context.TblStudent.FirstOrDefault(u => u.Username == _username);

                if (student != null)
                {
                    student.Password = txtPassword.Text;
                    student.Name = txtName.Text;
                    student.Surname = txtSurname.Text;
                    student.Email = txtEmail.Text;
                    student.PhoneNumber = txtPhoneNumber.Text;
                    student.Username = txtUsername.Text;
                    student.Department = txtDepartment.Text;
                    context.SaveChanges();
                    MessageBox.Show("Öğrenci bilgileri başarıyla güncellendi!");
                }
                else
                {
                    MessageBox.Show("Öğrenci bilgileri güncellenirken bir hata oluştu!");
                }
            }
        }
    }
}
