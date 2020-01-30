using System.Windows.Forms;

namespace Odin_Scores
{
    partial class OdinScores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        #endregion

        private void InitializeComponent()
        {
            this.PlayerNumberLabel = new System.Windows.Forms.Label();
            this.PlayerNumberBox = new System.Windows.Forms.ComboBox();
            this.Player1Text = new System.Windows.Forms.TextBox();
            this.Player1Colour = new System.Windows.Forms.ComboBox();
            this.Player2Text = new System.Windows.Forms.TextBox();
            this.Player2Colour = new System.Windows.Forms.ComboBox();
            this.Player3Text = new System.Windows.Forms.TextBox();
            this.Player3Colour = new System.Windows.Forms.ComboBox();
            this.Player4Text = new System.Windows.Forms.TextBox();
            this.Player4Colour = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // PlayerNumberLabel
            // 
            this.PlayerNumberLabel.AutoSize = true;
            this.PlayerNumberLabel.Location = new System.Drawing.Point(43, 50);
            this.PlayerNumberLabel.Name = "PlayerNumberLabel";
            this.PlayerNumberLabel.Size = new System.Drawing.Size(327, 20);
            this.PlayerNumberLabel.TabIndex = 1;
            this.PlayerNumberLabel.Text = "How many Player will be preparing feasts?";
            // 
            // PlayerNumberBox
            // 
            this.PlayerNumberBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerNumberBox.FormattingEnabled = true;
            this.PlayerNumberBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.PlayerNumberBox.Location = new System.Drawing.Point(419, 50);
            this.PlayerNumberBox.Name = "PlayerNumberBox";
            this.PlayerNumberBox.Size = new System.Drawing.Size(98, 28);
            this.PlayerNumberBox.TabIndex = 2;
            // 
            // Player1Text
            // 
            this.Player1Text.Location = new System.Drawing.Point(34, 108);
            this.Player1Text.Name = "Player1Text";
            this.Player1Text.Size = new System.Drawing.Size(283, 26);
            this.Player1Text.TabIndex = 3;
            this.Player1Text.Text = "Player 1";
            this.Player1Text.TextChanged += new System.EventHandler(this.Player1_TextChanged);
            // 
            // Player1Colour
            // 
            this.Player1Colour.FormattingEnabled = true;
            this.Player1Colour.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Red",
            "Yellow"});
            this.Player1Colour.Location = new System.Drawing.Point(400, 106);
            this.Player1Colour.Name = "Player1Colour";
            this.Player1Colour.Size = new System.Drawing.Size(117, 28);
            this.Player1Colour.TabIndex = 4;
            this.Player1Colour.SelectedIndexChanged += new System.EventHandler(this.Player1Colour_SelectedIndexChanged);
            // 
            // Player2Text
            // 
            this.Player2Text.Location = new System.Drawing.Point(34, 159);
            this.Player2Text.Name = "Player2Text";
            this.Player2Text.Size = new System.Drawing.Size(283, 26);
            this.Player2Text.TabIndex = 5;
            this.Player2Text.Text = "Player 2";
            this.Player2Text.TextChanged += new System.EventHandler(this.Player2Text_TextChanged);
            // 
            // Player2Colour
            // 
            this.Player2Colour.FormattingEnabled = true;
            this.Player2Colour.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Red",
            "Yellow"});
            this.Player2Colour.Location = new System.Drawing.Point(400, 159);
            this.Player2Colour.Name = "Player2Colour";
            this.Player2Colour.Size = new System.Drawing.Size(117, 28);
            this.Player2Colour.TabIndex = 6;
            this.Player2Colour.SelectedIndexChanged += new System.EventHandler(this.Player2Colour_SelectedIndexChanged);
            // 
            // Player3Text
            // 
            this.Player3Text.Location = new System.Drawing.Point(34, 211);
            this.Player3Text.Name = "Player3Text";
            this.Player3Text.Size = new System.Drawing.Size(283, 26);
            this.Player3Text.TabIndex = 7;
            this.Player3Text.Text = "Player 3";
            this.Player3Text.TextChanged += new System.EventHandler(this.Player3Text_TextChanged);
            // 
            // Player3Colour
            // 
            this.Player3Colour.FormattingEnabled = true;
            this.Player3Colour.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Red",
            "Yellow"});
            this.Player3Colour.Location = new System.Drawing.Point(400, 211);
            this.Player3Colour.Name = "Player3Colour";
            this.Player3Colour.Size = new System.Drawing.Size(117, 28);
            this.Player3Colour.TabIndex = 8;
            this.Player3Colour.SelectedIndexChanged += new System.EventHandler(this.Player3Colour_SelectedIndexChanged);
            // 
            // Player4Text
            // 
            this.Player4Text.Location = new System.Drawing.Point(34, 257);
            this.Player4Text.Name = "Player4Text";
            this.Player4Text.Size = new System.Drawing.Size(283, 26);
            this.Player4Text.TabIndex = 9;
            this.Player4Text.Tag = "";
            this.Player4Text.Text = "Player 4 ";
            this.Player4Text.TextChanged += new System.EventHandler(this.Player4Text_TextChanged);
            // 
            // Player4Colour
            // 
            this.Player4Colour.FormattingEnabled = true;
            this.Player4Colour.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Red",
            "Yellow"});
            this.Player4Colour.Location = new System.Drawing.Point(400, 257);
            this.Player4Colour.Name = "Player4Colour";
            this.Player4Colour.Size = new System.Drawing.Size(117, 28);
            this.Player4Colour.TabIndex = 14;
            this.Player4Colour.SelectedIndexChanged += new System.EventHandler(this.Player4Colour_SelectedIndexChanged);
            // 
            // OdinScores
            // 
            this.ClientSize = new System.Drawing.Size(612, 542);
            this.Controls.Add(this.Player4Colour);
            this.Controls.Add(this.Player4Text);
            this.Controls.Add(this.Player3Colour);
            this.Controls.Add(this.Player3Text);
            this.Controls.Add(this.Player2Colour);
            this.Controls.Add(this.Player2Text);
            this.Controls.Add(this.Player1Colour);
            this.Controls.Add(this.Player1Text);
            this.Controls.Add(this.PlayerNumberBox);
            this.Controls.Add(this.PlayerNumberLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "OdinScores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #region Private List
        private Label PlayerNumberLabel;
        private TextBox Player2Text;
        private TextBox Player3Text;
        private TextBox Player4Text;
        private TextBox Player1Text;
        private ComboBox PlayerNumberBox;
        private ComboBox Player1Colour;
        private ComboBox Player2Colour;
        private ComboBox Player3Colour;
        private ComboBox Player4Colour;
        #endregion
    }


}
