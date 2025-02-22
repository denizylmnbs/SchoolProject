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
    public partial class frmRegistrarInformationUpdate : Form
    {
        public string _username;
        public frmRegistrarInformationUpdate(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void frmRegistrarInformationUpdate_Load(object sender, EventArgs e)
        {
            using (var context = new DbSchoolProjectEntities1())
            {
                var registrar = context.TblRegistrar.FirstOrDefault(u => u.Username == _username);

                if (registrar != null)
                {
                    txtPassword.Text = registrar.Password;
                    txtName.Text = registrar.Name;
                    txtSurname.Text = registrar.Surname;
                    txtEmail.Text = registrar.Email;
                    txtPhoneNumber.Text = registrar.PhoneNumber;
                    txtUsername.Text = registrar.Username;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new DbSchoolProjectEntities1())
            {
                var registrar = context.TblRegistrar.FirstOrDefault(u => u.Username == _username);
                if (registrar != null)
                {
                    registrar.Password = txtPassword.Text;
                    registrar.Name = txtName.Text;
                    registrar.Surname = txtSurname.Text;
                    registrar.Email = txtEmail.Text;
                    registrar.PhoneNumber = txtPhoneNumber.Text;
                    registrar.Username = txtUsername.Text;
                    context.SaveChanges();
                    MessageBox.Show("Kayıt görevlisi bilgileri başarıyla güncellendi!");
                }
                else
                {
                    MessageBox.Show("Kayıt görevlisi bilgileri güncellenirken bir hata oluştu!");
                }
            }
        }
    }
}
