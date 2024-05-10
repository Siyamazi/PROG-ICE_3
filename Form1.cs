namespace PROG_ICE_3
{
    public partial class Form1 : Form
    {
        private const string Frappe = "Frapp";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (comboName.SelectedItem.ToString() == "Latte")
            {
                if (comboType.SelectedItem.ToString() == "Frappe")
                {
                    txbTotal.Text = (float.Parse(comboQuantity.Text) * 40).ToString();
                }
                if (comboType.SelectedItem.ToString() == "Ice")
                {
                    txbTotal.Text = (float.Parse(comboQuantity.Text) * 50).ToString();
                }
                if (comboType.SelectedItem.ToString() == "Hot")
                {
                    txbTotal.Text = (float.Parse(comboQuantity.Text) * 45).ToString();
                }
                dataGridView1.Rows.Add(txbID.Text, comboName.Text, comboType.Text, comboQuantity.Text, txbTotal.Text);
            }
            if (comboName.SelectedItem.ToString() == "Cappuccino")
            {
                if (comboType.SelectedItem.ToString() == "Frappe")
                {
                    txbTotal.Text = (float.Parse(comboQuantity.Text) * 30).ToString();
                }
                if (comboType.SelectedItem.ToString() == "Ice")
                {
                    txbTotal.Text = (float.Parse(comboQuantity.Text) * 35).ToString();
                }
                if (comboType.SelectedItem.ToString() == "Hot")
                {
                    txbTotal.Text = (float.Parse(comboQuantity.Text) * 40).ToString();
                }
                dataGridView1.Rows.Add(txbID.Text, comboName.Text, comboType.Text, comboQuantity.Text, txbTotal.Text);
            }
            if (comboName.SelectedItem.ToString() == "Chocolate")
            {
                if (comboType.SelectedItem.ToString() == "Frappe")
                {
                    txbTotal.Text = (float.Parse(comboQuantity.Text) * 25).ToString();
                }
                if (comboType.SelectedItem.ToString() == "Ice")
                {
                    txbTotal.Text = (float.Parse(comboQuantity.Text) * 35).ToString();
                }
                if (comboType.SelectedItem.ToString() == "Hot")
                {
                    txbTotal.Text = (float.Parse(comboQuantity.Text) * 45).ToString();
                }
            }
            dataGridView1.Rows.Add(txbID.Text, comboName.Text, comboType.Text, comboQuantity.Text, txbTotal.Text);
        }

        private void txbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbID.Text = "";
            comboName.Text = "";
            comboQuantity.Text = "";
            comboType.Text = "";
            txbTotal.Text = "";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
