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
            eventOutputlabel.Text = "Welcome to Castle Heist! This is a game in which you try and break into a castle to steal as much loot as possible! Good luck!" + Environment.NewLine + Environment.NewLine + "After a three day long walk, you have finally made it to Black Reach Castle. Rumour suggests that the castle's king has gone mad and the castle has been long abandoned. Some think that the legendary Dread King roams within the castle's walls, but those stories are just myths. Large sums of gold are said to be hidden within the castle's walls. After closer inspection, you find four ways that you can potentially enter the castle. Which way do you choose?";
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
                    yellowButton.Visible = false;
                    greenButton.Visible = false;
                    break;
                case 2:
                    eventOutputlabel.Text = "You decide that the window would not be a good entrance to the castle and continue walking across the roof. Unfortunatly, a archer spots you and puts an arrow into your forehead before you realize he was even there. GAME OVER.";
                    blueOutputLabel.Text = "Play again?";
                    redOutputlabel.Text = "Quit!";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    yellowButton.Visible = false;
                    greenButton.Visible = false;
                    break;
                case 3:
                    eventOutputlabel.Text = "You climb into the window and find yourself in a forge with a large amount of weapons in pristine condition around you. After gearing up, you see that there are large doors to your left and a long hallway to your right. Which way to do go?";
                    blueOutputLabel.Text = "Go down the hallway.";
                    redOutputlabel.Text = "Go near the large doors.";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    yellowButton.Visible = false;
                    greenButton.Visible = false;
                    break;
                case 4:
                    eventOutputlabel.Text = "You draw yourself closer to the doors, but something seems quite strange about them. This castle was supposed to be abandoned, but the doors seemed like they were made recently. The door is covered in strange markings and seems to be glowing slightly. Chills run up your spine as you continue to study the door; you feel slighty dizzy and have a slight urge to run. Do you open the doors or continue into a room to the left of the door?";
                    blueOutputLabel.Text = "Open the strange doors.";
                    redOutputlabel.Text = "Move away from the strange doors and into the room.";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    yellowButton.Visible = false;
                    greenButton.Visible = false;
                    break;
                case 5:
                    eventOutputlabel.Text = "You continue down the hallway away from the large doors. As soon as you turn a corner however, you find a massive barracks full of soldiers! Before you can even figure out how there are so many soldiers in the 'abandoned' castle, a soldier yells at you and a another soldier thrusts his spear in your chest. GAME OVER.";
                    blueOutputLabel.Text = "Play again?";
                    redOutputlabel.Text = "Quit!";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    yellowButton.Visible = false;
                    greenButton.Visible = false;
                    break;
                case 6:
                    eventOutputlabel.Text = "You trust your instincts and move away from the door quickly into a another room. As soon as you enter the room however, you hear a strange clanking noise, like gears turning. A large being walks out of a door at the far side of the room; some kind of mechanical knight? You panic and try to run out of the room, but the door is locked. You pull out the freshly forged sword you picked up earlier and begin to fight the terrifying figure. You parry a few of it's attacks, but it overwhelms you with its strength and cuts your sword in half. It then screeches a horrible, ear shattering noise and plunges it's blade into your skull and out your lower back. GAME OVER. ";
                    blueOutputLabel.Text = "Play again?";
                    redOutputlabel.Text = "Quit!";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    yellowButton.Visible = false;
                    greenButton.Visible = false;
                    break;
                case 7:
                    eventOutputlabel.Text = "You fight your instincts and push with all of your strengh to open the doors. You look up and see a breath-taking sight. A large, expansive throne room that has a large glass wall near the back of the room. Behind the wall is a massive pile of gold and gems; as you move closer you notice that the mountain of gold takes of 3/4 of the room. After looking in awe for some time, you look down to see a figure sitting in the throne wearing strange armour that looks very menacing. 'You have somehow broken into my domain, you infidel! Prepare to die!!' The Dread King gets up from his throne and unsheathes his blade; which glows with a strong red light. He jumps 6 feet in the air and lands infront of you. Do you worship the Dread King or fight him?";
                    blueOutputLabel.Text = "Bow to the Dread King";
                    redOutputlabel.Text = "Unsheath your blade and prepare for the fight or your life";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    yellowButton.Visible = false;
                    greenButton.Visible = false;
                    break;
                case 8:
                    eventOutputlabel.Text = "You decide to bow down on one knee and claim your loyalties to the king. He swiftly chops your head off and with such immense force that your head and body fly out of the window and fall into the castle's moat. GAME OVER.";
                    blueOutputLabel.Text = "Play again?";
                    redOutputlabel.Text = "Quit!";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    yellowButton.Visible = false;
                    greenButton.Visible = false;
                    break;
                case 9:
                    eventOutputlabel.Text = "You pull out your newly acquired blade and take a defensive stance. The Dread King takes the first swing and you parry back and forth. He nearly chops off your head a few times, but you are reinvigorated by a sudden strength and focus. He slips through your stance and slices your chest, but you don't feel anything. You press on fighting and find yourself gaining the upperhand. You counter a large overhead swing and swing with all of your might; chooping the head of the Dread King off from his body. You decide to try and grab as much loot as you can, but three Steamwinders (the king's elite guard) storm into the throne room and overwhelm you. Your head is soon spit upon a steak. GAME OVER";
                    blueOutputLabel.Text = "Play again?";
                    redOutputlabel.Text = "Quit!";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    yellowButton.Visible = false;
                    greenButton.Visible = false;
                    break;
                case 10:
                    eventOutputlabel.Text = "You pull out your newly acquired blade and take a defensive stance. The Dread King takes the first swing and you parry back and forth. He nearly chops off your head a few times, but you are reinvigorated by a sudden strength and focus. He slips through your stance and slices your chest, but you don't feel anything. You press on fighting and find yourself gaining the upperhand. You counter a large overhead swing and swing with all of your might; chooping the head of the Dread King off from his body. You decide to take the Dread King's head with you in a bag. You smash through a window and climb down from it using vines that had been growing on the wall for years. You manage to get onto the ground and run far, far away from the castle. You return the head for a massive sum of money. YOU ARE REWARDED WITH 30 MILLION GOLD FOR YOUR EFFORTS! OUTSTANDING!";
                    blueOutputLabel.Text = "Play again?";
                    redOutputlabel.Text = "Quit!";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    yellowButton.Visible = false;
                    greenButton.Visible = false;
                    break;
                case 11:
                    eventOutputlabel.Text = "You decide to enter through the front gate. You walk up to the gate and try to enter through a side door. The door is locked. Do you try and pick the lock or kick the door down with your mighty legs?";
                    blueOutputLabel.Text = "Pick the lock";
                    redOutputlabel.Text = "Kick the door down";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    yellowButton.Visible = false;
                    greenButton.Visible = false;
                    break;
                case 12:
                    eventOutputlabel.Text = "You take out your lock picking tools and get to work on the lock. After some time, you get really close to opening the lock when a guard walks out from another door and takes his war hammer out. You are crushed to a pulp. GAME OVER";
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
                    eventOutputlabel.Text = "You decide to go through the sewer in hopes it would somehow link to a room in the castle. With all your might you manage to lift open the grate and jump down into the depths below. After looking around in the dark for a bit, you find that there is a ladder going down and a ladder going up. The ladder going down leads to what seems like more darkness. You move over the the ladder going upwards and observe light flickering softly at the top of the ladder. Do you take the ladder leading downwards or the ladder leading upwards?";
                    blueOutputLabel.Text = "Climb the ladder leading downwards";
                    redOutputlabel.Text = "Climb the ladder leading upwards";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    yellowButton.Visible = false;
                    greenButton.Visible = false;
                    break;
                case 15:
                    eventOutputlabel.Text = "You decide to take the ladder upwards in hopes that the light will lead to a empty room. You climb all the way up to the top and take a look around at your surroundings. It seems as you have ended up in the basement of the castle, as barrels and boxes fill the room. You start to poke around to see what is inside of the barrels, but before you can open one of the boxes, you hear footsteps moving towards your location. Do you try and hide in a barrel or fight the person/creature approaching you?";
                    blueOutputLabel.Text = "Hide in a barrel";
                    redOutputlabel.Text = "Prepare for combat";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    yellowButton.Visible = false;
                    greenButton.Visible = false;
                    break;
                case 16:
                    eventOutputlabel.Text = "You unsheath your trusty dagger and position yourself behind some small boxes. You hear the door open to the room as two guards walk in. You spot them at the other side of the room and prepare for your next move. As soon as the two guards pass by your location, you jump up and land onto one of the guards. You manage to quickly kill the first guard but the other one has already swung his sword at you. You stumble backwards as you see that your right arm is now on the ground beside the body of the first guard. The second guard closes in on you. GAME OVER. ";
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
                    eventOutputlabel.Text = "You quickly cut open a barrel that you made sure was empty and fling the lid back on just as soon as the guards open the door. You sit in the barrel with you dagger still drawn, trying to figure out how you could fight back if the guards were to find you. The footsteps continue by your barrel. You hear the guards talking to each other in some foreign dialect and then you hear them walk out of the room with a slam of the door. You rise out the barrel slowly and barracade the door with a few other large boxes you push into place. You then inspect the room fully and find quite a few valuble items which you put into your rucksack. After looting the room, you go back down the ladder and make your way back out of the sewer. YOU MADE IT OUT WITH A MEDIUM SUM OF GOLD! GOOD JOB!";
                    blueOutputLabel.Text = "Play again?";
                    redOutputlabel.Text = "Quit!";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    yellowButton.Visible = false;
                    greenButton.Visible = false;
                    break;
                case 19:
                    eventOutputlabel.Text = "You decide to take the ladder downwards in hopes that you may find some secret treasure. You trudge around in the dark for quite sometime until you hear a roar come from behind you. You whirl around to see two red eyes staring back at you in the dark. Do you try and fight the beast or run away?";
                    blueOutputLabel.Text = "Unsheath your dagger and prepare for a fight";
                    redOutputlabel.Text = "Run away";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    yellowButton.Visible = false;
                    greenButton.Visible = false;
                    break;
                case 20:
                    eventOutputlabel.Text = "The beast looks very menacing and you decide to run away. You begin sprinting down the hallway with the beast right at your heels. Fortunately, after turning a few corners, you eventually lose the beast. Unfortunately, you are now lost in a dark sewer and you have no idea which corners you turned. You begin wandering around for what feels like hours, but you have no success in finding the ladder. You sit down to have a rest, before realizing that you hear heavy breathing all around you. The sewer is filled with blood-curling screams of terror. GAME OVER";
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
                    eventOutputlabel.Text = "You take out your dagger and start swinging. The beast seems to avoid your first few swings, then leaps at you. It topples you over onto your back. You quickly thrust your dagger into its neck and the beast jumps off of you. You get up to finish it off, but it bites and your leg and begins to slash your body with it's claws. You swing repeatedly at its neck until you sever its spine. You get up from the ground and limp over to where the beast had been before the battle. You recover a small box which you put into your rucksack and you manage to painfully get out of the sewer. YOU MADE IT OUT WITH A PETTY SUM OF GOLD... BETTER LUCK NEXT TIME!";
                    blueOutputLabel.Text = "Play again?";
                    redOutputlabel.Text = "Quit!";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    yellowButton.Visible = false;
                    greenButton.Visible = false;
                    break;
                case 23:
                    eventOutputlabel.Text = "You decide to enter through the smaller back gate which you can easily climb over. After you land back down on the ground and enter the castle, two pathways present themselves to you. A long hallway with many doors on either side, or head up a flight of stairs. Which way do you go?";
                    blueOutputLabel.Text = "Climb the stairs";
                    redOutputlabel.Text = "Walk down the hallway";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    yellowButton.Visible = false;
                    greenButton.Visible = false;
                    break;
                case 24:
                    eventOutputlabel.Text = "You decide to go down the hallway and see where each of the doors lead to. The first three doors you open reveal rooms with nothing very significant in them, mostly living quarters that looked like they had not be used in decades. The last door revealed a small room with a large strongbox on a table, as well as some foodstuffs. Before you can take a closer look at the strongbox, you hear shouts coming from further down the hallway. Do you grab the strongbox and run or try to break into it?";
                    blueOutputLabel.Text = "Break into the strongbox";
                    redOutputlabel.Text = "Put it in your rucksack and run";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    yellowButton.Visible = false;
                    greenButton.Visible = false;
                    break;
                case 25:
                    eventOutputlabel.Text = "You lift the heavy strong box and manage to place it into your rucksack; you make sure you grab a sweet roll before leaving. As soon as you leave the room, three guards are already running to your location. You break into a sprint and the guards chase you back down the long hallway. You manage to climb over the gate while the guards are trying to unlock the gate and sprint away. You come to a fork in the road, do you go into the forest or walk through the tall grass?";
                    blueOutputLabel.Text = "Play again?";
                    redOutputlabel.Text = "Quit!";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    yellowButton.Visible = false;
                    greenButton.Visible = false;
                    break;
                case 26:
                    eventOutputlabel.Text = "You decide to break into the strongbox as it looks like it is too heavy to carry in your rucksack. Unfortunatly, while you were trying to pry open the strongbox, the guards were able to get into the room. ";
                    blueOutputLabel.Text = "Play again?";
                    redOutputlabel.Text = "Quit!";
                    yellowOutputlabel.Visible = false;
                    greenOutputlabel.Visible = false;
                    yellowButton.Visible = false;
                    greenButton.Visible = false;
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
