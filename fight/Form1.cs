namespace fight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            bool temp = false;
            if (random.Next(6) == 1)
            {
                temp = true;
            }
            Doge Dog = new Doge(Dog, random.Next(21), random.Next(4), random.Next(11), random.Next(35), random.Next(11), temp);
        }
    }
}
