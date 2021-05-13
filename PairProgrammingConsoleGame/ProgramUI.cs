using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PairProgrammingConsoleGame
{
    public class ProgramUI
    {
        bool _hasKey;
        bool _hasWeapon;
        bool _hasRiddle;
        bool _firstRoom;

        public void Run()
        {
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                _hasKey = false;
                _hasWeapon = false;
                _hasRiddle = false;
                _firstRoom = false;
                Console.Clear();
                Console.Title = "Dungeon of Riddles";
                string title = @"

            ▓█████▄  █    ██  ███▄    █   ▄████ ▓█████  ▒█████   ███▄    █ 
            ▒██▀ ██▌ ██  ▓██▒ ██ ▀█   █  ██▒ ▀█▒▓█   ▀ ▒██▒  ██▒ ██ ▀█   █ 
            ░██   █▌▓██  ▒██░▓██  ▀█ ██▒▒██░▄▄▄░▒███   ▒██░  ██▒▓██  ▀█ ██▒
            ░▓█▄   ▌▓▓█  ░██░▓██▒  ▐▌██▒░▓█  ██▓▒▓█  ▄ ▒██   ██░▓██▒  ▐▌██▒
            ░▒████▓ ▒▒█████▓ ▒██░   ▓██░░▒▓███▀▒░▒████▒░ ████▓▒░▒██░   ▓██░
             ▒▒▓  ▒ ░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒  ░▒   ▒ ░░ ▒░ ░░ ▒░▒░▒░ ░ ▒░   ▒ ▒ 
             ░ ▒  ▒ ░░▒░ ░ ░ ░ ░░   ░ ▒░  ░   ░  ░ ░  ░  ░ ▒ ▒░ ░ ░░   ░ ▒░
             ░ ░  ░  ░░░ ░ ░    ░   ░ ░ ░ ░   ░    ░   ░ ░ ░ ▒     ░   ░ ░ 
               ░       ░              ░       ░    ░  ░    ░ ░           ░ 
             ░                    ▒█████    █████▒                         
                                 ▒██▒  ██▒▓██   ▒                          
                                 ▒██░  ██▒▒████ ░                          
                                 ▒██   ██░░▓█▒  ░                          
                                 ░ ████▓▒░░▒█░                             
                                 ░ ▒░▒░▒░  ▒ ░                             
                                   ░ ▒ ▒░  ░                               
                                 ░ ░ ░ ▒   ░ ░                             
                                     ░ ░                                   
                ██▀███   ██▓▓█████▄ ▓█████▄  ██▓    ▓█████   ██████        
               ▓██ ▒ ██▒▓██▒▒██▀ ██▌▒██▀ ██▌▓██▒    ▓█   ▀ ▒██    ▒        
               ▓██ ░▄█ ▒▒██▒░██   █▌░██   █▌▒██░    ▒███   ░ ▓██▄          
               ▒██▀▀█▄  ░██░░▓█▄   ▌░▓█▄   ▌▒██░    ▒▓█  ▄   ▒   ██▒       
               ░██▓ ▒██▒░██░░▒████▓ ░▒████▓ ░██████▒░▒████▒▒██████▒▒       
               ░ ▒▓ ░▒▓░░▓   ▒▒▓  ▒  ▒▒▓  ▒ ░ ▒░▓  ░░░ ▒░ ░▒ ▒▓▒ ▒ ░       
                 ░▒ ░ ▒░ ▒ ░ ░ ▒  ▒  ░ ▒  ▒ ░ ░ ▒  ░ ░ ░  ░░ ░▒  ░ ░       
                 ░░   ░  ▒ ░ ░ ░  ░  ░ ░  ░   ░ ░      ░   ░  ░  ░         
                  ░      ░     ░       ░        ░  ░   ░  ░      ░         
                             ░       ░                                     
";
                Console.WriteLine(title);
                Console.WriteLine("\tWelcome to the dungeon.\n");
                Console.WriteLine("\tSelect a menu option:\n" +
                    "\t1. Start Game\n" +
                    "\t2. Rules\n" +
                    "\t3. Exit");

                string input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "1":
                        // StartGame
                        StartGame();
                        break;
                    case "2":
                        // DisplayRules
                        DisplayRules();
                        break;
                    case "3":
                        // Exit
                        keepRunning = false;
                        Exit();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\n\tPlease enter a valid option.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        Console.ReadKey();
                        break;
                }
                Console.WriteLine("\n\tPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void DisplayRules()
        {
            Console.Clear();
            string title = @"

             ██▀███   █    ██  ██▓    ▓█████   ██████ 
            ▓██ ▒ ██▒ ██  ▓██▒▓██▒    ▓█   ▀ ▒██    ▒ 
            ▓██ ░▄█ ▒▓██  ▒██░▒██░    ▒███   ░ ▓██▄   
            ▒██▀▀█▄  ▓▓█  ░██░▒██░    ▒▓█  ▄   ▒   ██▒
            ░██▓ ▒██▒▒▒█████▓ ░██████▒░▒████▒▒██████▒▒
            ░ ▒▓ ░▒▓░░▒▓▒ ▒ ▒ ░ ▒░▓  ░░░ ▒░ ░▒ ▒▓▒ ▒ ░
              ░▒ ░ ▒░░░▒░ ░ ░ ░ ░ ▒  ░ ░ ░  ░░ ░▒  ░ ░
              ░░   ░  ░░░ ░ ░   ░ ░      ░   ░  ░  ░  
               ░        ░         ░  ░   ░  ░      ░  
                                                      
";
            Console.WriteLine(title);
            Console.WriteLine("\n\tTo play the game you can use the numbered options always presented to you or\n" +
                "\tuse keywords like \"goto\", \"look at\", \"open\", and \"pick up\" objects or items that are presented to you.\n" +
                "\tThis dungeon is full of clues that are needed to escape. Make sure you take a look around or you\n" +
                "\tcould end up missing something important.\n" +
                "\n" +
                "\tPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        private void StartGame()
        {
            Console.Clear();
            Console.WriteLine("\n\tWelcome to the Dungeon of Riddles.\n" +
                "\n" +
                "\tYou find yourself lost amoungst the trees of your nearby village. The sky darkens with the\n" +
                "\tsetting of the sun, the air begins to feel like a cold frost as you inhale it into your lungs.\n" +
                "\tA subtle mist begins to descend from the leaves above you and you grow weary as you wander aimlessly\n" +
                "\ttrying to get a grasp on your surroundings.\n" +
                "\n" +
                "\tPress any key to continue...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n\tMinutes turn to hours and yet still, you have not found your way back. An ensuing\n" +
                "\tinevitable dread washes over your psyche and panic begins to seep into the recesses of your mind. Your\n" +
                "\tsenses heighten, every branch that cracks, every caw from nearby crows, and the dreadful whisper of the\n" +
                "\twind deepens your anxiety.\n" +
                "\n" +
                "\tThe sun has been set for hours now, cold and alone, you finally realize that this forest will have to be\n" +
                "\twhere you bed down for the night. You feel your way around the area clutching branches and trees to keep\n" +
                "\tyourself grounded before hunkering down beneath your wooden bark-like shelter. Huddling close to the trunk\n" +
                "\tand curling up into a small ball for warmth, you drift away into a deep sleep.\n" +
                "\n" +
                "\tPress any key to continue...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n\tYou stir awake from what felt like a bad dream, it's dark but you feel the comfort of a bed.\n" +
                "\tYou let out a sigh of relief and reach over to your bedside to light your morning lantern, but as you reached\n" +
                "\tforward expecting to meet your bedside table you instead fall - crashing against a cold damp stone like floor.\n" +
                "\tThis place is not your home, and you have instead awoken deeper into the nightmare that started last night.\n" +
                "\n" +
                "\tIf you are ever to return home you know that you must escape this hell or you'll never see the town where\n" +
                "\tyou reside again.\n" +
                "\n" +
                "\tPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Start();
        }

        // Room One - red door
        public void Start()
        {
            if(_firstRoom)
            {
                RoomOne();
            }
            else
            {
                RoomOneFirst();
            }
        }
        private void RoomOneFirst()
        {
            _firstRoom = true;
            Console.Clear();
            string title = @"
         ██▀███   ▒█████   ▒█████   ███▄ ▄███▓    ▒█████   ███▄    █▓█████ 
        ▓██ ▒ ██▒▒██▒  ██▒▒██▒  ██▒▓██▒▀█▀ ██▒   ▒██▒  ██▒ ██ ▀█   █▓█   ▀ 
        ▓██ ░▄█ ▒▒██░  ██▒▒██░  ██▒▓██    ▓██░   ▒██░  ██▒▓██  ▀█ ██▒███   
        ▒██▀▀█▄  ▒██   ██░▒██   ██░▒██    ▒██    ▒██   ██░▓██▒  ▐▌██▒▓█  ▄ 
        ░██▓ ▒██▒░ ████▓▒░░ ████▓▒░▒██▒   ░██▒   ░ ████▓▒░▒██░   ▓██░▒████▒
        ░ ▒▓ ░▒▓░░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░   ░  ░   ░ ▒░▒░▒░ ░ ▒░   ▒ ▒░░ ▒░ ░
          ░▒ ░ ▒░  ░ ▒ ▒░   ░ ▒ ▒░ ░  ░      ░     ░ ▒ ▒░ ░ ░░   ░ ▒░░ ░  ░
          ░░   ░ ░ ░ ░ ▒  ░ ░ ░ ▒  ░      ░      ░ ░ ░ ▒     ░   ░ ░   ░   
           ░         ░ ░      ░ ░         ░          ░ ░           ░   ░  ░
                                                                           
";
            Console.WriteLine(title);
            Console.WriteLine("\n\tYou pick yourself up off the damp stone floor, brush yourself off and begin fumbling\n" +
                "\taround the darkness.\n" +
                "\n" +
                "\tPress any key to continue...");
            Console.ReadKey();
            bool inRoomOne = true;
            while (inRoomOne)
            {
                Console.Clear();
                Console.WriteLine(title);
                Console.WriteLine("\n\tYou finally orientate yourself with your surroundings and your eyes begin to adjust to\n" +
                    "\tthe dark. While it is still hard to see, you are able to make out that you are standing in a room with \n" +
                    "\tfour walls and two doors.\n" +
                    "\n" +
                    "\tDuring your search you found a key lying on the floor in a corner, some torn pages scattered across the room,\n" +
                    "\tthe bed you awoke in, one blue door, and one green door.\n" +
                    "\n" +
                    "\tWhat would you like to do?\n" +
                    "\n" +
                    "\tNote: Remember you can use the keywords \"goto\", \"look at\", \"open\", and \"pick up\" objects or items \n" +
                    "\tthat are presented to you.\n" +
                    "\n" +
                    "\t1. Rules\n" +
                    "\t2. Inventory\n" +
                    "\t3. Exit");

                string input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "1":
                        // Rules
                        DisplayRules();
                        Console.WriteLine("\tPress any key to continue...");
                        break;
                    case "2":
                        // Inventory
                        Inventory();
                        Console.WriteLine("\tPress any key to continue...");
                        break;
                    case "3":
                        // Exit
                        return;
                    case "goto blue door":
                        // goto blue door
                        Console.Clear();
                        Console.WriteLine("\n\tYou walk up to the blue door. You are closer to it than you were before.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "look at blue door":
                        // look at blue door
                        Console.Clear();
                        Console.WriteLine("\n\tYou stare at the blue door. The door is of normal size possibly an ancient wood work of years past.\n" +
                            "\tIt is weatherd and fading but its blue coat of paint still exists. The handle has begun to rust and it's hinges look\n" +
                            "\tlook as if they have not moved in a very long time.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "open blue door":
                        // open blue door
                        OpenDoor();
                        Console.ReadKey();
                        inRoomOne = false;
                        RoomFour();
                        break;
                    case "pick up blue door":
                        // pick up blue door
                        Console.Clear();
                        Console.WriteLine("\n\tYou simply are not strong enough to pick up the door. Maybe because it still resides within\n" +
                            "\tits frame.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "goto green door":
                        // goto green door
                        Console.Clear();
                        Console.WriteLine("\n\tYou walk up to the green door. You are closer to it than you were before.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "look at green door":
                        // look at green door
                        Console.Clear();
                        Console.WriteLine("\n\tYou stare at the green door. The door is of normal size possibly an ancient wood work of years past.\n" +
                            "\tIt is weatherd and fading but its green coat of paint still exists. The handle has begun to rust and it's hinges look\n" +
                            "\tlook as if they have not moved in a very long time.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "open green door":
                        // open green door
                        OpenDoor();
                        Console.ReadKey();
                        inRoomOne = false;
                        RoomTwo();
                        break;
                    case "pick up green door":
                        // pick up green door
                        Console.Clear();
                        Console.WriteLine("\n\tYou simply are not strong enough to pick up the door. Maybe because it still resides within its frame.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "goto torn pages":
                        // goto torn pages
                        Console.Clear();
                        Console.WriteLine("\n\tYou walk over to the torn pages that a littered over the floor.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "look at torn pages":
                        // look at torn pages
                        Console.Clear();
                        Console.WriteLine("\n\tSadly after what could be years of decay the words on these pages are no longer legible.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "pick up torn pages":
                        // pick up torn pages
                        Console.Clear();
                        Console.WriteLine("\n\tSadly after what could be years of decay the words on these pages are no longer legible.\n" +
                            "\n" +
                            "\tIt is probably best to not take these pages with you, there is no point.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "goto key":
                        // goto key
                        Console.Clear();
                        Console.WriteLine("\n\tYou walk over to the key that is on the ground in the corner. It entices you, maybe\n" +
                            "\tyou will need this later.\n" +
                            "\n" +
                            "\tNote: You can \"pick up key\" to add this item to your inventory.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "look at key":
                        // look at key
                        Console.Clear();
                        Console.WriteLine("\n\tThe key glistens in the darkened room, gold and embroidered with some ancient dialect unkown to yourself.\n" +
                            "\tIt entices you, maybe you will need this later.\n" +
                            "\n" +
                            "\tNote: You can \"pick up key\" to add this item to your inventory.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "pick up key":
                        // pick up key
                        Console.Clear();
                        Console.WriteLine("\n\tYou walk over to the key on the ground, bend down, pick it up and slip into your pocket.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        _hasKey = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\n\tPlease enter a valid option.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                }
                // Console.WriteLine("\n\tPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void RoomOne()
        {
            _firstRoom = true;
            Console.Clear();
            string title = @"
         ██▀███   ▒█████   ▒█████   ███▄ ▄███▓    ▒█████   ███▄    █▓█████ 
        ▓██ ▒ ██▒▒██▒  ██▒▒██▒  ██▒▓██▒▀█▀ ██▒   ▒██▒  ██▒ ██ ▀█   █▓█   ▀ 
        ▓██ ░▄█ ▒▒██░  ██▒▒██░  ██▒▓██    ▓██░   ▒██░  ██▒▓██  ▀█ ██▒███   
        ▒██▀▀█▄  ▒██   ██░▒██   ██░▒██    ▒██    ▒██   ██░▓██▒  ▐▌██▒▓█  ▄ 
        ░██▓ ▒██▒░ ████▓▒░░ ████▓▒░▒██▒   ░██▒   ░ ████▓▒░▒██░   ▓██░▒████▒
        ░ ▒▓ ░▒▓░░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░   ░  ░   ░ ▒░▒░▒░ ░ ▒░   ▒ ▒░░ ▒░ ░
          ░▒ ░ ▒░  ░ ▒ ▒░   ░ ▒ ▒░ ░  ░      ░     ░ ▒ ▒░ ░ ░░   ░ ▒░░ ░  ░
          ░░   ░ ░ ░ ░ ▒  ░ ░ ░ ▒  ░      ░      ░ ░ ░ ▒     ░   ░ ░   ░   
           ░         ░ ░      ░ ░         ░          ░ ░           ░   ░  ░
                                                                           
";
            Console.WriteLine(title);
           
            bool inRoomOne = true;
            while (inRoomOne)
            {
                Console.Clear();
                Console.WriteLine(title);
                Console.WriteLine("\n\tWhile it is still hard to see, you are able to make out that you are standing in a room with \n" +
                    "\tfour walls and two doors.\n" +
                    "\n" +
                    "\tDuring your search you found a key lying on the floor in a corner, some torn pages scattered across the room,\n" +
                    "\tthe bed you awoke in, one blue door, and one green door.\n" +
                    "\n" +
                    "\tWhat would you like to do?\n" +
                    "\n" +
                    "\tNote: Remember you can use the keywords \"goto\", \"look at\", \"open\", and \"pick up\" objects or items \n" +
                    "\tthat are presented to you.\n" +
                    "\n" +
                    "\t1. Rules\n" +
                    "\t2. Inventory\n" +
                    "\t3. Exit");

                string input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "1":
                        // Rules
                        DisplayRules();
                        Console.WriteLine("\tPress any key to continue...");
                        break;
                    case "2":
                        // Inventory
                        Inventory();
                        Console.WriteLine("\tPress any key to continue...");
                        break;
                    case "3":
                        // Exit
                        return;
                    case "goto blue door":
                        // goto blue door
                        Console.Clear();
                        Console.WriteLine("\n\tYou walk up to the blue door. You are closer to it than you were before.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "look at blue door":
                        // look at blue door
                        Console.Clear();
                        Console.WriteLine("\n\tYou stare at the blue door. The door is of normal size possibly an ancient wood work of years past.\n" +
                            "\tIt is weatherd and fading but its blue coat of paint still exists. The handle has begun to rust and it's hinges look\n" +
                            "\tlook as if they have not moved in a very long time.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "open blue door":
                        // open blue door
                        OpenDoor();
                        Console.ReadKey();
                        inRoomOne = false;
                        RoomFour();
                        break;
                    case "pick up blue door":
                        // pick up blue door
                        Console.Clear();
                        Console.WriteLine("\n\tYou simply are not strong enough to pick up the door. Maybe because it still resides within\n" +
                            "\tits frame.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "goto green door":
                        // goto green door
                        Console.Clear();
                        Console.WriteLine("\n\tYou walk up to the green door. You are closer to it than you were before.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "look at green door":
                        // look at green door
                        Console.Clear();
                        Console.WriteLine("\n\tYou stare at the green door. The door is of normal size possibly an ancient wood work of years past.\n" +
                            "\tIt is weatherd and fading but its green coat of paint still exists. The handle has begun to rust and it's hinges look\n" +
                            "\tlook as if they have not moved in a very long time.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "open green door":
                        // open green door
                        OpenDoor();
                        Console.ReadKey();
                        inRoomOne = false;
                        RoomTwo();
                        break;
                    case "pick up green door":
                        // pick up green door
                        Console.Clear();
                        Console.WriteLine("\n\tYou simply are not strong enough to pick up the door. Maybe because it still resides within its frame.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "goto torn pages":
                        // goto torn pages
                        Console.Clear();
                        Console.WriteLine("\n\tYou walk over to the torn pages that a littered over the floor.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "look at torn pages":
                        // look at torn pages
                        Console.Clear();
                        Console.WriteLine("\n\tSadly after what could be years of decay the words on these pages are no longer legible.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "pick up torn pages":
                        // pick up torn pages
                        Console.Clear();
                        Console.WriteLine("\n\tSadly after what could be years of decay the words on these pages are no longer legible.\n" +
                            "\n" +
                            "\tIt is probably best to not take these pages with you, there is no point.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "goto key":
                        // goto key
                        Console.Clear();
                        Console.WriteLine("\n\tYou walk over to the key that is on the ground in the corner. It entices you, maybe\n" +
                            "\tyou will need this later.\n" +
                            "\n" +
                            "\tNote: You can \"pick up key\" to add this item to your inventory.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "look at key":
                        // look at key
                        Console.Clear();
                        Console.WriteLine("\n\tThe key glistens in the darkened room, gold and embroidered with some ancient dialect unkown to yourself.\n" +
                            "\tIt entices you, maybe you will need this later.\n" +
                            "\n" +
                            "\tNote: You can \"pick up key\" to add this item to your inventory.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "pick up key":
                        // pick up key
                        Console.Clear();
                        Console.WriteLine("\n\tYou walk over to the key on the ground, bend down, pick it up and slip into your pocket.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        _hasKey = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\n\tPlease enter a valid option.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                }
                // Console.WriteLine("\n\tPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }


        // Room Two - green door
        private void RoomTwo()
        {
            Console.Clear();
            string title = @"
         ██▀███   ▒█████   ▒█████   ███▄ ▄███▓   ▄▄▄█████▓ █     █░ ▒█████  
        ▓██ ▒ ██▒▒██▒  ██▒▒██▒  ██▒▓██▒▀█▀ ██▒   ▓  ██▒ ▓▒▓█░ █ ░█░▒██▒  ██▒
        ▓██ ░▄█ ▒▒██░  ██▒▒██░  ██▒▓██    ▓██░   ▒ ▓██░ ▒░▒█░ █ ░█ ▒██░  ██▒
        ▒██▀▀█▄  ▒██   ██░▒██   ██░▒██    ▒██    ░ ▓██▓ ░ ░█░ █ ░█ ▒██   ██░
        ░██▓ ▒██▒░ ████▓▒░░ ████▓▒░▒██▒   ░██▒     ▒██▒ ░ ░░██▒██▓ ░ ████▓▒░
        ░ ▒▓ ░▒▓░░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░   ░  ░     ▒ ░░   ░ ▓░▒ ▒  ░ ▒░▒░▒░ 
          ░▒ ░ ▒░  ░ ▒ ▒░   ░ ▒ ▒░ ░  ░      ░       ░      ▒ ░ ░    ░ ▒ ▒░ 
          ░░   ░ ░ ░ ░ ▒  ░ ░ ░ ▒  ░      ░        ░        ░   ░  ░ ░ ░ ▒  
           ░         ░ ░      ░ ░         ░                   ░        ░ ░  
                                                                            
";
            bool inRoomTwo = true;
            while (inRoomTwo)
            {
                Console.WriteLine(title);
                Console.WriteLine("\n\tAs you emerge into this new space, the smell of rot and decay barrages your nostrils. The air here\n" +
                    "\tsmells of death and mildew. As you pan your gaze across the room you see a corpse that has a book clutched\n" +
                    "\tin their arms, you notice a picture frame with a slashed canvas, and a mirror. You see the red door you just\n" +
                    "\tpassed through, and a new door that is brown.\n" +
                    "\n" +
                    "\tWhat would you like to do?\n" +
                    "\n" +
                    "\t1. Rules\n" +
                    "\t2. Inventory\n" +
                    "\t3. Exit");

                string input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "1":
                        // Rules
                        DisplayRules();
                        Console.WriteLine("\tPress any key to continue...");
                        break;
                    case "2":
                        // Inventory
                        Inventory();
                        Console.WriteLine("\tPress any key to continue...");
                        break;
                    case "3":
                        // Exit
                        return;
                    case "open red door":
                        OpenDoor();
                        Console.ReadKey();
                        inRoomTwo = false;
                        RoomOne();
                        break;
                    case "open brown door":
                        OpenDoor();
                        Console.ReadKey();
                        inRoomTwo = false;
                        RoomThree();
                        break;
                    case "look at mirror":
                    case "go to mirror":
                    case "goto mirror":
                    case "pickup mirror":
                    case "pick up mirror":
                    case "mirror":
                        Console.Clear();
                        Console.WriteLine("\n\tYou walk over to the mirror and gaze upon it. You see your reflection looking back at you dreadfully.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case "look at picture":
                    case "go to picture":
                    case "goto picture":
                    case "picture":
                    case "pick up picture":
                    case "pickup picture":
                    case "look at picture frame":
                    case "go to picture frame":
                    case "goto picture frame":
                    case "picture frame":
                        Console.Clear();
                        Console.WriteLine("\n\tYou walk over to the picture and gaze upon it. You see a slashed canvas, it was most likely a potrait\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case "goto corpse":
                    case "look at corpse":
                    case "corpse":
                    case "look at book":
                    case "go to book":
                    case "goto book":
                    case "book":
                        Console.Clear();
                        Console.WriteLine("\n\tYou walk over to the corpse and pry the book from their arms. You open the book and look amoung\n" +
                            "\tits pages. While most pages are too badly damaged to read them you do see one page that seems unscathed.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        Console.ReadKey();
                        Book();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\n\tPlease enter a valid option.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                }
                //Console.WriteLine("\n\tPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // Room Three - brown door
        private void RoomThree()
        {
            Console.Clear();
            string title = @"
         ██▀███   ▒█████   ▒█████   ███▄ ▄███▓   ▄▄▄█████▓ ██░ ██  ██▀███  ▓█████ ▓█████ 
        ▓██ ▒ ██▒▒██▒  ██▒▒██▒  ██▒▓██▒▀█▀ ██▒   ▓  ██▒ ▓▒▓██░ ██▒▓██ ▒ ██▒▓█   ▀ ▓█   ▀ 
        ▓██ ░▄█ ▒▒██░  ██▒▒██░  ██▒▓██    ▓██░   ▒ ▓██░ ▒░▒██▀▀██░▓██ ░▄█ ▒▒███   ▒███   
        ▒██▀▀█▄  ▒██   ██░▒██   ██░▒██    ▒██    ░ ▓██▓ ░ ░▓█ ░██ ▒██▀▀█▄  ▒▓█  ▄ ▒▓█  ▄ 
        ░██▓ ▒██▒░ ████▓▒░░ ████▓▒░▒██▒   ░██▒     ▒██▒ ░ ░▓█▒░██▓░██▓ ▒██▒░▒████▒░▒████▒
        ░ ▒▓ ░▒▓░░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░   ░  ░     ▒ ░░    ▒ ░░▒░▒░ ▒▓ ░▒▓░░░ ▒░ ░░░ ▒░ ░
          ░▒ ░ ▒░  ░ ▒ ▒░   ░ ▒ ▒░ ░  ░      ░       ░     ▒ ░▒░ ░  ░▒ ░ ▒░ ░ ░  ░ ░ ░  ░
          ░░   ░ ░ ░ ░ ▒  ░ ░ ░ ▒  ░      ░        ░       ░  ░░ ░  ░░   ░    ░      ░   
           ░         ░ ░      ░ ░         ░                ░  ░  ░   ░        ░  ░   ░  ░
                                                                                         
";

            bool inRoomThree = true;
            while (inRoomThree)
            {
                Console.WriteLine(title);
                Console.WriteLine("\n\tAs you emerge into this new space you get a sense of safety. There is not much in this room other than some\n" +
                    "\tbracketed torches hung from the walls and illuminated with a subtle flame, a carpet that stretches out in the middle of the\n" +
                    "\troom, a blue door, a green door, and an ornate golden door." +
                    "\n" +
                    "\tWhat would you like to do?\n" +
                    "\n" +
                    "\t1. Rules\n" +
                    "\t2. Inventory\n" +
                    "\t3. Exit");

                string input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "1":
                        // Rules
                        DisplayRules();
                        Console.WriteLine("\tPress any key to continue...");
                        break;
                    case "2":
                        // Inventory
                        Inventory();
                        Console.WriteLine("\tPress any key to continue...");
                        break;
                    case "3":
                        // Exit
                        return;
                    case "goto blue door":
                        // goto blue door
                        Console.Clear();
                        Console.WriteLine("\n\tYou walk up to the blue door. You are closer to it than you were before.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "look at blue door":
                        // look at blue door
                        Console.Clear();
                        Console.WriteLine("\n\tYou stare at the blue door. The door is of normal size possibly an ancient wood work of years past.\n" +
                            "\tIt is weatherd and fading but its blue coat of paint still exists. The handle has begun to rust and it's hinges look\n" +
                            "\tlook as if they have not moved in a very long time.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "open blue door":
                        // open blue door
                        OpenDoor();
                        Console.ReadKey();
                        inRoomThree = false;
                        RoomFour();
                        break;
                    case "pick up blue door":
                        // pick up blue door
                        Console.Clear();
                        Console.WriteLine("\n\tYou simply are not strong enough to pick up the door. Maybe because it still resides within\n" +
                            "\tits frame.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "goto green door":
                        // goto green door
                        Console.Clear();
                        Console.WriteLine("\n\tYou walk up to the green door. You are closer to it than you were before.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "look at green door":
                        // look at green door
                        Console.Clear();
                        Console.WriteLine("\n\tYou stare at the green door. The door is of normal size possibly an ancient wood work of years past.\n" +
                            "\tIt is weatherd and fading but its green coat of paint still exists. The handle has begun to rust and it's hinges look\n" +
                            "\tlook as if they have not moved in a very long time.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "open green door":
                        // open green door
                        OpenDoor();
                        Console.ReadKey();
                        inRoomThree = false;
                        RoomTwo();
                        break;
                    case "pick up green door":
                        // pick up green door
                        Console.Clear();
                        Console.WriteLine("\n\tYou simply are not strong enough to pick up the door. Maybe because it still resides within its frame.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "goto golden door":
                    case "look at golden door":
                        Console.Clear();
                        Console.WriteLine("\n\tYou walk over to the golden door. It's semi reflective gold reflecting the flickering torch light\n" +
                            "\tin the room behind you. Ornate craftsmenship covers the piece with runic letters inscribed over it. There is\n" +
                            "\ta key hole and a slit you can peer through.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n\tYou peer through the hole and can see a mound of treasure, gems, rubies, gold coins, trinkets\n" +
                            "\tand other various items. There also looks to be an ancient sword unlike anything you have ever seen before.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "golden door":
                    case "open golden door":
                    case "gold door":
                        Console.Clear();
                        inRoomThree = false;
                        DeathRoom();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\n\tPlease enter a valid option.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                }
                //Console.WriteLine("\n\tPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // Room Four - blue door
        private void RoomFour()
        {
            Console.Clear();
            string title = @"
        
         ██▀███   ▒█████   ▒█████   ███▄ ▄███▓     █████▒▒█████   █    ██  ██▀███  
        ▓██ ▒ ██▒▒██▒  ██▒▒██▒  ██▒▓██▒▀█▀ ██▒   ▓██   ▒▒██▒  ██▒ ██  ▓██▒▓██ ▒ ██▒
        ▓██ ░▄█ ▒▒██░  ██▒▒██░  ██▒▓██    ▓██░   ▒████ ░▒██░  ██▒▓██  ▒██░▓██ ░▄█ ▒
        ▒██▀▀█▄  ▒██   ██░▒██   ██░▒██    ▒██    ░▓█▒  ░▒██   ██░▓▓█  ░██░▒██▀▀█▄  
        ░██▓ ▒██▒░ ████▓▒░░ ████▓▒░▒██▒   ░██▒   ░▒█░   ░ ████▓▒░▒▒█████▓ ░██▓ ▒██▒
        ░ ▒▓ ░▒▓░░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░   ░  ░    ▒ ░   ░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ░ ▒▓ ░▒▓░
          ░▒ ░ ▒░  ░ ▒ ▒░   ░ ▒ ▒░ ░  ░      ░    ░       ░ ▒ ▒░ ░░▒░ ░ ░   ░▒ ░ ▒░
          ░░   ░ ░ ░ ░ ▒  ░ ░ ░ ▒  ░      ░       ░ ░   ░ ░ ░ ▒   ░░░ ░ ░   ░░   ░ 
           ░         ░ ░      ░ ░         ░                 ░ ░     ░        ░     
                                                                                   
        
";

            bool inRoomFour = true;
            while (inRoomFour)
            {
                Console.WriteLine(title);
                Console.WriteLine("\n\tAs you emerge into this new space you get a sense of safety. There is not much in this room other than some\n" +
                    "\tbracketed torches hung from the walls and illuminated with a subtle flame, a carpet that stretches out in the middle of the\n" +
                    "\troom, a red door, a brown door, and a metal door." +
                    "\n" +
                    "\tWhat would you like to do?\n" +
                    "\n" +
                    "\t1. Rules\n" +
                    "\t2. Inventory\n" +
                    "\t3. Exit");

                string input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "1":
                        // Rules
                        DisplayRules();
                        Console.WriteLine("\tPress any key to continue...");
                        break;
                    case "2":
                        // Inventory
                        Inventory();
                        Console.WriteLine("\tPress any key to continue...");
                        break;
                    case "3":
                        // Exit
                        return;
                    case "goto red door":
                        // goto red door
                        Console.Clear();
                        Console.WriteLine("\n\tYou walk up to the red door. You are closer to it than you were before.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "look at red door":
                        // look at red door
                        Console.Clear();
                        Console.WriteLine("\n\tYou stare at the red door. The door is of normal size possibly an ancient wood work of years past.\n" +
                            "\tIt is weatherd and fading but its red coat of paint still exists. The handle has begun to rust and it's hinges look\n" +
                            "\tlook as if they have not moved in a very long time.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "pick up red door":
                        // pick up red door
                        Console.Clear();
                        Console.WriteLine("\n\tYou simply are not strong enough to pick up the door. Maybe because it still resides within\n" +
                            "\tits frame.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "open red door":
                        OpenDoor();
                        Console.ReadKey();
                        inRoomFour = false;
                        RoomOne();
                        break;
                    case "goto brown door":
                        // goto brown door
                        Console.Clear();
                        Console.WriteLine("\n\tYou walk up to the brown door. You are closer to it than you were before.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "look at brown door":
                        // look at brown door
                        Console.Clear();
                        Console.WriteLine("\n\tYou stare at the brown door. The door is of normal size possibly an ancient wood work of years past.\n" +
                            "\tIt is weatherd and fading but its brown coat of paint still exists. The handle has begun to rust and it's hinges look\n" +
                            "\tlook as if they have not moved in a very long time.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "pick up brown door":
                        // pick up brown door
                        Console.Clear();
                        Console.WriteLine("\n\tYou simply are not strong enough to pick up the door. Maybe because it still resides within\n" +
                            "\tits frame.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "open brown door":
                        // open brown door
                        OpenDoor();
                        Console.ReadKey();
                        inRoomFour = false;
                        RoomThree();
                        break;
                    case "look at metal door":
                    case "goto metal door":
                    case "metal door":
                        Console.Clear();
                        Console.WriteLine("\n\tYou walk over to the metal door, the door looks to be secured very well and upon closer inspection\n" +
                            "\tyou see runic letters inscribed on its surface. You assume this is to ward off those who wish to enter. You also\n" +
                            "\tsee a combination lock that takes in three numbers.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                    case "open metal door":
                        Console.Clear();
                        Console.WriteLine("\n\tYou walk over to the metal door, you attempt to open it but it is locked. It seems to take a\n" +
                            "\tcombination of three numbers.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        Console.ReadKey();
                        inRoomFour = false;
                        ComboDoor();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\n\tPlease enter a valid option.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        break;
                }
                // Console.WriteLine("\n\tPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // Combo Door
        private void ComboDoor()
        {
            Console.Clear();
            bool atComboDoor = true;
            while (atComboDoor)
            {
                Console.WriteLine("\n\tYou look at the combination lock that takes an input of three numbers.\n" +
                    "\n" +
                    "\tWhat would you like to do?\n" +
                    "\n" +
                    "\t1. Rules\n" +
                    "\t2. Inventory\n" +
                    "\t3. Exit");

                string input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "1":
                        // Rules
                        DisplayRules();
                        Console.WriteLine("\tPress any key to continue...");
                        break;
                    case "2":
                        // Inventory
                        Inventory();
                        Console.WriteLine("\tPress any key to continue...");
                        break;
                    case "3":
                        // Exit
                        return;
                    case "252":
                        // Boss Room
                        Console.Clear();
                        Console.WriteLine("\n\tAs you enter the final digit an audible click is heard. The door recesses into the frame of\n" +
                            "\tthe wall and pulls away. The room is dark as you walk into it, after taking several steps the metal door\n" +
                            "\tslas shut and you hear its mechanisms lock.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n\tThe illuminates with ethereal torches that cascade around the exterior walls. A ritual styled runes\n" +
                            "\tlight ablaze on the floor. They reveal a spectral like entity in the middle of the room.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                        atComboDoor = false;
                        Console.ReadKey();
                        Console.Clear();
                        BossRoom();
                        break;
                    default:
                        //again:
                        Console.Clear();
                        Console.WriteLine("\n\tThat wasn't right.\n" +
                            "\n" +
                            "\tTry again? [y]es or [n]o.");
                        string answer = Console.ReadLine();
                        if (answer == "y" || answer == "yes")
                        {
                            ComboDoor();
                        }
                        else
                        {
                            atComboDoor = false;
                            RoomFour();
                        }
                        break;
                }
                Console.WriteLine("\n\tPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // Boss Room
        private void BossRoom()
        {
            Console.Clear();
            string title = @"
        
          █████▒██▓ ███▄    █  ▄▄▄       ██▓        ██▀███   ▒█████   ▒█████   ███▄ ▄███▓
        ▓██   ▒▓██▒ ██ ▀█   █ ▒████▄    ▓██▒       ▓██ ▒ ██▒▒██▒  ██▒▒██▒  ██▒▓██▒▀█▀ ██▒
        ▒████ ░▒██▒▓██  ▀█ ██▒▒██  ▀█▄  ▒██░       ▓██ ░▄█ ▒▒██░  ██▒▒██░  ██▒▓██    ▓██░
        ░▓█▒  ░░██░▓██▒  ▐▌██▒░██▄▄▄▄██ ▒██░       ▒██▀▀█▄  ▒██   ██░▒██   ██░▒██    ▒██ 
        ░▒█░   ░██░▒██░   ▓██░ ▓█   ▓██▒░██████▒   ░██▓ ▒██▒░ ████▓▒░░ ████▓▒░▒██▒   ░██▒
         ▒ ░   ░▓  ░ ▒░   ▒ ▒  ▒▒   ▓▒█░░ ▒░▓  ░   ░ ▒▓ ░▒▓░░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░   ░  ░
         ░      ▒ ░░ ░░   ░ ▒░  ▒   ▒▒ ░░ ░ ▒  ░     ░▒ ░ ▒░  ░ ▒ ▒░   ░ ▒ ▒░ ░  ░      ░
         ░ ░    ▒ ░   ░   ░ ░   ░   ▒     ░ ░        ░░   ░ ░ ░ ░ ▒  ░ ░ ░ ▒  ░      ░   
                ░           ░       ░  ░    ░  ░      ░         ░ ░      ░ ░         ░   
                                                                                         
        
";

            bool inBossRoom = true;
            while (inBossRoom)
            {
                Console.WriteLine(title);
                Console.WriteLine("\n\tStanding before the spectral entity you feel tensions rise.");
                if (_hasWeapon)
                {
                    Console.WriteLine("\n\tArmed with the ancient sword you grabbed earlier its runes begin to emflame. The specter shrieks in\n" +
                        "\tits prescence. You unleash a mighty swing and the specter is slain.\n" +
                        "\n" +
                        "\tWhile standing triumphant over the specters corpse you see another door. This one you can see the sun beating through.\n" +
                        "\n" +
                        "\tPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("\n\tYou walk to the door, open it and walk through. You have escaped this nightmare!\n" +
                        "\n" +
                        "\tPress any key to continue...");
                    Console.ReadKey();
                    inBossRoom = false;
                    Menu();
                }
                else
                {
                    Console.WriteLine("\n\tArmed with nothing but your fists you await for the specter to dash towards you. Instead it\n" +
                        "\tvanishes from your sight and reappears behind you. It shrieks a harrowing scream, it brandishes ethereal like claws\n" +
                        "\tand impales you. You feel its cold claws enter your body and begin to fade.\n" +
                        "\n" +
                        "\tPress any key to continue...\n");
                    Console.ReadKey();
                    Console.WriteLine("\tIt leans in close and shouts...");
                    Thread.Sleep(5000); //wait 5 seconds
                    Console.Clear();
                    BloodForTheBloodGod();
                    Thread.Sleep(5000); //wait 5 seconds
                    Console.Clear();
                    Console.WriteLine("\n\tYou have died...\n" +
                                "\n" +
                                "\tPress any key to return to main menu.");
                    Console.ReadKey();
                    inBossRoom = false;
                    Menu();
                }
            }
        }

        // Death Room
        private void DeathRoom()
        {
            bool inRoomDeathRoom = true;
            while (inRoomDeathRoom)
            {
                if (_hasKey && _hasWeapon)
                {
                    DeathRoomWithSword();
                }
                else if (_hasKey)
                {
                    DeathRoomWithKey();
                }
                else
                {
                    Console.WriteLine("\n\tThis door seems to be locked and requires some sort of key.\n" +
                            "\n" +
                            "\tYou need a key to open this door, you START to see RED as your frustration builds.\n" +
                            "\n" +
                            "\tPress any key to continue...");
                    inRoomDeathRoom = false;
                    Console.ReadKey();
                    Console.Clear();
                    RoomThree();
                }
            }
        }
        private void DeathRoomWithKey()
        {
            bool inRoomDeathRoom = true;
            while (inRoomDeathRoom)
            {
                if (_hasKey == true)
                {
                    Console.WriteLine(@"
        
        ▄▄▄█████▓ ██▀███  ▓█████ ▄▄▄        ██████  █    ██  ██▀███  ▓█████ 
        ▓  ██▒ ▓▒▓██ ▒ ██▒▓█   ▀▒████▄    ▒██    ▒  ██  ▓██▒▓██ ▒ ██▒▓█   ▀ 
        ▒ ▓██░ ▒░▓██ ░▄█ ▒▒███  ▒██  ▀█▄  ░ ▓██▄   ▓██  ▒██░▓██ ░▄█ ▒▒███   
        ░ ▓██▓ ░ ▒██▀▀█▄  ▒▓█  ▄░██▄▄▄▄██   ▒   ██▒▓▓█  ░██░▒██▀▀█▄  ▒▓█  ▄ 
          ▒██▒ ░ ░██▓ ▒██▒░▒████▒▓█   ▓██▒▒██████▒▒▒▒█████▓ ░██▓ ▒██▒░▒████▒
          ▒ ░░   ░ ▒▓ ░▒▓░░░ ▒░ ░▒▒   ▓▒█░▒ ▒▓▒ ▒ ░░▒▓▒ ▒ ▒ ░ ▒▓ ░▒▓░░░ ▒░ ░
            ░      ░▒ ░ ▒░ ░ ░  ░ ▒   ▒▒ ░░ ░▒  ░ ░░░▒░ ░ ░   ░▒ ░ ▒░ ░ ░  ░
          ░        ░░   ░    ░    ░   ▒   ░  ░  ░   ░░░ ░ ░   ░░   ░    ░   
                    ░        ░  ░     ░  ░      ░     ░        ░        ░  ░
                      ██▀███   ▒█████   ▒█████   ███▄ ▄███▓                 
                     ▓██ ▒ ██▒▒██▒  ██▒▒██▒  ██▒▓██▒▀█▀ ██▒                 
                     ▓██ ░▄█ ▒▒██░  ██▒▒██░  ██▒▓██    ▓██░                 
                     ▒██▀▀█▄  ▒██   ██░▒██   ██░▒██    ▒██                  
                     ░██▓ ▒██▒░ ████▓▒░░ ████▓▒░▒██▒   ░██▒                 
                     ░ ▒▓ ░▒▓░░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░   ░  ░                 
                       ░▒ ░ ▒░  ░ ▒ ▒░   ░ ▒ ▒░ ░  ░      ░                 
                       ░░   ░ ░ ░ ░ ▒  ░ ░ ░ ▒  ░      ░                    
                        ░         ░ ░      ░ ░         ░                    
                                                                            

            ");
                    Console.WriteLine("\n\tYou insert the golden key you found in the first room, with a simple turn you hear a very\n" +
                      "\taudible click. The door recesses into the frame of the wall and pulls away. Before you, you see all the\n" +
                      "\ttreasure and the ancient sword.\n");

                    Console.WriteLine("\tWhat would you like to do?\n" +
                        "\n" +
                    "\t1. Rules\n" +
                    "\t2. Inventory\n" +
                    "\t3. Exit");

                    string input = Console.ReadLine();

                    switch (input.ToLower())
                    {
                        case "1":
                            // Rules
                            DisplayRules();
                            Console.WriteLine("\tPress any key to continue...");
                            break;
                        case "2":
                            // Inventory
                            Inventory();
                            Console.WriteLine("\tPress any key to continue...");
                            break;
                        case "3":
                            // Exit
                            return;
                        case "gold":
                        case "pick up treasure":
                        case "treasure":
                        case "pick up gold":
                            Console.Clear();
                            Console.WriteLine("\n\tYou give in to temptation and dart quickly for anything that is shiny or valuable.\n" +
                                "\tYou begin to bask in all this wealth that you have claimed for your own. As you are enjoying untold riches\n" +
                                "\tyou feel the floor beneath you begin to give way. You try your best to scramble back up to your feet and\n" +
                                "\tmake for the door but it closes before you could reach it.\n" +
                                "\n" +
                                "\tPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("\n\tThe floor opens up to below, the gold coins begin to clatter beneath you as you slowly begin\n" +
                                "\tto drift into the dark abyss. You can hold yourself up no longer and begin to plummit.\n" +
                                "\n" +
                                "\tAs you near what you could only assume is the bottom of this pit you are met with the jagged metal edges of\n" +
                                "\tupright blades and skewers. The momentum of your fall comes to a quick stop as you feel the burning sensation\n" +
                                "\tof being skewered alive. You let out a blood gurgling growl as the you begin to cough up blood.\n" +
                                "\n" +
                                "\tIn your final moments you think to yourself \"Maybe it was not best to give into temptation and greed\"\n" +
                                "\tas you lay there struggling to keep consciousness a shadowy figure reveals itself to you.\n" +
                                "\n" +
                                "\tPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("\n\tThe specter like creature moves in close and grasps your back, it's cold touch could bring\n" +
                                "\ton death itself. It leans in and whispers...");
                            Thread.Sleep(5000); //wait 5 seconds
                            BloodForTheBloodGod();
                            Thread.Sleep(10000); //wait 10 seconds
                            Console.Clear();
                            Console.WriteLine("\n\tYou have died...\n" +
                                "\n" +
                                "\tPress any key to return to main menu.");
                            Console.ReadKey();
                            Menu();
                            break;
                        case "sword":
                        case "pick up sword":
                        case "ancient sword":
                        case "pick up ancient sword":
                            Console.Clear();
                            Console.WriteLine("\n\tYou only inch in the room and grab the ancient sword.");
                            _hasWeapon = true;
                            Console.WriteLine("\n\n\tYou add the sword to your inventory, you have a feeling this will come in handy later.\n" +
                                "\n" +
                                "\tYou feel it best to come back for the treasure later.\n" +
                                "\n" +
                                "\tPress any key to continue...");
                            Console.ReadKey();
                            inRoomDeathRoom = false;
                            DeathRoomWithSword();
                            break;
                        case "go back":
                        case "back":
                        case "leave":
                            Console.Clear();
                            Console.WriteLine("\n\tYou leave the room.");
                            inRoomDeathRoom = false;
                            RoomThree();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("\n\tPlease enter a valid option.\n" +
                                "\n" +
                                "\tPress any key to continue...");
                            break;
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\n\tThis door seems to be locked and requires some sort of key.\n" +
                        "\n" +
                        "\tYou need a key to open this door, you START to see RED as your frustration builds.\n" +
                        "\n" +
                        "\tPress any key to continue...");
                    inRoomDeathRoom = false;
                    Console.ReadKey();
                    Console.Clear();
                    RoomThree();
                }
            }
        }
        private void DeathRoomWithSword()
        {
            bool inRoomDeathRoom = true;
            while (inRoomDeathRoom)
            {
                if (_hasKey == true)
                {
                    Console.WriteLine(@"
        
        ▄▄▄█████▓ ██▀███  ▓█████ ▄▄▄        ██████  █    ██  ██▀███  ▓█████ 
        ▓  ██▒ ▓▒▓██ ▒ ██▒▓█   ▀▒████▄    ▒██    ▒  ██  ▓██▒▓██ ▒ ██▒▓█   ▀ 
        ▒ ▓██░ ▒░▓██ ░▄█ ▒▒███  ▒██  ▀█▄  ░ ▓██▄   ▓██  ▒██░▓██ ░▄█ ▒▒███   
        ░ ▓██▓ ░ ▒██▀▀█▄  ▒▓█  ▄░██▄▄▄▄██   ▒   ██▒▓▓█  ░██░▒██▀▀█▄  ▒▓█  ▄ 
          ▒██▒ ░ ░██▓ ▒██▒░▒████▒▓█   ▓██▒▒██████▒▒▒▒█████▓ ░██▓ ▒██▒░▒████▒
          ▒ ░░   ░ ▒▓ ░▒▓░░░ ▒░ ░▒▒   ▓▒█░▒ ▒▓▒ ▒ ░░▒▓▒ ▒ ▒ ░ ▒▓ ░▒▓░░░ ▒░ ░
            ░      ░▒ ░ ▒░ ░ ░  ░ ▒   ▒▒ ░░ ░▒  ░ ░░░▒░ ░ ░   ░▒ ░ ▒░ ░ ░  ░
          ░        ░░   ░    ░    ░   ▒   ░  ░  ░   ░░░ ░ ░   ░░   ░    ░   
                    ░        ░  ░     ░  ░      ░     ░        ░        ░  ░
                      ██▀███   ▒█████   ▒█████   ███▄ ▄███▓                 
                     ▓██ ▒ ██▒▒██▒  ██▒▒██▒  ██▒▓██▒▀█▀ ██▒                 
                     ▓██ ░▄█ ▒▒██░  ██▒▒██░  ██▒▓██    ▓██░                 
                     ▒██▀▀█▄  ▒██   ██░▒██   ██░▒██    ▒██                  
                     ░██▓ ▒██▒░ ████▓▒░░ ████▓▒░▒██▒   ░██▒                 
                     ░ ▒▓ ░▒▓░░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░   ░  ░                 
                       ░▒ ░ ▒░  ░ ▒ ▒░   ░ ▒ ▒░ ░  ░      ░                 
                       ░░   ░ ░ ░ ░ ▒  ░ ░ ░ ▒  ░      ░                    
                        ░         ░ ░      ░ ░         ░                    
                                                                            

            ");
                    Console.WriteLine("\n\tWith Sword in hand you gaze at the gold around you.");

                    Console.WriteLine("\tWhat would you like to do?\n" +
                        "\n" +
                    "\t1. Rules\n" +
                    "\t2. Inventory\n" +
                    "\t3. Exit");

                    string input = Console.ReadLine();

                    switch (input.ToLower())
                    {
                        case "1":
                            // Rules
                            DisplayRules();
                            Console.WriteLine("\tPress any key to continue...");
                            break;
                        case "2":
                            // Inventory
                            Inventory();
                            Console.WriteLine("\tPress any key to continue...");
                            break;
                        case "3":
                            // Exit
                            return;
                        case "gold":
                        case "pick up treasure":
                        case "treasure":
                        case "pick up gold":
                            Console.Clear();
                            Console.WriteLine("\n\tYou give in to temptation and dart quickly for anything that is shiny or valuable.\n" +
                                "\tYou begin to bask in all this wealth that you have claimed for your own. As you are enjoying untold riches\n" +
                                "\tyou feel the floor beneath you begin to give way. You try your best to scramble back up to your feet and\n" +
                                "\tmake for the door but it closes before you could reach it.\n" +
                                "\n" +
                                "\tPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("\n\tThe floor opens up to below, the gold coins begin to clatter beneath you as you slowly begin\n" +
                                "\tto drift into the dark abyss. You can hold yourself up no longer and begin to plummit.\n" +
                                "\n" +
                                "\tAs you near what you could only assume is the bottom of this pit you are met with the jagged metal edges of\n" +
                                "\tupright blades and skewers. The momentum of your fall comes to a quick stop as you feel the burning sensation\n" +
                                "\tof being skewered alive. You let out a blood gurgling growl as the you begin to cough up blood.\n" +
                                "\n" +
                                "\tIn your final moments you think to yourself \"Maybe it was not best to give into temptation and greed\"\n" +
                                "\tas you lay there struggling to keep consciousness a shadowy figure reveals itself to you.\n" +
                                "\n" +
                                "\tPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("\n\tThe specter like creature moves in close and grasps your back, it's cold touch could bring\n" +
                                "\ton death itself. It leans in and whispers...");
                            Thread.Sleep(5000); //wait 5 seconds
                            BloodForTheBloodGod();
                            Thread.Sleep(10000); //wait 10 seconds
                            Console.Clear();
                            Console.WriteLine("\n\tYou have died...\n" +
                                "\n" +
                                "\tPress any key to return to main menu.");
                            Console.ReadKey();
                            Menu();
                            break;
                        case "go back":
                        case "back":
                        case "leave":
                            Console.Clear();
                            Console.WriteLine("\n\tYou leave the room.");
                            inRoomDeathRoom = false;
                            RoomThree();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("\n\tPlease enter a valid option.\n" +
                                "\n" +
                                "\tPress any key to continue...");
                            break;
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\n\tThis door seems to be locked and requires some sort of key.\n" +
                        "\n" +
                        "\tYou need a key to open this door, you START to see RED as your frustration builds.\n" +
                        "\n" +
                        "\tPress any key to continue...");
                    inRoomDeathRoom = false;
                    Console.ReadKey();
                    Console.Clear();
                    RoomThree();
                }
            }
        }


        // Helper Methods
        private void OpenDoor()
        {
            Console.Clear();
            Console.WriteLine("\n\tYou twist the handle of the door and push the door open and move into the room beyond.\n" +
                "\n" +
                "\tPress any key to continue...");
        }

        private void Inventory()
        {
            Console.Clear();
            Console.WriteLine("\n\tYou rummage through your pockets and check your belongings.");
            if (_hasKey)
            {
                Console.WriteLine("\n\tGolden Key");
            }
            if (_hasWeapon)
            {
                Console.WriteLine("\n\tSword");
            }
            if (_hasRiddle)
            {
                Console.WriteLine("\n\tBook");
            }
            if (_hasKey == false && _hasWeapon == false && _hasRiddle == false)
            {
                Console.WriteLine("\n\tYou have nothing in your inventory.");
            }
        }

        private void Book()
        {
            Console.Clear();
            string book = @"
                __________________   __________________
            .-/|                  \ /                  |\-.
            ||||                   |                   ||||
            ||||                   |    Darkest Day    ||||
            ||||    --==*==--      |    Twenty First   ||||
            ||||                   |   Times that of   ||||
            ||||                   |      December     ||||
            ||||                   |                   ||||
            ||||                   |                   ||||
            ||||                   |     --==*==--     ||||
            ||||                   |                   ||||
            ||||                   |                   ||||
            ||||__________________ | __________________||||
            ||/===================\|/===================\||
            `--------------------~___~-------------------''
";
            Console.WriteLine(book);
            Console.WriteLine("\n" +
                "\tPress any key to continue...");
        }

        private void BloodForTheBloodGod()
        {
            Console.Clear();
            string blood = @"
        
              ▄▄▄▄    ██▓     ▒█████   ▒█████  ▓█████▄      
             ▓█████▄ ▓██▒    ▒██▒  ██▒▒██▒  ██▒▒██▀ ██▌     
             ▒██▒ ▄██▒██░    ▒██░  ██▒▒██░  ██▒░██   █▌     
             ▒██░█▀  ▒██░    ▒██   ██░▒██   ██░░▓█▄   ▌     
             ░▓█  ▀█▓░██████▒░ ████▓▒░░ ████▓▒░░▒████▓      
             ░▒▓███▀▒░ ▒░▓  ░░ ▒░▒░▒░ ░ ▒░▒░▒░  ▒▒▓  ▒      
             ▒░▒   ░ ░ ░ ▒  ░  ░ ▒ ▒░   ░ ▒ ▒░  ░ ▒  ▒      
              ░    ░   ░ ░   ░ ░ ░ ▒  ░ ░ ░ ▒   ░ ░  ░      
              ░          ░  ░    ░ ░      ░ ░     ░         
                   ░                            ░           
          █████▒▒█████   ██▀███     ▄▄▄█████▓ ██░ ██ ▓█████ 
        ▓██   ▒▒██▒  ██▒▓██ ▒ ██▒   ▓  ██▒ ▓▒▓██░ ██▒▓█   ▀ 
        ▒████ ░▒██░  ██▒▓██ ░▄█ ▒   ▒ ▓██░ ▒░▒██▀▀██░▒███   
        ░▓█▒  ░▒██   ██░▒██▀▀█▄     ░ ▓██▓ ░ ░▓█ ░██ ▒▓█  ▄ 
        ░▒█░   ░ ████▓▒░░██▓ ▒██▒     ▒██▒ ░ ░▓█▒░██▓░▒████▒
         ▒ ░   ░ ▒░▒░▒░ ░ ▒▓ ░▒▓░     ▒ ░░    ▒ ░░▒░▒░░ ▒░ ░
         ░       ░ ▒ ▒░   ░▒ ░ ▒░       ░     ▒ ░▒░ ░ ░ ░  ░
         ░ ░   ░ ░ ░ ▒    ░░   ░      ░       ░  ░░ ░   ░   
                   ░ ░     ░                  ░  ░  ░   ░  ░
              ▄▄▄▄    ██▓     ▒█████   ▒█████  ▓█████▄      
             ▓█████▄ ▓██▒    ▒██▒  ██▒▒██▒  ██▒▒██▀ ██▌     
             ▒██▒ ▄██▒██░    ▒██░  ██▒▒██░  ██▒░██   █▌     
             ▒██░█▀  ▒██░    ▒██   ██░▒██   ██░░▓█▄   ▌     
             ░▓█  ▀█▓░██████▒░ ████▓▒░░ ████▓▒░░▒████▓      
             ░▒▓███▀▒░ ▒░▓  ░░ ▒░▒░▒░ ░ ▒░▒░▒░  ▒▒▓  ▒      
             ▒░▒   ░ ░ ░ ▒  ░  ░ ▒ ▒░   ░ ▒ ▒░  ░ ▒  ▒      
              ░    ░   ░ ░   ░ ░ ░ ▒  ░ ░ ░ ▒   ░ ░  ░      
              ░          ░  ░    ░ ░      ░ ░     ░         
                   ░   ▄████  ▒█████  ▓█████▄   ░           
                      ██▒ ▀█▒▒██▒  ██▒▒██▀ ██▌              
                     ▒██░▄▄▄░▒██░  ██▒░██   █▌              
                     ░▓█  ██▓▒██   ██░░▓█▄   ▌              
                     ░▒▓███▀▒░ ████▓▒░░▒████▓               
                      ░▒   ▒ ░ ▒░▒░▒░  ▒▒▓  ▒               
                       ░   ░   ░ ▒ ▒░  ░ ▒  ▒               
                     ░ ░   ░ ░ ░ ░ ▒   ░ ░  ░               
                           ░     ░ ░     ░                  
                                       ░                    

            ";
            Console.WriteLine(blood);
        }

        // Exit Method - bc game loops through every loop console.readkey before exiting
        private void Exit()
        {
            Environment.Exit(0);
        }
    }
}
