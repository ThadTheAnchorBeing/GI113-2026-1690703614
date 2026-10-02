/*
 * Student ID : 1690703614
 * Name       : Thadpong Thuedam
 * Section    : 129B
 * No.        : 36
 * Course     : GI113 Computer Programming (GI)
 */

using System;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game Title: Lost God");
            Console.WriteLine("GOD BRAIN encounters a Devil....");
            Console.WriteLine("ACTION 1 ATTACK");
            Console.WriteLine("ACTION 2 USE SKILL 1 GOD PUNCH");
            Console.WriteLine("ACTION 3 USE SKILL 2 GOD KICK");
            Console.WriteLine("ACTION 4 USE SKILL 3 GOD THUNDER");
            Console.WriteLine("ACTION 5 RUN!!!");
            Console.WriteLine("ACTION 6 USE ITEM 1 HEALTH POTION");

            Console.Write("Choose your action (1-6): ");
            bool actionOk = int.TryParse(Console.ReadLine(), out int action);

            if (actionOk == false || action < 1 || action > 6)
            {
                Console.WriteLine("Invalid action. Please choose a number between 1 and 6.");
            }
            else
            {
                Console.Write("Enter divine power (0-100): ");
                bool powerOk = int.TryParse(Console.ReadLine(), out int divinePower);

                if (powerOk == false || divinePower < 0 || divinePower > 100)
                {
                    Console.WriteLine("Invalid divine power. Please enter a number from 0 to 100.");
                }
                else if (action == 1)
                {
                    if (divinePower >= 50)
                    {
                        Console.WriteLine("God Brain strikes hard. The Devil loses 35 HP.");
                    }
                    else
                    {
                        Console.WriteLine("God Brain strikes weakly. The Devil loses 15 HP.");
                    }
                }
                else if (action == 2)
                {
                    if (divinePower >= 50)
                    {
                        Console.WriteLine("God Punch lands. The Devil is stunned and loses 45 HP.");
                    }
                    else
                    {
                        Console.WriteLine("God Punch is too light. The Devil barely flinches.");
                    }
                }
                else if (action == 3)
                {
                    if (divinePower >= 50)
                    {
                        Console.WriteLine("God Kick sends the Devil flying. The Devil loses 40 HP.");
                    }
                    else
                    {
                        Console.WriteLine("God Kick misses. The Devil laughs.");
                    }
                }
                else if (action == 4)
                {
                    if (divinePower >= 50)
                    {
                        Console.WriteLine("God Thunder hits. The Devil is burned and loses 50 HP.");
                    }
                    else
                    {
                        Console.WriteLine("God Thunder fizzles. Sparks fall to the ground.");
                    }
                }
                else if (action == 5)
                {
                    if (divinePower >= 50)
                    {
                        Console.WriteLine("God Brain escapes. The Devil cannot follow.");
                    }
                    else
                    {
                        Console.WriteLine("God Brain tries to run but is too weak. The Devil blocks the path.");
                    }
                }
                else
                {
                    if (divinePower >= 50)
                    {
                        Console.WriteLine("God Brain drinks a potion. Hero HP is now 120.");
                    }
                    else
                    {
                        Console.WriteLine("The potion is almost empty. Hero HP is now 85.");
                    }
                }
            }
        }
    }
}
