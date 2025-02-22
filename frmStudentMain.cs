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
    public partial class frmStudentMain : Form
    {

        private string _username;

        public frmStudentMain(string username)
        {
            InitializeComponent();
            _username = username;
        }



        private void frmStudentMain_Load(object sender, EventArgs e)
        {
            using (var context = new DbSchoolProjectEntities1())
            {
                var student = context.TblStudent.FirstOrDefault(u => u.Username == _username);

                if (student != null)
                {
                    lblFullName.Text = student.Name + " " + student.Surname;
                    lblDepartment.Text = student.Department;
                    lblEmail.Text = student.Email;
                    lblGrade.Text = student.Grade;
                    lblPhoneNumber.Text = student.PhoneNumber;
                }
                else
                {
                    MessageBox.Show("Öğrenci bilgileri yüklenirken bir hata oluştu!");
                }
            }

        }
    }
}
