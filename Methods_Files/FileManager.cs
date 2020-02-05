using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Methods_Files
{
    class FileManager
    {
        private string path;

        public string Path
        {
            get { return path; }
            set { path = @".\"; }
        }

        public void CreateNewFile(string fileName, string data)
        {
            File.WriteAllText(fileName + ".txt", data);
        }

        public bool DeleteFile(string Path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                return true;
            }
            else
                return false;
        }

        public string ReadFile(string Path)
        {
            return File.ReadAllText(path + ".txt");
        }

        public List<string> ReadFilesInDirectory()
        {
            List<string> files = new List<string>();

            //foreach (string file in Directory.GetFiles(Path))
            foreach (string file in Directory.GetFiles(Environment.CurrentDirectory))
            {
                files.Add(file);
            }
            return files;
        }
    }
}
