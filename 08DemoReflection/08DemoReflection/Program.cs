using System;
using System.Linq;
using System.Reflection;

namespace _00Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reference Added 
            string path = @"D:\Nashik03-04-2023\DOTNET\08DemoReflection\Calculator.DLL\bin\Debug\Calculator.DLL.dll";
            Assembly assembly = Assembly.LoadFrom(path);
            // Console.WriteLine(assembly.FullName);
            Type[] types = assembly.GetTypes();
            string methodSignature = null;
            for (int i = 0; i < types.Length; i++)
            {
                Type type = types[i];
                #region exploring differnt properties of type CMath.
                //Console.WriteLine("{0}, isPublic = {1}",type.Name,type.IsPublic.ToString());
                //Console.WriteLine("{0}, isSerializable = {1}",type.Name,type.IsSerializable.ToString());
                //Console.WriteLine(type.Name);
                //Console.WriteLine(type.FullName); 
                #endregion

                #region GetAttributes 
                //Attribute [] allAttributes = type.GetCustomAttributes().ToArray();

                //for(int j = 0; j < allAttributes.Length; j++) 
                //{
                //    Attribute attribute = allAttributes[j];
                //    //Console.WriteLine(attribute.GetType().ToString());
                //    if(attribute.GetType().ToString() == "System.SerializableAttribute")
                //    {
                //        Console.WriteLine("{0} is marked as {1}",type.Name, attribute.GetType().ToString());
                //    }
                //} 
                #endregion
                Console.WriteLine("--------------------------------------------");
                MethodInfo[] allMethods = type.GetMethods();
                for (int k = 0; k < allMethods.Length; k++)
                {
                    MethodInfo method = allMethods[k];
                    Console.WriteLine(method.Name);
                    methodSignature = method.ReturnType.ToString() + " " + method.Name + " ( ";
                    Console.WriteLine("--------------------------------------------");
                    ParameterInfo[] allParms = method.GetParameters();
                    for (int p = 0; p < allParms.Length; p++)
                    {
                        ParameterInfo param = allParms[p];
                        //Console.WriteLine("{0} is of type {1}",param.Name,param.ParameterType);

                        methodSignature = methodSignature + param.ParameterType + " " + param.Name + " ,";
                    }
                    methodSignature = methodSignature.TrimEnd(',');
                    methodSignature = methodSignature + " )";
                    Console.WriteLine(methodSignature);
                    Console.WriteLine("--------------------------------------------");
                }

            }
            // print on console - "int Add (int x,int y)"
            //Console.WriteLine(methodSignature);
            //Console.WriteLine("--------------------------------------------");
            Console.ReadLine();
        }
    }
}




