/* Brie Prater
 * 07/23/2020
 * CIS 353
 * Professor Cain
 * Assignment 8.2 A */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week8
{
    public partial class assignment8a : Form // creating a form
    {
        double ccPrice = 4.99; // variable for chocolate chip price per dozen
        double sdPrice = 5.99; // variable for snickerdoodle price per dozen
        double omrPrice = 3.99; // variable for oatmeal raisin price per dozen
        double Final = 0; // variable to hold final price
        string date; // variable to hold estimated delivery date

        public assignment8a() // assignment8a method
        {
            InitializeComponent(); // calls to initiliaze the form
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void exit_Click(object sender, EventArgs e) // exit button click method
        { 
            Application.Exit(); // exits application
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void displayCost_Click(object sender, EventArgs e)
        {
          
        }

        private void cc_CheckedChanged(object sender, EventArgs e) // method for chocolate chip radio button
        {
            cType(sender, e); // calls cType method
        }

        private void sd_CheckedChanged(object sender, EventArgs e) // method for snickerdoodle radio button
        {
            cType(sender, e); // calls cType method
        }

        private void omr_CheckedChanged(object sender, EventArgs e) // method for oatmeal raisin radio button
        {
            cType(sender, e); // calls cType method
        }

        private void halfDzn_CheckedChanged(object sender, EventArgs e) // method for 1/2 dozen radio button
        {
            dPrice(sender, e); // calls dPrice method
        }

        private void oneDzn_CheckedChanged(object sender, EventArgs e) // method for 1 dozen radio button
        {
            dPrice(sender, e); // calls dPrice method
        }

        private void twoDzn_CheckedChanged(object sender, EventArgs e) // method for 2 dozen radio button
        {
            dPrice(sender, e); // calls dPrice method
        }

        private void threeDzn_CheckedChanged(object sender, EventArgs e) // method for 3 dozen radio button
        {
            dPrice(sender, e); // calls dPrice method
        }

        private void cType(object sender, EventArgs e) // cType method to determine which button is selected
        {
            if (cc.Checked == true) // boolean returns true if chocolate chip selected, runs rest of code within 
            {
                if (halfDzn.Checked == true) // boolean returns true if 1/2 dozen selected
                {
                    Final = ccPrice * .5; // calculates cost
                }
                else if (oneDzn.Checked == true) // boolean returns true if 1 dozen selected
                {
                    Final = ccPrice;
                }
                else if (twoDzn.Checked == true) // boolean returns true if 2 dozen selected
                {
                    Final = ccPrice * 2; // calculates cost 
                }
                else if (threeDzn.Checked == true) // boolean returns true if 3 dozen selected
                {
                    Final = ccPrice * 3; // calculates cost
                }
            }
            else if (sd.Checked == true) // boolean returns true if snickerdoodle selected, runs rest of code within
            {
                if (halfDzn.Checked == true)
                {
                    Final = sdPrice * .5;
                }
                else if (oneDzn.Checked == true)
                {
                    Final = sdPrice;
                }    
                else if (twoDzn.Checked == true)
                {
                    Final = sdPrice * 2;
                }
                else if (threeDzn.Checked == true)
                {
                    Final = sdPrice * 3;
                }
            }
            else if (omr.Checked == true) // boolean returns true if oatmeal raisin selected, runs rest of code within
            {
                if (halfDzn.Checked == true)
                {
                    Final = omrPrice * .5;
                }
                else if (oneDzn.Checked == true)
                {
                    Final = omrPrice;
                }
                else if (twoDzn.Checked == true)
                {
                    Final = omrPrice * 2;
                }
                else if (threeDzn.Checked == true)
                {
                    Final = omrPrice * 3;
                }    
            }
            displayIt(sender, e); // calls displayIt method
        }
        private void dPrice(object sender, EventArgs e) // dPrice method to determine which button is selected
        {
            if (halfDzn.Checked == true) // boolean returns true if 1/2 dozen selected, runs rest of code within
            {
                if (cc.Checked == true) // boolean returns true if chocolate chip selected
                {
                    Final = ccPrice * .5; // calculates cost
                }
                else if (sd.Checked == true) // boolean returns true if snickerdoodle selected
                { 
                    Final = sdPrice * .5; // calculates cost
                }
                else if (omr.Checked == true) // boolean returns true if oatmeal raisin selected
                {
                    Final = omrPrice * .5; // calculates cost
                }
            }
            else if (oneDzn.Checked == true) // boolean returns true if 1 dozen selected, runs rest of code within
            {
                if (cc.Checked == true)
                {
                    Final = ccPrice;
                }
                else if (sd.Checked == true)
                {
                    Final = sdPrice;
                }
                else if (omr.Checked == true)
                {
                    Final = omrPrice;
                }
            }
            else if (twoDzn.Checked == true) // boolean returns true if 2 dozen selected, runs rest of code within
            {
                if (cc.Checked == true)
                {
                    Final = ccPrice * 2;
                }
                else if (sd.Checked == true)
                {
                    Final = sdPrice * 2;
                }
                else if (omr.Checked == true)
                {
                    Final = omrPrice * 2;
                }
            }
            else if (threeDzn.Checked == true) // boolean returns true if 3 dozen selected, runs rest of code within
            {
                if (cc.Checked == true)
                {
                    Final = ccPrice * 3;
                }
                else if (sd.Checked == true)
                {
                    Final = sdPrice * 3;
                }
                else if (omr.Checked == true)
                {
                    Final = omrPrice * 3;
                }
            }
            displayIt(sender, e); // calls displayIt method
        }
        private void displayIt(object sender, EventArgs e) // displayIt method to change displayCost label
        {
            this.displayCost.Text = "$" + Final.ToString(); // sets displayCost label text to Final price variable
        }

        private void orderCalendar_DateChanged(object sender, DateRangeEventArgs e) // method to determine selected date
        {
            date = orderCalendar.SelectionRange.Start.AddDays(3).ToString(); // determines selected date, adds 3 days to that date
            // sets new date to variable date
            this.delvDate.Text = date; // sets delvDate label text to date variable
        }
    }
}
