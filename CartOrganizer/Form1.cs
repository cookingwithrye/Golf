using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CartOrganizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO: get the input list of names (should already be grouped together prior to input)
            //TODO: get the number of holes on the golf course (names should be independent of the index of the hole, just in case there needs to be more starters at that part of the course)
            //TODO: distribute the carts across the course, export the information to the word template (still need to receive a copy of this template)
        }
    }
}
