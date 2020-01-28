using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using studentGuid.classes;
using studentGuid.forms;

namespace studentGuid.forms
{
    public partial class Year : Form
    {
        Bcs bcs;
        Traking bcsTracking;
        public Year()
        {
            InitializeComponent();
        }
        public Year(Bcs bcs,Traking bcsTracking)
        {
            this.bcsTracking = bcsTracking;
            InitializeComponent();
            this.bcs = bcs;
        }

        private void YearNextBtn_Click(object sender, EventArgs e)
        {
            if (Year1check.Checked)
            {
                this.bcsTracking.Year = "year1";
            }

            Semester semester = new Semester(bcs,bcsTracking);
            this.Hide();
            semester.Show();

        }
    }
}
