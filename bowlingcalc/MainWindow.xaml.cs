using System;
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

namespace bowlingcalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double Gameone;
        double Gametwo;
        double Gamethree;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Double.TryParse(GameOne.Text, out Gameone);
            Double.TryParse(GameTwo.Text, out Gametwo);
            Double.TryParse(GameThree.Text, out Gamethree);

            Double answer = Gameone + Gametwo + Gamethree;
            Double answer1 = (Gameone + Gametwo + Gamethree) / 3;
            Double answer2 = (answer1 - 200) * 8;

            series_text.Text = answer.ToString();
            average_text.Text = answer1.ToString();
            handicap_text.Text = answer2.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            GameOne.Text = "";
            GameTwo.Text = "";
            GameThree.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
