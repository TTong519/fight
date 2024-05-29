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
        public Turn Turn = Turn.Start;
        public Cat Cat;
        public Doge Dog;
        public Rabies Rabies1;
        public Game(Cat cat, Doge dog)
        {
            Cat = cat;
            Dog = dog;
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
