using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
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
using System.Xml;
using BuildGenerator.Properties;

namespace BuildGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            //string[] contentsOfFile =
            //{
            //"rndName = " + Settings.Default.RandomNameOut,
            //"rndRace = " + Settings.Default.RandomRaceOut,
            //"rndClass = " + Settings.Default.RandomClassOut,
            //"rndStone = " + Settings.Default.RandomStoneOut,
            //"rndTransform = " + Settings.Default.RandomTransformOut,
            //"rndReligion = " + Settings.Default.RandomReligionOut,
            //"rndSkills = " + Settings.Default.RandomSkillOut,
            //"rndArea = " + Settings.Default.RandomAreaOut,
            //};
            //Directory.CreateDirectory(@"SKSE/Plugins");
            //File.WriteAllLines(@"SKSE/Plugins/RandomisedOutput.ini", contentsOfFile);                 // might be used at some point for automation in game 
            Application.Current.Shutdown();
        }
    }
}
