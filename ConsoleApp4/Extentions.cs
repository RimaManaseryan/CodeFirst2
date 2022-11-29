using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public static class Extensions
    {
        public static bool IsIn(this object obj, params object[] strings)
           => strings.Where(s => s == obj).Any();
    }
}
