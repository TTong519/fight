namespace fight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Game game;
        bool isDogTurnUse;
        bool isCatTurnUse;
        private void timer1_Tick(object sender, EventArgs e)
        {
            DogHealth.Value = game.Dog.health;
            CatHealth.Value = game.Cat.health;
            if (game.Turn != Turn.End)
            {
                if (game.Turn  == Turn.Start)
                {
                    game.Turn = Turn.Dog;
                }
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
            Cat cat = new Cat("Cat", random.Next(10), random.Next(6), random.Next(10), random.Next(41), random.Next(16));
            game = new Game(cat, Dog);
            DogHealth.Maximum = game.Dog.health;
            DogHealth.Value = game.Dog.health;
            CatHealth.Maximum = game.Cat.health;
            CatHealth.Value = game.Cat.health;
        }

        private void Bite_Click(object sender, EventArgs e)
          {
            if (game.Cat.isWaterBodyActive)
            {
                game.Cat.health -= (game.Dog.attacks[1].damage/10)*2;
            }
            else
            {
                game.Cat.health -= game.Dog.attacks[1].damage;
            }
            if(game.Cat.health < 0)
            {
                game.Cat.health = 0;
            }
            else if(game.Dog.health < 0)
            {
                game.Dog.health = 0;
            }
        }
    }
}
