//GROUP : 6
//GROUP MEMBERS: William Wiltshire, Kirsti Tench, Zahidali Maknojia, Krishna Bhandari, Aleksander Mukhin
//ASSIGNMENT# 7
//Description: A Tic Tac Toe Game simulator
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

namespace TTTGameSimulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameSimulation gm = new GameSimulation();
        public MainWindow()
        {
            InitializeComponent();
            AppWindow.DataContext = gm;
        }
        private void Simulate_Click(object sender, RoutedEventArgs e)
        {
            gm.ArrayFilling();
        }

        private void ResetScore_Click(object sender, RoutedEventArgs e)
        {
            gm.ClearScore();
        }

    }
}
