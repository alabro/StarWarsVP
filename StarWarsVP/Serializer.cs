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


        private static void BinarySerialize(ArrayList list)
        {
            using (FileStream str = File.Create("Scores.bin"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(str, list);
            }
        }

        private static ArrayList BinaryDeserialize()
        {
            ArrayList people = null;
            using (FileStream str = File.OpenRead("Scores.bin"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                people = (ArrayList)bf.Deserialize(str);
            }
            return people;
        }

        public static Serializer Instance;

        public Serializer GetSerializer()
        {
            if (Instance == null)
            {
                Instance = new Serializer();
            }

            return Instance;
        }
    }
}
