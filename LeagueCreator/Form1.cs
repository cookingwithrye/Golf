using System;
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

using LeagueCreator.Factories;

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
                MessageBox.Show(String.Format("Error encountered, probably in the data format in the excel file. More details: '{0}'", ex.Message));
            }
        }

        private void btnCreateTeams_Click(object sender, EventArgs e)
        {
            if (PlayerSheet == null)
            {
                MessageBox.Show("Please load the players first.");
                return;
            }

            try
            {
                //ask the user how many teams should be created
                int numTeams = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("How many teams do you want to create?"));

                //generate the teams
                var teams = PlayerSheet.CreateTeams(numTeams);

                //TODO: output the teams to the specified file
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Some kind of error creating the teams. Probably an invalid number. More details '{0}'", ex.Message));
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            //TODO: Use shellexec to open the xls file using Excel
        }
    }
}
