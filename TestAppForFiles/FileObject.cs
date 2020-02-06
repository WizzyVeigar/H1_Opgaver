using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppForFiles
{
    class FileObject
    {
        private string path;

        public string Name
        {
            get { return path; }
            set { path = value; }
        }


        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
