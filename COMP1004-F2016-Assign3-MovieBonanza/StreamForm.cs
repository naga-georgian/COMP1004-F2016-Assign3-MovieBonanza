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
    public partial class StreamForm : Form
    {
        public StreamForm()
        {
            InitializeComponent();
        }

        private void StreamForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            StreamForm.ActiveForm.Close();
        }
    }
}
