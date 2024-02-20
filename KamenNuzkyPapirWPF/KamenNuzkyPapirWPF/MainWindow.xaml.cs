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

namespace KamenNuzkyPapirWPF
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

        private void btnKamen_Click(object sender, RoutedEventArgs e)
        {
            TxtBoxPlayer.Text = "kámen";
            string inputPLAYER = TxtBoxPlayer.Text;
            Random random = new Random();
            int inputRandomCPU = random.Next(1, 4);
            Hra(inputRandomCPU, inputPLAYER);
        }


        private void btnNuzky_Click(object sender, RoutedEventArgs e)
        {
            TxtBoxPlayer.Text = "nůžky";
            string inputPLAYER = TxtBoxPlayer.Text;
            Random random = new Random();
            int inputRandomCPU = random.Next(1, 4);
            Hra(inputRandomCPU, inputPLAYER);
        }

        private void btnPapir_Click(object sender, RoutedEventArgs e)
        {
            TxtBoxPlayer.Text = "papír";
            string inputPLAYER = TxtBoxPlayer.Text;
            Random random = new Random();
            int inputRandomCPU = random.Next(1, 4);
            Hra(inputRandomCPU, inputPLAYER);
        }
        private void Hra(int inputRandomCPU, string inputPLAYER)
        {
            string inputCPU;
            switch (inputRandomCPU)
            {
                case 1:
                    inputCPU = "kámen";
                    txtBoxCPU.Text = "Počítač vybral kámen.";
                    if (inputPLAYER == "kámen")
                    {
                        MessageBox.Show("Remíza!");
                    }
                    else if (inputPLAYER == "papír")
                    {
                        MessageBox.Show("Vyhrál jsi!");
                    }
                    else if (inputPLAYER == "nůžky")
                    {
                        MessageBox.Show("Prohrál jsi!");
                    }
                    break;
                case 2:
                    inputCPU = "nůžky";
                    txtBoxCPU.Text = "Počítač vybral nůžky.";
                    if (inputPLAYER == "nůžky")
                    {
                        MessageBox.Show("Remíza!");
                    }
                    else if (inputPLAYER == "kámen")
                    {
                        MessageBox.Show("Vyhrál jsi!");
                    }
                    else if (inputPLAYER == "papír")
                    {
                        MessageBox.Show("Prohrál jsi!");
                    }
                    break;
                case 3:
                    inputCPU = "papír";
                    txtBoxCPU.Text = "Počítač vybral papír.";
                    if (inputPLAYER == "papír")
                    {
                        MessageBox.Show("Remíza!");
                    }
                    else if (inputPLAYER == "nůžky")
                    {
                        MessageBox.Show("Vyhrál jsi!");
                    }
                    else if (inputPLAYER == "kámen")
                    {
                        MessageBox.Show("Prohrál jsi!");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
