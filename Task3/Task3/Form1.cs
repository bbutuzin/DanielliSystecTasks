namespace Task3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        string calTotal;
        int num1;
        int num2;
        String option;
        int result;

        private void button3_Click(object sender, EventArgs e) {
            option = "*";
            num1 = int.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void button17_Click(object sender, EventArgs e) {
            txtDisplay.Text = txtDisplay.Text + btn1.Text;
        }


        private void button13_Click(object sender, EventArgs e) {
            txtDisplay.Text = txtDisplay.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e) {
            txtDisplay.Text = txtDisplay.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e) {
            txtDisplay.Text = txtDisplay.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e) {
            txtDisplay.Text = txtDisplay.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e) {
            txtDisplay.Text = txtDisplay.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e) {
            txtDisplay.Text = txtDisplay.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e) {
            txtDisplay.Text = txtDisplay.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e) {
            txtDisplay.Text = txtDisplay.Text + btn9.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e) {
            option = "+";
            num1 = int.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e) {
            option = "-";
            num1 = int.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e) {
            option = "/";
            num1 = int.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnEql_Click(object sender, EventArgs e) {
            
            num2 = int.Parse(txtDisplay.Text);

            if (option.Equals("+")) {
                result = num1 + num2;
            }
            if (option.Equals("-")) {
                result = num1 - num2;
            }
            if (option.Equals("*")) {
                result = num1 * num2;
            }
            if (option.Equals("/")) {
                result = num1 / num2;
            }
            txtDisplay.Text = result + "";
            
        }

        private void btnClear_Click(object sender, EventArgs e) {
            txtDisplay.Clear();
        }
    }
}