/*
 * Couper Ebbs-Picken
 * 6/4/2018
 * D0 math
 */ 
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

namespace u5_MathTutor_CouperEbbsPicken
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int number1;
        int number2;
        int operation;
        double answer;
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            lblOperation.Content = "What is ";
            lblOutpt.Content = "";
            answer = 0;
            number1 = random.Next(1, 11);
            number2 = random.Next(1, 11);
            operation = random.Next(0, 4);

            if (operation == 0)
            {
                answer = number1 * number2;
                Math.Round(answer,2);
                lblOperation.Content += number1.ToString() + " * " + number2.ToString() + "?";
            }

            if (operation == 1)
            {
                answer = number1 + number2;
                Math.Round(answer,2);
                lblOperation.Content += number1.ToString() + " + " + number2.ToString() + "?";
            }

            if (operation == 2)
            {
                answer = number1 - number2;
                Math.Round(answer,2);
                lblOperation.Content += number1.ToString() + " - " + number2.ToString() + "?";
            }

            if (operation == 3)
            {
                answer = number1 / number2;
                Math.Round(answer,2);
                lblOperation.Content += number1.ToString() + " / " + number2.ToString() + "?";
            }
        }

        private void btnCheckAnswer_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(txtInput.Text, out int guess);

            if (guess == answer)
            {
                lblOutpt.Content = "Correct!";
            }

            if (guess != answer)
            {
                lblOutpt.Content = "Incorrect! The correct answer is: " + answer.ToString();
            }
        }
    }
}
