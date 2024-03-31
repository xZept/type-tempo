using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingSpeedTest
{
    public partial class frmStartWindow : Form
    {
        public frmStartWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Open the main window
            frmMainWindow frm = new frmMainWindow();
            frm.Show();

            // Display the given text to be typed in the text box
            // TODO: Database.getWords();

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            // Open history window
            frmHistory frm = new frmHistory();
            frm.Show();
        }
    }
}
