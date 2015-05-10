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
            return string.Format("{0:20}\t{1:10}", Name, Score);
        }

    }
}
