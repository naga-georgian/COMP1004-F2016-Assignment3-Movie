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

        //Method will calculate the totals of the movie depending on whether or not the add dvd box is checked
        private void CalculateTotals()
        {

            if (OrderDvdCheckBox.Checked == true)
            {
                DvdLabel.Show();
                DvdCostTextBox.Show();
                double TotalTax = Convert.ToDouble((CostTextBox.Text as string).TrimStart('$'));
                double DvdCost = TotalTax + 10;


                TotalTax = DvdCost * 0.13;
                double Grand = TotalTax + DvdCost;


                SubtotalTextBox.Text = DvdCost.ToString("C2");
                SalesTaxTextBox.Text = TotalTax.ToString("C2");
                GrandTotalTextBox.Text = Grand.ToString("C2");
                Program.info.GrandTotal = GrandTotalTextBox.Text;

            }
            else if (OrderDvdCheckBox.Checked == false)
            {
                DvdLabel.Hide();
                DvdCostTextBox.Hide();
                CostTextBox.Text = Program.info.Cost;
                double TotalTax = Convert.ToDouble((CostTextBox.Text as string).TrimStart('$'));
                double Grand = TotalTax * 1.13;
                TotalTax = TotalTax * 0.13;



                SubtotalTextBox.Text = CostTextBox.Text;
                SalesTaxTextBox.Text = TotalTax.ToString("C2");
                GrandTotalTextBox.Text = Grand.ToString("C2");
                Program.info.GrandTotal = GrandTotalTextBox.Text;
            }

        }

    }
}