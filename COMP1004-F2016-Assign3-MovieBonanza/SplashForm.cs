using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Assign3_MovieBonanza
{
    public partial class SplashForm : Form
    {

        private const double _FADE_IN_TIME = 2000; //Milliseconds
        private const double _FADE_OUT_TIME = 1000;

        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            Timer TimerTicked = (Timer)sender;
            TimerTicked.Enabled = false;

            if (TimerTicked == FadeInTicker)
            {
                if (Opacity < 1)
                {
                    Opacity += (double)(FadeInTicker.Interval / _FADE_IN_TIME);

                    FadeInTicker.Enabled = true;
                }
                else
                {
                    SplashTimer.Enabled = true;
                }
            }
            else if (TimerTicked == SplashTimer)
            {
                FadeOutTicker.Enabled = true;
            }
            else if (TimerTicked == FadeOutTicker)
            {
                if (Opacity > 0)
                {
                    Opacity -= (double)(FadeOutTicker.Interval / _FADE_OUT_TIME);

                    FadeOutTicker.Enabled = true;
                }
                else
                {
                    SelectionForm NewSelectionForm = new SelectionForm();
                    NewSelectionForm.Show();

                    this.Hide();
                }
            }
        }
    }
}
