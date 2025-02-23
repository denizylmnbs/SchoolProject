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
    public partial class frmRegistrarAnnounce : Form
    {
        public string _username;
        public frmRegistrarAnnounce(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void frmRegistrarAnnounce_Load(object sender, EventArgs e)
        {
            using (var context = new DbSchoolProjectEntities1())
            {
                var registrar = context.TblRegistrar.FirstOrDefault(u => u.Username == _username);
                if (registrar == null)
                {
                    MessageBox.Show("Yetkisiz Erişim!");
                    Application.Exit();
                }
                else
                {
                    var announcements = context.TblAnnouncement.Select(a => new { a.ForTeachers, a.ForStudents, a.Content });
                    dataGridView1.DataSource = announcements.ToList();
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            using(var context = new DbSchoolProjectEntities1())
            {
                var announcement = new TblAnnouncement
                {
                    Content = richTextBox1.Text,
                    ForStudents = chckStudents.Checked,
                    ForTeachers = chckTeacher.Checked
                };
                context.TblAnnouncement.Add(announcement);
                context.SaveChanges();
                MessageBox.Show("Duyuru Gönderildi!");
            }
        }
    }
}
