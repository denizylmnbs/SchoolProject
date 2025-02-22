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
            lblUsername.Text = _username;
        }
    }
}
