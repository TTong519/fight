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
        bool isLast;
        Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            DogHealth.Value = game.Dog.health;
            CatHealth.Value = game.Cat.health;
            if (game.Cat.isinfected)
            {
                CatRabiesIndicator.BringToFront();
            }
            if (game.Dog.hasRabies)
            {
                DogRabiesIndicator.BringToFront();
            }
            if (game.Turn != Turn.End)
            {
                if (game.Turn == Turn.Start)
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
                if (isCatTurnUse)
                {
                    game.Turn = Turn.Dog;
                    isCatTurnUse = false;
                    if (game.Cat.isinfected)
                    {
                        game.Cat.health -= 15;
                        if (game.Cat.health < 0)
                        {
                            game.Cat.health = 0;
                        }
                    }
                    if (game.Dog.hasRabies)
                    {
                        game.Dog.health -= 5;
                        if (game.Dog.health < 0)
                        {
                            game.Dog.health = 0;
                        }
                    }
                }
                if (isDogTurnUse)
                {
                    game.Turn = Turn.Cat;
                    isDogTurnUse = false;
                    game.Cat.isWaterBodyActive = false;
                    if (game.Cat.health <= 30)
                    {
                        game.Cat.isWaterBodyActive = true;
                    }
                    if (game.Cat.isinfected)
                    {
                        game.Cat.health -= 15;
                        if (game.Cat.health < 0)
                        {
                            game.Cat.health = 0;
                        }
                    }
                    if (game.Dog.hasRabies)
                    {
                        game.Dog.health -= 5;
                        if (game.Dog.health < 0)
                        {
                            game.Dog.health = 0;
                        }
                    }
                }
                if (DogHealth.Value == 0 || CatHealth.Value == 0)
                {
                    game.Turn = Turn.End;
                }
            }
            else
            {
                panel1.BringToFront();
                if (DogHealth.Value == 0)
                {
                    game.GameWinner = Game.Winner.Cat;
                }
                else
                {
                    game.GameWinner = Game.Winner.Dog;
                }
                switch (game.GameWinner)
                {
                    case Game.Winner.Cat:
                        label3.Text = "CAT wins";
                        break;
                    case Game.Winner.Dog:
                        label3.Text = "DOG wins";
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
                game.Cat.health -= (game.Dog.attacks[0].damage / 10) * 2;
            }
            else
            {
                game.Cat.health -= game.Dog.attacks[0].damage;
            }
            if (game.Cat.health < 0)
            {
                game.Cat.health = 0;
            }
            if (game.Dog.hasRabies)
            {
                game.Cat.isinfected = true;
            }
            isDogTurnUse = true;
        }

        private void Kick_Click(object sender, EventArgs e)
        {
            if (game.Cat.isWaterBodyActive)
            {
                game.Cat.health -= (game.Dog.attacks[1].damage / 10) * 2;
            }
            else
            {
                game.Cat.health -= game.Dog.attacks[1].damage;
            }
            if (game.Cat.health < 0)
            {
                game.Cat.health = 0;
            }
            isDogTurnUse = true;
        }

        private void Heal_Click(object sender, EventArgs e)
        {
            game.Dog.health -= game.Dog.attacks[2].damage;
            if (game.Dog.health > DogHealth.Maximum)
            {
                game.Dog.health = DogHealth.Maximum;
            }
            isDogTurnUse = true;
        }

        private void Scratch_Click(object sender, EventArgs e)
        {
            game.Dog.health -= game.Cat.attacks[0].damage;
            if (game.Dog.health < 0)
            {
                game.Dog.health = 0;
            }
            isCatTurnUse = true;
        }

        private void Bite2_Click(object sender, EventArgs e)
        {
            game.Dog.health -= game.Cat.attacks[1].damage;
            if (game.Dog.health < 0)
            {
                game.Dog.health = 0;
            }
            isCatTurnUse = true;
        }

        private void WaterBody_Click(object sender, EventArgs e)
        {
            game.Cat.isWaterBodyActive = true;
            isCatTurnUse = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.ResetGame(random);
            panel1.SendToBack();
            DogHealth.Maximum = game.Dog.health;
            DogHealth.Value = game.Dog.health;
            CatHealth.Maximum = game.Cat.health;
            CatHealth.Value = game.Cat.health;
            DogRabiesIndicator.SendToBack();
            CatRabiesIndicator.SendToBack();
        }
    }
}
