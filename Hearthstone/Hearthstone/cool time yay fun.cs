﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//SUMMON CARD FROM HAND TO FEILD
//HERO ABILITY


namespace Hearthstone
{
    public partial class Form1 : Form
    {
        
        Card[] arrayAllCards = new Card[30];//an array holding all the spells
        Card[] arrayP1Deck = new Card[30];//an array holding the player 1 deck
        Card[] arrayP2Deck = new Card[30];//an array holding player 2 deck

        Card[] arrayP1Field = new Card[7];
        Card[] arrayP2Field = new Card[7];

        Random randomCard = new Random();

        List<Card> lstPlayer1 = new List<Card>();
        List<Card> lstPlayer2 = new List<Card>();

        List<Card> lstP1Hand = new List<Card>();
        List<Card> lstP2Hand = new List<Card>();

        int intHealth1 = 30;
        int intHealth2 = 30;
        int intMana1 = 0;
        int intMana2 = 0;

        bool blnEnough;

        int intSelectedCard = 0;

        int intEndOfList = 0;

        int intCountHand1 = 0;
        int intCountHand2 = 0;

        int intCountTurn = 0;

        int intCounter = 0;//declare counter for the loop
        //declaring variables for the inside of the loop
        int int1stHalf = 0;
        int int2ndHalf = 0;
        int intAttackHolder = 0;
        int intManaCostHolder = 0;
        int intHealthHolder = 0;
        string strNameHolder = "";
        Image imgHolder = null;

        public Form1()
        {
            InitializeComponent();
        }

