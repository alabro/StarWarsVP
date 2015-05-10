using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsVP
{
    [Serializable]
    public class PlayerScore : Comparer<PlayerScore>
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

        public override int Compare(PlayerScore x, PlayerScore y)
        {
            return x.Score.CompareTo(y.Score);
        }

        public override bool Equals(object obj)
        {
            return Score.CompareTo((obj as PlayerScore).Score)==0;
        }
    }

    public class PlayerComparator : Comparer<PlayerScore>{

        public override int Compare(PlayerScore x, PlayerScore y)
        {
            return x.Score.CompareTo(y.Score);
        }
    }
     
}
