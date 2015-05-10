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

        private static readonly string filePath = "HighScores.bin";

        public static void WriteToBinaryFile<T>(T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        public static T ReadFromBinaryFile<T>()
        {
            if (File.Exists(filePath))
            {
                using (Stream stream = File.Open(filePath, FileMode.Open))
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    return (T)binaryFormatter.Deserialize(stream);
                }
            }
            return default(T);
        }

        private static Serializer Instance;

        public static Serializer GetSerializer()
        {
            if (Instance == null)
            {
                Instance = new Serializer();
                HighScores = ReadFromBinaryFile<List<PlayerScore>>();
                if (HighScores == null)
                {
                    HighScores = new List<PlayerScore>();
                }
            }
            return Instance;
        }


        public static string GetString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                if (i < HighScores.Count - 1)
                {
                    sb.Append(string.Format("{0}. {1}", (i + 1), HighScores[i]));
                }
                else
                {
                    sb.Append(string.Format("{0}. ", i + 1));
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }


        public static void AddPlayer(PlayerScore score)
        {
            HighScores.Add(score);
        }

        public static void SaveScores()
        {
            HighScores.Sort(new PlayerComparator());
            WriteToBinaryFile<List<PlayerScore>>(HighScores);
        }

        public List<PlayerScore> GetScores()
        {
            return HighScores;
        }

    }
}
