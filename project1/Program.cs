/*

Brenna Hull
CWEB2010 Project 1
2/6/2020

*/

using System;

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

            //Wide-Reciever 
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

        }
    }

    public class Player
    {
        public string playerName { get; set; }
        public string playerSchool { get; set; }
        public long playerCost { get; set; }

        public int playerRanking { get; set; }

        public Player(string Name, string School, int Cost, int Ranking)
        {
            playerName = Name;
            playerSchool = School;
            playerCost = Cost;
            playerRanking = Ranking;
        }
        public override string ToString()
        {
            return String.Format($"{playerName}\r\n{playerSchool}\r\n{playerCost}");

        }

    }
}

