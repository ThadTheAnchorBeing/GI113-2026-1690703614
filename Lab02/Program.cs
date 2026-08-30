/*
 * Student ID : 1690703614
 * Name       : Thadpong Thuedam
 * Section    : 129B
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // ========================================
        // PART A - KIRIN'S STATUS REPORT
        // ========================================

        string bossName = "Kirin";
        char rank = 'S';
        int level = 7;
        int maxHp = 240;
        int currentHp = 175;
        float attackPower = 42.5f;
        double critMultiplier = 1.75;
        bool isBoss = true;

        Console.WriteLine("===== BOSS STATUS: INITIAL =====");
        Console.WriteLine($"Name: {bossName}");
        Console.WriteLine($"Rank: {rank}");
        Console.WriteLine($"Level: {level}");
        Console.WriteLine($"HP: {currentHp} / {maxHp}");
        Console.WriteLine($"Attack Power: {attackPower}");
        Console.WriteLine($"Crit Multiplier: {critMultiplier}");
        Console.WriteLine($"Is Boss: {isBoss}");

        Console.WriteLine();

        int hpPercent = currentHp * 100 / maxHp;
        Console.WriteLine($"HP Percent: {hpPercent}%");

        Console.WriteLine();

        Console.WriteLine("Kirin takes 60 damage!");

        currentHp = currentHp - 60;

        Console.WriteLine();

        Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
        Console.WriteLine($"HP: {currentHp} / {maxHp}");

        hpPercent = currentHp * 100 / maxHp;
        Console.WriteLine($"HP Percent: {hpPercent}%");


        // ========================================
        // PART B - TEKKEN 8
        // ========================================

        // ===== CHARACTER 1 =====

        string name1 = "Jin Kazama";
        int hp1 = 420;
        float attack1 = 72.5f;
        double critical1 = 1.90;
        char rank1 = 'S';

        Console.WriteLine("===== TEKKEN 8 CHARACTER 1 =====");
        Console.WriteLine($"Name: {name1}");
        Console.WriteLine($"HP: {hp1}");
        Console.WriteLine($"Attack Power: {attack1}");
        Console.WriteLine($"Critical Multiplier: {critical1}");
        Console.WriteLine($"Rank: {rank1}");

        Console.WriteLine();


        // ===== CHARACTER 2 =====

        string name2 = "Kazuya Mishima";
        int hp2 = 450;
        float attack2 = 80.5f;
        double critical2 = 2.10;
        bool isDevilGene = true;

        Console.WriteLine("===== TEKKEN 8 CHARACTER 2 =====");
        Console.WriteLine($"Name: {name2}");
        Console.WriteLine($"HP: {hp2}");
        Console.WriteLine($"Attack Power: {attack2}");
        Console.WriteLine($"Critical Multiplier: {critical2}");
        Console.WriteLine($"Has Devil Gene: {isDevilGene}");

        Console.WriteLine();


        // ===== CHARACTER 3 =====

        string name3 = "King";
        int hp3 = 500;
        float attack3 = 85.0f;
        double critical3 = 2.00;
        bool isWrestler = true;

        Console.WriteLine("===== TEKKEN 8 CHARACTER 3 =====");
        Console.WriteLine($"Name: {name3}");
        Console.WriteLine($"HP: {hp3}");
        Console.WriteLine($"Attack Power: {attack3}");
        Console.WriteLine($"Critical Multiplier: {critical3}");
        Console.WriteLine($"Is Wrestler: {isWrestler}");

        Console.WriteLine();


        // ===== CHARACTER 4 =====

        string name4 = "Hwoarang";
        int hp4 = 400;
        float attack4 = 76.5f;
        double critical4 = 1.85;
        char rank4 = 'A';

        Console.WriteLine("===== TEKKEN 8 CHARACTER 4 =====");
        Console.WriteLine($"Name: {name4}");
        Console.WriteLine($"HP: {hp4}");
        Console.WriteLine($"Attack Power: {attack4}");
        Console.WriteLine($"Critical Multiplier: {critical4}");
        Console.WriteLine($"Rank: {rank4}");
    }
}
