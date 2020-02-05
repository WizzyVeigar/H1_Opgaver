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

        internal void CreateFile(string fileName, string data)
        {
            fileManager.CreateNewFile(fileName, data);
        }

        internal bool DeleteFile(string data)
        {
            if (fileManager.DeleteFile(data))
                return true;
            else
                return false;
            
        }

        internal List<string> DisplayFiles()
        {
            return fileManager.ReadFilesInDirectory();
        }

        internal void AddFolder(string data)
        {
            throw new NotImplementedException();
        }
    }
}
