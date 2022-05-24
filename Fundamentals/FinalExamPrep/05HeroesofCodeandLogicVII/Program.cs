using System;
using System.Collections.Generic;
using System.Linq;

namespace _05HeroesofCodeandLogicVII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());
            List<Hero> listOfHeroes = new List<Hero>();

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string input = Console.ReadLine();

                string[] inputArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int HP = int.Parse(inputArgs[1]);
                int MP = int.Parse(inputArgs[2]);
                //if (HP > 100)
                //{
                //    HP = 100;
                //}
                //if(MP > 200)
                //{
                //    MP = 200;
                //}

                Hero currHero = new Hero(inputArgs[0], HP, MP);
                listOfHeroes.Add(currHero);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArgs = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string heroName = cmdArgs[1];
                Hero currHero = FindHero(listOfHeroes, heroName);

                if (cmdArgs[0] == "CastSpell")
                {
                    int MPNeeded = int.Parse(cmdArgs[2]);
                    string spellName = cmdArgs[3];

                    if (currHero.MP >= MPNeeded)
                    {
                        currHero.MP -= MPNeeded;
                        Console.WriteLine($"{currHero.Name} has successfully cast {spellName} and now has {currHero.MP} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{currHero.Name} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (cmdArgs[0] == "TakeDamage")
                {
                    int damage = int.Parse(cmdArgs[2]);
                    string attacker = cmdArgs[3];

                    currHero.HP -= damage;

                    if (currHero.HP <= 0)
                    {
                        Console.WriteLine($"{currHero.Name} has been killed by {attacker}!");
                        listOfHeroes.Remove(currHero);
                    }
                    else
                    {
                        Console.WriteLine($"{currHero.Name} was hit for {damage} HP by {attacker} and now has {currHero.HP} HP left!");
                    }
                }
                else if (cmdArgs[0] == "Recharge")
                {
                    int rechargeAmount = int.Parse(cmdArgs[2]);
                    int currMP = currHero.MP;
                    currHero.MP += rechargeAmount;
                    if (currHero.MP > 200)
                    {
                        rechargeAmount = 200 - currMP;
                        currHero.MP = 200;
                    }
                    Console.WriteLine($"{currHero.Name} recharged for {rechargeAmount} MP!");
                }
                else if (cmdArgs[0] == "Heal")
                {
                    int healAmount = int.Parse(cmdArgs[2]);
                    int currHP = currHero.HP;
                    currHero.HP += healAmount;
                    if (currHero.HP > 100)
                    {
                        healAmount = 100 - currHP;
                        currHero.HP = 100;
                    }
                    Console.WriteLine($"{currHero.Name} healed for {healAmount} HP!");
                }

                command = Console.ReadLine();
            }

            List<Hero> sortedHeroes = listOfHeroes.OrderByDescending(hero => hero.HP).ThenBy(hero => hero.Name).ToList();
            //List<Hero> finalPrint = sortedHeroes.OrderBy(hero => hero.Name).ToList();

            foreach (var hero in listOfHeroes)
            {
                Console.WriteLine(hero.Name);
                Console.WriteLine($"  HP: {hero.HP}");
                Console.WriteLine($"  MP: {hero.MP}");
            }

        }

        static Hero FindHero(List<Hero> listOfHeroes, string heroName)
        {
            Hero validHero = null;
            foreach (var hero in listOfHeroes)
            {
                if (hero.Name == heroName)
                {
                    validHero = hero;
                    break;
                }
            }
            return validHero;
        }
    }



    class Hero
    {

        public Hero(string name, int hp, int mp)
        {
            this.Name = name;
            this.HP = hp;
            this.MP = mp;
        }
        public string Name { get; set; }

        public int HP { get; set; }

        public int MP { get; set; }
    }

}
