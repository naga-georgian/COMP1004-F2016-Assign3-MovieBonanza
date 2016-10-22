/*
A Few Good Men
Batman Begins
Finding Dory
Finding Nemo
Forest Gump
Gravity
Guardians of the Galaxy
Inception
Interstellar
LotR: The Fellowship of the Ring
LotR: The Return of the King
LotR: The Two Towers
Pulp Fiction
Star Wars - A New Hope
Star Wars - Attack of the Clones
Star Wars - Return of the Jedi
Star Wars - Revenge of the Sith
Star Wars - The Empire Strikes Back
Star Wars - The Force Awakens
Star Wars - The Phantom Menace
Suicide Squad
The Dark Knight
The Dark Knight Rises
The Godfather
The Godfather: Part II
The Godfather: Part III
The Shawshank Redemption
The Social Network
The Wolf of Wall Street
Top Gun
*/
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
    public partial class SelectionForm : Form
    {
        //----------------   Global Variables   -----------------//

        //Private Variables
        private Movie _SelectedMovie;
        private OrderForm _OrderForm;

        private bool _RentComboBoxIsListening = false;

        //----------------   Initializers   ---------------------//
        /// <summary>
        /// Initialize the Selection Form
        /// </summary>
        public SelectionForm()
        {
            InitializeComponent();

            //Public bool initializer
            OrderFormCreated = false;
        }

        /// <summary>
        /// Used when moving back and forth from Order Form
        /// </summary>
        public bool OrderFormCreated { get; set; }

        //----------------   Event Handlers   -------------------//
        private void SelectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.CloseConfirmed == false)
            {
                Program.ConfirmAppExit(e);
            }
        }

        private void CurrentMovieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string NewSelection = CurrentMovieComboBox.SelectedItem.ToString();

            Movie NewMovie = Program.FindMovie(NewSelection);

            if (NewMovie.Name == "ERROR")
            {
                FormInfoTextBox.Text = "Error: No Movie found with name " + NewSelection;
            }
            else
            {
                SelectMovie(NewMovie);
                FormInfoTextBox.Text = "";
            }
        }

        private void AccountLabelLink_MouseUp(object sender, MouseEventArgs e)
        {
            LinkLabel ActiveLabel = (LinkLabel)sender;

            ActiveLabel.ForeColor = SystemColors.ControlText;
            ActiveLabel.ActiveLinkColor = SystemColors.ControlText;
        }
        private void AccountLabelLink_MouseDown(object sender, MouseEventArgs e)
        {
            LinkLabel ActiveLabel = (LinkLabel)sender;

            ActiveLabel.ForeColor = Color.Blue;
            ActiveLabel.ActiveLinkColor = Color.Blue;
        }

        private void SelectMovie(Movie Selection)
        {
            _SelectedMovie = Selection;

            MovieTitleLabel.Text = Selection.Name;
            DescriptionTextBox.Text = Selection.Description;
            GenreTextBox.Text = Selection.Genre.ToDescription();
            MoviePictureBox.Image = Selection.Picture;

            UpdatePrice(Selection);
        }

        private Movie.RentTime GetRentHours(string selectedItem)
        {
            switch (selectedItem)
            {
                case "24 hrs":
                    return Movie.RentTime._24hrs;
                case "48 hrs":
                    return Movie.RentTime._48hrs;

                default:
                    return Movie.RentTime._24hrs;
            }
        }

        private double GetMoviePrice(Movie Selection)
        {
            double BaseCost;
            int RentHours;
            double Price;

            switch (Selection.Value)
            {
                case Movie.MovieValue.Discount:
                    BaseCost = 3;
                    break;
                case Movie.MovieValue.Standard:
                    BaseCost = 5;
                    break;
                case Movie.MovieValue.Premium:
                    BaseCost = 7;
                    break;

                default:
                    BaseCost = 5;
                    break;
            }

            RentHours = (
                Selection.IsBuying ?
                5 * (int)Movie.RentTime._24hrs :
                Selection.RentHours
                );

            Price = BaseCost * (RentHours / (int)Movie.RentTime._24hrs);

            return Price;
        }

        private void PurchaseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton CheckedRadioButton = (RadioButton)sender;

            RentComboBox.Enabled = (
                CheckedRadioButton == RentRadioButton ?
                true : false
                );
            if (_SelectedMovie != null)
            {
                UpdatePrice(_SelectedMovie);
            }
        }

        private void UpdatePrice(Movie Selection)
        {
            Selection.IsBuying = (BuyRadioButton.Checked ? true : false);
            Selection.RentHours = (int)GetRentHours(RentComboBox.SelectedItem.ToString());
            Selection.Price = GetMoviePrice(Selection);

            PriceTextBox.Text = String.Format("{0:C}", Selection.Price);
            PriceLabel.Visible = true;
            PurchaseButton.Enabled = true;
        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {
            RentComboBox.SelectedIndex = RentComboBox.FindString("24 hrs");
            _RentComboBoxIsListening = true;
        }

        private void RentComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_RentComboBoxIsListening && _SelectedMovie != null)
            {
                UpdatePrice(_SelectedMovie);
            }
        }

        private void FormButton_Click(object sender, EventArgs e)
        {
            PurchaseMovie(_SelectedMovie);
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ActiveItem = (ToolStripMenuItem)sender;

            if (ActiveItem == ExitMenuItem)
            {
                SelectionForm.ActiveForm.Close();
            }
        }

        private void PurchaseMovie(Movie movie)
        {
            SelectionForm ThisForm = (SelectionForm)SelectionForm.ActiveForm;
            ThisForm.Hide();

            if (OrderFormCreated == false)
            {
                _OrderForm = new OrderForm(ThisForm);

                OrderFormCreated = true;
            }

            _OrderForm.LoadMovieInfo(_SelectedMovie);
            _OrderForm.Show();
        }
    }
}