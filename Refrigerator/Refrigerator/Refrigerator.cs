using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refrigerator
{
    public partial class Form1 : Form
    {
        RefrigeratorAnother _refrigerator = new RefrigeratorAnother();
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _refrigerator.MaxWeight = Convert.ToDouble(maximumWeightEntiyTextBox.Text);
                maximumWeightEntiyTextBox.Clear();

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
           
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                _refrigerator.NumberOfItems = Convert.ToInt32(noOfItemsextBox.Text);
                _refrigerator.WeightPerItem = Convert.ToInt32(weightTextBox.Text);

                noOfItemsextBox.Clear();
                weightTextBox.Clear();

                currentTextBox.Text = _refrigerator.GetCurrentWeight().ToString();

                remanigTextBox.Text = _refrigerator.GetRemainingtWeight().ToString();

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
           
        }
    }
}
