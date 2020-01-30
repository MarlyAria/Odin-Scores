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


        }

        #region Buttons
        private void ScoreButton_Click(object sender, EventArgs e)
        {
          
        }

        private void PartyButton_Click(object sender, EventArgs e)
        {

        }
        #endregion
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
            }

            else if (Party.Size == 3)
            {
                pictureBoxPlayers.Visible = false;
                Player1Text.Visible = true;
                Player1Text.BackColor = Color.Azure;
                Player1Colour.Visible = true;
                Player2Colour.BackColor = Color.Azure;
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

            }

            else if (Party.Size >= 4)
            {
                pictureBoxPlayers.Visible = false;
                Player1Text.Visible = true;
                Player1Text.BackColor = Color.Azure;
                Player1Colour.Visible = true;
                Player2Colour.BackColor = Color.Azure;
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

            }
        }

        #region Player1 input
        private void Player1Text_TextChanged(object sender, EventArgs e)
        {
            Player1.Name = Player1Text.Text;
        }
       
        private void Player1Colour_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player1.Colour = Player1Colour.SelectedItem.ToString();
        }
        #endregion
        #region Player2 input
        private void Player2Text_TextChanged(object sender, EventArgs e)
        {

            Player2.Name = Player2Text.Text;
        } 
        private void Player2Colour_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player2.Colour = Player2Colour.SelectedItem.ToString();
        }
        #endregion
        #region Player3 input
        private void Player3Text_TextChanged(object sender, EventArgs e)
        {
            Player3.Name = Player3Text.Text;
        }

        private void Player3Colour_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player3.Colour = Player3Colour.SelectedItem.ToString();
        }
        #endregion
        #region Player4 input
        private void Player4Text_TextChanged(object sender, EventArgs e)
        {
            Player4.Name = Player4Text.Text;
        }

        private void Player4Colour_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player4.Colour = Player4Colour.SelectedItem.ToString();
        }
        #endregion
    
    }
}

/*  _guys = new Guy[3];
            _guys[0] = new Guy { Cash = 50, Name = "Joe", MyLabel = joeBetLabel, MyRadioButton = joeRadioButton };
            _guys[1] = new Guy { Cash = 75, Name = "Bob", MyLabel = bobBetLabel, MyRadioButton = bobRadioButton };
            _guys[2] = new Guy { Cash = 45, Name = "AI", MyLabel = aiBetLabel, MyRadioButton = aIRadioButton };
            _guys[0].MyBet = new Bet { Amount = 0, Dog = 1, Bettor = _guys[0] };
            _guys[1].MyBet = new Bet { Amount = 0, Dog = 1, Bettor = _guys[1] };
            _guys[2].MyBet = new Bet { Amount = 0, Dog = 1, Bettor = _guys[2] };
            for (int i = 0; i<_guys.Length; i++)
            {
                _guys[i].UpdateLabels();
            }
            minimumBetLabel.Text = "Miniumum bet: " + betNumericUpDown.Minimum.ToString() + " bucks";
            timer1.Interval = 500;
            */