        public void StartUp()
        {
            for (int i = 0; i < 30; i++)//loop to instanceiate the array of all spells
            {
                arrayAllCards[i] = new Card();
                arrayP1Deck[i] = new Card();
                arrayP2Deck[i] = new Card();              
            }

            for (int i = 0; i < 7; i++)//loop to instanceiate the array of all spells
            {
                arrayP1Field[i] = new Card();
                arrayP2Field[i] = new Card();
            }

            arrayAllCards[0].Name = "Bloodfen Raptor";
            arrayAllCards[1].Name = "Boulderfist Ogre";
            arrayAllCards[2].Name = "Murlock Raider";
            arrayAllCards[3].Name = "Nightblade";
            arrayAllCards[4].Name = "Novice Engineer";
            arrayAllCards[5].Name = "Oasis Snapjaw";
            arrayAllCards[6].Name = "River Crocolist";
            arrayAllCards[7].Name = "Sen'jin Shieldmasta";
            arrayAllCards[8].Name = "Wolfrider";
            arrayAllCards[9].Name = "Arcane Explosion";
            arrayAllCards[10].Name = "Arcane Intellect";
            arrayAllCards[11].Name = "Arcane Missiles";
            arrayAllCards[12].Name = "Arcane Shot";
            arrayAllCards[13].Name = "Fire Ball";
            arrayAllCards[14].Name = "Polymorph";
            arrayAllCards[15].Name = "Bloodfen Raptor";
            arrayAllCards[16].Name = "Boulderfist Ogre";
            arrayAllCards[17].Name = "Murlock Raider";
            arrayAllCards[18].Name = "Nightblade";
            arrayAllCards[19].Name = "Novice Engineer";
            arrayAllCards[20].Name = "Oasis Snapjaw";
            arrayAllCards[21].Name = "River Crocolist";
            arrayAllCards[22].Name = "Sen'jin Shieldmasta";
            arrayAllCards[23].Name = "Wolfrider";
            arrayAllCards[24].Name = "Arcane Explosion";
            arrayAllCards[25].Name = "Arcane Intellect";
            arrayAllCards[26].Name = "Arcane Missiles";
            arrayAllCards[27].Name = "Arcane Shot";
            arrayAllCards[28].Name = "Fire Ball";
            arrayAllCards[29].Name = "Polymorph";

            arrayAllCards[0].Attack = 3;
            arrayAllCards[1].Attack = 6;
            arrayAllCards[2].Attack = 2;
            arrayAllCards[3].Attack = 4;
            arrayAllCards[4].Attack = 1;
            arrayAllCards[5].Attack = 2;
            arrayAllCards[6].Attack = 2;
            arrayAllCards[7].Attack = 3;
            arrayAllCards[8].Attack = 3;
            arrayAllCards[9].Attack = 0;
            arrayAllCards[10].Attack = 0;
            arrayAllCards[11].Attack = 0;
            arrayAllCards[12].Attack = 0;
            arrayAllCards[13].Attack = 0;
            arrayAllCards[14].Attack = 0;
            arrayAllCards[15].Attack = 3;
            arrayAllCards[16].Attack = 6;
            arrayAllCards[17].Attack = 2;
            arrayAllCards[18].Attack = 4;
            arrayAllCards[19].Attack = 1;
            arrayAllCards[20].Attack = 2;
            arrayAllCards[21].Attack = 2;
            arrayAllCards[22].Attack = 3;
            arrayAllCards[23].Attack = 3;
            arrayAllCards[24].Attack = 0;
            arrayAllCards[25].Attack = 0;
            arrayAllCards[26].Attack = 0;
            arrayAllCards[27].Attack = 0;
            arrayAllCards[28].Attack = 0;
            arrayAllCards[29].Attack = 0;

            arrayAllCards[0].Health = 2;
            arrayAllCards[1].Health = 7;
            arrayAllCards[2].Health = 1;
            arrayAllCards[3].Health = 4;
            arrayAllCards[4].Health = 1;
            arrayAllCards[5].Health = 7;
            arrayAllCards[6].Health = 3;
            arrayAllCards[7].Health = 5;
            arrayAllCards[8].Health = 1;
            arrayAllCards[9].Health = 0;
            arrayAllCards[10].Health = 0;
            arrayAllCards[11].Health = 0;
            arrayAllCards[12].Health = 0;
            arrayAllCards[13].Health = 0;
            arrayAllCards[14].Health = 0;
            arrayAllCards[15].Health = 2;
            arrayAllCards[16].Health = 7;
            arrayAllCards[17].Health = 1;
            arrayAllCards[18].Health = 4;
            arrayAllCards[19].Health = 1;
            arrayAllCards[20].Health = 7;
            arrayAllCards[21].Health = 3;
            arrayAllCards[22].Health = 5;
            arrayAllCards[23].Health = 1;
            arrayAllCards[24].Health = 0;
            arrayAllCards[25].Health = 0;
            arrayAllCards[26].Health = 0;
            arrayAllCards[27].Health = 0;
            arrayAllCards[28].Health = 0;
            arrayAllCards[29].Health = 0;

            arrayAllCards[0].ManaCost = 2;
            arrayAllCards[1].ManaCost = 6;
            arrayAllCards[2].ManaCost = 1;
            arrayAllCards[3].ManaCost = 5;
            arrayAllCards[4].ManaCost = 2;
            arrayAllCards[5].ManaCost = 4;
            arrayAllCards[6].ManaCost = 2;
            arrayAllCards[7].ManaCost = 4;
            arrayAllCards[8].ManaCost = 3;
            arrayAllCards[9].ManaCost = 2;
            arrayAllCards[10].ManaCost = 3;
            arrayAllCards[11].ManaCost = 1;
            arrayAllCards[12].ManaCost = 1;
            arrayAllCards[13].ManaCost = 4;
            arrayAllCards[14].ManaCost = 4;
            arrayAllCards[15].ManaCost = 2;
            arrayAllCards[16].ManaCost = 6;
            arrayAllCards[17].ManaCost = 1;
            arrayAllCards[18].ManaCost = 5;
            arrayAllCards[19].ManaCost = 2;
            arrayAllCards[20].ManaCost = 4;
            arrayAllCards[21].ManaCost = 2;
            arrayAllCards[22].ManaCost = 4;
            arrayAllCards[23].ManaCost = 3;
            arrayAllCards[24].ManaCost = 2;
            arrayAllCards[25].ManaCost = 3;
            arrayAllCards[26].ManaCost = 1;
            arrayAllCards[27].ManaCost = 1;
            arrayAllCards[28].ManaCost = 4;
            arrayAllCards[29].ManaCost = 4;

            arrayAllCards[0].Picture = Properties.Resources.Bloodfen_Raptor;
            arrayAllCards[1].Picture = Properties.Resources.Boulderfist_Ogre;
            arrayAllCards[2].Picture = Properties.Resources.Murloc_Raider;
            arrayAllCards[3].Picture = Properties.Resources.Nightblade;
            arrayAllCards[4].Picture = Properties.Resources.Novice_Engineer;
            arrayAllCards[5].Picture = Properties.Resources.Oasis_Snapjaw;
            arrayAllCards[6].Picture = Properties.Resources.River_Crocolisk;
            arrayAllCards[7].Picture = Properties.Resources.Sen_jin_Shieldmasta;
            arrayAllCards[8].Picture = Properties.Resources.Wolfrider;
            arrayAllCards[9].Picture = Properties.Resources.Arcane_Explosion;
            arrayAllCards[10].Picture = Properties.Resources.Arcane_Intellect;
            arrayAllCards[11].Picture = Properties.Resources.Arcane_Missiles;
            arrayAllCards[12].Picture = Properties.Resources.Arcane_Shot;
            arrayAllCards[13].Picture = Properties.Resources.Fireball;
            arrayAllCards[14].Picture = Properties.Resources.Polymorph;
            arrayAllCards[15].Picture = Properties.Resources.Bloodfen_Raptor;
            arrayAllCards[16].Picture = Properties.Resources.Boulderfist_Ogre;
            arrayAllCards[17].Picture = Properties.Resources.Murloc_Raider;
            arrayAllCards[18].Picture = Properties.Resources.Nightblade;
            arrayAllCards[19].Picture = Properties.Resources.Novice_Engineer;
            arrayAllCards[20].Picture = Properties.Resources.Oasis_Snapjaw;
            arrayAllCards[21].Picture = Properties.Resources.River_Crocolisk;
            arrayAllCards[22].Picture = Properties.Resources.Sen_jin_Shieldmasta;
            arrayAllCards[23].Picture = Properties.Resources.Wolfrider;
            arrayAllCards[24].Picture = Properties.Resources.Arcane_Explosion;
            arrayAllCards[25].Picture = Properties.Resources.Arcane_Intellect;
            arrayAllCards[26].Picture = Properties.Resources.Arcane_Missiles;
            arrayAllCards[27].Picture = Properties.Resources.Arcane_Shot;
            arrayAllCards[28].Picture = Properties.Resources.Fireball;
            arrayAllCards[29].Picture = Properties.Resources.Polymorph;
            
        }
        public void DeckShuffle()
        {
            while (intCounter < 30)//shuffle loop
            {
                //STEP 1: METAPHORICALLY SPLITING THE DECK
                int1stHalf = randomCard.Next(0, 15);//random in first half
                int2ndHalf = randomCard.Next(15, 30);//random in second half

                //STEP 2: SETTING ASIDE/ SAVING 1ST HALF VALUE
                intAttackHolder = arrayAllCards[int1stHalf].Attack;
                intManaCostHolder = arrayAllCards[int1stHalf].ManaCost;
                intHealthHolder = arrayAllCards[int1stHalf].Health;
                strNameHolder = arrayAllCards[int1stHalf].Name;
                imgHolder = arrayAllCards[int1stHalf].Picture;
                //test message

                //STEP 3: REPLACING 1ST HALF WITH 2ND HALF
                arrayAllCards[int1stHalf].Attack = arrayAllCards[int2ndHalf].Attack;
                arrayAllCards[int1stHalf].ManaCost = arrayAllCards[int2ndHalf].ManaCost;
                arrayAllCards[int1stHalf].Health = arrayAllCards[int2ndHalf].Health;
                arrayAllCards[int1stHalf].Name = arrayAllCards[int2ndHalf].Name;
                arrayAllCards[int1stHalf].Picture = arrayAllCards[int2ndHalf].Picture;

                //STEP 4: FILLING IN THE 2ND HALF WITH THE SAVED VALUES
                arrayAllCards[int2ndHalf].Attack = intAttackHolder;
                arrayAllCards[int2ndHalf].ManaCost = intManaCostHolder;
                arrayAllCards[int2ndHalf].Health = intHealthHolder;
                arrayAllCards[int2ndHalf].Name = strNameHolder;
                arrayAllCards[int2ndHalf].Picture = imgHolder;

                //test message after switch

                intCounter++;//add to counter
            }
            intCounter = 0;

        }

