﻿using System;
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
            //get the name and uc name from the text boxes
            string studentName = textBoxStudentName.Text;
            string ucName = textBoxUCName.Text;

            //create a boolean to check if we get an error sending it to the db
            int error = DatabaseHelper.CreateStudent(studentName,ucName);
            if (error == 0)
            {
                MessageBox.Show("Error saving to database");
            }
            else
            {
                MessageBox.Show("Saved to database");
            }
        }

    }
}
