using System;
using System.IO;
using Pet_Game;

namespace Pet.Game.Services
{
    public class FileDatabaseService
    {
        private string filePath1, filePath2, filePath3;
        public FileDatabaseService()
        {
            filePath1 = Environment.CurrentDirectory + @"\" + Constants.fileName1;
            filePath2 = Environment.CurrentDirectory + @"\" + Constants.fileName2;
        }
        public string[] ReadMaps()
        {
            if (File.Exists(filePath1))
                return File.ReadAllLines(filePath1);
            else
                return null;
        }
        public string[] ReadPets()
        {
            if (File.Exists(filePath2))
                return File.ReadAllLines(filePath2);
            else
                return null;
        }
        public void UpdateFile1(string data)
        {
            File.WriteAllText(filePath1, data);
        }
        public void UpdateFile2(string data)
        {
            File.WriteAllText(filePath2, data);
        }
    }
}
