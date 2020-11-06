using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace GenericConstraints
{
    public class Scale<T> where T : IComparable<T>
    {
        private T left;
        private T right;

        public Scale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public T GetHeavier()
        {
            if (this.left.CompareTo(this.right)>0)
            {
                return left;
            }
            else if (this.left.CompareTo(this.right)<0)
            {
                return right;
            }
            else
            {
                return default(T);
            }
        }
    }
}
