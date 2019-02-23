using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods_Delegates_Lambda_LINQ.Extensions
{
    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder stringBuilder, int index, int length)
        {
           StringBuilder newString = new StringBuilder(stringBuilder.ToString(index, length),stringBuilder.Capacity);
            return newString;
           
        }
    }
}