        public void Player1List()
        {
            DeckShuffle();

            for (int i = 0; i < 30; i++)
            {
                arrayP1Deck[i].Name = arrayAllCards[i].Name;
                arrayP1Deck[i].Attack = arrayAllCards[i].Attack;
                arrayP1Deck[i].Health = arrayAllCards[i].Health;
                arrayP1Deck[i].ManaCost = arrayAllCards[i].ManaCost;
                arrayP1Deck[i].Picture = arrayAllCards[i].Picture;
            }

            lstPlayer1.AddRange(arrayP1Deck);

            for (int i = 0; i < 4; i++)
            {
                DrawCardP1();
            }

        }
        public void Player2List()
        {
            DeckShuffle();

            for (int i = 0; i < 30; i++)
            {
                arrayP2Deck[i].Name = arrayAllCards[i].Name;
                arrayP2Deck[i].Attack = arrayAllCards[i].Attack;
                arrayP2Deck[i].Health = arrayAllCards[i].Health;
                arrayP2Deck[i].ManaCost = arrayAllCards[i].ManaCost;
                arrayP2Deck[i].Picture = arrayAllCards[i].Picture;
            }

            lstPlayer2.AddRange(arrayP2Deck);

            for (int i = 0; i < 4; i++)
            {
                DrawCardP2();
            }
        }

