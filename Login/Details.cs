using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class Details : Form
    {
       private UserDetails currentFormUserDetails;
       public Details()
       {
            InitializeComponent();
       }

        public Details(UserDetails input) // constructor - constructs the 'details' form with the details from the array in 'input.cs'
        {
            InitializeComponent(); // builds the forms boxes, buttons etc
            currentFormUserDetails = input;//sets input values to the variable set up in line 13 above
            populateForm(); // my created function (below) to populate the boxes
        }

        void populateForm()
        {
            name.Text = currentFormUserDetails.Name;
            userName.Text = currentFormUserDetails.UserName;
            age.Text = currentFormUserDetails.Age.ToString();
            address.Text = currentFormUserDetails.Address1;


           
        }
    }

 } 

