using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odin_Scores
{
    public class Player
    {
        #region Variables
        //all info you need per player
        public string Name;
        public string Colour;
        public int Endscore = 0;
        public int Ships = 0;
        public int Emigration = 0;
        public int ExplorationP = 0;
        public int ShedsHousesP = 0;
        public int SheepCattle = 0;
        public int Occupations = 0;
        public int Silver = 0;
        public int FinalIncome = 0;
        public int Crown = 0;
        public int HomeBoard = 0;
        public int ExplorationN = 0;
        public int ShedsHousesN = 0;
        public int ThingPenalty = 0;
        public int PositiveScore = 0;
        public int NegativeScore = 0;
        #endregion

        public int AddPlus()
        {
            //het berekenen van de punten die de speler heeft gehaald op zijn dorps bord 
            //en ontdekkingsbord. 
            //let op, hier worden niet de minpunten bij opgeteld.
            
                return PositiveScore = Ships + Emigration + ExplorationP +
                     ShedsHousesP + SheepCattle + Occupations + Silver + FinalIncome + Crown;
          
        }

        public int AddMin()
        {
            //het berekenen van de min punten van het dorpsbord en ontdekkingsbord
            return NegativeScore = HomeBoard + ExplorationN + ShedsHousesN + ThingPenalty;
        }

        public int Totaal()
        {
            //het berekenen van het totaal aantal punten
            return Endscore = PositiveScore - NegativeScore;
        }

       
    }
}
