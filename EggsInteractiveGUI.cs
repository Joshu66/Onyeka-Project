using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.data;
using System.Drawing;
using System.Windows.Forms;



namespace EggsInteractiveGUI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            lblResult.Visible = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Call function
            calculate();

        }
        void calculate()
        {
            int sum = 0;
            int egg1, egg2, egg3, egg4, egg5;
            if(!int.TryParse(txtChicken1.Text,out egg1))
            {
            MessageBox.Show("Enter valid input..");
            }
            else if (!int.TryParse(txtChicken2.Text, out egg2))
            {
            MessageBox.Show("Enter valid input..");
            }
            else if (!int.TryParse(txtChicken3.Text, out egg3))
            {
            MessageBox.Show("Enter valid input..");
            }
            else if (!int.TryParse(txtChicken4.Text, out egg4))
            {
            MessageBox.Show("Enter valid input..");
            }
            else if (!int.TryParse(txtChicken5.Text, out egg5))
            {
            MessageBox.Show("Enter valid input..");
            }
            else
            {
            sum = egg1 + egg2 + egg3 + egg4 + egg5;
            // Find eggs in dozens
            int dozens = sum /12;
            int remaining = sum % 12;
            lblResult.Text = "A total of " + sum + " eggs is " + dozens + " dozen and " + remaining + " eggs";
            lblResult.Visible = true;
            }

        }
    }
}