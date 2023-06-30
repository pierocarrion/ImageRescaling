using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageRescaling.Extensions
{
    public static class StringExtension
    {
        public static Int32 ToInt32(this string text)
        {
            if(Int32.TryParse(text, out int integer))
            {
                return integer;
            }
            throw new Exception("Cannot parse String to Int");
        }
    }
}
