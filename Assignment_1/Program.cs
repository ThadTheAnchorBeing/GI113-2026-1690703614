/*
* Student ID : 1690703614
* Name       : Thadpong Thuedam
* Section    : 129B
* No.        : 36
* Course     : GI113 Computer Programming (GI)
*/


namespace acc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CharacterName = "Thadpong";
            const string GameTitle = "Shadow MOON CITY";

            var heroRank = 'S';
            var heroName = "Shadow";
            int heroLevel = 25;
            float attackPower = 78.5f;
            double specialPower = 95.75;
            bool isUnlocked = true;

            Console.WriteLine("========================================");
            Console.WriteLine($"       {GameTitle} - STAT CARD");
            Console.WriteLine("========================================");
            Console.WriteLine($"  Character : {CharacterName}");
            Console.WriteLine($"  Hero Name : {heroName}");
            Console.WriteLine($"  Rank      : {heroRank}");
            Console.WriteLine($"  Level     : {heroLevel}");
            Console.WriteLine($"  Attack    : {attackPower}");
            Console.WriteLine($"  Special   : {specialPower}");
            Console.WriteLine($"  Unlocked  : {isUnlocked}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("  SPECIAL SKILL");
            Console.WriteLine("  Void Reaper");
            Console.WriteLine("  Summon dark energy to destroy enemies");
            Console.WriteLine("========================================");

            double heroLevelAsDouble = heroLevel;
            Console.WriteLine($"Level as double (implicit): {heroLevelAsDouble}");

            int powerCast = (int)attackPower;
            int powerConvert = Convert.ToInt32(attackPower);

            Console.WriteLine($"Attack cast (truncates): {powerCast}");
            Console.WriteLine($"Attack Convert (rounds): {powerConvert}");
        }
    }
}