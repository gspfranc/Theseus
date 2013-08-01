using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Theseus
{
    /// <summary>
    /// Classe servant à sauvegarder l'état d'un jeu pour le restorer plus tard.
    /// </summary>
    public class SaveRestore
    {
        public void save(String FileName, Maze lab)
        {
            Stream TestFileStream = File.Create(FileName);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(TestFileStream, lab);
            TestFileStream.Close();
        }

        public Maze restore(String FileName)
        {
            Maze lab = null;
            if (File.Exists(FileName))
            {
                Stream TestFileStringWriter = File.OpenRead(FileName);
                BinaryFormatter deserializer = new BinaryFormatter();
                lab = (Maze)deserializer.Deserialize(TestFileStringWriter);
                TestFileStringWriter.Close();
            }
            else
            {
                throw new Exception("File No Exist for Deserialisation");
            }

            return lab;
        }
    }
}
