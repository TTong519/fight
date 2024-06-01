namespace fight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Game game;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (game.Turn == Turn.Start)
            {
                if (game.Turn == Turn.Dog)
                {
                    CatMoves.Enabled = false;
                    DogMoves.Enabled = true;
                }
                if (game.Turn == Turn.Cat)
                {
                    CatMoves.Enabled = true;
                    DogMoves.Enabled = false;
                }

                if (DogHealth.Value == 0 || CatHealth.Value == 0)
                {
                    game.Turn = Turn.End;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            bool temp = false;
            if (random.Next(6) == 1)
            {
                temp = true;
            }
            Doge Dog = new Doge("Dog", random.Next(21), random.Next(11), random.Next(11), random.Next(36), random.Next(11), temp);
            Cat cat = new Cat("Cat", random.Next(10), random.Next(6), random.Next(10), random.Next(41), random.Next(16), false);
            game = new Game(cat, Dog);
            DogHealth.Maximum = game.Dog.health;
            DogHealth.Value = game.Dog.health;
            CatHealth.Maximum = game.Cat.health;
            CatHealth.Value = game.Cat.health;
        }

        private void Bite_Click(object sender, EventArgs e)
        {

        }
    }
}
