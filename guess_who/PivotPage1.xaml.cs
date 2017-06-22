using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace guess_who
{
    public partial class PivotPage1 : PhoneApplicationPage
    {
        public PivotPage1()
        {
            InitializeComponent();
        }

        private void image2_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void image3_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox3.Text.Equals("sylvester stallone")||textBox11.Text.Equals("silvester stallone"))
            {
                textBlock3.Text = "u are write :)";
                ellipse1.Fill = new SolidColorBrush(Colors.Transparent);
            }
            else
                textBlock3.Text = "try again :)";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (textBox2.Text.Equals("amir khan"))
            {
                textBlock2.Text = "u are write :)";
            }
            else textBlock2.Text = "try again :)";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text.Equals("michael jackson"))
            {
                textBlock1.Text = "u are write :)";
            }
            else textBlock1.Text = "try again :)";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {

            if (textBox4.Text.Equals("chiranjeevi"))
            {
                textBlock4.Text = "u are write :)";
                ellipse2.Fill = new SolidColorBrush(Colors.Transparent);
            }
            else textBlock4.Text = "try again :)";
        }

        private void image4_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (textBox5.Text.Equals("ms dhoni") || textBox11.Text.Equals("mahendra singh dhoni")|| textBox11.Text.Equals("m s dhoni"))
            {
                textBlock5.Text = "u are write :)";
            }
            else textBlock5.Text = "try again :)";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (textBox6.Text.Equals("shakira"))
            {
                textBlock6.Text = "u are write :)";
                ellipse18.Fill = new SolidColorBrush(Colors.Transparent);
            }
            else textBlock6.Text = "try again :)";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (textBox7.Text.Equals("a r rahman"))
            {
                textBlock7.Text = "u are write :)";
                ellipse3.Fill = new SolidColorBrush(Colors.Transparent);
            }
            else textBlock7.Text = "try again :)";
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (textBox8.Text.Equals("enrique iglesias"))
            {
                textBlock8.Text = "u are write :)";
                ellipse4.Fill = new SolidColorBrush(Colors.Transparent);
            }
            else textBlock8.Text = "try again :)";
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (textBox9.Text.Equals("shahrukh khan")|| textBox11.Text.Equals("sharukh khan"))
            {
                textBlock9.Text = "u are write :)";
                ellipse5.Fill = new SolidColorBrush(Colors.Transparent);
            }
            else textBlock9.Text = "try again :)";
        }

        private void image10_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
        
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
        if (textBox10.Text.Equals("leonardo dicaprio"))
            {
                textBlock10.Text = "u are write :)";
                ellipse6.Fill = new SolidColorBrush(Colors.Transparent);
            }
            else textBlock10.Text = "try again :)";
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
        if (textBox11.Text.Equals("amitabh bachchan")||textBox11.Text.Equals("amitabh bachan"))
            {
                textBlock11.Text = "u are write :)";
                ellipse7.Fill = new SolidColorBrush(Colors.Transparent);
            }
            else textBlock11.Text = "try again :)";
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
        if (textBox12.Text.Equals("pavan kalyan"))
            {
                textBlock12.Text = "u are write :)";
                ellipse8.Fill = new SolidColorBrush(Colors.Transparent);
            }
            else textBlock12.Text = "try again :)";
        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
        if (textBox13.Text.Equals("hrithik roshan"))
            {
                textBlock13.Text = "u are write :)";
                ellipse9.Fill = new SolidColorBrush(Colors.Transparent);
            }
            else textBlock13.Text = "try again :)";
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
        if (textBox14.Text.Equals("sachin tendulkar"))
            {
                textBlock14.Text = "u are write :)";
                ellipse10.Fill = new SolidColorBrush(Colors.Transparent);
            }
            else textBlock14.Text = "try again :)";
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
         if (textBox15.Text.Equals("virat kohli"))
            {
                textBlock15.Text = "u are write :)";
                ellipse11.Fill = new SolidColorBrush(Colors.Transparent);
            }
            else textBlock15.Text = "try again :)";
        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
         if (textBox16.Text.Equals("salman khan"))
            {
                textBlock16.Text = "u are write :)";
                ellipse12.Fill = new SolidColorBrush(Colors.Transparent);
            }
            else textBlock16.Text = "try again :)";
        }

        private void button17_Click(object sender, RoutedEventArgs e)
        {
         if (textBox17.Text.Equals("emma watson"))
            {
                textBlock17.Text = "u are write :)";
                ellipse13.Fill = new SolidColorBrush(Colors.Transparent);
            }
            else textBlock17.Text = "try again :)";
        }

        private void button18_Click(object sender, RoutedEventArgs e)
        {
        if (textBox18.Text.Equals("arnold schwarzenegger"))
            {
                textBlock18.Text = "u are write :)";
                ellipse14.Fill = new SolidColorBrush(Colors.Transparent);
            }
            else textBlock18.Text = "try again :)";
        }

        private void button19_Click(object sender, RoutedEventArgs e)
        {
            if (textBox19.Text.Equals("rock") || textBox19.Text.Equals("dwayne johnson") || textBox19.Text.Equals("the rock"))
                {
                    textBlock19.Text = "u are write :)";
                    ellipse15.Fill = new SolidColorBrush(Colors.Transparent);
                }
                else textBlock19.Text = "try again :)";
       
        }

        private void button20_Click(object sender, RoutedEventArgs e)
        {
            if (textBox20.Text.Equals("robert pattinson"))
            {
                textBlock20.Text = "u are write :)";
                ellipse16.Fill = new SolidColorBrush(Colors.Transparent);
            }
            else textBlock20.Text = "try again :)";
        }

        private void button21_Click(object sender, RoutedEventArgs e)
        {
            if (textBox21.Text.Equals("allu arjun"))
            {
                textBlock21.Text = "u are write :)";
                ellipse17.Fill = new SolidColorBrush(Colors.Transparent);
            }
            else textBlock21.Text = "try again :)";
        }

        private void image5_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}