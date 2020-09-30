using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5
{
    class Storage
    {
        private string FName;
        public Storage(string FileName)
        {
            this.FName = FileName;
        }

        public bool SaveLibrary(Library lib)
        {
            bool res = false;
            try
            {
                File.WriteAllText(FName, lib.GetAllBooks());
                res = true;
            }
            catch (Exception e)
            {

            }

            return res;
        }
    }
}
