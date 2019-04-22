using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionPracticalWork
{
    class Program
    {
        static void Main(string[] args)
        {

            //    foreach (var memberInfo in type.GetMembers())
            //    {
            //        if (memberInfo is MethodInfo)
            //        {
            //            Console.WriteLine($"{memberInfo.Name} {(memberInfo as MethodInfo).ReturnType}");
            //            //Console.WriteLine("----------");
            //            //method.Invoke(new , assembly);

            //            //object usingString = memberInfo.Invoke(String, new object[] { 100 });

            //            var asd = "asdasd";
            //            if (memberInfo.Name == "Substring")
            //            {
            //                Console.WriteLine("----------");
            //                //object obj = Activator.CreateInstance(type);

            //                //var method = type.GetMethod("Substring");
            //                MethodInfo mi = type.GetMethod("Substring", new Type[] { });

            //                mi.Invoke(asd, new object);
            //                Console.ReadLine();
            //                Console.WriteLine(asd);
            //            }
            //        }
            //    }

            //    Console.ReadLine();

            //}


            Type type = typeof(String);
            MethodInfo method = type.GetMethod("Substring", );
            string obj = "asdasd";
            obj = method.Name.Substring(2);
            Console.WriteLine(obj);
        }
    }
}
