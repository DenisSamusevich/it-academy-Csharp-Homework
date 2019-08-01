using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    public class Develop : Employee
    {
        public int NumberPublicDevelop = 6;
        protected int NumberProtectedDevelop = 5;
        internal int NumberInternalDevelop = 5;
        private int NumberPrivateDevelop = 4;
        protected internal int NumberProtectedInternalDevelop = 3;
        private protected int NumberPrivateProtectedDevelop = 2;

        int Multiplication(int num)
        {
            num = NumberPublic;
            num = NumberProtected;
            num = NumberInternal;
            num = NumberPrivate; //this member is not available here
            num = NumberProtectedInternal;
            num = NumberPrivateProtected; 
            return num
        }
    }
}
