using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public delegate  int mydel(int x);
    public static class Transform 
    {
        public static int[] Map(this int[] ar,mydel mydel1 )
        {
           for(int i=0;i<ar.Length;i++)
           {
               ar[i]=mydel1(ar[i]);
           }
           return ar;
        }
    }
}
