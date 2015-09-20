using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRollGame
{
    public partial class dice_roll : Form
    {
        public dice_roll()
        {
            InitializeComponent();
        }

        //Start of - Roll button - Clicked Event
        private void btn_roll_Click(object sender, EventArgs e)

        {
            #region declaration 
            //Declaration of variables
            int dice_one = 0;   //Dice One
            int dice_two = 0;   //Dice Two
            int sequence = 0;   //Roll Sequence Number
            Random rand = new Random();  //Random number
            #endregion

          
            System.Media.SystemSounds.Hand.Play();
            //Clears list view 

         
            lv_dice_roll.Items.Clear();

            //Roll Dice
            //Loops through one hundreed times
            for (int counter_two = 1; counter_two <= 100; counter_two++)
                {
                    //Creates new list view items
                    ListViewItem dice_item_one = new ListViewItem();
                    
                    // gets random number from 1-100
                    dice_one = rand.Next(1, 101);
                    dice_two = rand.Next(1, 101);

                    //adds random numbers to list view items
                    dice_item_one.Text = Convert.ToString(dice_one);
                    dice_item_one.SubItems.Add(Convert.ToString(dice_two));

                #region rollsequence

                //Checks wether the dices match
                if (dice_one == dice_two) {

                        sequence++;

                        //if matches match then adds the sequence number
                        if (sequence == 1 || sequence == 21 || sequence == 31 || sequence == 41 || sequence == 51 || sequence == 61 || sequence == 71 || sequence == 81 || sequence == 91)
                        {
                            dice_item_one.SubItems.Add(sequence + "st"); //adds sequence number to list view items

                        }

                        else if (sequence == 2 || sequence == 22 || sequence == 32 || sequence == 42 || sequence == 52 || sequence == 62 || sequence == 72 || sequence == 82 || sequence == 92)
                        {

                            dice_item_one.SubItems.Add(sequence + "nd"); //adds sequence number to list view items


                    }
                        else if (sequence == 3 || sequence == 23 || sequence == 33 || sequence == 43 || sequence == 53 || sequence == 63 || sequence == 73 || sequence == 83 || sequence == 93)
                        {

                            dice_item_one.SubItems.Add(sequence + "rd"); //adds sequence number to list view items


                    }

                        else {

                            dice_item_one.SubItems.Add(sequence + "th");


                        }

                     
                    }
# endregion
                lv_dice_roll.Items.Add(dice_item_one); //adds list view items to the dice_roll list view





            }
               


   




        }
        //-------END OF ROLL BUTTON-----\\

        //------BEGINING OF CANCEL BUTTON\\
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //------END OF CANCEL BUTTON\\
    }
}
