using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odin_Scores
{
    public partial class OdinForm : System.Windows.Forms.Form
    {
        // int voor het bepalen van de groote van de groep
        party Party = new party();
        Player Player1 = new Player();
        Player Player2 = new Player();
        Player Player3 = new Player();
        Player Player4 = new Player();

                       
        public OdinForm()
        {
            InitializeComponent();
            Player1.Name = "Player 1";
            Player2.Name = "Player 2";
            Player3.Name = "Player 3";
            Player4.Name = "Player 4";
        }

        private void PlayerNumberBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Party.Selected = Convert.ToInt16(PlayerNumberBox.SelectedIndex);
            // Omdat de selectie een array is moet je er 1 bijop tellen zodat je party overeenkomst met het aantal spelers.
            Party.Size = Party.Selected + 1;

            if (Party.Size == 1)
            {
                pictureBoxPlayers.Visible = false;
                Player1Text.Visible = true;
                Player1Text.BackColor = Color.Azure;
                Player1Colour.Visible = true;
                Player1Colour.BackColor = Color.Azure;
                Player2Text.Visible = false;
                Player2Colour.Visible = false;
                Player3Text.Visible = false;
                Player3Colour.Visible = false;
                Player4Text.Visible = false;
                Player4Colour.Visible = false;
                Player1radioButton.Visible = true;
                Player1radioButton.BackColor = Color.Azure;
                Player2radioButton.Visible = false;
                Player3radioButton.Visible = false;
                Player4radioButton.Visible = false;
                Player1EndscoreLabel.Visible = true;
                Player1EndscoreLabel.BackColor = Color.Azure;
                Player2EndscoreLabel.Visible = false;
                Player3EndscoreLabel.Visible = false;
                Player4EndscoreLabel.Visible = false;
            }

            else if (Party.Size == 2)
            {
                pictureBoxPlayers.Visible = false;
                Player1Text.Visible = true;
                Player1Text.BackColor = Color.Azure;
                Player1Colour.Visible = true;
                Player1Colour.BackColor = Color.Azure;
                Player2Text.Visible = true;
                Player2Text.BackColor = Color.Azure;
                Player2Colour.Visible = true;
                Player2Colour.BackColor = Color.Azure;
                Player3Text.Visible = false;
                Player3Colour.Visible = false;
                Player4Text.Visible = false;
                Player4Colour.Visible = false;
                Player1radioButton.Visible = true;
                Player1radioButton.BackColor = Color.Azure;
                Player2radioButton.Visible = true;
                Player2radioButton.BackColor = Color.Azure;
                Player3radioButton.Visible = false;
                Player4radioButton.Visible = false;
                Player1EndscoreLabel.Visible = true;
                Player1EndscoreLabel.BackColor = Color.Azure;
                Player2EndscoreLabel.Visible = true;
                Player2EndscoreLabel.BackColor = Color.Azure;
                Player3EndscoreLabel.Visible = false;
                Player4EndscoreLabel.Visible = false;
            }

            else if (Party.Size == 3)
            {
                pictureBoxPlayers.Visible = false;
                Player1Text.Visible = true;
                Player1Text.BackColor = Color.Azure;
                Player1Colour.Visible = true;
                Player1Colour.BackColor = Color.Azure;
                Player2Text.Visible = true;
                Player2Text.BackColor = Color.Azure;
                Player2Colour.Visible = true;
                Player2Colour.BackColor = Color.Azure;
                Player3Text.Visible = true;
                Player3Text.BackColor = Color.Azure;
                Player3Colour.Visible = true;
                Player3Colour.BackColor = Color.Azure;
                Player4Text.Visible = false;
                Player4Colour.Visible = false;
                Player1radioButton.Visible = true;
                Player1radioButton.BackColor = Color.Azure;
                Player2radioButton.Visible = true;
                Player2radioButton.BackColor = Color.Azure;
                Player3radioButton.Visible = true;
                Player3radioButton.BackColor = Color.Azure;
                Player4radioButton.Visible = false;
                Player1EndscoreLabel.Visible = true;
                Player1EndscoreLabel.BackColor = Color.Azure;
                Player2EndscoreLabel.Visible = true;
                Player2EndscoreLabel.BackColor = Color.Azure;
                Player3EndscoreLabel.Visible = true;
                Player3EndscoreLabel.BackColor = Color.Azure;
                Player4EndscoreLabel.Visible = false;
            }

            else if (Party.Size >= 4)
            {
                pictureBoxPlayers.Visible = false;
                Player1Text.Visible = true;
                Player1Text.BackColor = Color.Azure;
                Player1Colour.Visible = true;
                Player1Colour.BackColor = Color.Azure;
                Player2Text.Visible = true;
                Player2Text.BackColor = Color.Azure;
                Player2Colour.Visible = true;
                Player2Colour.BackColor = Color.Azure;
                Player3Text.Visible = true;
                Player3Text.BackColor = Color.Azure;
                Player3Colour.Visible = true;
                Player3Colour.BackColor = Color.Azure;
                Player4Text.Visible = true;
                Player4Text.BackColor = Color.Azure;
                Player4Colour.Visible = true;
                Player4Colour.BackColor = Color.Azure;
                Player1radioButton.Visible = true;
                Player1radioButton.BackColor = Color.Azure;
                Player2radioButton.Visible = true;
                Player2radioButton.BackColor = Color.Azure;
                Player3radioButton.Visible = true;
                Player3radioButton.BackColor = Color.Azure;
                Player4radioButton.Visible = true;
                Player4radioButton.BackColor = Color.Azure;
                Player1EndscoreLabel.Visible = true;
                Player1EndscoreLabel.BackColor = Color.Azure;
                Player2EndscoreLabel.Visible = true;
                Player2EndscoreLabel.BackColor = Color.Azure;
                Player3EndscoreLabel.Visible = true;
                Player3EndscoreLabel.BackColor = Color.Azure;
                Player4EndscoreLabel.Visible = true;
                Player4EndscoreLabel.BackColor = Color.Azure;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            pictureBoxForm.Visible = false;
            pictureBoxPlayers.Visible = false;
            Player1Text.Visible = false;
            Player1Colour.Visible = false;
            Player2Text.Visible = false;
            Player2Colour.Visible = false;
            Player3Text.Visible = false;
            Player3Colour.Visible = false;
            Player4Text.Visible = false;
            Player4Colour.Visible = false;
            labelPlayerSelect.Visible = false;
            StartButton.Visible = false;
            PlayerNumberBox.Visible = false;
            PlayerNumberLabel.Visible = false;
        }

        public void ScoreButton_Click(object sender, EventArgs e)
        {
            #region Spelers uitrekenen
            if (Party.Size == 1)
            {
                Player1.AddPlus();
                Player1.AddMin();
                Player1.Totaal();
                Player2.Endscore = -99999;
                Player3.Endscore = -99999;
                Player4.Endscore = -99999;
            }
            if (Party.Size == 2)
            {
                Player1.AddPlus();
                Player1.AddMin();
                Player1.Totaal();
                Player2.AddPlus();
                Player2.AddMin();
                Player2.Totaal();
                Player3.Endscore = -99999;
                Player4.Endscore = -99999;
            }
            if (Party.Size == 3)
            {
                Player1.AddPlus();
                Player1.AddMin();
                Player1.Totaal();
                Player2.AddPlus();
                Player2.AddMin();
                Player2.Totaal();
                Player3.AddPlus();
                Player3.AddMin();
                Player3.Totaal();
                Player4.Endscore = -99999;
            }
            if (Party.Size == 4)
            {
                Player1.AddPlus();
                Player1.AddMin();
                Player1.Totaal();
                Player2.AddPlus();
                Player2.AddMin();
                Player2.Totaal();
                Player3.AddPlus();
                Player3.AddMin();
                Player3.Totaal();
                Player4.AddPlus();
                Player4.AddMin();
                Player4.Totaal();
            }
            #endregion

            #region Party Winnaar uitrekenen

            if (Player1.Endscore > Player2.Endscore &&
                Player1.Endscore > Player3.Endscore &&
                Player1.Endscore > Player4.Endscore)
            {
                MessageBox.Show("Congratulations " + Player1.Name + ", You have won!!!!");
            }

            else if (Player2.Endscore > Player1.Endscore &&
                    Player2.Endscore > Player3.Endscore &&
                    Player2.Endscore > Player4.Endscore)
            {
                MessageBox.Show("Congratulations " + Player2.Name + ", You have won!!!!");
            }

            else if (Player3.Endscore > Player1.Endscore &&
                    Player3.Endscore > Player2.Endscore &&
                    Player3.Endscore > Player4.Endscore)
            {
                MessageBox.Show("Congratulations " + Player3.Name + ", You have won!!!!"); ;
            }

            else if (Player4.Endscore > Player1.Endscore &&
                    Player4.Endscore > Player2.Endscore &&
                    Player4.Endscore > Player3.Endscore)
            {
                MessageBox.Show("Congratulations " + Player4.Name + ", You have won!!!!");
            }

            else

                MessageBox.Show("Well well, it seems we might have more then one winner.");

            #endregion

            #region Labels en boxen wegwerken
            Player1radioButton.Visible = false;
            Player2radioButton.Visible = false;
            Player3radioButton.Visible = false;
            Player4radioButton.Visible = false;
            ScoreButton.Visible = false;
            labelWatTeDoen.Visible = false;
            labelShips.Visible = false;
            labelEmigration.Visible = false;
            labelExplorationBoardP.Visible = false;
            labelShedsHousesP.Visible = false;
            labelSheepCattle.Visible = false;
            labelOccupations.Visible = false;
            labelSilver.Visible = false;
            labelFinalIncome.Visible = false;
            labelEnglishCrown.Visible = false;
            labelPositivePoints.Visible = false;
            labelNegativepoints.Visible = false;
            labelHomeBoard.Visible = false;
            labelExplorationBoardN.Visible = false;
            labelShedsHousesN.Visible = false;
            labelThingPenalty.Visible = false;
            ShipsBoxP4.Visible = false;
            EmigrationBoxP4.Visible = false;
            ExplorationBoardsPBoxP4.Visible = false;
            ShedsHousesPBoxP4.Visible = false;
            SheepCattleBoxP4.Visible = false;
            OccupationsBoxP4.Visible = false; 
            SilverBoxP4.Visible = false;
            FinalIncomeBoxP4.Visible = false;
            HomeBoardBoxP4.Visible = false;
            ExplorationBoardsNBoxP4.Visible = false;
            ShedsHousesNBoxP4.Visible = false;
            ThingPenaltyBoxP4.Visible = false;
            pictureBoxForm.Visible = false;
            EnglishCrownBoxP4.Visible = false;
            pictureBoxRadioButtons.Visible = false;
            pictureBoxEndscore.Visible = false;
            ShipsBoxP2.Visible = false;
            EmigrationBoxP2.Visible = false;
            ExplorationBoardsPBoxP2.Visible = false;
            ShedsHousesPBoxP2.Visible = false;
            SheepCattleBoxP2.Visible = false;
            OccupationsBoxP2.Visible = false;
            SilverBoxP2.Visible = false;
            FinalIncomeBoxP2.Visible = false;
            HomeBoardBoxP2.Visible = false;
            ExplorationBoardsNBoxP2.Visible = false;
            ShedsHousesNBoxP2.Visible = false;
            ThingPenaltyBoxP2.Visible = false;
            EnglishCrownBoxP2.Visible = false;
            ShipsBoxP3.Visible = false;
            EmigrationBoxP3.Visible = false;
            ExplorationBoardsPBoxP3.Visible = false;
            ShedsHousesPBoxP3.Visible = false;
            SheepCattleBoxP3.Visible = false;
            OccupationsBoxP3.Visible = false;
            SilverBoxP3.Visible = false;
            FinalIncomeBoxP3.Visible = false;
            HomeBoardBoxP3.Visible = false;
            ExplorationBoardsNBoxP3.Visible = false;
            ShedsHousesNBoxP3.Visible = false;
            ThingPenaltyBoxP3.Visible = false;
            EnglishCrownBoxP3.Visible = false;
            ShipsBoxP1.Visible = false;
            EmigrationBoxP1.Visible = false;
            ExplorationBoardsPBoxP1.Visible = false;
            ShedsHousesPBoxP1.Visible = false;
            SheepCattleBoxP1.Visible = false;
            OccupationsBoxP1.Visible = false;
            SilverBoxP1.Visible = false;
            FinalIncomeBoxP1.Visible = false;
            HomeBoardBoxP1.Visible = false;
            ExplorationBoardsNBoxP1.Visible = false;
            ShedsHousesNBoxP1.Visible = false;
            ThingPenaltyBoxP1.Visible = false;
            EnglishCrownBoxP1.Visible = false;


            #endregion
           
            #region Endscore bijwerken
            Player1EndscoreLabel.Text = Player1.Name.ToString() + " has " + Player1.Endscore.ToString() + " points.";
            Player2EndscoreLabel.Text = Player2.Name.ToString() + " has " + Player2.Endscore.ToString() + " points.";
            Player3EndscoreLabel.Text = Player3.Name.ToString() + " has " + Player3.Endscore.ToString() + " points.";
            Player4EndscoreLabel.Text = Player4.Name.ToString() + " has " + Player4.Endscore.ToString() + " points.";
            #endregion  
        }
         

        #region Player1 input
        private void Player1Text_TextChanged(object sender, EventArgs e)
        {
            Player1.Name = "Player 1";
            Player1.Name = Player1Text.Text;
            Player1radioButton.Text = Player1.Name;
        }       
        private void Player1Colour_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player1.Colour = Player1Colour.SelectedItem.ToString();

            if (Player1.Colour == "Red")
            {
                Player1radioButton.ForeColor = Color.Red;
               
            }
            else if (Player1.Colour == "Blue")
            {
                Player1radioButton.ForeColor = Color.Blue;
            }
            else if (Player1.Colour == "Yellow")
            {
                Player1radioButton.ForeColor = Color.Yellow;
            }
            else
            {
                Player1radioButton.ForeColor = Color.Black;
            }
        }
        private void Player1radioButton_Checked(object sender, EventArgs e)
        {
            ShipsBoxP1.Visible = true;
            ShipsBoxP1.BackColor = Color.Azure;
            EmigrationBoxP1.Visible = true;
            EmigrationBoxP1.BackColor = Color.Azure;
            ExplorationBoardsPBoxP1.Visible = true;
            ExplorationBoardsPBoxP1.BackColor = Color.Azure;
            ShedsHousesPBoxP1.Visible = true;
            ShedsHousesPBoxP1.BackColor = Color.Azure;
            SheepCattleBoxP1.Visible = true;
            SheepCattleBoxP1.BackColor = Color.Azure;
            OccupationsBoxP1.Visible = true;
            OccupationsBoxP1.BackColor = Color.Azure;
            SilverBoxP1.Visible = true;
            SilverBoxP1.BackColor = Color.Azure;
            FinalIncomeBoxP1.Visible = true;
            FinalIncomeBoxP1.BackColor = Color.Azure;
            HomeBoardBoxP1.Visible = true;
            HomeBoardBoxP1.BackColor = Color.Azure;
            ExplorationBoardsNBoxP1.Visible = true;
            ExplorationBoardsNBoxP1.BackColor = Color.Azure;
            ShedsHousesNBoxP1.Visible = true;
            ShedsHousesNBoxP1.BackColor = Color.Azure;
            ThingPenaltyBoxP1.Visible = true;
            ThingPenaltyBoxP1.BackColor = Color.Azure;
            EnglishCrownBoxP1.Visible = true;
            EnglishCrownBoxP1.BackColor = Color.Azure;
            
            ShipsBoxP2.Visible = false;
            EmigrationBoxP2.Visible = false;
            ExplorationBoardsPBoxP2.Visible = false;
            ShedsHousesPBoxP2.Visible = false;
            SheepCattleBoxP2.Visible = false;
            OccupationsBoxP2.Visible = false;
            SilverBoxP2.Visible = false;
            FinalIncomeBoxP2.Visible = false;
            HomeBoardBoxP2.Visible = false;
            ExplorationBoardsNBoxP2.Visible = false;
            ShedsHousesNBoxP2.Visible = false;
            ThingPenaltyBoxP2.Visible = false;
            EnglishCrownBoxP2.Visible = false;

            ShipsBoxP3.Visible = false;
            EmigrationBoxP3.Visible = false;
            ExplorationBoardsPBoxP3.Visible = false;
            ShedsHousesPBoxP3.Visible = false;
            SheepCattleBoxP3.Visible = false;
            OccupationsBoxP3.Visible = false;
            SilverBoxP3.Visible = false;
            FinalIncomeBoxP3.Visible = false;
            HomeBoardBoxP3.Visible = false;
            ExplorationBoardsNBoxP3.Visible = false;
            ShedsHousesNBoxP3.Visible = false;
            ThingPenaltyBoxP3.Visible = false;
            EnglishCrownBoxP3.Visible = false;

            ShipsBoxP4.Visible = false;
            EmigrationBoxP4.Visible = false;
            ExplorationBoardsPBoxP4.Visible = false;
            ShedsHousesPBoxP4.Visible = false;
            SheepCattleBoxP4.Visible = false;
            OccupationsBoxP4.Visible = false;
            SilverBoxP4.Visible = false;
            FinalIncomeBoxP4.Visible = false;
            HomeBoardBoxP4.Visible = false;
            ExplorationBoardsNBoxP4.Visible = false;
            ShedsHousesNBoxP4.Visible = false;
            ThingPenaltyBoxP4.Visible = false;
            EnglishCrownBoxP4.Visible = false;

        }

        
        private void ShipsBoxP1_TextChanged(Object sender, EventArgs e)
        {
            Player1.Ships = Convert.ToInt32(ShipsBoxP1.Text);
        }
        private void EmigrationBoxP1_TextChanged(Object sender, EventArgs e)
        {
            Player1.Emigration = Convert.ToInt32(EmigrationBoxP1.Text);
        }
        private void ExplorationBoardsPBoxP1_TextChanged(Object sender, EventArgs e)
        {
            Player1.ExplorationP = Convert.ToInt32(ExplorationBoardsPBoxP1.Text);
        }
        private void ShedsHousesPBoxP1_TextChanged(Object sender, EventArgs e)
        {
            Player1.ShedsHousesP = Convert.ToInt32(ShedsHousesPBoxP1.Text);
        }
        private void SheepCattleBoxP1_TextChanged(Object sender, EventArgs e)
        {
            Player1.SheepCattle = Convert.ToInt32(SheepCattleBoxP1.Text);
        }
        private void OccupationsBoxP1_TextChanged(Object sender, EventArgs e)
        {
            Player1.Occupations = Convert.ToInt32(OccupationsBoxP1.Text);
        }
        private void SilverBoxP1_TextChanged(Object sender, EventArgs e)
        {
            Player1.Silver = Convert.ToInt32(SilverBoxP1.Text);
        }
        private void FinalIncomeBoxP1_TextChanged(Object sender, EventArgs e)
        {
            Player1.FinalIncome = Convert.ToInt32(FinalIncomeBoxP1.Text);
        }
        private void HomeBoardBoxP1_TextChanged(Object sender, EventArgs e)
        {
            Player1.HomeBoard = Convert.ToInt32(HomeBoardBoxP1.Text);
        }
        private void ExplorationBoardsNBoxP1_TextChanged(Object sender, EventArgs e)
        {
            Player1.ExplorationN = Convert.ToInt32(ExplorationBoardsNBoxP1.Text);
        }
        private void ShedsHousesNBoxP1_TextChanged(Object sender, EventArgs e)
        {
            Player1.ShedsHousesN = Convert.ToInt32(ShedsHousesNBoxP1.Text);
        }
        private void ThingPenaltyBoxP1_TextChanged(Object sender, EventArgs e)
        {
            Player1.ThingPenalty = Convert.ToInt32(ThingPenaltyBoxP1.Text);

        }
        private void EnglishCrownBoxP1_CheckedChanged(Object sender, EventArgs e)
        {
            if (EnglishCrownBoxP1.Checked)
            {
                Player1.Crown = 2;
            }
        }
        #endregion

        #region Player2 input
        private void Player2Text_TextChanged(object sender, EventArgs e)
        {
            Player2.Name = Player2Text.Text;
            Player2radioButton.Text = Player2.Name;
        } 
        private void Player2Colour_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player2.Colour = Player2Colour.SelectedItem.ToString();

            if (Player2.Colour == "Red")
            {
                Player2radioButton.ForeColor = Color.Red;
            }
            else if (Player2.Colour == "Blue")
            {
                Player2radioButton.ForeColor = Color.Blue;
            }
            else if (Player2.Colour == "Yellow")
            {
                Player2radioButton.ForeColor = Color.Yellow;
            }
            else
            {
                Player2radioButton.ForeColor = Color.Black;
            }
        }
        private void Player2radioButton_Checked(object sender, EventArgs e)
        {
            ShipsBoxP2.Visible = true;
            ShipsBoxP2.BackColor = Color.Azure;
            EmigrationBoxP2.Visible = true;
            EmigrationBoxP2.BackColor = Color.Azure;
            ExplorationBoardsPBoxP2.Visible = true;
            ExplorationBoardsPBoxP2.BackColor = Color.Azure;
            ShedsHousesPBoxP2.Visible = true;
            ShedsHousesPBoxP2.BackColor = Color.Azure;
            SheepCattleBoxP2.Visible = true;
            SheepCattleBoxP2.BackColor = Color.Azure;
            OccupationsBoxP2.Visible = true;
            OccupationsBoxP2.BackColor = Color.Azure;
            SilverBoxP2.Visible = true;
            SilverBoxP2.BackColor = Color.Azure;
            FinalIncomeBoxP2.Visible = true;
            FinalIncomeBoxP2.BackColor = Color.Azure;
            HomeBoardBoxP2.Visible = true;
            HomeBoardBoxP2.BackColor = Color.Azure;
            ExplorationBoardsNBoxP2.Visible = true;
            ExplorationBoardsNBoxP2.BackColor = Color.Azure;
            ShedsHousesNBoxP2.Visible = true;
            ShedsHousesNBoxP2.BackColor = Color.Azure;
            ThingPenaltyBoxP2.Visible = true;
            ThingPenaltyBoxP2.BackColor = Color.Azure;
            EnglishCrownBoxP2.Visible = true;
            EnglishCrownBoxP2.BackColor = Color.Azure;

            ShipsBoxP1.Visible = false;
            EmigrationBoxP1.Visible = false;
            ExplorationBoardsPBoxP1.Visible = false;
            ShedsHousesPBoxP1.Visible = false;
            SheepCattleBoxP1.Visible = false;
            OccupationsBoxP1.Visible = false;
            SilverBoxP1.Visible = false;
            FinalIncomeBoxP1.Visible = false;
            HomeBoardBoxP1.Visible = false;
            ExplorationBoardsNBoxP1.Visible = false;
            ShedsHousesNBoxP1.Visible = false;
            ThingPenaltyBoxP1.Visible = false;
            EnglishCrownBoxP1.Visible = false;

            ShipsBoxP3.Visible = false;
            EmigrationBoxP3.Visible = false;
            ExplorationBoardsPBoxP3.Visible = false;
            ShedsHousesPBoxP3.Visible = false;
            SheepCattleBoxP3.Visible = false;
            OccupationsBoxP3.Visible = false;
            SilverBoxP3.Visible = false;
            FinalIncomeBoxP3.Visible = false;
            HomeBoardBoxP3.Visible = false;
            ExplorationBoardsNBoxP3.Visible = false;
            ShedsHousesNBoxP3.Visible = false;
            ThingPenaltyBoxP3.Visible = false;
            EnglishCrownBoxP3.Visible = false;

            ShipsBoxP4.Visible = false;
            EmigrationBoxP4.Visible = false;
            ExplorationBoardsPBoxP4.Visible = false;
            ShedsHousesPBoxP4.Visible = false;
            SheepCattleBoxP4.Visible = false;
            OccupationsBoxP4.Visible = false;
            SilverBoxP4.Visible = false;
            FinalIncomeBoxP4.Visible = false;
            HomeBoardBoxP4.Visible = false;
            ExplorationBoardsNBoxP4.Visible = false;
            ShedsHousesNBoxP4.Visible = false;
            ThingPenaltyBoxP4.Visible = false;
            EnglishCrownBoxP4.Visible = false;
        }


        private void ShipsBoxP2_TextChanged(Object sender, EventArgs e)
        {
            Player2.Ships = Convert.ToInt32(ShipsBoxP2.Text);
        }
        private void EmigrationBoxP2_TextChanged(Object sender, EventArgs e)
        {
            Player2.Emigration = Convert.ToInt32(EmigrationBoxP2.Text);
        }
        private void ExplorationBoardsPBoxP2_TextChanged(Object sender, EventArgs e)
        {
            Player2.ExplorationP = Convert.ToInt32(ExplorationBoardsPBoxP2.Text);
        }
        private void ShedsHousesPBoxP2_TextChanged(Object sender, EventArgs e)
        {
            Player2.ShedsHousesP = Convert.ToInt32(ShedsHousesPBoxP2.Text);
        }
        private void SheepCattleBoxP2_TextChanged(Object sender, EventArgs e)
        {
            Player2.SheepCattle = Convert.ToInt32(SheepCattleBoxP2.Text);
        }
        private void OccupationsBoxP2_TextChanged(Object sender, EventArgs e)
        {
            Player2.Occupations = Convert.ToInt32(OccupationsBoxP2.Text);
        }
        private void SilverBoxP2_TextChanged(Object sender, EventArgs e)
        {
            Player2.Silver = Convert.ToInt32(SilverBoxP2.Text);
        }
        private void FinalIncomeBoxP2_TextChanged(Object sender, EventArgs e)
        {
            Player2.FinalIncome = Convert.ToInt32(FinalIncomeBoxP2.Text);
        }
        private void HomeBoardBoxP2_TextChanged(Object sender, EventArgs e)
        {
            Player2.HomeBoard = Convert.ToInt32(HomeBoardBoxP2.Text);
        }
        private void ExplorationBoardsNBoxP2_TextChanged(Object sender, EventArgs e)
        {
            Player2.ExplorationN = Convert.ToInt32(ExplorationBoardsNBoxP2.Text);
        }
        private void ShedsHousesNBoxP2_TextChanged(Object sender, EventArgs e)
        {
            Player2.ShedsHousesN = Convert.ToInt32(ShedsHousesNBoxP2.Text);
        }
        private void ThingPenaltyBoxP2_TextChanged(Object sender, EventArgs e)
        {
            Player2.ThingPenalty = Convert.ToInt32(ThingPenaltyBoxP2.Text);

        }
        private void EnglishCrownBoxP2_CheckedChanged(Object sender, EventArgs e)
        {
            if (EnglishCrownBoxP2.Checked)
            {
                Player2.Crown = 2;
            }
        }
        #endregion

        #region Player3 input
        private void Player3Text_TextChanged(object sender, EventArgs e)
        {
            Player3.Name = Player3Text.Text;
            Player3radioButton.Text = Player3.Name;
        }
        private void Player3Colour_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player3.Colour = Player3Colour.SelectedItem.ToString();

            if (Player3.Colour == "Red")
            {
                Player3radioButton.ForeColor = Color.Red;
            }
            else if (Player3.Colour == "Blue")
            {
                Player3radioButton.ForeColor = Color.Blue;
            }
            else if (Player3.Colour == "Yellow")
            {
                Player3radioButton.ForeColor = Color.Yellow;
            }
            else
            {
                Player3radioButton.ForeColor = Color.Black;
            }
        }
        private void Player3radioButton_Checked(object sender, EventArgs e)
        {
            ShipsBoxP3.Visible = true;
            ShipsBoxP3.BackColor = Color.Azure;
            EmigrationBoxP3.Visible = true;
            EmigrationBoxP3.BackColor = Color.Azure;
            ExplorationBoardsPBoxP3.Visible = true;
            ExplorationBoardsPBoxP3.BackColor = Color.Azure;
            ShedsHousesPBoxP3.Visible = true;
            ShedsHousesPBoxP3.BackColor = Color.Azure;
            SheepCattleBoxP3.Visible = true;
            SheepCattleBoxP3.BackColor = Color.Azure;
            OccupationsBoxP3.Visible = true;
            OccupationsBoxP3.BackColor = Color.Azure;
            SilverBoxP3.Visible = true;
            SilverBoxP3.BackColor = Color.Azure;
            FinalIncomeBoxP3.Visible = true;
            FinalIncomeBoxP3.BackColor = Color.Azure;
            HomeBoardBoxP3.Visible = true;
            HomeBoardBoxP3.BackColor = Color.Azure;
            ExplorationBoardsNBoxP3.Visible = true;
            ExplorationBoardsNBoxP3.BackColor = Color.Azure;
            ShedsHousesNBoxP3.Visible = true;
            ShedsHousesNBoxP3.BackColor = Color.Azure;
            ThingPenaltyBoxP3.Visible = true;
            ThingPenaltyBoxP3.BackColor = Color.Azure;
            EnglishCrownBoxP3.Visible = true;
            EnglishCrownBoxP3.BackColor = Color.Azure;

            ShipsBoxP2.Visible = false;
            EmigrationBoxP2.Visible = false;
            ExplorationBoardsPBoxP2.Visible = false;
            ShedsHousesPBoxP2.Visible = false;
            SheepCattleBoxP2.Visible = false;
            OccupationsBoxP2.Visible = false;
            SilverBoxP2.Visible = false;
            FinalIncomeBoxP2.Visible = false;
            HomeBoardBoxP2.Visible = false;
            ExplorationBoardsNBoxP2.Visible = false;
            ShedsHousesNBoxP2.Visible = false;
            ThingPenaltyBoxP2.Visible = false;
            EnglishCrownBoxP2.Visible = false;

            ShipsBoxP1.Visible = false;
            EmigrationBoxP1.Visible = false;
            ExplorationBoardsPBoxP1.Visible = false;
            ShedsHousesPBoxP1.Visible = false;
            SheepCattleBoxP1.Visible = false;
            OccupationsBoxP1.Visible = false;
            SilverBoxP1.Visible = false;
            FinalIncomeBoxP1.Visible = false;
            HomeBoardBoxP1.Visible = false;
            ExplorationBoardsNBoxP1.Visible = false;
            ShedsHousesNBoxP1.Visible = false;
            ThingPenaltyBoxP1.Visible = false;
            EnglishCrownBoxP1.Visible = false;

            ShipsBoxP4.Visible = false;
            EmigrationBoxP4.Visible = false;
            ExplorationBoardsPBoxP4.Visible = false;
            ShedsHousesPBoxP4.Visible = false;
            SheepCattleBoxP4.Visible = false;
            OccupationsBoxP4.Visible = false;
            SilverBoxP4.Visible = false;
            FinalIncomeBoxP4.Visible = false;
            HomeBoardBoxP4.Visible = false;
            ExplorationBoardsNBoxP4.Visible = false;
            ShedsHousesNBoxP4.Visible = false;
            ThingPenaltyBoxP4.Visible = false;
            EnglishCrownBoxP4.Visible = false;


        }


        private void ShipsBoxP3_TextChanged(Object sender, EventArgs e)
        {
            Player3.Ships = Convert.ToInt32(ShipsBoxP3.Text);
        }
        private void EmigrationBoxP3_TextChanged(Object sender, EventArgs e)
        {
            Player3.Emigration = Convert.ToInt32(EmigrationBoxP3.Text);
        }
        private void ExplorationBoardsPBoxP3_TextChanged(Object sender, EventArgs e)
        {
            Player3.ExplorationP = Convert.ToInt32(ExplorationBoardsPBoxP3.Text);
        }
        private void ShedsHousesPBoxP3_TextChanged(Object sender, EventArgs e)
        {
            Player3.ShedsHousesP = Convert.ToInt32(ShedsHousesPBoxP3.Text);
        }
        private void SheepCattleBoxP3_TextChanged(Object sender, EventArgs e)
        {
            Player3.SheepCattle = Convert.ToInt32(SheepCattleBoxP3.Text);
        }
        private void OccupationsBoxP3_TextChanged(Object sender, EventArgs e)
        {
            Player3.Occupations = Convert.ToInt32(OccupationsBoxP3.Text);
        }
        private void SilverBoxP3_TextChanged(Object sender, EventArgs e)
        {
            Player3.Silver = Convert.ToInt32(SilverBoxP3.Text);
        }
        private void FinalIncomeBoxP3_TextChanged(Object sender, EventArgs e)
        {
            Player3.FinalIncome = Convert.ToInt32(FinalIncomeBoxP3.Text);
        }
        private void HomeBoardBoxP3_TextChanged(Object sender, EventArgs e)
        {
            Player3.HomeBoard = Convert.ToInt32(HomeBoardBoxP3.Text);
        }
        private void ExplorationBoardsNBoxP3_TextChanged(Object sender, EventArgs e)
        {
            Player3.ExplorationN = Convert.ToInt32(ExplorationBoardsNBoxP3.Text);
        }
        private void ShedsHousesNBoxP3_TextChanged(Object sender, EventArgs e)
        {
            Player3.ShedsHousesN = Convert.ToInt32(ShedsHousesNBoxP3.Text);
        }
        private void ThingPenaltyBoxP3_TextChanged(Object sender, EventArgs e)
        {
            Player3.ThingPenalty = Convert.ToInt32(ThingPenaltyBoxP3.Text);
        }
        private void EnglishCrownBoxP3_CheckedChanged(Object sender, EventArgs e)
        {
            if (EnglishCrownBoxP3.Checked)
            { 
                Player3.Crown = 2; 
            }
        }
        #endregion

        #region Player4 input
        private void Player4Text_TextChanged(object sender, EventArgs e)
        {
            Player4.Name = Player4Text.Text;
            Player4radioButton.Text = Player4.Name;
        }
        private void Player4Colour_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player4.Colour = Player4Colour.SelectedItem.ToString();

            if (Player4.Colour == "Red")
            {
                Player4radioButton.ForeColor = Color.Red;
            }
            else if (Player4.Colour == "Blue")
            {
                Player1radioButton.ForeColor = Color.Blue;
            }
            else if (Player4.Colour == "Yellow")
            {
                Player4radioButton.ForeColor = Color.Yellow;
            }
            else
            {
                Player4radioButton.ForeColor = Color.Black;
            }
        }
        private void Player4radioButton_Checked(object sender, EventArgs e)
        {
            ShipsBoxP4.Visible = true;
            ShipsBoxP4.BackColor = Color.Azure;
            EmigrationBoxP4.Visible = true;
            EmigrationBoxP4.BackColor = Color.Azure;
            ExplorationBoardsPBoxP4.Visible = true;
            ExplorationBoardsPBoxP4.BackColor = Color.Azure;
            ShedsHousesPBoxP4.Visible = true;
            ShedsHousesPBoxP4.BackColor = Color.Azure;
            SheepCattleBoxP4.Visible = true;
            SheepCattleBoxP4.BackColor = Color.Azure;
            OccupationsBoxP4.Visible = true;
            OccupationsBoxP4.BackColor = Color.Azure;
            SilverBoxP4.Visible = true;
            SilverBoxP4.BackColor = Color.Azure;
            FinalIncomeBoxP4.Visible = true;
            FinalIncomeBoxP4.BackColor = Color.Azure;
            HomeBoardBoxP4.Visible = true;
            HomeBoardBoxP4.BackColor = Color.Azure;
            ExplorationBoardsNBoxP4.Visible = true;
            ExplorationBoardsNBoxP4.BackColor = Color.Azure;
            ShedsHousesNBoxP4.Visible = true;
            ShedsHousesNBoxP4.BackColor = Color.Azure;
            ThingPenaltyBoxP4.Visible = true;
            ThingPenaltyBoxP4.BackColor = Color.Azure;
            EnglishCrownBoxP4.Visible = true;
            EnglishCrownBoxP4.BackColor = Color.Azure;

            ShipsBoxP2.Visible = false;
            EmigrationBoxP2.Visible = false;
            ExplorationBoardsPBoxP2.Visible = false;
            ShedsHousesPBoxP2.Visible = false;
            SheepCattleBoxP2.Visible = false;
            OccupationsBoxP2.Visible = false;
            SilverBoxP2.Visible = false;
            FinalIncomeBoxP2.Visible = false;
            HomeBoardBoxP2.Visible = false;
            ExplorationBoardsNBoxP2.Visible = false;
            ShedsHousesNBoxP2.Visible = false;
            ThingPenaltyBoxP2.Visible = false;
            EnglishCrownBoxP2.Visible = false;

            ShipsBoxP3.Visible = false;
            EmigrationBoxP3.Visible = false;
            ExplorationBoardsPBoxP3.Visible = false;
            ShedsHousesPBoxP3.Visible = false;
            SheepCattleBoxP3.Visible = false;
            OccupationsBoxP3.Visible = false;
            SilverBoxP3.Visible = false;
            FinalIncomeBoxP3.Visible = false;
            HomeBoardBoxP3.Visible = false;
            ExplorationBoardsNBoxP3.Visible = false;
            ShedsHousesNBoxP3.Visible = false;
            ThingPenaltyBoxP3.Visible = false;
            EnglishCrownBoxP3.Visible = false;

            ShipsBoxP1.Visible = false;
            EmigrationBoxP1.Visible = false;
            ExplorationBoardsPBoxP1.Visible = false;
            ShedsHousesPBoxP1.Visible = false;
            SheepCattleBoxP1.Visible = false;
            OccupationsBoxP1.Visible = false;
            SilverBoxP1.Visible = false;
            FinalIncomeBoxP1.Visible = false;
            HomeBoardBoxP1.Visible = false;
            ExplorationBoardsNBoxP1.Visible = false;
            ShedsHousesNBoxP1.Visible = false;
            ThingPenaltyBoxP1.Visible = false;
            EnglishCrownBoxP1.Visible = false;
            
        }
        

        private void ShipsBoxP4_TextChanged (Object sender, EventArgs e)
        {
            Player4.Ships = Convert.ToInt32(ShipsBoxP4.Text);
        }
        private void EmigrationBoxP4_TextChanged (Object sender, EventArgs e)
        {
            Player4.Emigration = Convert.ToInt32(EmigrationBoxP4.Text);
        }        
        private void ExplorationBoardsPBoxP4_TextChanged (Object sender, EventArgs e)
        {
            Player4.ExplorationP = Convert.ToInt32(ExplorationBoardsPBoxP4.Text);
        }
        private void ShedsHousesPBoxP4_TextChanged (Object sender, EventArgs e)
        {
            Player4.ShedsHousesP = Convert.ToInt32(ShedsHousesPBoxP4.Text);
        }
        private void SheepCattleBoxP4_TextChanged (Object sender, EventArgs e)
        {
            Player4.SheepCattle = Convert.ToInt32(SheepCattleBoxP4.Text);
        }
        private void OccupationsBoxP4_TextChanged (Object sender, EventArgs e)
        {
            Player4.Occupations = Convert.ToInt32(OccupationsBoxP4.Text);
        }
        private void SilverBoxP4_TextChanged (Object sender, EventArgs e)
        {
            Player4.Silver = Convert.ToInt32(SilverBoxP4.Text);
        }
        private void FinalIncomeBoxP4_TextChanged (Object sender, EventArgs e)
        {
            Player4.FinalIncome = Convert.ToInt32(FinalIncomeBoxP4.Text);
        }
        private void HomeBoardBoxP4_TextChanged (Object sender, EventArgs e)
        {
            Player4.HomeBoard = Convert.ToInt32(HomeBoardBoxP4.Text);
        }
        private void ExplorationBoardsNBoxP4_TextChanged (Object sender, EventArgs e)
        {
            Player4.ExplorationN = Convert.ToInt32(ExplorationBoardsNBoxP4.Text);
        }
        private void ShedsHousesNBoxP4_TextChanged (Object sender, EventArgs e)
        {
            Player4.ShedsHousesN = Convert.ToInt32(ShedsHousesNBoxP4.Text);
        }
        private void ThingPenaltyBoxP4_TextChanged(Object sender, EventArgs e)
        {
            Player4.ThingPenalty = Convert.ToInt32(ThingPenaltyBoxP4.Text);
            
        }
        private void EnglishCrownBoxP4_CheckedChanged (Object sender, EventArgs e)
        {
            if (EnglishCrownBoxP4.Checked)
                {
                Player4.Crown = 2;
                }
        }
        #endregion

       
    }
}


