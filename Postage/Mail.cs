using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postage
{
    //Types of packages
    public enum PackageType
    {
        Letter,
        Package
    }

    public enum CountryName
    {
        Denmark,
        England,
        USA
    }

    class Mail
    {
        private PackageType type;

        public PackageType Type
        {
            get { return type; }
            set { type = value; }
        }

        private double length;

        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        private double width;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        private double weight;


        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Mail(double length, double width, double weight, PackageType packageType)
        {
            Length = length;
            Width = width;
            Weight = weight;
            Type = packageType;
        }
    }
}
