using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.CodeDom;
using System.Diagnostics;

namespace MathTools
{
    class High_Code
    {
        public static void High_Equal<T, U>(T t, U u) where T: class where U: class  
        {
            var val1 = (from v1 in t.GetType().GetMembers() where v1.MemberType == MemberTypes.Property select t.GetType().GetProperty(v1.Name)).ToList();
            var val2 = (from v1 in u.GetType().GetMembers() where v1.MemberType == MemberTypes.Property select u.GetType().GetProperty(v1.Name)).ToList();
            
        }
    }
}
