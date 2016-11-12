using System;
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

    public partial class OrderForm : Form
    {
        SelectionForm select = new SelectionForm();
        public OrderForm()
        {
            InitializeComponent();
        }

        //Cancel button closes the form
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //X closes the form
        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //When the form loads populate with info saved from the last form
        private void OrderForm_Load(object sender, EventArgs e)
        {


            TitleTextBox.Text = Program.info.Title;
            GenreTextBox.Text = Program.info.Genre;
            CostTextBox.Text = Program.info.Cost;
            OrderPictureBox.Image = Program.info.Picture;

            CalculateTotals();
        }

    }
}