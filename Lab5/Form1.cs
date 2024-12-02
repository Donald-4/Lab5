using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Name: Donald Wouakam Tientcheu
         * Date: 02 December 2024
         * This program rolls one dice or calculates mark stats.
         * Link to your repo in GitHub: https://github.com/Donald-4/Lab5
         * */

        //class-level random object
        Random rand = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            //select one roll radiobutton
            radOneRoll.Checked = true;
            
            //add your name to end of form title
            this.Text += "Donald Wouakam Tientcheu";
            
        } // end form load

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearOneRoll();
            //call the function
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearStats();
            //call the function
            
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            int dice1, dice2;
            //call ftn RollDice, placing returned number into integers
            dice1 = RollDice();
            dice2 = RollDice();

            //place integers into labels
            lblDice1.Text = dice1.ToString();
            lblDice2.Text = dice2.ToString();

            // call ftn GetName sending total and returning name
            string name = GetName(dice1 + dice2);

            //display name in label
            lblRollName.Text = name;

        }

        /* Name: ClearOneRoll
        *  Sent: nothing
        *  Return: nothing
        *  Clear the labels */
        private void ClearOneRoll()
        {
            lblDice1.Text = "";
            lblDice2.Text = "";
            lblRollName.Text = "";

        }


        /* Name: ClearStats
        *  Sent: nothing
        *  Return: nothing
        *  Reset nud to minimum value, chkbox unselected, 
        *  clear labels and listbox */
        private void ClearStats()
        {
            nudNumber.Value = 50;
            lblPass.Text = "";
            lblFail.Text = "";
            lblAverage.Text ="";
            lstMarks.Items.Clear();
            chkSeed.Checked = false;
        }


        /* Name: RollDice
        * Sent: nothing
        * Return: integer (1-6)
        * Simulates rolling one dice */
        private int RollDice()
        {
            
            return rand.Next(1,7);

        }


        /* Name: GetName
        * Sent: 1 integer (total of dice1 and dice2) 
        * Return: string (name associated with total) 
        * Finds the name of dice roll based on total.
        * Use a switch statement with one return only
        * Names: 2 = Snake Eyes
        *        3 = Litle Joe
        *        5 = Fever
        *        7 = Most Common
        *        9 = Center Field
        *        11 = Yo-leven
        *        12 = Boxcars
        * Anything else = No special name*/
        private string GetName(int a)
        {
            string name="";
            switch (a)
            {
                case 2:
                    name = "Snake Eyes";
                    break;
                case 3:
                    name = "Little Joe";
                    break;
                case 5:
                    name = "Fever";
                    break;
                case 7:
                    name = "Most Common";
                    break;
                case 9:
                    name = "Center Field";
                    break;
                case 11:
                    name = "Yo-leven";
                    break;
                case 12:
                    name = "Boxcars";
                    break;
                default:
                    name = "No Special Name";
                    break;

            }
            return name;

        }

        private void btnSwapNumbers_Click(object sender, EventArgs e)
        {
            //call ftn DataPresent twice sending string returning boolean
            string dice1text, dice2text;
            dice1text = lblDice1.Text;
            dice2text = lblDice2.Text;
            bool v1 = DataPresent(dice1text);
            bool v2 = DataPresent(dice2text);

            //if data present in both labels, call SwapData sending both strings
            if(v1==true && v2==true)
            {
                SwapData(ref dice1text, ref dice2text);
                //put data back into labels
                lblDice1.Text = dice1text;
                lblDice2.Text = dice2text;
   
            }
            //if data not present in either label display error msg
            else
            {
                MessageBox.Show("Roll the dice", "Data Missing");
            }
        }

        /* Name: DataPresent
        * Sent: string
        * Return: bool (true if data, false if not) 
        * See if string is empty or not*/
        private bool DataPresent(string m)
        {
            bool value;
            if (m != "")
            {
                value = true;
            }
            else
            {
                value = false;
            }
            return value;
        }


        /* Name: SwapData
        * Sent: 2 strings
        * Return: none 
        * Swaps the memory locations of two strings*/
        private void SwapData(ref string n, ref string m)
        {
            string temp;
            temp = n;
            n = m;
            m = temp;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            
            //declare variables and array
            int pass=0, fail=0,size=(int)nudNumber.Value;
            int[] marks= new int[size];
            int i = 0;

            //check if seed value
            bool seed = chkSeed.Checked;

            //fill array using random number
            lstMarks.Items.Clear();
            if (seed)
            {
                Random random = new Random(1000);
                while( i < size)
                {
                    
                    marks[i] = random.Next(40, 101);
                    lstMarks.Items.Add(marks[i].ToString());
                    i++;
                }
            
        }
            else {
                while (i < size)
                {
                    marks[i] = rand.Next(40, 101);
                    lstMarks.Items.Add(marks[i].ToString());
                    i++;
                } }

                //call CalcStats sending and returning data
                double avg = CalcStats(marks, ref pass, ref fail);

            //display data sent back in labels - average, pass and fail
            lblPass.Text = pass.ToString();
            lblFail.Text = fail.ToString();
            // Format average always showing 2 decimal places 
            lblAverage.Text = avg.ToString("f2");

        } // end Generate click

        private void radOneRoll_CheckedChanged(object sender, EventArgs e)
        {
            grpMarkStats.Visible = false;
            ClearStats();
            grpOneRoll.Visible = true;
        }

        private void radRollStats_CheckedChanged(object sender, EventArgs e)
        {
            grpOneRoll.Visible = false;
            ClearOneRoll();
            grpMarkStats.Visible = true;
        }

        /* Name: CalcStats
        * Sent: array and 2 integers
        * Return: average (double) 
        * Run a foreach loop through the array.
        * Passmark is 60%
        * Calculate average and count how many marks pass and fail
        * The pass and fail values must also get returned for display*/
        private double CalcStats(int[] array, ref int a, ref int b)
        {
            double average;
            int sum=0;
            a = 0;
            foreach (int ar in array)
            {
                sum += ar;
                if (ar >= 60)
                {
                    a++;
                }
            }
            b = (array.Length) - a;



            average = Convert.ToDouble(sum) / Convert.ToDouble(array.Length);
            return average;
        }

        private void chkSeed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeed.Checked)
            {
                DialogResult selection = MessageBox.Show("Are you sure you want a seed value ?",
                        "Confirm Seed Value", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (selection)
                {
                    case DialogResult.Yes:
                        chkSeed.Checked = true;
                        break;
                    case DialogResult.No:
                        chkSeed.Checked = false;
                        break;
                }
            }

        }
    }
}
