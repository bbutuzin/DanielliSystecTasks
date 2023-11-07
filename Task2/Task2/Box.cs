using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2 {
    public class Box  {

            public int Height { get; }
            public int Width { get; }
            public int Length { get; }

            public Box(int length, int width, int height) {
                Height = height;
                Width = width;
                Length = length;
            }
        }
    }

