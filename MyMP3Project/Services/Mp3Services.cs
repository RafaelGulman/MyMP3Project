using Microsoft.VisualBasic;
using MyMP3Project.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMP3Project.Services
{
    public static class Mp3Services
    {
        public static ObservableCollection<Mp3Directory> InitializeObservableCollection()
        {
            ObservableCollection<Mp3Directory> collection = new ObservableCollection<Mp3Directory>();

            foreach(var disk in Directory.GetLogicalDrives())
            {
                collection.Add(new Mp3Directory(disk));
            }

            return collection;
        }
    }
}
