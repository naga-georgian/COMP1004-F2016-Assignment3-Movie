using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name: Naga Rimmalapudi
// Student #: 200277598
// Description: This form is about the exit form
// Date: November 7th 2016

namespace COMP1004_F2016_Assignment3_Movie
{
    public partial class ExitForm : Form
    {
        public ExitForm()
        {
            InitializeComponent();
        }

        private void GoodByeForm_Load(object sender, EventArgs e)
        {
            ExitTimer.Start();
        }

       

        private void ExitTimer_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
