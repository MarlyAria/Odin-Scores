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
    public partial class NewForm : Form
    {
        // int voor het bepalen van de groote van de groep
        Party Party = new Party();
        Player Player1 = new Player();
        Player Player2 = new Player();
        Player Player3 = new Player();
        Player Player4 = new Player();
        public NewForm()
        {
            InitializeComponent();
            Player1.Name = "Viking 1";
            Player2.Name = "Viking 2";
            Player3.Name = "Viking 3";
            Player4.Name = "Viking 4";
        }

        
    }
}
