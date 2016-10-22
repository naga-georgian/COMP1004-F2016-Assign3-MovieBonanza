using COMP1004_F2016_Assign3_MovieBonanza.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Assign3_MovieBonanza
{
    static class Program
    {
        public static bool CloseConfirmed = false;

        public static Movie[] MovieList =
        {
            new Movie(
                "ERROR",
                "ERROR",
                "ERROR",
                Genre.Unclassified,
                Movie.MovieValue.Standard,
                Resources.NoImage
                ),

            new Movie(
                "A Few Good Men",
                "A Few Good Men",
                "YOU CAN'T HANDLE THE TRUTH!!!",
                Genre.Unclassified,
                Movie.MovieValue.Discount,
                Resources.AFewGoodMen
                ),

            new Movie(
                "Batman Begins",
                "Batman Begins",
                "Bye bye parents :(",
                Genre.Action,
                Movie.MovieValue.Standard,
                Resources.NoImage
                ),

            new Movie(
                "Finding Nemo",
                "Finding Nemo",
                "Where'd he go?",
                Genre.Horror,
                Movie.MovieValue.Premium,
                Resources.NoImage
                ),

            new Movie(
                "LotR: The Fellowship of the Ring",
                "Lord of the Rings: The Fellowship of the Ring",
                "Intro to Lord of the Rings, they set off with the ring, hoping to destroy it once and for all.",
                Genre.Action,
                Movie.MovieValue.Standard,
                Resources.NoImage
                ),

            new Movie(
                "Suicide Squad",
                "Suicide Squad",
                "Bad guys fight crime",
                Genre.Action,
                Movie.MovieValue.Premium,
                Resources.NoImage
                )
        };

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }

        public static void ConfirmAppExit(FormClosingEventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are you sure you wish to close the application?", "Close Confirmation", MessageBoxButtons.YesNo);

            if (Result == DialogResult.Yes)
            {
                CloseConfirmed = true;

                Application.Exit();
            }

            e.Cancel = true;
        }

        public static Movie FindMovie(string itemValue)
        {
            for (int i = 0; i < MovieList.Length; i++)
            {
                if (MovieList[i].ItemValue.Equals(itemValue))
                {
                    return MovieList[i];
                }
            }

            Debug.WriteLine("ERROR: No Movie found with name: " + itemValue);
            return MovieList[0];
        }

    }
}
