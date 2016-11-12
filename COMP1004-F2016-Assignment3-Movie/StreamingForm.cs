﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace COMP1004_F2016_Assignment3_Movie
{
    public partial class StreamingForm : Form
    {

        public StreamingForm()
        {
            InitializeComponent();

        }

        //Ok button loads what would be the movie. In this case its to show and enjoy the movie form
        private void StreamOkButton_Click(object sender, EventArgs e)
        {
            ExitForm bye = new ExitForm();
            bye.Show();
            this.Hide();
        }

        //When the form loads it will grab your selection and show you a receipt
        private void StreamForm_Load(object sender, EventArgs e)
        {

            ProgressTimer.Start();

            StreamLabel.Text = "Thank you for choosing Movie Bonanza!" + "\r\n" + "Your movie is: " + Program.info.Title + "\r\n"
                + "Your cost is: " + Program.info.GrandTotal + "\r\n";


        }

        private void StreamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Timer loads the progress bar. When finished the button and label will appear
        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            StreamProgressBar.Increment(1);
            if (StreamProgressBar.Value == 100)
            {
                ProgressTimer.Stop();
                StreamOkButton.Show();
                MovieReadyLabel.Show();
                StreamProgressBar.Hide();



            }
        }
    }
}
