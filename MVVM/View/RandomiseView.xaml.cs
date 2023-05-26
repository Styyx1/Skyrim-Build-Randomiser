using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
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

namespace BuildGenerator.MVVM.View
{
    /// <summary>
    /// Interaction logic for RandomiseView.xaml
    /// </summary>
    public partial class RandomiseView : UserControl
    {
        public RandomiseView()
        {
            InitializeComponent();
            OutputName.Background = new SolidColorBrush(Colors.Transparent);
            RaceOutput.Background = new SolidColorBrush(Colors.Transparent);
            ClassOutput.Background = new SolidColorBrush(Colors.Transparent);
            StoneOutput.Background = new SolidColorBrush(Colors.Transparent);
            TransformOutput.Background = new SolidColorBrush(Colors.Transparent);
            ReligionOutput.Background = new SolidColorBrush(Colors.Transparent);
            SkillsMajorOutput.Background = new SolidColorBrush(Colors.Transparent);
            AreaOutput.Background = new SolidColorBrush(Colors.Transparent);

            Properties.Settings.Default.RandomNameOut = OutputName.Text;
            Properties.Settings.Default.RandomRaceOut = RaceOutput.Text;            
            Properties.Settings.Default.RandomClassOut = ClassOutput.Text;            
            Properties.Settings.Default.RandomStoneOut = StoneOutput.Text;            
            Properties.Settings.Default.RandomTransformOut = TransformOutput.Text;            
            Properties.Settings.Default.RandomReligionOut = ReligionOutput.Text;            
            Properties.Settings.Default.RandomSkillOut = SkillsMajorOutput.Text;       
            Properties.Settings.Default.RandomAreaOut = AreaOutput.Text;
        }

        public int IsEvil = 0;



        public void NameButton_Click(object sender, RoutedEventArgs e)
        {
            
            string nameFile = @"SettingFiles\randomNames.txt";
            string[] lines = File.ReadAllLines(nameFile);
            Random rand = new Random();
            string RandName = lines[rand.Next(lines.Length)];
            if (RandName == null) { RandName = "Leroy Jenkins"; }
            else
                OutputName.Text = RandName;
            Properties.Settings.Default.RandomNameOut = OutputName.Text;
            Properties.Settings.Default.Save();
        }
        public void RaceButton_Click(object sender, RoutedEventArgs e)
        {
                string raceFile = @"SettingFiles\Races.txt";
                string[] lines = File.ReadAllLines(raceFile);
                Random rnd = new Random();
                string RandRace = lines[rnd.Next(lines.Length)];
                RaceOutput.Text = RandRace;
                Properties.Settings.Default.RandomRaceOut = RaceOutput.Text;
                Properties.Settings.Default.Save();
        }
        public void ClassButton_Click(object sender, RoutedEventArgs e)
        {
            string classFile = @"SettingFiles\Classes.txt";
            string[] lines = File.ReadAllLines(classFile);
            Random random = new Random();
            string rndClass = lines[random.Next(lines.Length)];
            ClassOutput.Text = rndClass;
            Properties.Settings.Default.RandomClassOut = ClassOutput.Text;
            Properties.Settings.Default.Save();
        }
        public void StoneButton_Click(object sender, RoutedEventArgs e)
        {
            string stoneFile = @"SettingFiles\StandingStones.txt";
            string[] lines = File.ReadAllLines(stoneFile);
            Random rnd = new Random();
            string RNDStone = lines[rnd.Next(lines.Length)];
            StoneOutput.Text = RNDStone;
            Properties.Settings.Default.RandomStoneOut = StoneOutput.Text;
            Properties.Settings.Default.Save();
        }

        public void TransformButton_Click(object sender, RoutedEventArgs e)
        {
            string transformFile = @"SettingFiles\Transformation.txt";
            string[] lines= File.ReadAllLines(transformFile);
            Random rnd = new Random();  
            string RNDTransform = lines[rnd.Next(lines.Length)];
            TransformOutput.Text = RNDTransform;
            Properties.Settings.Default.RandomTransformOut = TransformOutput.Text;
            Properties.Settings.Default.Save();
        }

        public void ReligionButton_Click(object sender, RoutedEventArgs e)
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
            ReligionOutput.Text = RNDReligion;
            Properties.Settings.Default.RandomReligionOut = ReligionOutput.Text;
            Properties.Settings.Default.Save();
        }

        public void EvilCheckbox_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.ReligionEvil = true;
            Properties.Settings.Default.Save();

        }

        public void EvilCheckbox_Unchecked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.ReligionEvil = false;
            Properties.Settings.Default.Save();
        }

        public void SkillsMajorButton_Click(object sender, RoutedEventArgs e)
        {
            string majorSkillFile = @"SettingFiles\Skills.txt";
            string[] lines = File.ReadAllLines(majorSkillFile);
            List<string> source = new List<string>();
            Random rnd = new Random();
            int NumLines = 3;
            for (int i = 0;i < NumLines; i++) 
            {
                source.Add(lines[rnd.Next(0, lines.Length - 1)]);
            }
            var RNDMajorSkillArray = source.ToArray<string>();   // https://stackoverflow.com/questions/44269733/how-to-make-string-list-to-string-array for the rescue
            var RNDMajorSkill = string.Join(", ", RNDMajorSkillArray);
            SkillsMajorOutput.Text = RNDMajorSkill;
            Properties.Settings.Default.RandomSkillOut = SkillsMajorOutput.Text;
            Properties.Settings.Default.Save();
        }

        public void AreaButton_Click(object sender, RoutedEventArgs e)
        {
            string areaFile = @"SettingFiles\StartArea.txt";
            string[] lines = File.ReadAllLines(areaFile);
            Random rnd = new Random();
            string RNDStartArea = lines[rnd.Next(lines.Length)];
            AreaOutput.Text = RNDStartArea;
            Properties.Settings.Default.RandomAreaOut = AreaOutput.Text;
            Properties.Settings.Default.Save();
        }

        public void RandomiseImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NameButton.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Primitives.ButtonBase.ClickEvent));
            RaceButton.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Primitives.ButtonBase.ClickEvent));
            ClassButton.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Primitives.ButtonBase.ClickEvent));
            StoneButton.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Primitives.ButtonBase.ClickEvent));
            TransformButton.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Primitives.ButtonBase.ClickEvent));
            ReligionButton.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Primitives.ButtonBase.ClickEvent));
            SkillsMajorButton.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Primitives.ButtonBase.ClickEvent));
            AreaButton.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Primitives.ButtonBase.ClickEvent));
        }

        private void ResetRandomiserButton_Click(object sender, RoutedEventArgs e)
        {
            OutputName.Text = string.Empty;
            RaceOutput.Text = string.Empty;
            ClassOutput.Text = string.Empty;
            StoneOutput.Text = string.Empty;
            TransformOutput.Text = string.Empty;
            ReligionOutput.Text = string.Empty;
            SkillsMajorOutput.Text = string.Empty;
            AreaOutput.Text = string.Empty;

            Properties.Settings.Default.RandomNameOut = OutputName.Text;
            Properties.Settings.Default.RandomRaceOut = RaceOutput.Text;
            Properties.Settings.Default.RandomClassOut = ClassOutput.Text;
            Properties.Settings.Default.RandomStoneOut = StoneOutput.Text;
            Properties.Settings.Default.RandomTransformOut = TransformOutput.Text;
            Properties.Settings.Default.RandomReligionOut = ReligionOutput.Text;
            Properties.Settings.Default.RandomSkillOut = SkillsMajorOutput.Text;
            Properties.Settings.Default.RandomAreaOut = AreaOutput.Text;
        }
    }
}
