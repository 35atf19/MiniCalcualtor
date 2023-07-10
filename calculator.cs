namespace Simple__Desktop_Calculator_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            int toplam;

            number1 = int.Parse(textBox1.Text);
            number2 = Convert.ToInt32(textBox2.Text);

            toplam = number1 + number2;
            label3.Text = toplam.ToString();


            
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number3;
            int number4;
            int carpim;

            number3 = int.Parse(textBox3.Text);
            number4 = Convert.ToInt32(textBox4.Text);

            carpim = number3 * number4;
            label8.Text = carpim.ToString();

        }
    }
}
