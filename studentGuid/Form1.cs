using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using studentGuid.forms;

namespace studentGuid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GPACalculation_Click(object sender, EventArgs e)
        {
            Stream stream = new Stream();
            stream.Show();
            this.Hide();

        }
    }
}
