using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMP3Project.Models
{
    public class Mp3Directory
    {
        public string Name { get; }

        public Mp3Directory(string name) => Name = name;
    }
}
