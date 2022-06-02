using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Settings
    {

        public static int Width { get; set; }
        public static int Height { get; set; }

        public static string directions;

        public Settings()
        {
            Width = 19;
            Height = 19;
            directions = "left";
        }

    }
}
