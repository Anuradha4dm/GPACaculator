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

namespace studentGuid.forms
{
    public partial class Semester : Form
    {
        Bcs bcs;
        Traking bcsTracking;
        public Semester()
        {
            InitializeComponent();
        }
        public Semester(Bcs bcs,Traking bcsTrackig)
        {
            this.bcsTracking = bcsTrackig;
            InitializeComponent();
            this.bcs=bcs;
        }


        private void SemesterNext_Click(object sender, EventArgs e)
        {
            if (Semester1Check.Checked)
            {
                bcsTracking.Semester = "semester1";
                
                DynamicSubject dynamicSubject = new DynamicSubject(bcs,bcsTracking);
                this.Hide();
                dynamicSubject.ShowDialog();
                this.Show();
            }
            else if (Semester2Check.Checked)
            {
                bcsTracking.Semester = "semester2";
                DynamicSubject dynamicSubject = new DynamicSubject(bcs, bcsTracking);
                this.Hide();
                dynamicSubject.ShowDialog();
                this.Show();

            }

        }

        private void UpToNowGPA_Click(object sender, EventArgs e)
        {
            if (bcs.Year1sem1GPA != 0)
            {
                label1.Text = bcs.Year1sem1GPA.ToString();
               

            }
            else
            {
                MessageBox.Show("Please Enter The Results");
                Semester1Check.Checked = true;
                SemesterNext.PerformClick();
                return;

            }
            if (bcs.Year1sem2GPA != 0)
            {
                label2.Text = bcs.Year1sem2GPA.ToString();
            }
            else
            {
                MessageBox.Show("Please Enter The Results");
                Semester1Check.Checked = false;
                Semester2Check.Checked = true;
                SemesterNext.PerformClick();
                return;

            }
        }
    }
}
