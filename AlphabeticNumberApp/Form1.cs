/*
A, B, and C = 2
D, E, and F = 3
G, H, and I = 4
J, K, and L = 5
M, N, and O = 6
P, Q, R, and S = 7
T, U, and V = 8
W, X, Y, and Z = 9

Create an application that lets the user enter a 10-character telephone number in the format XXX-XXX-XXXX. The application should display the telephone number with any alphabetic characters that appeared
in the original translated to their equivalent. For exemple, if the user enters 555-GET-FOOD, the application must display 555-438-3663
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphabeticNumberApp
{
    public partial class AlphNum : Form
    {
        public AlphNum()
        {
            InitializeComponent();
        }
        //Form level variable - character jagged array(An array of arrays) placing characters from A to
        char[][] alphabetic =
        {
            new char[] { ' ' }, // First level  which represents the zero index that way index two in my arrray corresponds exactly with the number two on the keypad
            new char[] { ' ' }, // Otherwise, if starting from Zero, that is to avoid to compensate for the difference that the array starts on KEypod start with two ( counter ++)
            new char[] { 'A', 'B', 'C'},
            new char[] { 'D', 'E', 'F'},
            new char[] { 'G', 'H', 'I'},
            new char[] { 'J', 'K', 'L'},
            new char[] { 'M', 'N', 'O'},
            new char[] { 'P', 'Q', 'R', 'S'},
            new char[] { 'T', 'U', 'V'},
            new char[] { 'W', 'X', 'Y', 'Z'}
        };

        

        private void AlphNum_Load(object sender, EventArgs e)
        {

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            // Variables to manipulate users input
            string numAlpha = maskedTextBoxInput.Text; // String to gather user input
            string codeArea = numAlpha.Substring(0, 3) + "-";// Default Code Area
            string phoneLetters = numAlpha.Substring(4);// Get users inputted letters after area code
            string phoneNum = codeArea; // Phone number generated

            // Nested loop to loop the letters inputted
            foreach(char c in phoneLetters)
            {
                for(int i = 2; i < alphabetic.Length; i++) // Starting at 2 beacause 1 and 2 are not being used - Loop untill the end
                {
                    // Capture each row of the letters array - Length is unknow of the rows each need to be capture separateky
                    char[] arrayInner = alphabetic[i];
                    for (int j = 0; j < arrayInner.Length; j++)
                    {
                        // Comparing user inputted
                        if (char.ToUpper(c) == arrayInner[j])
                        {
                            if (phoneNum.Length == 7)
                                phoneNum += "-";// Adding the characther 'dash'

                            // The indexes of the array are mapped to the letter indexex in the letter array
                            phoneNum += i.ToString();
                        }
                           
                    }
                }
            }

            // Display the phone number
            textBoxDisp.Text = phoneNum;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
