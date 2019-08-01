using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyOne;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Employee Employee = new Employee();
            ClassTest ClassTest = new ClassTest();

            num = Employee.NumberPublic;
            num = Employee.NumberProtected; //this method is not available here as a Protected
            num = Employee.NumberInternal; //this method is not available here as a Internal
            num = Employee.NumberPrivate; //this method is not available here as a Private
            num = Employee.NumberProtectedInternal; //this method is not available here as a ProtectedInternal
            num = Employee.NumberPrivateProtected; //this method is not available here as a PrivateProtected

        }
    }
}
