using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClasses
{
    public partial class Default : System.Web.UI.Page
    {

        Character player1, player2;
        Random rnd;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                CreateHeros();
            }

            if (ViewState["Player1ViewState"] != null)
            {
                player1 = (Character)ViewState["Player1ViewState"];
                player2 = (Character)ViewState["Player2ViewState"];
            }

            RefreshDisplay();
            rnd = new Random((int)DateTime.Now.Ticks);
            
        }

        private void Player1Attack()
        {
            int attack = PlayerAttack(player1);
            int defend = Defend();
            if (defend > attack)
                return;
            
            player2.Health -= (attack - defend);
            
        }

        private void Player2Attack()
        {
            int attack = PlayerAttack(player2);
            int defend = Defend();
            if (defend > attack)
                return;

            player1.Health -= (attack - defend);
            
        }

        private int PlayerAttack(Character x)
        {
            return rnd.Next(0, x.DamageMaximum);
        }

        private int Defend()
        {
            return rnd.Next(0, 10);
        }

        private void RefreshDisplay()
        {
            player1Label.Text = player1.Name;
            player1HealthLabel.Text = player1.Health.ToString();

            player2Label.Text = player2.Name;
            player2HealthLabel.Text = player2.Health.ToString();
        }

        private void SaveData()
        {
            ViewState["Player1ViewState"] = player1;
            ViewState["Player2ViewState"] = player2;
        }

        private void CreateHeros()
        {
            player1 = new Character();
            player1.Name = "Monster";
            player1.Health = 100;
            player1.DamageMaximum = 10;

            player2 = new Character();
            player2.Name = "Hero";
            player2.Health = 100;
            player2.DamageMaximum = 11;

            SaveData();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            while(player1.Health > 0 && player2.Health > 0)
            {
                OutputToDisplay();
                
                Player1Attack();
                if (CheckHealth(player2))
                    break;
                
                Player2Attack();
                if (CheckHealth(player1))
                    break;
               
                RefreshDisplay();
                SaveData();
                
            }

            RefreshDisplay();
            SaveData();
            
        }

        private Boolean CheckHealth( Character x)
        {
            if (x.Health <= 0)
            {
                x.Health = 0;
                OutputWinner(x);
                return true;
            }
            
            return false;
        }


        private void OutputWinner(Character name)
        {
            
            if (name.Equals(player1))
                name = player2;
            else
                name = player1;
            
            debugLabel.Text += "</br> "+ name.Name +" is the winner";

        }

        private void OutputToDisplay()
        {
            
            debugLabel.Text += "</br> " + player1.Name + " H:" + player1.Health.ToString() + " // " + player2.Name + " :" + player2.Health.ToString() ;
            
        }
    }
}