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
        private string path = Directory.GetCurrentDirectory();

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        /// <summary>
        /// Creates a file from a specified path
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="data"></param>
        public void CreateNewFile(string fileName, string data)
        {
            File.WriteAllText(fileName + ".txt", data);
        }

        /// <summary>
        /// Deletes a file from a specified path
        /// </summary>
        /// <param name="Path"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Reads the content of a specified file 
        //How to make this idiotproof?
        /// </summary>
        /// <param name="Path"></param>
        /// <returns></returns>
        public string ReadFile(string Path)
        {
            return File.ReadAllText(Directory.GetCurrentDirectory() + path);
        }

        /// <summary>
        /// Creates a directory at /bin/debug plus the specified path
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        internal bool CreateDirectory(string data)
        {
            //Probably should not write GetCurrentDirectory twice
            if (!Directory.Exists(Directory.GetCurrentDirectory() + data))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + data);
                return true;
            }
            else
                return false;

        }

        /// <summary>
        /// Reads all files in chosen directory with <paramref name="directory"/> 
        /// </summary>
        /// <returns>returns all found files</returns>
        public List<string> ReadAllFiles(string directory)
        {
            List<string> files = new List<string>();

            //foreach (string file in Directory.GetFiles(Path))
            foreach (string file in Directory.GetFiles(Environment.CurrentDirectory + directory))
            { 
                files.Add(file);
            }
            return files;
        }

        /// <summary>
        /// Reads all files in base directory 
        /// </summary>
        /// <returns>returns all found files</returns>
        public List<string> ReadAllFiles()
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
