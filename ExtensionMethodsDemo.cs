using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public static class ExtensionMethodsDemo
    {
        public static int ToInt32(this string s)
        {
            int a;
            int.TryParse(s, out a);
            return a;
        }
    }
}
