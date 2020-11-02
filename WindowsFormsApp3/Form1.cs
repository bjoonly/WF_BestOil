using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{

    public partial class Form1 : Form
    {
        private int timeLeft=0;
        private const int timeMax = 5;
        private List<Gasoline> gasolines = new List<Gasoline>();
        private double fullProfit = 0;
        Timer timer;
        public Form1()
        {
            InitializeComponent();
            gasolines.Add(new Gasoline("A - 80", 10));
            gasolines.Add(new Gasoline("A - 92", 15));
            gasolines.Add(new Gasoline("A - 95", 20));
            gasolines.Add(new Gasoline("A - 95 + ", 25));
            gasolines.Add(new Gasoline("A - 98", 30));
            gasolines.Add(new Gasoline("A - 100", 35));

            petrolComboBox.Items.AddRange(gasolines.ToArray());
            petrolComboBox.SelectedItem = gasolines[0];
            pricePetrolTextBox.Text = gasolines[0].Price.ToString();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
        }

        private void PetrolComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pricePetrolTextBox.Text = ((Gasoline)petrolComboBox.SelectedItem).Price.ToString();
      
        }

        private void CountRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (countGasRadioButton.Checked)
            {
                countGasNumericUpDown.Enabled = true;
                countGasNumericUpDown.ReadOnly = false;
                sumGasNumericUpDown.Enabled = false;

                sumGasNumericUpDown.Value = sumGasNumericUpDown.Minimum;

                toPayGasGroupBox.Text = "To pay";
                ulToPayGasLabel.Text = "uah";

            }
            else
            {
                sumGasNumericUpDown.Enabled = true;
                sumGasNumericUpDown.ReadOnly = false;
                countGasNumericUpDown.Enabled = false;

                countGasNumericUpDown.Value = countGasNumericUpDown.Minimum;
                toPayGasGroupBox.Text = "For delivery";
                ulToPayGasLabel.Text = "l";

            }
        }

        private void countGasNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            toPayGasStationLabel.Text = String.Format("{0:f2}", (Convert.ToDecimal(pricePetrolTextBox.Text) * countGasNumericUpDown.Value));
           
        }

        private void sumGasNumericUpDown_ValueChanged(object sender, EventArgs e)
        {        
             toPayGasStationLabel.Text = String.Format("{0:f2}", (sumGasNumericUpDown.Value / Convert.ToDecimal(pricePetrolTextBox.Text)));
            
        }

        private void hotDogCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            countHotdogNumericUpDown.Enabled = ((CheckBox)sender).Checked;
            countHotdogNumericUpDown.ReadOnly = !((CheckBox)sender).Checked;
            countHotdogNumericUpDown.Value = 0;
            ToPayCafe(sender,e);
        }

        private void hamburgerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
          countHamburgerNumericUpDown.Enabled = ((CheckBox)sender).Checked;
          countHamburgerNumericUpDown.ReadOnly = !((CheckBox)sender).Checked;
            countHamburgerNumericUpDown.Value = 0;
            ToPayCafe(sender, e);
        }

        private void frenchFriesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            countFrenchFriesNumericUpDown.Enabled = ((CheckBox)sender).Checked;
            countFrenchFriesNumericUpDown.ReadOnly = !((CheckBox)sender).Checked;
            countFrenchFriesNumericUpDown.Value = 0;
            ToPayCafe(sender, e);
        }

        private void cocaColaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            countCocaColaNumericUpDown.Enabled = ((CheckBox)sender).Checked;
            countCocaColaNumericUpDown.ReadOnly = !((CheckBox)sender).Checked;
            countCocaColaNumericUpDown.Value = 0;
            ToPayCafe(sender, e);
        }

        private void ToPayCafe(object sender, EventArgs e)
        {
            decimal pay = 0;
            pay += Convert.ToDecimal(hotDogCheckBox.Tag) *Convert.ToInt32(countHotdogNumericUpDown.Value);
            pay += Convert.ToDecimal(cocaColaCheckBox.Tag) * Convert.ToInt32(countCocaColaNumericUpDown.Value);
            pay += Convert.ToDecimal(frenchFriesCheckBox.Tag) * Convert.ToInt32(countFrenchFriesNumericUpDown.Value);
            pay += Convert.ToDecimal(hamburgerCheckBox.Tag) * Convert.ToInt32(countHamburgerNumericUpDown.Value);
            ToPayCafeLabel.Text =String.Format("{0:f2}",pay);
           
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (countGasRadioButton.Checked)
                ToPayLabel.Text = String.Format("{0:f2}", Convert.ToDouble(toPayGasStationLabel.Text) + Convert.ToDouble(ToPayCafeLabel.Text));
            else
                ToPayLabel.Text = String.Format("{0:f2}", Convert.ToDecimal(ToPayCafeLabel.Text) + sumGasNumericUpDown.Value);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {    
            if (timeLeft < timeMax)
            {
                ++timeLeft;
            }
            else
            {
                timer.Stop();
                timeLeft = 0;
                var choose = MessageBox.Show("Clear form?", "Form cleaning",MessageBoxButtons.YesNoCancel);              
                if (choose == DialogResult.Yes)
                {
                    fullProfit += Convert.ToDouble(ToPayLabel.Text);
                    petrolComboBox.SelectedIndex = 0;
                    PetrolComboBox_SelectionChangeCommitted(petrolComboBox, e);
                    countGasRadioButton.Checked = true;
                    countGasNumericUpDown.Value = countGasNumericUpDown.Minimum;
                    hotDogCheckBox.Checked = false;
                    cocaColaCheckBox.Checked = false;
                    frenchFriesCheckBox.Checked = false;
                    hamburgerCheckBox.Checked = false;
                    ToPayLabel.Text = "0,00";
                    
                }
                else
                {
                    timer.Start();
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show($"Full profit: {fullProfit}", "Full profit for day", MessageBoxButtons.OKCancel);
        }
    }
}
