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
    public partial class frmTeacherAnnounce: Form
    {
        public string _username;
        public frmTeacherAnnounce(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void frmTeacherAnnounce_Load(object sender, EventArgs e)
        {
            using(var context = new DbSchoolProjectEntities1())
            {
                var teacher = context.TblTeacher.FirstOrDefault(u => u.Username == _username);
                if (teacher == null)
                {
                    MessageBox.Show("Yetkisiz Erişim!");
                    Application.Exit();
                } else
                {
                    var courses = context.TblCourses.Select(c => c.Name).Distinct().ToList();
                    foreach (var course in courses)
                    {
                        cmbCourse.Items.Add(course);
                    }
                }

                var announcements = context.TblAnnouncement.Select(a => new { a.Course, a.Section, a.Content }).ToList();

                dataGridView1.DataSource = announcements;
            }
        }
        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string courseName = cmbCourse.Text;
            using (var context = new DbSchoolProjectEntities1())
            {
                var sections = context.TblCourses.Where(c => c.Name == courseName).Select(c => c.Section).Distinct().ToList();

                foreach (var section in sections)
                {
                    cmbSection.Items.Add(section);
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            using (var context = new DbSchoolProjectEntities1())
            {
                var announcement = new TblAnnouncement
                {
                    Course = cmbCourse.Text,
                    Section = cmbSection.Text,
                    Content = rchContext.Text,
                    ForStudents = false,
                    ForTeachers = false,
                };
                context.TblAnnouncement.Add(announcement);
                context.SaveChanges();
                MessageBox.Show("Duyuru Gönderildi!");
            }
        }
    }
}
