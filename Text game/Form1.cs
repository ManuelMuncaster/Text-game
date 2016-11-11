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
using System.Media;
using System.Threading;
namespace Text_game
{

    public partial class Form1 : Form
    {
        int scene = 0; //Setting up scene variable
        Random randGen = new Random(); //Setting up random encounters

        public Form1()
        {
            InitializeComponent();
            //Initial message at beginning of the program
            eventOutputlabel.Text = "Welcome to Castle Heist! This is a game in which you try and break into a castle to steal as much loot as possible! Good luck!" + Environment.NewLine + Environment.NewLine + "After a three day long walk, you have finally made it to Black Reach Castle. Rumour suggests that the castle's king has gone mad and the castle has been long abandoned. Some think that the legendary Dread King roams within the castle's walls, but those stories are just myths. Large sums of gold are said to be hidden within the castle's walls. After closer inspection, you find four ways that you can potentially enter the castle. Which way do you choose?";
            blueOutputLabel.Text = "Climb up onto the roof.";
            redOutputlabel.Text = "Try and enter through the front gate.";
            yellowOutputlabel.Text = "Enter through a sewer drain.";
            greenOutputlabel.Text = "Sneak through the back gate.";
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B) //Blue button; this is all of the actions and scene changes the blue button will carry out.
            {
                // Roof -- This is all of the actions the blue button will do in this area.
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 2; 
                    SoundPlayer player = new SoundPlayer(Properties.Resources.Arrow);
                    player.Play();
                }
                else if (scene == 2)
                {
                    scene = 0;
                }
                else if (scene == 3)
                {
                    scene = 4;
                }
                else if (scene == 4)
                {
                    scene = 6;
                    SoundPlayer player1 = new SoundPlayer(Properties.Resources.Sword3);
                    SoundPlayer player2 = new SoundPlayer(Properties.Resources.Sword2);
                    SoundPlayer player3 = new SoundPlayer(Properties.Resources.Death3);
                    player1.Play();
                    Thread.Sleep(600);
                    player2.Play();
                    Thread.Sleep(500);
                    player3.Play();
                }
                else if (scene == 6)
                {
                    scene = 0;
                }
                else if (scene == 7)
                {
                    scene = 8;
                    SoundPlayer player1 = new SoundPlayer(Properties.Resources.Loser);
                    SoundPlayer player2 = new SoundPlayer(Properties.Resources.Death2);
                    player1.Play();
                    Thread.Sleep(3500);
                    player2.Play();
                    Thread.Sleep(1500);
                }
                else if (scene == 8)
                {
                    scene = 0;
                }
                else if (scene == 5)
                {
                    scene = 0;
                }
                else if (scene == 9)
                {
                    scene = 0;
                }
                else if (scene == 10)
                {
                    scene = 0;
                }

                // Front gate
                else if (scene == 11)
                {
                    scene = 12;
                    SoundPlayer player1 = new SoundPlayer(Properties.Resources.Arrow);
                    player1.Play();
                }
                else if (scene == 12)
                {
                    scene = 0;
                }
                else if (scene == 13)
                {
                    scene = 0;
                }

                // Sewer
                else if (scene == 14)
                {
                    scene = 15;
                }
                else if (scene == 15)
                {
                    scene = 16;
                    SoundPlayer player1 = new SoundPlayer(Properties.Resources.Sword3);
                    SoundPlayer player2 = new SoundPlayer(Properties.Resources.Sword2);
                    SoundPlayer player3 = new SoundPlayer(Properties.Resources.Death3);
                    player1.Play();
                    Thread.Sleep(600);
                    player2.Play();
                    Thread.Sleep(600);
                    player3.Play();
                }
                else if (scene == 16)
                {
                    scene = 0;
                }
                else if (scene == 19)
                {
                    scene = 20;
                    SoundPlayer player1 = new SoundPlayer(Properties.Resources.Death3);
                    player1.Play();
                    Thread.Sleep(500);
                }
                else if (scene == 20)
                {
                    scene = 0;
                }
                else if (scene == 22)
                {
                    scene = 0;
                }
                else if (scene == 21)
                {
                    scene = 0;
                }
                else if (scene == 18)
                {
                    scene = 0;
                }
                else if (scene == 17)
                {
                    scene = 0;
                }

