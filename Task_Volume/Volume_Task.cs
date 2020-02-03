using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Volume
{

    class Volume_Task
    {
        Box box;

        public void CreateBox(float width, float height, float length)
        {
            box = new Box(height, length, width); 
        }
        public string CalculateVolume()
        {
            return box.CalculateVolume(); 
        }

    }

    class Box
    {
        private float height;

        public float Height
        {
            get { return height; }
            set { height = value; }
        }
        private float length;

        public float Length
        {
            get { return length; }
            set { length = value; }
        }

        private float width;

        public float Width
        {
            get { return width; }
            set { width = value; }
        }

        public Box(float height, float length, float width)
        {
            Height = height;
            Length = length;
            Width = width;
        }


        //the box shouldn't know how to calculate itself
        public string CalculateVolume()
        {
            return "The Volume is: " + (Length * Height * Width).ToString();
        }
    }
}
