using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMP3Project.Models
{
    public class Mp3Directory
    {
        public string CurrentDirectory { get; }

        public Mp3Directory(string curr)
        {
            CurrentDirectory = curr;
        }
    }
}
