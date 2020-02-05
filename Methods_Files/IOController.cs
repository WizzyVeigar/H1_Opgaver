using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Files
{
    class IOController
    {
        FileManager fileManager = new FileManager();
        
        /// <summary>
        /// Create a file using <paramref name="fileName"/> and what <paramref name="data"/> it should contain
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="data"></param>
        internal void CreateFile(string fileName, string data)
        {
            fileManager.CreateNewFile(fileName, data);
        }
        /// <summary>
        /// Delete a file given the <paramref name="name"/> of the file
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Return true if file was deleted successfully</returns>
        internal bool DeleteFile(string name)
        {
            if (fileManager.DeleteFile(name))
                return true;
            else
                return false;
            
        }
        /// <summary>
        /// Displays all files in current directory
        /// </summary>
        /// <returns>Returns a list of all files in the current directory</returns>
        internal List<string> DisplayFiles()
        {
            return fileManager.ReadAllFiles();
        }
        /// <summary>
        /// Creates a directory with the given <paramref name="path"/> 
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Returns true if successful in creating the directory</returns>
        internal bool AddFolder(string path)
        {
            if (fileManager.CreateDirectory(path))
                return true;
            else
                return false;
        }
        /// <summary>
        /// Uses the given <paramref name="directory"/> to search for files with <paramref name="keyword"/>
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="keyword"></param>
        /// <returns>Returns a list of all files containing <paramref name="keyword"/></returns>
        internal List<string> SearchForFiles(string directory, string keyword)
        {
            List<string> returnList = new List<string>();
            foreach (string file in fileManager.ReadAllFiles(directory))
            {
                if (file.Contains(keyword))
                    returnList.Add(file);
            }
            return returnList;
        }
    }
}
