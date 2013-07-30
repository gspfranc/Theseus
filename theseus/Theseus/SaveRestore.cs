using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Theseus
{
    public class SaveRestore
    {

        public void save(String FileName, Labyrinth lab)
        {
            Stream TestFileStream = File.Create(FileName);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(TestFileStream, lab);
            TestFileStream.Close();
        }

        public Labyrinth restore(String FileName)
        {
            Labyrinth lab = null;
            if (File.Exists(FileName))
            {
                Stream TestFileStringWriter = File.OpenRead(FileName);
                BinaryFormatter deserializer = new BinaryFormatter();
                lab = (Labyrinth)deserializer.Deserialize(TestFileStringWriter);
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
