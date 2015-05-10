using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsVP
{
    [Serializable]
    public class PlayerScore
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public PlayerScore(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public override string ToString()
        {
            return string.Format("{0,-30} \t{1,10}{2,10}", Name, "Score: ",Score);
        }

    }

    public class PlayerComparator : Comparer<PlayerScore>{

        public override int Compare(PlayerScore x, PlayerScore y)
        {
            return y.Score.CompareTo(x.Score);
        }
    }
     
}
