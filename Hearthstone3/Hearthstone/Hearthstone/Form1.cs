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
        Random randomCard = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        public void StartUp()
        {
            for (int i = 0; i < 30; i++)//loop to instanceiate the array of all spells
            {
                arrayAllCards[i] = new Card();
            }

            arrayAllCards[0].Name = "Minion 1";
            arrayAllCards[1].Name = "Minion 2";
            arrayAllCards[2].Name = "Minion 3";
            arrayAllCards[3].Name = "Minion 4";
            arrayAllCards[4].Name = "Minion 5";
            arrayAllCards[5].Name = "Minion 6";
            arrayAllCards[6].Name = "Minion 7";
            arrayAllCards[7].Name = "Minion 8";
            arrayAllCards[8].Name = "Minion 9";
            arrayAllCards[9].Name = "Minion 10";
            arrayAllCards[10].Name = "Minion 11";
            arrayAllCards[11].Name = "Minion 12";
            arrayAllCards[12].Name = "Minion 13";
            arrayAllCards[13].Name = "Minion 14";
            arrayAllCards[14].Name = "Minion 15";
            arrayAllCards[15].Name = "Minion 16";
            arrayAllCards[16].Name = "Minion 17";
            arrayAllCards[17].Name = "Minion 18";
            arrayAllCards[18].Name = "Minion 19";
            arrayAllCards[19].Name = "Minion 20";
            arrayAllCards[20].Name = "Minion 21";
            arrayAllCards[21].Name = "Minion 22";
            arrayAllCards[22].Name = "Minion 23";
            arrayAllCards[23].Name = "Minion 24";
            arrayAllCards[24].Name = "Minion 25";
            arrayAllCards[25].Name = "Minion 26";
            arrayAllCards[26].Name = "Minion 27";
            arrayAllCards[27].Name = "Minion 28";
            arrayAllCards[28].Name = "Minion 29";
            arrayAllCards[29].Name = "Minion 30";


            arrayAllCards[0].Attack = 1;
            arrayAllCards[1].Attack = 1;
            arrayAllCards[2].Attack = 1;
            arrayAllCards[3].Attack = 1;
            arrayAllCards[4].Attack = 1;
            arrayAllCards[5].Attack = 1;
            arrayAllCards[6].Attack = 1;
            arrayAllCards[7].Attack = 1;
            arrayAllCards[8].Attack = 1;
            arrayAllCards[9].Attack = 1;
            arrayAllCards[10].Attack = 1;
            arrayAllCards[11].Attack = 1;
            arrayAllCards[12].Attack = 1;
            arrayAllCards[13].Attack = 1;
            arrayAllCards[14].Attack = 1;
            arrayAllCards[15].Attack = 1;
            arrayAllCards[16].Attack = 1;
            arrayAllCards[17].Attack = 1;
            arrayAllCards[18].Attack = 1;
            arrayAllCards[19].Attack = 1;
            arrayAllCards[20].Attack = 1;
            arrayAllCards[21].Attack = 1;
            arrayAllCards[22].Attack = 1;
            arrayAllCards[23].Attack = 1;
            arrayAllCards[24].Attack = 1;
            arrayAllCards[25].Attack = 1;
            arrayAllCards[26].Attack = 1;
            arrayAllCards[27].Attack = 1;
            arrayAllCards[28].Attack = 1;
            arrayAllCards[29].Attack = 1;


            arrayAllCards[0].Health = 1;
            arrayAllCards[1].Health = 1;
            arrayAllCards[2].Health = 1;
            arrayAllCards[3].Health = 1;
            arrayAllCards[4].Health = 1;
            arrayAllCards[5].Health = 1;
            arrayAllCards[6].Health = 1;
            arrayAllCards[7].Health = 1;
            arrayAllCards[8].Health = 1;
            arrayAllCards[9].Health = 1;
            arrayAllCards[10].Health = 1;
            arrayAllCards[11].Health = 1;
            arrayAllCards[12].Health = 1;
            arrayAllCards[13].Health = 1;
            arrayAllCards[14].Health = 1;
            arrayAllCards[15].Health = 1;
            arrayAllCards[16].Health = 1;
            arrayAllCards[17].Health = 1;
            arrayAllCards[18].Health = 1;
            arrayAllCards[19].Health = 1;
            arrayAllCards[20].Health = 1;
            arrayAllCards[21].Health = 1;
            arrayAllCards[22].Health = 1;
            arrayAllCards[23].Health = 1;
            arrayAllCards[24].Health = 1;
            arrayAllCards[25].Health = 1;
            arrayAllCards[26].Health = 1;
            arrayAllCards[27].Health = 1;
            arrayAllCards[28].Health = 1;
            arrayAllCards[29].Health = 1;


            arrayAllCards[0].ManaCost = 1;
            arrayAllCards[1].ManaCost = 1;
            arrayAllCards[2].ManaCost = 1;
            arrayAllCards[3].ManaCost = 1;
            arrayAllCards[4].ManaCost = 1;
            arrayAllCards[5].ManaCost = 1;
            arrayAllCards[6].ManaCost = 1;
            arrayAllCards[7].ManaCost = 1;
            arrayAllCards[8].ManaCost = 1;
            arrayAllCards[9].ManaCost = 1;
            arrayAllCards[10].ManaCost = 1;
            arrayAllCards[11].ManaCost = 1;
            arrayAllCards[12].ManaCost = 1;
            arrayAllCards[13].ManaCost = 1;
            arrayAllCards[14].ManaCost = 1;
            arrayAllCards[15].ManaCost = 1;
            arrayAllCards[16].ManaCost = 1;
            arrayAllCards[17].ManaCost = 1;
            arrayAllCards[18].ManaCost = 1;
            arrayAllCards[19].ManaCost = 1;
            arrayAllCards[20].ManaCost = 1;
            arrayAllCards[21].ManaCost = 1;
            arrayAllCards[22].ManaCost = 1;
            arrayAllCards[23].ManaCost = 1;
            arrayAllCards[24].ManaCost = 1;
            arrayAllCards[25].ManaCost = 1;
            arrayAllCards[26].ManaCost = 1;
            arrayAllCards[27].ManaCost = 1;
            arrayAllCards[28].ManaCost = 1;
            arrayAllCards[29].ManaCost = 1;

        }
        public void DeckShuffle()
        {

            int intCounter = 0;//declare counter for the loop
            //declaring variables for the inside of the loop
            int int1stHalf = 0;
            int int2ndHalf = 0;
            int intAttackHolder = 0;
            int intManaCostHolder = 0;
            int intHealthHolder = 0;
            string strNameHolder = "";
            //
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
                //test message
                //MessageBox.Show(arrayCards[int1stHalf].Value + " " + arrayCards[int1stHalf].Suit + "\n" + arrayCards[int2ndHalf].Value + " " + arrayCards[int2ndHalf].Suit + "\n" + intValueHolder + " " + strSuitHolder);

                //STEP 3: REPLACING 1ST HALF WITH 2ND HALF
                arrayAllCards[int1stHalf].Attack = arrayAllCards[int2ndHalf].Attack;
                arrayAllCards[int1stHalf].ManaCost = arrayAllCards[int2ndHalf].ManaCost;
                arrayAllCards[int1stHalf].Health = arrayAllCards[int2ndHalf].Health;
                arrayAllCards[int1stHalf].Name = arrayAllCards[int2ndHalf].Name;

                //STEP 4: FILLING IN THE 2ND HALF WITH THE SAVED VALUES
                arrayAllCards[int2ndHalf].Attack = intAttackHolder;
                arrayAllCards[int2ndHalf].ManaCost = intManaCostHolder;
                arrayAllCards[int2ndHalf].Health = intHealthHolder;
                arrayAllCards[int2ndHalf].Name = strNameHolder;
                //test message after switch
                //MessageBox.Show(arrayCards[int1stHalf].Value + " " + arrayCards[int1stHalf].Suit + "\n" + arrayCards[int2ndHalf].Value + " " + arrayCards[int2ndHalf].Suit + "\n" + intValueHolder + " " + strSuitHolder);

                intCounter++;//add to counter
            }

            //TRANSFER ARRAY VALUES INTO A LIST FOR THEIR DECK

            int i = 0;
            while (i < 30)
            {
                lblShow.Text += arrayAllCards[i].Name + "\n";
                i++;
            }
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            StartUp();
            DeckShuffle();
            MessageBox.Show("asd");
        }
    }

    public class Card
    {
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Health { get; set; }
        public int ManaCost { get; set; }
        public bool Effect { get; set; } //fix this
    }
}

    

