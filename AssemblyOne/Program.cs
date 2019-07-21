using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Employee Employee = new Employee();
            Develop Develop = new Develop();

            num = Employee.NumberPublic;
            num = Employee.NumberProtected; //this method is not available here as a Protected
            num = Employee.NumberInternal; 
            num = Employee.NumberPrivate; //this method is not available here as a Private
            num = Employee.NumberProtectedInternal;
            num = Employee.NumberPrivateProtected; //this method is not available here as a PrivateProtected

        }
    }
}
