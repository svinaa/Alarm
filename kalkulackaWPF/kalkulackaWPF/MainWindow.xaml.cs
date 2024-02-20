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
using MatematikaObjektove;

namespace kalkulackaWPF
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double vysledek = 0;
        string operace = "";
        bool jeOperace = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (jeOperace == true)
            {
                txtBox.Clear();
            }
            jeOperace = false;
            txtBox.Text += 7;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (jeOperace)
            {
                txtBox.Clear();
            }
            jeOperace = false;
            txtBox.Text += 8;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (jeOperace)
            {
                txtBox.Clear();
            }
            jeOperace = false;
            txtBox.Text += 9;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (jeOperace)
            {
                txtBox.Clear();
            }
            jeOperace = false;
            txtBox.Text += 4;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {if (jeOperace)
            {
                txtBox.Clear();
            }
            jeOperace = false;
            txtBox.Text += 5;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {if (jeOperace)
            {
                txtBox.Clear();
            }
            jeOperace = false;
            txtBox.Text += 6;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {if (jeOperace)
            {
                txtBox.Clear();
            }
            jeOperace = false;
            txtBox.Text += 1;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {if (jeOperace)
            {
                txtBox.Clear();
            }
            jeOperace = false;
            txtBox.Text += 2;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {if (jeOperace)
            {
                txtBox.Clear();
            }
            jeOperace = false;
            txtBox.Text += 3;
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {if (jeOperace)
            {
                txtBox.Clear();
            }
            jeOperace = false;
            txtBox.Text += 0;
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Clear();
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Clear();
        }

        private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            operace = "-";
            vysledek = double.Parse(txtBox.Text);
            jeOperace = true;
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operace = "+";
            vysledek = double.Parse(txtBox.Text);
            jeOperace = true;
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operace = "-";
            vysledek = double.Parse(txtBox.Text);
            jeOperace = true;
        }

        private void btnKrat_Click(object sender, RoutedEventArgs e)
        {
            operace = "*";
            vysledek = double.Parse(txtBox.Text);
            jeOperace = true;
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            double vysledekParse = double.Parse(txtBox.Text);
            switch (operace)
            {
                case "+":
                    txtBox.Text = (vysledek + vysledekParse).ToString();
                    break;
                case "-":
                default:
                    break;
            }
        }
    }
}
