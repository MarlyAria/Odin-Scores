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
    public partial class OdinScores : Form

    {
        // int voor het bepalen van de groote van de groep
        public int PlayerNumbers;
        Player Player1 = new Player();
        Player Player2 = new Player();
        Player Player3 = new Player();
        Player Player4 = new Player();
        
        public OdinScores()
        {
            InitializeComponent();
        }


        #region oude code uitrekenen

        /*private void button1_Click(object sender, EventArgs e)
        {    
             //
             //Zwart
             //
             int SchepenAddZ = int.Parse(ZwartSchepenInput.Text);
             int EmigratieAddZ = int.Parse(ZwartEmigratieInput.Text);
             int OntdekkingsAddZ = int.Parse(ZwartOntdekkingsInput.Text);
             int SchurenHuizenPlusAddZ = int.Parse(ZwartSchurenHuizenPlusInput.Text);
             int SchapenRunderenAddZ = int.Parse(ZwartAmbachtenInput.Text);
             int ZilverAddZ = int.Parse(ZwartZilverInput.Text);
             int LaatsteInkomstenAddZ = int.Parse(ZwartLaatsteInkomstenInput.Text);
             int EngelseKroonAddZ = int.Parse(ZwartEngelseKroonInput.Text);
             ZwartTotaalPluspuntenConclusie.Text = (SchepenAddZ + EmigratieAddZ + OntdekkingsAddZ + 
                                             SchurenHuizenPlusAddZ + SchapenRunderenAddZ + ZilverAddZ 
                                             + LaatsteInkomstenAddZ + EngelseKroonAddZ).ToString();

             int DorpsbordAddZ = int.Parse(ZwartDorpsbordInput.Text);
             int OntdekkingbordenAddZ = int.Parse(ZwartOntdekkingsbordenInput.Text);
             int SchurenHuizenMinAddZ = int.Parse(ZwartSchurenHuizenMinInput.Text);
             int ThingstrafAddZ = int.Parse(ZwartThingstrafInput.Text);
             ZwartTotaalMinpuntenConclusie.Text = (DorpsbordAddZ + OntdekkingbordenAddZ + SchurenHuizenMinAddZ +
                                              ThingstrafAddZ).ToString();

             int TotaalPluspuntenAddZ = int.Parse(ZwartTotaalPluspuntenConclusie.Text);
             int TotaalMinpuntenAddZ = int.Parse(ZwartTotaalMinpuntenConclusie.Text);
             ZwartEindscoreConclusie.Text = (TotaalPluspuntenAddZ - TotaalMinpuntenAddZ).ToString();

             //
             //Rood
             //
             int SchepenAddR = int.Parse(RoodSchepenInput.Text);
             int EmigratieAddR = int.Parse(RoodEmigratieInput.Text);
             int OntdekkingAddR = int.Parse(RoodOntdekkingsInput.Text);
             int SchurenHuizenPlusAddR = int.Parse(RoodSchurenHuizenPlusInput.Text);
             int SchapenRunderenAddR = int.Parse(RoodAmbachtenInput.Text);
             int ZilverAddR = int.Parse(RoodZilverInput.Text);
             int LaatsteInkomstenAddR = int.Parse(RoodLaatsteInkomstenInput.Text);
             int EngelseKroonAddR = int.Parse(RoodEngelseKroonInput.Text);
             RoodTotaalPluspuntenConclusie.Text = (SchepenAddR + EmigratieAddR + OntdekkingAddR +
                                             SchurenHuizenPlusAddR + SchapenRunderenAddR + ZilverAddR
                                             + LaatsteInkomstenAddR + EngelseKroonAddR).ToString();

             int DorpsbordAddR = int.Parse(RoodDorpsbordInput.Text);
             int OntdekkingbordenAddR = int.Parse(RoodOntdekkingsbordenInput.Text);
             int SchurenHuizenMinAddR = int.Parse(RoodSchurenHuizenMinInput.Text);
             int ThingstrafAddR = int.Parse(RoodThingstrafInput.Text);
             RoodTotaalMinpuntenConclusie.Text = (DorpsbordAddR + OntdekkingbordenAddR + SchurenHuizenMinAddR +
                                              ThingstrafAddR).ToString();

             int TotaalPluspuntenAddR = int.Parse(RoodTotaalPluspuntenConclusie.Text);
             int TotaalMinpuntenAddR = int.Parse(RoodTotaalMinpuntenConclusie.Text);
             RoodEindscoreConclusie.Text = (TotaalPluspuntenAddR - TotaalMinpuntenAddR).ToString();
             //
             //Blauw
             //
             int SchepenAddB = int.Parse(BlauwSchepenInput.Text);
             int EmigratieAddB = int.Parse(BlauwEmigratieInput.Text);
             int OntdekkingsAddB = int.Parse(BlauwOntdekkingsInput.Text);
             int SchurenHuizenPlusAddB = int.Parse(BlauwSchurenHuizenPlusInput.Text);
             int SchapenRunderenAddB = int.Parse(BlauwAmbachtenInput.Text);
             int ZilverAddB = int.Parse(BlauwZilverInput.Text);
             int LaatsteInkomstenAddB = int.Parse(BlauwLaatsteInkomstenInput.Text);
             int EngelseKroonAddB = int.Parse(BlauwEngelseKroonInput.Text);
             BlauwTotaalPluspuntenConclusie.Text = (SchepenAddB + EmigratieAddB + OntdekkingsAddB +
                                             SchurenHuizenPlusAddB + SchapenRunderenAddB + ZilverAddB
                                             + LaatsteInkomstenAddB + EngelseKroonAddB).ToString();



             int TotaalPluspuntenAddB = int.Parse(BlauwTotaalPluspuntenConclusie.Text);
             int TotaalMinpuntenAddB = int.Parse(BlauwTotaalMinpuntenConclusie.Text);
             BlauwEindscoreConclusie.Text = (TotaalPluspuntenAddB - TotaalMinpuntenAddB).ToString();
             //
             //Geel
             //
             int SchepenAddG = int.Parse(GeelSchepenInput.Text);
             int EmigratieAddG = int.Parse(GeelEmigratieInput.Text);
             int OntdekkingsAddG = int.Parse(GeelOntdekkingsInput.Text);
             int SchurenHuizenPlusAddG = int.Parse(GeelSchurenHuizenPlusInput.Text);
             int SchapenRunderenAddG = int.Parse(GeelAmbachtenInput.Text);
             int ZilverAddG = int.Parse(GeelZilverInput.Text);
             int LaatsteInkomstenAddG = int.Parse(GeelLaatsteInkomstenInput.Text);
             int EngelseKroonAddG = int.Parse(GeelEngelseKroonInput.Text);
             GeelTotaalPluspuntenConclusie.Text = (SchepenAddG + EmigratieAddG + OntdekkingsAddG +
                                             SchurenHuizenPlusAddG + SchapenRunderenAddG + ZilverAddG
                                             + LaatsteInkomstenAddG + EngelseKroonAddG).ToString();

             int DorpsbordAddG = int.Parse(GeelDorpsbordInput.Text);
             int OntdekkingbordenAddG = int.Parse(GeelOntdekkingsbordenInput.Text);
             int SchurenHuizenMinAddG = int.Parse(GeelSchurenHuizenMinInput.Text);
             int ThingstrafAddG = int.Parse(GeelThingstrafInput.Text);
             GeelTotaalMinpuntenConclusie.Text = (DorpsbordAddG + OntdekkingbordenAddG + SchurenHuizenMinAddG +
                                              ThingstrafAddG).ToString();

             int TotaalPluspuntenAddG = int.Parse(GeelTotaalPluspuntenConclusie.Text);
             int TotaalMinpuntenAddG = int.Parse(GeelTotaalMinpuntenConclusie.Text);
             GeelEindscoreConclusie.Text = (TotaalPluspuntenAddG - TotaalMinpuntenAddG).ToString();
             }*/
        #endregion
        #region player1 input
        private void Player1_TextChanged(object sender, EventArgs e)
        {
            Player1.Name = Player1Text.Text;
        }
        private void Player1Colour_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player1.Colour = Player1Colour.SelectedItem.ToString();
        }
        
        
        
        #endregion
        #region player2 input
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
