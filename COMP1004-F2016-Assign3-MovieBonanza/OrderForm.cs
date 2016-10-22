using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Assign3_MovieBonanza
{
    public partial class OrderForm : Form
    {
        private SelectionForm _ParentForm;
        private Movie _Movie;

        private double _Price;
        private double _DvdCost;
        private double _SubTotal;
        private double _Tax;
        private double _Total;

        public OrderForm(SelectionForm parent)
        {
            InitializeComponent();

            _ParentForm = parent;
        }

        public void LoadMovieInfo(Movie movie)
        {
            _Movie = movie;

            MovieTitleLabel.Text = _Movie.Name;
            GenreTextBox.Text = _Movie.Genre.ToDescription();
            MoviePictureBox.Image = _Movie.Picture;

            PurchaseLabel.Text = (
                _Movie.IsBuying ?
                "Purchase" :
                String.Format("Rent ({0}hrs)", _Movie.RentHours)
                );

            if (_Movie.IsBuying == false)
            {
                OrderDvdCheckBox.Checked = false;
                OrderDvdCheckBox.Enabled = false;
            }
            else
            {
                OrderDvdCheckBox.Enabled = true;
            }

            _Price = _Movie.Price;
            _DvdCost = (OrderDvdCheckBox.Checked ? 10 : 0);
            _SubTotal = _Price + _DvdCost;
            _Tax = _SubTotal * 0.13;
            _Total = _SubTotal + _Tax;

            PriceCostLabel.Text = Money(_Price);
            SubTotalCostLabel.Text = Money(_SubTotal);
            TaxCostLabel.Text = Money(_Tax);
            TotalCostLabel.Text = Money(_Total);
        }

        private void FormButton_Click(object sender, EventArgs e)
        {
            Button ActiveButton = (Button)sender;

            if (ActiveButton == BackButton)
            {
                GoBack();
            }
            else if (ActiveButton == OrderButton)
            {
                DialogResult Result = MessageBox.Show("Do you wish to process with your purchase?", "Order Confirmation", MessageBoxButtons.YesNo);

                if (Result == DialogResult.Yes)
                {
                    Program.CloseConfirmed = true;

                    OrderForm.ActiveForm.Close();
                    _ParentForm.Close();

                    StreamForm NewStreamForm = new StreamForm();

                    NewStreamForm.Show();
                }
            }
        }

        private string Money(double money)
        {
            return String.Format("{0:C}", money);
        }

        private void GoBack()
        {
            OrderForm.ActiveForm.Hide();

            _ParentForm.Show();
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.CloseConfirmed == false)
            {
                Program.ConfirmAppExit(e);
            }
        }

        private void OrderDvdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMovieInfo(_Movie);
        }
    }
}
