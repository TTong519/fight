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
        public Cat Cat1;
        public Doge Dog;

    }
}
