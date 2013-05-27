﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Packaging;
using System.IO;
using System.Xml;


namespace LeagueCreator
{
    public partial class frmLeagueGenerator : Form
    {
        private IPlayerSheet PlayerSheet;
        
        public frmLeagueGenerator()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                //load and display the player sheet onscreen
                PlayerSheet = PlayerSheetFactory.GetPlayerSheet("Players.xls");
                gridviewPlayers.DataSource = PlayerSheet.Players;
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error encountered, probably in the data format in the excel file. More details: '{0}'", ex.Message);
            }
        }

        private void btnCreateTeams_Click(object sender, EventArgs e)
        {
            if (PlayerSheet == null)
            {
                MessageBox.Show("Please load the players first.");
                return;
            }
            
            //ask the user how many teams should be created
            int numTeams = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("How many teams do you want to create?"));

            //TODO: Save the teams to the desired xls file.    
        }
    }
}
