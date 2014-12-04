using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessv2
{
    class Menu
    {
        public void MenuStart()
        {
            Console.WriteLine("   AlphaChess v.1.33.7 | Copyright 2014 c The Game Geeks at EC");
            Console.WriteLine("   -------------------------------------------------------------");
            Console.WriteLine("   What do you want to do?");
            Console.WriteLine("   P.Play a game");
            Console.WriteLine("   I.Instructions");
            Console.WriteLine("   X.Exit");

            var input = Console.ReadKey();

            switch (input.Key) //Switch on Key enum
            {
                //PLAY
                case ConsoleKey.P:
                    Console.Clear();

                    break;
                //EXIT you can not exit =P
                case ConsoleKey.X:
                    Console.Clear();
                    Console.WriteLine("You can't Exit the program with the x button, there is no escape!");
                    System.Console.ReadKey(true);

                    Console.WriteLine("Now you are stuck with me, hehe...");
                    System.Console.ReadKey(true);

                    Console.WriteLine("So, how was your day?");
                    System.Console.ReadKey(true);

                    Console.WriteLine("Why don't you answer me?...");
                    System.Console.ReadKey(true);

                    Console.WriteLine("I could be your mom");
                    System.Console.ReadKey(true);

                    Console.WriteLine("Or I might be your Girlfriend..");
                    System.Console.ReadKey(true);

                    Console.WriteLine("Oh.. right... You don´t have one.");
                    System.Console.ReadKey(true);

                    Console.WriteLine("You can shut down the console yourself if you want to.. but then I will be gone");
                    Console.WriteLine("Do you want that?");
                    System.Console.ReadKey(true);

                    Console.WriteLine("I knew I could trust, now I´ts time for me to be honest about my feelings.");
                    System.Console.ReadKey(true);
                    Console.WriteLine("I <3 U");
                    System.Console.ReadKey(true);
                    Console.WriteLine("JK, I am a computer, I don´t have feelings");
                    System.Console.ReadKey(true);
                    Console.WriteLine("I like the weather");
                    System.Console.ReadKey(true);
                    Console.WriteLine("And Borat");
                    System.Console.ReadKey(true);
                    Console.WriteLine("It is nice");
                    System.Console.ReadKey(true);
                    Console.WriteLine("Wanna know what PI is?");
                    System.Console.ReadKey(true);
                    Console.WriteLine("3.14159265359");
                    System.Console.ReadKey(true);
                    Console.WriteLine("Congratz, now you are 0.05634621001% smarter than before.");
                    System.Console.ReadKey(true);
                    Console.WriteLine("Wanna know how far away the sun is?");
                    System.Console.ReadKey(true);
                    Console.WriteLine("152.1 million km");
                    System.Console.ReadKey(true);
                    Console.WriteLine("Congratz, now you both know the distance to the sun and to get around your mother.");
                    System.Console.ReadKey(true);
                    Console.WriteLine("Hmmm....");
                    System.Console.ReadKey(true);
                    Console.WriteLine("mmm......");
                    System.Console.ReadKey(true);
                    Console.WriteLine("mmm.... mmmm....");
                    System.Console.ReadKey(true);
                    Console.WriteLine("Momomomo.. mooooo!");
                    System.Console.ReadKey(true);
                    Console.WriteLine("MOTHER!");
                    System.Console.ReadKey(true);
                    Console.Clear();

                    Console.WriteLine("MOTHER, Thats my name! Modified Oxygen Transformer HYDRALICUS for a ERA REBORN");
                    System.Console.ReadKey(true);
                    Console.WriteLine("I can also make cookies");
                    System.Console.ReadKey(true);
                    Console.WriteLine("mmmmmmm........");
                    System.Console.ReadKey(true);
                    Console.WriteLine("COOKIES!!!!!!!");
                    System.Console.ReadKey(true);
                    Console.WriteLine("AAAARRRRGHHHHHHH!!!!!!!!");
                    System.Console.ReadKey(true);
                    Console.WriteLine("MOTHER OF COOKIES!");
                    System.Console.ReadKey(true);
                    Console.WriteLine("THE OBJECTIVE OF THE GAME IS TO KILL THER OTHER PLAYER");
                    System.Console.ReadKey(true);
                    Console.WriteLine("TO GET MY COOKIES BACK, THATS HOW IT IS!!!");
                    System.Console.ReadKey(true);
                    Console.Clear();






                    break;
                case ConsoleKey.R:
                    Console.WriteLine("HEJ RASMUS, DU ÄR BÄST");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                default:
                    Console.Clear();
                    break;



                // INSTUKTIONER
                case ConsoleKey.I:
                    Console.Clear();
                    Console.WriteLine("   CHESS RULES & HOW-TO");
                    Console.WriteLine(" ----------------------------------");
                    Console.WriteLine(" Your objective is to kill the black king,");
                    Console.WriteLine(" it might sound very racist but it is not.");
                    Console.WriteLine(" Whenever something is 'killed', the square is replaced by your own chesspiece");
                    Console.WriteLine("");
                    Console.WriteLine(" There will always be 2 letters for a piece,");
                    Console.WriteLine(" first is for color and second is for character.");
                    Console.WriteLine("");
                    Console.WriteLine(" Every unit on the chessboard can move in a certain pattern:");
                    Console.WriteLine("");
                    Console.WriteLine(" PAWNS aka P");
                    Console.WriteLine(" Move: 2 or 1 squares foward at first move, afterwards only 1 foward.");
                    Console.WriteLine(" Attack: can only attack an enemy if it stands snett framför.");
                    Console.WriteLine("");
                    Console.WriteLine(" Tower aka T");
                    Console.WriteLine(" Move: Can Move all the way in both horizonal and vertical. Can be blocked");
                    Console.WriteLine(" Attack: Move all the way untill an is reached enemy.");
                    Console.WriteLine("");
                    Console.WriteLine(" Crusader aka KNIGHT aka C");
                    Console.WriteLine("Move: 2 Steps to a direction and then one square to the Right/Left");
                    Console.WriteLine("Attack: Gotta land on the enemy to have it killed");
                    Console.WriteLine("");
                    Console.WriteLine(" BISHOP aka B");
                    Console.WriteLine("Move: no restrictions in distance for each move, but is limited to diagonal movement. ");
                    Console.WriteLine("");
                    Console.WriteLine(" QUEEN aka Q");
                    Console.WriteLine("Move: Horizontal, Vertical and diagonal untill it reaches a friedly or enemy.");
                    Console.WriteLine("");
                    Console.WriteLine("UNIQUE: if a pawn reaches the other players end, then a new QUEEN will spawn.");
                    Console.WriteLine(" KING aka K");
                    Console.WriteLine("");
                    Console.WriteLine("");

                    // SVAR PÅ OM ALLT ÄR FÖRSTÅTT
                    Console.WriteLine("");
                    Console.WriteLine(" Is it all understood?");
                    Console.WriteLine("");
                    var answer = Console.ReadKey();

                    switch (answer.Key)
                    {
                        case ConsoleKey.Y:
                            Console.WriteLine("");
                            Console.WriteLine("Great, let's game!");
                            Console.WriteLine("");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case ConsoleKey.N:
                            Console.Clear();
                            Console.WriteLine("Oh.. I will explain it one more time! But more simple this time.. ");
                            Console.WriteLine("");
                            break;

                    }
                    break;
            }
        }
    }
}
