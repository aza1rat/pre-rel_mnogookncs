using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnogookno
{
     public class Pizza
     {
        string name;
        double price;
        string description;
        string image;

        public string Name { get { return name; } set { name = value; } }
        public double Price { get { return price; } set { price = value; } }
        public string Description { get { return description; } set { description = value; } }

        public string Image { get { return image; } set { image = value; } }

        public Pizza (string nam, double pr, string desc, string img)
        {
            name = nam;
            price = pr;
            description = desc;
            image = img;
        }

        public override string ToString()
        {
            return name;
        }
    }

    
}