                // Back Gate
                else if (scene == 23)
                {
                    scene = 24;
                }
                else if (scene == 24)
                {
                    scene = 25;
                }
                else if (scene == 25)
                {
                    scene = 27;
                    SoundPlayer player1 = new SoundPlayer(Properties.Resources.Death1);
                    player1.Play();
                    Thread.Sleep(1000);
                }
                else if (scene == 27)
                {
                    scene = 0;
                }
                else if (scene == 29)
                {
                    scene = 34;
                }
                else if (scene == 34)
                {
                    scene = 0;
                }
                else if (scene == 30)
                {
                    int chance = randGen.Next(1, 101);

                    if (chance < 40)
                    {
                        scene = 33;
                        SoundPlayer player1 = new SoundPlayer(Properties.Resources.Sword3);
                        SoundPlayer player2 = new SoundPlayer(Properties.Resources.Sword2);
                        SoundPlayer player3 = new SoundPlayer(Properties.Resources.Giant);
                        SoundPlayer player4 = new SoundPlayer(Properties.Resources.Sword1);
                        player1.Play();
                        Thread.Sleep(600);
                        player4.Play();
                        Thread.Sleep(600);
                        player2.Play();
                        Thread.Sleep(600);
                        player3.Play();
                        Thread.Sleep(600);
                    }
                    else
                    {
                        scene = 31;
                        SoundPlayer player1 = new SoundPlayer(Properties.Resources.Sword3);
                        SoundPlayer player2 = new SoundPlayer(Properties.Resources.Sword2);
                        SoundPlayer player4 = new SoundPlayer(Properties.Resources.Sword1);
                        SoundPlayer player5 = new SoundPlayer(Properties.Resources.Death1);
                        SoundPlayer player6 = new SoundPlayer(Properties.Resources.Giant2);
                        player1.Play();
                        Thread.Sleep(600);
                        player4.Play();
                        Thread.Sleep(600);
                        player5.Play();
                        Thread.Sleep(1200);
                        player6.Play();
                        Thread.Sleep(600);
                    }
                }
                else if (scene == 31)
                {
                    scene = 0;
                }
                else if (scene == 33)
                {
                    scene = 4;
                }
                else if (scene == 32)
                {
                    scene = 0;
                }
                else if (scene == 26)
                {
                    scene = 0;
                }
                else if (scene == 29)
                {
                    scene = 0;
                }
                else if (scene == 29)
                {
                    scene = 34;
                    SoundPlayer player1 = new SoundPlayer(Properties.Resources.Victory);
                    player1.Play();
                }
                else if (scene == 34)
                {
                    scene = 0;
                }
                else if (scene == 28)
                {
                    scene = 0;
                }
            }
            else if (e.KeyCode == Keys.R) //Red Button; this is all the code for the red button
            {
                // Front Gate
                if (scene == 0)
                {
                    scene = 11;
                }
                else if (scene == 11)
                {
                    scene = 13;
                    SoundPlayer player1 = new SoundPlayer(Properties.Resources.Ram);
                    SoundPlayer player2 = new SoundPlayer(Properties.Resources.Death1);
                    player1.Play();
                    Thread.Sleep(1000);
                    player1.Play();
                    Thread.Sleep(1000);
                    player1.Play();
                    Thread.Sleep(1000);
                    player1.Play();
                    Thread.Sleep(1000);
                    player2.Play();
                    Thread.Sleep(1000);
                }
                else if (scene == 12)
                {
                    this.Close();
                }
                else if (scene == 13)
                {
                    this.Close();
                }

                // Roof
                else if (scene == 1)
                {
                    scene = 3;
                }
                else if (scene == 3)
                {
                    scene = 5;
                    SoundPlayer player1 = new SoundPlayer(Properties.Resources.Sword1);
                    SoundPlayer player2 = new SoundPlayer(Properties.Resources.Sword2);
                    SoundPlayer player3 = new SoundPlayer(Properties.Resources.Death1);
                    player1.Play();
                    Thread.Sleep(500);
                    player2.Play();
                    Thread.Sleep(500);
                    player3.Play();
                    Thread.Sleep(500);
                }
                else if (scene == 4)
                {
                    scene = 7;
                    SoundPlayer player1 = new SoundPlayer(Properties.Resources.Door);
                    player1.Play();
                    Thread.Sleep(5000);
                }
                else if (scene == 7)
                {
                    int chance = randGen.Next(1, 101);

                    if (chance < 25)
                    {
                        scene = 10; //Ending
                        SoundPlayer player1 = new SoundPlayer(Properties.Resources.Sword1);
                        SoundPlayer player2 = new SoundPlayer(Properties.Resources.Sword2);
                        SoundPlayer player3 = new SoundPlayer(Properties.Resources.Sword3);
                        SoundPlayer player4 = new SoundPlayer(Properties.Resources.Death1);
                        SoundPlayer player5 = new SoundPlayer(Properties.Resources.Gold);
                        SoundPlayer player6 = new SoundPlayer(Properties.Resources.Victory);
                        player1.Play();
                        Thread.Sleep(625);
                        player2.Play();
                        Thread.Sleep(625);
                        player3.Play();
                        Thread.Sleep(625);
                        player1.Play();
                        Thread.Sleep(625);
                        player4.Play();
                        Thread.Sleep(1000);
                        player5.Play();
                        Thread.Sleep(1700);
                        player6.Play();
                    }
                    else
                    {
                        scene = 9; //Ending
                        SoundPlayer player1 = new SoundPlayer(Properties.Resources.Sword1);
                        SoundPlayer player2 = new SoundPlayer(Properties.Resources.Sword2);
                        SoundPlayer player3 = new SoundPlayer(Properties.Resources.Sword3);
                        SoundPlayer player4 = new SoundPlayer(Properties.Resources.Death1);
                        SoundPlayer player5 = new SoundPlayer(Properties.Resources.Death2);
                        player1.Play();
                        Thread.Sleep(625);
                        player2.Play();
                        Thread.Sleep(625);
                        player3.Play();
                        Thread.Sleep(625);
                        player1.Play();
                        Thread.Sleep(625);
                        player4.Play();
                        Thread.Sleep(1000);
                        player3.Play();
                        Thread.Sleep(625);
                        player1.Play();
                        Thread.Sleep(625);
                        player5.Play();
                        Thread.Sleep(600);
                    }
                }
                else if (scene == 2)
                {
                    Close();
                }
                else if (scene == 5)
                {
                    Close();
                }
                else if (scene == 6)
                {
                    Close();
                }
                else if (scene == 8)
                {
                    Close();
                }
                else if (scene == 9)
                {
                    Close();
                }
                else if (scene == 10)
                {
                    Close();
                }

                // Sewer
                else if (scene == 14)
                {
                    scene = 19;
                }
                else if (scene == 19)
                {
                    int chance = randGen.Next(1, 101);

                    if (chance < 80)
                    {
                        scene = 22; //Ending
                        SoundPlayer player1 = new SoundPlayer(Properties.Resources.Sword3);
                        SoundPlayer player2 = new SoundPlayer(Properties.Resources.Sword2);
                        SoundPlayer player3 = new SoundPlayer(Properties.Resources.Death2);
                        SoundPlayer player4 = new SoundPlayer(Properties.Resources.Wolf1);
                        SoundPlayer player5 = new SoundPlayer(Properties.Resources.Wolf2);
                        SoundPlayer player6 = new SoundPlayer(Properties.Resources.Gold);
                        SoundPlayer player7 = new SoundPlayer(Properties.Resources.Fail);
                        player1.Play();
                        Thread.Sleep(600);
                        player4.Play();
                        Thread.Sleep(650);
                        player2.Play();
                        Thread.Sleep(600);
                        player5.Play();
                        Thread.Sleep(650);
                        player1.Play();
                        Thread.Sleep(600);
                        player6.Play();
                        Thread.Sleep(2500);
                        player7.Play();
                    }
                    else
                    {
                        scene = 21; //Ending
                        SoundPlayer player1 = new SoundPlayer(Properties.Resources.Sword3);
                        SoundPlayer player2 = new SoundPlayer(Properties.Resources.Sword2);
                        SoundPlayer player3 = new SoundPlayer(Properties.Resources.Death2);
                        SoundPlayer player4 = new SoundPlayer(Properties.Resources.Wolf1);
                        SoundPlayer player5 = new SoundPlayer(Properties.Resources.Wolf2);
                        player1.Play();
                        Thread.Sleep(600);
                        player4.Play();
                        Thread.Sleep(600);
                        player2.Play();
                        Thread.Sleep(600);
                        player5.Play();
                        Thread.Sleep(600);
                        player3.Play();
                    }
                }
                else if (scene == 15)
                {
                    int chance = randGen.Next(1, 101);

                    if (chance < 65)
                    {
                        scene = 18; //Ending
                        SoundPlayer player1 = new SoundPlayer(Properties.Resources.Gold);
                        SoundPlayer player2 = new SoundPlayer(Properties.Resources.Victory);
                        player1.Play();
                        Thread.Sleep(2300);
                        player2.Play();
                    }
                    else
                    {
                        scene = 17; //Ending
                        SoundPlayer player1 = new SoundPlayer(Properties.Resources.Sword3);
                        SoundPlayer player2 = new SoundPlayer(Properties.Resources.Sword2);
                        SoundPlayer player3 = new SoundPlayer(Properties.Resources.Death3);
                        player1.Play();
                        Thread.Sleep(600);
                        player2.Play();
                        Thread.Sleep(600);
                        player3.Play();
                    }
                }
                else if (scene == 16)
                {
                    Close();
                }
                else if (scene == 17)
                {
                    Close();
                }
                else if (scene == 18)
                {
                    Close();
                }
                else if (scene == 20)
                {
                    Close();
                }
                else if (scene == 21)
                {
                    Close();
                }
                else if (scene == 22)
                {
                    Close();
                }

                // Back Gate
                else if (scene == 23)
                {
                    scene = 30;
                }
                else if (scene == 30)
                {
                    scene = 32; //Ending
                    SoundPlayer player1 = new SoundPlayer(Properties.Resources.Death3);
                    SoundPlayer player2 = new SoundPlayer(Properties.Resources.Giant2);
                    player1.Play();
                    Thread.Sleep(1000);
                    player2.Play();
                }
                else if (scene == 24)
                {
                    scene = 26; //Ending
                    SoundPlayer player1 = new SoundPlayer(Properties.Resources.Ram);
                    SoundPlayer player2 = new SoundPlayer(Properties.Resources.Death3);
                    player1.Play();
                    Thread.Sleep(1000);
                    player2.Play();
                    Thread.Sleep(1000);
                }
                else if (scene == 25)
                {
                    int chance = randGen.Next(1, 101);

                    if (chance < 1)
                    {
                        scene = 29; //Ending
                        SoundPlayer player1 = new SoundPlayer(Properties.Resources.Rattata);
                        player1.Play();
                    }
                    else
                    {
                        scene = 28; //Ending
                        SoundPlayer player1 = new SoundPlayer(Properties.Resources.Gold);
                        SoundPlayer player2 = new SoundPlayer(Properties.Resources.Victory);
                        player1.Play();
                        Thread.Sleep(2600);
                        player2.Play();
                    }
                }
                else if (scene == 26)
                {
                    Close();
                }
                else if (scene == 27)
                {
                    Close();
                }
                else if (scene == 28)
                {
                    Close();
                }
                else if (scene == 34)
                {
                    Close();
                }
                else if (scene == 33)
                {
                    Close();
                }
                else if (scene == 31)
                {
                    Close();
                }
                else if (scene == 32)
                {
                    Close();
                }
            }