        public void DrawCardP1()
        {
            intEndOfList = lstPlayer1.Count - 1;

            lstP1Hand.Add(lstPlayer1[intEndOfList]);

            lstPlayer1.RemoveAt(intEndOfList);
            
            lstVisualHand.Items.Add(lstP1Hand[intCountHand1].Name + "       " + lstPlayer1[intCountHand1].ManaCost);

            intCountHand1++;
        }

        public void DrawCardP2()
        {
            intEndOfList = lstPlayer2.Count - 1;

            lstP2Hand.Add(lstPlayer2[intEndOfList]);

            lstPlayer2.RemoveAt(intEndOfList);

            intCountHand2++;

        }

        public void Mana()
        {
            intCountTurn++;

            if (intCountTurn <= 10)
            {
                intMana1 = intCountTurn;
                intMana2 = intCountTurn;
            }
            else
            {
                intMana1 = 10;
                intMana2 = 10;
            }

            lblMana1.Text = Convert.ToString(intMana1);
            lblMana2.Text = Convert.ToString(intMana2);
        }

        public void Effects()
        {
            for (int E = 0; E < lstVisualHand.Items.Count; E++)
            {
                if (lstP1Hand[lstVisualHand.SelectedIndex].Name == "Wolfrider")
                {
                    lstP1Hand[E].Charge();
                }
                
            }

        }

        public void Health()
        {
            lblHealth1.Text = Convert.ToString(intHealth1);
            lblHealth2.Text = Convert.ToString(intHealth2);
        }

        public void HandToField()
        {
            try
            {
                if (lstP1Hand[lstVisualHand.SelectedIndex].ManaCost <= intMana1)
                {
                    intMana1 = intMana1 - lstP1Hand[lstVisualHand.SelectedIndex].ManaCost;
                    lblMana1.Text = Convert.ToString(intMana1);

                    arrayP1Field[intSelectedCard].Name = lstP1Hand[lstVisualHand.SelectedIndex].Name;
                    arrayP1Field[intSelectedCard].Attack = lstP1Hand[lstVisualHand.SelectedIndex].Attack;
                    arrayP1Field[intSelectedCard].Health = lstP1Hand[lstVisualHand.SelectedIndex].Health;
                    arrayP1Field[intSelectedCard].ManaCost = lstP1Hand[lstVisualHand.SelectedIndex].ManaCost;
                    intCountHand1--;
                    blnEnough = true;
                }
                else
                {
                    blnEnough = false;
                }
            }
            catch
            {
                MessageBox.Show("Your hand is empty");
            }
          
        }

