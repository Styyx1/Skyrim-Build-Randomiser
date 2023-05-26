using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BuildGenerator.MVVM.View;
using BuildGenerator.Properties;

namespace BuildGenerator.MVVM.View
{
    /// <summary>
    /// Interaction logic for BackstoryView.xaml
    /// </summary>
    public partial class BackstoryView : UserControl
    {
        public BackstoryView()
        {
            InitializeComponent();
            OutputBackstory.Background = new SolidColorBrush(Colors.Transparent);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = string.Empty;
            string race = string.Empty;
            string stone = string.Empty;
            string classes = string.Empty;
            string origin = string.Empty;
            string dream = string.Empty;
            string age = string.Empty;
            string wealthyoung = string.Empty;
            string wealthnow = string.Empty;
            string negPers = string.Empty;
            string posPers = string.Empty;
            string skills = string.Empty;
            string appear = string.Empty;
            string religion = string.Empty;
            string gameGoals = string.Empty;

            if (Properties.Settings.Default.RandomNameOut == string.Empty)
            {
                string nameFile = @"SettingFiles\randomNames.txt";
                string[] lines = File.ReadAllLines(nameFile);
                Random rand = new Random();
                string RandName = lines[rand.Next(lines.Length)];
                Properties.Settings.Default.RandomNameOut = RandName;
                Properties.Settings.Default.Save();
                name = Settings.Default.RandomNameOut;
            }
            else { name = Settings.Default.RandomNameOut; }

            if (Properties.Settings.Default.RandomRaceOut == string.Empty)
            {
                string raceFile = @"SettingFiles\Races.txt";
                string[] lines = File.ReadAllLines(raceFile);
                Random rnd = new Random();
                string RandRace = lines[rnd.Next(lines.Length)];
                Properties.Settings.Default.RandomRaceOut = RandRace;
                Properties.Settings.Default.Save();
                race = Settings.Default.RandomRaceOut;
            }
            else
            {
                race = Settings.Default.RandomRaceOut;
            }

            if (Settings.Default.RandomClassOut == string.Empty)
            {
                string classFile = @"SettingFiles\Classes.txt";
                string[] lines = File.ReadAllLines(classFile);
                Random random = new Random();
                string rndClass = lines[random.Next(lines.Length)];
                
                Properties.Settings.Default.RandomClassOut = rndClass;
                Properties.Settings.Default.Save();
                classes = Settings.Default.RandomClassOut;
            }
            else
            {
                classes = Settings.Default.RandomClassOut;
            }
            if (Settings.Default.RandomStoneOut == string.Empty)
            {
                string stoneFile = @"SettingFiles\StandingStones.txt";
                string[] lines = File.ReadAllLines(stoneFile);
                Random rnd = new Random();
                string RNDStone = lines[rnd.Next(lines.Length)];                
                Properties.Settings.Default.RandomStoneOut = RNDStone;
                Properties.Settings.Default.Save();
                stone = Settings.Default.RandomStoneOut;
            }
            else
            {
                stone = Settings.Default.RandomStoneOut;
            }
            if (Properties.Settings.Default.RandomReligionOut == string.Empty)
            {
                string religionFile = @"SettingFiles\Religion.txt";
                switch (Properties.Settings.Default.ReligionEvil)
                {
                    case false:
                        religionFile = @"SettingFiles\Religion.txt";
                        break;
                    case true:
                        religionFile = @"SettingFiles\ReligionDaedra.txt";
                        break;
                }
                string[] lines = File.ReadAllLines(religionFile);
                Random rnd = new Random();
                string RNDReligion = lines[rnd.Next(lines.Length)];
                Properties.Settings.Default.RandomReligionOut = RNDReligion;
                Properties.Settings.Default.Save();
                religion = Settings.Default.RandomReligionOut;

            }
            else
            {
                religion = Settings.Default.RandomReligionOut;
            }

            if (Settings.Default.RandomSkillOut == string.Empty)
            {
                string majorSkillFile = @"SettingFiles\Skills.txt";
                string[] lines = File.ReadAllLines(majorSkillFile);
                List<string> source = new List<string>();
                Random rnd = new Random();
                int NumLines = 3;
                for (int i = 0; i < NumLines; i++)
                {
                    source.Add(lines[rnd.Next(0, lines.Length - 1)]);
                }
                var RNDMajorSkillArray = source.ToArray<string>();   // https://stackoverflow.com/questions/44269733/how-to-make-string-list-to-string-array for the rescue
                var RNDMajorSkill = string.Join(", ", RNDMajorSkillArray);                
                Properties.Settings.Default.RandomSkillOut = RNDMajorSkill;
                Properties.Settings.Default.Save();
                skills = Settings.Default.RandomSkillOut;   
            }
            else
            {
                skills = Settings.Default.RandomSkillOut;
            }

            string RandomAge()
            {
                string ageFile = @"SettingFiles\Age.txt";
                string[] lines = File.ReadAllLines(ageFile);
                Random random = new Random();
                string rndage = lines[random.Next(lines.Length)];
                return rndage;
            }
            string RandomHailFrom()
            {
                string HailFromFile = @"SettingFiles\HailFrom.txt";
                string[] lines = File.ReadAllLines(HailFromFile);
                Random random = new Random();
                string rndOrigin = lines[random.Next(lines.Length)];
                return rndOrigin;
            }
            string RandomDreams()
            {
                string DreamsFile = @"SettingFiles\Dreams.txt";
                string[] lines = File.ReadAllLines(DreamsFile);
                Random random = new Random();
                string rndDream = lines[random.Next(lines.Length)];
                return rndDream;
            }
            string RandomWealth()
            {
                string WealthFile = @"SettingFiles\Wealth.txt";
                string[] lines = File.ReadAllLines(@WealthFile);
                Random random = new Random();
                string rndWealth = lines[random.Next(0, lines.Length-1)];
                return rndWealth;
            }
            string RandomNegativePersonality()
            {
                string negPersFile = @"SettingFiles\PersonalityNegative.txt";
                string[] lines = File.ReadAllLines(negPersFile);
                Random rnd = new Random();
                string rndNegPers = lines[rnd.Next(lines.Length)];
                return rndNegPers;
            }
            string RandomPositivePersonality()
            {
                string posPersFile = @"SettingFiles\PersonalityPositive.txt";
                string[] lines = File.ReadAllLines(@posPersFile);
                Random rnd = new Random();
                string rndPosPers = lines[rnd.Next(lines.Length)];
                return rndPosPers;
            }

            string RandomCharacterGoals()
            {
                string charGoals = @"SettingFiles\GameGoals.txt";
                string[] lines = File.ReadAllLines(charGoals);
                Random rng= new Random();
                string rndGameGoals = lines[rng.Next(0, lines.Length-1)];
                return rndGameGoals;
            }
                    
            origin = RandomHailFrom();
            dream = RandomDreams();
            age = RandomAge();
            wealthyoung = RandomWealth();
            wealthnow = RandomWealth();
            negPers = RandomNegativePersonality();
            posPers = RandomPositivePersonality();
            gameGoals = RandomCharacterGoals();


            OutputBackstory.Text =
                "You are a " + age + race + " named " + name + " born under the " + stone + 
                "\nYou hail from " + origin + " and travel through Skyrim for adventure" +
                "\nwhile secretly dreaming of " + dream + ". Growing up " + wealthyoung + " formed your personality." +                
                "\nPast experiences have caused you to become " + negPers + " but" +
                "\nregardless of all the pains of life, you strive to be " + posPers + " in all your dealings." +
                "\n\nDuring your journies through Skyrim you heard various rumors and " + 
                "\nmade it your goal to " + gameGoals +
                ".\nYears of training in " + skills + " prepared you for that moment." +
                "\nHaving a strong faith in " + religion + " helps you keep your focus on your goals.";
        }
        private void ResetBackstoryButton_Click(object sender, RoutedEventArgs e)
        {
            var rv = new RandomiseView();

            rv.OutputName.Text = string.Empty;
            rv.RaceOutput.Text = string.Empty;
            rv.ClassOutput.Text = string.Empty;
            rv.StoneOutput.Text = string.Empty;
            rv.TransformOutput.Text = string.Empty;
            rv.ReligionOutput.Text = string.Empty;
            rv.SkillsMajorOutput.Text = string.Empty;
            rv.AreaOutput.Text = string.Empty;

            Properties.Settings.Default.RandomNameOut = rv.OutputName.Text;
            Properties.Settings.Default.RandomRaceOut = rv.RaceOutput.Text;
            Properties.Settings.Default.RandomClassOut = rv.ClassOutput.Text;
            Properties.Settings.Default.RandomStoneOut = rv.StoneOutput.Text;
            Properties.Settings.Default.RandomTransformOut = rv.TransformOutput.Text;
            Properties.Settings.Default.RandomReligionOut = rv.ReligionOutput.Text;
            Properties.Settings.Default.RandomSkillOut = rv.SkillsMajorOutput.Text;
            Properties.Settings.Default.RandomAreaOut = rv.AreaOutput.Text;
        }
    }
}
