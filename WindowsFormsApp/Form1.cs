using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedLibrary;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //create a method for the text box when the button is clicked


        private void buttonGetUCName_Click(object sender, EventArgs e)
        {
            //call the method from the shared library
            string x = SIHelper.GetUCName();
            //display the result in the text box
            textBoxUCName.Text = x;
        }

        private void btnSaveToDatabase_Click(object sender, EventArgs e)
        {

        }
    }
}
