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
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
            textBlock2.Text = " 1) U have to type the \n  correct name.. \n\n 2) All the names must be in \n  small case.. \n\n 3) If there is a space \n  in the names it must\n  be given while typing\n\n 4) Spellings are to be typed\n  correctly.. ";
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
    }
}