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
        private string dirPath = Directory.GetCurrentDirectory();

        public string DirPath
        {
            get { return dirPath; }
            set { dirPath = value; }
        }

        /// <summary>
        /// Creates a file from a specified path, while checking for invalid characters
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="data"></param>
        public bool CreateNewFile(string fileName, string data)
        {
            if (ContainsInvalidFileChar(fileName))
            {
                return false;
            }

            File.WriteAllText(fileName + ".txt", data);
            return true;
        }

        internal bool CreateNewFile(string directory, string fileName, string data)
        {
            if (ContainsInvalidFileChar(fileName) || ContainsInvalidDirChar(directory))
            {
                return false;
            }

            File.WriteAllText(directory + ".txt" , data);
            return true;
        }

        /// <summary>
        /// Deletes a file from a specified path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool DeleteFile(string path)
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
        public string ReadFile(string fileName)
        {
            return File.ReadAllText(Directory.GetCurrentDirectory() + fileName);
        }

        /// <summary>
        /// Creates a directory at /bin/debug plus the specified path
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        internal bool CreateDirectory(string data)
        {
            //Checks if the wanted directory has invalid characters
            if (ContainsInvalidDirChar(data))
                return false;

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
        /// <returns>returns a list containing all found files</returns>
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

        /// <summary>
        /// Checks <paramref name="fileName"/> for invalid characters
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>Returns true if <paramref name="fileName"/> has forbidden characters, otherwise returns false</returns>
        public bool ContainsInvalidFileChar(string fileName)
        {
            char[] chars = Path.GetInvalidFileNameChars();

            if (string.IsNullOrWhiteSpace(fileName))
                return true;

            foreach (char item in chars)
            {
                if (fileName.Contains(item.ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Checks <paramref name="dirName"/> for invalid characters
        /// </summary>
        /// <param name="dirName"></param>
        /// <returns>Returns true if <paramref name="dirName"/> contains forbidden characters, otherwise returns false</returns>
        public bool ContainsInvalidDirChar(string dirName)
        {
            char[] chars = Path.GetInvalidPathChars();

            if (string.IsNullOrWhiteSpace(dirName))
                return true;

            foreach (char item in chars)
            {
                if (dirName.Contains(item.ToString()))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
