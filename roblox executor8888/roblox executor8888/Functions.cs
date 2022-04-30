using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace roblox_executor8888
{
    class Functions
    {
        public static void PopulateScripts(Scripts lsb, string Folder, string FileType)
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles(FileType);
            foreach (FileInfo file in Files)
            {
                //lsb.Items.Add(file.Name);
            }
        }
    }
}
