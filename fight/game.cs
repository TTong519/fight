using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public enum Turn
{
    Dog,
    Cat,
    End,
    Start
};
namespace fight
{
    public class Game
    {
        public enum Winner
        {
            Cat,
            Dog,
            Undecided
        }
        public Turn Turn = Turn.Start;
        public Cat Cat;
        public Doge Dog;
        public Rabies Rabies1;
        public Winner GameWinner = Winner.Undecided;
        public Game(Cat cat, Doge dog)
        {
            Cat = cat;
            Dog = dog;
        }
        public void ResetGame(Random random)
        {
            bool temp = false;
            if (random.Next(6) == 1)
            {
                temp = true;
            }
            Cat cat = new Cat("Cat", random.Next(10), random.Next(6), random.Next(10), random.Next(41), random.Next(16));
            Doge dog = new Doge("Dog", random.Next(21), random.Next(11), random.Next(11), random.Next(36), random.Next(11), temp);
            Cat = cat;
            Dog = dog;
            Turn = Turn.Start;
        }
        public void doSP()
        {
            if (Dog.hasRabies)
            {
                Dog.health += Rabies1.eff/3;
            }
            if (Cat.isinfected)
            {
                Cat.health += Rabies1.eff;
            }
        }
    }
}