        public void EnoughCards()
        {
            if (lstVisualHand.SelectedIndex <= -1)
            {
                pictureBox8.Enabled = false;
            }
            else 
            {
                pictureBox8.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartUp();
            Player1List();
            Player2List();
            Mana();
            Health();
            lstVisualHand.SelectedIndex = 0;
        }

        public void UserHeroAbility()
        {
            if (intMana1 >= 2)
            {
                intMana1 -= 2;
                intHealth2 -= 2;

            }
        }

        public void BotHeroAbility()
        {
            if (intMana2 >= 2)
            {
                intMana2 -= 2;
                intHealth1 -= 2;

            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Mana();
            DrawCardP1();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
            intSelectedCard = 0;
            HandToField();
            try
            {
                if (blnEnough == true)
                {
                    pictureBox8.Image = lstP1Hand[lstVisualHand.SelectedIndex].Picture;
                    lstP1Hand.RemoveAt(lstVisualHand.SelectedIndex);
                    lstVisualHand.Items.Remove(lstVisualHand.SelectedItem);
                }
                lstVisualHand.SelectedIndex = 0;
            }
            catch
            {
             
            }
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            intSelectedCard = 1;
            HandToField();
            try
            {
                if (blnEnough == true)
                {
                    pictureBox9.Image = lstP1Hand[lstVisualHand.SelectedIndex].Picture;
                    lstP1Hand.RemoveAt(lstVisualHand.SelectedIndex);
                    lstVisualHand.Items.Remove(lstVisualHand.SelectedItem);
                    lstVisualHand.SelectedIndex = 0;
                }
            }
            catch
            {

            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            intSelectedCard = 2;
            HandToField();
            try
            {
                if (blnEnough == true)
                {
                    pictureBox10.Image = lstP1Hand[lstVisualHand.SelectedIndex].Picture;
                    lstP1Hand.RemoveAt(lstVisualHand.SelectedIndex);
                    lstVisualHand.Items.Remove(lstVisualHand.SelectedItem);
                    lstVisualHand.SelectedIndex = 0;
                }
            }
            catch
            {

            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            intSelectedCard = 3;
            HandToField();
            try
            {
                if (blnEnough == true)
                {
                    pictureBox11.Image = lstP1Hand[lstVisualHand.SelectedIndex].Picture;
                    lstP1Hand.RemoveAt(lstVisualHand.SelectedIndex);
                    lstVisualHand.Items.Remove(lstVisualHand.SelectedItem);
                    lstVisualHand.SelectedIndex = 0;
                }
            }
            catch
            {

            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            intSelectedCard = 4;
            HandToField();
            try
            {
                if (blnEnough == true)
                {
                    pictureBox12.Image = lstP1Hand[lstVisualHand.SelectedIndex].Picture;
                    lstP1Hand.RemoveAt(lstVisualHand.SelectedIndex);
                    lstVisualHand.Items.Remove(lstVisualHand.SelectedItem);
                    lstVisualHand.SelectedIndex = 0;
                }
            }
            catch
            {

            }
        }
        
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            intSelectedCard = 5;
            HandToField();
            try
            {
                if (blnEnough == true)
                {
                    pictureBox13.Image = lstP1Hand[lstVisualHand.SelectedIndex].Picture;
                    lstP1Hand.RemoveAt(lstVisualHand.SelectedIndex);
                    lstVisualHand.Items.Remove(lstVisualHand.SelectedItem);
                    lstVisualHand.SelectedIndex = 0;
                }
            }
            catch
            {

            }
        }
        
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            intSelectedCard = 6;
            HandToField();
            try
            {
                if (blnEnough == true)
                {
                    pictureBox14.Image = lstP1Hand[lstVisualHand.SelectedIndex].Picture;
                    lstP1Hand.RemoveAt(lstVisualHand.SelectedIndex);
                    lstVisualHand.Items.Remove(lstVisualHand.SelectedItem);
                    lstVisualHand.SelectedIndex = 0;
                }
            }
            catch
            {

            }
        }
    }

    public class Card
    {
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Health { get; set; }
        public int ManaCost { get; set; }
        //public int Effect { get; set; } //fix this
        public Image Picture { get; set; }

        public void Charge()
        {
            MessageBox.Show("testy testhole");
        }
    }
}



