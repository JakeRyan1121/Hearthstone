﻿//Josh, Wyatt, Iyan, and Jake  
//6-4-2019
//Hearthstone 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hearthstone
{
    public partial class Form1 : Form
    {
        Card[] arrayAllCards = new Card[30];//an array holding all the spells
        Card[] arrayP1Deck = new Card[30];//an array holding the player 1 shuffled deck
        Card[] arrayP2Deck = new Card[30];//an array holding player 2 shuffled deck

        Card[] arrayP1Field = new Card[7];//the array for the player 1 field
        Card[] arrayP2Field = new Card[7];//the array for the player 2 field

        Random randomCard = new Random();//random number generator for the deck shuffle

        List<Card> lstPlayer1 = new List<Card>();//the list for the player 1 shuffled deck
        List<Card> lstPlayer2 = new List<Card>();//the list for the player 2 shuffled deck

        List<Card> lstP1Hand = new List<Card>();//the list for the player 1 hand
        List<Card> lstP2Hand = new List<Card>();//the list for the player 2 hand

        int intHealth1 = 30;//the health for the player 1
        int intHealth2 = 30;//the health for the player 2
        int intMana1 = 0;//the mana for player 1
        int intMana2 = 0;//the mana for player 2

        bool blnEnough1;//does player 1 have cards in their hand
        bool blnEnough2;//does player 2 have cards in their hand
        bool blnU1Turn = true;//is it player 1's turn 
        bool blnDidAttack1 = false;//did player 1 attack directly 
        bool blnDidAttack2 = false;//did player 2 attack directly 

        int intSelectedCard = 0;//the selected card on the player 1 field
        int intSelectedBot = 0;//the selected card on the player 2 field

        int intAttack1 = -1;//the selected attacker on player 1 field
        int intAttack2 = -1;//the selected attacker on player 2 field

        int intEndOfList = 0;//

        int intCountHand1 = 0;//the amount of cards in player 1 hand
        int intCountHand2 = 0;//the amount of cards in player 2 hand

        int intCountTurnU1 = 0;//counts player 1 turns
        int intCountTurnU2 = 0;//counts player 1 turns

        //below is the holders for the deck shuffle
        int intCounter = 0;//declare counter for the shuffle loop
        int int1stHalf = 0;//holds the 1st half the deck
        int int2ndHalf = 0;//holds the 2nd half the deck
        int intAttackHolder = 0;//holds the attack value
        int intManaCostHolder = 0;//holds the mana cost 
        int intHealthHolder = 0;//holds the health value
        string strNameHolder = "";//holds the name of the cards
        Image imgHolder = null;//holds the picture of the cards

        public Form1()
        {
            InitializeComponent();
        }

        public void StartUp()
        {
            for (int i = 0; i < 30; i++)//loop to instanceiate the array of all cards
            {
                arrayAllCards[i] = new Card();
                arrayP1Deck[i] = new Card();
                arrayP2Deck[i] = new Card();              
            }

            for (int i = 0; i < 7; i++)//loop to instanceiate the field holders
            {
                arrayP1Field[i] = new Card();
                arrayP2Field[i] = new Card();
            }

            //sets all of the cards stats (name, attack, health, mana, and picture)
            arrayAllCards[0].Name = "Bloodfen Raptor";
            arrayAllCards[1].Name = "Boulderfist Ogre";
            arrayAllCards[2].Name = "Murlock Raider";
            arrayAllCards[3].Name = "Nightblade";
            arrayAllCards[4].Name = "Novice Engineer";
            arrayAllCards[5].Name = "Oasis Snapjaw";
            arrayAllCards[6].Name = "River Crocolist";
            arrayAllCards[7].Name = "Sen'jin Shieldmasta";
            arrayAllCards[8].Name = "Wolfrider";
            arrayAllCards[9].Name = "Electra Stormsurge";
            arrayAllCards[10].Name = "Gearmaster Mechazod";
            arrayAllCards[11].Name = "Aberrant Berserker";
            arrayAllCards[12].Name = "Abominable Bowman";
            arrayAllCards[13].Name = "Abomination";
            arrayAllCards[14].Name = "Pyromaniac";
            arrayAllCards[15].Name = "Bloodfen Raptor";
            arrayAllCards[16].Name = "Boulderfist Ogre";
            arrayAllCards[17].Name = "Murlock Raider";
            arrayAllCards[18].Name = "Nightblade";
            arrayAllCards[19].Name = "Novice Engineer";
            arrayAllCards[20].Name = "Oasis Snapjaw";
            arrayAllCards[21].Name = "River Crocolist";
            arrayAllCards[22].Name = "Sen'jin Shieldmasta";
            arrayAllCards[23].Name = "Wolfrider";
            arrayAllCards[24].Name = "Electra Stormsurge";
            arrayAllCards[25].Name = "Gearmaster Mechazod";
            arrayAllCards[26].Name = "Aberrant Berserker";
            arrayAllCards[27].Name = "Abominable Bowman";
            arrayAllCards[28].Name = "Abomination";
            arrayAllCards[29].Name = "Pyromaniac";

            arrayAllCards[0].Attack = 3;
            arrayAllCards[1].Attack = 6;
            arrayAllCards[2].Attack = 2;
            arrayAllCards[3].Attack = 4;
            arrayAllCards[4].Attack = 1;
            arrayAllCards[5].Attack = 2;
            arrayAllCards[6].Attack = 2;
            arrayAllCards[7].Attack = 3;
            arrayAllCards[8].Attack = 3;
            arrayAllCards[9].Attack = 3;
            arrayAllCards[10].Attack = 2;
            arrayAllCards[11].Attack = 3;
            arrayAllCards[12].Attack = 6;
            arrayAllCards[13].Attack = 4;
            arrayAllCards[14].Attack = 3;
            arrayAllCards[15].Attack = 3;
            arrayAllCards[16].Attack = 6;
            arrayAllCards[17].Attack = 2;
            arrayAllCards[18].Attack = 4;
            arrayAllCards[19].Attack = 1;
            arrayAllCards[20].Attack = 2;
            arrayAllCards[21].Attack = 2;
            arrayAllCards[22].Attack = 3;
            arrayAllCards[23].Attack = 3;
            arrayAllCards[24].Attack = 3;
            arrayAllCards[25].Attack = 2;
            arrayAllCards[26].Attack = 3;
            arrayAllCards[27].Attack = 6;
            arrayAllCards[28].Attack = 4;
            arrayAllCards[29].Attack = 3;

            arrayAllCards[0].Health = 2;
            arrayAllCards[1].Health = 7;
            arrayAllCards[2].Health = 1;
            arrayAllCards[3].Health = 4;
            arrayAllCards[4].Health = 1;
            arrayAllCards[5].Health = 7;
            arrayAllCards[6].Health = 3;
            arrayAllCards[7].Health = 5;
            arrayAllCards[8].Health = 1;
            arrayAllCards[9].Health = 3;
            arrayAllCards[10].Health = 95;
            arrayAllCards[11].Health = 5;
            arrayAllCards[12].Health = 7;
            arrayAllCards[13].Health = 4;
            arrayAllCards[14].Health = 4;
            arrayAllCards[15].Health = 2;
            arrayAllCards[16].Health = 7;
            arrayAllCards[17].Health = 1;
            arrayAllCards[18].Health = 4;
            arrayAllCards[19].Health = 1;
            arrayAllCards[20].Health = 7;
            arrayAllCards[21].Health = 3;
            arrayAllCards[22].Health = 5;
            arrayAllCards[23].Health = 1;
            arrayAllCards[24].Health = 3;
            arrayAllCards[25].Health = 95;
            arrayAllCards[26].Health = 5;
            arrayAllCards[27].Health = 7;
            arrayAllCards[28].Health = 4;
            arrayAllCards[29].Health = 4;

            arrayAllCards[0].ManaCost = 2;
            arrayAllCards[1].ManaCost = 6;
            arrayAllCards[2].ManaCost = 1;
            arrayAllCards[3].ManaCost = 5;
            arrayAllCards[4].ManaCost = 2;
            arrayAllCards[5].ManaCost = 4;
            arrayAllCards[6].ManaCost = 2;
            arrayAllCards[7].ManaCost = 4;
            arrayAllCards[8].ManaCost = 3;
            arrayAllCards[9].ManaCost = 3;
            arrayAllCards[10].ManaCost = 10;
            arrayAllCards[11].ManaCost = 4;
            arrayAllCards[12].ManaCost = 7;
            arrayAllCards[13].ManaCost = 5;
            arrayAllCards[14].ManaCost = 3;
            arrayAllCards[15].ManaCost = 2;
            arrayAllCards[16].ManaCost = 6;
            arrayAllCards[17].ManaCost = 1;
            arrayAllCards[18].ManaCost = 5;
            arrayAllCards[19].ManaCost = 2;
            arrayAllCards[20].ManaCost = 4;
            arrayAllCards[21].ManaCost = 2;
            arrayAllCards[22].ManaCost = 4;
            arrayAllCards[23].ManaCost = 3;
            arrayAllCards[24].ManaCost = 3;
            arrayAllCards[25].ManaCost = 10;
            arrayAllCards[26].ManaCost = 4;
            arrayAllCards[27].ManaCost = 7;
            arrayAllCards[28].ManaCost = 5;
            arrayAllCards[29].ManaCost = 3;

            arrayAllCards[0].Picture = Properties.Resources.Bloodfen_Raptor;
            arrayAllCards[1].Picture = Properties.Resources.Boulderfist_Ogre;
            arrayAllCards[2].Picture = Properties.Resources.Murloc_Raider;
            arrayAllCards[3].Picture = Properties.Resources.Nightblade;
            arrayAllCards[4].Picture = Properties.Resources.Novice_Engineer;
            arrayAllCards[5].Picture = Properties.Resources.Oasis_Snapjaw;
            arrayAllCards[6].Picture = Properties.Resources.River_Crocolisk;
            arrayAllCards[7].Picture = Properties.Resources.Sen_jin_Shieldmasta;
            arrayAllCards[8].Picture = Properties.Resources.Wolfrider;
            arrayAllCards[9].Picture = Properties.Resources.Electra_Stormsurge;
            arrayAllCards[10].Picture = Properties.Resources.Gearmaster_Mechazod;
            arrayAllCards[11].Picture = Properties.Resources.Aberrant_berserker;
            arrayAllCards[12].Picture = Properties.Resources.Abominable_bowman;
            arrayAllCards[13].Picture = Properties.Resources.Abomination;
            arrayAllCards[14].Picture = Properties.Resources.Pyromaniac;
            arrayAllCards[15].Picture = Properties.Resources.Bloodfen_Raptor;
            arrayAllCards[16].Picture = Properties.Resources.Boulderfist_Ogre;
            arrayAllCards[17].Picture = Properties.Resources.Murloc_Raider;
            arrayAllCards[18].Picture = Properties.Resources.Nightblade;
            arrayAllCards[19].Picture = Properties.Resources.Novice_Engineer;
            arrayAllCards[20].Picture = Properties.Resources.Oasis_Snapjaw;
            arrayAllCards[21].Picture = Properties.Resources.River_Crocolisk;
            arrayAllCards[22].Picture = Properties.Resources.Sen_jin_Shieldmasta;
            arrayAllCards[23].Picture = Properties.Resources.Wolfrider;
            arrayAllCards[24].Picture = Properties.Resources.Electra_Stormsurge;
            arrayAllCards[25].Picture = Properties.Resources.Gearmaster_Mechazod;
            arrayAllCards[26].Picture = Properties.Resources.Aberrant_berserker;
            arrayAllCards[27].Picture = Properties.Resources.Abominable_bowman;
            arrayAllCards[28].Picture = Properties.Resources.Abomination;
            arrayAllCards[29].Picture = Properties.Resources.Pyromaniac;
            
        }
        public void DeckShuffle()//shuffles the deck
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

                intCounter++;//add to counter
            }
            intCounter = 0;

        }

        public void Player1List()//shuffles the deck and copies it to the player1 array and list deck
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

            //draws 4 cards to start the game
            for (int i = 0; i < 4; i++)
            {
                DrawCardP1();
            }

        }
        public void Player2List()//shuffles the deck and copies it to the player1 array and list deck
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

            //draws 4 cards to start the game
            for (int i = 0; i < 4; i++)
            {
                DrawCardP2();
            }
        }

        public void DrawCardP1()//draws 1 card from the last card(top) of the player 1 deck
        {
            try
            {
                intEndOfList = lstPlayer1.Count - 1;

                lstP1Hand.Add(lstPlayer1[intEndOfList]);

                lstPlayer1.RemoveAt(intEndOfList);

                lstVisualHand.Items.Add(lstP1Hand[intCountHand1].Name + "      " + lstP1Hand[intCountHand1].ManaCost);

                intCountHand1++;
            }
            catch
            {
                MessageBox.Show("Player1's deck is empty");
            }
        }

        public void DrawCardP2()//draws 1 card from the last card(top) of the player 2 deck
        {
            try
            {
                intEndOfList = lstPlayer2.Count - 1;

                lstP2Hand.Add(lstPlayer2[intEndOfList]);

                lstPlayer2.RemoveAt(intEndOfList);

                lstVisualHand2.Items.Add(lstP2Hand[intCountHand2].Name + "      " + lstP2Hand[intCountHand2].ManaCost);

                intCountHand2++;
            }
            catch
            {
                MessageBox.Show("Player2's deck is empty");
            }

        }

        public void Mana()//gives the users 1 more mana then the user had the previous turn, capped at 10 mana a turn
        {
            if (blnU1Turn == true)
            {
                intCountTurnU1++;
            }
            else
            {
                intCountTurnU2++;
            }

            if (intCountTurnU1 <= 10 && intCountTurnU2 <= 10)
            {
                intMana1 = intCountTurnU1;
                intMana2 = intCountTurnU2;
            }
            else
            {
                intMana1 = 10;
                intMana2 = 10;
            }

            lblMana1.Text = Convert.ToString(intMana1);
            lblMana2.Text = Convert.ToString(intMana2);
        }
        
        public void Health()//updates the health values
        {
            lblHealth1.Text = Convert.ToString(intHealth1);
            lblHealth2.Text = Convert.ToString(intHealth2);
        }

        public void HandToField1()//shows the player 1's card on the field when they play a card
        {
            try
            {
                if (lstP1Hand[lstVisualHand.SelectedIndex].ManaCost <= intMana1)
                {
                    intMana1 = intMana1 - lstP1Hand[lstVisualHand.SelectedIndex].ManaCost;
                    lblMana1.Text = Convert.ToString(intMana1);

                    //puts the cards values in the field array
                    arrayP1Field[intSelectedCard].Name = lstP1Hand[lstVisualHand.SelectedIndex].Name;
                    arrayP1Field[intSelectedCard].Attack = lstP1Hand[lstVisualHand.SelectedIndex].Attack;
                    arrayP1Field[intSelectedCard].Health = lstP1Hand[lstVisualHand.SelectedIndex].Health;
                    arrayP1Field[intSelectedCard].ManaCost = lstP1Hand[lstVisualHand.SelectedIndex].ManaCost;
                    intCountHand1--;
                    blnEnough1 = true;
                }
                else
                {
                    blnEnough1 = false;
                }
            }
            catch
            {
                MessageBox.Show("Your hand is empty");
            }
          
        }

        public void HandToField2() //shows the player 1's card on the field when they play a card
        {
            try
            {
                if (lstP2Hand[lstVisualHand2.SelectedIndex].ManaCost <= intMana2)
                {
                    intMana2 = intMana2 - lstP2Hand[lstVisualHand2.SelectedIndex].ManaCost;
                    lblMana2.Text = Convert.ToString(intMana2);

                    //puts the cards values in the field array
                    arrayP2Field[intSelectedBot].Name = lstP2Hand[lstVisualHand2.SelectedIndex].Name;
                    arrayP2Field[intSelectedBot].Attack = lstP2Hand[lstVisualHand2.SelectedIndex].Attack;
                    arrayP2Field[intSelectedBot].Health = lstP2Hand[lstVisualHand2.SelectedIndex].Health;
                    arrayP2Field[intSelectedBot].ManaCost = lstP2Hand[lstVisualHand2.SelectedIndex].ManaCost;
                    intCountHand2--;
                    blnEnough2 = true;
                }
                else
                {
                    blnEnough2 = false;
                }
            }
            catch
            {
                MessageBox.Show("Your hand is empty");
            }
        }

        public void TurnKeeper()//enables the buttons when it is the player's turn
        {
            if (blnU1Turn == true)
            {
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;

                btnAttack1.Enabled = false;
                btnAttack2.Enabled = false;
                btnAttack3.Enabled = false;
                btnAttack4.Enabled = false;
                btnAttack5.Enabled = false;
                btnAttack6.Enabled = false;
                btnAttack7.Enabled = false;
                lstVisualHand2.Enabled = false;



                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
                pictureBox10.Enabled = true;
                pictureBox11.Enabled = true;
                pictureBox12.Enabled = true;
                pictureBox13.Enabled = true;
                pictureBox14.Enabled = true;

                btnAttack8.Enabled = true;
                btnAttack9.Enabled = true;
                btnAttack10.Enabled = true;
                btnAttack11.Enabled = true;
                btnAttack12.Enabled = true;
                btnAttack13.Enabled = true;
                btnAttack14.Enabled = true;
                lstVisualHand.Enabled = true;
            }
            else
            {
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox5.Enabled = true;
                pictureBox6.Enabled = true;
                pictureBox7.Enabled = true;

                btnAttack1.Enabled = true;
                btnAttack2.Enabled = true;
                btnAttack3.Enabled = true;
                btnAttack4.Enabled = true;
                btnAttack5.Enabled = true;
                btnAttack6.Enabled = true;
                btnAttack7.Enabled = true;
                lstVisualHand2.Enabled = true;

                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
                pictureBox10.Enabled = false;
                pictureBox11.Enabled = false;
                pictureBox12.Enabled = false;
                pictureBox13.Enabled = false;
                pictureBox14.Enabled = false;

                btnAttack8.Enabled = false;
                btnAttack9.Enabled = false;
                btnAttack10.Enabled = false;
                btnAttack11.Enabled = false;
                btnAttack12.Enabled = false;
                btnAttack13.Enabled = false;
                btnAttack14.Enabled = false;
                lstVisualHand.Enabled = false;
            }
        }

        private void WinCondition()//shows when a player wins
        {
            if (intHealth1 <= 0)
            {
                MessageBox.Show("Player 2 has won!");
            }
            if (intHealth2 <= 0)
            {
                MessageBox.Show("Player 1 has won!");
            }
        }

        public void Damage()//calculates the damage
        {
            if (intAttack1 >= 0 && intAttack2 >= 0)
            {
                arrayP1Field[intAttack1].Health -= arrayP2Field[intAttack2].Attack;
                arrayP2Field[intAttack2].Health -= arrayP1Field[intAttack1].Attack;
                MessageBox.Show(arrayP2Field[intAttack2].Health.ToString() + "\n" + arrayP1Field[intAttack1].Health.ToString());
                intAttack1 = -1;
                intAttack2 = -1;
                RemoveFromField();
            }
        }

        public void RemoveFromField()//removes the card from the field when it is dead
        {
            for (int i = 0; i <7; i++)
            {
                if (arrayP1Field[i].Health <=0)
                {
                    arrayP1Field[i].Health = 0;
                    arrayP1Field[i].Attack = 0;
                    arrayP1Field[i].ManaCost = 0;
                    arrayP1Field[i].Name = "";
                    arrayP1Field[i].Picture = null;
                }
            }
            for (int j = 0; j < 7; j++)
            {
                if (arrayP2Field[j].Health <= 0)
                {
                    arrayP2Field[j].Health = 0;
                    arrayP2Field[j].Attack = 0;
                    arrayP2Field[j].ManaCost = 0;
                    arrayP2Field[j].Name = "";
                    arrayP2Field[j].Picture = null;
                }
            }
            if (arrayP1Field[0].Health <= 0)
            {
                pictureBox8.Image = null;
                
            }
            if (arrayP1Field[1].Health <= 0)
            {
                pictureBox9.Image = null;
            }
            if (arrayP1Field[2].Health <= 0)
            {
                pictureBox10.Image = null;
            }
            if (arrayP1Field[3].Health <= 0)
            {
                pictureBox11.Image = null;
            }
            if (arrayP1Field[4].Health <= 0)
            {
                pictureBox12.Image = null;
            }
            if (arrayP1Field[5].Health <= 0)
            {
                pictureBox13.Image = null;
            }
            if (arrayP1Field[6].Health <= 0)
            {
                pictureBox14.Image = null;
            }
            
            if (arrayP2Field[0].Health <= 0)
            {
                pictureBox1.Image = null;
            }
            if (arrayP2Field[1].Health <= 0)
            {
                pictureBox2.Image = null;
            }
            if (arrayP2Field[2].Health <= 0)
            {
                pictureBox3.Image = null;
            }
            if (arrayP2Field[3].Health <= 0)
            {
                pictureBox4.Image = null;
            }
            if (arrayP2Field[4].Health <= 0)
            {
                pictureBox5.Image = null;
            }
            if (arrayP2Field[5].Health <= 0)
            {
                pictureBox6.Image = null;
            }
            if (arrayP2Field[6].Health <= 0)
            {
                pictureBox7.Image = null;
            }
        }

        public void Enable()//enables buttons 
        {
            btnAttack1.Enabled = true;
            btnAttack2.Enabled = true;
            btnAttack3.Enabled = true;
            btnAttack4.Enabled = true;
            btnAttack5.Enabled = true;
            btnAttack6.Enabled = true;
            btnAttack7.Enabled = true;

            btnAttack8.Enabled = true;
            btnAttack9.Enabled = true;
            btnAttack10.Enabled = true;
            btnAttack11.Enabled = true;
            btnAttack12.Enabled = true;
            btnAttack13.Enabled = true;
            btnAttack14.Enabled = true;

            btnTarget1.Enabled = true;
            btnTarget2.Enabled = true;
        }
        
        private void Form1_Load(object sender, EventArgs e)//what happens during startup
        {
            StartUp();
            Player1List();
            Player2List();
            Mana();
            Health();
            lstVisualHand.SelectedIndex = 0;
            lstVisualHand2.SelectedIndex = 0;
            TurnKeeper();
        }

        public void UserHeroAbility()//uses the player 1's hero ability
        {
            if (intMana1 >= 2)
            {
                intMana1 -= 2;
                intHealth2 -= 2;
                lblHealth2.Text = intHealth2.ToString();
                lblMana1.Text = intMana1.ToString();
            }
        }

        public void BotHeroAbility()//uses the player 2's hero ability
        {
            if (intMana2 >= 2)
            {
                intMana2 -= 2;
                intHealth1 -= 2;
                lblHealth1.Text = intHealth1.ToString();
                lblMana2.Text = intMana2.ToString();

            }
        }

        private void btnEnd_Click(object sender, EventArgs e)//the users end the turn the blnU1Turn toggles, mana is set, and a card is drawn
        {
            blnU1Turn = !blnU1Turn;
            TurnKeeper();
            Mana();

            if (blnU1Turn == true)
            {
                DrawCardP1();
            }
            else
            {
                DrawCardP2();
            }
            
            intSelectedBot = -1;
            intSelectedCard = -1;
            intAttack1 = -1;
            intAttack2 = -1;
            blnDidAttack1 = false;
            blnDidAttack2 = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)//a player 2 field slot
        {
            intSelectedBot = 0;
            HandToField2();
            try
            {
                if (blnEnough2 == true)
                {
                    pictureBox1.Image = lstP2Hand[lstVisualHand2.SelectedIndex].Picture;
                    lstP2Hand.RemoveAt(lstVisualHand2.SelectedIndex);
                    lstVisualHand2.Items.Remove(lstVisualHand2.SelectedItem);
                }
                lstVisualHand2.SelectedIndex = 0;
            }
            catch
            {

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)//a player 2 field slot
        {
            intSelectedBot = 1;
            HandToField2();
            try
            {
                if (blnEnough2 == true)
                {
                    pictureBox2.Image = lstP2Hand[lstVisualHand2.SelectedIndex].Picture;
                    lstP2Hand.RemoveAt(lstVisualHand2.SelectedIndex);
                    lstVisualHand2.Items.Remove(lstVisualHand2.SelectedItem);
                }
                lstVisualHand2.SelectedIndex = 0;
            }
            catch
            {

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)//a player 2 field slot
        {
            intSelectedBot = 2;
            HandToField2();
            try
            {
                if (blnEnough2 == true)
                {
                    pictureBox3.Image = lstP2Hand[lstVisualHand2.SelectedIndex].Picture;
                    lstP2Hand.RemoveAt(lstVisualHand2.SelectedIndex);
                    lstVisualHand2.Items.Remove(lstVisualHand2.SelectedItem);
                }
                lstVisualHand2.SelectedIndex = 0;
            }
            catch
            {

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)//a player 2 field slot
        {
            intSelectedBot = 3;
            HandToField2();
            try
            {
                if (blnEnough2 == true)
                {
                    pictureBox4.Image = lstP2Hand[lstVisualHand2.SelectedIndex].Picture;
                    lstP2Hand.RemoveAt(lstVisualHand2.SelectedIndex);
                    lstVisualHand2.Items.Remove(lstVisualHand2.SelectedItem);
                }
                lstVisualHand2.SelectedIndex = 0;
            }
            catch
            {

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)//a player 2 field slot
        {
            intSelectedBot = 4;
            HandToField2();
            try
            {
                if (blnEnough2 == true)
                {
                    pictureBox5.Image = lstP2Hand[lstVisualHand2.SelectedIndex].Picture;
                    lstP2Hand.RemoveAt(lstVisualHand2.SelectedIndex);
                    lstVisualHand2.Items.Remove(lstVisualHand2.SelectedItem);
                }
                lstVisualHand2.SelectedIndex = 0;
            }
            catch
            {

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)//a player 2 field slot
        {
            intSelectedBot = 5;
            HandToField2();
            try
            {
                if (blnEnough2 == true)
                {
                    pictureBox6.Image = lstP2Hand[lstVisualHand2.SelectedIndex].Picture;
                    lstP2Hand.RemoveAt(lstVisualHand2.SelectedIndex);
                    lstVisualHand2.Items.Remove(lstVisualHand2.SelectedItem);
                }
                lstVisualHand2.SelectedIndex = 0;
            }
            catch
            {

            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)//a player 2 field slot
        {
            intSelectedBot = 6;
            HandToField2();
            try
            {
                if (blnEnough2 == true)
                {
                    pictureBox7.Image = lstP2Hand[lstVisualHand2.SelectedIndex].Picture;
                    lstP2Hand.RemoveAt(lstVisualHand2.SelectedIndex);
                    lstVisualHand2.Items.Remove(lstVisualHand2.SelectedItem);
                }
                lstVisualHand2.SelectedIndex = 0;
            }
            catch
            {

            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)//a player 1 field slot
        {
            intSelectedCard = 0;
            HandToField1();
            try
            {
                if (blnEnough1 == true)
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

        private void pictureBox9_Click(object sender, EventArgs e)//a player 1 field slot
        {
            intSelectedCard = 1;
            HandToField1();
            try
            {
                if (blnEnough1 == true)
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

        private void pictureBox10_Click(object sender, EventArgs e)//a player 1 field slot
        {
            intSelectedCard = 2;
            HandToField1();
            try
            {
                if (blnEnough1 == true)
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

        private void pictureBox11_Click(object sender, EventArgs e)//a player 1 field slot
        {
            intSelectedCard = 3;
            HandToField1();
            try
            {
                if (blnEnough1 == true)
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

        private void pictureBox12_Click(object sender, EventArgs e)//a player 1 field slot
        {
            intSelectedCard = 4;
            HandToField1();
            try
            {
                if (blnEnough1 == true)
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
        
        private void pictureBox13_Click(object sender, EventArgs e)//a player 1 field slot
        {
            intSelectedCard = 5;
            HandToField1();
            try
            {
                if (blnEnough1 == true)
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
        
        private void pictureBox14_Click(object sender, EventArgs e)//a player 1 field slot
        {
            intSelectedCard = 6;
            HandToField1();
            try
            {
                if (blnEnough1 == true)
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

        
        
        private void btnAttack1_Click(object sender, EventArgs e)//a attack button for the player 2 field
        {
            Enable();
            intAttack2 = 0;
            Damage();
        }

        private void btnAttack2_Click(object sender, EventArgs e)//a attack button for the player 2 field
        {
            Enable();
            intAttack2 = 1;
            Damage();
        }

        private void btnAttack3_Click(object sender, EventArgs e)//a attack button for the player 2 field
        {
            Enable();
            intAttack2 = 2;
            Damage();
        }

        private void btnAttack4_Click(object sender, EventArgs e)//a attack button for the player 2 field
        {
            Enable();
            intAttack2 = 3;
            Damage();
        }

        private void btnAttack5_Click(object sender, EventArgs e)//a attack button for the player 2 field
        {
            Enable();
            intAttack2 = 4;
            Damage();
        }

        private void btnAttack6_Click(object sender, EventArgs e)//a attack button for the player 2 field
        {
            Enable();
            intAttack2 = 5;
            Damage();
        }

        private void btnAttack7_Click(object sender, EventArgs e)//a attack button for the player 2 field
        {
            Enable();
            intAttack2 = 6;
            Damage();
        }

        private void btnAttack8_Click(object sender, EventArgs e)//a attack button for the player 1 field
        {
            Enable();
            intAttack1 = 0;
            Damage();
        }

        private void btnAttack9_Click(object sender, EventArgs e)//a attack button for the player 1 field
        {
            Enable();
            intAttack1 = 1;
            Damage();
        }

        private void btnAttack10_Click(object sender, EventArgs e)//a attack button for the player 1 field
        {
            Enable();
            intAttack1 = 2;
            Damage();
        }

        private void btnAttack11_Click(object sender, EventArgs e)//a attack button for the player 1 field
        {
            Enable();
            intAttack1 = 3;
            Damage();
        }

        private void btnAttack12_Click(object sender, EventArgs e)//a attack button for the player 1 field
        {
            Enable();
            intAttack1 = 4;
            Damage();
        }

        private void btnAttack13_Click(object sender, EventArgs e)//a attack button for the player 1 field
        {
            Enable();
            intAttack1 = 5;
            Damage();
        }

        private void btnAttack14_Click(object sender, EventArgs e)//a attack button for the player 1 field
        {
            Enable();
            intAttack1 = 6;
            Damage();
        }

        private void pictureBox15_Click(object sender, EventArgs e)//the player 1 hero
        {
            if (blnU1Turn == true)
            {
                UserHeroAbility();
                WinCondition();
            }
        }
        private void pictureBox16_Click(object sender, EventArgs e)//the player 2 hero
        {
            if (blnU1Turn == false)
            {
                BotHeroAbility();
                WinCondition();
            }
        }

        private void btnTarget1_Click(object sender, EventArgs e)//attacks the player 1 directly
        {
            try
            {
                if (blnDidAttack2 == false)
                {
                    intHealth1 -= arrayP2Field[intAttack2].Attack;
                    Health();
                    blnDidAttack2 = true;
                }
                else
                {
                    MessageBox.Show("You have already attacked directly this turn");
                }

                intAttack1 = -1;
                intAttack2 = -1;
                btnTarget1.Enabled = false;
                btnTarget2.Enabled = false;
            }
            catch
            {

            }
            WinCondition();
        }

        private void btnTarget2_Click(object sender, EventArgs e)//attacks the player 2 directly
        {
            try
            {
                if (blnDidAttack1 == false)
                {
                    intHealth2 -= arrayP1Field[intAttack1].Attack;
                    Health();
                    blnDidAttack1 = true;
                }
                else
                {
                    MessageBox.Show("You have already attacked directly this turn");
                }

                intAttack1 = -1;
                intAttack2 = -1;
                btnTarget1.Enabled = false;
                btnTarget2.Enabled = false;
            }
            catch
            {

            }
            WinCondition();
        }

        private void lblMana1_Click(object sender, EventArgs e)
        {

        }

        private void lblHealth1_Click(object sender, EventArgs e)
        {

        }
        
        private void lblMana2_Click(object sender, EventArgs e)
        {

        }

        private void lblHealth2_Click(object sender, EventArgs e)
        {

        }

        
    }

    public class Card//oBjEcT
    {
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Health { get; set; }
        public int ManaCost { get; set; }
        public Image Picture { get; set; }        
    }
}