using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    public class Employee
    {
        public const int NumberConstant = 10;
        public string Name = String.Empty;
        public bool Flag;
        public int NumberPublic = 6;
        protected int NumberProtected = 5;
        internal int NumberInternal = 5;
        private int NumberPrivate = 4;
        protected internal int NumberProtectedInternal = 3;
        private protected int NumberPrivateProtected = 2;


        int Multiplication(int num)
        {
            num = NumberPublic;
            num = NumberProtected;
            num = NumberInternal;
            num = NumberPrivate;
            num = NumberProtectedInternal;
            num = NumberPrivateProtected;
            return num;
        }
    }
}
