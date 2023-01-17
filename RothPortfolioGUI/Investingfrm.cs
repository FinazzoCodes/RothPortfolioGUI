namespace RothPortfolioGUI
{
    public partial class Investingfrm : Form
    {
        public Investingfrm()
        {
            InitializeComponent();
        }
        private void Investingfrm_Load(object sender, EventArgs e)
        {
            // Doesn't work, but when application opens I want it to start on the textbox
            txtPay.SelectAll();
            txtPay.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Application closes when user clicks exit button
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear all the inputs and outputs when user clicks reset button
            txtPay.Clear();
            rad15.Checked = true;
            lblResultsFZROX.Text = "0";
            lblResultsFZILX.Text = "0";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double totalPay = 0;
            double fzroxResult = 0;
            double fzilxResult = 0;

            // If Pay textbox value is valid
            if (double.TryParse(txtPay.Text, out totalPay) && totalPay > 0)
            {

                // Determine which radiobutton is checked
                if (rad15.Checked)
                {
                    fzroxResult = (totalPay * .15) * .70;     // 15% of total pay is going into investment, 70% of investment money into FZROX
                    fzilxResult = (totalPay * .15) * .30;     // 15% of total pay is going into investment, 30% of investment money into FZILX
                }
                else if (rad10.Checked)
                {
                    fzroxResult = (totalPay * .10) * .70;
                    fzilxResult = (totalPay * .10) * .30;
                }
                else
                {
                    fzroxResult = (totalPay * .20) * .70;
                    fzilxResult = (totalPay * .20) * .30;
                }

                // Display results
                lblResultsFZROX.Text = ($"$ {fzroxResult}");
                lblResultsFZILX.Text = ($"$ {fzilxResult}");
            }
            else
            {
                // Display error message & focus error
                MessageBox.Show("Canno't be calculated. Please enter your total pay as numerical values in the textbox.", "RothIRA Investor", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPay.SelectAll();
                txtPay.Focus();
            }

        }
    }
}