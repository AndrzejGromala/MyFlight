using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFlight
{
    public partial class frmEstimate : Form
    {
        public const double dblVatRate = 0.23;
        public double dblStandartLaguagePrice = 10.00;
        public double dblExtraRate = 0.5;
        
        public double dblPriceOfFlight;
        public double dblPriceofBaggage;
        public frmEstimate()
        {
            InitializeComponent();
            panelDatesPrices.Visible = false;
            //the problem will be solved if i pass the values again to the prices under clear button
            //i think that it's the problem with passing the variables in the first place so it will be better
            //to move them to a method
        }

        //METHOD FOR THE GO BUTTON
        public void GoButtonPressed()
        {
         

            //validating if the fields are empty
            if (String.IsNullOrEmpty(txtExchangeRate.Text)|| String.IsNullOrEmpty(txtLondon.Text) ||
                String.IsNullOrEmpty(txtMenchaster.Text) || String.IsNullOrEmpty(txtLiverPool.Text) ||
                String.IsNullOrEmpty(txtNewCastle.Text))
            {
                MessageBox.Show("Exchange Rate or Prices not entered", "Reminder", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }else
            {
                panelExchangeRate.Visible = false;
                panelPrices.Visible = false;
                panelDatesPrices.Visible = true;
                lblEuroFlights.ForeColor = Color.RoyalBlue;
                panelSecondDatePicker.Visible = false;
            }

             

        }
        //METHOD FOR CALCULATING THE PRICES WITHOUT VAT
        public double PriceExcludingVat()
        {

            double priceStandard = 10;
            double priceExtra = 15;
            double result;

            result = dblPriceOfFlight;
            double flightTotal = 0;
            if (checkReturnFlight.Checked)
            {
                priceStandard = 20;
                priceExtra = 30;
                result = result * 2;
                if (radioStandard.Checked)
                {
                    flightTotal = result + priceStandard;
                }
                else if (radioExtra.Checked)
                {
                    flightTotal = result + priceExtra;
                }
            }
            else
            {
                if (radioStandard.Checked)
                {
                    flightTotal = result + priceStandard;
                }
                else if (radioExtra.Checked)
                {
                    flightTotal = result + priceExtra;
                }
            }
            return flightTotal;

        }
        //method for passing the values
        public void PriceSelection()
        {
            if (radioLondon.Checked)
            {
                double dblLondonPrice = double.Parse(txtLondon.Text);
                dblPriceOfFlight = dblLondonPrice;
            }
            else if (radioManchester.Checked)
            {
                double dblMenchesterPrice = double.Parse(txtMenchaster.Text);
                dblPriceOfFlight = dblMenchesterPrice;
            }
            else if (radioLiverPool.Checked)
            {
                double dblLiverPoolPrice = double.Parse(txtLiverPool.Text);
                dblPriceOfFlight = dblLiverPoolPrice;
            }
            else if (radioNewCastle.Checked)
            {
                double dblNewCastlePrice = double.Parse(txtNewCastle.Text);
                dblPriceOfFlight = dblNewCastlePrice;
            }
        }
     

        private void panelDatesPrices_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkReturnFlight_CheckedChanged(object sender, EventArgs e)
        {
            if (checkReturnFlight.Checked)
                panelSecondDatePicker.Visible = true;
            else if (checkReturnFlight.Checked == false)
                panelSecondDatePicker.Visible = false;
        }

        private void dateTimePickerReturn_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerDeparture.Value < dateTimePickerReturn.Value)
                MessageBox.Show("Departure date must be earlier than arrival date");
        }

        private void exitFromTopMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit the program?", "Reminder", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit the program?", "Reminder", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
        }

        private void cdmGO_Click(object sender, EventArgs e)
        {
            GoButtonPressed();
        }

        private void txtLondon_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMenchester_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtLiverPool_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txtNewCastle_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            //getting the values
            PriceSelection();
            //displey for GBP vat no vat
            double dblExchangeRate = double.Parse(txtExchangeRate.Text);
        double dblPriceIncludingVat;
            txtCostExcludingVatGbp.Text = PriceExcludingVat().ToString();
            dblPriceIncludingVat = (PriceExcludingVat() * dblVatRate) + PriceExcludingVat();
            txtCostIncludingVAtGBP.Text = dblPriceIncludingVat.ToString();
            //display for Euro vat no vat
            txtCostExcludingVatEuro.Text = (double.Parse(txtCostExcludingVatGbp.Text) * dblExchangeRate).ToString();
            txtCostIncludingVatEuro.Text = (dblPriceIncludingVat * dblExchangeRate).ToString();

            //display for the yellow label
            //lblOutput.Text = 

        }

        private void txtCostExcludingVatGbp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExchangeRate_TextChanged(object sender, EventArgs e)
        {
            //dblExchangeRate = double.Parse(txtExchangeRate.Text);
        }

        private void txtCostIncludingVAtGBP_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtCostIncludingVatEuro.Clear();
            txtCostExcludingVatEuro.Clear();
            txtCostExcludingVatGbp.Clear();
            txtCostIncludingVAtGBP.Clear();
            radioLondon.Checked = true;
            radioStandard.Checked = true;
            
        }

        private void radioLondon_CheckedChanged(object sender, EventArgs e)
        {
            
            
           
        }

        private void radioManchester_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioLiverPool_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioNewCastle_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioLondon_Enter(object sender, EventArgs e)
        {
            
        }

        private void radioLondon_Validated(object sender, EventArgs e)
        {
           
        }
    }
}
