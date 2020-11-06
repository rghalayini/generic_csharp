using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Generics
{
    class Box<T>
    {
        int Count { get; }
         
        List<T> temp = new List<T>();   //we must define a new list in order to use it in the methods below

        public void Add(T element)
        {
            temp.Add(element);   //simply add an element to the list
        }

        public T Remove()
        {
            T final = temp[temp.Count - 1]; //we do this because we can't write emp[temp.Count-1] directly after the return
            temp.RemoveAt(temp.Count -1);  //remove the last element from the list
            return final;   //return the name of the element removed
            
        }
    }
}
