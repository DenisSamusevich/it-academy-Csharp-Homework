using AssemblyOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyTwo
{
    public class ClassTest : Employee
    {
        public int NumberPublicClass = 6;
        protected int NumberProtectedClass = 5;
        internal int NumberInternalClass = 5;
        private int NumberPrivateClass = 4;
        protected internal int NumberProtectedInternalClass = 3;
        private protected int NumberPrivateProtectedClass = 2;

        int Multiplication(int num)
        {
            num = NumberPublic;  
            num = NumberProtected; 
            num = NumberInternal; //this member is not available here as a  Internal
            num = NumberPrivate; //this member is not available here as a  Private
            num = NumberProtectedInternal;
            num = NumberPrivateProtected; //this member is not available here as a PrivateProtected
            return num;
        }
    }
}
