using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsVP
{
    public class Serializer
    {

        private static List<PlayerScore> HighScores;

        private static void BinarySerialize(List<PlayerScore> list)
        {
            using (FileStream str = File.Create("Scores.bin"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(str, list);
            }
        }

        private static List<PlayerScore> BinaryDeserialize()
        {
            List<PlayerScore> people = new List<PlayerScore>();
            if (File.Exists("Scores.bin"))
            {
                using (FileStream str = File.OpenRead("Scores.bin"))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    people = bf.Deserialize(str) as List<PlayerScore>;
                }
            }
            return people;
        }

        private static Serializer Instance;

        public static Serializer GetSerializer()
        {
            if (Instance == null)
            {
                Instance = new Serializer();
                if (File.Exists("Scores.bin"))
                {
                    File.Create("Scores.bin");
                }
                HighScores = BinaryDeserialize();
            }

            return Instance;
        }

        public static List<PlayerScore> GetScores(){
            return HighScores;
        }

        public static void AddPlayer(PlayerScore score)
        {
            HighScores.Add(score);
        }

        public static void SaveScores()
        {
            BinarySerialize(HighScores);
        }

    }
}
