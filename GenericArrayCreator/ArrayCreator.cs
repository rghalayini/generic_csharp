using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArrayCreator
{
    public class ArrayCreator
    {

        public static T[] Create<T>(int length, T item)
        {

            var temporary = new T[length];  //to overload the method, we must define a new T
            for (int i = 0; i < length; i++) //loop for the length and add the item
            {
                temporary[i]=item;
            }

            return temporary;  //return the temporary variable introduced before
        }
    }
}
