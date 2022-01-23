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

namespace Advanced_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            txtInput.Text = "";
        }

        private void OnNumberClicked(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            txtInput.Text = txtInput.Text + clickedButton.Content;       
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            String input = txtInput.Text;
            int number = 0;
            int op1 = 0;
            char operation = ' ';
            
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i]>='0' && input[i] <= '9')
                {
                    number = number * 10;
                    number = number + (input[i] -'0');
                }
                else if (input[i] == '+' || input[i] == '-' || input[i] == 'x' || input[i] == '/')
                {
                    switch (operation)
                    {
                        case '+':
                            number = op1 + number;
                            break;

                        case '-':
                            number = op1 - number;
                            break;
                        case 'x':
                            number = op1 * number;
                            break;
                        case '/':
                            number = op1 / number;
                            break;
                    }

                    operation =input[i];
                    op1 = number;
                    number = 0;
                }
                
            }
            switch (operation)
            {
                case '+':
                    number = op1 + number;
                    break;

                case '-':
                    number = op1 - number;
                    break;
                case 'x':
                    number = op1 * number;
                    break;
                case '/':
                    number = op1 / number;
                    break;
            }
            txtInput.Text = number.ToString();
          
           
        }
    }

}
