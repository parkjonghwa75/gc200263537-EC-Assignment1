using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Assignment1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            int numberOfWins = 0, numberOfLosts = 0;
            int totalPointsScored, totalPointsAllowed, pointDifferential, totalSpectators;
            double averageSpectators;

            try
            {
                RadioButtonList rblGame1 = game1.FindControl("rblResult") as RadioButtonList;
                RadioButtonList rblGame2 = game2.FindControl("rblResult") as RadioButtonList;
                RadioButtonList rblGame3 = game3.FindControl("rblResult") as RadioButtonList;
                RadioButtonList rblGame4 = game4.FindControl("rblResult") as RadioButtonList;

                TextBox psbox1 = game1.FindControl("txtPointsScored") as TextBox;
                TextBox psbox2 = game2.FindControl("txtPointsScored") as TextBox;
                TextBox psbox3 = game3.FindControl("txtPointsScored") as TextBox;
                TextBox psbox4 = game4.FindControl("txtPointsScored") as TextBox;

                TextBox pabox1 = game1.FindControl("txtPointsAllowed") as TextBox;
                TextBox pabox2 = game2.FindControl("txtPointsAllowed") as TextBox;
                TextBox pabox3 = game3.FindControl("txtPointsAllowed") as TextBox;
                TextBox pabox4 = game4.FindControl("txtPointsAllowed") as TextBox;

                TextBox tbox1 = game1.FindControl("txtSpectators") as TextBox;
                TextBox tbox2 = game2.FindControl("txtSpectators") as TextBox;
                TextBox tbox3 = game3.FindControl("txtSpectators") as TextBox;
                TextBox tbox4 = game4.FindControl("txtSpectators") as TextBox;

                int game1PointScored = Int32.Parse(psbox1.Text);
                int game2PointScored = Int32.Parse(psbox2.Text);
                int game3PointScored = Int32.Parse(psbox3.Text);
                int game4PointScored = Int32.Parse(psbox4.Text);

                int game1PointAllowed = Int32.Parse(pabox1.Text);
                int game2PointAllowed = Int32.Parse(pabox2.Text);
                int game3PointAllowed = Int32.Parse(pabox3.Text);
                int game4PointAllowed = Int32.Parse(pabox4.Text);

                int game1Spectator = Int32.Parse(tbox1.Text);
                int game2Spectator = Int32.Parse(tbox2.Text);
                int game3Spectator = Int32.Parse(tbox3.Text);
                int game4Spectator = Int32.Parse(tbox4.Text);

                // Validation - RadioButtonList selection check
                if ((rblGame1.SelectedIndex != -1) && (rblGame2.SelectedIndex != -1) && (rblGame3.SelectedIndex != -1) && (rblGame4.SelectedIndex != -1))
                {
                    // Validation - All numbers should be positive value
                    if (((game1PointScored >= 0) && (game2PointScored >= 0) && (game3PointScored >= 0) && (game4PointScored >= 0)) &&
                        ((game1PointAllowed >= 0) && (game2PointAllowed >= 0) && (game3PointAllowed >= 0) && (game4PointAllowed >= 0)) &&
                        ((game1Spectator >= 0) && (game2Spectator >= 0) && (game3Spectator >= 0) && (game4Spectator >= 0)))
                    {
                        // Validation - no tie: scored points shouldn't be same as scored allowed
                        if ((game1PointScored != game1PointAllowed) && (game2PointScored != game2PointAllowed) && 
                            (game3PointScored != game3PointAllowed) && (game4PointScored != game4PointAllowed))
                        {
                            //Calculation of winnings

                            if (rblGame1.SelectedValue == "1")
                                numberOfWins += 1;
                            else
                                numberOfLosts += 1;

                            if (rblGame2.SelectedValue == "1")
                                numberOfWins += 1;
                            else
                                numberOfLosts += 1;

                            if (rblGame3.SelectedValue == "1")
                                numberOfWins += 1;
                            else
                                numberOfLosts += 1;

                            if (rblGame4.SelectedValue == "1")
                                numberOfWins += 1;
                            else
                                numberOfLosts += 1;

                            //Title display
                            lblSummaryTitle.Text = "Result";

                            //Calculation of # of games won
                            lblNumberOfWins.Text = "Number of games won: " + numberOfWins.ToString();

                            //Calculation of # of games lost
                            lblNumberOfLosts.Text = "Number of games lost: " + numberOfLosts.ToString();

                            //Calculation of winning %
                            lblWinningRate.Text = "Winning %: " + numberOfWins / 4.0;

                            //Calculation of total points scored
                            totalPointsScored = Int32.Parse(psbox1.Text) + Int32.Parse(psbox2.Text) + Int32.Parse(psbox3.Text) + Int32.Parse(psbox4.Text);
                            lblTotalPointsScored.Text = "Total points scored: " + totalPointsScored.ToString();

                            //Calculation of total points allowed
                            totalPointsAllowed = Int32.Parse(pabox1.Text) + Int32.Parse(pabox2.Text) + Int32.Parse(pabox3.Text) + Int32.Parse(pabox4.Text);
                            lblTotalPointsAllowed.Text = "Total points allowed: " + totalPointsAllowed.ToString();

                            //Calculation of point differential
                            pointDifferential = totalPointsScored - totalPointsAllowed;
                            lblPointsDifferential.Text = "Point differential: " + pointDifferential.ToString();

                            //Calculation of average # of spectators
                            averageSpectators = (Int32.Parse(tbox1.Text) + Int32.Parse(tbox2.Text) + Int32.Parse(tbox3.Text) + Int32.Parse(tbox4.Text)) / 4.0;
                            lblAverageSpectators.Text = "Average number of spectators:" + averageSpectators.ToString();

                            //Calculation of total # of spectators
                            totalSpectators = Int32.Parse(tbox1.Text) + Int32.Parse(tbox2.Text) + Int32.Parse(tbox3.Text) + Int32.Parse(tbox4.Text);
                            lblTotalSpectators.Text = "Total number of spectators:" + totalSpectators.ToString();
                        }
                        else
                        {
                            lblTotalPointsScored.Text = "There shouldn't be tie.";
                        }// end of validation check - no tie.

                    }
                    else
                    {
                        lblTotalPointsScored.Text = "All numbers should be positive.";
                    } // end of validation check - all numbers should be positive. 
                }
                else
                {
                    lblTotalPointsScored.Text = "Radio Button List <Result> check";
                }// end of validation check - radio button list 

            } // end of try
            catch (Exception ex)
            {
                lblTotalPointsScored.Text = "Numeric value error.";
            } // end of catch

        } // end of submit_Click
    } // end of class
} // end of namespace