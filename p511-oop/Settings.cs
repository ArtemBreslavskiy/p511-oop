using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Settings
    {
        public string Language { get; set; } = "English";
        public int VolumeLevel { get; set; } = 50;
        public int Brightness { get; set; } = 50;
        public int TextSize { get; set; } = 10;
        public bool IsDarkMode { get; set; } = false;
    }
}
