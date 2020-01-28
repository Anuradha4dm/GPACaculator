using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using studentGuid.classes;
using studentGuid.forms;

namespace studentGuid.forms
{
    public partial class DynamicSubject : Form
    {
        public DynamicSubject()
        {
            InitializeComponent();
        }

        int numt = 1;
        int numl = 1;
        int index = 0;
        double x=0;
        Bcs bcs;
        Traking bcsTracking;

        public DynamicSubject(Bcs bcs,Traking bcsTracking)
        {
            this.bcsTracking = bcsTracking;
            this.bcs = bcs;
            InitializeComponent();
        }
        private void DynamicSubject_Load(object sender, EventArgs e)
        {
           if(bcsTracking.Year=="year1" && bcsTracking.Semester=="semester1" && bcsTracking.Stream == "bcs")
            {
                foreach (String subject in bcs.bcsyear1sem1)
                {
                    CreateLabel(subject);
                    CreateTextbox();
                }

            }

            if (bcsTracking.Year == "year1" && bcsTracking.Semester == "semester2" && bcsTracking.Stream == "bcs")
            {
                foreach (String subject in bcs.bcsyear1sem2)
                {
                    CreateLabel(subject);
                    CreateTextbox();
                }

            }



        }

        public System.Windows.Forms.TextBox CreateTextbox()
        {
            System.Windows.Forms.TextBox dyText = new System.Windows.Forms.TextBox();
            this.Controls.Add(dyText);
            dyText.Top = numt * 30;
            dyText.Left = 250;
            dyText.Text = "";
            dyText.Name = "txt" + this.numt.ToString();
            numt += 1;
            return dyText;
        }

        public System.Windows.Forms.Label CreateLabel(String subject)
        {
            System.Windows.Forms.Label dyLabel = new System.Windows.Forms.Label();
            this.Controls.Add(dyLabel);
            dyLabel.Top = numl * 30;
            dyLabel.Left = 15;
            dyLabel.Width = 220;
            dyLabel.Text = subject;
            numl += 1;
            return dyLabel;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private double ResultToValue(string result)
        {
            switch (result.ToUpper())
            {
                case "A+": return 4.0;
                case "A": return 4.0;
                case "A-": return 3.7;
                case "B+": return 3.3;
                case "B": return 3.0;
                case "B-": return 2.7;
                case "C+": return 2.3;
                case "C": return 2.0;
                case "C-": return 1.7;
                case "D+": return 1.3;
                case "D": return 1.0;
                case "E": return 0.0;
                default: return 0;

            }

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {

            if(bcsTracking.Year == "year1" && bcsTracking.Semester == "semester1" && bcsTracking.Stream == "bcs")
            {
                index = 0;
                x = 0;

                foreach (Control childc in this.Controls)
                {
                    if (childc is TextBox && childc.Name.Contains("txt"))
                    {
                        x += ResultToValue(((TextBox)childc).Text) * bcs.bcsyear1sem1credits[index];
                        MessageBox.Show(index.ToString());
                        index++;
                    }

                    bcs.Year1sem1GPA = x / 14.5;


                }

            }

            if(bcsTracking.Year == "year1" && bcsTracking.Semester == "semester2" && bcsTracking.Stream == "bcs")
            {
                index = 0;
                x = 0;
                foreach (Control childc in this.Controls)
                {
                    if (childc is TextBox && childc.Name.Contains("txt"))
                    {
                        x += ResultToValue(((TextBox)childc).Text) * bcs.bcsyear1sem2credits[index];
            
                        index++;
                    }

                    bcs.Year1sem2GPA = x / 14.5;


                }

            }
   
            


           


        }
    }
}
