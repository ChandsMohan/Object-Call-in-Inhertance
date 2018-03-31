using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base_Class_And_Derive_Class
{
   public class Program
    {
        public void Method1()
        {
            string a = "Its a Base method";
            Console.WriteLine(a);
        }
    }
    public class DerivedClass:Program
    {
        public new void Method1()
        {
            string a = "Its a Derived Class";
            Console.WriteLine(a);
        }
    }
    public class ForMain
    {

        static void Main(string[] args)
        {
            DerivedClass DerivedClass_Obj = new DerivedClass();
            Program BaseClass_Obj = (Program)DerivedClass_Obj;
            BaseClass_Obj.Method1();
            //DerivedClass_Obj.Method1();
            //DerivedClass_Obj.Method2();
            Console.ReadKey();

        }
    }
}
