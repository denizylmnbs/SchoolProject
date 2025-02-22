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
    
    public partial class frmTeacherMain: Form
    {
        private string _username;
        public frmTeacherMain(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void frmTeacherMain_Load(object sender, EventArgs e)
        {
            using (var context = new DbSchoolProjectEntities1())
            {
                var teacher = context.TblTeacher.FirstOrDefault(u => u.Username == _username);

                if (teacher != null)
                {
                    lblFullName.Text = teacher.Name + " " + teacher.Surname;
                    lblEmail.Text = teacher.Email;
                    lblPhoneNumber.Text = teacher.PhoneNumber;
                    lblTitle.Text = teacher.Title;
                }
                else
                {
                    MessageBox.Show("Kayıt bilgileri yüklenirken bir hata oluştu!");
                }
            }
        }
    }
}
