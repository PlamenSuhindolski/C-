using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses1
{
   public class Display
    {
       public double size;
       public uint numberOfColors;

       public Display(double Size, uint NumberOfColors)
       {
           this.size = Size;
           this.numberOfColors = NumberOfColors;
       }

       public double Size
       {
           get
           { return this.size; }
           set
           {
               if (value < 1)
               {
                   throw new ArgumentException("The size can't be under 1");
               }
               this.size = value;
           }
       }

       public uint NumberOfColors
       {
           get { return this.numberOfColors; }

           set { this.numberOfColors = value; }
       }
    }
}
