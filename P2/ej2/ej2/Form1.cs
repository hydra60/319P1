namespace ej2
{

    public partial class Form1 : Form
    {
        private Calculator calculator;
        private int numero = 0; 
        private String text;
        public Form1()
        {
            this.calculator = new Calculator();
            this.numero = 0;
            this.text = "";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.text = this.text + '1';
            textBox1.Text = this.text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.text = this.text + '2';
            textBox1.Text = this.text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.text = this.text + '3';
            textBox1.Text = this.text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.text = this.text + '4';
            textBox1.Text = this.text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.text = this.text + '5';
            textBox1.Text = this.text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.text = this.text + '6';
            textBox1.Text = this.text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.text = this.text + '7';
            textBox1.Text = this.text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.text = this.text + '8';
            textBox1.Text = this.text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.text = this.text + '9';
            textBox1.Text = this.text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.text = this.text + '0';
            textBox1.Text = this.text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //suma
            if (this.numero == 0)
            {
                this.calculator.Seta(Convert.ToInt32(textBox1.Text));
                textBox1.Text = "";
                this.text = "";
                this.numero = 1;
                this.calculator.SetOp("+");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //resta
            if (this.numero == 0)
            {
                this.calculator.Seta(Convert.ToInt32(textBox1.Text));
                textBox1.Text = "";
                this.text = "";
                this.numero = 1;
                this.calculator.SetOp("-");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //multiplication
            if (this.numero == 0)
            {
                this.calculator.Seta(Convert.ToInt32(textBox1.Text));
                textBox1.Text = "";
                this.text = "";
                this.numero = 1;
                this.calculator.SetOp("*");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //division
            if (this.numero == 0)
            {
                this.calculator.Seta(Convert.ToInt32(textBox1.Text));
                textBox1.Text = "";
                this.text = "";
                this.numero = 1;
                this.calculator.SetOp("/");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //reset
            textBox1.Text = "";
            this.text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //igual
            if (this.numero == 1) {
                this.numero = 0;
                this.calculator.Setb(Convert.ToInt32(textBox1.Text.Trim()));
                textBox1.Text = this.calculator.resultation().ToString();
                this.text = "";
            }
        }
    }
    public class Calculator
    {
        private int a;
        private int b;
        private int result;
        private String op;


        public String GetOp() {
            return op;
        }
        public void SetOp(String value) {
            this.op = value;
        }
        public int Getresult()
        {
            return result;
        }

        public void Setresult(int value)
        {
            result = value;
        }

        public int Getb()
        {
            return b;
        }

        public void Setb(int value)
        {
            b = value;
        }

        public int Geta()
        {
            return a;
        }

        public void Seta(int value)
        {
            a = value;
        }
        public Calculator()
        {
            this.Seta(0);
            this.Setb(0);
            this.Setresult(0);
        }
        public Calculator(int a, int b)
        {
            this.Seta(a);
            this.Setb(b);
        }

        public int suma()
        {
            return this.a + this.b;
        }
        public int resta()
        {
            return this.a - this.b;
        }
        public int multiplicasion()
        {
            return this.a * this.b;
        }
        public int div()
        {
            return this.a / this.b;
        }
        public int resultation() {
            if ("+".Equals(this.op)){
                return suma();
            }
            if ("-".Equals(this.op))
            {
                return resta();
            }
            if ("*".Equals(this.op))
            {
                return multiplicasion();
            }
            if ("/".Equals(this.op))
            {
                return div();
            }
            return 0;
        }
    }
}