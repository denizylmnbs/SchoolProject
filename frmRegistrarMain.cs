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
    public partial class frmRegistrarMain: Form
    {

        public string _username;
        public frmRegistrarMain(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void frmRegistrarMain_Load(object sender, EventArgs e)
        {
            using(var context = new DbSchoolProjectEntities1())
            {
                var registrar = context.TblRegistrar.First(u => u.Username == _username);

                if (registrar != null)
                {
                    lblFullName.Text = registrar.Name + " " + registrar.Surname;
                    lblEmail.Text = registrar.Email;
                    lblPhoneNumber.Text = registrar.PhoneNumber;
                }
                else
                {
                    MessageBox.Show("Kayıt bilgileri yüklenirken bir hata oluştu!");
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmRegistrarInformationUpdate fr = new frmRegistrarInformationUpdate(_username);
            fr.ShowDialog();
        }
    }
}
