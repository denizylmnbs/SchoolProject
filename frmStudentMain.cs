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
    public partial class frmStudentMain: Form
    {

        private string _username;

        public frmStudentMain(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void frmStudentMain_Load(object sender, EventArgs e)
        {
            lblUsername.Text = _username;
        }

    }
}
