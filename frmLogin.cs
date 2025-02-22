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
    public partial class frmLogin: Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (var context = new DbSchoolProjectEntities1())
            {
                var user = context.TblAccount.FirstOrDefault(u => u.Username == username && u.Password == password);

                if (user != null)
                {
                    MessageBox.Show("Giriş başarılı!");
                    if (user.AccountType == "Student")
                    {
                        frmStudentMain frm = new frmStudentMain(user.Username);
                        frm.Show();
                        this.Hide();
                    }
                    if (user.AccountType == "Teacher")
                    {
                        frmTeacherMain frm = new frmTeacherMain(user.Username);
                        frm.Show();
                        this.Hide();
                    }
                    if (user.AccountType == "Registrar")
                    {
                        frmRegistrarMain frm = new frmRegistrarMain(user.Username);
                        frm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                }
            }
        }
    }
}
