using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

// unused

namespace BuildGenerator.Core
{
    public class RandomiseAll 
    { 
        public string RandomRaceSelect()
            {
                string raceFile = @"SettingFiles\Races.txt";
                string[] lines = File.ReadAllLines(raceFile);
                Random rnd = new Random();
                string RandRace1 = lines[rnd.Next(lines.Length)];
                return RandRace1;
            }
        public string RandomName()
            {
                string nameFile = @"SettingFiles\randomNames.txt";
                string[] lines = File.ReadAllLines(nameFile);
                Random rand = new Random();
                string RandName = lines[rand.Next(lines.Length)];
                return RandName;
            }
        public string RandomStone()
            {
                string stoneFile = @"SettingFiles\StandingStones.txt";
                string[] lines = File.ReadAllLines(stoneFile);
                Random rnd = new Random();
                string RNDStone = lines[rnd.Next(lines.Length)];
                return RNDStone;
            }
        public string RandomClass()
            {
                string classFile = @"SettingFiles\Classes.txt";
                string[] lines = File.ReadAllLines(classFile);
                Random random = new Random();
                string rndClass = lines[random.Next(lines.Length)];
                return rndClass;
            }
        public string RandomAge()
            {
                string ageFile = @"SettingFiles\Age.txt";
                string[] lines = File.ReadAllLines(ageFile);
                Random random = new Random();
                string rndage = lines[random.Next(lines.Length)];
                return rndage;
            }
        public string RandomHailFrom()
            {
                string HailFromFile = @"SettingFiles\HailFrom.txt";
                string[] lines = File.ReadAllLines(HailFromFile);
                Random random = new Random();
                string rndOrigin = lines[random.Next(lines.Length)];
                return rndOrigin;
            }
        public string RandomDreams()
            {
                string DreamsFile = @"SettingFiles\Dreams.txt";
                string[] lines = File.ReadAllLines(DreamsFile);
                Random random = new Random();
                string rndDream = lines[random.Next(lines.Length)];
                return rndDream;
            }
        public string RandomWealth()
            {
                string WealthFile = @"SettingFiles\Wealth.txt";
                string[] lines = File.ReadAllLines(WealthFile);
                Random random = new Random();
                string rndWealth = lines[random.Next(lines.Length)];
                return rndWealth;
            }
        public string RandomNegativePersonality()
            {
                string negPersFile = @"SettingFiles\PersonalityNegative.txt";
                string[] lines = File.ReadAllLines(negPersFile);
                Random rnd = new Random();
                string rndNegPers = lines[rnd.Next(lines.Length)];
                return rndNegPers;
            }
        public string RandomPositivePersonality()
            {
                string posPersFile = @"SettingFiles\PersonalityPositive.txt";
                string[] lines = File.ReadAllLines(@posPersFile);
                Random rnd = new Random();
                string rndPosPers = lines[rnd.Next(lines.Length)];
                return rndPosPers;
            }
        public string Background()
        {
                string race = RandomRaceSelect();
                string name = RandomName();
                string parent1 = RandomName();
                string parent2 = RandomName();
                string stone = RandomStone();
                string classes = RandomClass();
                string origin = RandomHailFrom();
                string dream = RandomDreams();
                string age = RandomAge();
                string wealthyoung = RandomWealth();
                string wealthnow = RandomWealth();
                string negPers = RandomNegativePersonality();
                string posPers = RandomPositivePersonality();
                return("You are " + name +
                    "\nYou are a " + age + race + " hailing from " + origin +
                    "\nWhen you were younger you were raised by " + wealthyoung + " Parents. Their names were " + parent1 + " and " + parent2 +
                    "\nNow, after years of work you are " + wealthnow +
                    "\nYour years of life have caused you to become " + negPers + " but" +
                    "\nregardless of all the pains of life, you strive to be " + posPers + " in all your dealings." +
                    "\nYour birthsign is the " + stone + " Stone " +
                    "\nYou start out as a " + classes + " and you dream of " + dream);          
        }       
    }  
}