            else if (e.KeyCode == Keys.Y) //Yellow button
            {
                //Sewer
                if (scene == 0)
                {
                    scene = 14;
                }
            }
            else if (e.KeyCode == Keys.G) //Green button
            {
                //Back Gate
                if (scene == 0)
                {
                    scene = 23;
                }
            }
                switch (scene)
                {
                // All of this code is for each scene. Environment.NewLine is a bit of code that makes the spacing between paragraphs on the start up screen and for scene 0. 
                    case 0:
                        eventOutputlabel.Text = "Welcome to Castle Heist! This is a game in which you try and break into a castle to steal as much loot as possible! Good luck!" + Environment.NewLine + Environment.NewLine + "After a three day long walk, you have finally made it to Black Reach Castle. Rumour suggests that the castle's king has gone mad and the castle has been long abandoned. Some think that the legendary Dread King roams within the castle's walls, but those stories are just myths. Large sums of gold are said to be hidden within the castle's walls. After closer inspection, you find four ways that you can potentially enter the castle. Which way do you choose?";
                        blueOutputLabel.Text = "Climb up onto the roof.";
                        redOutputlabel.Text = "Try and enter through the front gate.";
                        yellowOutputlabel.Text = "Enter through a sewer drain.";
                        greenOutputlabel.Text = "Climb over the back gate.";
                        yellowOutputlabel.Visible = true;
                        yellowButton.Visible = true;
                        greenOutputlabel.Visible = true;
                        greenButton.Visible = true;
                        break;
                    case 1:
                        eventOutputlabel.Text = "You inspect the wall for a considerable amount of time before finding a way to climb onto the roof safely. Eventually you get to the edge of the roof and pull yourself up. You scan the area and see a medium sized window that you could fit into. Do you try and climb through the window or continue along the roof?";
                        blueOutputLabel.Text = "Continue walking on the roof.";
                        redOutputlabel.Text = "Climb into the window.";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 2:
                        eventOutputlabel.Text = "You decide that the window would not be a good entrance to the castle and you continue walking across the roof. Unfortunatly, an archer spots you and puts an arrow into your forehead before you realize he was even there. GAME OVER.";
                        blueOutputLabel.Text = "Play again?";
                        redOutputlabel.Text = "Quit!";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 3:
                        eventOutputlabel.Text = "You climb into the window and find yourself in a forge with a large amount of weapons in pristine condition around you. After gearing up, you see that there are large doors to your left and a long hallway to your right. Which way to do go?";
                        blueOutputLabel.Text = "Go near the large doors.";
                        redOutputlabel.Text = "Go down the hallway.";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 4:
                        eventOutputlabel.Text = "You draw yourself closer to the doors, but something seems quite strange about them. This castle was supposed to be abandoned, but the doors seem like they were made recently. The door is covered in strange markings and appears to be glowing slightly. Chills run up your spine as you continue to study the door; you feel slighty dizzy and have a slight urge to run. Do you open the doors or continue into a room to the left of the door?";
                        blueOutputLabel.Text = "Move away from the strange doors and into the room.";
                        redOutputlabel.Text = "Open the strange doors.";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        redButton.Visible = true;
                        redOutputlabel.Visible = true;
                        break;
                    case 5:
                        eventOutputlabel.Text = "You continue down the hallway away from the large doors. As soon as you turn a corner however, you find a massive barracks full of soldiers! Before you can even figure out how there are so many soldiers in the 'abandoned' castle, a soldier yells at you and a another soldier thrusts his spear into your chest. GAME OVER.";
                        blueOutputLabel.Text = "Play again?";
                        redOutputlabel.Text = "Quit!";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 6:
                        eventOutputlabel.Text = "You trust your instincts and move away from the door quickly into the room on the left. As soon as you enter the room however, you hear a strange clanking noise, like gears turning. A large being walks out of a door at the far side of the room; some kind of mechanical knight? You panic and try to run out of the room, but the door is locked. You pull out the freshly forged sword you picked up earlier and begin to fight the terrifying figure. You parry a few of it's attacks, but it overwhelms you with it's strength and cuts your sword in half. It then screeches a horrible, ear shattering noise and plunges it's blade into your skull and out your lower back. GAME OVER.";
                        blueOutputLabel.Text = "Play again?";
                        redOutputlabel.Text = "Quit!";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 7:
                        eventOutputlabel.Text = "You fight your instincts and push with all of your strengh to open the doors. You look up and see a breath-taking sight. A large, expansive throne room that has a large glass wall near the back of the room. Behind the wall is a massive pile of gold and gems; as you move closer you notice that the mountain of gold takes up 3/4 of the room. After looking in awe for some time, you look down to see a figure sitting in a throne wearing strange armour that looks very menacing. 'You have somehow broken into my domain, you infidel! Prepare to die!!' You realize with horror that the figure is the Dread King himself!! He gets up from his throne and unsheathes his blade; which glows with a strong red light. He jumps 6 feet in the air and lands infront of you. Do you worship the Dread King or fight him?";
                        blueOutputLabel.Text = "Bow down to the Dread King.";
                        redOutputlabel.Text = "Unsheath your blade and prepare for the fight of your life.";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 8:
                        eventOutputlabel.Text = "You decide to bow down on one knee and claim your loyalties to the Dread King. He swiftly chops your head off. GAME OVER.";
                        blueOutputLabel.Text = "Play again?";
                        redOutputlabel.Text = "Quit!";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 9:
                        eventOutputlabel.Text = "You pull out your newly acquired blade and take a defensive stance. The Dread King takes the first swing and you parry back and forth. He nearly chops off your head a few times, but you are reinvigorated by a feeling of sudden strength and focus. He slips through your stance and slices your chest, but you don't feel anything. You press on fighting and find yourself gaining the upperhand. You counter a large overhead blow from the Dread King and swing with all of your might; chooping the head of the Dread King off from his body. You decide to try and grab as much loot as you can, but three strange mechanical knights storm into the throne room and overwhelm you. Your head is soon spit upon a pike. GAME OVER.";
                        blueOutputLabel.Text = "Play again?";
                        redOutputlabel.Text = "Quit!";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 10:
                        eventOutputlabel.Text = "You pull out your newly acquired blade and take a defensive stance. The Dread King takes the first swing and you parry back and forth. He nearly chops off your head a few times, but you are reinvigorated by a feeling of sudden strength and focus. He slips through your stance and slices your chest, but you don't feel anything. You press on fighting and find yourself gaining the upperhand. You counter a large overhead blow from the Dread King and swing with all of your might; chooping the head of the Dread King off from his body. You decide to take the Dread King's head with you in a bag. You smash through a window and climb down from it using vines that had been growing on the wall for years. You manage to get onto the ground and run far, far away from the castle. You return the head for a massive sum of money. YOU ARE REWARDED WITH 30 MILLION GOLD FOR YOUR EFFORTS! OUTSTANDING!";
                        blueOutputLabel.Text = "Play again?";
                        redOutputlabel.Text = "Quit!";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 11:
                        eventOutputlabel.Text = "You decide to enter through the front gate. You walk up to the gate and try to enter through a side door. The door is locked. Do you try and pick the lock or kick the door down with your all mighty leg?";
                        blueOutputLabel.Text = "Pick the lock.";
                        redOutputlabel.Text = "Kick the door down.";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 12:
                        eventOutputlabel.Text = "You take out your lock picking tools and get to work on the lock. After some time, you get really close to opening the lock when an archer spots you and places a arrow in the back of your head. GAME OVER.";
                        blueOutputLabel.Text = "Play again?";
                        redOutputlabel.Text = "Quit!";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 13:
                        eventOutputlabel.Text = "You begin to kick the door with your all mighty leg...... which you break after the fourth kick. GAME OVER";
                        blueOutputLabel.Text = "Play again?";
                        redOutputlabel.Text = "Quit!";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 14:
                        eventOutputlabel.Text = "You decide to go through the sewer in hopes it would somehow link to a room in the castle. With all your might you manage to lift open the grate and jump down into the depths below. After looking around in the dark for a bit, you find that there is a ladder going down and a ladder going up. The ladder going down leads to what seems like more darkness. You move over to the ladder going upwards and observe light flickering softly at the top of the ladder. Do you take the ladder leading downwards or the ladder leading upwards?";
                        blueOutputLabel.Text = "Climb the ladder leading upwards.";
                        redOutputlabel.Text = "Climb the ladder leading downwards.";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 15:
                        eventOutputlabel.Text = "You decide to take the ladder upwards in hopes that the light will lead to an empty room. You climb all the way up to the top and take a look around at your surroundings. It seems as you have ended up in the basement of the castle; as barrels and boxes fill the room. You start to poke around to see what is inside of the barrels, but you hear footsteps moving towards your location. Do you try and hide in a barrel or fight the person/creature approaching you?";
                        blueOutputLabel.Text = "Prepare for combat.";
                        redOutputlabel.Text = "Hide in a barrel.";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 16:
                        eventOutputlabel.Text = "You unsheath your trusty dagger and position yourself behind some small boxes. You hear the door open to the room as two guards walk in. You spot them at the other side of the room and prepare for your next move. As soon as the two guards pass by your location, you jump up and land on one of the guards. You manage to quickly kill the first guard that you landed on but the other one has already swung his sword at you. You stumble backwards as you see that your right arm is now on the ground beside the body of the first guard. The second guard closes in on you. GAME OVER.";
                        blueOutputLabel.Text = "Play again?";
                        redOutputlabel.Text = "Quit!";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 17:
                        eventOutputlabel.Text = "You quickly cut open a barrel that you made sure was empty and fling the lid back on just as soon as the guards open the door. You sit in the barrel with you dagger still drawn, trying to figure out how you could fight back if the guards were to find you. The footsteps continue by your barrel but then stop suddenly. A spear punctures the barrel and into your chest. GAME OVER.";
                        blueOutputLabel.Text = "Play again?";
                        redOutputlabel.Text = "Quit!";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 18:
                        eventOutputlabel.Text = "You quickly cut open a barrel that you made sure was empty and fling the lid back on just as soon as the guards open the door. You sit in the barrel with you dagger still drawn, trying to figure out how you could fight back if the guards were to find you. The footsteps continue by your barrel. You hear the guards talking to each other in some foreign dialect and then you hear them walk out of the room with a slam of the door. You rise out the barrel slowly and  you quickly barracade the door with a few other large boxes you push into place. You then inspect the room fully and find quite a few valuble items which you put into your rucksack. After looting the room, you go back down the ladder and make your way back out of the sewer. YOU MADE IT OUT WITH A MEDIUM SUM OF GOLD! GOOD JOB!";
                        blueOutputLabel.Text = "Play again?";
                        redOutputlabel.Text = "Quit!";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 19:
                        eventOutputlabel.Text = "You decide to take the ladder downwards in hopes that you may find some secret treasure. You trudge around in the dark for quite sometime until you hear a heavy breathing come from behind you. You whirl around to see two red eyes staring back at you in the dark. Do you try and fight the beast or run away?";
                        blueOutputLabel.Text = "Run away.";
                        redOutputlabel.Text = "Unsheath your dagger and prepare for a fight.";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 20:
                        eventOutputlabel.Text = "The beast looks very menacing and you decide to run away. You begin sprinting down the hallway with the beast right at your heels. Fortunately, after turning a few corners, you eventually lose the beast. Unfortunately, you are now lost in a dark sewer and you have no idea which corners you turned. You begin wandering around for what feels like hours, but you have no success in finding the ladder. You go to sit down to have a rest, but you realize that you hear heavy breathing all around you. The sewer is filled with blood-curling screams of terror. GAME OVER";
                        blueOutputLabel.Text = "Play again?";
                        redOutputlabel.Text = "Quit!";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 21:
                        eventOutputlabel.Text = "You take out your dagger and start swinging. The beast seems to avoid your first few swings, then leaps at you. It topples you over and proceeds to rip the arteries out of your neck before you can thurst your dagger into it's body. GAME OVER";
                        blueOutputLabel.Text = "Play again?";
                        redOutputlabel.Text = "Quit!";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 22:
                        eventOutputlabel.Text = "You take out your dagger and start swinging. The beast seems to avoid your first few swings, then leaps at you. It topples you over onto your back. You quickly thrust your dagger into its neck and the beast jumps off of you. You get up to finish it off, but it bites at your leg and begins to slash your body with it's claws. You swing repeatedly at its neck until you sever its spine. You get up from the ground and limp over to where the beast had been before the battle. You recover a small box which you put into your rucksack and you manage to painfully get out of the sewer. YOU MADE IT OUT WITH A PETTY SUM OF GOLD... BETTER LUCK NEXT TIME!";
                        blueOutputLabel.Text = "Play again?";
                        redOutputlabel.Text = "Quit!";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 23:
                        eventOutputlabel.Text = "You decide to enter through the smaller back gate which you easily climb over. After you land back down on the ground and enter the castle, two pathways present themselves to you. A long hallway with many doors on either side, or head up a flight of stairs. Which way do you go?";
                        blueOutputLabel.Text = "Walk down the hallway.";
                        redOutputlabel.Text = "Climb the stairs.";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 24:
                        eventOutputlabel.Text = "You decide to go down the hallway and see where each of the doors lead to. The first three doors you open reveal rooms with nothing very significant in them, mostly living quarters that look like they havev not be used in decades. The last door reveals a small room with a large strongbox on a table, as well as some foodstuffs. Before you can take a closer look at the strongbox, you hear shouts coming from further down the hallway. Do you grab the strongbox and run or try to break into it?";
                        blueOutputLabel.Text = "Put it in your rucksack and run.";
                        redOutputlabel.Text = "Break into the strongbox.";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 25:
                        eventOutputlabel.Text = "You lift the heavy strong box and manage to place it into your rucksack; you make sure you grab a sweet roll before leaving. As soon as you leave the room, three guards are already running to your location. You break into a sprint and the guards chase you back down the long hallway. You manage to climb over the gate while the guards are trying to unlock the gate and sprint away. You come to a fork in the road, do you go into the forest or walk through the tall grass?";
                        blueOutputLabel.Text = "Run into the woods to lose your captives.";
                        redOutputlabel.Text = "Run into the tall grass to hide from your captives.";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 26:
                        eventOutputlabel.Text = "You decide to break into the strongbox as it looks like it is too heavy to carry in your rucksack. Unfortunatly, while you were trying to pry open the strongbox, the guards were able to get into the room. You try to throw the box at one of the guards to stun him, but the box narrowly misses him. The guards kill you before you can draw your dagger. GAME OVER.";
                        blueOutputLabel.Text = "Play again?";
                        redOutputlabel.Text = "Quit!";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 27:
                        eventOutputlabel.Text = "You run into the woods to try and lose the guards chasing you. You slow down and take a look at your surroundings. You seem to have gotten yourself lost in the forest. You try to get out of the forest the way you came in, but you walk out of the forest right into 10 guards. You are killed on the spot. GAME OVER.";
                        blueOutputLabel.Text = "Play again?";
                        redOutputlabel.Text = "Quit!";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        break;
                    case 28:
                        eventOutputlabel.Text = "You run into the tall grass and lay down so that you are harder to find. The guards run by you and you start crawling away from the castle. You make it back to the town and open the strongbox. It contains a huge sum of 5 million gold. YOU MADE IT OUT WITH A MODERATE SUM OF GOLD. GOOD JOB!";
                        blueOutputLabel.Text = "Play again?";
                        redOutputlabel.Text = "Quit!";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 29:
                        eventOutputlabel.Text = "A wild Rattata appeared!";
                        blueOutputLabel.Text = "Capture it!!!";
                        redOutputlabel.Visible = false;
                        redButton.Visible = false;
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 30:
                        eventOutputlabel.Text = "You decide to head up the flight of stairs. You begin to climb up the stairs with your dagger drawn just in case you encounter someone. You reach the top of the stairs and see a large lift like structure that leads to what seems like a large room.... but a giant stands in your way. Do you fight the giant or run away?";
                        blueOutputLabel.Text = "Fight the giant.";
                        redOutputlabel.Text = "Run away.";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 31:
                        eventOutputlabel.Text = "You charge towards the giant and avoid his first massive swing. Your dagger starts to do work on the giant's right leg, but he swings his massive club onto you. GAME OVER.";
                        blueOutputLabel.Text = "Play again?";
                        redOutputlabel.Text = "Quit!";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 32:
                        eventOutputlabel.Text = "You quickly turn around and try to open the doors you just came through, but they are locked. You turn around to see the giant looming over you. Blood splatters all over the door. GAME OVER.";
                        blueOutputLabel.Text = "Play again?";
                        redOutputlabel.Text = "Quit!";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        break;
                    case 33:
                        eventOutputlabel.Text = "You charge towards the giant and avoid his first massive swing. After your long sprint, you get to his leg and use your dagger like a ice pick; slowly climbing up his body. He tries to shake you off, but you hang on for dear life. You climb onto the giant's head and you plunge your dagger into his skull, killing the giant instantly. You find a freshly forged blade on the lift and you sheath your dagger. After pulling a lever on the lift, the lift begins to move upwards. You find some strange looking doors which give you a feeling of terror.";
                        blueOutputLabel.Text = "Continue";
                        redOutputlabel.Visible = false;
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        redButton.Visible = false;
                        break;
                    case 34:
                        eventOutputlabel.Text = "You sneak up on the Rattata and capture it in your rucksack. You bring it back to town to see if you could sell it for even 1 gold. It turns out that no one has seen the creature before and you sell it for 900 trillion gold. YOU WIN AND HAVE 99% OF ALL THE GOLD IN THE WORLD!!!! GODLIKE!!!!!!";
                        blueOutputLabel.Text = "Play again?";
                        redOutputlabel.Text = "Quit!";
                        yellowOutputlabel.Visible = false;
                        greenOutputlabel.Visible = false;
                        yellowButton.Visible = false;
                        greenButton.Visible = false;
                        redButton.Visible = true;
                        redOutputlabel.Visible = true;
                        break;
           }
        }
    }
}
