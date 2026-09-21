namespace Lab06

{
    internal class Program
    {
        static void Main(string[] args)

        {
            // int lives = 0;

            //if (lives == 0)
            //{
            //     Console.WriteLine("Game Over!");
            // }
            //else
            //{
            //  Console.WriteLine("Continue to play!");
            //}
            //เมื่อเงื่อนไขทำงานสำเร็จแล้ว หรือ เงื่อนไขไม่ตรงเลยโค้ดทำงานต่อConsole.WriteLine(" Continue to run");

            // Console.Write("Your level (1-99): ");
            //bool ok = int.TryParse(Console.ReadLine(), out int level);

            // if (!ok || level < 1 || level > 99)

            //{
            //  Console.WriteLine("Invalid level.");
            //}
            //else if (level >= 10)
            //{
            //   Console.WriteLine("The door opens.");
            //}
            //else if (level >= 5)
            //{
            //  Console.WriteLine("Boss floor unlocked.");
            //}
            //else
            //{
            //  Console.WriteLine("The door stays shut.");
            //}





            Console.Writeline("Game TITLE: Lost God");
            Console.WriteLine("GOD BRAIN ENCOUNTER A DEVIL.... ");
            Console.WriteLine("ACTION 1 ATTACK");
            Console.WriteLine("ACTION 2 USE SKILL 1 GOD PUNCH ");
            Console.WriteLine("ACTION 3 USE SKILL 2 GOD KICK ");
            Console.WriteLine("ACTION 4 USE SKILL 3 GOD THUNDER ");
            Console.WriteLine("ACTION 5 RUN!!! ");
            Console.WriteLine("ACTION 6 USE ITEM 1 HEALTH POTION ");

            Console.WriteLine("Choose your action (1-6): ");
            bool isInputvalid = int.TryParse(Console.ReadLine(), out int action);

            if(isInputValid == false || action < 1 || action > 6)
            {
                Console.WriteLine("Invalid action. Please choose a number between 1 and 6.");
            }
  
            }
    }
}



          