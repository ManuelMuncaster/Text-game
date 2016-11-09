//Created by: Manuel Muncaster
//Date: November 8, 2016
//Purpose: Text-based adventure game showcasing switch-case statments and nested if statments
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_game
{

    public partial class Form1 : Form
    {
        int scene = 0;

        public Form1()
        {
            InitializeComponent();
            eventOutputlabel.Text = "Welcome to Castle Heist! This is a game in which you try and break into a castle to steal as much loot as possible! Good luck!" + Environment.NewLine + Environment.NewLine + "After a three day long walk, you have finally made it to Black Reach Castle. Rumour suggests that the castle's king has gone mad and the castle has been long abandoned. Large sums of gold are said to be hidden within the castle's walls. After closer inspection, you find four ways that you can potentially enter the castle. Which way do you choose?";
            blueOutputLabel.Text = "Climb up onto the roof.";
            redOutputlabel.Text = "Try and enter through the front gate.";
            yellowOutputlabel.Text = "Enter through a sewer drain.";
            greenOutputlabel.Text = "Sneak through the back gate.";
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B)
            {
                if (scene == 0)
                {
                    scene = 1;
                }

            }
            else if (e.KeyCode == Keys.M)
            {

            }
            else if (e.KeyCode == Keys.H)
            {

            }
            else if (e.KeyCode == Keys.J)
            {

            }
            switch (scene)
            {
                case 0:
                    break;
                case 1:
                    eventOutputlabel.Text = "You inspect the wall for a considerable amount of time before finding a way to climb onto the roof safely. Eventually you get to the edge of the roof and pull yourself up. You scan the area and see a medium sized window that you could fit into. Do you try and climb through the window or continue along the roof?";
                    blueOutputLabel.Text = "Climb into the window.";
                    redOutputlabel.Text = "Continue walking on the roof.";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    break;
                case 2:
                    eventOutputlabel.Text = "You decide that the window would not be a good entrance to the castle and continue walking across the roof. Unfortunatly, a archer spots you and puts an arrow into your forehead before you realize he was even there. GAME OVER.";
                    blueOutputLabel.Text = "Play again?";
                    redOutputlabel.Text = "Quit!";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    break;
                case 3:
                    eventOutputlabel.Text = "You climb into the window and find yourself in a forge with a large amount of weapons in pristine condition around you. After gearing up, you see that there are large doors to your left and a long hallway to your right. Which way to do go?";
                    blueOutputLabel.Text = "Go down the hallway.";
                    redOutputlabel.Text = "Go near the large doors.";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    break;
                case 4:
                    eventOutputlabel.Text = "You draw yourself closer to the doors, but something seems quite strange about them. This castle was supposed to be abandoned, but the doors seemed like they were made recently. The door is covered in strange markings and seems to be glowing slightly. Chills run up your spine as you continue to study the door; you feel slighty dizzy and have a slight urge to run. Do you open the doors or continue into a room to the left of the door?";
                    blueOutputLabel.Text = "Open the strange doors.";
                    redOutputlabel.Text = "Move away from the strange doors and into the room.";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    break;
                case 5:
                    eventOutputlabel.Text = "You continue down the hallway away from the large doors. As soon as you turn a corner however, you find a massive barracks full of soldiers! Before you can even figure out how there are so many soldiers in the 'abandoned' castle, a soldier yells at you and a another soldier thrusts his spear in your chest. GAME OVER.";
                    blueOutputLabel.Text = "Play again?";
                    redOutputlabel.Text = "Quit!";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    break;
                case 6:
                    eventOutputlabel.Text = "You trust your instincts and move away from the door quickly into a another room. As soon as you enter the room however, you hear a strange clanking noise, like gears turning. A large being walks out of a door at the far side of the room; some kind of mechanical knight? You panic and try to run out of the room, but the door is locked. You pull out the freshly forged sword you picked up earlier and begin to fight the terrifying figure. You parry a few of it's attacks, but it overwhelms you with its strength and cuts your sword in half. It then screeches a horrible, ear shattering noise and plunges it's blade into your skull and out your lower back. GAME OVER. ";
                    blueOutputLabel.Text = "Play again?";
                    redOutputlabel.Text = "Quit!";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    break;
                case 7:
                    eventOutputlabel.Text = "You fight your instincts and push with all of your strengh to open the doors. You look up and see a breath-taking sight. A large, expansive throne room that has a large glass wall near the back of the room. Behind the wall is a massive pile of gold and gems; as you move closer you notice that the mountain of gold takes of 3/4 of the room. After looking in awe for some time, you look down to see a figure sitting in the throne wearing strange armour that looks very menacing. 'You have somehow broken into my domain, you infidel! Prepare to die!!' The Dread King gets up from his throne and unsheathes his blade; which glows with a strong red light. He jumps 6 feet in the air and lands infront of you. Do you worship the Dread King or fight him?";
                    blueOutputLabel.Text = "Bow to the Dread King";
                    redOutputlabel.Text = "Unsheath your blade and prepare for the fight or your life";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    break;
                case 8:
                    eventOutputlabel.Text = "You decide to bow down on one knee and claim your loyalties to the king. He swiftly chops your head off and with such immense force that your head and body fly out of the window and fall into the castle's moat. GAME OVER.";
                    blueOutputLabel.Text = "Play again?";
                    redOutputlabel.Text = "Quit!";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    break;
                case 9:
                    eventOutputlabel.Text = "You pull out your newly acquired blade and take a defensive stance. The Dread King takes the first swing and you parry back and forth. He nearly chops off your head a few times, but you are reinvigorated by a sudden strength and focus. He slips through your stance and slices your chest, but you don't feel anything. You press on fighting and find yourself gaining the upperhand. You counter a large overhead swing and swing with all of your might; chooping the head of the Dread King off from his body. You decide to try and grab as much loot as you can, but three Steamwinders (the king's elite guard) storm into the throne room and overwhelm you. Your head is soon spit upon a steak. GAME OVER";
                    blueOutputLabel.Text = "Play again?";
                    redOutputlabel.Text = "Quit!";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    break;
                case 10:
                    eventOutputlabel.Text = "You pull out your newly acquired blade and take a defensive stance. The Dread King takes the first swing and you parry back and forth. He nearly chops off your head a few times, but you are reinvigorated by a sudden strength and focus. He slips through your stance and slices your chest, but you don't feel anything. You press on fighting and find yourself gaining the upperhand. You counter a large overhead swing and swing with all of your might; chooping the head of the Dread King off from his body. You decide to take the Dread King's head with you in a bag. You smash through a window and climb down from it using vines that had been growing on the wall for years. You manage to get onto the ground and run far, far away from the castle. You return the head for a massive sum of money. SUPER WIN VICTORY!!!";
                    blueOutputLabel.Text = "Play again?";
                    redOutputlabel.Text = "Quit!";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    break;
                case 11:
                    eventOutputlabel.Text = "You decide to enter through the front gate. You walk up to the gate and try to enter through a side door. The door is locked. Do you try and pick the lock or kick the door down with your mighty legs?";
                    blueOutputLabel.Text = "Pick the lock";
                    redOutputlabel.Text = "Kick the door down";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    break;
                case 12:
                    eventOutputlabel.Text = "You take out your lock picking tools and get to work on the lock. After some time, you get really close to opening the lock when a guard walks out from another door and takes his war hammer out. You are crushed to a pulp. GAME OVER";
                    blueOutputLabel.Text = "Play again?";
                    redOutputlabel.Text = "Quit!";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                    break;
                case 22:
                    break;
                case 23:
                    break;
                case 24:
                    break;
                case 25:
                    break;
                case 26:
                    break;
                case 27:
                    break;
                case 28:
                    break;
                case 29:
                    break;
                case 30:
                    break;
                case 31:
                    break;
                case 32:
                    break;
                case 33:
                    break;

            }
        }
    }
}
