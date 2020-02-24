/*

Brenna Hull
CWEB2010 Project 1
2/6/2020

*/

using System;
using System.Globalization;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quarterbacks
            Player player1 = new Player("Joe Burrow", "(LSU)", 26400100, 1);

            Player player2 = new Player("Tua Tagoviloa", "(Alamabma)", 20300100, 2);

            Player player3 = new Player("Justin Herbert", "(Oregon)", 17420300, 3);

            Player player4 = new Player("Jordan Love", "(Utah St.)", 13100145, 4);

            Player player5 = new Player("Jake Fromm", "(Georgia)", 10300000, 5);

            //Running Back 
            Player player6 = new Player("D'Andre Smith", "(Georgia)", 24500100, 1);

            Player player7 = new Player("Jonathan Taylor", "(Wisconsin)", 19890200, 2); 

            Player player8 = new Player("J.X. Dobbins", "(Ohio St.)", 18700800, 3);

            Player player9 = new Player("Zack Moss", "(Utah)", 15000000, 4);

            Player player10 = new Player("Cam Akers", "(Florida St.)", 11600400, 5);

            //Wide-Receiver 
            Player player11 = new Player("CeeDee Lamb", "(Oklahoma)", 23400000, 1);

            Player player12 = new Player("Jerry Jeudy", "(Alamabma)", 21900300, 2);

            Player player13 = new Player("Tee Higgins", "(Clemson)", 19300230, 3);

            Player player14 = new Player("Henry Ruggs III", "(Alamabma)", 13400230, 4);

            Player player15 = new Player("Tyler Johnson", "(Minnesota)", 10000000, 5);

            //Defensive Lineman
            Player player16 = new Player("Chase Young", "(Ohio St.)", 26200300, 1);

            Player player17 = new Player("Derrick Brown", "(Auburn)", 22000000,2 );

            Player player18 = new Player("A.J. Epensa", "(Iowa)", 16000000, 3);

            Player player19 = new Player("Javon Kinlaw", "(So. Carolina)", 18000000, 4);

            Player player20 = new Player("Yetur Gross-Matos", "(Penn St.)", 13000000, 5);

            //Defensive Back 
            Player player21 = new Player("Jeff Okudah", "(Ohio St.)", 24000000, 1);

            Player player22 = new Player("Grant Delpit", "(LSU)", 22500249, 2);

            Player player23 = new Player("Kritian Fulton", "(LSU)", 20000100, 3);

            Player player24 = new Player("Xavier McKinney", "(Alamabma)", 16000200, 4);

            Player player25 = new Player("CJ Henderson", "(Florida)", 11899999, 5);

            //Tight Ends
            Player player26 = new Player("Cole Kmet", "(Notre Dame)", 27800900, 1);

            Player player27 = new Player("Brycen Hopkinds", "(Purdue)", 21000800, 2);

            Player player28 = new Player("Hunter Bryant", "(Washington)", 17499233, 3);

            Player player29 = new Player("Jared Pinkney", "(Vanderbilt)", 27900200, 4);

            Player player30 = new Player("Jacob Breeland", "(Oregon)", 14900333, 5);

            //Line Backers
            Player player31 = new Player("Isaiah Simmons", "(Clemson)", 22900300, 1);

            Player player32 = new Player("Kenneth Murray", "(Oklahoma)", 19000590, 2);

            Player player33 = new Player("Zach Baun", "(Wisconsin)", 18000222, 3);

            Player player34 = new Player("Akeem Davis-Gaither", "(App St.)", 12999999, 4);

            Player player35 = new Player("Troy Dye", "(Oregon)", 10000100, 5);

            //Offensive Tackles
            Player player36 = new Player("Jedrick Wills Jr.", "(Alamabma)", 23000000, 1);

            Player player37 = new Player("Andrew Thomas", "(Georgia)", 20000000, 2);

            Player player38 = new Player("Tristan Wirfs", "(Iowa)", 19400000, 3);

            Player player39 = new Player("Tyler Biadasz", "(Wisconsin)", 16200700, 4);

            Player player40 = new Player("Mekhi Becton", "(Louisville)", 15900000, 5);

            //Player information shown on screen
            Console.WriteLine("Position");
            Console.WriteLine("\n");
            Console.WriteLine($"Quarterback:\n\n\t {player1} | {player2} | {player3} | {player4} | {player5}");
            Console.WriteLine("\n");
            Console.WriteLine($"Running Back:\n\n\t {player6} | {player7} | {player8} | {player9} | {player10}");
            Console.WriteLine("\n");
            Console.WriteLine($"Wide-Receiver:\n\n\t {player11} | {player12} | {player13} | {player14} | {player15}");
            Console.WriteLine("\n");
            Console.WriteLine($"Defensive Lineman:\n\n\t {player16} | {player17} | {player18} | {player19} | {player20}");
            Console.WriteLine("\n");
            Console.WriteLine($"Defensive-Back:\n\n\t {player21} | {player22} | {player23} | {player24} | {player25}");
            Console.WriteLine("\n");
            Console.WriteLine($"Tight Ends:\n\n\t {player26} | {player27} | {player28} | {player29} | {player30}");
            Console.WriteLine("\n");
            Console.WriteLine($"Line-Backers:\n\n\t {player31} | {player32} | {player33} | {player34} | {player35}");
            Console.WriteLine("\n");
            Console.WriteLine($"Offensive Tackles:\n\n\t {player36} | {player37} | {player38} | {player39} | {player40}");
            Console.WriteLine("\n");

            Console.WriteLine("==========================================================================================================================\n");
            Console.WriteLine("To select a player, enter their last name.\n");
            
            long moneyRemaining = 95000000;
            string formattedMoneyRemaining = moneyRemaining.ToString("C0", CultureInfo.CurrentCulture);

            long moneySpent = 0;
            string formattedMoneySpent = moneySpent.ToString("C0", CultureInfo.CurrentCulture);


            for (int i = 1; i <= 5; i++)
            {
                if (moneyRemaining > 0)
                {
                    Console.WriteLine($"Please select choice number {i} or type quit or exit to get your total: ");
                    string name = Console.ReadLine();
                    
                    if (name == "Burrow")
                    {
                        moneyRemaining = moneyRemaining - player1.playerCost;
                        moneySpent = moneySpent + player1.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Tagovailoa")
                    {
                        moneyRemaining = moneyRemaining - player2.playerCost;
                        moneySpent = moneySpent + player2.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Herbert")
                    {
                        moneyRemaining = moneyRemaining - player3.playerCost;
                        moneySpent = moneySpent + player3.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Love")
                    {
                        moneyRemaining = moneyRemaining - player4.playerCost;
                        moneySpent = moneySpent + player4.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Fromm")
                    {
                        moneyRemaining = moneyRemaining - player5.playerCost;
                        moneySpent = moneySpent + player5.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Swift")
                    {
                        moneyRemaining = moneyRemaining - player6.playerCost;
                        moneySpent = moneySpent + player6.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Taylor")
                    {
                        moneyRemaining = moneyRemaining - player7.playerCost;
                        moneySpent = moneySpent + player7.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Dobbins")
                    {
                        moneyRemaining = moneyRemaining - player8.playerCost;
                        moneySpent = moneySpent + player8.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Moss")
                    {
                        moneyRemaining = moneyRemaining - player9.playerCost;
                        moneySpent = moneySpent + player9.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Akers")
                    {
                        moneyRemaining = moneyRemaining - player10.playerCost;
                        moneySpent = moneySpent + player10.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Lamb")
                    {
                        moneyRemaining = moneyRemaining - player11.playerCost;
                        moneySpent = moneySpent + player11.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Jeudy")
                    {
                        moneyRemaining = moneyRemaining - player12.playerCost;
                        moneySpent = moneySpent + player12.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Higgins")
                    {
                        moneyRemaining = moneyRemaining - player13.playerCost;
                        moneySpent = moneySpent + player13.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Ruggs" | name == "Ruggs III")
                    {
                        moneyRemaining = moneyRemaining - player14.playerCost;
                        moneySpent = moneySpent + player14.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Johnson")
                    {
                        moneyRemaining = moneyRemaining - player15.playerCost;
                        moneySpent = moneySpent + player15.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Young")
                    {
                        moneyRemaining = moneyRemaining - player16.playerCost;
                        moneySpent = moneySpent + player16.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Brown")
                    {
                        moneyRemaining = moneyRemaining - player17.playerCost;
                        moneySpent = moneySpent + player17.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Epensa")
                    {
                        moneyRemaining = moneyRemaining - player18.playerCost;
                        moneySpent = moneySpent + player18.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Kinlaw")
                    {
                        moneyRemaining = moneyRemaining - player19.playerCost;
                        moneySpent = moneySpent + player19.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Gross-Matos" | name == "Matos" | name == "Gross")
                    {
                        moneyRemaining = moneyRemaining - player20.playerCost;
                        moneySpent = moneySpent + player20.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Okudah")
                    {
                        moneyRemaining = moneyRemaining - player21.playerCost;
                        moneySpent = moneySpent + player21.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Delpit")
                    {
                        moneyRemaining = moneyRemaining - player22.playerCost;
                        moneySpent = moneySpent + player22.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Fulton")
                    {
                        moneyRemaining = moneyRemaining - player23.playerCost;
                        moneySpent = moneySpent + player23.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "McKinney")
                    {
                        moneyRemaining = moneyRemaining - player24.playerCost;
                        moneySpent = moneySpent + player24.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Henderson")
                    {
                        moneyRemaining = moneyRemaining - player25.playerCost;
                        moneySpent = moneySpent + player25.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Kmet")
                    {
                        moneyRemaining = moneyRemaining - player26.playerCost;
                        moneySpent = moneySpent + player26.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Hopkins")
                    {
                        moneyRemaining = moneyRemaining - player27.playerCost;
                        moneySpent = moneySpent + player27.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Bryant")
                    {
                        moneyRemaining = moneyRemaining - player28.playerCost;
                        moneySpent = moneySpent + player28.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Pinkney")
                    {
                        moneyRemaining = moneyRemaining - player29.playerCost;
                        moneySpent = moneySpent + player29.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Breeland")
                    {
                        moneyRemaining = moneyRemaining - player30.playerCost;
                        moneySpent = moneySpent + player30.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Simmons")
                    {
                        moneyRemaining = moneyRemaining - player31.playerCost;
                        moneySpent = moneySpent + player31.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Murray")
                    {
                        moneyRemaining = moneyRemaining - player32.playerCost;
                        moneySpent = moneySpent + player32.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Baun")
                    {
                        moneyRemaining = moneyRemaining - player33.playerCost;
                        moneySpent = moneySpent + player33.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Davis-Gaither" | name == "Gaither" | name == "Davis")
                    {
                        moneyRemaining = moneyRemaining - player34.playerCost;
                        moneySpent = moneySpent + player34.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Dye")
                    {
                        moneyRemaining = moneyRemaining - player35.playerCost;
                        moneySpent = moneySpent + player35.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Wills Jr." | name == "Wills")
                    {
                        moneyRemaining = moneyRemaining - player36.playerCost;
                        moneySpent = moneySpent + player36.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Thomas")
                    {
                        moneyRemaining = moneyRemaining - player37.playerCost;
                        moneySpent = moneySpent + player37.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Wirfs")
                    {
                        moneyRemaining = moneyRemaining - player38.playerCost;
                        moneySpent = moneySpent + player38.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Bladasz")
                    {
                        moneyRemaining = moneyRemaining - player39.playerCost;
                        moneySpent = moneySpent + player39.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "Becton")
                    {
                        moneyRemaining = moneyRemaining - player40.playerCost;
                        moneySpent = moneySpent + player40.playerCost;
                        Console.WriteLine($"You have {moneyRemaining.ToString("C0", CultureInfo.CurrentCulture)} remaining");
                    }
                    else if (name == "")
                    {

                    }
                    else if (name == "quit" | name == "exit")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, your input does not meet the set requirements. Please enter the last name of the player.");
                    }
                }else if (moneyRemaining < 10000100)
                {
                    Console.WriteLine("Sorry, you have exceeded the limit.");
                }

                Console.WriteLine("");

            } 

            Console.WriteLine($"You spent {moneySpent.ToString("C0", CultureInfo.CurrentCulture)}");
            Console.WriteLine("\n");

        }
    }

    public class Player
    {
        public string playerName { get; set; }
        public string playerSchool { get; set; }
        public long playerCost { get; set; }
        public int playerRanking { get; set; }
        public string moneyCost;


        public Player(string Name, string School, int Cost, int Ranking)
        {
            playerName = Name;
            playerSchool = School;
            playerCost = Cost;
            playerRanking = Ranking;
            moneyCost = playerCost.ToString("C0", CultureInfo.CurrentCulture);
            
        }
        public override string ToString()
        {
            return String.Format($"{playerName} {playerSchool} {moneyCost}");

        }

    }
}

